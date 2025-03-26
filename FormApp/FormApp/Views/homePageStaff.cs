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
    public partial class homePageStaff : Form
    {
        public homePageStaff()
        {
            InitializeComponent();
        }

        private void homePageStaff_Load(object sender, EventArgs e)
        {

        }
        private void manageBooksBtn_Click(object sender, EventArgs e)
        {
            bookList bookListForm = new bookList();
            bookListForm.Show();
            this.Hide();
        }

        private void manageRentalRequestsBtn_Click(object sender, EventArgs e)
        {
            rentalRequest rentalRequestForm = new rentalRequest();
            rentalRequestForm.Show();
            this.Hide();

        }

        private void ManageRentalTransactionsBtn_Click(object sender, EventArgs e)
        {

        }

        private void ManageReturnRecordBtn_Click(object sender, EventArgs e)
        {
            returnRecord returnRecordForm = new returnRecord();
            returnRecordForm.Show();
            this.Hide();
        }
    }
}
