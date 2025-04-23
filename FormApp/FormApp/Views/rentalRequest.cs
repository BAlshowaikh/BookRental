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
using FormApp.Controllers;
using BookRentalObject;

using Microsoft.VisualBasic.ApplicationServices;



namespace FormApp.Views
{
    //this page is to view all the Rental Requests in the database and filter them if needed
    //this bage include a redirection to the rental request details page
    public partial class rentalRequest : Form
    {
        BookRentalDBContext context = new BookRentalDBContext();
        public rentalRequest()
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
        }

        private void rentalRequest_Load(object sender, EventArgs e)
        {
            //user drop down list 
            ddlFilterUser.DataSource = context.Users.ToList(); ;
            ddlFilterUser.DisplayMember = "FullName";
            ddlFilterUser.ValueMember = "UserId";
            ddlFilterUser.SelectedItem = null;

            //refreshing the grid view
            RefreshRentalRequestGridview();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //refreshing the grid view
            RefreshRentalRequestGridview();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //refreshing the grid view mainly after adding a filter 
            RefreshRentalRequestGridview();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            //remove the existing filters
            txtFilterRequestNo.Text = string.Empty;
            txtFilterRequestNo.Focus();

            ddlFilterUser.SelectedValue = string.Empty;

            //refreshing the grid view
            RefreshRentalRequestGridview();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            //get the request ID and redirect the user ro the details page 
            int cell = Convert.ToInt32(dgvRentalRequest.SelectedCells[0].OwningRow.Cells[0].Value);
            rentalRequestDetails frmrentalRequestDetails = new rentalRequestDetails(cell);
            frmrentalRequestDetails.ShowDialog();

            //DialogResult.OK means that the use changed something in the DB
            if (frmrentalRequestDetails.DialogResult == DialogResult.OK)
            {
                //if so then refresh the grid view 
                RefreshRentalRequestGridview();
            }
        }

        private void RefreshRentalRequestGridview()
        {
            dgvRentalRequest.DataSource = null;
            //create a varible to hold the data needed to be shown
            var RequestToShow = context.RentalRequests.AsQueryable();

            //in case of filtering by the id
            if (txtFilterRequestNo.Text != "")
            {
                RequestToShow = RequestToShow
                    .Where(x => x.RequestId == Convert.ToInt32(txtFilterRequestNo.Text));
            }
            //in case of filtering by the drop down list
            else if (ddlFilterUser.SelectedValue != null)
            {
                RequestToShow = RequestToShow
                    .Where(x => x.UserId == Convert.ToInt32(ddlFilterUser.SelectedValue.ToString()));
            }

            //customize the data grid view
            dgvRentalRequest.DataSource = RequestToShow.Select(x => new
            {
                RequestID = x.RequestId,
                UserName = x.User.FullName,
                RentalRequestStatus = x.RentalRequestStatus.Status,
                BookID = x.BookId,
                StartDate = x.RentalStartDate
            }).ToList();
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
