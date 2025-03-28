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

namespace FormApp.Views
{
    public partial class returnRecord : Form
    {
        BookRentalDBContext context = new BookRentalDBContext();
        public returnRecord()
        {
            InitializeComponent();
        }

        private void returnRecord_Load(object sender, EventArgs e)
        {

            ddlFilterBook.DataSource = context.Books.ToList(); ;

            ddlFilterBook.DisplayMember = "Name";
            ddlFilterBook.ValueMember = "BookId";
            ddlFilterBook.SelectedItem = null;

            RefreshReturnRecourdGridview();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshReturnRecourdGridview();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            RefreshReturnRecourdGridview();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            txtFilterRecordNo.Text = String.Empty;
            txtFilterRecordNo.Focus();

            ddlFilterBook.SelectedValue = string.Empty;

            RefreshReturnRecourdGridview();
        }

        private void RefreshReturnRecourdGridview()
        {
            dgvReturnRecourd.DataSource = null;
            var RequestToShow = context.ReturnRecords.AsQueryable();

            if (txtFilterRecordNo.Text != "")
            {
                RequestToShow = RequestToShow
                    .Where(x => x.RecordId == Convert.ToInt32(txtFilterRecordNo.Text));
            }
            else if (ddlFilterBook.SelectedValue != null)
            {
                RequestToShow = RequestToShow
                    .Where(x => x.BookId == Convert.ToInt32(ddlFilterBook.SelectedValue.ToString()));
            }

            dgvReturnRecourd.DataSource = RequestToShow.Select(x => new 
            {
                RecordID = x.RecordId,
                x.ExpectedReturnDate,
                x.ActualReturnDate,
                x.TotalAdditionalCharges,
                x.LateReturnFee,
                BookName = x.Book.Name,
                BookCondition = x.BookCondition.ReturnCondition,
                x.TransactionId
            }).ToList();
        }

    }
}
