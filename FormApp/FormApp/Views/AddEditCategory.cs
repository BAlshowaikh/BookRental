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
    public partial class AddEditCategory : Form
    {
        BookRentalDBContext context;
        Category category;

        public AddEditCategory()
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
            context = new BookRentalDBContext();
            category = new Category();
            pageTitle.Text = "Add Category";
        }

        public AddEditCategory(int c1)
        {
            InitializeComponent();
            context = new BookRentalDBContext();
            this.category = context.Categories.Find(c1);
            pageTitle.Text = "Edit Category";
        }

        private void AddEditCategory_Load(object sender, EventArgs e)
        {
            AddEditCategories();
        }

        private void AddEditCategories()
        {
            try
            {
                //check if it's an existing category
                if (category.CategoryId > 0)
                {
                    // Populate form fields with the category data
                    txtCategoryID.Text = category.CategoryId.ToString();
                    txtCategoryName.Text = category.CategoryName;
                    if (category.IsActive)
                    isActive.Checked = true;
                }
                else
                {
                    // If this is a new category, clear the category name
                    txtCategoryName.Text = "";
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
                category.CategoryName = txtCategoryName.Text.ToString();

                // If the category has an existing ID, update the record
                if (category.CategoryId > 0)
                {
                    if (MessageBox.Show("are you sure you want to edit category ID:" + category.CategoryId + "?", "conferm Approval", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (isActive.Checked == true)
                        {
                            category.IsActive = true;
                        }
                        else 
                        {
                            category.IsActive = false;
                        }
                        context.Categories.Update(category);
                    }
                }
                else // add a new category
                {
                    if (MessageBox.Show("are you sure you want to add this category? ", "conferm Approval", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (isActive.Checked == true)
                        {
                            category.IsActive = true;
                        }
                        else
                        {
                            category.IsActive = false;
                        }

                        context.Categories.Add(category);
                    }
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

        private void homeIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.homePageBtn(this);
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.exitBtn();
        }

        private void cancelBttn_Click(object sender, EventArgs e)
        {
            // Close the form and return Cancel 
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.ShowProfilePage(this);
        }
    }
}
