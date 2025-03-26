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
using Microsoft.EntityFrameworkCore;

namespace FormApp
{
    public partial class bookList : Form
    {
        BookRentalDBContext context;

        public bookList()
        {
            InitializeComponent();
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

        }

        private void dgvBooksList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Function to customize the showed attributes in the data grid view
        private List<object> GetFormattedBookData(IQueryable<Book> books)
        {
            return books.Select(b => new
            {
                b.BookId,
                b.Name,
                b.Description,
                b.RentalPrice,
                b.PublishDate,
                b.Isbn,
                Category = b.Category.CategoryName,
                Author = b.Author.FirstName,
                Availability_Status = b.AvailabilityStatus.AvailabilityStatus1,
                Book_Condition = b.BookCondition.ReturnCondition
            }).ToList<object>(); // Convert to List<object> for UI binding
        }

        // Function to load the book table into the grid view

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
                dgvBooksList.DataSource = GetFormattedBookData(books);
            }
            catch(Exception ex) {
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

                // Check if both of them are filled, show an error message
                if (isTextBoxFilled && isDropDownFilled)
                {
                    MessageBox.Show("Please use only one filter method (either Book ID or Book Name).", "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var booksToShow = context.Books.AsQueryable();

                // Check if the text box is filled 
                if (isTextBoxFilled)
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
                var result = GetFormattedBookData(booksToShow);

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

    }
}
