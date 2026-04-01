namespace FormApp.Views
{
    partial class profile
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
            label1 = new Label();
            saveBtn = new Button();
            cancelBtn = new Button();
            homeIcon = new PictureBox();
            exitIcon = new PictureBox();
            emailTxt = new TextBox();
            lblEmail = new Label();
            lastNameTxt = new TextBox();
            lblLastName = new Label();
            firstNameTxt = new TextBox();
            lblContactNumber = new Label();
            textBox1 = new TextBox();
            lblFirstName = new Label();
            userInfoGroupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            userInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 26F, FontStyle.Bold);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(379, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 63);
            label1.TabIndex = 1;
            label1.Text = "Profile";
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Cornsilk;
            saveBtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.Location = new Point(275, 558);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(200, 50);
            saveBtn.TabIndex = 9;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.IndianRed;
            cancelBtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(509, 558);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(200, 50);
            cancelBtn.TabIndex = 10;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // homeIcon
            // 
            homeIcon.BackColor = Color.Transparent;
            homeIcon.Image = Properties.Resources.home__2_;
            homeIcon.Location = new Point(880, 12);
            homeIcon.Name = "homeIcon";
            homeIcon.Size = new Size(40, 40);
            homeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            homeIcon.TabIndex = 12;
            homeIcon.TabStop = false;
            homeIcon.Click += homeIcon_Click;
            // 
            // exitIcon
            // 
            exitIcon.BackColor = Color.Transparent;
            exitIcon.Image = Properties.Resources.exit_icon;
            exitIcon.Location = new Point(930, 12);
            exitIcon.Name = "exitIcon";
            exitIcon.Size = new Size(40, 40);
            exitIcon.SizeMode = PictureBoxSizeMode.Zoom;
            exitIcon.TabIndex = 13;
            exitIcon.TabStop = false;
            exitIcon.Click += exitIcon_Click;
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(296, 226);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(399, 34);
            emailTxt.TabIndex = 7;
            emailTxt.TextChanged += emailTxt_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(77, 230);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(79, 27);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // lastNameTxt
            // 
            lastNameTxt.Location = new Point(296, 146);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(399, 34);
            lastNameTxt.TabIndex = 5;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(78, 150);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(129, 27);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name:";
            // 
            // firstNameTxt
            // 
            firstNameTxt.Location = new Point(296, 69);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(399, 34);
            firstNameTxt.TabIndex = 3;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.BackColor = Color.Transparent;
            lblContactNumber.Font = new Font("Britannic Bold", 12F);
            lblContactNumber.Location = new Point(78, 306);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(191, 27);
            lblContactNumber.TabIndex = 14;
            lblContactNumber.Text = "Contact Number:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(292, 305);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(403, 34);
            textBox1.TabIndex = 15;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(74, 70);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(133, 27);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name:";
            // 
            // userInfoGroupBox
            // 
            userInfoGroupBox.BackColor = Color.Transparent;
            userInfoGroupBox.Controls.Add(firstNameTxt);
            userInfoGroupBox.Controls.Add(textBox1);
            userInfoGroupBox.Controls.Add(lblContactNumber);
            userInfoGroupBox.Controls.Add(lblEmail);
            userInfoGroupBox.Controls.Add(lblFirstName);
            userInfoGroupBox.Controls.Add(emailTxt);
            userInfoGroupBox.Controls.Add(lastNameTxt);
            userInfoGroupBox.Controls.Add(lblLastName);
            userInfoGroupBox.Font = new Font("Britannic Bold", 12F);
            userInfoGroupBox.Location = new Point(109, 114);
            userInfoGroupBox.Name = "userInfoGroupBox";
            userInfoGroupBox.Size = new Size(778, 409);
            userInfoGroupBox.TabIndex = 16;
            userInfoGroupBox.TabStop = false;
            userInfoGroupBox.Text = "User Info";
            // 
            // profile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(userInfoGroupBox);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(label1);
            DoubleBuffered = true;
            HelpButton = true;
            Name = "profile";
            Text = "profile";
            Load += profile_Load;
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            userInfoGroupBox.ResumeLayout(false);
            userInfoGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox3;
        private Button SaveBtn;
        private Button button1;
        private PictureBox homeIcon;
        private PictureBox exitIcon;
        private Button saveBtn;
        private Button cancelBtn;
        private TextBox emailTxt;
        private Label lblEmail;
        private TextBox lastNameTxt;
        private Label lblLastName;
        private TextBox firstNameTxt;
        private Label lblContactNumber;
        private TextBox textBox1;
        private Label lblFirstName;
        private GroupBox userInfoGroupBox;
    }
}