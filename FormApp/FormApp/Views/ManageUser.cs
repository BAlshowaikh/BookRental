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
                var userToShow = context.Users.AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtUserID.Text))
                {
                    userToShow = userToShow.Where(u => u.UserId == Convert.ToInt32(txtUserID.Text));
                }
                //if a user is selected, filter by that category 
                else if (ddlUser.SelectedItem != null)
                {
                    userToShow = userToShow.Where(x => x.UserId == Convert.ToInt32(ddlUser.SelectedValue));
                }

                //Project the filtered user into an anonymous type, then convert the result to a list and bind it to the data grid view.
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

        private void deleteBttn_Click(object sender, EventArgs e)
        {
            try
            {
                //check if at least one cell is selected
                if (dgvUsers.SelectedCells.Count > 0)
                {
                    //Get the selected cell within the grid view
                    int selectedCell = Convert.ToInt32(dgvUsers.SelectedCells[0].OwningRow.Cells[0].Value);

                    //Retrieve the user object of the selected id
                    User u1 = context.Users.Single(x => x.UserId == selectedCell);

                    if (MessageBox.Show("Are you sure you want to delete the user - (" + u1.UserId + ")?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        context.Users.Remove(u1); //Delete the user with the specified ID

                        context.SaveChanges(); //Execute the changes against the Database

                        RefreshUsersGridView(); //Call refresh grid view to view the changes
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
