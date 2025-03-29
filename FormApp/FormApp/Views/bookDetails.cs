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
using FormApp.Controllers;

namespace FormApp
{
    public partial class bookDetails : Form
    {
        BookRentalDBContext context;
        private int bookId;

        public bookDetails(Book book)
        {
            InitializeComponent();
            BookRentalDBContext context = new BookRentalDBContext();
            txtBookId.Text = book.BookId.ToString();
            txtBookName.Text = book.Name;
            txtBookISBN.Text = book.Isbn;
            txtBookDesc.Text = book.Description;
            txtPublishDate.Text = book.PublishDate.ToString();
            txtRentalPrice.Text = book.RentalPrice.ToString();
            txtAvailability.Text = book.AvailabilityStatus.AvailabilityStatus1;
            txtBookCondition.Text = book.BookCondition.ReturnCondition;
            txtBookCategory.Text = book.Category.CategoryName;
            txtAuthorName.Text = book.Author.FirstName;


        }

        public bookDetails(int bookId)
        {
            this.bookId = bookId;
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
    }
}
