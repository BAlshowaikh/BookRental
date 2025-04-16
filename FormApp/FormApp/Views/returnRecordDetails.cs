using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BookRentalObject;
using FormApp.Controllers;

namespace FormApp.Views
{
    public partial class returnRecordDetails : Form
    {
        BookRentalDBContext context = new BookRentalDBContext();
        ReturnRecord returnRecord;
        RentalTransaction transaction;
        public returnRecordDetails(int transactionID)
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
            returnRecord = new ReturnRecord();
            this.transaction = context.RentalTransactions.Where(x => x.TransactionId == transactionID).FirstOrDefault();
        }

        public returnRecordDetails(ReturnRecord returnRecord)
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
            this.returnRecord = returnRecord;
        }

        private void returnRecordDetails_Load(object sender, EventArgs e)
        {
            ddlBookCondition.DataSource = context.BookConditions.ToList();
            ddlBookCondition.DisplayMember = "ReturnCondition";
            ddlBookCondition.ValueMember = "BookConditionId";
            ddlBookCondition.SelectedItem = null;


            if (returnRecord.RecordId > 0)
            {
                txtRecordID.Text = returnRecord.RecordId.ToString();
                txtTransactionID.Text = returnRecord.TransactionId.ToString();

                txtBookName.Text = context.Books
                .Where(x => x.BookId == returnRecord.BookId)
                .Select(x => x.Name)
                .FirstOrDefault();

                ddlBookCondition.SelectedValue = returnRecord.BookConditionId;
                ddlBookCondition.Enabled = false;

                txtExpectedReturnDate.Text = returnRecord.ExpectedReturnDate.ToString();
                txtLateReturnFee.ReadOnly = true;

                dtpActualReturnDate.Value = returnRecord.ActualReturnDate;
                dtpActualReturnDate.Enabled = false;

                txtLateReturnFee.Text = returnRecord.LateReturnFee.ToString();
                txtLateReturnFee.ReadOnly = true;

                txtTotalCost.Text = returnRecord.TotalAdditionalCharges.ToString();


                btnGenerate.Text = "Return";
                btnCancel.Hide();
            }
            else
            {
                txtTransactionID.Text = transaction.TransactionId.ToString();

                txtBookName.Text = context.Books
                .Where(x => x.BookId == transaction.BookId)
                .Select(x => x.Name)
                .FirstOrDefault();

                txtExpectedReturnDate.Text = transaction.ReturnDate.ToString();

                txtTotalCost.Text = "Not Calculated";
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (returnRecord.RecordId > 0)
            {
                this.Hide();
            }
            else
            {
                try
                {
                    var ExpectedReturnDate = (DateTime)transaction.ReturnDate;
                    var ActualReturnDate = dtpActualReturnDate.Value;
                    var LateReturnFee = double.Parse(txtLateReturnFee.Text.Trim());

                    returnRecord.TransactionId = transaction.TransactionId;
                    returnRecord.BookId = transaction.BookId;
                    returnRecord.BookConditionId = Convert.ToInt32(ddlBookCondition.SelectedValue.ToString());

                    returnRecord.ExpectedReturnDate = ExpectedReturnDate;
                    returnRecord.ActualReturnDate = ActualReturnDate;
                    returnRecord.LateReturnFee = LateReturnFee;

                    returnRecord.TotalAdditionalCharges =
                        calculateTotalCharges(ExpectedReturnDate, ActualReturnDate, LateReturnFee);

                    context.ReturnRecords.Add(returnRecord);
                    context.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private Double calculateTotalCharges(DateTime expexter, DateTime actual, Double lateFee)
        {
            TimeSpan difference = expexter - actual;

            Double amount = (difference.Days)*lateFee;

            return amount;
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.homePageBtn(this);
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.exitBtn();
        }
    }
}
