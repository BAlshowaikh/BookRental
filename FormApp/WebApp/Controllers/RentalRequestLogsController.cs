using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models; // adjust if your DbContext lives elsewhere
using BookRentalObject;
using System;
using System.Linq;

namespace WebApp.Controllers
{
    public class RentalRequestLogsController : Controller
    {
        private readonly BookRentalDBContext _context;

        public RentalRequestLogsController(BookRentalDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var logs = _context.Logs
                               .Include(l => l.User)
                               .AsQueryable();

            var model = logs
                .OrderByDescending(l => l.Timestamp)
                .Select(l => new RentalRequestLogViewModel
                {
                    LogId = l.LogId,
                    Timestamp = l.Timestamp,
                    AffectedData = l.AffectedData,
                    Source = l.Source,
                    Exception = l.Exceptions,
                    UserName = l.User.FirstName + " " + l.User.LastName
                })
                .ToList();

            return View(model);
        }

        // ✅ Inline ViewModel
        public class RentalRequestLogViewModel
        {
            public int LogId { get; set; }
            public DateTime Timestamp { get; set; }
            public string AffectedData { get; set; }
            public string Source { get; set; }
            public string Exception { get; set; }
            public string UserName { get; set; }
        }
    }
}
