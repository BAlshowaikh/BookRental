using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookRentalObject;
using System.Text.Json;
using WebApp.ViewModel;

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
        public async Task<IActionResult> Index(string SearchString, string SearchCustomer)
        {
            IQueryable<RentalTransaction> bookRentalDBContext = _context.RentalTransactions.Include(r => r.Book).Include(r => r.PaymentMethod).Include(r => r.PaymentStatus).Include(r => r.User).Where(x => x.User.UserRole.Role == "Customer");

            if (!String.IsNullOrEmpty(SearchString))
            {
                bookRentalDBContext = bookRentalDBContext.Where(x => x.TransactionId == Convert.ToInt32(SearchString));
            }

            if (!String.IsNullOrEmpty(SearchCustomer))
            {
                bookRentalDBContext = bookRentalDBContext.Where(x => x.User.UserId.ToString() == SearchCustomer);
            }

            //if (User.IsInRole("Customer"))
            //{
                var custList = new SelectList(_context.Users.Where(x => x.UserRole.Role == "Customer"), "UserId", "FullName", SearchString);
                ViewBag.CustList = custList;
            //}

            return View(bookRentalDBContext);
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

			ViewBag.PaymentMethodId = new SelectList(_context.PaymentMethods, "PaymentMethodId", "PaymentMethod1", rentalTransaction.PaymentMethodId);
			ViewBag.PaymentStatusId = new SelectList(_context.PaymentStatuses, "PaymentId", "PaymentStatus1", rentalTransaction.PaymentStatusId);
			return View(rentalTransaction);
        }

        // GET: RentalTransactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RentalTransactions == null)
            {
                return NotFound();
            }

            var rentalTransaction = await _context.RentalTransactions
                                            .Include(x => x.Book)
                                            .Include(x => x.User)
                                            .Include(x => x.PaymentMethod)
                                            .Include(x => x.PaymentStatus)
                                            .FirstOrDefaultAsync(x => x.TransactionId == id);
            
            if (rentalTransaction == null)
            {
                return NotFound();
            }

            RentalRedirectDataViewModel? redirectData = null;

            if (TempData["RedirectToTransaction"] != null)
            {
                var jsonString = TempData["RedirectToTransaction"]?.ToString();
                redirectData = JsonSerializer.Deserialize<RentalRedirectDataViewModel>(jsonString);

               // rentalTransaction.RentalStartDate = redirectData.RentalStartDate;
               // rentalTransaction.ReturnDate = redirectData.ReturnDate;
            }

            var selectedPaymentMethod = _context.RentalTransactions.Where(x => x.TransactionId == id).FirstOrDefault().PaymentMethod.PaymentMethod1;
            var selectedPaymentStatus = _context.RentalTransactions.Where(x => x.TransactionId == id).FirstOrDefault().PaymentStatus.PaymentStatus1;

			ViewBag.PaymentMethodId = new SelectList(_context.PaymentMethods, "PaymentMethodId", "PaymentMethod1", rentalTransaction.PaymentMethodId);
			ViewBag.PaymentStatusId = new SelectList(_context.PaymentStatuses, "PaymentId", "PaymentStatus1", rentalTransaction.PaymentStatusId);
            
            return View(new RentalTransactionViewModel
            {
                RentalTransaction = rentalTransaction,
                RedirectData = redirectData
            });
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

			var selectedPaymentMethod = _context.RentalTransactions.Where(x => x.TransactionId == id).FirstOrDefault().PaymentMethod.PaymentMethod1;
			var selectedPaymentStatus = _context.RentalTransactions.Where(x => x.TransactionId == id).FirstOrDefault().PaymentStatus.PaymentStatus1;

			ViewBag.PaymentMethodId = new SelectList(_context.PaymentMethods, "PaymentMethodId", "PaymentMethod1", selectedPaymentMethod);
			ViewBag.PaymentStatusId = new SelectList(_context.PaymentStatuses, "PaymentId", "PaymentStatus1", selectedPaymentStatus);

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
