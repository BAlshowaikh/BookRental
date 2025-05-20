using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookRentalObject;
using System.Net;
using System.Text.Json;
using WebApp.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;



namespace WebApp.Controllers
{
    public class RentalRequestsController : Controller
    {
        private readonly BookRentalDBContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public RentalRequestsController(BookRentalDBContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: RentalRequests
        public async Task<IActionResult> Index(int? searchRequestId, int? searchStatusId, int page = 1)
        {
            int pageSize = 12;

            var query = _context.RentalRequests
                .Include(r => r.User)
                .Include(r => r.Book)
                .Include(r => r.RentalRequestStatus)
                .AsQueryable();

            if (searchRequestId.HasValue && searchRequestId.Value > 0)
            {
                query = query.Where(r => r.RequestId == searchRequestId.Value);
            }

            if (searchStatusId.HasValue && searchStatusId.Value > 0)
            {
                query = query.Where(r => r.RentalRequestStatusId == searchStatusId.Value);
            }

            int totalItems = await query.CountAsync();

            query = query.OrderBy(r => r.RequestId); 

            var items = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize);
            ViewBag.StatusList = new SelectList(_context.RentalRequestStatuses, "RentalRequestStatusId", "Status");

            return View(items);
        }



        // GET: RentalRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RentalRequests == null)
            {
                return NotFound();
            }

            var rentalRequest = await _context.RentalRequests
                .Include(r => r.Book)
                .Include(r => r.RentalRequestStatus)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.RequestId == id);
            if (rentalRequest == null)
            {
                return NotFound();
            }

            return View(rentalRequest);
        }

        // GET: RentalRequests/Create
        // Only User (customer) can create a rental request
        [Authorize(Roles = "User")]
        public IActionResult Create(int? bookId)
        {
            if (bookId == null)
            {
                return NotFound();
            }

            var book = _context.Books.FirstOrDefault(b => b.BookId == bookId);
            if (book == null)
            {
                return NotFound();
            }

            // var currentUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
            //ViewBag.UserFullName = currentUser?.FirstName + " " + currentUser?.LastName;

            ViewBag.BookId = book.BookId;
            ViewBag.BookName = book.Name;
            ViewBag.RentalPrice = book.RentalPrice;
            ViewBag.RentalRequestStatus = "Pending";
            var rentedDates = _context.RentalTransactions
                    .Where(rt => rt.BookId == bookId)
                    .Select(rt => new { rt.RentalStartDate, rt.ReturnDate })
                    .ToList();

            ViewBag.RentedRanges = JsonSerializer.Serialize(rentedDates);

            return View();
        }

        // POST: RentalRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        // POST: RentalRequests/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        // Only User (customer) can create a rental request
        [Authorize(Roles = "User")]
        public async Task<IActionResult> Create([Bind("RequestId,UserId,RentalRequestStatusId,BookId,RentalStartDate,TotalCost,ReturnDate")] RentalRequest rentalRequest, IFormFile uploadedFile)
        {
            if ((rentalRequest.ReturnDate - rentalRequest.RentalStartDate).TotalDays > 30)
            {
                TempData["ErrorMessage"] = "Rental period should not exceed 30 days.";
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(rentalRequest);
                    await _context.SaveChangesAsync(); // Save first to get RentalRequestId

                    // Handle document upload
                    if (uploadedFile != null && uploadedFile.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await uploadedFile.CopyToAsync(memoryStream);
                            var document = new Document
                            {
                                UploadDate = DateTime.UtcNow,
                                Blob = memoryStream.ToArray(),
                                RentalRequestId = rentalRequest.RequestId,                                                                           
                            };

                            _context.Documents.Add(document);
                        }
                    }

                    // Add notification
                    var statusName = await _context.RentalRequestStatuses
                        .Where(s => s.RentalRequestStatusId == rentalRequest.RentalRequestStatusId)
                        .Select(s => s.Status)
                        .FirstOrDefaultAsync();

                    var notification = new Notification
                    {
                        UserId = rentalRequest.UserId,
                        Subject = "Rental Request Submitted",
                        Message = $"Your rental request has been submitted. Status: {statusName}.",
                        Status = false
                    };

                    _context.Notifications.Add(notification);
                    await _context.SaveChangesAsync();

                    TempData["SuccessMessage"] = "Rental request submitted successfully!";
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    TempData["ErrorMessage"] = "An error occurred while saving the rental request.";

                    var user = await _userManager.GetUserAsync(User);
                    var email = await _userManager.GetEmailAsync(user);

                    var newLog = new Log 
                    {
                        UserId = _context.Users.Where(x=> x.Email == email).FirstOrDefault().UserId,
                        Timestamp = DateTime.Now,
                        AffectedData = "rental request",
                        Source = "web app",
                        Exceptions = "Error: " + ex.Message
                    };

                    _context.Logs.Add(newLog);
                    await _context.SaveChangesAsync();
                }
            }

            // Repopulate view data if model state invalid
            var book = _context.Books.Find(rentalRequest.BookId);
            ViewBag.BookId = book?.BookId;
            ViewBag.BookName = book?.Name;
            ViewBag.RentalPrice = book?.RentalPrice;
            ViewBag.RentalRequestStatus = "Pending";

            return View(rentalRequest);
        }



        // GET: RentalRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RentalRequests == null)
            {
                return NotFound();
            }

            var rentalRequest = await _context.RentalRequests
                .Include(r => r.Book)
                .Include(r => r.User)
                .Include(r => r.RentalRequestStatus)
                .Include(r => r.Documents)
                .FirstOrDefaultAsync(r => r.RequestId == id);

            if (rentalRequest == null)
            {
                return NotFound();
            }

            ViewBag.BookName = rentalRequest.Book?.Name ?? "Unknown Book";
            ViewBag.UserFullName = rentalRequest.User?.FullName ?? "Unknown User";
            ViewBag.RentalRequestStatus = rentalRequest.RentalRequestStatus?.Status ?? "Unknown Status";
            ViewBag.BookId = rentalRequest.BookId;
            ViewBag.RentalPrice = rentalRequest.Book?.RentalPrice ?? 0;
            ViewBag.RentedRanges = Newtonsoft.Json.JsonConvert.SerializeObject(await _context.RentalRequests
                .Where(r => r.BookId == rentalRequest.BookId && r.RequestId != rentalRequest.RequestId)
                .Select(r => new { r.RentalStartDate, r.ReturnDate })
                .ToListAsync());

            return View(rentalRequest);
        }

        // POST: RentalRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RequestId,UserId,RentalRequestStatusId,BookId,RentalStartDate,TotalCost,ReturnDate")] RentalRequest rentalRequest)
        {
            if (id != rentalRequest.RequestId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var original = await _context.RentalRequests
    .AsNoTracking()
    .FirstOrDefaultAsync(r => r.RequestId == id);

                    _context.Update(rentalRequest);
                    await _context.SaveChangesAsync();

                    // Compare and build audit entry
                    var changes = new List<string>();
                    var oldValues = new List<string>();
                    var newValues = new List<string>();

                    if (original.RentalRequestStatusId != rentalRequest.RentalRequestStatusId)
                    {
                        changes.Add("Status");
                        oldValues.Add($"Status: {original.RentalRequestStatusId}");
                        newValues.Add($"Status: {rentalRequest.RentalRequestStatusId}");
                    }
                    if (original.RentalStartDate != rentalRequest.RentalStartDate)
                    {
                        changes.Add("StartDate");
                        oldValues.Add($"Start: {original.RentalStartDate:yyyy-MM-dd}");
                        newValues.Add($"Start: {rentalRequest.RentalStartDate:yyyy-MM-dd}");
                    }
                    if (original.ReturnDate != rentalRequest.ReturnDate)
                    {
                        changes.Add("ReturnDate");
                        oldValues.Add($"Return: {original.ReturnDate:yyyy-MM-dd}");
                        newValues.Add($"Return: {rentalRequest.ReturnDate:yyyy-MM-dd}");
                    }
                    if (original.TotalCost != rentalRequest.TotalCost)
                    {
                        changes.Add("TotalCost");
                        oldValues.Add($"Cost: {original.TotalCost}");
                        newValues.Add($"Cost: {rentalRequest.TotalCost}");
                    }

                    if (changes.Any())
                    {
                        var audit = new AuditTrail
                        {
                            Timestamp = DateTime.Now,
                            UserId = rentalRequest.UserId,
                            OldValue = string.Join("; ", oldValues),
                            NewValue = string.Join("; ", newValues)
                        };

                        _context.AuditTrails.Add(audit);
                        await _context.SaveChangesAsync();
                    }

                    TempData["SuccessMessage"] = "Rental request updated successfully!";
                    return RedirectToAction(nameof(Edit), new { id = rentalRequest.RequestId });
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    TempData["ErrorMessage"] = "An error occurred while editing the rental request.";

                    var user = await _userManager.GetUserAsync(User);
                    var email = await _userManager.GetEmailAsync(user);

                    var newLog = new Log
                    {
                        UserId = _context.Users.Where(x => x.Email == email).FirstOrDefault().UserId,
                        Timestamp = DateTime.Now,
                        AffectedData = "rental request",
                        Source = "web app",
                        Exceptions = "Error: " + ex.Message
                    };

                    _context.Logs.Add(newLog);
                    await _context.SaveChangesAsync();
                }
            }
            else
            {
                TempData["ErrorMessage"] = "Please correct the errors and try again.";
            }
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Name", rentalRequest.BookId);
            ViewData["RentalRequestStatusId"] = new SelectList(_context.RentalRequestStatuses, "RentalRequestStatusId", "Status", rentalRequest.RentalRequestStatusId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FullName", rentalRequest.UserId);
            return View(rentalRequest);
        }

        // GET: RentalRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RentalRequests == null)
            {
                return NotFound();
            }

            var rentalRequest = await _context.RentalRequests
                .Include(r => r.Book)
                .Include(r => r.RentalRequestStatus)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.RequestId == id);
            if (rentalRequest == null)
            {
                return NotFound();
            }

            return View(rentalRequest);
        }

        // POST: RentalRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RentalRequests == null)
            {
                return Problem("Entity set 'BookRentalDBContext.RentalRequests'  is null.");
            }
            var rentalRequest = await _context.RentalRequests.FindAsync(id);
            if (rentalRequest != null)
            {
                _context.RentalRequests.Remove(rentalRequest);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentalRequestExists(int id)
        {
            return (_context.RentalRequests?.Any(e => e.RequestId == id)).GetValueOrDefault();
        }

        // In case the "Approve" button is clicked
        [HttpPost]
        public async Task<IActionResult> Approve(int id)
        {
            var request = await _context.RentalRequests
                .Include(r => r.Book).Include(x => x.User)
                .FirstOrDefaultAsync(r => r.RequestId == id);

            if (request == null)
            {
                TempData["ErrorMessage"] = "Request not found.";
                return RedirectToAction("Index");
            }

            var originalStatus = request.RentalRequestStatusId;
            var originalBookStatus = request.Book.AvailabilityStatusId;

            // Update rental request status to Approved (2)
            request.RentalRequestStatusId = 2;

            // Update book availability status to Rented (2)
            request.Book.AvailabilityStatusId = 2;

			TempData["ApproveSuccess"] = "Request approved successfully! You will be redirected to the Rental Transaction page.";

			TempData["RedirectData"] = JsonSerializer.Serialize(new
			{
				bookId = request.BookId,
				userId = request.UserId,
				rentalStartDate = request.RentalStartDate.ToString("yyyy-MM-dd"),
				returnDate = request.ReturnDate.ToString("yyyy-MM-dd"),
				totalCost = request.TotalCost
			});

			var rentalTransaction = new RentalTransaction
			{
				RentalRequestId = request.RequestId,
				BookId = request.BookId,
				UserId = request.UserId,
				RentalStartDate = request.RentalStartDate,
				ReturnDate = request.ReturnDate,
				RentalPeriod = (request.ReturnDate - request.RentalStartDate).Days,
				RentalFee = request.TotalCost,
				PaymentMethodId = 3,
				PaymentStatusId = 2
			};

			_context.RentalTransactions.Add(rentalTransaction);

            var statusName = await _context.RentalRequestStatuses
            .Where(s => s.RentalRequestStatusId == request.RentalRequestStatusId)
            .Select(s => s.Status)
            .FirstOrDefaultAsync();

            var notification = new Notification
            {
                UserId = request.UserId,
                Subject = "Rental Request Update",
                Message = $"Your rental request status has been updated to: {statusName}.",
                Status = false
            };

            _context.Notifications.Add(notification);

            await _context.SaveChangesAsync();

            // AUDIT TRAIL for Approve
            var audit = new AuditTrail
            {
                Timestamp = DateTime.Now,
                UserId = request.UserId,
                OldValue = $"Request Status: {originalStatus}, Book Status: {originalBookStatus}",
                NewValue = $"Request Status: {request.RentalRequestStatusId} (Approved), Book Status: {request.Book.AvailabilityStatusId} (Rented)"
            };

            _context.AuditTrails.Add(audit);
            await _context.SaveChangesAsync();


            return RedirectToAction("Index");
		}

        // In case the "Reject" button is clicked
        [HttpPost]
        public async Task<IActionResult> Reject(int id)
        {
            var request = await _context.RentalRequests.FindAsync(id);

            if (request == null)
            {
                TempData["ErrorMessage"] = "Request not found.";
                return View();
            }

            var originalStatus = request.RentalRequestStatusId;

            // Set status to Rejected (3)
            request.RentalRequestStatusId = 3;

            TempData["RejectSuccess"] = "Request rejected successfully.";

            var statusName = await _context.RentalRequestStatuses
           .Where(s => s.RentalRequestStatusId == request.RentalRequestStatusId)
           .Select(s => s.Status)
           .FirstOrDefaultAsync();

            var notification = new Notification
            {
                UserId = request.UserId,
                Subject = "Rental Request Update",
                Message = $"Your rental request status has been updated to: {statusName}.",
                Status = false
            };

            _context.Notifications.Add(notification);

            await _context.SaveChangesAsync();
            // AUDIT TRAIL for Reject
            var audit = new AuditTrail
            {
                Timestamp = DateTime.Now,
                UserId = request.UserId,
                OldValue = $"Request Status: {originalStatus}",
                NewValue = $"Request Status: {request.RentalRequestStatusId} (Rejected)"
            };

            _context.AuditTrails.Add(audit);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        // Function to retrive the documnet and display it
        public async Task<IActionResult> DownloadDocument(int id)
        {
            try
            {
                var document = await _context.Documents.Where(d => d.RentalRequestId == id).FirstOrDefaultAsync();
                if (document == null)
                    return NotFound("Document not found.");

                var rentalRequestId = document.RentalRequestId;

                return File(document.Blob, "application/octet-stream", $"RentalRequest_{rentalRequestId}.pdf");
            }
            catch (Exception ex)
            {
                // Log the exception if needed
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        // Function to delete the dosumnet
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteDocument(int id)
        {
            try
            {
                var document = await _context.Documents
                    .FirstOrDefaultAsync(d => d.RentalRequestId == id);

                if (document == null)
                    return NotFound("Document not found.");

                _context.Documents.Remove(document);
                await _context.SaveChangesAsync();

                return Ok(); // AJAX handles the response
            }
            catch
            {
                return StatusCode(500, "Internal server error.");
            }
        }

        // Function to upload a documnet for Manager
        [HttpPost]
        public async Task<IActionResult> UploadDocument(int RentalRequestId, IFormFile Document)
        {
            try
            {
                if (Document == null || Document.Length == 0)
                    return Ok(new { success = false, message = "Please select a file to upload." });

                if (Path.GetExtension(Document.FileName).ToLower() != ".pdf")
                    return Ok(new { success = false, message = "Only PDF files are allowed." });

                var rentalRequest = await _context.RentalRequests
                    .FirstOrDefaultAsync(r => r.RequestId == RentalRequestId);

                if (rentalRequest == null)
                    return Ok(new { success = false, message = "Rental request not found." });

                var existingDoc = await _context.Documents
                    .FirstOrDefaultAsync(d => d.RentalRequestId == RentalRequestId);

                using var memoryStream = new MemoryStream();
                await Document.CopyToAsync(memoryStream);

                if (existingDoc != null)
                {
                    existingDoc.Blob = memoryStream.ToArray();
                    existingDoc.UploadDate = DateTime.UtcNow;
                }
                else
                {
                    var newDocument = new Document
                    {
                        RentalRequestId = RentalRequestId,
                        UploadDate = DateTime.UtcNow,
                        Blob = memoryStream.ToArray()
                    };
                    _context.Documents.Add(newDocument);
                }

                await _context.SaveChangesAsync();
                return Ok(new { success = true, message = "Document updated successfully." });
            }
            catch
            {
                return Ok(new { success = false, message = "An error occurred while uploading the document." });
            }
        }


    }
} 
