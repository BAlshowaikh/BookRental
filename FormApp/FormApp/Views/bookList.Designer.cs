namespace FormApp
{
    partial class bookList
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
            dgvBooksList = new DataGridView();
            groupBox1 = new GroupBox();
            lblFilterByBookName = new Label();
            txtFilterByBookID = new TextBox();
            ddlFilterByBookName = new ComboBox();
            btnRefresh = new Button();
            btnFilter = new Button();
            lblfilterByBookID = new Label();
            returnIcon = new PictureBox();
            exitIcon = new PictureBox();
            homeIcon = new PictureBox();
            userIcon = new PictureBox();
            btnDeleteBook = new Button();
            btnEditBook = new Button();
            btnAddBook = new Button();
            btnViewDetails = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooksList).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)returnIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            SuspendLayout();
            // 
            // dgvBooksList
            // 
            dgvBooksList.BackgroundColor = SystemColors.Control;
            dgvBooksList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooksList.Location = new Point(22, 210);
            dgvBooksList.Margin = new Padding(2);
            dgvBooksList.Name = "dgvBooksList";
            dgvBooksList.RowHeadersWidth = 62;
            dgvBooksList.Size = new Size(930, 340);
            dgvBooksList.TabIndex = 2;
            dgvBooksList.CellContentClick += dgvBooksList_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lblFilterByBookName);
            groupBox1.Controls.Add(txtFilterByBookID);
            groupBox1.Controls.Add(ddlFilterByBookName);
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(btnFilter);
            groupBox1.Controls.Add(lblfilterByBookID);
            groupBox1.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(22, 92);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(928, 96);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // lblFilterByBookName
            // 
            lblFilterByBookName.AutoSize = true;
            lblFilterByBookName.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFilterByBookName.ForeColor = Color.Black;
            lblFilterByBookName.Location = new Point(333, 45);
            lblFilterByBookName.Margin = new Padding(2, 0, 2, 0);
            lblFilterByBookName.Name = "lblFilterByBookName";
            lblFilterByBookName.Size = new Size(192, 22);
            lblFilterByBookName.TabIndex = 29;
            lblFilterByBookName.Text = "Filter by book name:";
            // 
            // txtFilterByBookID
            // 
            txtFilterByBookID.Location = new Point(166, 39);
            txtFilterByBookID.Name = "txtFilterByBookID";
            txtFilterByBookID.Size = new Size(150, 32);
            txtFilterByBookID.TabIndex = 28;
            // 
            // ddlFilterByBookName
            // 
            ddlFilterByBookName.FormattingEnabled = true;
            ddlFilterByBookName.Location = new Point(528, 40);
            ddlFilterByBookName.Margin = new Padding(4);
            ddlFilterByBookName.Name = "ddlFilterByBookName";
            ddlFilterByBookName.Size = new Size(168, 32);
            ddlFilterByBookName.TabIndex = 27;
            //ddlFilterByBookName.SelectedIndexChanged += ddlFilterByBookName_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Cornsilk;
            btnRefresh.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(813, 35);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(105, 38);
            btnRefresh.TabIndex = 20;
            btnRefresh.Text = "Reset";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += refreshBttn_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Cornsilk;
            btnFilter.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.Black;
            btnFilter.Location = new Point(702, 35);
            btnFilter.Margin = new Padding(2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(105, 38);
            btnFilter.TabIndex = 10;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // lblfilterByBookID
            // 
            lblfilterByBookID.AutoSize = true;
            lblfilterByBookID.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblfilterByBookID.ForeColor = Color.Black;
            lblfilterByBookID.Location = new Point(6, 45);
            lblfilterByBookID.Margin = new Padding(2, 0, 2, 0);
            lblfilterByBookID.Name = "lblfilterByBookID";
            lblfilterByBookID.Size = new Size(161, 22);
            lblfilterByBookID.TabIndex = 0;
            lblfilterByBookID.Text = "Filter by book id:";
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
            returnIcon.TabIndex = 23;
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
            exitIcon.TabIndex = 22;
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
            homeIcon.TabIndex = 21;
            homeIcon.TabStop = false;
            homeIcon.Click += pictureBox2_Click;
            // 
            // userIcon
            // 
            userIcon.BackColor = Color.Transparent;
            userIcon.Image = Properties.Resources.user;
            userIcon.Location = new Point(22, 12);
            userIcon.Margin = new Padding(2);
            userIcon.Name = "userIcon";
            userIcon.Size = new Size(40, 40);
            userIcon.SizeMode = PictureBoxSizeMode.Zoom;
            userIcon.TabIndex = 20;
            userIcon.TabStop = false;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.BackColor = Color.IndianRed;
            btnDeleteBook.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteBook.ForeColor = Color.White;
            btnDeleteBook.Location = new Point(752, 578);
            btnDeleteBook.Margin = new Padding(2);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(200, 50);
            btnDeleteBook.TabIndex = 26;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = false;
            // 
            // btnEditBook
            // 
            btnEditBook.BackColor = Color.Cornsilk;
            btnEditBook.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditBook.ForeColor = Color.Black;
            btnEditBook.Location = new Point(266, 578);
            btnEditBook.Margin = new Padding(2);
            btnEditBook.Name = "btnEditBook";
            btnEditBook.Size = new Size(200, 50);
            btnEditBook.TabIndex = 25;
            btnEditBook.Text = "Edit Book";
            btnEditBook.UseVisualStyleBackColor = false;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.Cornsilk;
            btnAddBook.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddBook.ForeColor = Color.Black;
            btnAddBook.Location = new Point(24, 578);
            btnAddBook.Margin = new Padding(2);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(200, 50);
            btnAddBook.TabIndex = 24;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.Cornsilk;
            btnViewDetails.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewDetails.ForeColor = Color.Black;
            btnViewDetails.Location = new Point(509, 578);
            btnViewDetails.Margin = new Padding(2);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(200, 50);
            btnViewDetails.TabIndex = 27;
            btnViewDetails.Text = "View Book Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // bookList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(btnViewDetails);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnEditBook);
            Controls.Add(btnAddBook);
            Controls.Add(returnIcon);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            Controls.Add(groupBox1);
            Controls.Add(dgvBooksList);
            DoubleBuffered = true;
            Margin = new Padding(4);
            Name = "bookList";
            Text = "bookList";
            Load += bookList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooksList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)returnIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvBooksList;
        private GroupBox groupBox1;
        private Button btnFilter;
        private Label lblfilterByBookID;
        private PictureBox returnIcon;
        private PictureBox exitIcon;
        private PictureBox homeIcon;
        private PictureBox userIcon;
        private Button btnDeleteBook;
        private Button btnEditBook;
        private Button btnAddBook;
        private Button btnRefresh;
        private ComboBox ddlFilterByBookName;
        private TextBox txtFilterByBookID;
        private Label lblFilterByBookName;
        private Button btnViewDetails;
    }
}