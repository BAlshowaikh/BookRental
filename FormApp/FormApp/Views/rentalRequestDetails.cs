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

    public partial class rentalRequestDetails : Form
    {
        BookRentalDBContext context = new BookRentalDBContext();
        private int requestID;
        public rentalRequestDetails(int requestID)
        {
            this.requestID = requestID;
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
        }

        private void rentalRequestDetails_Load(object sender, EventArgs e)
        {
            var request = context.RentalRequests.FirstOrDefault(x => x.RequestId == requestID);
            var bookID = request.BookId;
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
                if (request.RentalRequestStatusId == 1)
                {
                    if (MessageBox.Show("are you sure you want to approve requst ID:" + requestID + "?", "conferm Approval", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        request.RentalRequestStatusId = 2;
                        context.RentalRequests.Update(request);

                        context.SaveChanges();

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        //GeneratedRransaction generatedRransaction = new GeneratedRransaction();
                    }

                }
                else
                {
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
                if (request.RentalRequestStatusId == 1)
                {
                    if (MessageBox.Show("are you sure you want to reject requst ID:" + requestID + "?", "conferm Rejection", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        request.RentalRequestStatusId = 3;
                        context.RentalRequests.Update(request);

                        context.SaveChanges();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
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

    }
}
