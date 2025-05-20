using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormApp.Controllers;
using ProjectFormApp;

namespace FormApp.Views
{
    public partial class homePageStaff : Form
    {
        private static homePageStaff _instance;
        public homePageStaff()
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
        }

        public static homePageStaff GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new homePageStaff();
            }
            return _instance;
        }
        private void homePageStaff_Load(object sender, EventArgs e)
        {
            if (Global.user != null)
            {
                lblWelcome.Text = "Welcome, "+Global.user.FullName+"!";
            }
        }

        // Event handler for the Manage Books button
        private void manageBooksBtn_Click(object sender, EventArgs e)
        {
            Form bookListForm = new bookList();
            HelperFunctions.navigationToPage(this, bookListForm);
        }

        // Event handler for the Rental Requests button
        private void manageRentalRequestBtn_Click(object sender, EventArgs e)
        {
            Form manageRentalRequestForm = new rentalRequest();
            HelperFunctions.navigationToPage(this, manageRentalRequestForm);

        }

        // Event handler for the Manage Rental Transactions button
        private void manageRentalTransictionsBtn_Click(object sender, EventArgs e)
        {
            Form ViewTransactions = new ViewTransactions();
            HelperFunctions.navigationToPage(this, ViewTransactions);
        }

        // Event handler for the Manage Return Record button
        private void manageRentalRecordsBtn_Click(object sender, EventArgs e)
        {
            Form returnRecordForm = new returnRecord();
            HelperFunctions.navigationToPage(this, returnRecordForm);
        }

        // Event handler for the Generating Book Record form button
        private void GenerateRecordBtn_Click(object sender, EventArgs e)
        {
            Form auditTrails = new Audit_Trails();
            HelperFunctions.navigationToPage(this, auditTrails);
        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.ShowProfilePage(this);
        }

        // Event handler for the Viewing Statistics form button
        private void ViewStatsBtn_Click(object sender, EventArgs e)
        {
            Form monitoringDashboardForm = new mointoringDashboard();
            HelperFunctions.navigationToPage(this, monitoringDashboardForm);
        }

        private void manageAuthorsBtn_Click(object sender, EventArgs e)
        {
            Form manageAuthorForm = new ManageAuthors();
            HelperFunctions.navigationToPage(this, manageAuthorForm);
        }

        private void manageCategoryBtn_Click(object sender, EventArgs e)
        {
            Form manageCategoryForm = new ManageCategory();
            HelperFunctions.navigationToPage(this, manageCategoryForm);
        }

        private void quickAccessLbl_Click(object sender, EventArgs e)
        {

            var menu = new ContextMenuStrip();

            // ── Books ──
            var booksMenu = new ToolStripMenuItem("📚 Books");
            booksMenu.DropDownItems.Add("Add Book", null, (s, ea) => HelperFunctions.OpenSingletonForm<bookList>(this));
            booksMenu.DropDownItems.Add("Edit Book", null, (s, ea) => HelperFunctions.OpenSingletonForm<bookList>(this));
            booksMenu.DropDownItems.Add("Delete Book", null, (s, ea) => HelperFunctions.OpenSingletonForm<bookList>(this));
            menu.Items.Add(booksMenu);

            // ── Users ──
            var usersMenu = new ToolStripMenuItem("👤 Users");
            usersMenu.DropDownItems.Add("Add User", null, (s, ea) => HelperFunctions.OpenSingletonForm<ManageUser>(this));
            usersMenu.DropDownItems.Add("Edit User", null, (s, ea) => HelperFunctions.OpenSingletonForm<ManageUser>(this));
            usersMenu.DropDownItems.Add("Delete User", null, (s, ea) => HelperFunctions.OpenSingletonForm<ManageUser>(this));
            menu.Items.Add(usersMenu);

            // ── Categories ──
            var catsMenu = new ToolStripMenuItem("🗂 Categories");
            catsMenu.DropDownItems.Add("Add Category", null, (s, ea) => HelperFunctions.OpenSingletonForm<ManageCategory>(this));
            catsMenu.DropDownItems.Add("Edit Category", null, (s, ea) => HelperFunctions.OpenSingletonForm<ManageCategory>(this));
            catsMenu.DropDownItems.Add("Delete Category", null, (s, ea) => HelperFunctions.OpenSingletonForm<ManageCategory>(this));
            menu.Items.Add(catsMenu);

            // ── Authors ──
            var authMenu = new ToolStripMenuItem("✍️ Authors");
            authMenu.DropDownItems.Add("Add Author", null, (s, ea) => HelperFunctions.OpenSingletonForm<ManageAuthors>(this));
            authMenu.DropDownItems.Add("Edit Author", null, (s, ea) => HelperFunctions.OpenSingletonForm<ManageAuthors>(this));
            authMenu.DropDownItems.Add("Delete Author", null, (s, ea) => HelperFunctions.OpenSingletonForm<ManageAuthors>(this));
            menu.Items.Add(authMenu);

            // ── Rentals & Returns ── (single‑page forms)
            menu.Items.Add("📖 Rental Transactions", null, (s, ea) => HelperFunctions.OpenSingletonForm<ViewTransactions>(this));
            menu.Items.Add("🔁 Return Records", null, (s, ea) => HelperFunctions.OpenSingletonForm<returnRecord>(this));
            menu.Items.Add("🧾 Rental Requests", null, (s, ea) => HelperFunctions.OpenSingletonForm<rentalRequest>(this));

            // ── Logs & Audits ──
            menu.Items.Add("📊 Audit Trails", null, (s, ea) => HelperFunctions.OpenSingletonForm<Audit_Trails>(this));
            menu.Items.Add("⚙️ Log Trails", null, (s, ea) => HelperFunctions.OpenSingletonForm<Logging>(this));

            // Position and show
            menu.Show(quickAccessLbl, new Point(0, quickAccessLbl.Height));
        }
    }
}
