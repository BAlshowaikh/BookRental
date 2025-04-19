using BookRentalObject;
using Microsoft.VisualBasic.ApplicationServices;
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
            if (this.author.AuthorId > 0)
            {
                pageTitle.Text = "Edit Author";
                txtAuthorID.Text = author.AuthorId.ToString();
                txtFirstName.Text = author.FirstName;
                txtLastName.Text = author.LastName;
                txtEmail.Text = author.Email;
            }
            else
            {
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "";
            }
        }

        private void addBttn_Click(object sender, EventArgs e)
        {
            try
            {
                author.FirstName = txtFirstName.Text;
                author.LastName = txtLastName.Text;
                author.Email = txtEmail.Text;

                if (author.AuthorId > 0)
                {
                    if (MessageBox.Show("are you sure you want to edit author ID:" + author.AuthorId + "?", "conferm Approval", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        context.Authors.Update(author);
                    }
                }
                else
                {
                    if (MessageBox.Show("are you sure you want to add this author? ", "conferm Approval", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        context.Authors.Add(author);
                    }
                }

                context.SaveChanges();

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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
