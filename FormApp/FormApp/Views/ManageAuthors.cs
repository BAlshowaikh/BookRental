using BookRentalObject;
using FormApp.Controllers;
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
            HelperFunctions.setUpFormDesign(this);
        }

        private void deleteBttn_Click(object sender, EventArgs e)
        {
            //Get the selected cell within the grid view
            int selectedCell = Convert.ToInt32(dgvAuthors.SelectedCells[0].OwningRow.Cells[0].Value);

            //Retrieve the author object of the selected id
            Author author = context.Authors.Where(x => x.AuthorId == selectedCell).FirstOrDefault();

            if (MessageBox.Show("Are you sure you want to delete the author with the id - (" + author.AuthorId + ")?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Authors.Remove(author); //Delete the author with the specified ID

                context.SaveChanges(); //Execute the changes against the Database

                RefreshAuthorsGridView(); //Call refresh grid view to view the changes
            }
        }

        private void ManageAuthors_Load(object sender, EventArgs e)
        {
            LoadAuthors(); 
            RefreshAuthorsGridView();
        }

        private void LoadAuthors()
        {
            try
            {
                //Set the data source of the drop down list to a list of authors from the database
                ddlAuthors.DataSource = context.Authors.ToList(); 
                ddlAuthors.DisplayMember = "FullName"; //Set the Property to display in the drop down list
                ddlAuthors.ValueMember = "authorId"; //Set the value associated with each item 
                ddlAuthors.SelectedItem = null; //Clear Pre-selected value
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshAuthorsGridView()
        {
            try
            {
                var authorsToShow = context.Authors.AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtAuthorID.Text))
                {
                    authorsToShow = authorsToShow.Where(a => a.AuthorId == Convert.ToInt32(txtAuthorID.Text));
                }

                else if (ddlAuthors.SelectedValue != null)
                {
                    authorsToShow = authorsToShow.Where(x => x.AuthorId == Convert.ToInt32(ddlAuthors.SelectedValue));

                }
              
                //Project the filtered authors into an anonymous type, then convert the result to a list and bind it to the data grid view.
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
            RefreshAuthorsGridView(); //Call the method to filter if any filters were applied
        }

        private void refreshBttn_Click_1(object sender, EventArgs e)
        {
            ddlAuthors.SelectedItem = null; //Clear Pre-selected value
            RefreshAuthorsGridView(); //Refresh the view to remove the filters
        }

        private void addBttn_Click_1(object sender, EventArgs e)
        {
            AddEditAuthors addEdit = new AddEditAuthors();
            addEdit.ShowDialog();

            //If the dialog result was ok, refresh the authors grid view to show the new data
            if (addEdit.DialogResult == DialogResult.OK)
            {
                RefreshAuthorsGridView();
            }
        }

        private void editBttn_Click_1(object sender, EventArgs e)
        {
            //Get the author ID from the first selected cell
            int selectedCell = Convert.ToInt32(dgvAuthors.SelectedCells[0].OwningRow.Cells[0].Value);

            AddEditAuthors addEdit = new AddEditAuthors(selectedCell);
            addEdit.ShowDialog();

            //if the dialog result was ok, refresh the grid view to reflect the updates
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

        private void userIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.ShowProfilePage(this);
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
