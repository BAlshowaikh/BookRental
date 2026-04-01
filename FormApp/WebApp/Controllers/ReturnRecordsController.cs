using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookRentalObject;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing.Printing;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using Microsoft.AspNetCore.Identity;

namespace WebApp.Controllers
{
    public class ReturnRecordsController : Controller
    {
        private readonly BookRentalDBContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public ReturnRecordsController(BookRentalDBContext context, UserManager<IdentityUser> UserManager)
        {
            _context = context;
            _userManager = UserManager;
        }

        // GET: ReturnRecords
        [Authorize]
        public async Task<IActionResult> Index(string SearchString, string SearchCon, int page = 1, int pageSize = 9)
        {
            // Start with base query
            var bookRentalDBContext = _context.ReturnRecords
                .Include(r => r.Book)
                .Include(r => r.BookCondition)
                .Include(r => r.ExtraCharges)
                .Include(r => r.Transaction)
                .AsQueryable();

            // Get current user info
            var currentUserEmail = _userManager.GetUserName(User);
            var dbUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == currentUserEmail);
            ViewBag.CurrentUserId = dbUser?.UserId; // Store the int UserId

            // Filter for regular users
            if (User.IsInRole("User") && dbUser != null)
            {
                bookRentalDBContext = bookRentalDBContext.Where(x => x.Transaction.UserId == dbUser.UserId);
            }

            // Apply filters
            if (!string.IsNullOrEmpty(SearchString))
            {
                if (int.TryParse(SearchString, out int recordId))
                    bookRentalDBContext = bookRentalDBContext.Where(x => x.RecordId == recordId);
                else
                    ModelState.AddModelError("SearchString", "Please enter a valid numeric ID");
            }

            if (!string.IsNullOrEmpty(SearchCon))
            {
                bookRentalDBContext = bookRentalDBContext.Where(x =>
                    x.BookCondition != null &&
                    x.BookCondition.BookConditionId.ToString() == SearchCon);
            }

            // Get dropdown data
            ViewBag.conList = new SelectList(
                await _context.BookConditions.ToListAsync(),
                "BookConditionId",
                "ReturnCondition",
                SearchCon);

            // Pagination
            var totalRecords = await bookRentalDBContext.CountAsync();
            var records = await bookRentalDBContext
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            // Feedback status
            var feedbackStatus = new Dictionary<int, bool>();
            foreach (var record in records)
            {
                feedbackStatus[record.RecordId] = _context.Feedbacks
                    .Any(f => f.ReturnRecordId == record.RecordId);
            }
            ViewBag.FeedbackStatus = feedbackStatus;

            ViewBag.TotalPages = (int)Math.Ceiling(totalRecords / (double)pageSize);
            ViewBag.CurrentPage = page;

            return View(records);
        }

        // GET: ReturnRecords/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ReturnRecords == null)
            {
                return NotFound();
            }

            var returnRecord = await _context.ReturnRecords
                .Include(r => r.Book)
                .Include(r => r.BookCondition)
                .Include(r => r.ExtraCharges)
                .Include(r => r.Transaction)
                .FirstOrDefaultAsync(m => m.RecordId == id);
            if (returnRecord == null)
            {
                return NotFound();
            }

            return View(returnRecord);
        }

        // GET: ReturnRecords/Create
        [Authorize(Roles = "Admin, Manager")]
        public IActionResult Create(int id)
        {
            var transaction = _context.RentalTransactions
                .Include(t => t.Book)
                .FirstOrDefault(t => t.TransactionId == id);

            if (transaction == null)
            {
                return NotFound();
            }

            // Exclude "Not Returned" (assuming ID = 1)
            ViewData["BookConditionId"] = new SelectList(
                _context.BookConditions.Where(x => x.BookConditionId != 1),
                "BookConditionId",
                "ReturnCondition"
            );

            ViewData["TransactionId"] = id;
            ViewData["BookId"] = transaction.BookId;
            ViewData["ExpectedDate"] = transaction.ReturnDate;

            // Map BookConditionId to ExtraChargesId
            var chargeMap = new Dictionary<int, int?>
    {
        { 2, null }, // Good condition – no extra charges
        { 3, 1 },    // Damaged
        { 4, 3 },    // Poor
        { 5, 2 }     // Lost
    };

            // Fetch all extra charges into dictionary
            var charges = _context.ExtraCharges
                .ToDictionary(e => e.ExtraChargesId, e => (double)e.ExtraChargeRate);

            var conditionToRate = chargeMap.ToDictionary(
                pair => pair.Key,
                pair => pair.Value.HasValue && charges.ContainsKey(pair.Value.Value)
                    ? charges[pair.Value.Value]
                    : 0.0 // Default rate for null or invalid ID
            );

            ViewData["ChargeRates"] = conditionToRate;

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Manager")]
        public async Task<IActionResult> Create([Bind("RecordId,ExpectedReturnDate,ActualReturnDate,TotalAdditionalCharges,LateReturnFee,BookId,BookConditionId,TransactionId,ExtraChargesId")] ReturnRecord returnRecord)
        {
            var transaction = await _context.RentalTransactions
                .FirstOrDefaultAsync(t => t.TransactionId == returnRecord.TransactionId);

            if (transaction == null)
            {
                return NotFound("Transaction not found.");
            }

            // Ensure the book exists and update its availability
            var book = await _context.Books.FindAsync(transaction.BookId);
            if (book == null)
            {
                return NotFound("Book not found.");
            }

            // Update book availability to "Available" (assuming ID = 1)
            book.AvailabilityStatusId = 1;

            // Update book condition based on the selected return condition
            if (returnRecord.BookConditionId != null)
            {
                book.BookConditionId = returnRecord.BookConditionId;
            }

            if (returnRecord.ActualReturnDate == default)
            {
                ModelState.AddModelError("ActualReturnDate", "Actual return date is required.");
            }

            // Map BookConditionId to ExtraChargesId
            var chargeMap = new Dictionary<int, int?>
            {
                { 2, null }, // Good condition – no extra charges
                { 3, 1 },    // Damaged
                { 4, 3 },    // Poor
                { 5, 2 }     // Lost
            };

            if (chargeMap.ContainsKey(returnRecord.BookConditionId))
            {
                returnRecord.ExtraChargesId = chargeMap[returnRecord.BookConditionId];
            }

            if (ModelState.IsValid)
            {
                transaction.IsReturned = true;
                book.AvailabilityStatusId = 1;
                // Create a notification for the user
                Notification notif = new Notification
                {
                    Subject = "Return record has been created",
                    Message = $"Your return record for transaction ID: {returnRecord.TransactionId} has been generated. Please give feedback on your book.",
                    UserId = transaction.UserId,
                    Status = false
                };

                _context.Notifications.Add(notif);
                _context.Add(returnRecord);
                _context.RentalTransactions.Update(transaction);
                _context.Books.Update(book);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            // If ModelState is invalid, repopulate dropdowns
            ViewData["BookConditionId"] = new SelectList(
                _context.BookConditions.Where(x => x.BookConditionId != 1),
                "BookConditionId",
                "ReturnCondition",
                returnRecord.BookConditionId
            );

            ViewData["BookId"] = returnRecord.BookId;
            ViewData["ExpectedDate"] = returnRecord.ExpectedReturnDate;

            var allCharges = await _context.ExtraCharges.ToDictionaryAsync(e => e.ExtraChargesId, e => (double)e.ExtraChargeRate);

            ViewData["ChargeRates"] = chargeMap.ToDictionary(
                pair => pair.Key,
                pair => pair.Value.HasValue && allCharges.ContainsKey(pair.Value.Value)
                    ? allCharges[pair.Value.Value]
                    : 0.0
            );

            return View(returnRecord);
        }

        // GET: ReturnRecords/Edit/5
        // Only admin and manager can edit the return record
        [Authorize(Roles = "Admin, Manager")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ReturnRecords == null)
            {
                return NotFound();
            }

            var returnRecord = await _context.ReturnRecords.FindAsync(id);
            if (returnRecord == null)
            {
                return NotFound();
            }
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Isbn", returnRecord.BookId);
            ViewData["BookConditionId"] = new SelectList(_context.BookConditions, "BookConditionId", "ReturnCondition", returnRecord.BookConditionId);
            ViewData["ExtraChargesId"] = new SelectList(_context.ExtraCharges, "ExtraChargesId", "ExtraChargeName", returnRecord.ExtraChargesId);
            ViewData["TransactionId"] = new SelectList(_context.RentalTransactions, "TransactionId", "TransactionId", returnRecord.TransactionId);
            return View(returnRecord);
        }

        // POST: ReturnRecords/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        // Only admin and manager can edit the return record
        [Authorize(Roles = "Admin, Manager")]
        public async Task<IActionResult> Edit(int id, [Bind("RecordId,ExpectedReturnDate,ActualReturnDate,TotalAdditionalCharges,LateReturnFee,BookId,BookConditionId,TransactionId,ExtraChargesId")] ReturnRecord returnRecord)
        {
            if (id != returnRecord.RecordId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(returnRecord);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReturnRecordExists(returnRecord.RecordId))
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
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Isbn", returnRecord.BookId);
            ViewData["BookConditionId"] = new SelectList(_context.BookConditions, "BookConditionId", "ReturnCondition", returnRecord.BookConditionId);
            ViewData["ExtraChargesId"] = new SelectList(_context.ExtraCharges, "ExtraChargesId", "ExtraChargeName", returnRecord.ExtraChargesId);
            ViewData["TransactionId"] = new SelectList(_context.RentalTransactions, "TransactionId", "TransactionId", returnRecord.TransactionId);
            return View(returnRecord);
        }

        // GET: ReturnRecords/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ReturnRecords == null)
            {
                return NotFound();
            }

            var returnRecord = await _context.ReturnRecords
                .Include(r => r.Book)
                .Include(r => r.BookCondition)
                .Include(r => r.ExtraCharges)
                .Include(r => r.Transaction)
                .FirstOrDefaultAsync(m => m.RecordId == id);
            if (returnRecord == null)
            {
                return NotFound();
            }

            return View(returnRecord);
        }

        // POST: ReturnRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ReturnRecords == null)
            {
                return Problem("Entity set 'BookRentalDBContext.ReturnRecords'  is null.");
            }
            var returnRecord = await _context.ReturnRecords.FindAsync(id);
            if (returnRecord != null)
            {
                _context.ReturnRecords.Remove(returnRecord);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReturnRecordExists(int id)
        {
          return (_context.ReturnRecords?.Any(e => e.RecordId == id)).GetValueOrDefault();
        }
    }
}
