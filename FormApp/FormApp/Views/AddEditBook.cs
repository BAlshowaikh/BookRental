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

namespace FormApp.Views
{
    public partial class AddEditBook : Form
    {
        BookRentalDBContext context;
        Book newBook;
        public AddEditBook()
        {
            InitializeComponent();
            context = new BookRentalDBContext();
            newBook = new Book();
            HelperFunctions.setUpFormDesign(this);
        }

        // In case of "Edit" Option
        public AddEditBook(Book updatedBook)
        {
            InitializeComponent();
            context = new BookRentalDBContext();
            this.newBook = updatedBook;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Take the filled fields and create a new book object
            try
            {
                Book newBook = new Book();

                txtBookId.Text = "Generated automatically";
                txtBookId.ReadOnly = true;
                newBook.Name = txtBookName.Text;
                newBook.Isbn = txtBookISBN.Text;
                newBook.Description = txtBookDesc.Text;
                newBook.PublishDate = dtpPublishedDate.Value;
                newBook.RentalPrice = Convert.ToDouble(txtRentalPrice.Text);
                newBook.AuthorId = Convert.ToInt32(ddlAuthorName.SelectedValue);
                newBook.AvailabilityStatusId = Convert.ToInt32(ddlAvailability.SelectedValue);
                newBook.CategoryId = Convert.ToInt32(ddlBookCategory.SelectedValue);
                newBook.BookConditionId = Convert.ToInt32(ddlBookCondition.SelectedValue);

                if (newBook.BookId > 0)
                {
                    context.Books.Update(newBook);
                }
                else
                {
                    context.Books.Add(newBook);
                }
                context.SaveChanges();

                //txtBookId.Text = newBook.BookId.ToString();

                MessageBox.Show($"Book added successfully! ID: {newBook.BookId}",
                               "Success",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding a new book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddEditBook_Load(object sender, EventArgs e)
        {
            txtBookId.ReadOnly = true;
            // Populating the drop down lists with the data once the form load
            ddlAuthorName.DataSource = context.Authors.ToList();
            ddlAuthorName.DisplayMember = "FirstName";
            ddlAuthorName.ValueMember = "AuthorId";
            ddlAuthorName.SelectedItem = null;

            ddlAvailability.DataSource = context.AvailabilityStatuses.ToList();
            ddlAvailability.DisplayMember = "AvailabilityStatus1";
            ddlAvailability.ValueMember = "AvailabiltyStatusId";
            ddlAvailability.SelectedItem = null;

            ddlBookCategory.DataSource = context.Categories.ToList();
            ddlBookCategory.DisplayMember = "CategoryName";
            ddlBookCategory.ValueMember = "CategoryId";
            ddlBookCategory.SelectedItem = null;

            ddlBookCondition.DataSource = context.BookConditions.ToList();
            ddlBookCondition.DisplayMember = "ReturnCondition";
            ddlBookCondition.ValueMember = "BookConditionId";
            ddlBookCondition.SelectedItem = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); 
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.homePageBtn(this);
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.exitBtn();
        }

        private void returnIcon_Click(object sender, EventArgs e)
        {
           // this.Close();
            //Parent.Show();
        }
    }
}
