namespace FormApp.Views
{
    partial class homePageStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userIcon = new PictureBox();
            exitIcon = new PictureBox();
            welcomeTxt = new Label();
            ViewStatsBtn = new Button();
            manageAuthorsBtn = new Button();
            manageCategoryBtn = new Button();
            manageRentalRecordsBtn = new Button();
            manageRentalRequestBtn = new Button();
            manageRentalTransictionsBtn = new Button();
            manageBooksBtn = new Button();
            quickAccessLbl = new Label();
            lblWelcome = new Label();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            SuspendLayout();
            // 
            // userIcon
            // 
            userIcon.BackColor = Color.Transparent;
            userIcon.Image = Properties.Resources.user;
            userIcon.Location = new Point(19, 20);
            userIcon.Margin = new Padding(2);
            userIcon.Name = "userIcon";
            userIcon.Size = new Size(40, 40);
            userIcon.SizeMode = PictureBoxSizeMode.Zoom;
            userIcon.TabIndex = 9;
            userIcon.TabStop = false;
            userIcon.Click += userIcon_Click;
            // 
            // exitIcon
            // 
            exitIcon.BackColor = Color.Transparent;
            exitIcon.Image = Properties.Resources.exit_icon;
            exitIcon.Location = new Point(930, 12);
            exitIcon.Name = "exitIcon";
            exitIcon.Size = new Size(40, 40);
            exitIcon.SizeMode = PictureBoxSizeMode.Zoom;
            exitIcon.TabIndex = 12;
            exitIcon.TabStop = false;
            // 
            // welcomeTxt
            // 
            welcomeTxt.AutoSize = true;
            welcomeTxt.BackColor = Color.Transparent;
            welcomeTxt.Font = new Font("Felix Titling", 22F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeTxt.Location = new Point(80, 133);
            welcomeTxt.Margin = new Padding(2, 0, 2, 0);
            welcomeTxt.Name = "welcomeTxt";
            welcomeTxt.Size = new Size(817, 52);
            welcomeTxt.TabIndex = 13;
            welcomeTxt.Text = "Welcome to Book Nook Store!";
            // 
            // ViewStatsBtn
            // 
            ViewStatsBtn.BackColor = Color.Cornsilk;
            ViewStatsBtn.Font = new Font("Britannic Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            ViewStatsBtn.Location = new Point(379, 489);
            ViewStatsBtn.Name = "ViewStatsBtn";
            ViewStatsBtn.Size = new Size(220, 50);
            ViewStatsBtn.TabIndex = 35;
            ViewStatsBtn.Text = "View Mointoring Dashboard";
            ViewStatsBtn.UseVisualStyleBackColor = false;
            ViewStatsBtn.Click += ViewStatsBtn_Click;
            // 
            // manageAuthorsBtn
            // 
            manageAuthorsBtn.BackColor = Color.Cornsilk;
            manageAuthorsBtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            manageAuthorsBtn.Location = new Point(95, 258);
            manageAuthorsBtn.Margin = new Padding(2);
            manageAuthorsBtn.Name = "manageAuthorsBtn";
            manageAuthorsBtn.Size = new Size(220, 50);
            manageAuthorsBtn.TabIndex = 34;
            manageAuthorsBtn.Text = "Manage Authors";
            manageAuthorsBtn.UseVisualStyleBackColor = false;
            manageAuthorsBtn.Click += manageAuthorsBtn_Click;
            // 
            // manageCategoryBtn
            // 
            manageCategoryBtn.BackColor = Color.Cornsilk;
            manageCategoryBtn.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            manageCategoryBtn.Location = new Point(654, 258);
            manageCategoryBtn.Margin = new Padding(2);
            manageCategoryBtn.Name = "manageCategoryBtn";
            manageCategoryBtn.Size = new Size(220, 50);
            manageCategoryBtn.TabIndex = 33;
            manageCategoryBtn.Text = "Manage Categories";
            manageCategoryBtn.UseVisualStyleBackColor = false;
            manageCategoryBtn.Click += manageCategoryBtn_Click;
            // 
            // manageRentalRecordsBtn
            // 
            manageRentalRecordsBtn.BackColor = Color.Cornsilk;
            manageRentalRecordsBtn.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            manageRentalRecordsBtn.Location = new Point(95, 370);
            manageRentalRecordsBtn.Margin = new Padding(2);
            manageRentalRecordsBtn.Name = "manageRentalRecordsBtn";
            manageRentalRecordsBtn.Size = new Size(220, 50);
            manageRentalRecordsBtn.TabIndex = 30;
            manageRentalRecordsBtn.Text = "Manage Return Records";
            manageRentalRecordsBtn.UseVisualStyleBackColor = false;
            manageRentalRecordsBtn.Click += manageRentalRecordsBtn_Click;
            // 
            // manageRentalRequestBtn
            // 
            manageRentalRequestBtn.BackColor = Color.Cornsilk;
            manageRentalRequestBtn.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            manageRentalRequestBtn.Location = new Point(379, 369);
            manageRentalRequestBtn.Margin = new Padding(2);
            manageRentalRequestBtn.Name = "manageRentalRequestBtn";
            manageRentalRequestBtn.Size = new Size(220, 50);
            manageRentalRequestBtn.TabIndex = 29;
            manageRentalRequestBtn.Text = "Manage Rental Request";
            manageRentalRequestBtn.UseVisualStyleBackColor = false;
            manageRentalRequestBtn.Click += manageRentalRequestBtn_Click;
            // 
            // manageRentalTransictionsBtn
            // 
            manageRentalTransictionsBtn.BackColor = Color.Cornsilk;
            manageRentalTransictionsBtn.Font = new Font("Britannic Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            manageRentalTransictionsBtn.Location = new Point(654, 369);
            manageRentalTransictionsBtn.Margin = new Padding(2);
            manageRentalTransictionsBtn.Name = "manageRentalTransictionsBtn";
            manageRentalTransictionsBtn.Size = new Size(220, 50);
            manageRentalTransictionsBtn.TabIndex = 28;
            manageRentalTransictionsBtn.Text = "Manage Rental Transactions";
            manageRentalTransictionsBtn.UseVisualStyleBackColor = false;
            manageRentalTransictionsBtn.Click += manageRentalTransictionsBtn_Click;
            // 
            // manageBooksBtn
            // 
            manageBooksBtn.BackColor = Color.Cornsilk;
            manageBooksBtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            manageBooksBtn.Location = new Point(379, 258);
            manageBooksBtn.Margin = new Padding(2);
            manageBooksBtn.Name = "manageBooksBtn";
            manageBooksBtn.Size = new Size(220, 50);
            manageBooksBtn.TabIndex = 27;
            manageBooksBtn.Text = "Manage Books";
            manageBooksBtn.UseVisualStyleBackColor = false;
            manageBooksBtn.Click += manageBooksBtn_Click;
            // 
            // quickAccessLbl
            // 
            quickAccessLbl.BackColor = Color.Transparent;
            quickAccessLbl.FlatStyle = FlatStyle.Flat;
            quickAccessLbl.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            quickAccessLbl.ForeColor = Color.Maroon;
            quickAccessLbl.Image = Properties.Resources.search1;
            quickAccessLbl.ImageAlign = ContentAlignment.MiddleLeft;
            quickAccessLbl.Location = new Point(650, 14);
            quickAccessLbl.Name = "quickAccessLbl";
            quickAccessLbl.Size = new Size(196, 39);
            quickAccessLbl.TabIndex = 39;
            quickAccessLbl.Text = "Quick Access";
            quickAccessLbl.TextAlign = ContentAlignment.MiddleRight;
            quickAccessLbl.Click += quickAccessLbl_Click;
            quickAccessLbl.MouseEnter += quickAccessLbl_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.Maroon;
            lblWelcome.Location = new Point(64, 31);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(195, 22);
            lblWelcome.TabIndex = 37;
            lblWelcome.Text = "Welcome, username!";
            // 
            // homePageStaff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            ClientSize = new Size(978, 644);
            Controls.Add(quickAccessLbl);
            Controls.Add(lblWelcome);
            Controls.Add(ViewStatsBtn);
            Controls.Add(manageAuthorsBtn);
            Controls.Add(manageCategoryBtn);
            Controls.Add(manageRentalRecordsBtn);
            Controls.Add(manageRentalRequestBtn);
            Controls.Add(manageRentalTransictionsBtn);
            Controls.Add(manageBooksBtn);
            Controls.Add(welcomeTxt);
            Controls.Add(exitIcon);
            Controls.Add(userIcon);
            Name = "homePageStaff";
            Text = "homePageStaff";
            Load += homePageStaff_Load;
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox userIcon;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label welcomeTxt;
        private PictureBox exitIcon;
        private Button button1;
        private Button button2;
        private Button ViewStatsBtn;
        private Button manageAuthorsBtn;
        private Button manageCategoryBtn;
        private Button manageRentalRecordsBtn;
        private Button manageRentalRequestBtn;
        private Button manageRentalTransictionsBtn;
        private Button manageBooksBtn;
        private Label quickAccessLbl;
        private Label lblWelcome;
    }
}