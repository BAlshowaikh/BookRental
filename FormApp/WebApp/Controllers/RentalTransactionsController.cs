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
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Controllers
{
    [Authorize]
    public class RentalTransactionsController : Controller
    {
        private readonly BookRentalDBContext _context;

        public RentalTransactionsController(BookRentalDBContext context)
        {
            _context = context;
        }

        // GET: RentalTransactions
        //      public async Task<IActionResult> Index(string SearchString, string SearchCustomer, bool? fromRequest, int? bookId, int? userId, string rentalStartDate, string returnDate, decimal? totalCost)
        //      {
        //	/*IQueryable<RentalTransaction> bookRentalDBContext = _context.RentalTransactions.Include(r => r.Book).Include(r => r.PaymentMethod).Include(r => r.PaymentStatus).Include(r => r.User).Where(x => x.User.UserRole.Role == "Customer");

        //          if (!String.IsNullOrEmpty(SearchString))
        //          {
        //              bookRentalDBContext = bookRentalDBContext.Where(x => x.TransactionId == Convert.ToInt32(SearchString));
        //          }

        //          if (!String.IsNullOrEmpty(SearchCustomer))
        //          {
        //              bookRentalDBContext = bookRentalDBContext.Where(x => x.User.UserId.ToString() == SearchCustomer);
        //          }

        //          var custList = new SelectList(_context.Users.Where(x => x.UserRole.Role == "Customer"), "UserId", "FullName", SearchCustomer);
        //          ViewBag.CustList = custList;

        //          return View(bookRentalDBContext);*/

        //	var query = _context.RentalTransactions
        //                .Include(r => r.Book)
        //                .Include(r => r.User)
        //                      .Include(r => r.PaymentMethod)
        //                      .Include(r => r.PaymentStatus)
        //                //.Where(r => r.User.UserRole.Role == "Customer")
        //                .AsQueryable();

        //	if (!String.IsNullOrEmpty(SearchString) && int.TryParse(SearchString, out int transId))
        //	{
        //		query = query.Where(r => r.TransactionId == transId);
        //	}

        //	if (!String.IsNullOrEmpty(SearchCustomer) && int.TryParse(SearchCustomer, out int userID))
        //	{
        //		query = query.Where(r => r.User.UserId == userID);
        //	}

        //	var transactions = await query.ToListAsync();

        //	var cards = transactions
        //                   .Select(tr => new RentalTransactionViewModel
        //                   {
        //                    RentalTransaction = tr,
        //                          RedirectData = null
        //                      })
        //                   .ToList();

        //	Console.WriteLine($"Total cards: {cards.Count}");

        //	ViewBag.CustList = new SelectList(
        //             await _context.Users
        //	        .Where(x => x.UserRole.Role == "Customer")
        //	        .ToListAsync(),
        //             "UserId", "FullName", SearchCustomer
        //       );

        //	return View(cards);
        //}

        public async Task<IActionResult> Index(
            string SearchString,
            string SearchCustomer,
            bool? fromRequest,
            int? bookId,
            int? userId,
            string rentalStartDate,
            string returnDate,
            decimal? totalCost,
            int page = 1,
            int pageSize = 12)
        {
			var query = _context.RentalTransactions
		                .Include(r => r.Book)
		                .Include(r => r.User)
                        .Include(r => r.PaymentMethod)
                        .Include(r => r.PaymentStatus)
						.Include(x => x.ReturnRecords)
						//.Where(r => r.User.UserRole.Role == "Customer")
						.AsQueryable();


            if (!String.IsNullOrEmpty(SearchString) && int.TryParse(SearchString, out int transId))
            {
                query = query.Where(r => r.TransactionId == transId);
            }
            
            if (!String.IsNullOrEmpty(SearchCustomer) && int.TryParse(SearchCustomer, out int userID))
            {
                query = query.Where(r => r.User.UserId == userID);
            }

            // Total count for pagination
            int totalItems = await query.CountAsync();

            // Paging
            var pagedTransactions = await query
                .OrderByDescending(r => r.RentalStartDate) 
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var cards = pagedTransactions
                .Select(tr => new RentalTransactionViewModel
                {
                    RentalTransaction = tr,
                    RedirectData = null
                })
                .ToList();

			Console.WriteLine($"Total cards: {cards.Count}");

			ViewBag.CustList = new SelectList(
					 await _context.Users
					.Where(x => x.UserRole.Role == "Customer")
					.Select(u => new {
						u.UserId,
						FullName = (u.FirstName ?? "") + " " + (u.LastName ?? "")
					})
					.ToListAsync(),
					 "UserId", "FullName", SearchCustomer
			);

            if (User.IsInRole("User"))
            {
				string currentEmail = User.Identity.Name;
                cards = cards.Where(x => x.RentalTransaction.User.Email == currentEmail).ToList();
            }

			ViewBag.TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize);
            ViewBag.CurrentPage = page;

            return View(cards);
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
        [Authorize(Roles = "Admin, Manager")]
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
            }

			// Calculate RentalPeriod (in days)
			if (rentalTransaction.RentalStartDate != null && rentalTransaction.ReturnDate != null)
			{
				rentalTransaction.RentalPeriod = (rentalTransaction.ReturnDate - rentalTransaction.RentalStartDate).Days;
			}

			// Set default values
			var defaultPaymentMethod = _context.PaymentMethods
				.FirstOrDefault(pm => pm.PaymentMethod1 == "Cash")?.PaymentMethodId;

			var defaultPaymentStatus = _context.PaymentStatuses
				.FirstOrDefault(ps => ps.PaymentStatus1 == "Pending")?.PaymentId;

			
			int? selectedPaymentMethod = rentalTransaction?.PaymentMethodId ?? defaultPaymentMethod;
			int? selectedPaymentStatus = rentalTransaction?.PaymentStatusId ?? defaultPaymentStatus;

			ViewBag.PaymentMethodId = new SelectList(
				_context.PaymentMethods.ToList(),
				"PaymentMethodId",
				"PaymentMethod1",
				selectedPaymentMethod
			);

			ViewBag.PaymentStatusId = new SelectList(
				_context.PaymentStatuses.ToList(),
				"PaymentId",
				"PaymentStatus1",
				selectedPaymentStatus
			);


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
		[Authorize(Roles = "Admin, Manager")]
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

			var selectedPaymentMethod = _context.RentalTransactions.Include(x => x.PaymentMethod).Where(x => x.PaymentMethod.PaymentMethod1 == "cash").FirstOrDefault().PaymentMethodId;
			var selectedPaymentStatus = _context.RentalTransactions.Include(x => x.PaymentStatus).Where(x => x.PaymentStatus.PaymentStatus1 == "Pending").Select(x => x.PaymentStatusId).FirstOrDefault();

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
