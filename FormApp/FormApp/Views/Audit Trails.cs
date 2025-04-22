using BookRentalObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormApp.Controllers;

namespace FormApp
{
    //this page is to view all the Audit trails in the database and filter them if needed
    public partial class Audit_Trails : Form
    {
        BookRentalDBContext context = new BookRentalDBContext();
        public Audit_Trails()
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
        }

        private void Audit_Trails_Load(object sender, EventArgs e)
        {
            //user drop down list 
            ddlFilterUser.DataSource = context.Users.ToList(); ;
            ddlFilterUser.DisplayMember = "FullName";
            ddlFilterUser.ValueMember = "UserId";
            ddlFilterUser.SelectedItem = null;

            //refreshing the grid view
            RefreshAuditTrailsGridview();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            //refreshing the grid view
            RefreshAuditTrailsGridview();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //refreshing the grid view mainly after adding a filter 
            RefreshAuditTrailsGridview();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //remove the existing filters
            txtFilterTrailsNo.Text = String.Empty;
            txtFilterTrailsNo.Focus();

            ddlFilterUser.SelectedValue = string.Empty;

            //refreshing the grid view
            RefreshAuditTrailsGridview();
        }

        private void RefreshAuditTrailsGridview()
        {
            dgvAuditTrail.DataSource = null;
            //create a varible to hold the data needed to be shown
            var TrailsToShow = context.AuditTrails.AsQueryable();

            //in case of filtering by the id
            if (txtFilterTrailsNo.Text != "")
            {
                TrailsToShow = TrailsToShow
                    .Where(x => x.AuditId == Convert.ToInt32(txtFilterTrailsNo.Text));
            }
            //in case of filtering by the drop down list
            else if (ddlFilterUser.SelectedValue != null)
            {
                TrailsToShow = TrailsToShow
                    .Where(x => x.UserId == Convert.ToInt32(ddlFilterUser.SelectedValue.ToString()));
            }

            //customize the data grid view
            dgvAuditTrail.DataSource = TrailsToShow.Select(x => new
            {
                AuditID = x.AuditId,
                x.Timestamp,
                x.OldValue,
                x.NewValue,
                UserName = x.User.FullName
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
