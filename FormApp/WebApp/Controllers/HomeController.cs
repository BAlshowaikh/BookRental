using System.Diagnostics;
using BookRentalObject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly BookRentalDBContext _context;
        public HomeController(ILogger<HomeController> logger, BookRentalDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Dashboard()
        {
            var now = DateTime.Now;

            // Most Rented Categories
            var categoryCounts = _context.RentalTransactions
                .Include(r => r.Book)
                .ThenInclude(b => b.Category)
                .GroupBy(x => x.Book.Category.CategoryName)
                .Select(g => new
                {
                    Category = g.Key,
                    Count = g.Count()
                })
                .OrderByDescending(g => g.Count)
                .ToList();

            // Active Rentals (checking if the rental has a matching ReturnRecord)
            int activeRentals = _context.RentalTransactions
                .Where(rt => !_context.ReturnRecords.Any(rr => rr.TransactionId == rt.TransactionId))
                .Count();

            // On-time & Late Returns
            int onTimeReturns = _context.ReturnRecords
                .Count(t => t.ActualReturnDate != null && t.ActualReturnDate <= t.ExpectedReturnDate);

            int lateReturns = _context.ReturnRecords
                .Count(t => t.ActualReturnDate != null && t.ActualReturnDate > t.ExpectedReturnDate);

            int totalReturns = _context.ReturnRecords
                .Count(t => t.ActualReturnDate != null);

            double onTimePercentage = totalReturns > 0 ? (onTimeReturns * 100.0 / totalReturns) : 0;
            double latePercentage = totalReturns > 0 ? (lateReturns * 100.0 / totalReturns) : 0;

            // Total Revenue = Rental Fees + Late Fees
            double totalRevenue = _context.ReturnRecords
                .Where(t => t.TotalAdditionalCharges != null)
                .Sum(t => t.TotalAdditionalCharges);

            double rentalRevenue = _context.RentalTransactions.Sum(t => t.RentalFee);
            double lateFees = totalRevenue - rentalRevenue;

            // Condition-Based Chart Data (Books by Condition)
            var conditionCounts = _context.Books
                .GroupBy(b => b.BookCondition.ReturnCondition)
                .Select(g => new
                {
                    Condition = g.Key,
                    Count = g.Count()
                })
                .OrderByDescending(g => g.Count)
                .ToList();

            // Pass data to View
            ViewBag.CategoryLabels = categoryCounts.Select(c => c.Category).ToList();
            ViewBag.CategoryData = categoryCounts.Select(c => c.Count).ToList();
            ViewBag.ActiveRentals = activeRentals;
            ViewBag.OnTimeReturns = onTimePercentage;
            ViewBag.LateReturns = latePercentage;
            ViewBag.TotalRevenue = totalRevenue;
            ViewBag.ReturnStatsData = new List<int> { onTimeReturns, lateReturns };
            ViewBag.RevenueData = new List<double> { rentalRevenue, totalRevenue }; // Update RevenueData
            ViewBag.ConditionLabels = conditionCounts.Select(c => c.Condition).ToList();
            ViewBag.ConditionData = conditionCounts.Select(c => c.Count).ToList();

            return View();
        }


    }
}
