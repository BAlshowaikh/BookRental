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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FormApp.Views
{
    public partial class EditTransaction : Form
    {
        BookRentalDBContext context;
        RentalRequest request;
        RentalTransaction transaction;
        bool edit = false;

        public EditTransaction()
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
            context = new BookRentalDBContext();
        }

        public EditTransaction(int transactionID, bool edit)
        {
            InitializeComponent();
            context = new BookRentalDBContext();
            this.transaction = context.RentalTransactions.Include(x => x.User).Include(x => x.Book).Where(x => x.TransactionId == transactionID).FirstOrDefault();
            this.edit = edit;
            LoadTransactionData();
            HelperFunctions.setUpFormDesign(this);
        }

        public EditTransaction(int requestID)
        {
            InitializeComponent();
            context = new BookRentalDBContext();
            this.request = context.RentalRequests.Include(x => x.User).Include(x => x.Book).Where(x => x.RequestId == requestID).FirstOrDefault();
            LoadRequestData();
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.homePageBtn(this);
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.exitBtn();
        }

        private void EditTransaction_Load(object sender, EventArgs e)
        {
            if (request != null)
            {
                LoadRequestData();
            }
            if (transaction != null)
            {
                LoadTransactionData();
            }
            populatePaymentMethod();
            populatePaymentStatus();
        }

        private void populatePaymentMethod()
        {
            try
            {
                //Set the data source of the drop down to the list of payment methods
                ddlPaymentMethod.DataSource = context.PaymentMethods.ToList();
                ddlPaymentMethod.DisplayMember = "PaymentMethod1"; // Set which property to display in the dropdown
                ddlPaymentMethod.ValueMember = "PaymentMethodId"; // Set the value property for each dropdown item
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populatePaymentStatus()
        {
            try
            {
                //Set the data source of the drop down to the list of payment status
                ddlPaymentStatus.DataSource = context.PaymentStatuses.ToList();
                ddlPaymentStatus.DisplayMember = "Status"; // Set which property to display in the dropdown
                ddlPaymentStatus.ValueMember = "PaymentId"; // Set the value property for each dropdown item
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadRequestData()
        {
            try
            {
                if (request != null)
                {
                    //populate the form with rental request info
                    txtTransactionID.Text = "New";
                    txtCustomerName.Text = request.User.FullName;
                    txtBookName.Text = request.Book.Name;
                    dtpRentalStartDate.Value = request.RentalStartDate;
                    dtpReturnDate.Value = request.ReturnDate;
                    txtRentalFee.Text = request.TotalCost.ToString();
                    txtRentalPeriod.Text = CalculateRentalPeriod(request.RentalStartDate, request.ReturnDate).ToString();

                    txtRentalPeriod.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadTransactionData()
        {
            try
            {
                if (transaction != null)
                {
                    //populate the form with rental trnasaction info
                    txtTransactionID.Text = transaction.TransactionId.ToString();
                    txtCustomerName.Text = transaction.User.FullName;
                    txtBookName.Text = transaction.Book.Name;
                    txtRentalFee.Text = transaction.RentalFee.ToString();
                    txtRentalPeriod.Text = CalculateRentalPeriod(transaction.RentalStartDate, transaction.ReturnDate).ToString();
                    ddlPaymentMethod.SelectedValue = transaction.PaymentMethodId;
                    ddlPaymentStatus.SelectedValue = transaction.PaymentStatusId;
                    dtpRentalStartDate.Value = transaction.RentalStartDate;
                    dtpReturnDate.Value = transaction.ReturnDate;

                    txtRentalPeriod.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int CalculateRentalPeriod(DateTime? startDate, DateTime? returnDate)
        {
            if (startDate.HasValue && returnDate.HasValue)
            {
                return (returnDate.Value - startDate.Value).Days;
            }
            return 0; // or -1 to indicate missing dates
        }

        private void saveBttn_Click(object sender, EventArgs e)
        {
            if (transaction != null)
            {
                // Update existing transaction
                transaction.RentalStartDate = dtpRentalStartDate.Value;
                transaction.ReturnDate = dtpReturnDate.Value;
                transaction.RentalFee = Convert.ToDouble(txtRentalFee.Text);
                transaction.PaymentMethodId = Convert.ToInt32(ddlPaymentMethod.SelectedValue);
                transaction.PaymentStatusId = Convert.ToInt32(ddlPaymentStatus.SelectedValue);
                transaction.RentalPeriod = CalculateRentalPeriod(transaction.RentalStartDate, transaction.ReturnDate);

                //update the existing rental transaction
                context.RentalTransactions.Update(transaction);
            }
            else if (request != null)
            {
                // Create new transaction
                var newTransaction = new RentalTransaction
                {
                    UserId = request.UserId,
                    BookId = request.BookId,
                    RentalStartDate = dtpRentalStartDate.Value,
                    ReturnDate = dtpReturnDate.Value,
                    RentalFee = Convert.ToDouble(txtRentalFee.Text),
                    PaymentMethodId = Convert.ToInt32(ddlPaymentMethod.SelectedValue),
                    PaymentStatusId = Convert.ToInt32(ddlPaymentStatus.SelectedValue),
                    RentalPeriod = CalculateRentalPeriod(dtpRentalStartDate.Value, dtpReturnDate.Value)
                };

                // add a new rental transaction
                context.RentalTransactions.Add(newTransaction);
                txtTransactionID.Text = newTransaction.TransactionId.ToString();
            }

            // Save changes to the database
            context.SaveChanges();
            MessageBox.Show("Transaction saved successfully");

            // Close the form and return OK result
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void UpdateRentalPeriod()
        {
            // Updates the rental period text field
            txtRentalPeriod.Text = CalculateRentalPeriod(dtpRentalStartDate.Value, dtpReturnDate.Value).ToString();
        }

        private void dtpRentalStartDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateRentalPeriod();
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateRentalPeriod();
        }

        private void cancelBttn_Click(object sender, EventArgs e)
        {
            // Close the form and return Cancel 
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void exitIcon_Click_1(object sender, EventArgs e)
        {
            HelperFunctions.exitBtn();
        }
    }
}
