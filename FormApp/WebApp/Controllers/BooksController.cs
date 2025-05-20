using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookRentalObject;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing.Printing;
using Microsoft.AspNetCore.Authorization;

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
        public async Task<IActionResult> Index(string SearchString, string SearchCategory, int page = 1, int pageSize = 9)
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

            //Pagination

            // Total count before pagination
            var totalBooks = await bookRentalDBContext.CountAsync();

            // Apply pagination
            var books = await bookRentalDBContext
            .OrderBy(b => b.Name)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            // Pass pagination data to view
            ViewBag.TotalPages = (int)Math.Ceiling(totalBooks / (double)pageSize);
            ViewBag.CurrentPage = page;

            return View(books);

            // Execute the query and return the view with the filtered books
            // return View(await bookRentalDBContext.ToListAsync());
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
        //Restrict the edit book
        [Authorize(Roles = "Admin, Manager")]
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
        [Authorize(Roles = "Admin, Manager")]
        public async Task<IActionResult> Create([Bind("Name,Description,CategoryId,RentalPrice,BookConditionId,AvailabilityStatusId,AuthorId,PublishDate,Isbn,IsActive,ImageId")] Book book, IFormFile ImageFile)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Handle image upload
                    if (ImageFile != null && ImageFile.Length > 0)
                    {
                        using var memoryStream = new MemoryStream();
                        await ImageFile.CopyToAsync(memoryStream);

                        var image = new Image
                        {
                            ImageName = Path.GetFileName(ImageFile.FileName),
                            ImageType = ImageFile.ContentType,
                            Blob = memoryStream.ToArray()
                        };

                        _context.Images.Add(image);
                        await _context.SaveChangesAsync();

                        book.ImageId = image.ImageId; 
                    }

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
        //Restrict the edit book
        [Authorize(Roles = "Admin, Manager")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                 .Include(b => b.Image)
                 .FirstOrDefaultAsync(b => b.BookId == id);

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
        public async Task<IActionResult> Edit(int id, [Bind("BookId,Name,Description,CategoryId,RentalPrice,BookConditionId,AvailabilityStatusId,AuthorId,PublishDate,Isbn,IsActive,ImageId")] Book book, IFormFile ImageFile)
        {
            if (id != book.BookId)
            {
                TempData["ErrorMessage"] = "The book doesn't exist.";
                return RedirectToAction("Index");
            }

            var existingBook = await _context.Books
                .Include(b => b.Image) // Make sure to include Image in the query
                .FirstOrDefaultAsync(b => b.BookId == id);

            if (existingBook == null)
            {
                TempData["ErrorMessage"] = "Book not found.";
                return RedirectToAction("Index");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Preserve the original ImageId
                    var originalImageId = existingBook.ImageId;

                    // Update scalar properties (book details)
                    _context.Entry(existingBook).CurrentValues.SetValues(book);

                    // Restore original ImageId
                    existingBook.ImageId = originalImageId;

                    // Handle new image upload
                    if (ImageFile != null && ImageFile.Length > 0)
                    {
                        using var memoryStream = new MemoryStream();
                        await ImageFile.CopyToAsync(memoryStream);

                        if (existingBook.ImageId != null) // Check if there is an associated image
                        {
                            // Retrieve the existing image directly from the database
                            var existingImage = await _context.Images.FindAsync(existingBook.ImageId);

                            if (existingImage != null)
                            {
                                // Update the existing image record
                                existingImage.ImageName = Path.GetFileName(ImageFile.FileName);
                                existingImage.ImageType = ImageFile.ContentType;
                                existingImage.Blob = memoryStream.ToArray();

                                // Mark the image entity as modified
                                _context.Images.Update(existingImage);
                            }
                        }
                        else
                        {
                            // If no image exists, create a new one
                            var newImage = new Image
                            {
                                ImageName = Path.GetFileName(ImageFile.FileName),
                                ImageType = ImageFile.ContentType,
                                Blob = memoryStream.ToArray()
                            };

                            // Add the new image to the database and assign it to the book
                            _context.Images.Add(newImage);
                            await _context.SaveChangesAsync(); // Save to get the new image ID

                            // Update the book with the new image ID
                            existingBook.ImageId = newImage.ImageId;
                        }
                    }

                    // Save all changes (book and image)
                    await _context.SaveChangesAsync();

                    TempData["SuccessMessage"] = "Book edited successfully!";
                    ViewBag.EditedBookId = existingBook.BookId;

                    // Return the updated book view
                    var fullBook = await _context.Books
                        .Include(b => b.Image) // Include the image in the updated book
                        .FirstOrDefaultAsync(b => b.BookId == id);

                    return View(fullBook);
                }
                catch (Exception)
                {
                    TempData["ErrorMessage"] = "An error occurred while editing the book.";
                }
            }
            else
            {
                TempData["ErrorMessage"] = "Please correct the errors and try again.";
            }

            // If model is invalid, reload the necessary data for the form
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "FullName", book.AuthorId);
            ViewData["AvailabilityStatusId"] = new SelectList(_context.AvailabilityStatuses, "AvailabiltyStatusId", "AvailabilityStatus1", book.AvailabilityStatusId);
            ViewData["BookConditionId"] = new SelectList(_context.BookConditions, "BookConditionId", "ReturnCondition", book.BookConditionId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", book.CategoryId);
           // ViewData["ImageId"] = new SelectList(_context.Images, "ImageId", "ImageName", book.ImageId);

            var fullBookOnError = await _context.Books
                .Include(b => b.Image)
                .FirstOrDefaultAsync(b => b.BookId == id);

            return View(fullBookOnError);
        }


        // GET: Books/Delete/5
        // Restrict the user for deleting book
        [Authorize(Roles = "Admin, Manager")]
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
        // Restrict the user for deleting book
        [Authorize(Roles = "Admin, Manager")]
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
        // Restrict the user for hiding/showing book
        [Authorize(Roles = "Admin, Manager")]
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
