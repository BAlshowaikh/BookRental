using FormApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp
{
    public partial class homePageAdmin : Form
    {
        public homePageAdmin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rentalRequest rentalRequestForm = new rentalRequest();
            rentalRequestForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void exitIcon_Click(object sender, EventArgs e)
        {

        }

        private void manageUsersBtn_Click(object sender, EventArgs e)
        {
            ManageUser manageUserForm = new ManageUser();
            manageUserForm.Show();
            this.Hide();
        }

        private void manageBooksBtn_Click(object sender, EventArgs e)
        {
            bookList bookListForm = new bookList();
            bookListForm.Show();
            this.Hide();
        }

        private void manageRentalRecordsBtn_Click(object sender, EventArgs e)
        {
            returnRecord returnRecordForm = new returnRecord();
            returnRecordForm.Show();
            this.Hide();
        }
    }
}
