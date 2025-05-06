using System.Diagnostics;
using BookRentalObject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

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
            var categoryCounts = _context.RentalTransactions
                .Include(r => r.Book)
                .ThenInclude(b => b.Category)
                .GroupBy(x=> x.Book.Category.CategoryName)
                .Select(g => new
                {
                    Category = g.Key,
                    Count = g.Count()
                })
                .OrderByDescending(g => g.Count)
                .ToList();

            ViewBag.CategoryLabels = categoryCounts.Select(c => c.Category).ToList();
            ViewBag.CategoryData = categoryCounts.Select(c => c.Count).ToList();

            return View();
        }
    }
}
