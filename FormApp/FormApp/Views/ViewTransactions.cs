using BookRentalObject;
using FormApp.Controllers;
using Microsoft.EntityFrameworkCore;
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
    public partial class ViewTransactions : Form
    {
        BookRentalDBContext context;

        public ViewTransactions()
        {
            InitializeComponent();
            context = new BookRentalDBContext();
            HelperFunctions.setUpFormDesign(this);
        }

        private void addBttn_Click(object sender, EventArgs e)
        {

        }

        private void ViewTransactions_Load(object sender, EventArgs e)
        {
            PopulateCustomerDDL();
            RefreshGridView();
        }

        private void PopulateCustomerDDL()
        {
            ddlCustomer.DataSource = context.Users.Where(x => x.UserRole.Role == "Customer").ToList();
            ddlCustomer.DisplayMember = "FullName";
            ddlCustomer.ValueMember = "userId";
            ddlCustomer.SelectedItem = null;
        }

        private void RefreshGridView()
        {
            var transaction = context.RentalTransactions.AsQueryable();

            if (txtTransactionID.Text != "")
            {
                transaction = transaction.Where(x => x.TransactionId == Convert.ToInt32(txtTransactionID.Text));
            }
            if (ddlCustomer.SelectedItem != null)
            {
                transaction = transaction.Where(x => x.UserId == Convert.ToInt32(ddlCustomer.SelectedValue));
            }

            dgvTransaction.DataSource = transaction.Select(x => new
            {
                TransactionID = x.TransactionId,
                BookName = x.Book.Name,
                CustomerName = x.User.FullName,
                RentalStartDate = x.RentalStartDate,
                ReturnDate = x.ReturnDate,
                RentalFee = x.RentalFee
            }).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filterBttn_Click(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void refreshBttn_Click(object sender, EventArgs e)
        {
            ddlCustomer.SelectedItem = null;
            txtTransactionID.Text = "";
            RefreshGridView();
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
