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
        }


        private void mointoringDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardStats();
        }

        private void LoadDashboardStats()
        {
            try
            {
                string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookNookDB;Integrated Security=True";
                using(SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();

                    //counting total books 
                    SqlCommand cmdTotalBooks = new SqlCommand("SELECT COUNT(*) FROM Books", con);
                    lblTotalBooks.Text = cmdTotalBooks.ExecuteScalar().ToString();

                    //counting the available books
                    SqlCommand cmdAvailable = new SqlCommand("SELECT COUNT(*) FROM Books WHERE Status = 'Available' ", con);
                    lblAvailableBooks.Text = cmdAvailable.ExecuteScalar().ToString();

                    //counting the damaged books 
                    SqlCommand cmdDamaged = new SqlCommand("SELECT COUNT(*) FROM Books WHERE Status = 'Damaged' ", con);
                    lblDamgedBooks.Text = cmdAvailable.ExecuteScalar().ToString();

                    //counting the rental requests
                    SqlCommand cmdRequests = new SqlCommand("SELECT COUNT(*) From RentalRequests", con);
                    lblTotalRentalRequets.Text = cmdRequests.ExecuteScalar().ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message);
            }
        }
    }
}
