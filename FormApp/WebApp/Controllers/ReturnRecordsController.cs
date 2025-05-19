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

namespace WebApp.Controllers
{
    public class ReturnRecordsController : Controller
    {
        private readonly BookRentalDBContext _context;

        public ReturnRecordsController(BookRentalDBContext context)
        {
            _context = context;
        }

        // GET: ReturnRecords
        public async Task<IActionResult> Index(string SearchString, string SearchCon, int page = 1, int pageSize = 9)
        {
            // Start with base query including all relationships
            var bookRentalDBContext = _context.ReturnRecords
                .Include(r => r.Book)
                .Include(r => r.BookCondition)
                .Include(r => r.ExtraCharges)
                .Include(r => r.Transaction)
                .AsQueryable();

            // Apply Record ID filter
            if (!string.IsNullOrEmpty(SearchString))
            {
                if (int.TryParse(SearchString, out int recordId))
                {
                    bookRentalDBContext = bookRentalDBContext.Where(x => x.RecordId == recordId);
                }
                else
                {
                    ModelState.AddModelError("SearchString", "Please enter a valid numeric ID");
                }
            }

            // Apply Book Condition filter
            if (!string.IsNullOrEmpty(SearchCon))
            {
                bookRentalDBContext = bookRentalDBContext.Where(x => x.BookCondition != null &&
                                       x.BookCondition.BookConditionId.ToString() == SearchCon);
            }

            // Populate dropdown with current selection preserved
            ViewBag.conList = new SelectList(
                await _context.BookConditions.ToListAsync(),
                "BookConditionId",
                "ReturnCondition",
                SearchCon);

            // Total count before pagination
            var totalrecords = await bookRentalDBContext.CountAsync();

            // Apply pagination
            var records = await bookRentalDBContext
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            // Check feedback status for each record
            var feedbackStatus = new Dictionary<int, bool>();
            foreach (var record in records)
            {
                feedbackStatus[record.RecordId] = _context.Feedbacks
                    .Any(f => f.ReturnRecordId == record.RecordId);
            }
            ViewBag.FeedbackStatus = feedbackStatus;

            // Pass pagination data to view
            ViewBag.TotalPages = (int)Math.Ceiling(totalrecords / (double)pageSize);
            ViewBag.CurrentPage = page;


            return View(await bookRentalDBContext.ToListAsync());
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
        public IActionResult Create(int id)
        {
            var transaction = _context.RentalTransactions
            .Include(t => t.Book)
            .FirstOrDefault(t => t.TransactionId == id);

            ViewData["BookConditionId"] = new SelectList(_context.BookConditions.Where(x => x.BookConditionId != 1), "BookConditionId", "ReturnCondition");
            ViewData["TransactionId"] = id;
            ViewData["BookId"] = transaction.BookId;
            ViewData["ExpextedDate"] = transaction.ReturnDate;

            var chargeMap = new Dictionary<int, int>
            {
                { 2, 0 }, // Good > no charge
                { 3, 1 },
                { 4, 3 }, 
                { 5, 2 }  // Lost book id = 5 > loost book fee id = 2
            };

            var charges = _context.ExtraCharges
                .ToDictionary(e => e.ExtraChargesId, e => (double)e.ExtraChargeRate);

            var conditionToRate = chargeMap.ToDictionary(
                pair => pair.Key,
                pair => charges.ContainsKey(pair.Value) ? charges[pair.Value] : 0.0
            );
            ViewData["ChargeRates"] = conditionToRate;
            return View();
        }

        // POST: ReturnRecords/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RecordId,ExpectedReturnDate,ActualReturnDate,TotalAdditionalCharges,LateReturnFee,BookId,BookConditionId,TransactionId,ExtraChargesId")] ReturnRecord returnRecord)
        {
            // Get the original transaction details
            var transaction = await _context.RentalTransactions
                .FirstOrDefaultAsync(t => t.TransactionId == returnRecord.TransactionId);

            // Validate actual return date not in future
            if (returnRecord.ActualReturnDate > DateTime.Today)
            {
                ModelState.AddModelError("ActualReturnDate", "Actual return date cannot be in the future");
            }

            // Validate not more than 2 days before expected date
            if (returnRecord.ActualReturnDate < returnRecord.ExpectedReturnDate.AddDays(-2))
            {
                ModelState.AddModelError("ActualReturnDate", "Book cannot be returned more than 2 days before expected return date");
            }

            // Validate date is provided
            if (returnRecord.ActualReturnDate == default)
            {
                ModelState.AddModelError("ActualReturnDate", "Actual return date is required");
            }

            if (ModelState.IsValid)
            {
                Notification notif = new Notification
                {
                    Subject = "return record have been created",
                    Message = "Your return record for transaction ID:"+returnRecord.TransactionId+"have been generated, give feedback to your book",
                    UserId = transaction.UserId,
                    Status = false
                };

                _context.Notifications.Add(notif);
                _context.Add(returnRecord);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Repopulate view data if validation fails
            ViewData["BookConditionId"] = new SelectList(_context.BookConditions.Where(x => x.BookConditionId != 1), "BookConditionId", "ReturnCondition", returnRecord.BookConditionId);
            ViewData["BookId"] = returnRecord.BookId;
            ViewData["ExpextedDate"] = returnRecord.ExpectedReturnDate;

            // Recreate the charge rates dictionary
            var chargeMap = new Dictionary<int, int>
            {
                { 2, 0 }, // good, no extra charge
                { 3, 1 }, // damaged, damaged book fee
                { 4, 3 }, // poor, poor book fee
                { 5, 2 }  // lost, lost book fee
            };
            var charges = _context.ExtraCharges.ToDictionary(e => e.ExtraChargesId, e => (double)e.ExtraChargeRate);
            ViewData["ChargeRates"] = chargeMap.ToDictionary(
                pair => pair.Key,
                pair => charges.ContainsKey(pair.Value) ? charges[pair.Value] : 0.0
            );

            return View(returnRecord);
        }

        // GET: ReturnRecords/Edit/5
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
