using BookRentalObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp.Views
{
    public partial class AddEditAuthors : Form
    {
        BookRentalDBContext context;
        Author author;

        public AddEditAuthors()
        {
            InitializeComponent();
            context = new BookRentalDBContext();
            author = new Author();
        }

        public AddEditAuthors(int authorId)
        {
            InitializeComponent();
            context = new BookRentalDBContext();
            this.author = context.Authors.Find(authorId);
        }

        private void AddEditAuthors_Load(object sender, EventArgs e)
        {
            AddEditAuthorsFields();
        }

        private void AddEditAuthorsFields()
        {
            try
            {
                //check if it's an existing author
                if (this.author.AuthorId > 0)
                {
                    // Populate form fields with the author data
                    txtAuthorID.Text = author.AuthorId.ToString();
                    txtFirstName.Text = author.FirstName;
                    txtLastName.Text = author.LastName;
                    txtEmail.Text = author.Email;
                }
                else
                {
                    // If this is a new author, clear the first name, last name and email
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtEmail.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addBttn_Click(object sender, EventArgs e)
        {
            try
            {
                author.FirstName = txtFirstName.Text;
                author.LastName = txtLastName.Text;
                author.Email = txtEmail.Text;

                // If the author has an existing ID, update the record
                if (author.AuthorId > 0)
                {
                    context.Authors.Update(author);
                }
                else // add a new user
                {
                    context.Authors.Add(author);
                }

                // Save changes to the database
                context.SaveChanges();

                // Close the form and return OK result
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBttn_Click(object sender, EventArgs e)
        {
            
        }

        private void cancelBttn_Click(object sender, EventArgs e)
        {
            // Close the form and return Cancel
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
