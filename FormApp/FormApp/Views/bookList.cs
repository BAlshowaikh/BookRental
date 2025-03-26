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

namespace FormApp
{
    public partial class bookList : Form
    {
        BookRentalDBContext context;
        public bookList()
        {
            InitializeComponent();
            context = new BookRentalDBContext();
        }
        private void bookList_Load(object sender, EventArgs e)
        {
            LoadBookData();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void refreshBttn_Click(object sender, EventArgs e)
        {

        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {

        }

        private void dgvBooksList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Function to load the book table into the grid view
        private void LoadBookData()
        {
            try
            {
                dgvBooksList.DataSource = context.Books.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading book data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
