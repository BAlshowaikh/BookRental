using BookRentalObject;
using FormApp.Controllers;
using Microsoft.Data.SqlClient;
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
    public partial class profile : Form
    {
        BookRentalDBContext context;
        int userId;
        public profile()
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);

            context = new BookRentalDBContext();

            // testing user id , will remove once login page is integrated 
            userId = 1;

            this.Load += profile_Load;
        }

      

        private void profile_Load(object sender, EventArgs e)
        {
            try
            {
                var user = context.Users.FirstOrDefault(u => u.UserId == userId);
                if (user != null)
                {
                    firstNameTxt.Text = user.FirstName;
                    lastNameTxt.Text = user.LastName;
                    emailTxt.Text = user.Email;
                }
                else
                {
                    MessageBox.Show($"User with ID {userId} not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var user = context.Users.FirstOrDefault(u => u.UserId == userId);
                if (user != null)
                {
                    user.FirstName = firstNameTxt.Text;
                    user.LastName = lastNameTxt.Text;
                    user.Email = emailTxt.Text;

                    context.SaveChanges();
                    MessageBox.Show("Profile updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
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

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

