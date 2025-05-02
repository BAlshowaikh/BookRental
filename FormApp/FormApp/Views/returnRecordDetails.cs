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
using Sprache;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FormApp.Views
{
    //this page shows the details for a spicefic Return Record
    //or generate a new return record
    public partial class returnRecordDetails : Form
    {
        BookRentalDBContext context = new BookRentalDBContext();
        //ReturnRecord object to be accessed to all the method in the form
        ReturnRecord returnRecord;

        //RentalTransaction object to be accessed to all the method in the form
        //this apply only in case of generating a new return record
        RentalTransaction transaction;
        public returnRecordDetails(int transactionID)
        {
            //in case of generating a new return record the user only send the transaction ID

            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);

            //set return record object an new
            returnRecord = new ReturnRecord();

            //set the transaction by ID
            this.transaction = context.RentalTransactions.Where(x => x.TransactionId == transactionID).FirstOrDefault();
        }

        public returnRecordDetails(ReturnRecord returnRecord)
        {
            //in case of viewing a record the user send a ReturnRecord objecr

            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);

            //set the object as the received one 
            this.returnRecord = returnRecord;
        }

        private void returnRecordDetails_Load(object sender, EventArgs e)
        {
            //populate the drop down list
            //the "New" condition for the book is removed becouse as soon as book is rentend it is no longer new
            ddlBookCondition.DataSource = context.BookConditions.Where(x => x.BookConditionId != 1).ToList();
            ddlBookCondition.DisplayMember = "ReturnCondition";
            ddlBookCondition.ValueMember = "BookConditionId";
            ddlBookCondition.SelectedItem = null;

            //in case of viewing
            if (returnRecord.RecordId > 0)
            {
                //populate the text fields
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

                txtExtraCharges.Text = returnRecord.TotalAdditionalCharges.ToString();

                //hide the buttons
                btnGenerate.Hide();
                btnCancel.Hide();
            }
            //in case of generating a new return record
            else
            {
                //populate the text fields with the information that can be reteved from the transaction 
                txtTransactionID.Text = transaction.TransactionId.ToString();

                txtBookName.Text = context.Books
                .Where(x => x.BookId == transaction.BookId)
                .Select(x => x.Name)
                .FirstOrDefault();

                txtExpectedReturnDate.Text = transaction.ReturnDate.ToString();


                /*adding event handler to calculate the total cost of the extra charges as soon as any changes happen
                in the date and book condition*/
                dtpActualReturnDate.ValueChanged += DatePickerHandler;
                ddlBookCondition.SelectedIndexChanged += BookConditionHandler;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                //set the returnRecord attributes 
                returnRecord.TransactionId = transaction.TransactionId;
                returnRecord.BookId = transaction.BookId;

                returnRecord.BookConditionId = Convert.ToInt32(ddlBookCondition.SelectedValue.ToString());
                returnRecord.ExpectedReturnDate = (DateTime)transaction.ReturnDate;
                returnRecord.ActualReturnDate = dtpActualReturnDate.Value;

                returnRecord.LateReturnFee = calculateLateReturnFee();
                returnRecord.TotalAdditionalCharges = getExtraChargeRate();

                //change the value so the user cannot generate another record for the same transaction
                transaction.IsReturned = true;

                //change the AvailabilityStatusId
                Book book = context.Books.Find(transaction.BookId);
                book.AvailabilityStatusId = 1;

                var totalCost  = calculateLateReturnFee() + getExtraChargeRate();
                if (MessageBox.Show("are you sure you want to generate a return record?" + "\nThe amount of the total additional charges is" + totalCost, "conferm Approval", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    context.ReturnRecords.Add(returnRecord);
                    //save the updated value
                    context.RentalTransactions.Update(transaction);
                    context.Books.Update(book);

                    context.SaveChanges();

                    //set the DialogResult as OK to indecate the change in the database
                    this.DialogResult = DialogResult.OK;

                    //redirect the user to the return record page NOT the teansaction page
                    returnRecord frmreturnRecord = new returnRecord();
                    frmreturnRecord.Show();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //this method handles the changes in the date picker 
        private void DatePickerHandler(object sender, EventArgs e)
        {
            txtLateReturnFee.Text = calculateLateReturnFee().ToString();
        }

        //this method handles the changes in the book condition drop down list
        private void BookConditionHandler(object sender, EventArgs e)
        {
            txtExtraCharges.Text = getExtraChargeRate().ToString();
        }

        //this method calculate the Total Additional Charges and returns the amount
        private double calculateLateReturnFee() {
            //the daily rate of lateFee is fixed
            var lateFee = 0.8;
            var expexter = (DateTime)transaction.ReturnDate;
            var actual = dtpActualReturnDate.Value;

            //ge defrence between the expected and actual return dates
            TimeSpan difference = actual - expexter;
            //calculate the Late Return Fee amount
            Double LateReturnFee = (difference.Days) * lateFee;
            if (LateReturnFee < 0) {
                return 0;
            }
            else
            {
                return LateReturnFee;
            }
        }
        private double getExtraChargeRate() { 
            //if the user selected a book condition
            //the Extra Charge Rate defult amout is zero 
            Double ExtraChargeRate = 0;
            if (ddlBookCondition.SelectedValue != null)
            {
                switch (ddlBookCondition.SelectedValue)
                {
                    //based on the book condition we get the ExtraChargeRate 
                    case 2:
                        ExtraChargeRate = 0;
                        break;
                    case 3:
                        ExtraChargeRate = Convert.ToDouble(context.ExtraCharges.Where(x => x.ExtraChargesId == 1).FirstOrDefault().ExtraChargeRate.ToString());
                        break;
                    case 1002:
                        ExtraChargeRate = Convert.ToDouble(context.ExtraCharges.Where(x => x.ExtraChargesId == 7).FirstOrDefault().ExtraChargeRate.ToString());
                        break;
                    case 1006:
                        ExtraChargeRate = Convert.ToDouble(context.ExtraCharges.Where(x => x.ExtraChargesId == 4).FirstOrDefault().ExtraChargeRate.ToString());
                        break;
                }
            }
            //returns both the LateReturnFee and ExtraChargeRate
            return ExtraChargeRate;
        }
        private void homeIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.homePageBtn(this);
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.exitBtn();
        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.ShowProfilePage(this);
        }
    }
}
