using FormApp.Controllers;
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
            HelperFunctions.setUpFormDesign(this);
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.exitBtn();
        }

        // Opens the Manage User form
        private void manageUsersBtn_Click(object sender, EventArgs e)
        {
            Form manageUserForm = new ManageUser();
            HelperFunctions.navigationToPage(this, manageUserForm);

        }

        // Opens the Book List form 
        private void manageBooksBtn_Click(object sender, EventArgs e)
        {
            Form bookListForm = new bookList();
            HelperFunctions.navigationToPage(this, bookListForm);
        }

        // Opens the Return Records form
        private void manageRentalRecordsBtn_Click(object sender, EventArgs e)
        {
            Form returnRecordForm = new returnRecord();
            HelperFunctions.navigationToPage(this, returnRecordForm);

        }

        // Opens the Rental Request form
        private void manageRentalRequestBtn_Click(object sender, EventArgs e)
        {
            Form manageRentalRequestForm = new rentalRequest();
            HelperFunctions.navigationToPage(this, manageRentalRequestForm);
        }

        //Opens the Manage Rental Record form
        private void manageRentalRecordsBtn_Click_1(object sender, EventArgs e)
        {
            Form manageReturnRecordsForm = new returnRecord();
            HelperFunctions.navigationToPage(this, manageReturnRecordsForm);
        }


        // Opens the Manage Transactions form
        private void manageRentalTransictionsBtn_Click(object sender, EventArgs e)
        {
            Form ViewTransactions = new ViewTransactions();
            HelperFunctions.navigationToPage(this, ViewTransactions);
        }

        // Opens the Audit Trails form 
        private void generateRecordsBtn_Click(object sender, EventArgs e)
        {
            Form loginTrails = new Logging();
            HelperFunctions.navigationToPage(this, loginTrails);
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.homePageBtn(this);
        }

        private void btnViewAuditTrails_Click(object sender, EventArgs e)
        {
            Form auditTrails = new Audit_Trails();
            HelperFunctions.navigationToPage(this, auditTrails);
        }

        private void homePageAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
