using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookRentalObject;
using FormApp.Controllers;
using Microsoft.EntityFrameworkCore;

namespace FormApp
{
    public partial class bookDetails : Form
    {
        BookRentalDBContext context;
        private int bookId;

        public bookDetails(Book selectedBook)
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);

            // Pass the selected book object and populate the information
            PopulateForm(selectedBook);
        }

        private void PopulateForm(Book book)
        {
            txtBookId.Text = book.BookId.ToString();
            txtBookName.Text = book.Name;
            txtBookISBN.Text = book.Isbn;
            txtBookDesc.Text = book.Description ?? "N/A";
            txtPublishDate.Text = book.PublishDate?.ToString("yyyy-MM-dd") ?? "N/A";
            txtRentalPrice.Text = book.RentalPrice.ToString("C");
            txtAvailability.Text = book.AvailabilityStatus?.AvailabilityStatus1 ?? "N/A";
            txtBookCondition.Text = book.BookCondition?.ReturnCondition ?? "N/A";
            txtBookCategory.Text = book.Category?.CategoryName ?? "N/A";
            txtAuthorName.Text = book.Author?.FirstName ?? "N/A";

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).ReadOnly = true;
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.homePageBtn(this);
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.exitBtn();
        }

        private void bookDetails_Load(object sender, EventArgs e)
        {

        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.ShowProfilePage(this);
        }
    }
}
