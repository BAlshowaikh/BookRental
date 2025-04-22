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

        // Event handler for the Manage Books button
        private void manageBooksBtn_Click(object sender, EventArgs e)
        {
            Form bookListForm = new bookList();
            HelperFunctions.navigationToPage(this, bookListForm);
        }

        // Event handler for the Rental Requests button
        private void manageRentalRequestsBtn_Click(object sender, EventArgs e)
        {
            Form manageRentalRequestForm = new rentalRequest();
            HelperFunctions.navigationToPage(this, manageRentalRequestForm);

        }

        // Event handler for the Manage Rental Transactions button
        private void ManageRentalTransactionsBtn_Click(object sender, EventArgs e)
        {
            Form ViewTransactions = new ViewTransactions();
            HelperFunctions.navigationToPage(this, ViewTransactions);
        }

        // Event handler for the Manage Return Record button
        private void ManageReturnRecordBtn_Click(object sender, EventArgs e)
        {
            Form returnRecordForm = new returnRecord();
            HelperFunctions.navigationToPage(this, returnRecordForm);
        }

        // Event handler for the Generating Book Record form button
        private void GenerateRecordBtn_Click(object sender, EventArgs e)
        {
            Form auditTrails = new Audit_Trails();
            HelperFunctions.navigationToPage(this, auditTrails);
        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.ShowProfilePage(this);
        }
    }
}
