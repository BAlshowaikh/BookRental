using BookRentalObject;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FormApp.Controllers;

namespace FormApp.Views
{
    //this page shows the details for a spicefic Rental Request
    //this page allows the user to approve or reject pending requests 
    //this page gaves the user the ability to create a transaction when the request is approved
    public partial class rentalRequestDetails : Form
    {
        BookRentalDBContext context = new BookRentalDBContext();
        //private variable for thr request ID do it is accessed to all the method in the form
        private int requestID;
        public rentalRequestDetails(int requestID)
        {
            //set the requestID as the reseved requestID
            this.requestID = requestID;
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
        }

        private void rentalRequestDetails_Load(object sender, EventArgs e)
        {
            //get the request as an object 
            var request = context.RentalRequests.FirstOrDefault(x => x.RequestId == requestID);

            //a variable for the book ID, used more than once
            var bookID = request.BookId;

            //populate the text fields
            txtRequestID.Text = requestID.ToString();

            txtUserName.Text = context.Users
                .Where(x => x.UserId == request.UserId)
                .Select(x => x.FullName)
                .FirstOrDefault();

            lblUserID.Text = "User ID: " + request.UserId.ToString();
            txtBookID.Text = bookID.ToString();

            txtBookName.Text = context.Books
                .Where(x => x.BookId == bookID)
                .Select(x => x.Name)
                .FirstOrDefault();

            //get the book status and set the lable
            var bookStatus = context.Books
                .Where(x => x.BookId == bookID)
                .Select(x => x.AvailabilityStatus.AvailabilityStatus1)
                .FirstOrDefault();
            lblBookStatus.Text = "This Book is " + bookStatus;

            txtStartDate.Text = request.RentalStartDate.ToString();
            txtReturnDate.Text = request.ReturnDate.ToString();
            txtTotalCost.Text = request.TotalCost.ToString();

            var statusId = request.RentalRequestStatusId;
            txtStatus.Text = context.RentalRequestStatuses
                .Where(x => x.RentalRequestStatusId == statusId)
                .Select(x => x.Status)
                .FirstOrDefault();

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                var request = context.RentalRequests.FirstOrDefault(x => x.RequestId == requestID);
                //if the request status is "pending"
                if (request.RentalRequestStatusId == 1)
                {
                    if (MessageBox.Show("are you sure you want to approve requst ID:" + requestID + "?", "conferm Approval", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //set the status ID as 2 -> approved
                        request.RentalRequestStatusId = 2;
                        context.RentalRequests.Update(request);

                        context.SaveChanges();

                        //set the DialogResult as OK to indecate the change in the database
                        this.DialogResult = DialogResult.OK;
                        this.Close();

<<<<<<< HEAD
                        EditTransaction editTransaction = new EditTransaction(requestID);
                        editTransaction.ShowDialog();
=======
                        //GeneratedRransaction generatedRransaction = new GeneratedRransaction();
>>>>>>> 6f807689b52fcc50769e98269e9124e41d93ba22
                    }

                }
                //if the request status is NOT "pending"
                else
                {
                    //the user cannot approve the request after it has been approved or rejected previously
                    MessageBox.Show("This request cannot be approved, it has been "
                        + context.RentalRequestStatuses
                        .Where(x => x.RentalRequestStatusId == request.RentalRequestStatusId)
                        .Select(x => x.Status)
                        .FirstOrDefault());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            try
            {
                var request = context.RentalRequests.FirstOrDefault(x => x.RequestId == requestID);
                //if the request status is "pending"
                if (request.RentalRequestStatusId == 1)
                {
                    if (MessageBox.Show("are you sure you want to reject requst ID:" + requestID + "?", "conferm Rejection", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //set the status ID as 3 -> rejected
                        request.RentalRequestStatusId = 3;
                        context.RentalRequests.Update(request);

                        context.SaveChanges();
                        //set the DialogResult as OK to indecate the change in the database
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                //if the request status is NOT "pending"
                else
                {
                    //the user cannot approve the request after it has been approved or rejected previously
                    MessageBox.Show("This request cannot be rejected, it has been "
                        + context.RentalRequestStatuses
                        .Where(x => x.RentalRequestStatusId == request.RentalRequestStatusId)
                        .Select(x => x.Status)
                        .FirstOrDefault());
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

        private void userIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.ShowProfilePage(this);
        }
    }
}
