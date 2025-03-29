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
    public partial class Logging : Form
    {
        BookRentalDBContext context = new BookRentalDBContext();
        public Logging()
        {
            InitializeComponent();
        }

        private void Logging_Load(object sender, EventArgs e)
        {
            ddlFilterUser.DataSource = context.Users.ToList(); ;

            ddlFilterUser.DisplayMember = "FullName";
            ddlFilterUser.ValueMember = "UserId";
            ddlFilterUser.SelectedItem = null;

            RefreshLogTrailsGridview();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshLogTrailsGridview();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            RefreshLogTrailsGridview();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtFilterTrailsNo.Text = string.Empty;
            txtFilterTrailsNo.Focus();

            ddlFilterUser.SelectedValue = string.Empty;
            RefreshLogTrailsGridview();
        }

        private void RefreshLogTrailsGridview()
        {
            dgvLogTrail.DataSource = null;
            var TrailsToShow = context.Logs.AsQueryable();

            if (txtFilterTrailsNo.Text != "")
            {
                TrailsToShow = TrailsToShow
                    .Where(x => x.LogId == Convert.ToInt32(txtFilterTrailsNo.Text));
            }
            else if (ddlFilterUser.SelectedValue != null)
            {
                TrailsToShow = TrailsToShow
                    .Where(x => x.UserId == Convert.ToInt32(ddlFilterUser.SelectedValue.ToString()));
            }

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
