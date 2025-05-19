using BookRentalObject;
using FormApp.Controllers;
using Microsoft.EntityFrameworkCore;
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
    public partial class ManageCategory : Form
    {
        BookRentalDBContext context;

        public ManageCategory()
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
            context = new BookRentalDBContext();
        }

        private void ManageCategory_Load(object sender, EventArgs e)
        {
            populateCategory();
            RefreshCategoryGridView();
        }
        private void populateCategory()
        {
            try
            {
                //Set the data source of the drop down to the list of categories 
                ddlCategory.DataSource = context.Categories.ToList();
                ddlCategory.DisplayMember = "categoryName";  // Set which property to display in the dropdown
                ddlCategory.ValueMember = "categoryId"; // Set the value property for each dropdown item
                ddlCategory.SelectedItem = null; // Clear any pre-selected item

                // Refresh the grid view to show the latest categories
                RefreshCategoryGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshCategoryGridView()
        {
            try
            {
                var categoryToShow = context.Categories.AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtCategoryID.Text))
                {
                    categoryToShow = categoryToShow.Where(c => c.CategoryId == Convert.ToInt32(txtCategoryID.Text));
                }

                else if (ddlCategory.SelectedItem != null)
                {
                    categoryToShow = categoryToShow.Where(x => x.CategoryId == Convert.ToInt32(ddlCategory.SelectedValue));
                }

                //Project the filtered category into an anonymous type, then convert the result to a list and bind it to the data grid view.
                dgvCategories.DataSource = categoryToShow.Select(x => new
                {
                    CategoryID = x.CategoryId,
                    CategoryName = x.CategoryName
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filterBttn_Click(object sender, EventArgs e)
        {
            RefreshCategoryGridView(); //Call the method to filter if any filters were applied
        }

        private void refreshBttn_Click(object sender, EventArgs e)
        {
            txtCategoryID.Text = string.Empty; // Clear ID input
            ddlCategory.SelectedItem = null;   // Clear dropdown
            RefreshCategoryGridView();         // Refresh grid
        }

        private void deleteBttn_Click(object sender, EventArgs e)
        {
            //Get the selected cell within the grid view
            int selectedCell = Convert.ToInt32(dgvCategories.SelectedCells[0].OwningRow.Cells[0].Value);

            //Retrieve the category object of the selected id
            Category category = context.Categories.Where(x => x.CategoryId == selectedCell).FirstOrDefault();

            if (MessageBox.Show("Are you sure you want to delete the category with the id - (" + category.CategoryId + ")?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Categories.Remove(category); //Delete the category with the specified ID

                context.SaveChanges(); //Execute the changes against the Database

                RefreshCategoryGridView(); //Call refresh grid view to view the changes
            }
        }

        private void addBttn_Click(object sender, EventArgs e)
        {
            AddEditCategory addEdit = new AddEditCategory();
            addEdit.ShowDialog();

            //If the dialog result was ok, refresh the authors grid view to show the new data
            if (addEdit.DialogResult == DialogResult.OK)
            {
                RefreshCategoryGridView();
            }
        }

        private void editBttn_Click(object sender, EventArgs e)
        {
            //Get the category ID from the first selected cell
            int selectedCell = Convert.ToInt32(dgvCategories.SelectedCells[0].OwningRow.Cells[0].Value);

            AddEditCategory addEdit = new AddEditCategory(selectedCell);
            addEdit.ShowDialog();

            //if the dialog result was ok, refresh the grid view to reflect the updates
            if (addEdit.DialogResult == DialogResult.OK)
            {
                RefreshCategoryGridView();
            }

        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.homePageBtn(this);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshCategoryGridView();
        }

        private void returnIcon_Click(object sender, EventArgs e)
        {

        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.ShowProfilePage(this);
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.exitBtn();
        }
    }
}
