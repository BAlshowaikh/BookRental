namespace FormApp.Views
{
    partial class mointoringDashboard
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
            welcomeTxt = new Label();
            userIcon = new PictureBox();
            returnIcon = new PictureBox();
            homeIcon = new PictureBox();
            exitIcon = new PictureBox();
            totalBooksGroupBox = new GroupBox();
            lblTotalBooksTitle = new Label();
            lblTotalBooks = new Label();
            availableBooksGroupBox = new GroupBox();
            lblAvailableBooks = new Label();
            lblAvailableBooksTitle = new Label();
            damagedBooksGroupBox = new GroupBox();
            lblDamgedBooks = new Label();
            lblDamagedBooksTitle = new Label();
            totalRentalRequestsGroupBox = new GroupBox();
            lblTotalRentalRequets = new Label();
            lblTotalRentalRequetsTitle = new Label();
            refreshBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)returnIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            totalBooksGroupBox.SuspendLayout();
            availableBooksGroupBox.SuspendLayout();
            damagedBooksGroupBox.SuspendLayout();
            totalRentalRequestsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeTxt
            // 
            welcomeTxt.AutoSize = true;
            welcomeTxt.BackColor = Color.Transparent;
            welcomeTxt.Font = new Font("Felix Titling", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeTxt.Location = new Point(187, 96);
            welcomeTxt.Margin = new Padding(2, 0, 2, 0);
            welcomeTxt.Name = "welcomeTxt";
            welcomeTxt.Size = new Size(638, 52);
            welcomeTxt.TabIndex = 13;
            welcomeTxt.Text = "Mointoring Dashboard";
            // 
            // userIcon
            // 
            userIcon.BackColor = Color.Transparent;
            userIcon.Image = Properties.Resources.user;
            userIcon.Location = new Point(19, 12);
            userIcon.Margin = new Padding(2);
            userIcon.Name = "userIcon";
            userIcon.Size = new Size(40, 40);
            userIcon.SizeMode = PictureBoxSizeMode.Zoom;
            userIcon.TabIndex = 14;
            userIcon.TabStop = false;
            // 
            // returnIcon
            // 
            returnIcon.BackColor = Color.Transparent;
            returnIcon.Image = Properties.Resources._return;
            returnIcon.Location = new Point(830, 12);
            returnIcon.Margin = new Padding(2);
            returnIcon.Name = "returnIcon";
            returnIcon.Size = new Size(40, 40);
            returnIcon.SizeMode = PictureBoxSizeMode.Zoom;
            returnIcon.TabIndex = 15;
            returnIcon.TabStop = false;
            // 
            // homeIcon
            // 
            homeIcon.BackColor = Color.Transparent;
            homeIcon.Image = Properties.Resources.home__2_;
            homeIcon.Location = new Point(880, 12);
            homeIcon.Margin = new Padding(2);
            homeIcon.Name = "homeIcon";
            homeIcon.Size = new Size(40, 40);
            homeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            homeIcon.TabIndex = 16;
            homeIcon.TabStop = false;
            // 
            // exitIcon
            // 
            exitIcon.BackColor = Color.Transparent;
            exitIcon.Image = Properties.Resources.exit_icon;
            exitIcon.Location = new Point(930, 12);
            exitIcon.Margin = new Padding(2);
            exitIcon.Name = "exitIcon";
            exitIcon.Size = new Size(40, 40);
            exitIcon.SizeMode = PictureBoxSizeMode.Zoom;
            exitIcon.TabIndex = 17;
            exitIcon.TabStop = false;
            // 
            // totalBooksGroupBox
            // 
            totalBooksGroupBox.BackColor = Color.Transparent;
            totalBooksGroupBox.Controls.Add(lblTotalBooks);
            totalBooksGroupBox.Controls.Add(lblTotalBooksTitle);
            totalBooksGroupBox.Location = new Point(88, 170);
            totalBooksGroupBox.Name = "totalBooksGroupBox";
            totalBooksGroupBox.Size = new Size(300, 150);
            totalBooksGroupBox.TabIndex = 18;
            totalBooksGroupBox.TabStop = false;
            // 
            // lblTotalBooksTitle
            // 
            lblTotalBooksTitle.AutoSize = true;
            lblTotalBooksTitle.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalBooksTitle.Location = new Point(84, 27);
            lblTotalBooksTitle.Name = "lblTotalBooksTitle";
            lblTotalBooksTitle.Size = new Size(137, 27);
            lblTotalBooksTitle.TabIndex = 0;
            lblTotalBooksTitle.Text = "Total Books";
            // 
            // lblTotalBooks
            // 
            lblTotalBooks.AutoSize = true;
            lblTotalBooks.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalBooks.Location = new Point(121, 79);
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(52, 53);
            lblTotalBooks.TabIndex = 1;
            lblTotalBooks.Text = "0";
            // 
            // availableBooksGroupBox
            // 
            availableBooksGroupBox.BackColor = Color.Transparent;
            availableBooksGroupBox.Controls.Add(lblAvailableBooks);
            availableBooksGroupBox.Controls.Add(lblAvailableBooksTitle);
            availableBooksGroupBox.Location = new Point(525, 170);
            availableBooksGroupBox.Name = "availableBooksGroupBox";
            availableBooksGroupBox.Size = new Size(300, 150);
            availableBooksGroupBox.TabIndex = 19;
            availableBooksGroupBox.TabStop = false;
            // 
            // lblAvailableBooks
            // 
            lblAvailableBooks.AutoSize = true;
            lblAvailableBooks.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvailableBooks.Location = new Point(121, 79);
            lblAvailableBooks.Name = "lblAvailableBooks";
            lblAvailableBooks.Size = new Size(52, 53);
            lblAvailableBooks.TabIndex = 1;
            lblAvailableBooks.Text = "0";
            // 
            // lblAvailableBooksTitle
            // 
            lblAvailableBooksTitle.AutoSize = true;
            lblAvailableBooksTitle.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvailableBooksTitle.Location = new Point(60, 27);
            lblAvailableBooksTitle.Name = "lblAvailableBooksTitle";
            lblAvailableBooksTitle.Size = new Size(180, 27);
            lblAvailableBooksTitle.TabIndex = 0;
            lblAvailableBooksTitle.Text = "Available Books";
            // 
            // damagedBooksGroupBox
            // 
            damagedBooksGroupBox.BackColor = Color.Transparent;
            damagedBooksGroupBox.Controls.Add(lblDamgedBooks);
            damagedBooksGroupBox.Controls.Add(lblDamagedBooksTitle);
            damagedBooksGroupBox.Location = new Point(88, 396);
            damagedBooksGroupBox.Name = "damagedBooksGroupBox";
            damagedBooksGroupBox.Size = new Size(300, 150);
            damagedBooksGroupBox.TabIndex = 19;
            damagedBooksGroupBox.TabStop = false;
            // 
            // lblDamgedBooks
            // 
            lblDamgedBooks.AutoSize = true;
            lblDamgedBooks.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDamgedBooks.Location = new Point(121, 79);
            lblDamgedBooks.Name = "lblDamgedBooks";
            lblDamgedBooks.Size = new Size(52, 53);
            lblDamgedBooks.TabIndex = 1;
            lblDamgedBooks.Text = "0";
            // 
            // lblDamagedBooksTitle
            // 
            lblDamagedBooksTitle.AutoSize = true;
            lblDamagedBooksTitle.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDamagedBooksTitle.Location = new Point(62, 27);
            lblDamagedBooksTitle.Name = "lblDamagedBooksTitle";
            lblDamagedBooksTitle.Size = new Size(184, 27);
            lblDamagedBooksTitle.TabIndex = 0;
            lblDamagedBooksTitle.Text = "Damaged Books";
            // 
            // totalRentalRequestsGroupBox
            // 
            totalRentalRequestsGroupBox.BackColor = Color.Transparent;
            totalRentalRequestsGroupBox.Controls.Add(lblTotalRentalRequets);
            totalRentalRequestsGroupBox.Controls.Add(lblTotalRentalRequetsTitle);
            totalRentalRequestsGroupBox.Location = new Point(525, 396);
            totalRentalRequestsGroupBox.Name = "totalRentalRequestsGroupBox";
            totalRentalRequestsGroupBox.Size = new Size(300, 150);
            totalRentalRequestsGroupBox.TabIndex = 20;
            totalRentalRequestsGroupBox.TabStop = false;
            // 
            // lblTotalRentalRequets
            // 
            lblTotalRentalRequets.AutoSize = true;
            lblTotalRentalRequets.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRentalRequets.Location = new Point(121, 79);
            lblTotalRentalRequets.Name = "lblTotalRentalRequets";
            lblTotalRentalRequets.Size = new Size(52, 53);
            lblTotalRentalRequets.TabIndex = 1;
            lblTotalRentalRequets.Text = "0";
            // 
            // lblTotalRentalRequetsTitle
            // 
            lblTotalRentalRequetsTitle.AutoSize = true;
            lblTotalRentalRequetsTitle.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRentalRequetsTitle.Location = new Point(35, 27);
            lblTotalRentalRequetsTitle.Name = "lblTotalRentalRequetsTitle";
            lblTotalRentalRequetsTitle.Size = new Size(233, 27);
            lblTotalRentalRequetsTitle.TabIndex = 0;
            lblTotalRentalRequetsTitle.Text = "Total Rental Requets";
            // 
            // refreshBtn
            // 
            refreshBtn.BackColor = Color.Cornsilk;
            refreshBtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshBtn.Location = new Point(357, 563);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(200, 50);
            refreshBtn.TabIndex = 10;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = false;
            // 
            // mointoringDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            ClientSize = new Size(978, 644);
            Controls.Add(refreshBtn);
            Controls.Add(totalRentalRequestsGroupBox);
            Controls.Add(damagedBooksGroupBox);
            Controls.Add(availableBooksGroupBox);
            Controls.Add(totalBooksGroupBox);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(returnIcon);
            Controls.Add(userIcon);
            Controls.Add(welcomeTxt);
            Name = "mointoringDashboard";
            Text = "mointoringDashboard";
            Load += mointoringDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)returnIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            totalBooksGroupBox.ResumeLayout(false);
            totalBooksGroupBox.PerformLayout();
            availableBooksGroupBox.ResumeLayout(false);
            availableBooksGroupBox.PerformLayout();
            damagedBooksGroupBox.ResumeLayout(false);
            damagedBooksGroupBox.PerformLayout();
            totalRentalRequestsGroupBox.ResumeLayout(false);
            totalRentalRequestsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeTxt;
        private PictureBox userIcon;
        private PictureBox returnIcon;
        private PictureBox homeIcon;
        private PictureBox exitIcon;
        private GroupBox damagedBooksGroupBox;
        private GroupBox totalBooksGroupBox;
        private Label lblTotalBooks;
        private Label lblTotalBooksTitle;
        private GroupBox availableBooksGroupBox;
        private Label lblAvailableBooks;
        private Label lblAvailableBooksTitle;
        private Label lblDamgedBooks;
        private Label lblDamagedBooksTitle;
        private GroupBox totalRentalRequestsGroupBox;
        private Label lblTotalRentalRequets;
        private Label lblTotalRentalRequetsTitle;
        private Button refreshBtn;
    }
}