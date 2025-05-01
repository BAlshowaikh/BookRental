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
    public class AuditTrailsController : Controller
    {
        private readonly BookRentalDBContext _context;

        public AuditTrailsController(BookRentalDBContext context)
        {
            _context = context;
        }

        // GET: AuditTrails
        public async Task<IActionResult> Index()
        {
            var bookRentalDBContext = _context.AuditTrails.Include(a => a.User);
            return View(await bookRentalDBContext.ToListAsync());
        }

        // GET: AuditTrails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AuditTrails == null)
            {
                return NotFound();
            }

            var auditTrail = await _context.AuditTrails
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.AuditId == id);
            if (auditTrail == null)
            {
                return NotFound();
            }

            return View(auditTrail);
        }

        // GET: AuditTrails/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName");
            return View();
        }

        // POST: AuditTrails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AuditId,Timestamp,OldValue,NewValue,UserId")] AuditTrail auditTrail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(auditTrail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName", auditTrail.UserId);
            return View(auditTrail);
        }

        // GET: AuditTrails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AuditTrails == null)
            {
                return NotFound();
            }

            var auditTrail = await _context.AuditTrails.FindAsync(id);
            if (auditTrail == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName", auditTrail.UserId);
            return View(auditTrail);
        }

        // POST: AuditTrails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AuditId,Timestamp,OldValue,NewValue,UserId")] AuditTrail auditTrail)
        {
            if (id != auditTrail.AuditId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(auditTrail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuditTrailExists(auditTrail.AuditId))
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
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FirstName", auditTrail.UserId);
            return View(auditTrail);
        }

        // GET: AuditTrails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AuditTrails == null)
            {
                return NotFound();
            }

            var auditTrail = await _context.AuditTrails
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.AuditId == id);
            if (auditTrail == null)
            {
                return NotFound();
            }

            return View(auditTrail);
        }

        // POST: AuditTrails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AuditTrails == null)
            {
                return Problem("Entity set 'BookRentalDBContext.AuditTrails'  is null.");
            }
            var auditTrail = await _context.AuditTrails.FindAsync(id);
            if (auditTrail != null)
            {
                _context.AuditTrails.Remove(auditTrail);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AuditTrailExists(int id)
        {
          return (_context.AuditTrails?.Any(e => e.AuditId == id)).GetValueOrDefault();
        }
    }
}
