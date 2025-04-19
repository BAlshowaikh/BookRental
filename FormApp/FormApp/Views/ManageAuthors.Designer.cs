
namespace FormApp.Views
{
    partial class ManageAuthors
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
            dgvAuthors = new DataGridView();
            groupBox1 = new GroupBox();
            btnReset = new Button();
            ddlAuthors = new ComboBox();
            filterBttn = new Button();
            lblAuthorName = new Label();
            deleteBttn = new Button();
            editBttn = new Button();
            addBttn = new Button();
            lblAuthorID = new Label();
            txtAuthorID = new TextBox();
            pageTitleTxt = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)returnIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            groupBox1.SuspendLayout();
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
            returnIcon.TabIndex = 31;
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
            // 
            // dgvAuthors
            // 
            dgvAuthors.BackgroundColor = SystemColors.Control;
            dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthors.GridColor = SystemColors.ButtonFace;
            dgvAuthors.Location = new Point(27, 195);
            dgvAuthors.Margin = new Padding(2);
            dgvAuthors.Name = "dgvAuthors";
            dgvAuthors.RowHeadersWidth = 62;
            dgvAuthors.Size = new Size(930, 329);
            dgvAuthors.TabIndex = 27;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtAuthorID);
            groupBox1.Controls.Add(lblAuthorID);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(ddlAuthors);
            groupBox1.Controls.Add(filterBttn);
            groupBox1.Controls.Add(lblAuthorName);
            groupBox1.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(27, 79);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(928, 96);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Cornsilk;
            btnReset.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(810, 39);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(105, 38);
            btnReset.TabIndex = 19;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += refreshBttn_Click_1;
            // 
            // ddlAuthors
            // 
            ddlAuthors.FormattingEnabled = true;
            ddlAuthors.Location = new Point(514, 42);
            ddlAuthors.Name = "ddlAuthors";
            ddlAuthors.Size = new Size(168, 32);
            ddlAuthors.TabIndex = 18;
            // 
            // filterBttn
            // 
            filterBttn.BackColor = Color.Cornsilk;
            filterBttn.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterBttn.ForeColor = Color.Black;
            filterBttn.Location = new Point(701, 39);
            filterBttn.Margin = new Padding(2);
            filterBttn.Name = "filterBttn";
            filterBttn.Size = new Size(105, 38);
            filterBttn.TabIndex = 10;
            filterBttn.Text = "Filter";
            filterBttn.UseVisualStyleBackColor = false;
            filterBttn.Click += filterBttn_Click;
            // 
            // lblAuthorName
            // 
            lblAuthorName.AutoSize = true;
            lblAuthorName.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAuthorName.ForeColor = Color.Black;
            lblAuthorName.Location = new Point(369, 47);
            lblAuthorName.Margin = new Padding(2, 0, 2, 0);
            lblAuthorName.Name = "lblAuthorName";
            lblAuthorName.Size = new Size(145, 22);
            lblAuthorName.TabIndex = 0;
            lblAuthorName.Text = "Filter By Name:";
            // 
            // deleteBttn
            // 
            deleteBttn.BackColor = Color.IndianRed;
            deleteBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBttn.ForeColor = Color.White;
            deleteBttn.Location = new Point(697, 580);
            deleteBttn.Margin = new Padding(2);
            deleteBttn.Name = "deleteBttn";
            deleteBttn.Size = new Size(200, 50);
            deleteBttn.TabIndex = 34;
            deleteBttn.Text = "Delete Authors";
            deleteBttn.UseVisualStyleBackColor = false;
            deleteBttn.Click += deleteBttn_Click;
            // 
            // editBttn
            // 
            editBttn.BackColor = Color.Cornsilk;
            editBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editBttn.ForeColor = Color.Black;
            editBttn.Location = new Point(421, 580);
            editBttn.Margin = new Padding(2);
            editBttn.Name = "editBttn";
            editBttn.Size = new Size(200, 50);
            editBttn.TabIndex = 33;
            editBttn.Text = "Edit Authors";
            editBttn.UseVisualStyleBackColor = false;
            editBttn.Click += editBttn_Click_1;
            // 
            // addBttn
            // 
            addBttn.BackColor = Color.Cornsilk;
            addBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBttn.ForeColor = Color.Black;
            addBttn.Location = new Point(131, 580);
            addBttn.Margin = new Padding(2);
            addBttn.Name = "addBttn";
            addBttn.Size = new Size(200, 50);
            addBttn.TabIndex = 32;
            addBttn.Text = "Add Authors";
            addBttn.UseVisualStyleBackColor = false;
            addBttn.Click += addBttn_Click_1;
            // 
            // lblAuthorID
            // 
            lblAuthorID.AutoSize = true;
            lblAuthorID.Font = new Font("Britannic Bold", 10F);
            lblAuthorID.Location = new Point(10, 47);
            lblAuthorID.Name = "lblAuthorID";
            lblAuthorID.Size = new Size(178, 22);
            lblAuthorID.TabIndex = 20;
            lblAuthorID.Text = "Filter by Author ID:";
            lblAuthorID.Click += label1_Click;
            // 
            // txtAuthorID
            // 
            txtAuthorID.Location = new Point(187, 42);
            txtAuthorID.Name = "txtAuthorID";
            txtAuthorID.Size = new Size(168, 32);
            txtAuthorID.TabIndex = 21;
            // 
            // pageTitleTxt
            // 
            pageTitleTxt.AutoSize = true;
            pageTitleTxt.BackColor = Color.Transparent;
            pageTitleTxt.Font = new Font("Tahoma", 26F, FontStyle.Bold);
            pageTitleTxt.ForeColor = Color.Cornsilk;
            pageTitleTxt.Location = new Point(256, 6);
            pageTitleTxt.Name = "pageTitleTxt";
            pageTitleTxt.Size = new Size(453, 63);
            pageTitleTxt.TabIndex = 35;
            pageTitleTxt.Text = "Manage Authors";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightGray;
            btnRefresh.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(847, 530);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 35);
            btnRefresh.TabIndex = 36;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ManageAuthors
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(btnRefresh);
            Controls.Add(pageTitleTxt);
            Controls.Add(deleteBttn);
            Controls.Add(editBttn);
            Controls.Add(addBttn);
            Controls.Add(returnIcon);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            Controls.Add(dgvAuthors);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ManageAuthors";
            Text = "ManageAuthors";
            Load += ManageAuthors_Load;
            ((System.ComponentModel.ISupportInitialize)returnIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void addBttn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void editBttn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ddlAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void refreshBttn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox returnIcon;
        private PictureBox exitIcon;
        private PictureBox homeIcon;
        private PictureBox userIcon;
        private DataGridView dgvAuthors;
        private GroupBox groupBox1;
        private Button btnReset;
        private ComboBox ddlAuthors;
        private Button filterBttn;
        private Label lblAuthorName;
        private Button deleteBttn;
        private Button editBttn;
        private Button addBttn;
        private Label lblAuthorID;
        private TextBox txtAuthorID;
        private Label pageTitleTxt;
        private Button btnRefresh;
    }
}