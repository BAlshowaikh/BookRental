namespace FormApp
{
    partial class homePageAdmin
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
            homeIcon = new PictureBox();
            exitIcon = new PictureBox();
            returnIcon = new PictureBox();
            welcomeTxt = new Label();
            manageUsersBtn = new Button();
            manageBooksBtn = new Button();
            manageRentalTransictionsBtn = new Button();
            manageRentalRequestBtn = new Button();
            manageRentalRecordsBtn = new Button();
            generateRecordsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)returnIcon).BeginInit();
            SuspendLayout();
            // 
            // userIcon
            // 
            userIcon.BackColor = Color.Transparent;
            userIcon.Image = Properties.Resources.user;
            userIcon.Location = new Point(15, 10);
            userIcon.Margin = new Padding(2, 2, 2, 2);
            userIcon.Name = "userIcon";
            userIcon.Size = new Size(48, 48);
            userIcon.SizeMode = PictureBoxSizeMode.Zoom;
            userIcon.TabIndex = 8;
            userIcon.TabStop = false;
            // 
            // homeIcon
            // 
            homeIcon.BackColor = Color.Transparent;
            homeIcon.Image = Properties.Resources.home__1_;
            homeIcon.Location = new Point(666, 10);
            homeIcon.Margin = new Padding(2, 2, 2, 2);
            homeIcon.Name = "homeIcon";
            homeIcon.Size = new Size(48, 48);
            homeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            homeIcon.TabIndex = 9;
            homeIcon.TabStop = false;
            homeIcon.Click += pictureBox2_Click;
            // 
            // exitIcon
            // 
            exitIcon.BackColor = Color.Transparent;
            exitIcon.Image = Properties.Resources.logout;
            exitIcon.Location = new Point(718, 10);
            exitIcon.Margin = new Padding(2, 2, 2, 2);
            exitIcon.Name = "exitIcon";
            exitIcon.Size = new Size(48, 48);
            exitIcon.SizeMode = PictureBoxSizeMode.Zoom;
            exitIcon.TabIndex = 10;
            exitIcon.TabStop = false;
            // 
            // returnIcon
            // 
            returnIcon.BackColor = Color.Transparent;
            returnIcon.Image = Properties.Resources._return;
            returnIcon.Location = new Point(613, 10);
            returnIcon.Margin = new Padding(2, 2, 2, 2);
            returnIcon.Name = "returnIcon";
            returnIcon.Size = new Size(48, 48);
            returnIcon.SizeMode = PictureBoxSizeMode.Zoom;
            returnIcon.TabIndex = 11;
            returnIcon.TabStop = false;
            // 
            // welcomeTxt
            // 
            welcomeTxt.AutoSize = true;
            welcomeTxt.BackColor = Color.Transparent;
            welcomeTxt.Font = new Font("Edwardian Script ITC", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeTxt.Location = new Point(164, 132);
            welcomeTxt.Margin = new Padding(2, 0, 2, 0);
            welcomeTxt.Name = "welcomeTxt";
            welcomeTxt.Size = new Size(509, 55);
            welcomeTxt.TabIndex = 12;
            welcomeTxt.Text = "Welocome to Book Nook Store!";
            // 
            // manageUsersBtn
            // 
            manageUsersBtn.BackColor = Color.Cornsilk;
            manageUsersBtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manageUsersBtn.Location = new Point(83, 239);
            manageUsersBtn.Margin = new Padding(2, 2, 2, 2);
            manageUsersBtn.Name = "manageUsersBtn";
            manageUsersBtn.Size = new Size(176, 40);
            manageUsersBtn.TabIndex = 13;
            manageUsersBtn.Text = "Manage Users";
            manageUsersBtn.UseVisualStyleBackColor = false;
            // 
            // manageBooksBtn
            // 
            manageBooksBtn.BackColor = Color.Cornsilk;
            manageBooksBtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manageBooksBtn.Location = new Point(310, 238);
            manageBooksBtn.Margin = new Padding(2, 2, 2, 2);
            manageBooksBtn.Name = "manageBooksBtn";
            manageBooksBtn.Size = new Size(176, 40);
            manageBooksBtn.TabIndex = 14;
            manageBooksBtn.Text = "Manage Books";
            manageBooksBtn.UseVisualStyleBackColor = false;
            // 
            // manageRentalTransictionsBtn
            // 
            manageRentalTransictionsBtn.BackColor = Color.Cornsilk;
            manageRentalTransictionsBtn.Font = new Font("Britannic Bold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manageRentalTransictionsBtn.Location = new Point(310, 327);
            manageRentalTransictionsBtn.Margin = new Padding(2, 2, 2, 2);
            manageRentalTransictionsBtn.Name = "manageRentalTransictionsBtn";
            manageRentalTransictionsBtn.Size = new Size(176, 40);
            manageRentalTransictionsBtn.TabIndex = 15;
            manageRentalTransictionsBtn.Text = "Manage Rental Transictions";
            manageRentalTransictionsBtn.UseVisualStyleBackColor = false;
            // 
            // manageRentalRequestBtn
            // 
            manageRentalRequestBtn.BackColor = Color.Cornsilk;
            manageRentalRequestBtn.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manageRentalRequestBtn.Location = new Point(526, 238);
            manageRentalRequestBtn.Margin = new Padding(2, 2, 2, 2);
            manageRentalRequestBtn.Name = "manageRentalRequestBtn";
            manageRentalRequestBtn.Size = new Size(176, 40);
            manageRentalRequestBtn.TabIndex = 16;
            manageRentalRequestBtn.Text = "Manage Rental Request";
            manageRentalRequestBtn.UseVisualStyleBackColor = false;
            manageRentalRequestBtn.Click += button2_Click;
            // 
            // manageRentalRecordsBtn
            // 
            manageRentalRecordsBtn.BackColor = Color.Cornsilk;
            manageRentalRecordsBtn.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manageRentalRecordsBtn.Location = new Point(83, 329);
            manageRentalRecordsBtn.Margin = new Padding(2, 2, 2, 2);
            manageRentalRecordsBtn.Name = "manageRentalRecordsBtn";
            manageRentalRecordsBtn.Size = new Size(176, 40);
            manageRentalRecordsBtn.TabIndex = 17;
            manageRentalRecordsBtn.Text = "Manage Rental Records";
            manageRentalRecordsBtn.UseVisualStyleBackColor = false;
            // 
            // generateRecordsBtn
            // 
            generateRecordsBtn.BackColor = Color.Cornsilk;
            generateRecordsBtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generateRecordsBtn.Location = new Point(526, 324);
            generateRecordsBtn.Margin = new Padding(2, 2, 2, 2);
            generateRecordsBtn.Name = "generateRecordsBtn";
            generateRecordsBtn.Size = new Size(176, 40);
            generateRecordsBtn.TabIndex = 18;
            generateRecordsBtn.Text = "Generate Records";
            generateRecordsBtn.UseVisualStyleBackColor = false;
            generateRecordsBtn.Click += button1_Click;
            // 
            // homePageAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 653);
            Controls.Add(generateRecordsBtn);
            Controls.Add(manageRentalRecordsBtn);
            Controls.Add(manageRentalRequestBtn);
            Controls.Add(manageRentalTransictionsBtn);
            Controls.Add(manageBooksBtn);
            Controls.Add(manageUsersBtn);
            Controls.Add(welcomeTxt);
            Controls.Add(returnIcon);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            DoubleBuffered = true;
            Margin = new Padding(2, 2, 2, 2);
            Name = "homePageAdmin";
            Text = "homePageAdmin";
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)returnIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox userIcon;
        private PictureBox homeIcon;
        private PictureBox exitIcon;
        private PictureBox returnIcon;
        private Label welcomeTxt;
        private Button manageUsersBtn;
        private Button manageBooksBtn;
        private Button manageRentalTransictionsBtn;
        private Button manageRentalRequestBtn;
        private Button manageRentalRecordsBtn;
        private Button generateRecordsBtn;
    }
}