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
        // Store the SQL connection and current user ID
        private readonly SqlConnection _connection;
        private readonly int _currentUserId;

        public profile(int userId, SqlConnection existingConnection)
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
            _currentUserId = userId;
            _connection = existingConnection;
        }


        private void profile_Load(object sender, EventArgs e)
        {
            try
            {
                // fetching the logged in user profile information
                string query = "SELECT FirstName, LastName, Email FROM Users WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, _connection);
                cmd.Parameters.AddWithValue("@UserID", _currentUserId);

                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // add user info to the text boxes
                        firstNameTxt.Text = reader["FirstName"].ToString();
                        lastNameTxt.Text = reader["LastName"].ToString();
                        emailTxt.Text = reader["Email"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                //error message if something goes wrong
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // updating  to save changes to the user's profile
                string query = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Email = @Email WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, _connection);

                // adding parameters from the text fields
                cmd.Parameters.AddWithValue("@FirstName", firstNameTxt.Text);
                cmd.Parameters.AddWithValue("@LastName", lastNameTxt.Text);
                cmd.Parameters.AddWithValue("@Email", emailTxt.Text);
                cmd.Parameters.AddWithValue("@UserID", _currentUserId);

                int result = cmd.ExecuteNonQuery();
                MessageBox.Show(result > 0 ? "Profile updated." : "Update failed.");
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong
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

