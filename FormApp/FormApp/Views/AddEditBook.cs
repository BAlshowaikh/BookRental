using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookRentalObject;
using FormApp.Controllers;
using Microsoft.EntityFrameworkCore;

namespace FormApp.Views
{
    public partial class AddEditBook : Form
    {
        BookRentalDBContext context;
        Book selectedBook;
        bool isNew;
        public AddEditBook(BookRentalDBContext parentContext)
        {
            InitializeComponent();
            context = parentContext;
            selectedBook = new Book();
            HelperFunctions.setUpFormDesign(this);
            isNew = true;
        }

        // In case of "Edit" Option
        public AddEditBook(Book updatedBook, BookRentalDBContext parentContext)
        {
            InitializeComponent();
            context = parentContext;
            selectedBook = updatedBook;
            HelperFunctions.setUpFormDesign(this);
            isNew = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Take the filled fields and create a new book object
            try
            {
                //Book newBook = new Book();

                txtBookId.Text = "Generated automatically";
                txtBookId.ReadOnly = true;
                selectedBook.Name = txtBookName.Text;
                selectedBook.Isbn = txtBookISBN.Text;
                selectedBook.Description = txtBookDesc.Text;
                selectedBook.PublishDate = dtpPublishedDate.Value;
                selectedBook.RentalPrice = Convert.ToDouble(txtRentalPrice.Text);
                selectedBook.AuthorId = Convert.ToInt32(ddlAuthorName.SelectedValue);
                selectedBook.AvailabilityStatusId = Convert.ToInt32(ddlAvailability.SelectedValue);
                selectedBook.CategoryId = Convert.ToInt32(ddlBookCategory.SelectedValue);
                selectedBook.BookConditionId = Convert.ToInt32(ddlBookCondition.SelectedValue);

                if (selectedBook.BookId > 0)
                {
                    if (MessageBox.Show("are you sure you want to edit book ID:" + selectedBook.BookId + "?", "conferm Approval", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        context.Entry(selectedBook).State = EntityState.Modified;
                        context.Books.Update(selectedBook);
                        context.SaveChanges();

                        MessageBox.Show($"Book updated successfully! ID: {selectedBook.BookId}",
                                   "Success",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (MessageBox.Show("are you sure you want to add this book? ", "conferm Approval", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        context.Books.Add(selectedBook);
                        context.SaveChanges();

                        MessageBox.Show($"Book added successfully! ID: {selectedBook.BookId}",
                                       "Success",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information);
                    }
                }

                //txtBookId.Text = newBook.BookId.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding/editing a new book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddEditBook_Load(object sender, EventArgs e)
        {
            populateDropDownLists();
            txtBookId.ReadOnly = true;

            //In case the user is editing a book
            if (isNew == false)
            {
                pageTitle.Text = "Edit Book";
                txtBookId.Text = selectedBook.BookId.ToString();
                txtBookName.Text = selectedBook.Name;
                txtBookISBN.Text = selectedBook.Isbn;
                txtBookDesc.Text = selectedBook.Description ?? "N/A";
                if (selectedBook.PublishDate.HasValue)
                {
                    dtpPublishedDate.Value = selectedBook.PublishDate.Value;
                }
                else
                {
                    dtpPublishedDate.Value = DateTime.Today;
                }
                txtRentalPrice.Text = selectedBook.RentalPrice.ToString();
                ddlAvailability.Text = selectedBook.AvailabilityStatus?.AvailabilityStatus1 ?? "N/A";
                ddlBookCondition.Text = selectedBook.BookCondition?.ReturnCondition ?? "N/A";
                ddlBookCategory.Text = selectedBook.Category?.CategoryName ?? "N/A";
                ddlAuthorName.Text = selectedBook.Author?.FirstName ?? "N/A";

            }
        }

        // Populate all drop down lists
        private void populateDropDownLists()
        {
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
            HelperFunctions.returnBtn(new bookList(), this);
        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.ShowProfilePage(this);
        }
    }
}
