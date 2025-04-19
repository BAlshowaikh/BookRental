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
    public partial class ManageAuthors : Form
    {
        BookRentalDBContext context;

        public ManageAuthors()
        {
            InitializeComponent();
            context = new BookRentalDBContext();
        }

        private void deleteBttn_Click(object sender, EventArgs e)
        {
            int selectedCell = Convert.ToInt32(dgvAuthors.SelectedCells[0].OwningRow.Cells[0].Value);

            Author author = context.Authors.Where(x => x.AuthorId == selectedCell).FirstOrDefault();

            if (MessageBox.Show("Are you sure you want to delete the author with the id - (" + author.AuthorId + ")?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Authors.Remove(author);

                context.SaveChanges();

                RefreshAuthorsGridView();
            }
        }

        private void ManageAuthors_Load(object sender, EventArgs e)
        {
            LoadAuthors();
            RefreshAuthorsGridView();
        }

        private void LoadAuthors()
        {
            ddlAuthors.DataSource = context.Authors.ToList();
            ddlAuthors.DisplayMember = "FullName";
            ddlAuthors.ValueMember = "authorId";
            ddlAuthors.SelectedItem = null;
        }

        private void RefreshAuthorsGridView()
        {
            try
            {
                var authorsToShow = context.Authors.AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtAuthorID.Text)) {
                    authorsToShow = authorsToShow.Where(a => a.AuthorId == Convert.ToInt32(txtAuthorID.Text));
                }

                else if (ddlAuthors.SelectedValue != null)
                {
                    authorsToShow = authorsToShow.Where(x => x.AuthorId == Convert.ToInt32(ddlAuthors.SelectedValue));

                }

                dgvAuthors.DataSource = authorsToShow.Select(x => new
                {
                    AuthorID = x.AuthorId,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Email = x.Email
                }).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filterBttn_Click(object sender, EventArgs e)
        {
            RefreshAuthorsGridView();
        }

        private void refreshBttn_Click_1(object sender, EventArgs e)
        {
            ddlAuthors.SelectedItem = null;
            RefreshAuthorsGridView();
        }

        private void addBttn_Click_1(object sender, EventArgs e)
        {
            AddEditAuthors addEdit = new AddEditAuthors();
            addEdit.ShowDialog();

            if (addEdit.DialogResult == DialogResult.OK)
            {
                RefreshAuthorsGridView();
            }
        }

        private void editBttn_Click_1(object sender, EventArgs e)
        {
            int selectedCell = Convert.ToInt32(dgvAuthors.SelectedCells[0].OwningRow.Cells[0].Value);

            AddEditAuthors addEdit = new AddEditAuthors(selectedCell);
            addEdit.ShowDialog();

            if (addEdit.DialogResult == DialogResult.OK)
            {
                RefreshAuthorsGridView();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAuthorsGridView();
        }
    }
}
