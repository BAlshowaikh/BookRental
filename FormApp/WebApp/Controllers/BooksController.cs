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
    public class BooksController : Controller
    {
        private readonly BookRentalDBContext _context;

        public BooksController(BookRentalDBContext context)
        {
            _context = context;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            var bookRentalDBContext = _context.Books.Include(b => b.Author).Include(b => b.AvailabilityStatus).Include(b => b.BookCondition).Include(b => b.Category).Include(b => b.Image);
            return View(await bookRentalDBContext.ToListAsync());
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .Include(b => b.Author)
                .Include(b => b.AvailabilityStatus)
                .Include(b => b.BookCondition)
                .Include(b => b.Category)
                .Include(b => b.Image)
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "FirstName");
            ViewData["AvailabilityStatusId"] = new SelectList(_context.AvailabilityStatuses, "AvailabiltyStatusId", "AvailabilityStatus1");
            ViewData["BookConditionId"] = new SelectList(_context.BookConditions, "BookConditionId", "ReturnCondition");
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            ViewData["ImageId"] = new SelectList(_context.Images, "ImageId", "ImageName");
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookId,Name,Description,CategoryId,RentalPrice,BookConditionId,AvailabilityStatusId,AuthorId,PublishDate,Isbn,IsActive,ImageId")] Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "FirstName", book.AuthorId);
            ViewData["AvailabilityStatusId"] = new SelectList(_context.AvailabilityStatuses, "AvailabiltyStatusId", "AvailabilityStatus1", book.AvailabilityStatusId);
            ViewData["BookConditionId"] = new SelectList(_context.BookConditions, "BookConditionId", "ReturnCondition", book.BookConditionId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", book.CategoryId);
            ViewData["ImageId"] = new SelectList(_context.Images, "ImageId", "ImageName", book.ImageId);
            return View(book);
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return NotFound();
            }

            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "FirstName", book.AuthorId);
            ViewData["AvailabilityStatusId"] = new SelectList(_context.AvailabilityStatuses, "AvailabiltyStatusId", "AvailabilityStatus1", book.AvailabilityStatusId);
            ViewData["BookConditionId"] = new SelectList(_context.BookConditions, "BookConditionId", "ReturnCondition", book.BookConditionId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", book.CategoryId);
            ViewData["ImageId"] = new SelectList(_context.Images, "ImageId", "ImageName", book.ImageId);
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookId,Name,Description,CategoryId,RentalPrice,BookConditionId,AvailabilityStatusId,AuthorId,PublishDate,Isbn,IsActive,ImageId")] Book book)
        {
            if (id != book.BookId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.BookId))
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
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "FirstName", book.AuthorId);
            ViewData["AvailabilityStatusId"] = new SelectList(_context.AvailabilityStatuses, "AvailabiltyStatusId", "AvailabilityStatus1", book.AvailabilityStatusId);
            ViewData["BookConditionId"] = new SelectList(_context.BookConditions, "BookConditionId", "ReturnCondition", book.BookConditionId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", book.CategoryId);
            ViewData["ImageId"] = new SelectList(_context.Images, "ImageId", "ImageName", book.ImageId);
            return View(book);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .Include(b => b.Author)
                .Include(b => b.AvailabilityStatus)
                .Include(b => b.BookCondition)
                .Include(b => b.Category)
                .Include(b => b.Image)
                .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Books == null)
            {
                return Problem("Entity set 'BookRentalDBContext.Books'  is null.");
            }
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
          return (_context.Books?.Any(e => e.BookId == id)).GetValueOrDefault();
        }
    }
}
