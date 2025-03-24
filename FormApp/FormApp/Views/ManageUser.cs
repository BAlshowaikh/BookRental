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

namespace FormApp
{
    public partial class ManageUser : Form
    {
        BookRentalDBContext context;

        public ManageUser()
        {
            InitializeComponent();
            context = new BookRentalDBContext();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            populateUserComboBox();
            RefreshUsersGridView();
        }

        private void populateUserComboBox()
        {
            ddlUser.DataSource = context.Users.ToList();
            ddlUser.DisplayMember = "FullName";
            ddlUser.ValueMember = "userId";
            ddlUser.SelectedItem = null;
        }

        private void filterBttn_Click(object sender, EventArgs e)
        {
            RefreshUsersGridView();
        }

        private void RefreshUsersGridView()
        {
            try
            {
                var userToShow = context.Users.AsQueryable();

                if (ddlUser.SelectedValue != null)
                {
                    dgvUsers.DataSource = userToShow.Where(x => x.UserId == Convert.ToInt32(ddlUser.SelectedValue)).Select(s => new
                    {
                        UserID = s.UserId,
                        FullName = s.FullName,
                        Email = s.Email,
                        Role = s.UserRole.Role
                    }).ToList();
                }
                else
                {
                    dgvUsers.DataSource = userToShow.Select(s => new
                    {
                        UserID = s.UserId,
                        FullName = s.FullName,
                        Email = s.Email,
                        Role = s.UserRole.Role
                    }).ToList();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshBttn_Click(object sender, EventArgs e)
        {
            ddlUser.SelectedItem = null;

            RefreshUsersGridView();
        }

        private void addBttn_Click(object sender, EventArgs e)
        {

        }

        private void editBttn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBttn_Click(object sender, EventArgs e)
        {
            var selectedCell = Convert.ToInt32(dgvUsers.SelectedCells[0].OwningRow.Cells[0].Value);

            User user = context.Users.Where(x => x.UserId == selectedCell).FirstOrDefault();

            if (selectedCell != null)
            {
                if (MessageBox.Show("Are you sure you want to delete the user - (" + user.UserId +")?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.OK)
                {
                    context.Users.Remove(user);
                }
            }
        }
    }
}
