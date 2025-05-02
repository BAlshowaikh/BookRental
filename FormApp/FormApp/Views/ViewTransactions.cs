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
            try
            {
                //Set the data source of the drop down to the list of customers
                ddlCustomer.DataSource = context.Users.Where(x => x.UserRole.Role == "Customer").ToList();
                ddlCustomer.DisplayMember = "FullName"; // Set which property to display in the dropdown
                ddlCustomer.ValueMember = "userId"; // Set the value property for each dropdown item
                ddlCustomer.SelectedItem = null; // Clear any pre-selected item
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshGridView()
        {
            try
            {
                var transaction = context.RentalTransactions.AsQueryable();

                // If a Transaction ID is entered, filter the transactions by the specified ID
                if (txtTransactionID.Text != "")
                {
                    transaction = transaction.Where(x => x.TransactionId == Convert.ToInt32(txtTransactionID.Text));
                }

                // If a customer is selected in the dropdown, filter the transactions by the selected customer ID
                if (ddlCustomer.SelectedItem != null)
                {
                    transaction = transaction.Where(x => x.UserId == Convert.ToInt32(ddlCustomer.SelectedValue));
                }

                //Project the filtered transaction into an anonymous type, then convert the result to a list and bind it to the data grid view.
                dgvTransaction.DataSource = transaction.Select(x => new
                {
                    TransactionID = x.TransactionId,
                    BookName = x.Book.Name,
                    CustomerName = x.User.FullName,
                    RentalStartDate = x.RentalStartDate,
                    ReturnDate = x.ReturnDate,
                    RentalFee = x.RentalFee,
                    PaymentMethod = x.PaymentMethod.PaymentMethod1,
                    PaymentStatus = x.PaymentStatus.PaymentStatus1
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filterBttn_Click(object sender, EventArgs e)
        {
            RefreshGridView(); //Call the method to filter if any filters were applied
        }

        private void refreshBttn_Click(object sender, EventArgs e)
        {
            ddlCustomer.SelectedItem = null; // Clear any pre-selected item
            txtTransactionID.Text = ""; // Clear the text box
            RefreshGridView(); //Refresh the view to remove the filters
        }

        private void generateRecordBttn_Click(object sender, EventArgs e)
        {

        }

        private void editBttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTransaction.SelectedCells.Count > 0)
                {
                    int selectedCell = Convert.ToInt32(dgvTransaction.SelectedCells[0].OwningRow.Cells[0].Value);

                    EditTransaction editTransaction = new EditTransaction(selectedCell, true);
                    editTransaction.StartPosition = FormStartPosition.CenterScreen;
                    editTransaction.ShowDialog();

                    if (editTransaction.DialogResult == DialogResult.OK)
                    {
                        RefreshGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
