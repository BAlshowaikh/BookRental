using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using FormApp.Views;
using ProjectFormApp;

namespace FormApp.Controllers
{
        
        public static class HelperFunctions {
        // Create a method that set up the new form design
        public static void setUpFormDesign(Form form)
        {
            // Remove default controls and set the the screen to be in the center
            form.ControlBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Text = string.Empty;


            // Adjust the form size
            form.Width = 1000;
            form.Height = 700;
            form.Size = new Size(1000, 700);

            // Prevent any resizing
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }

        public static void exitBtn()
        {
            Application.Exit();
        }

        public static void homePageBtn(Form currentForm)
        {
            if (Global.RoleName == "Admin")
            {
                homePageAdmin homePage = homePageAdmin.GetInstance();
                homePage.Show();
                currentForm.Close();
            }
            else 
            {
                homePageStaff homePage = homePageStaff.GetInstance();
                homePage.Show();
                currentForm.Close();
            }
        }

        public static void returnBtn(Form mainForm, Form subForm)
        {
            mainForm.Show();
            subForm.Close();
        }

        public static void navigationToPage(Form currentForm, Form newForm)
        {
            newForm.Show();
            currentForm.Hide();
        }

        // Function to be used for parent-child relationship in forms (For example, between the bookList form and AddEditBook form)
        public static void ShowChildForm(Form parentForm, Form childForm)
        {
            parentForm.Hide();
            childForm.FormClosed += (s, args) => parentForm.Show();
            childForm.Show();
        }

        // Function to go for the profile form
        public static void ShowProfilePage(Form currentForm)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to go to your Profile page?",
                "Confirm Navigation",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                profile profileForm = new profile();
                profileForm.ShowDialog();
            }
        }

        public static void OpenSingletonForm<T>(Form currentForm) where T : Form, new()
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is T existingForm)
                {
                    existingForm.BringToFront();
                    if (currentForm != existingForm)
                        currentForm.Hide();
                    return;
                }
            }

            // Form not open, create new instance
            T form = new T();
            form.Show();
            currentForm.Hide();
        }

    }
}
