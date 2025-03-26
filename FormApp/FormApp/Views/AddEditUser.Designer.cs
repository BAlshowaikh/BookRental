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
            returnIcon.Location = new Point(859, 11);
            returnIcon.Margin = new Padding(2);
            returnIcon.Name = "returnIcon";
            returnIcon.Size = new Size(32, 32);
            returnIcon.SizeMode = PictureBoxSizeMode.Zoom;
            returnIcon.TabIndex = 20;
            returnIcon.TabStop = false;
            // 
            // exitIcon
            // 
            exitIcon.BackColor = Color.Transparent;
            exitIcon.Image = Properties.Resources.exit_icon;
            exitIcon.Location = new Point(939, 11);
            exitIcon.Margin = new Padding(2);
            exitIcon.Name = "exitIcon";
            exitIcon.Size = new Size(32, 32);
            exitIcon.SizeMode = PictureBoxSizeMode.Zoom;
            exitIcon.TabIndex = 19;
            exitIcon.TabStop = false;
            // 
            // homeIcon
            // 
            homeIcon.BackColor = Color.Transparent;
            homeIcon.Image = Properties.Resources.home__2_;
            homeIcon.Location = new Point(899, 11);
            homeIcon.Margin = new Padding(2);
            homeIcon.Name = "homeIcon";
            homeIcon.Size = new Size(32, 32);
            homeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            homeIcon.TabIndex = 18;
            homeIcon.TabStop = false;
            // 
            // userIcon
            // 
            userIcon.BackColor = Color.Transparent;
            userIcon.Image = Properties.Resources.user;
            userIcon.Location = new Point(11, 11);
            userIcon.Margin = new Padding(2);
            userIcon.Name = "userIcon";
            userIcon.Size = new Size(32, 32);
            userIcon.SizeMode = PictureBoxSizeMode.Zoom;
            userIcon.TabIndex = 17;
            userIcon.TabStop = false;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(31, 96);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(112, 22);
            lblFirstName.TabIndex = 21;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(31, 151);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(108, 22);
            lblLastName.TabIndex = 22;
            lblLastName.Text = "Last Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(31, 209);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(65, 22);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Email:";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(31, 267);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(55, 22);
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
            grpboxUserInfo.Location = new Point(12, 71);
            grpboxUserInfo.Name = "grpboxUserInfo";
            grpboxUserInfo.Size = new Size(697, 321);
            grpboxUserInfo.TabIndex = 25;
            grpboxUserInfo.TabStop = false;
            grpboxUserInfo.Text = "User Info";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(182, 36);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(261, 30);
            txtUserID.TabIndex = 30;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(31, 43);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(82, 22);
            lblUserID.TabIndex = 29;
            lblUserID.Text = "User ID:";
            // 
            // ddlRole
            // 
            ddlRole.FormattingEnabled = true;
            ddlRole.Location = new Point(182, 259);
            ddlRole.Name = "ddlRole";
            ddlRole.Size = new Size(261, 30);
            ddlRole.TabIndex = 28;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(182, 144);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(261, 30);
            txtLastName.TabIndex = 27;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(182, 202);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 30);
            txtEmail.TabIndex = 26;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(182, 89);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(261, 30);
            txtFirstName.TabIndex = 25;
            // 
            // addBttn
            // 
            addBttn.BackColor = Color.Cornsilk;
            addBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBttn.ForeColor = Color.Black;
            addBttn.Location = new Point(43, 433);
            addBttn.Margin = new Padding(2);
            addBttn.Name = "addBttn";
            addBttn.Size = new Size(160, 40);
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
            deleteBttn.Location = new Point(549, 433);
            deleteBttn.Margin = new Padding(2);
            deleteBttn.Name = "deleteBttn";
            deleteBttn.Size = new Size(160, 40);
            deleteBttn.TabIndex = 27;
            deleteBttn.Text = "Cancel";
            deleteBttn.UseVisualStyleBackColor = false;
            deleteBttn.Click += deleteBttn_Click;
            // 
            // AddEditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 653);
            Controls.Add(deleteBttn);
            Controls.Add(addBttn);
            Controls.Add(grpboxUserInfo);
            Controls.Add(returnIcon);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            Cursor = Cursors.IBeam;
            DoubleBuffered = true;
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
    }
}