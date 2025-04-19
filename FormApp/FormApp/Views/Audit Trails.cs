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

            ddlFilterUser.DataSource = context.Users.ToList(); ;

            ddlFilterUser.DisplayMember = "FullName";
            ddlFilterUser.ValueMember = "UserId";
            ddlFilterUser.SelectedItem = null;

            RefreshAuditTrailsGridview();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAuditTrailsGridview();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            RefreshAuditTrailsGridview();
        }


        private void RefreshAuditTrailsGridview()
        {
            dgvAuditTrail.DataSource = null;
            var TrailsToShow = context.AuditTrails.AsQueryable();

            if (txtFilterTrailsNo.Text != "")
            {
                TrailsToShow = TrailsToShow
                    .Where(x => x.AuditId == Convert.ToInt32(txtFilterTrailsNo.Text));
            }
            else if (ddlFilterUser.SelectedValue != null)
            {
                TrailsToShow = TrailsToShow
                    .Where(x => x.UserId == Convert.ToInt32(ddlFilterUser.SelectedValue.ToString()));
            }

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

        private void FilterbyUser_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            txtFilterTrailsNo.Text = string.Empty;
            txtFilterTrailsNo.Focus();

            ddlFilterUser.SelectedValue = string.Empty;
            RefreshAuditTrailsGridview();
        }
    }
}
