using BookRentalObject;
using FormApp.Controllers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectFormApp;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FormApp.Views
{
    public partial class AddEditUser : Form
    {
        private BookRentalDBContext context;
        private FormsIdentityContext identityContext;
        private User user;
        private IdentityUser identityUser;
        private bool isEdit = false;

        public AddEditUser()
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);

            context = new BookRentalDBContext();
            identityContext = new FormsIdentityContext();

            user = new User();
            pageTitleTxt.Text = "Add User";
        }

        public AddEditUser(int userId)
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);

            context = new BookRentalDBContext();
            identityContext = new FormsIdentityContext();

            user = context.Users.Find(userId);
            isEdit = true;
            pageTitleTxt.Text = "Edit User";

            identityUser = identityContext.Users.FirstOrDefault(u => u.Email == user.Email);
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
                ddlRole.DataSource = context.UserRoles.ToList();
                ddlRole.DisplayMember = "role";
                ddlRole.ValueMember = "userRoleId";
                ddlRole.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading roles: " + ex.Message);
            }
        }

        private void AddEditUserDetails()
        {
            if (user.UserId > 0)
            {
                txtUserID.Text = user.UserId.ToString();
                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtEmail.Text = user.Email;
                ddlRole.SelectedValue = user.UserRoleId;
            }
            else
            {
                ddlRole.SelectedValue = "";
            }
        }

        private async void addBttn_Click(object sender, EventArgs e)
        {
            try
            {
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.Email = txtEmail.Text;
                user.UserRoleId = Convert.ToInt32(ddlRole.SelectedValue);
                user.IsActive = true;

                var email = user.Email.Trim();
                var userStore = new UserStore<IdentityUser>(identityContext);
                var userManager = new UserManager<IdentityUser>(
                    userStore, null, new PasswordHasher<IdentityUser>(),
                    null, null, null, null, null, null);

                if (isEdit)
                {
                    if (identityUser != null)
                    {
                        identityUser.Email = email;
                        identityUser.UserName = email;
                        await userStore.UpdateAsync(identityUser);
                    }

                    context.Users.Update(user);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to add this user?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var newIdentityUser = new IdentityUser
                        {
                            Email = email,
                            UserName = email,
                            EmailConfirmed = true
                        };

                        var result = await userManager.CreateAsync(newIdentityUser, "Password@123"); // Default password
                        if (result.Succeeded)
                        {
                            context.Users.Add(user);
                        }
                        else
                        {
                            MessageBox.Show("Failed to create identity user: " + string.Join(", ", result.Errors.Select(e => e.Description)));
                            return;
                        }
                    }
                }

                context.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message);
            }
        }

        private void cancelBttn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.exitBtn();
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.homePageBtn(this);
        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.ShowProfilePage(this);
        }
    }
}
