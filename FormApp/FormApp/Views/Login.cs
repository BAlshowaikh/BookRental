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

namespace FormApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            //comment
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;

            string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookNookDB;Integrated Security=True";

            SqlConnection con = new SqlConnection(connection);
            con.Open();

            string query = "SELECT * FROM Users WHERE Username = '" + username + "' AND Password = '" + password + "'";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader = reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Login Sucessful!");

                homePageAdmin home = new homePageAdmin();
                home.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
            con.Close();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
