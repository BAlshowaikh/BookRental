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
    public partial class AddEditUser : Form
    {

        BookRentalDBContext context;
        User user;

        public AddEditUser()
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
            context = new BookRentalDBContext();
            user = new User();
        }

        public AddEditUser(int user1)
        {
            InitializeComponent();
            context = new BookRentalDBContext();
            this.user = context.Users.Find(user1);

            HelperFunctions.setUpFormDesign(this);

        }

        private void AddEditUser_Load(object sender, EventArgs e)
        {
            PopulateUserRoleComboBox();
            AddEditUserDetails();
        }

        private void PopulateUserRoleComboBox()
        {
            try
            {
                //Set the data source of the drop down to the list of roles
                ddlRole.DataSource = context.UserRoles.ToList();
                ddlRole.DisplayMember = "role"; // Set which property to display in the dropdown
                ddlRole.ValueMember = "userRoleId"; // Set the value property for each dropdown item
                ddlRole.SelectedItem = null; // Clear any pre-selected item
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddEditUserDetails()
        {
            try
            {
                //check if it's an existing user
                if (this.user.UserId > 0)
                {
                    // Populate form fields with the user's data
                    txtUserID.Text = user.UserId.ToString();
                    txtFirstName.Text = user.FirstName;
                    txtLastName.Text = user.LastName;
                    txtEmail.Text = user.Email;
                    ddlRole.SelectedValue = user.UserRoleId;
                    //ddlRole.Enabled = false;
                }
                else
                {
                    // If this is a new user, clear the role selection
                    ddlRole.SelectedValue = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addBttn_Click(object sender, EventArgs e)
        {
            try
            {
                // Assign values to the user object
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.Email = txtEmail.Text;
                user.UserRoleId = Convert.ToInt32(ddlRole.SelectedValue);

                // If the user has an existing ID, update the record
                if (user.UserId > 0)
                {
                    context.Users.Update(user);
                }
                else // add a new user
                {
                    context.Users.Add(user);
                }

                // Save changes to the database
                context.SaveChanges();

                // Close the form and return OK result
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBttn_Click(object sender, EventArgs e)
        {
            
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.exitBtn();
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.homePageBtn(this);
        }

        private void cancelBttn_Click(object sender, EventArgs e)
        {
            // Close the form and return Cancel 
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
