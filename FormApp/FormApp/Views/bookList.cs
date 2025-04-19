using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookRentalObject;
using FormApp.Views;
using Microsoft.EntityFrameworkCore;
using FormApp.Controllers;
using System.Net;

namespace FormApp
{
    public partial class bookList : Form
    {
        BookRentalDBContext context;
        // Instantiate a book object 
        private Book _selectedBook;

        public bookList()
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
            context = new BookRentalDBContext();
        }
        private void bookList_Load(object sender, EventArgs e)
        {
            LoadBookData();
            populateDDL();

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        // Function to reset the filter fields and reload the original records
        private void refreshBttn_Click(object sender, EventArgs e)
        {
            try
            {
                txtFilterByBookID.Text = string.Empty;
                ddlFilterByBookName.SelectedItem = null;

                // Load the original records
                LoadBookData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error resetting filters: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (_selectedBook == null) //Check if no row is selected
            {
                MessageBox.Show($"No selected row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form viewDetailsForm = new bookDetails(_selectedBook);
                HelperFunctions.ShowChildForm(this, viewDetailsForm);
            }

        }


        private void dgvBooksList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        // Function to customize the book table into the grid view
        private List<object> formattedGridView(IQueryable<Book> books)
        {
            try
            {
                return books.Select(b => new
                {
                    Book_ID = b.BookId,
                    book_name = b.Name,
                    Descrption = b.Description,
                    ISBN = b.Isbn,
                    Rental_price = b.RentalPrice,
                    Published_date = b.PublishDate,
                    Category = b.Category.CategoryName,
                    Author = b.Author.FirstName,
                    Availability = b.AvailabilityStatus.AvailabilityStatus1,
                    Condition = b.BookCondition.ReturnCondition
                }).ToList<object>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading the books: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<object>();
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        // Create a function to populate the drop down list
        private void populateDDL()
        {
            ddlFilterByBookName.DataSource = context.Books.ToList();
            ddlFilterByBookName.DisplayMember = "Name";
            ddlFilterByBookName.ValueMember = "BookId";
            ddlFilterByBookName.SelectedItem = null;
        }

        private void LoadBookData()
        {
            try
            {
                var books = context.Books.AsQueryable();
                dgvBooksList.DataSource = formattedGridView(books);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading book data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyFilters()
        {
            try
            {
                // Create a boolean controls
                bool isTextBoxFilled = !string.IsNullOrWhiteSpace(txtFilterByBookID.Text);
                bool isDropDownFilled = ddlFilterByBookName.SelectedValue != null;
                var booksToShow = context.Books.AsQueryable();

                // Check if both of them are filled, show an error message
                if (isTextBoxFilled && isDropDownFilled)
                {

                    int textBoxBookId = Convert.ToInt32(txtFilterByBookID.Text);
                    int selectedBookId = Convert.ToInt32(ddlFilterByBookName.SelectedValue);

                    // Apply both filters together (AND condition)
                    booksToShow = booksToShow
                        .Where(b => b.BookId == textBoxBookId && b.BookId == selectedBookId);
                }

                // Check if the text box is filled 
                else if (isTextBoxFilled)
                {
                    booksToShow = booksToShow.Where(b => b.BookId == Convert.ToInt32(txtFilterByBookID.Text));
                }
                else if (isDropDownFilled)
                {
                    // Convert the selected value to int so it can be comapred
                    int selectedBookId = Convert.ToInt32(ddlFilterByBookName.SelectedValue);
                    booksToShow = booksToShow.Where(b => b.BookId == selectedBookId);
                }

                // Update the data grid view depending in the satisfied if condition
                var result = formattedGridView(booksToShow);

                if (result.Count == 0)
                {
                    MessageBox.Show("No records found.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvBooksList.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddEditBook addEditBook = new AddEditBook(context);
            HelperFunctions.ShowChildForm(this, addEditBook);

            if (addEditBook.DialogResult == DialogResult.OK)
            {
                LoadBookData();
            }
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.homePageBtn(this);
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.exitBtn();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadBookData();
        }

        // Function to retrieve the selected row and convert it to a book object
        private void dgvBooksList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure it's not a header row
            {
                // Select the entire row
                dgvBooksList.Rows[e.RowIndex].Selected = true;

                // Get the BookId from the selected row
                // var selectedRow = dgvBooksList.Rows[e.RowIndex];
                var bookId = Convert.ToInt32(dgvBooksList.Rows[e.RowIndex].Cells["Book_ID"].Value);

                // Fetch the complete Book object from the database
                //using (var context = new BookRentalDBContext())
                //{
                var book = context.Books
                   .Include(b => b.Author)
                   .Include(b => b.Category)
                   .Include(b => b.AvailabilityStatus)
                   .Include(b => b.BookCondition)
                   .FirstOrDefault(b => b.BookId == bookId);

                if (book != null)
                {
                    _selectedBook = book;
                }
                else
                {
                    // Handle not found case
                    MessageBox.Show("Book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _selectedBook = null; // Explicitly clear previous selection
                }
                //}
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedBook != null)
                {
                    var book = _selectedBook;
                    int deleteBookId = book.BookId;
                    String deleteBookName = book.Name;
                    if (MessageBox.Show("Are you sure you want to delete book with id (" + deleteBookId + " and name: " + deleteBookName + ") ?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var bookToDelete = context.Books.Find(deleteBookId); // Find in current context
                        if (bookToDelete != null)
                        {
                            context.Books.Remove(bookToDelete);
                            context.SaveChanges();
                            LoadBookData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occured when deleting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            // Check if there is a selected row
            try
            {
                if (dgvBooksList.SelectedCells.Count > 0)
                {
                    if (_selectedBook != null)
                    {
                        {
                            var updatedBook = _selectedBook;
                            Form addEditBookForm = new AddEditBook(updatedBook, context);
                            HelperFunctions.ShowChildForm(this, addEditBookForm);

                            if (addEditBookForm.DialogResult == DialogResult.OK)
                            {
                                LoadBookData();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have to select an order", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.ShowProfilePage(this);
        }
    }
}
