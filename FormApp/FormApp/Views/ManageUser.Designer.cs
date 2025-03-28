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
            refreshBttn = new Button();
            ddlUser = new ComboBox();
            filterBttn = new Button();
            label1 = new Label();
            dgvUsers = new DataGridView();
            addBttn = new Button();
            editBttn = new Button();
            deleteBttn = new Button();
            returnIcon = new PictureBox();
            exitIcon = new PictureBox();
            homeIcon = new PictureBox();
            userIcon = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)returnIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(refreshBttn);
            groupBox1.Controls.Add(ddlUser);
            groupBox1.Controls.Add(filterBttn);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(22, 92);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(928, 96);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // refreshBttn
            // 
            refreshBttn.BackColor = Color.Cornsilk;
            refreshBttn.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshBttn.ForeColor = Color.Black;
            refreshBttn.Location = new Point(568, 38);
            refreshBttn.Margin = new Padding(2);
            refreshBttn.Name = "refreshBttn";
            refreshBttn.Size = new Size(140, 38);
            refreshBttn.TabIndex = 19;
            refreshBttn.Text = "Refresh";
            refreshBttn.UseVisualStyleBackColor = false;
            refreshBttn.Click += refreshBttn_Click;
            // 
            // ddlUser
            // 
            ddlUser.FormattingEnabled = true;
            ddlUser.Location = new Point(139, 36);
            ddlUser.Margin = new Padding(4);
            ddlUser.Name = "ddlUser";
            ddlUser.Size = new Size(252, 32);
            ddlUser.TabIndex = 18;
            // 
            // filterBttn
            // 
            filterBttn.BackColor = Color.Cornsilk;
            filterBttn.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterBttn.ForeColor = Color.Black;
            filterBttn.Location = new Point(415, 38);
            filterBttn.Margin = new Padding(2);
            filterBttn.Name = "filterBttn";
            filterBttn.Size = new Size(140, 38);
            filterBttn.TabIndex = 10;
            filterBttn.Text = "Filter";
            filterBttn.UseVisualStyleBackColor = false;
            filterBttn.Click += filterBttn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(18, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 27);
            label1.TabIndex = 0;
            label1.Text = "Filter By:";
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = SystemColors.Control;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.GridColor = SystemColors.ButtonFace;
            dgvUsers.Location = new Point(22, 210);
            dgvUsers.Margin = new Padding(2);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.Size = new Size(930, 340);
            dgvUsers.TabIndex = 1;
            // 
            // addBttn
            // 
            addBttn.BackColor = Color.Cornsilk;
            addBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBttn.ForeColor = Color.Black;
            addBttn.Location = new Point(22, 571);
            addBttn.Margin = new Padding(2);
            addBttn.Name = "addBttn";
            addBttn.Size = new Size(200, 50);
            addBttn.TabIndex = 10;
            addBttn.Text = "Add User";
            addBttn.UseVisualStyleBackColor = false;
            addBttn.Click += addBttn_Click;
            // 
            // editBttn
            // 
            editBttn.BackColor = Color.Cornsilk;
            editBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editBttn.ForeColor = Color.Black;
            editBttn.Location = new Point(248, 571);
            editBttn.Margin = new Padding(2);
            editBttn.Name = "editBttn";
            editBttn.Size = new Size(200, 50);
            editBttn.TabIndex = 11;
            editBttn.Text = "Edit User";
            editBttn.UseVisualStyleBackColor = false;
            editBttn.Click += editBttn_Click;
            // 
            // deleteBttn
            // 
            deleteBttn.BackColor = Color.IndianRed;
            deleteBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBttn.ForeColor = Color.White;
            deleteBttn.Location = new Point(471, 571);
            deleteBttn.Margin = new Padding(2);
            deleteBttn.Name = "deleteBttn";
            deleteBttn.Size = new Size(200, 50);
            deleteBttn.TabIndex = 12;
            deleteBttn.Text = "Delete User";
            deleteBttn.UseVisualStyleBackColor = false;
            deleteBttn.Click += deleteBttn_Click;
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
            returnIcon.TabIndex = 16;
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
            exitIcon.TabIndex = 15;
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
            homeIcon.TabIndex = 14;
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
            userIcon.TabIndex = 13;
            userIcon.TabStop = false;
            // 
            // ManageUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(returnIcon);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            Controls.Add(deleteBttn);
            Controls.Add(editBttn);
            Controls.Add(addBttn);
            Controls.Add(dgvUsers);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Margin = new Padding(4);
            Name = "ManageUser";
            Text = "ManageUser";
            Load += ManageUser_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)returnIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button filterBttn;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private DataGridView dgvUsers;
        private Button addBttn;
        private Button editBttn;
        private Button deleteBttn;
        private PictureBox returnIcon;
        private PictureBox exitIcon;
        private PictureBox homeIcon;
        private PictureBox userIcon;
        private ComboBox ddlUser;
        private Button refreshBttn;
    }
}