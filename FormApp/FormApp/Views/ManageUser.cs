using BookRentalObject;
using FormApp.Controllers;
using FormApp.Views;
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
            HelperFunctions.setUpFormDesign(this);
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

            RefreshUsersGridView();
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

                if (!string.IsNullOrWhiteSpace(txtUserID.Text))
                {
                    userToShow = userToShow.Where(u => u.UserId == Convert.ToInt32(txtUserID.Text));
                }

                else if (ddlUser.SelectedItem != null)
                {
                    userToShow = userToShow.Where(x => x.UserId == Convert.ToInt32(ddlUser.SelectedValue));
                }

                dgvUsers.DataSource = userToShow.Select(s => new
                {
                    UserID = s.UserId,
                    FullName = s.FullName,
                    Email = s.Email,
                    Role = s.UserRole.Role
                }).ToList();

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
            AddEditUser addEdit = new AddEditUser();
            addEdit.StartPosition = FormStartPosition.CenterScreen;
            addEdit.ShowDialog();

            if (addEdit.DialogResult == DialogResult.OK)
            {
                RefreshUsersGridView();
            }

        }

        private void editBttn_Click(object sender, EventArgs e)
        {
            int selectedCell = Convert.ToInt32(dgvUsers.SelectedCells[0].OwningRow.Cells[0].Value);

            AddEditUser addEdit = new AddEditUser(selectedCell);
            addEdit.StartPosition = FormStartPosition.CenterScreen;
            addEdit.ShowDialog();

            if (addEdit.DialogResult == DialogResult.OK)
            {
                RefreshUsersGridView();
            }
        }

        private void deleteBttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.SelectedCells.Count > 0)
                {
                    int selectedCell = Convert.ToInt32(dgvUsers.SelectedCells[0].OwningRow.Cells[0].Value);

                    User u1 = context.Users.Single(x => x.UserId == selectedCell);

                    if (MessageBox.Show("Are you sure you want to delete the user - (" + u1.UserId + ")?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        context.Users.Remove(u1);

                        context.SaveChanges();

                        RefreshUsersGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void homeIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.homePageBtn(this);
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.exitBtn();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshUsersGridView();
        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.ShowProfilePage(this);
        }
    }
}
