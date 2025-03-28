using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BookRentalObject;
using FormApp.Controllers;

namespace FormApp.Views
{
    public partial class rentalRequest : Form
    {
        BookRentalDBContext context = new BookRentalDBContext();
        public rentalRequest()
        {
            InitializeComponent();
        }

        private void rentalRequest_Load(object sender, EventArgs e)
        {
            ddlFilterUser.DataSource = context.Users.ToList(); ;

            ddlFilterUser.DisplayMember = "FullName";
            ddlFilterUser.ValueMember = "UserId";
            ddlFilterUser.SelectedItem = null;

            RefreshRentalRequestGridview();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshRentalRequestGridview();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            RefreshRentalRequestGridview();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtFilterRequestNo.Text = string.Empty;
            txtFilterRequestNo.Focus();

            ddlFilterUser.SelectedValue = string.Empty;
            RefreshRentalRequestGridview();
        }

        private void RefreshRentalRequestGridview()
        {
            dgvRentalRequest.DataSource = null;
            var RequestToShow = context.RentalRequests.AsQueryable();

            if (txtFilterRequestNo.Text != "")
            {
                RequestToShow = RequestToShow
                    .Where(x => x.RequestId == Convert.ToInt32(txtFilterRequestNo.Text));
            }
            else if (ddlFilterUser.SelectedValue != null)
            {
                RequestToShow = RequestToShow
                    .Where(x => x.UserId == Convert.ToInt32(ddlFilterUser.SelectedValue.ToString()));
            }

            dgvRentalRequest.DataSource = RequestToShow.ToList();
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
