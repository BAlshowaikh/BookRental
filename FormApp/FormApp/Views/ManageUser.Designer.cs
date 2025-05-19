namespace FormApp
{
    partial class ManageUser
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
            groupBox1 = new GroupBox();
            txtUserID = new TextBox();
            lblUserID = new Label();
            btnReset = new Button();
            ddlUser = new ComboBox();
            filterBttn = new Button();
            lblFullName = new Label();
            dgvUsers = new DataGridView();
            addBttn = new Button();
            editBttn = new Button();
            deleteBttn = new Button();
            exitIcon = new PictureBox();
            homeIcon = new PictureBox();
            userIcon = new PictureBox();
            pageTitleTxt = new Label();
            btnRefresh = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtUserID);
            groupBox1.Controls.Add(lblUserID);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(ddlUser);
            groupBox1.Controls.Add(filterBttn);
            groupBox1.Controls.Add(lblFullName);
            groupBox1.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(25, 66);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(742, 77);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(101, 32);
            txtUserID.Margin = new Padding(2);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(177, 28);
            txtUserID.TabIndex = 19;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserID.Location = new Point(4, 36);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(97, 19);
            lblUserID.TabIndex = 20;
            lblUserID.Text = "Filter By ID:";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Cornsilk;
            btnReset.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(657, 30);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(84, 30);
            btnReset.TabIndex = 19;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += refreshBttn_Click;
            // 
            // ddlUser
            // 
            ddlUser.FormattingEnabled = true;
            ddlUser.Location = new Point(367, 32);
            ddlUser.Margin = new Padding(4);
            ddlUser.Name = "ddlUser";
            ddlUser.Size = new Size(197, 29);
            ddlUser.TabIndex = 18;
            // 
            // filterBttn
            // 
            filterBttn.BackColor = Color.Cornsilk;
            filterBttn.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            filterBttn.ForeColor = Color.Black;
            filterBttn.Location = new Point(570, 30);
            filterBttn.Margin = new Padding(2);
            filterBttn.Name = "filterBttn";
            filterBttn.Size = new Size(84, 30);
            filterBttn.TabIndex = 10;
            filterBttn.Text = "Filter";
            filterBttn.UseVisualStyleBackColor = false;
            filterBttn.Click += filterBttn_Click;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblFullName.ForeColor = Color.Black;
            lblFullName.Location = new Point(282, 36);
            lblFullName.Margin = new Padding(2, 0, 2, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(83, 19);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "FullName:";
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = SystemColors.Control;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.GridColor = SystemColors.ButtonFace;
            dgvUsers.Location = new Point(23, 156);
            dgvUsers.Margin = new Padding(2);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.Size = new Size(744, 264);
            dgvUsers.TabIndex = 1;
            // 
            // addBttn
            // 
            addBttn.BackColor = Color.Cornsilk;
            addBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addBttn.ForeColor = Color.Black;
            addBttn.Location = new Point(61, 466);
            addBttn.Margin = new Padding(2);
            addBttn.Name = "addBttn";
            addBttn.Size = new Size(160, 40);
            addBttn.TabIndex = 10;
            addBttn.Text = "Add User";
            addBttn.UseVisualStyleBackColor = false;
            addBttn.Click += addBttn_Click;
            // 
            // editBttn
            // 
            editBttn.BackColor = Color.Cornsilk;
            editBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            editBttn.ForeColor = Color.Black;
            editBttn.Location = new Point(320, 466);
            editBttn.Margin = new Padding(2);
            editBttn.Name = "editBttn";
            editBttn.Size = new Size(160, 40);
            editBttn.TabIndex = 11;
            editBttn.Text = "Edit User";
            editBttn.UseVisualStyleBackColor = false;
            editBttn.Click += editBttn_Click;
            // 
            // deleteBttn
            // 
            deleteBttn.BackColor = Color.IndianRed;
            deleteBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBttn.ForeColor = Color.White;
            deleteBttn.Location = new Point(576, 466);
            deleteBttn.Margin = new Padding(2);
            deleteBttn.Name = "deleteBttn";
            deleteBttn.Size = new Size(160, 40);
            deleteBttn.TabIndex = 12;
            deleteBttn.Text = "Delete User";
            deleteBttn.UseVisualStyleBackColor = false;
            deleteBttn.Click += deleteBttn_Click;
            // 
            // exitIcon
            // 
            exitIcon.BackColor = Color.Transparent;
            exitIcon.Image = Properties.Resources.exit_icon;
            exitIcon.Location = new Point(744, 10);
            exitIcon.Margin = new Padding(2);
            exitIcon.Name = "exitIcon";
            exitIcon.Size = new Size(32, 32);
            exitIcon.SizeMode = PictureBoxSizeMode.Zoom;
            exitIcon.TabIndex = 15;
            exitIcon.TabStop = false;
            exitIcon.Click += exitIcon_Click;
            // 
            // homeIcon
            // 
            homeIcon.BackColor = Color.Transparent;
            homeIcon.Image = Properties.Resources.home__2_;
            homeIcon.Location = new Point(704, 10);
            homeIcon.Margin = new Padding(2);
            homeIcon.Name = "homeIcon";
            homeIcon.Size = new Size(32, 32);
            homeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            homeIcon.TabIndex = 14;
            homeIcon.TabStop = false;
            homeIcon.Click += homeIcon_Click;
            // 
            // userIcon
            // 
            userIcon.BackColor = Color.Transparent;
            userIcon.Image = Properties.Resources.user;
            userIcon.Location = new Point(15, 10);
            userIcon.Margin = new Padding(2);
            userIcon.Name = "userIcon";
            userIcon.Size = new Size(32, 32);
            userIcon.SizeMode = PictureBoxSizeMode.Zoom;
            userIcon.TabIndex = 13;
            userIcon.TabStop = false;
            userIcon.Click += userIcon_Click;
            // 
            // pageTitleTxt
            // 
            pageTitleTxt.AutoSize = true;
            pageTitleTxt.BackColor = Color.Transparent;
            pageTitleTxt.Font = new Font("Tahoma", 26F, FontStyle.Bold, GraphicsUnit.Point);
            pageTitleTxt.ForeColor = Color.Cornsilk;
            pageTitleTxt.Location = new Point(232, 7);
            pageTitleTxt.Margin = new Padding(2, 0, 2, 0);
            pageTitleTxt.Name = "pageTitleTxt";
            pageTitleTxt.Size = new Size(333, 53);
            pageTitleTxt.TabIndex = 17;
            pageTitleTxt.Text = "Manage Users";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightGray;
            btnRefresh.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(679, 425);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(88, 28);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ManageUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 515);
            Controls.Add(btnRefresh);
            Controls.Add(pageTitleTxt);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            Controls.Add(deleteBttn);
            Controls.Add(editBttn);
            Controls.Add(addBttn);
            Controls.Add(dgvUsers);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Name = "ManageUser";
            Text = "ManageUser";
            Load += ManageUser_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button filterBttn;
        private Label lblFullName;
        private Button btnRefresh;
        private Button button2;
        private DataGridView dgvUsers;
        private Button addBttn;
        private Button editBttn;
        private Button deleteBttn;
        private PictureBox exitIcon;
        private PictureBox homeIcon;
        private PictureBox userIcon;
        private ComboBox ddlUser;
        private Button btnReset;
        private Label pageTitleTxt;
        private Label lblUserID;
        private TextBox txtUserID;
    }
}