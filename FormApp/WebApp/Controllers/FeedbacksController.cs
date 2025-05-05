using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookRentalObject;

namespace WebApp.Controllers
{
    public class FeedbacksController : Controller
    {
        private readonly BookRentalDBContext _context;

        public FeedbacksController(BookRentalDBContext context)
        {
            _context = context;
        }

        // GET: Feedbacks
        public async Task<IActionResult> Index()
        {
            var bookRentalDBContext = _context.Feedbacks
                .Include(f => f.Book)                          
                .Include(f => f.ReturnRecord)                   
                    .ThenInclude(r => r.Transaction)            
                    .ThenInclude(t => t.User);                  

            return View(await bookRentalDBContext.ToListAsync());
        }

        // GET: Feedbacks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Feedbacks == null)
            {
                return NotFound();
            }

            var feedback = await _context.Feedbacks
        .Include(f => f.Book)                          
        .Include(f => f.ReturnRecord)                   
            .ThenInclude(r => r.Transaction)            
            .ThenInclude(t => t.User)                  
        .FirstOrDefaultAsync(m => m.FeedbackId == id);
            if (feedback == null)
            {
                return NotFound();
            }

            return View(feedback);
        }

        // GET: Feedbacks/Create
        public IActionResult Create()
        {
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Isbn");
            ViewData["TransactionId"] = new SelectList(_context.RentalTransactions, "TransactionId", "TransactionId");
            return View();
        }

        // POST: Feedbacks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FeedbackId,Timestamp,Comment,TransactionId,Rate,BookId,IsHidden")] Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _context.Add(feedback);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Isbn", feedback.BookId);
            ViewData["TransactionId"] = new SelectList(
                _context.ReturnRecords.Select(r => r.Transaction).Distinct(),  // Select unique Transactions from ReturnRecords
                "TransactionId",           // The field you want to use for the option's value
                "TransactionId",           // The field you want to display in the select list
                feedback.ReturnRecord?.TransactionId // Set the selected value (if any) from the associated ReturnRecord's TransactionId
            );

            return View(feedback);
        }

        // GET: Feedbacks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Feedbacks == null)
            {
                return NotFound();
            }

            var feedback = await _context.Feedbacks.FindAsync(id);
            if (feedback == null)
            {
                return NotFound();
            }
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Isbn", feedback.BookId);
            // instead of TransactionId
            ViewData["ReturnRecordId"] = new SelectList(
                _context.ReturnRecords,
                "recordId",         
                "recordId",          
                feedback.ReturnRecordId  
            );

            return View(feedback);
        }

        // POST: Feedbacks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FeedbackId,Timestamp,Comment,TransactionId,Rate,BookId,IsHidden")] Feedback feedback)
        {
            if (id != feedback.FeedbackId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(feedback);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FeedbackExists(feedback.FeedbackId))
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
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Isbn", feedback.BookId);
            ViewData["ReturnRecordId"] = new SelectList(
                _context.ReturnRecords,
                "recordId",          // the PK of your Return Records table
                "recordId",          // what to display in the dropdown (you could swap this for some descriptive field)
                feedback.ReturnRecordId  // the current value, if any
            );
            return View(feedback);
        }

        // GET: Feedbacks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Feedbacks == null)
            {
                return NotFound();
            }

            var feedback = await _context.Feedbacks
                .Include(f => f.Book)
                .Include(f => f.ReturnRecord)
                .FirstOrDefaultAsync(m => m.FeedbackId == id);
            if (feedback == null)
            {
                return NotFound();
            }

            return View(feedback);
        }

        // POST: Feedbacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Feedbacks == null)
            {
                return Problem("Entity set 'BookRentalDBContext.Feedbacks'  is null.");
            }
            var feedback = await _context.Feedbacks.FindAsync(id);
            if (feedback != null)
            {
                _context.Feedbacks.Remove(feedback);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FeedbackExists(int id)
        {
          return (_context.Feedbacks?.Any(e => e.FeedbackId == id)).GetValueOrDefault();
        }

        [HttpPost]
        public async Task<IActionResult> ToggleVisibility(int feedbackId, bool isHidden)
        {
            var feedback = await _context.Feedbacks.FindAsync(feedbackId);
            if (feedback == null)
            {
                return NotFound();
            }

            feedback.IsHidden = isHidden;  // Toggle the visibility
            _context.Update(feedback);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
