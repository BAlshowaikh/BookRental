using BookRentalObject;
using FormApp.Controllers;
using FormApp.Views;
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
    public partial class homePageAdmin : Form
    {
        private static homePageAdmin _instance;

        public homePageAdmin()
        {
            InitializeComponent();
            HelperFunctions.setUpFormDesign(this);
        }

        public static homePageAdmin GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new homePageAdmin();
            }
            return _instance;
        }

        private void exitIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.exitBtn();
        }

        // Opens the Manage User form
        private void manageUsersBtn_Click(object sender, EventArgs e)
        {
            Form manageUserForm = new ManageUser();
            HelperFunctions.navigationToPage(this, manageUserForm);

        }

        // Opens the Book List form 
        private void manageBooksBtn_Click(object sender, EventArgs e)
        {
            Form bookListForm = new bookList();
            HelperFunctions.navigationToPage(this, bookListForm);
        }

        // Opens the Return Records form
        private void manageRentalRecordsBtn_Click(object sender, EventArgs e)
        {
            Form returnRecordForm = new returnRecord();
            HelperFunctions.navigationToPage(this, returnRecordForm);

        }

        // Opens the Rental Request form
        private void manageRentalRequestBtn_Click(object sender, EventArgs e)
        {
            Form manageRentalRequestForm = new rentalRequest();
            HelperFunctions.navigationToPage(this, manageRentalRequestForm);
        }

        //Opens the Manage Rental Record form
        private void manageRentalRecordsBtn_Click_1(object sender, EventArgs e)
        {
            Form manageReturnRecordsForm = new returnRecord();
            HelperFunctions.navigationToPage(this, manageReturnRecordsForm);
        }


        // Opens the Manage Transactions form
        private void manageRentalTransictionsBtn_Click(object sender, EventArgs e)
        {
            Form ViewTransactions = new ViewTransactions();
            HelperFunctions.navigationToPage(this, ViewTransactions);
        }

        // Opens the Audit Trails form 
        private void generateRecordsBtn_Click(object sender, EventArgs e)
        {
            Form loginTrails = new Logging();
            HelperFunctions.navigationToPage(this, loginTrails);
        }

        private void homeIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.homePageBtn(this);
        }

        private void btnViewAuditTrails_Click(object sender, EventArgs e)
        {
            Form auditTrails = new Audit_Trails();
            HelperFunctions.navigationToPage(this, auditTrails);
        }

        private void homePageAdmin_Load(object sender, EventArgs e)
        {

        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            HelperFunctions.ShowProfilePage(this);
        }

        private void manageCategoryBtn_Click(object sender, EventArgs e)
        {
            Form manageCategoryForm = new ManageCategory();
            HelperFunctions.navigationToPage(this, manageCategoryForm);
        }

        private void manageAuthorsBtn_Click(object sender, EventArgs e)
        {
            Form manageAuthorForm = new ManageAuthors();
            HelperFunctions.navigationToPage(this, manageAuthorForm);
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
