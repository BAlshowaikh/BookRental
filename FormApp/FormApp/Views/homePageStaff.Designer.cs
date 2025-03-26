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
            returnIcon = new PictureBox();
            homeIcon = new PictureBox();
            exitIcon = new PictureBox();
            welcomeTxt = new Label();
            manageBooksBtn = new Button();
            manageRentalRequestsBtn = new Button();
            ManageRentalTransactionsBtn = new Button();
            ManageReturnRecordBtn = new Button();
            GenerateRecordBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)returnIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
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
            // 
            // returnIcon
            // 
            returnIcon.BackColor = Color.Transparent;
            returnIcon.Image = Properties.Resources._return;
            returnIcon.Location = new Point(830, 12);
            returnIcon.Name = "returnIcon";
            returnIcon.Size = new Size(40, 40);
            returnIcon.SizeMode = PictureBoxSizeMode.Zoom;
            returnIcon.TabIndex = 10;
            returnIcon.TabStop = false;
            // 
            // homeIcon
            // 
            homeIcon.BackColor = Color.Transparent;
            homeIcon.Image = Properties.Resources.home__2_;
            homeIcon.Location = new Point(880, 12);
            homeIcon.Name = "homeIcon";
            homeIcon.Size = new Size(40, 40);
            homeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            homeIcon.TabIndex = 11;
            homeIcon.TabStop = false;
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
            welcomeTxt.Font = new Font("Felix Titling", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeTxt.Location = new Point(66, 176);
            welcomeTxt.Margin = new Padding(2, 0, 2, 0);
            welcomeTxt.Name = "welcomeTxt";
            welcomeTxt.Size = new Size(854, 52);
            welcomeTxt.TabIndex = 13;
            welcomeTxt.Text = "Welocome to Book Nook Store!";
            // 
            // manageBooksBtn
            // 
            manageBooksBtn.BackColor = Color.Cornsilk;
            manageBooksBtn.Font = new Font("Britannic Bold", 12F);
            manageBooksBtn.Location = new Point(104, 299);
            manageBooksBtn.Name = "manageBooksBtn";
            manageBooksBtn.Size = new Size(220, 50);
            manageBooksBtn.TabIndex = 14;
            manageBooksBtn.Text = "Manage Books";
            manageBooksBtn.UseVisualStyleBackColor = false;
            manageBooksBtn.Click += manageBooksBtn_Click_1;
            // 
            // manageRentalRequestsBtn
            // 
            manageRentalRequestsBtn.BackColor = Color.Cornsilk;
            manageRentalRequestsBtn.Font = new Font("Britannic Bold", 9F);
            manageRentalRequestsBtn.Location = new Point(379, 297);
            manageRentalRequestsBtn.Name = "manageRentalRequestsBtn";
            manageRentalRequestsBtn.Size = new Size(220, 50);
            manageRentalRequestsBtn.TabIndex = 15;
            manageRentalRequestsBtn.Text = "Manage Rental Requets";
            manageRentalRequestsBtn.UseVisualStyleBackColor = false;
            manageRentalRequestsBtn.Click += manageRentalRequestsBtn_Click;
            // 
            // ManageRentalTransactionsBtn
            // 
            ManageRentalTransactionsBtn.BackColor = Color.Cornsilk;
            ManageRentalTransactionsBtn.Font = new Font("Britannic Bold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ManageRentalTransactionsBtn.Location = new Point(650, 297);
            ManageRentalTransactionsBtn.Name = "ManageRentalTransactionsBtn";
            ManageRentalTransactionsBtn.Size = new Size(220, 50);
            ManageRentalTransactionsBtn.TabIndex = 16;
            ManageRentalTransactionsBtn.Text = "Manage Rental Transactions";
            ManageRentalTransactionsBtn.UseVisualStyleBackColor = false;
            ManageRentalTransactionsBtn.Click += ManageRentalTransactionsBtn_Click;
            // 
            // ManageReturnRecordBtn
            // 
            ManageReturnRecordBtn.BackColor = Color.Cornsilk;
            ManageReturnRecordBtn.Font = new Font("Britannic Bold", 9F);
            ManageReturnRecordBtn.Location = new Point(202, 407);
            ManageReturnRecordBtn.Name = "ManageReturnRecordBtn";
            ManageReturnRecordBtn.Size = new Size(220, 50);
            ManageReturnRecordBtn.TabIndex = 17;
            ManageReturnRecordBtn.Text = "Manage Rental Record";
            ManageReturnRecordBtn.UseVisualStyleBackColor = false;
            ManageReturnRecordBtn.Click += ManageReturnRecordBtn_Click;
            // 
            // GenerateRecordBtn
            // 
            GenerateRecordBtn.BackColor = Color.Cornsilk;
            GenerateRecordBtn.Font = new Font("Britannic Bold", 12F);
            GenerateRecordBtn.Location = new Point(541, 407);
            GenerateRecordBtn.Name = "GenerateRecordBtn";
            GenerateRecordBtn.Size = new Size(220, 50);
            GenerateRecordBtn.TabIndex = 18;
            GenerateRecordBtn.Text = "Generate Record";
            GenerateRecordBtn.UseVisualStyleBackColor = false;
            // 
            // homePageStaff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            ClientSize = new Size(978, 644);
            Controls.Add(GenerateRecordBtn);
            Controls.Add(ManageReturnRecordBtn);
            Controls.Add(ManageRentalTransactionsBtn);
            Controls.Add(manageRentalRequestsBtn);
            Controls.Add(manageBooksBtn);
            Controls.Add(welcomeTxt);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(returnIcon);
            Controls.Add(userIcon);
            Name = "homePageStaff";
            Text = "homePageStaff";
            Load += homePageStaff_Load;
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)returnIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
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
        private PictureBox returnIcon;
        private PictureBox homeIcon;
        private PictureBox exitIcon;
        private Button button1;
        private Button manageBooksBtn;
        private Button manageRentalRequestsBtn;
        private Button ManageRentalTransactionsBtn;
        private Button ManageReturnRecordBtn;
        private Button GenerateRecordBtn;
    }
}