namespace FormApp.Views
{
    partial class AddEditUser
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
            returnIcon = new PictureBox();
            exitIcon = new PictureBox();
            homeIcon = new PictureBox();
            userIcon = new PictureBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            lblRole = new Label();
            grpboxUserInfo = new GroupBox();
            txtUserID = new TextBox();
            lblUserID = new Label();
            ddlRole = new ComboBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtFirstName = new TextBox();
            addBttn = new Button();
            deleteBttn = new Button();
            pageTitleTxt = new Label();
            ((System.ComponentModel.ISupportInitialize)returnIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            grpboxUserInfo.SuspendLayout();
            SuspendLayout();
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
            returnIcon.TabIndex = 20;
            returnIcon.TabStop = false;
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
            exitIcon.TabIndex = 19;
            exitIcon.TabStop = false;
            exitIcon.Click += exitIcon_Click;
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
            homeIcon.TabIndex = 18;
            homeIcon.TabStop = false;
            homeIcon.Click += homeIcon_Click;
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
            userIcon.TabIndex = 17;
            userIcon.TabStop = false;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(39, 120);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(133, 27);
            lblFirstName.TabIndex = 21;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(39, 189);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(129, 27);
            lblLastName.TabIndex = 22;
            lblLastName.Text = "Last Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(39, 261);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(79, 27);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Email:";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(39, 334);
            lblRole.Margin = new Padding(4, 0, 4, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(66, 27);
            lblRole.TabIndex = 24;
            lblRole.Text = "Role:";
            // 
            // grpboxUserInfo
            // 
            grpboxUserInfo.BackColor = Color.Transparent;
            grpboxUserInfo.Controls.Add(txtUserID);
            grpboxUserInfo.Controls.Add(lblUserID);
            grpboxUserInfo.Controls.Add(ddlRole);
            grpboxUserInfo.Controls.Add(txtLastName);
            grpboxUserInfo.Controls.Add(txtEmail);
            grpboxUserInfo.Controls.Add(txtFirstName);
            grpboxUserInfo.Controls.Add(lblFirstName);
            grpboxUserInfo.Controls.Add(lblRole);
            grpboxUserInfo.Controls.Add(lblLastName);
            grpboxUserInfo.Controls.Add(lblEmail);
            grpboxUserInfo.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpboxUserInfo.Location = new Point(163, 126);
            grpboxUserInfo.Margin = new Padding(4);
            grpboxUserInfo.Name = "grpboxUserInfo";
            grpboxUserInfo.Padding = new Padding(4);
            grpboxUserInfo.Size = new Size(652, 401);
            grpboxUserInfo.TabIndex = 25;
            grpboxUserInfo.TabStop = false;
            grpboxUserInfo.Text = "User Info";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(228, 45);
            txtUserID.Margin = new Padding(4);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(325, 34);
            txtUserID.TabIndex = 30;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(39, 54);
            lblUserID.Margin = new Padding(4, 0, 4, 0);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(97, 27);
            lblUserID.TabIndex = 29;
            lblUserID.Text = "User ID:";
            // 
            // ddlRole
            // 
            ddlRole.FormattingEnabled = true;
            ddlRole.Location = new Point(228, 324);
            ddlRole.Margin = new Padding(4);
            ddlRole.Name = "ddlRole";
            ddlRole.Size = new Size(325, 35);
            ddlRole.TabIndex = 28;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(228, 180);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(325, 34);
            txtLastName.TabIndex = 27;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(228, 252);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(325, 34);
            txtEmail.TabIndex = 26;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(228, 111);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(325, 34);
            txtFirstName.TabIndex = 25;
            // 
            // addBttn
            // 
            addBttn.BackColor = Color.Cornsilk;
            addBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBttn.ForeColor = Color.Black;
            addBttn.Location = new Point(275, 542);
            addBttn.Margin = new Padding(2);
            addBttn.Name = "addBttn";
            addBttn.Size = new Size(200, 50);
            addBttn.TabIndex = 26;
            addBttn.Text = "Save User";
            addBttn.UseVisualStyleBackColor = false;
            addBttn.Click += addBttn_Click;
            // 
            // deleteBttn
            // 
            deleteBttn.BackColor = Color.IndianRed;
            deleteBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBttn.ForeColor = Color.White;
            deleteBttn.Location = new Point(516, 542);
            deleteBttn.Margin = new Padding(2);
            deleteBttn.Name = "deleteBttn";
            deleteBttn.Size = new Size(200, 50);
            deleteBttn.TabIndex = 27;
            deleteBttn.Text = "Cancel";
            deleteBttn.UseVisualStyleBackColor = false;
            deleteBttn.Click += deleteBttn_Click;
            // 
            // pageTitleTxt
            // 
            pageTitleTxt.AutoSize = true;
            pageTitleTxt.BackColor = Color.Transparent;
            pageTitleTxt.Font = new Font("Tahoma", 26F, FontStyle.Bold);
            pageTitleTxt.ForeColor = Color.Cornsilk;
            pageTitleTxt.Location = new Point(356, 12);
            pageTitleTxt.Margin = new Padding(2, 0, 2, 0);
            pageTitleTxt.Name = "pageTitleTxt";
            pageTitleTxt.Size = new Size(263, 63);
            pageTitleTxt.TabIndex = 28;
            pageTitleTxt.Text = "Add User";
            // 
            // AddEditUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(pageTitleTxt);
            Controls.Add(deleteBttn);
            Controls.Add(addBttn);
            Controls.Add(grpboxUserInfo);
            Controls.Add(returnIcon);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            Cursor = Cursors.IBeam;
            DoubleBuffered = true;
            Margin = new Padding(4);
            Name = "AddEditUser";
            Text = "AddEditUser";
            Load += AddEditUser_Load;
            ((System.ComponentModel.ISupportInitialize)returnIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            grpboxUserInfo.ResumeLayout(false);
            grpboxUserInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox returnIcon;
        private PictureBox exitIcon;
        private PictureBox homeIcon;
        private PictureBox userIcon;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private Label lblRole;
        private GroupBox grpboxUserInfo;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtFirstName;
        private ComboBox ddlRole;
        private Button addBttn;
        private Button deleteBttn;
        private TextBox txtUserID;
        private Label lblUserID;
        private Label pageTitleTxt;
    }
}