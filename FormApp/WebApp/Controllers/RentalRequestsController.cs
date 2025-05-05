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

namespace WebApp.Controllers
{
    public class RentalRequestsController : Controller
    {
        private readonly BookRentalDBContext _context;

        public RentalRequestsController(BookRentalDBContext context)
        {
            _context = context;
        }

        // GET: RentalRequests
        public async Task<IActionResult> Index()
        {
            var bookRentalDBContext = _context.RentalRequests.Include(r => r.Book).Include(r => r.RentalRequestStatus).Include(r => r.User);
            return View(await bookRentalDBContext.ToListAsync());
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
        public async Task<IActionResult> Create([Bind("RequestId,UserId,RentalRequestStatusId,BookId,RentalStartDate,TotalCost,ReturnDate")] RentalRequest rentalRequest)
        {
            // Server-side validation: ensure rental period does not exceed 30 days
            if ((rentalRequest.ReturnDate - rentalRequest.RentalStartDate).TotalDays > 30)
            {
                TempData["ErrorMessage"] = ("", "Rental period should not exceed 30 days.");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(rentalRequest);
                    await _context.SaveChangesAsync();
                    ViewBag.EditedBookId = rentalRequest.RequestId;
                    TempData["SuccessMessage"] = "Rental request submitted successfully!";
                    //return View(rentalRequest);
                }
                catch (Exception)
                {
                    TempData["ErrorMessage"] = "An error occurred while saving the rental request.";
                }
            }
            else
            {
                TempData["ErrorMessage"] = "Please correct the errors and try again.";
            }

            // Ensure that necessary data is repopulated in the ViewBag for the form
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

            var rentalRequest = await _context.RentalRequests.FindAsync(id);
            if (rentalRequest == null)
            {
                return NotFound();
            }
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Isbn", rentalRequest.BookId);
            ViewData["RentalRequestStatusId"] = new SelectList(_context.RentalRequestStatuses, "RentalRequestStatusId", "Status", rentalRequest.RentalRequestStatusId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName", rentalRequest.UserId);
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
                    _context.Update(rentalRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentalRequestExists(rentalRequest.RequestId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Isbn", rentalRequest.BookId);
            ViewData["RentalRequestStatusId"] = new SelectList(_context.RentalRequestStatuses, "RentalRequestStatusId", "Status", rentalRequest.RentalRequestStatusId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName", rentalRequest.UserId);
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
                .Include(r => r.Book)
                .FirstOrDefaultAsync(r => r.RequestId == id);

            if (request == null)
            {
                TempData["ErrorMessage"] = "Request not found.";
                return RedirectToAction("Index");
            }

            // Update rental request status to Approved (2)
            request.RentalRequestStatusId = 2;

            // Update book availability status to Rented (2)
            request.Book.AvailabilityStatusId = 2;

            await _context.SaveChangesAsync();
            TempData["SuccessMessage"] = "Request approved successfully.";

            // Redirect to Create with route values
            return RedirectToAction("Create", "RentalTransactions", new
            {
                rentalRequestId = request.RequestId,
                bookId = request.BookId,
                userId = request.UserId,
                rentalStartDate = request.RentalStartDate.ToString("yyyy-MM-dd"),
                returnDate = request.ReturnDate.ToString("yyyy-MM-dd"),
                totalCost = request.TotalCost
            });
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

            // Set status to Rejected (3)
            request.RentalRequestStatusId = 3;

            await _context.SaveChangesAsync();

            // Optionally redirect to index or details
            return View("Index"); 
        }
    }
} 
