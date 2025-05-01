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
    public class RentalTransactionsController : Controller
    {
        private readonly BookRentalDBContext _context;

        public RentalTransactionsController(BookRentalDBContext context)
        {
            _context = context;
        }

        // GET: RentalTransactions
        public async Task<IActionResult> Index()
        {
            var bookRentalDBContext = _context.RentalTransactions.Include(r => r.Book).Include(r => r.PaymentMethod).Include(r => r.PaymentStatus).Include(r => r.User);
            return View(await bookRentalDBContext.ToListAsync());
        }

        // GET: RentalTransactions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RentalTransactions == null)
            {
                return NotFound();
            }

            var rentalTransaction = await _context.RentalTransactions
                .Include(r => r.Book)
                .Include(r => r.PaymentMethod)
                .Include(r => r.PaymentStatus)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.TransactionId == id);
            if (rentalTransaction == null)
            {
                return NotFound();
            }

            return View(rentalTransaction);
        }

        // GET: RentalTransactions/Create
        public IActionResult Create()
        {
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Isbn");
            ViewData["PaymentMethodId"] = new SelectList(_context.PaymentMethods, "PaymentMethodId", "PaymentMethod1");
            ViewData["PaymentStatusId"] = new SelectList(_context.PaymentStatuses, "PaymentId", "PaymentStatus1");
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName");
            return View();
        }

        // POST: RentalTransactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransactionId,BookId,UserId,RentalStartDate,ReturnDate,RentalFee,PaymentMethodId,PaymentStatusId,RentalPeriod,IsReturned,RentalRequestId")] RentalTransaction rentalTransaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rentalTransaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Isbn", rentalTransaction.BookId);
            ViewData["PaymentMethodId"] = new SelectList(_context.PaymentMethods, "PaymentMethodId", "PaymentMethod1", rentalTransaction.PaymentMethodId);
            ViewData["PaymentStatusId"] = new SelectList(_context.PaymentStatuses, "PaymentId", "PaymentStatus1", rentalTransaction.PaymentStatusId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName", rentalTransaction.UserId);
            return View(rentalTransaction);
        }

        // GET: RentalTransactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RentalTransactions == null)
            {
                return NotFound();
            }

            var rentalTransaction = await _context.RentalTransactions.FindAsync(id);
            if (rentalTransaction == null)
            {
                return NotFound();
            }
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Isbn", rentalTransaction.BookId);
            ViewData["PaymentMethodId"] = new SelectList(_context.PaymentMethods, "PaymentMethodId", "PaymentMethod1", rentalTransaction.PaymentMethodId);
            ViewData["PaymentStatusId"] = new SelectList(_context.PaymentStatuses, "PaymentId", "PaymentStatus1", rentalTransaction.PaymentStatusId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName", rentalTransaction.UserId);
            return View(rentalTransaction);
        }

        // POST: RentalTransactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransactionId,BookId,UserId,RentalStartDate,ReturnDate,RentalFee,PaymentMethodId,PaymentStatusId,RentalPeriod,IsReturned,RentalRequestId")] RentalTransaction rentalTransaction)
        {
            if (id != rentalTransaction.TransactionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rentalTransaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentalTransactionExists(rentalTransaction.TransactionId))
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
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "Isbn", rentalTransaction.BookId);
            ViewData["PaymentMethodId"] = new SelectList(_context.PaymentMethods, "PaymentMethodId", "PaymentMethod1", rentalTransaction.PaymentMethodId);
            ViewData["PaymentStatusId"] = new SelectList(_context.PaymentStatuses, "PaymentId", "PaymentStatus1", rentalTransaction.PaymentStatusId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName", rentalTransaction.UserId);
            return View(rentalTransaction);
        }

        // GET: RentalTransactions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RentalTransactions == null)
            {
                return NotFound();
            }

            var rentalTransaction = await _context.RentalTransactions
                .Include(r => r.Book)
                .Include(r => r.PaymentMethod)
                .Include(r => r.PaymentStatus)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.TransactionId == id);
            if (rentalTransaction == null)
            {
                return NotFound();
            }

            return View(rentalTransaction);
        }

        // POST: RentalTransactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RentalTransactions == null)
            {
                return Problem("Entity set 'BookRentalDBContext.RentalTransactions'  is null.");
            }
            var rentalTransaction = await _context.RentalTransactions.FindAsync(id);
            if (rentalTransaction != null)
            {
                _context.RentalTransactions.Remove(rentalTransaction);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentalTransactionExists(int id)
        {
          return (_context.RentalTransactions?.Any(e => e.TransactionId == id)).GetValueOrDefault();
        }
    }
}
