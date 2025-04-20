namespace FormApp.Views
{
    partial class ManageCategory
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
            exitIcon = new PictureBox();
            homeIcon = new PictureBox();
            userIcon = new PictureBox();
            deleteBttn = new Button();
            editBttn = new Button();
            addBttn = new Button();
            dgvCategories = new DataGridView();
            groupBox1 = new GroupBox();
            txtCategoryID = new TextBox();
            lblCategoryID = new Label();
            lblCategoryName = new Label();
            btnReset = new Button();
            ddlCategory = new ComboBox();
            filterBttn = new Button();
            label1 = new Label();
            label2 = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            exitIcon.TabIndex = 24;
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
            homeIcon.TabIndex = 23;
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
            userIcon.TabIndex = 22;
            userIcon.TabStop = false;
            userIcon.Click += userIcon_Click;
            // 
            // deleteBttn
            // 
            deleteBttn.BackColor = Color.IndianRed;
            deleteBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBttn.ForeColor = Color.White;
            deleteBttn.Location = new Point(670, 580);
            deleteBttn.Margin = new Padding(2);
            deleteBttn.Name = "deleteBttn";
            deleteBttn.Size = new Size(200, 50);
            deleteBttn.TabIndex = 21;
            deleteBttn.Text = "Delete Category";
            deleteBttn.UseVisualStyleBackColor = false;
            deleteBttn.Click += deleteBttn_Click;
            // 
            // editBttn
            // 
            editBttn.BackColor = Color.Cornsilk;
            editBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editBttn.ForeColor = Color.Black;
            editBttn.Location = new Point(403, 580);
            editBttn.Margin = new Padding(2);
            editBttn.Name = "editBttn";
            editBttn.Size = new Size(200, 50);
            editBttn.TabIndex = 20;
            editBttn.Text = "Edit Category";
            editBttn.UseVisualStyleBackColor = false;
            editBttn.Click += editBttn_Click;
            // 
            // addBttn
            // 
            addBttn.BackColor = Color.Cornsilk;
            addBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBttn.ForeColor = Color.Black;
            addBttn.Location = new Point(128, 580);
            addBttn.Margin = new Padding(2);
            addBttn.Name = "addBttn";
            addBttn.Size = new Size(200, 50);
            addBttn.TabIndex = 19;
            addBttn.Text = "Add Category";
            addBttn.UseVisualStyleBackColor = false;
            addBttn.Click += addBttn_Click;
            // 
            // dgvCategories
            // 
            dgvCategories.BackgroundColor = SystemColors.Control;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.GridColor = SystemColors.ButtonFace;
            dgvCategories.Location = new Point(21, 197);
            dgvCategories.Margin = new Padding(2);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 62;
            dgvCategories.Size = new Size(930, 329);
            dgvCategories.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtCategoryID);
            groupBox1.Controls.Add(lblCategoryID);
            groupBox1.Controls.Add(lblCategoryName);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(ddlCategory);
            groupBox1.Controls.Add(filterBttn);
            groupBox1.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(21, 83);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(930, 96);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(182, 40);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(140, 32);
            txtCategoryID.TabIndex = 22;
            // 
            // lblCategoryID
            // 
            lblCategoryID.AutoSize = true;
            lblCategoryID.Font = new Font("Britannic Bold", 9F);
            lblCategoryID.Location = new Point(5, 49);
            lblCategoryID.Name = "lblCategoryID";
            lblCategoryID.Size = new Size(180, 20);
            lblCategoryID.TabIndex = 21;
            lblCategoryID.Text = "Filter By Category ID:";
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoryName.Location = new Point(325, 48);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(207, 20);
            lblCategoryName.TabIndex = 20;
            lblCategoryName.Text = "Filter By Category Name:";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Cornsilk;
            btnReset.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(817, 35);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(105, 38);
            btnReset.TabIndex = 19;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += refreshBttn_Click;
            // 
            // ddlCategory
            // 
            ddlCategory.FormattingEnabled = true;
            ddlCategory.Location = new Point(533, 38);
            ddlCategory.Margin = new Padding(4);
            ddlCategory.Name = "ddlCategory";
            ddlCategory.Size = new Size(168, 32);
            ddlCategory.TabIndex = 18;
            // 
            // filterBttn
            // 
            filterBttn.BackColor = Color.Cornsilk;
            filterBttn.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterBttn.ForeColor = Color.Black;
            filterBttn.Location = new Point(707, 35);
            filterBttn.Margin = new Padding(2);
            filterBttn.Name = "filterBttn";
            filterBttn.Size = new Size(105, 38);
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
            label1.Location = new Point(16, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 27);
            label1.TabIndex = 0;
            label1.Text = "Filter By:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 26F, FontStyle.Bold);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(232, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(497, 63);
            label2.TabIndex = 26;
            label2.Text = "Manage Catogries";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightGray;
            btnRefresh.Font = new Font("Britannic Bold", 10F);
            btnRefresh.Location = new Point(842, 530);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 35);
            btnRefresh.TabIndex = 27;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ManageCategory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(btnRefresh);
            Controls.Add(label2);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            Controls.Add(deleteBttn);
            Controls.Add(editBttn);
            Controls.Add(addBttn);
            Controls.Add(dgvCategories);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Margin = new Padding(4);
            Name = "ManageCategory";
            Text = "ManageCategory";
            Load += ManageCategory_Load;
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox exitIcon;
        private PictureBox homeIcon;
        private PictureBox userIcon;
        private Button deleteBttn;
        private Button editBttn;
        private Button addBttn;
        private DataGridView dgvCategories;
        private GroupBox groupBox1;
        private Button btnReset;
        private ComboBox ddlCategory;
        private Button filterBttn;
        private Label label1;
        private Label label2;
        private Label lblCategoryName;
        private TextBox txtCategoryID;
        private Label lblCategoryID;
        private Button btnRefresh;
    }
}