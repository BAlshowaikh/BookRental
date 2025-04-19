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
            ddlCategory.DataSource = context.Categories.ToList();
            ddlCategory.DisplayMember = "categoryName";
            ddlCategory.ValueMember = "categoryId";
            ddlCategory.SelectedItem = null;

            RefreshCategoryGridView();
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
            RefreshCategoryGridView();
        }

        private void refreshBttn_Click(object sender, EventArgs e)
        {
            ddlCategory.SelectedItem = null;
            RefreshCategoryGridView();
        }

        private void deleteBttn_Click(object sender, EventArgs e)
        {
            int selectedCell = Convert.ToInt32(dgvCategories.SelectedCells[0].OwningRow.Cells[0].Value);

            Category category = context.Categories.Where(x => x.CategoryId == selectedCell).FirstOrDefault();

            if (MessageBox.Show("Are you sure you want to delete the category with the id - (" + category.CategoryId + ")?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Categories.Remove(category);

                context.SaveChanges();

                RefreshCategoryGridView();
            }
        }

        private void addBttn_Click(object sender, EventArgs e)
        {
            AddEditCategory addEdit = new AddEditCategory();
            addEdit.ShowDialog();

            if (addEdit.DialogResult == DialogResult.OK)
            {
                RefreshCategoryGridView();
            }
        }

        private void editBttn_Click(object sender, EventArgs e)
        {
            int selectedCell = Convert.ToInt32(dgvCategories.SelectedCells[0].OwningRow.Cells[0].Value);

            AddEditCategory addEdit = new AddEditCategory(selectedCell);
            addEdit.ShowDialog();

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
    }
}
