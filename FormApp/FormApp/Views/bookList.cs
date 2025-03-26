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

        private void refreshBttn_Click(object sender, EventArgs e)
        {

        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {

        }

        private void dgvBooksList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Function to load the book table into the grid view
        private void LoadBookData()
        {
            try
            {
                var booksToShow = context.Books.AsQueryable();

                // Create an anonymous object to display specific attributes
                var bookDetailsToDisplay = booksToShow.Select(b => new
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
                }).ToList();

                dgvBooksList.DataSource = bookDetailsToDisplay;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading book data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        // Create a function to populate the drop down list
        private void populateDDL()
        {
            ddlFilterByBookName.DataSource = context.Books.ToList();
            ddlFilterByBookName.DisplayMember = "Name";
            ddlFilterByBookName.ValueMember = "BookId";
            ddlFilterByBookName.SelectedItem = null;
        }
    }
}
