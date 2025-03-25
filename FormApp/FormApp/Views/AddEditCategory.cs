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
    public partial class AddEditCategory : Form
    {
        BookRentalDBContext context;
        Category category;

        public AddEditCategory()
        {
            InitializeComponent();
            context = new BookRentalDBContext();
            category = new Category();
        }

        public AddEditCategory(Category c1)
        {
            InitializeComponent();
            context = new BookRentalDBContext();
            this.category = c1;
        }

        private void AddEditCategory_Load(object sender, EventArgs e)
        {
            AddEditCategories();
        }

        private void AddEditCategories()
        {
            if (category.CategoryId > 0)
            {
                txtCategoryID.Text = category.CategoryId.ToString();
                txtCategoryName.Text = category.CategoryName;
            }
            else
            {
                txtCategoryName.Text = "";
            }
        }

        private void addBttn_Click(object sender, EventArgs e)
        {
            try
            {
                if(int.TryParse(txtCategoryID.Text, out int categoryID))
                {
                    category.CategoryId = categoryID;
                }

                category.CategoryName = txtCategoryName.Text.ToString();

                if (category.CategoryId > 0)
                {
                    context.Categories.Update(category);
                }
                else
                {
                    context.Categories.Add(category);
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
