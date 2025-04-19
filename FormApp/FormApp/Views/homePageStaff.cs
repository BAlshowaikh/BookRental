using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormApp.Controllers;

namespace FormApp.Views
{
    public partial class homePageStaff : Form
    {
        public homePageStaff()
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
        }

        private void homePageStaff_Load(object sender, EventArgs e)
        {

        }
        private void manageBooksBtn_Click(object sender, EventArgs e)
        {
            Form bookListForm = new bookList();
            HelperFunctions.navigationToPage(this, bookListForm);
        }

        private void manageRentalRequestsBtn_Click(object sender, EventArgs e)
        {
            Form manageRentalRequestForm = new rentalRequest();
            HelperFunctions.navigationToPage(this, manageRentalRequestForm);

        }

        private void ManageRentalTransactionsBtn_Click(object sender, EventArgs e)
        {
            Form ViewTransactions = new ViewTransactions();
            HelperFunctions.navigationToPage(this, ViewTransactions);
        }

        private void ManageReturnRecordBtn_Click(object sender, EventArgs e)
        {
            Form returnRecordForm = new returnRecord();
            HelperFunctions.navigationToPage(this, returnRecordForm);
        }

        private void GenerateRecordBtn_Click(object sender, EventArgs e)
        {
            Form auditTrails = new Audit_Trails();
            HelperFunctions.navigationToPage(this, auditTrails);
        }
    }
}
