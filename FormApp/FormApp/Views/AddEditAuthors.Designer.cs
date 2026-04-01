namespace FormApp.Views
{
    partial class AddEditAuthors
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
            cancelBttn = new Button();
            addBttn = new Button();
            grpboxAuthorInfo = new GroupBox();
            txtAuthorID = new TextBox();
            lblAuthorID = new Label();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            returnIcon = new PictureBox();
            exitIcon = new PictureBox();
            homeIcon = new PictureBox();
            userIcon = new PictureBox();
            pageTitle = new Label();
            grpboxAuthorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)returnIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            SuspendLayout();
            // 
            // cancelBttn
            // 
            cancelBttn.BackColor = Color.IndianRed;
            cancelBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBttn.ForeColor = Color.White;
            cancelBttn.Location = new Point(549, 495);
            cancelBttn.Margin = new Padding(2);
            cancelBttn.Name = "cancelBttn";
            cancelBttn.Size = new Size(200, 50);
            cancelBttn.TabIndex = 34;
            cancelBttn.Text = "Cancel";
            cancelBttn.UseVisualStyleBackColor = false;
            cancelBttn.Click += cancelBttn_Click;
            // 
            // addBttn
            // 
            addBttn.BackColor = Color.Cornsilk;
            addBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBttn.ForeColor = Color.Black;
            addBttn.Location = new Point(287, 495);
            addBttn.Margin = new Padding(2);
            addBttn.Name = "addBttn";
            addBttn.Size = new Size(200, 50);
            addBttn.TabIndex = 33;
            addBttn.Text = "Save Author";
            addBttn.UseVisualStyleBackColor = false;
            addBttn.Click += addBttn_Click;
            // 
            // grpboxAuthorInfo
            // 
            grpboxAuthorInfo.BackColor = Color.Transparent;
            grpboxAuthorInfo.Controls.Add(txtAuthorID);
            grpboxAuthorInfo.Controls.Add(lblAuthorID);
            grpboxAuthorInfo.Controls.Add(txtLastName);
            grpboxAuthorInfo.Controls.Add(txtEmail);
            grpboxAuthorInfo.Controls.Add(txtFirstName);
            grpboxAuthorInfo.Controls.Add(lblFirstName);
            grpboxAuthorInfo.Controls.Add(lblLastName);
            grpboxAuthorInfo.Controls.Add(lblEmail);
            grpboxAuthorInfo.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpboxAuthorInfo.Location = new Point(215, 145);
            grpboxAuthorInfo.Name = "grpboxAuthorInfo";
            grpboxAuthorInfo.Size = new Size(560, 321);
            grpboxAuthorInfo.TabIndex = 32;
            grpboxAuthorInfo.TabStop = false;
            grpboxAuthorInfo.Text = "Author Info";
            // 
            // txtAuthorID
            // 
            txtAuthorID.Location = new Point(226, 66);
            txtAuthorID.Name = "txtAuthorID";
            txtAuthorID.ReadOnly = true;
            txtAuthorID.Size = new Size(261, 34);
            txtAuthorID.TabIndex = 30;
            // 
            // lblAuthorID
            // 
            lblAuthorID.AutoSize = true;
            lblAuthorID.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAuthorID.Location = new Point(75, 73);
            lblAuthorID.Name = "lblAuthorID";
            lblAuthorID.Size = new Size(121, 27);
            lblAuthorID.TabIndex = 29;
            lblAuthorID.Text = "Author ID:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(226, 174);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(261, 34);
            txtLastName.TabIndex = 27;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(226, 232);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 34);
            txtEmail.TabIndex = 26;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(226, 119);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(261, 34);
            txtFirstName.TabIndex = 25;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(75, 126);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(133, 27);
            lblFirstName.TabIndex = 21;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(75, 181);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(129, 27);
            lblLastName.TabIndex = 22;
            lblLastName.Text = "Last Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(75, 239);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(79, 27);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Email:";
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
            returnIcon.TabIndex = 31;
            returnIcon.TabStop = false;
            returnIcon.Click += returnIcon_Click;
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
            exitIcon.TabIndex = 30;
            exitIcon.TabStop = false;
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
            homeIcon.TabIndex = 29;
            homeIcon.TabStop = false;
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
            userIcon.TabIndex = 28;
            userIcon.TabStop = false;
            userIcon.Click += userIcon_Click;
            // 
            // pageTitle
            // 
            pageTitle.AutoSize = true;
            pageTitle.BackColor = Color.Transparent;
            pageTitle.Font = new Font("Tahoma", 26F, FontStyle.Bold);
            pageTitle.ForeColor = Color.Cornsilk;
            pageTitle.Location = new Point(322, 26);
            pageTitle.Margin = new Padding(2, 0, 2, 0);
            pageTitle.Name = "pageTitle";
            pageTitle.Size = new Size(323, 63);
            pageTitle.TabIndex = 47;
            pageTitle.Text = "Add Author";
            // 
            // AddEditAuthors
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            ClientSize = new Size(978, 644);
            Controls.Add(pageTitle);
            Controls.Add(cancelBttn);
            Controls.Add(addBttn);
            Controls.Add(grpboxAuthorInfo);
            Controls.Add(returnIcon);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddEditAuthors";
            Text = "AddEditAuthors";
            Load += AddEditAuthors_Load;
            grpboxAuthorInfo.ResumeLayout(false);
            grpboxAuthorInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)returnIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBttn;
        private Button addBttn;
        private GroupBox grpboxAuthorInfo;
        private TextBox txtAuthorID;
        private Label lblAuthorID;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private PictureBox returnIcon;
        private PictureBox exitIcon;
        private PictureBox homeIcon;
        private PictureBox userIcon;
        private Label pageTitle;
    }
}