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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace FormApp.Views
{
    public partial class ViewTransactions : Form
    {
        BookRentalDBContext context;

        public ViewTransactions()
        {
            InitializeComponent();
            context = new BookRentalDBContext();
            HelperFunctions.setUpFormDesign(this);
        }

        private void addBttn_Click(object sender, EventArgs e)
        {

        }

        private void ViewTransactions_Load(object sender, EventArgs e)
        {
            PopulateCustomerDDL();
            RefreshGridView();
        }

        private void PopulateCustomerDDL()
        {
            ddlCustomer.DataSource = context.Users.Where(x => x.UserRole.Role == "Customer").ToList();
            ddlCustomer.DisplayMember = "FullName";
            ddlCustomer.ValueMember = "userId";
            ddlCustomer.SelectedItem = null;
        }

        private void RefreshGridView()
        {
            var transaction = context.RentalTransactions.AsQueryable();

            if (txtTransactionID.Text != "")
            {
                transaction = transaction.Where(x => x.TransactionId == Convert.ToInt32(txtTransactionID.Text));
            }
            if (ddlCustomer.SelectedItem != null)
            {
                transaction = transaction.Where(x => x.UserId == Convert.ToInt32(ddlCustomer.SelectedValue));
            }

            dgvTransaction.DataSource = transaction.Select(x => new
            {
                TransactionID = x.TransactionId,
                BookName = x.Book.Name,
                CustomerName = x.User.FullName,
                RentalStartDate = x.RentalStartDate,
                ReturnDate = x.ReturnDate,
                RentalFee = x.RentalFee,
                IsReturned = x.IsReturned
            }).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filterBttn_Click(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void refreshBttn_Click(object sender, EventArgs e)
        {
            ddlCustomer.SelectedItem = null;
            txtTransactionID.Text = "";
            RefreshGridView();
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.homePageBtn(this);
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.exitBtn();
        }

        private void btnGenerateRecord_Click(object sender, EventArgs e)
        {
            //get the transaction ID and send it to a new returnRecordDetails form
            int cell = Convert.ToInt32(dgvTransaction.SelectedCells[0].OwningRow.Cells[0].Value);

            //check if this transaction have been returned befor
            var t = context.RentalTransactions.Where(x => x.TransactionId == cell).FirstOrDefault().IsReturned;

            //if it have not been returned than redirect the user to generate a return record
            if (t == false)
            {
                returnRecordDetails frmreturnRecordDetails = new returnRecordDetails(cell);
                frmreturnRecordDetails.Show();
                this.Hide();
            }
            else
            //if it have been returnd show a message to inform the user
            {
                MessageBox.Show("This transaction have been return, you cannot create another return record");
            }
        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.ShowProfilePage(this);
        }
    }
}
