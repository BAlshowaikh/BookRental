using BookRentalObject;
using FormApp.Controllers;
using FormApp.Views;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ProjectFormApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            try
            {
                //Set the data source of the drop down to the list of users 
                ddlUser.DataSource = context.Users.ToList();
                ddlUser.DisplayMember = "FullName"; // Set which property to display in the dropdown
                ddlUser.ValueMember = "userId"; // Set the value property for each dropdown item
                ddlUser.SelectedItem = null; // Clear any pre-selected item

                // Refresh the grid view to show the latest users
                RefreshUsersGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void filterBttn_Click(object sender, EventArgs e)
        {
            RefreshUsersGridView(); //Call the method to filter if any filters were applied
        }

        private void RefreshUsersGridView()
        {
            try
            {
                var userToShow = context.Users.Include(x => x.UserRole).AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtUserID.Text))
                {
                    userToShow = userToShow.Where(u => u.UserId == Convert.ToInt32(txtUserID.Text));
                }
                //if a user is selected, filter by that category 
                if (ddlUser.SelectedItem != null)
                {
                    userToShow = userToShow.Where(x => x.UserId == Convert.ToInt32(ddlUser.SelectedValue));
                }

                //Project the filtered user into an anonymous type, then convert the result to a list and bind it to the data grid view.
                dgvUsers.DataSource = userToShow.Select(s => new
                {
                    UserID = s.UserId,
                    FullName = s.FullName,
                    Email = s.Email,
                    ContactNumber = s.ContactNo,
                    Status = s.IsActive,
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
            txtUserID.Text = null;
            ddlUser.SelectedItem = null; // Clear any pre-selected item

            RefreshUsersGridView(); //Refresh the view to remove the filters
        }

        private void addBttn_Click(object sender, EventArgs e)
        {
            AddEditUser addEdit = new AddEditUser();
            addEdit.StartPosition = FormStartPosition.CenterScreen;
            addEdit.ShowDialog();

            //If the dialog result was ok, refresh the authors grid view to show the new data
            if (addEdit.DialogResult == DialogResult.OK)
            {
                RefreshUsersGridView();
            }

        }

        private void editBttn_Click(object sender, EventArgs e)
        {
            //Get the author ID from the first selected cell
            int selectedCell = Convert.ToInt32(dgvUsers.SelectedCells[0].OwningRow.Cells[0].Value);

            AddEditUser addEdit = new AddEditUser(selectedCell);
            addEdit.StartPosition = FormStartPosition.CenterScreen;
            addEdit.ShowDialog();

            //if the dialog result was ok, refresh the grid view to reflect the updates
            if (addEdit.DialogResult == DialogResult.OK)
            {
                RefreshUsersGridView();
            }
        }

        private async void deleteBttn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.SelectedCells.Count > 0)
                {
                    int selectedUserId = Convert.ToInt32(dgvUsers.SelectedCells[0].OwningRow.Cells[0].Value);

                    // Get the user from BookRental DB
                    var user = context.Users.FirstOrDefault(x => x.UserId == selectedUserId);

                    if (user == null)
                    {
                        MessageBox.Show("User not found in BookRental DB.");
                        return;
                    }

                    if (MessageBox.Show($"Are you sure you want to delete user ID {user.UserId}?",
                        "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Initialize Identity context and manager (same pattern as AddEditUser)
                        using (var identityContext = new FormsIdentityContext())
                        {
                            var userStore = new UserStore<IdentityUser>(identityContext);
                            var userManager = new UserManager<IdentityUser>(
                                userStore, null, new PasswordHasher<IdentityUser>(),
                                null, null, null, null, null, null);

                            // Find and delete Identity user
                            var identityUser = await userManager.FindByEmailAsync(user.Email);
                            if (identityUser != null)
                            {
                                var result = await userManager.DeleteAsync(identityUser);
                                if (!result.Succeeded)
                                {
                                    throw new Exception(string.Join("\n",
                                        result.Errors.Select(x => x.Description)));
                                }
                            }
                        }

                        // Delete from BookRental DB
                        context.Users.Remove(user);
                        await context.SaveChangesAsync();

                        RefreshUsersGridView();
                        MessageBox.Show("User deleted successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}\n\n{ex.InnerException?.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
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

        private void ddlAttributesNames_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
