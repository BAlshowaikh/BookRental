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
            ddlRole.DataSource = context.UserRoles.ToList();
            ddlRole.DisplayMember = "role";
            ddlRole.ValueMember = "userRoleId";
            ddlRole.SelectedItem = null;
        }

        private void AddEditUserDetails()
        {
            if (this.user.UserId > 0)
            {
                pageTitleTxt.Text = "Edit User";
                txtUserID.Text = user.UserId.ToString();
                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtEmail.Text = user.Email;
                ddlRole.SelectedValue = user.UserRoleId;
                ddlRole.Enabled = false;
            }
            else
            {
                ddlRole.SelectedValue = "";
            }
        }

        private void addBttn_Click(object sender, EventArgs e)
        {
            try
            {
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.Email = txtEmail.Text;
                user.UserRoleId = Convert.ToInt32(ddlRole.SelectedValue);

                if (user.UserId > 0)
                {
                    if (MessageBox.Show("are you sure you want to edit user ID:" + user.UserId + "?", "conferm Approval", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        context.Users.Update(user);
                    }
                }
                else
                {
                    if (MessageBox.Show("are you sure you want to add this user? ", "conferm Approval", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        context.Users.Add(user);
                    }
                }
                context.SaveChanges();

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
