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
    public partial class mointoringDashboard : Form
    {
        public mointoringDashboard()
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
        }


        private void mointoringDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardStats();// Load all statistics when the dashboard opens
        }

        // Method to retrieve and display statistics from the database
        private void LoadDashboardStats()
        {
            try
            {
                string connection = @"Server=reboot08.com;Database=BookRental;User Id=sa;Password='caliber,willpower,enjoyably,ending,giggling,P5';Encrypt=True;TrustServerCertificate=True;";
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();

                    //counting total books 
                    SqlCommand cmdTotalBooks = new SqlCommand("SELECT COUNT(*) FROM Book", con);
                    lblTotalBooks.Text = cmdTotalBooks.ExecuteScalar().ToString();

                    //counting the available books
                    SqlCommand cmdAvailable = new SqlCommand("SELECT COUNT(*) FROM Book WHERE availabilityStatusId = 1 ", con);
                    lblAvailableBooks.Text = cmdAvailable.ExecuteScalar().ToString();

                    //counting the damaged books 
                    SqlCommand cmdDamaged = new SqlCommand("SELECT COUNT(*) FROM Book WHERE bookConditionId IN (3, 4)", con);
                    lblDamgedBooks.Text = cmdDamaged.ExecuteScalar().ToString();

                    //counting the rental requests
                    SqlCommand cmdRequests = new SqlCommand("SELECT COUNT(*) From [Rental Request]", con);
                    lblTotalRentalRequets.Text = cmdRequests.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message);
            }
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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadDashboardStats(); //Re-load the dashboard statistics when refresh is clicked
        }
    }
}
