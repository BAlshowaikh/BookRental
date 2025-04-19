using BookRentalObject;
using FormApp.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp.Views
{
    //this page is to view all the logging trails in the database and filter them if needed
    public partial class Logging : Form
    {
        BookRentalDBContext context = new BookRentalDBContext();
        public Logging()
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
        }

        private void Logging_Load(object sender, EventArgs e)
        {
            //user drop down list
            ddlFilterUser.DataSource = context.Users.ToList(); ;
            ddlFilterUser.DisplayMember = "FullName";
            ddlFilterUser.ValueMember = "UserId";
            ddlFilterUser.SelectedItem = null;

            //refreshing the grid view
            RefreshLogTrailsGridview();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //refreshing the grid view
            RefreshLogTrailsGridview();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //refreshing the grid view mainly after adding a filter 
            RefreshLogTrailsGridview();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            //remove the existing filters
            txtFilterTrailsNo.Text = string.Empty;
            txtFilterTrailsNo.Focus();

            ddlFilterUser.SelectedValue = string.Empty;

            //refreshing the grid view
            RefreshLogTrailsGridview();
        }

        private void RefreshLogTrailsGridview()
        {
            dgvLogTrail.DataSource = null;
            //create a varible to hold the data needed to be shown
            var TrailsToShow = context.Logs.AsQueryable();

            //in case of filtering by the id
            if (txtFilterTrailsNo.Text != "")
            {
                TrailsToShow = TrailsToShow
                    .Where(x => x.LogId == Convert.ToInt32(txtFilterTrailsNo.Text));
            }
            //in case of filtering by the drop down list
            else if (ddlFilterUser.SelectedValue != null)
            {
                TrailsToShow = TrailsToShow
                    .Where(x => x.UserId == Convert.ToInt32(ddlFilterUser.SelectedValue.ToString()));
            }

            //customize the data grid view
            dgvLogTrail.DataSource = TrailsToShow.Select(x => new 
            {
                LogID = x.LogId,
                UserName = x.User.FullName,
                x.Timestamp,
                x.AffectedData,
                x.Source,
                x.Exceptions
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
    }
}
