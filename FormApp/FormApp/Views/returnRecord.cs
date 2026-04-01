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
    //this page is to view all the Return Records in the database and filter them if needed
    //this bage include a redirection to the return record details page
    public partial class returnRecord : Form
    {
        BookRentalDBContext context = new BookRentalDBContext();
        public returnRecord()
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
        }

        private void returnRecord_Load(object sender, EventArgs e)
        {
            //book drop down list 
            ddlFilterCondition.DataSource = context.BookConditions.Where(x=>x.BookConditionId != 1).ToList(); ;
            ddlFilterCondition.DisplayMember = "ReturnCondition";
            ddlFilterCondition.ValueMember = "BookConditionId";
            ddlFilterCondition.SelectedItem = null;

            //refreshing the grid view
            RefreshReturnRecourdGridview();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //refreshing the grid view
            RefreshReturnRecourdGridview();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //refreshing the grid view mainly after adding a filter 
            RefreshReturnRecourdGridview();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            //remove the existing filters
            txtFilterRecordNo.Text = String.Empty;
            txtFilterRecordNo.Focus();

            ddlFilterCondition.SelectedValue = string.Empty;

            //refreshing the grid view
            RefreshReturnRecourdGridview();
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            //get the record ID
            int cell = Convert.ToInt32(dgvReturnRecourd.SelectedCells[0].OwningRow.Cells[0].Value);
            //get the ReturnRecord from the ID (as object)
            ReturnRecord selected = context.ReturnRecords.Find(cell);

            //sed the object to a new return record details page
            returnRecordDetails frmreturnRecordDetails = new returnRecordDetails(selected);
            frmreturnRecordDetails.ShowDialog();

            //DialogResult.OK means that the use changed something in the DB
            if (frmreturnRecordDetails.DialogResult == DialogResult.OK)
            {
                //if so then refresh the grid view 
                RefreshReturnRecourdGridview();
            }
        }

        private void RefreshReturnRecourdGridview()
        {
            dgvReturnRecourd.DataSource = null;
            //create a varible to hold the data needed to be shown
            var RequestToShow = context.ReturnRecords.AsQueryable();

            //in case of filtering by the id
            if (txtFilterRecordNo.Text != "")
            {
                RequestToShow = RequestToShow
                    .Where(x => x.RecordId == Convert.ToInt32(txtFilterRecordNo.Text));
            }
            //in case of filtering by the drop down list
            else if (ddlFilterCondition.SelectedValue != null)
            {
                RequestToShow = RequestToShow
                    .Where(x => x.BookConditionId == Convert.ToInt32(ddlFilterCondition.SelectedValue.ToString()));
            }

            //customize the data grid view
            dgvReturnRecourd.DataSource = RequestToShow.Select(x => new
            {
                RecordID = x.RecordId,
                BookName = x.Book.Name,
                BookCondition = x.BookCondition.ReturnCondition,
                UserName = x.Transaction.User.FullName,
                x.ExpectedReturnDate,
                x.ActualReturnDate,
                TotalAdditionalCharges = x.TotalAdditionalCharges + x.LateReturnFee,
                LateReturnFee = x.LateReturnFee,
                x.TransactionId

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

        private void filterGB_Enter(object sender, EventArgs e)
        {

        }
    }
}
