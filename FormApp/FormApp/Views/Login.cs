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

namespace FormApp
{
    public partial class Login : Form
    {
        BookRentalDBContext context;
        public Login()
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);

            BookRentalDBContext context = new BookRentalDBContext();

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
        //    string email = usernameTxt.Text.Trim();    
        //    string password = passwordTxt.Text.Trim();

        //    var user = context.Users
        //                      //.FirstOrDefault(u => u.Email == email && u.password == password);

        //    if (user != null)
        //    {
        //        MessageBox.Show("Login Successful!");

        //        homePageAdmin home = new homePageAdmin(context, user.UserId);
        //        home.Show();
        //        this.Hide();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Incorrect email or password.");
        //    }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
