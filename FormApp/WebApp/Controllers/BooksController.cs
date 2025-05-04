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
        public async Task<IActionResult> Index(string SearchString, string SearchCategory)
        {
            // Logic for the search and filter
            var categories = await _context.Categories.ToListAsync();

            // Populate ViewBag.catlist with a SelectList for categories
            ViewBag.catlist = new SelectList(categories, "CategoryId", "CategoryName");

            // Fetch books along with their relationships
            var bookRentalDBContext = _context.Books
                .Include(b => b.Author)
                .Include(b => b.AvailabilityStatus)
                .Include(b => b.BookCondition)
                .Include(b => b.Category)
                .Include(b => b.Image)
                .AsQueryable();

            // Apply filtering by search string if provided
            if (!string.IsNullOrEmpty(SearchString))
            {
                bookRentalDBContext = bookRentalDBContext.Where(b => b.Name.Contains(SearchString));
            }

            // Apply filtering by selected category if provided
            if (!string.IsNullOrEmpty(SearchCategory))
            {
                bookRentalDBContext = bookRentalDBContext.Where(b => b.Category.CategoryId.ToString() == SearchCategory);
            }

            // Execute the query and return the view with the filtered books
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
                .Include(b => b.Feedbacks)
                    .ThenInclude(f => f.ReturnRecord)    
                    .ThenInclude(r => r.Transaction)
                    .ThenInclude(t => t.User)              
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
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "FullName");
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
        public async Task<IActionResult> Create([Bind("Name,Description,CategoryId,RentalPrice,BookConditionId,AvailabilityStatusId,AuthorId,PublishDate,Isbn,IsActive,ImageId")] Book book)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(book);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "Book added successfully!";
                    ViewBag.NewBookId = book.BookId;
                    return View(book); // do NOT redirect here
                }
                catch (Exception)
                {
                    TempData["ErrorMessage"] = "An error occurred while saving the book.";
                }
            }
            else
            {
                TempData["ErrorMessage"] = "Please correct the errors and try again.";
            }

            // Re-populate dropdowns if returning to Create view
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "FullName", book.AuthorId);
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
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "FullName", book.AuthorId);
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
                TempData["ErrorMessage"] = "The book doesn't exist.";
                return View(book);   
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "Book edited successfully!";
                    ViewBag.EditedBookId = book.BookId;
                    return View(book); // do NOT redirect here
                }
                catch (Exception)
                {
                        TempData["ErrorMessage"] = "An error occurred while editing the book.";
                    
                }
                //return RedirectToAction(nameof(Index));
            }
            else
            {
                TempData["ErrorMessage"] = "Please correct the errors and try again.";
            }

            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "FullName", book.AuthorId);
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

        // Method to autocompletion for the Book name search
        [HttpGet]
        public IActionResult SearchBooks(string term)
        {
            var bookNames = _context.Books
                .Where(b => b.Name.Contains(term))
                .Select(b => b.Name)
                .Take(5)
                .ToList();

            return Json(bookNames);
        }

        // Method to show/hide book button in the Index
        [HttpPost]
        public async Task<IActionResult> BookVisibility(int bookId, bool isActive)
        {
            Console.WriteLine("This is from books controller");
            var book = await _context.Books.FindAsync(bookId);
            if (book == null)
                return NotFound();

            book.IsActive = isActive;
            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}
