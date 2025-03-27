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
        public profile()
        {
            InitializeComponent();
        }

        int currentUserId;

        public profile(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }


        private void profile_Load(object sender, EventArgs e)
        {
            string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookNookDB;Integrated Security=True";

            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string query = "SELECT firstName, lastName, email FROM Users WHERE UserID = " + currentUserId;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                firstNameTxt.Text = reader["FirstName"].ToString();
                lastNameTxt.Text = reader["LastName"].ToString();
                emailTxt.Text = reader["Email"].ToString();
            }

            con.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTxt.Text;
            string lastName = lastNameTxt.Text;
            string email = emailTxt.Text;

            string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookNookDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string query = "UPDATE Users Set firstName = ' " + firstName + " ', lastName = ' "+ lastName +" ', Email '"+ email+ " ' WHERE UserID = " + currentUserId;
            SqlCommand cmd = new SqlCommand(query, con);

            int result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                MessageBox.Show("Profile updated");
            }
            else
            {
                MessageBox.Show("Update failed");
            }
            con.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

