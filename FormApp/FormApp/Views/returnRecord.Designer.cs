namespace FormApp.Views
{
    partial class returnRecord
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
            pageTitleTxt = new Label();
            exitIcon = new PictureBox();
            homeIcon = new PictureBox();
            userIcon = new PictureBox();
            dgvReturnRecourd = new DataGridView();
            btnRefresh = new Button();
            btnDetails = new Button();
            filterGB = new GroupBox();
            ddlFilterBook = new ComboBox();
            FilterbyBook = new Label();
            btnResetFilter = new Button();
            btnFilter = new Button();
            txtFilterRecordNo = new TextBox();
            FilterbyRecourdNo = new Label();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReturnRecourd).BeginInit();
            filterGB.SuspendLayout();
            SuspendLayout();
            // 
            // pageTitleTxt
            // 
            pageTitleTxt.AutoSize = true;
            pageTitleTxt.BackColor = Color.Transparent;
            pageTitleTxt.Font = new Font("Tahoma", 26F, FontStyle.Bold);
            pageTitleTxt.ForeColor = Color.Cornsilk;
            pageTitleTxt.Location = new Point(171, 9);
            pageTitleTxt.Margin = new Padding(2, 0, 2, 0);
            pageTitleTxt.Name = "pageTitleTxt";
            pageTitleTxt.Size = new Size(653, 63);
            pageTitleTxt.TabIndex = 4;
            pageTitleTxt.Text = "Manage Return Records";
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
            exitIcon.TabIndex = 27;
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
            homeIcon.TabIndex = 26;
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
            userIcon.TabIndex = 25;
            userIcon.TabStop = false;
            userIcon.Click += userIcon_Click;
            // 
            // dgvReturnRecourd
            // 
            dgvReturnRecourd.BackgroundColor = SystemColors.Control;
            dgvReturnRecourd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReturnRecourd.Location = new Point(26, 207);
            dgvReturnRecourd.Margin = new Padding(2);
            dgvReturnRecourd.Name = "dgvReturnRecourd";
            dgvReturnRecourd.RowHeadersWidth = 62;
            dgvReturnRecourd.Size = new Size(930, 329);
            dgvReturnRecourd.TabIndex = 29;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightGray;
            btnRefresh.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(845, 542);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 35);
            btnRefresh.TabIndex = 30;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = Color.Cornsilk;
            btnDetails.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDetails.ForeColor = Color.Black;
            btnDetails.Location = new Point(426, 582);
            btnDetails.Margin = new Padding(2);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(162, 51);
            btnDetails.TabIndex = 31;
            btnDetails.Text = "Details";
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Click += btnDetails_Click;
            // 
            // filterGB
            // 
            filterGB.BackColor = Color.Transparent;
            filterGB.Controls.Add(ddlFilterBook);
            filterGB.Controls.Add(FilterbyBook);
            filterGB.Controls.Add(btnResetFilter);
            filterGB.Controls.Add(btnFilter);
            filterGB.Controls.Add(txtFilterRecordNo);
            filterGB.Controls.Add(FilterbyRecourdNo);
            filterGB.Font = new Font("Tahoma", 10F);
            filterGB.Location = new Point(26, 93);
            filterGB.Name = "filterGB";
            filterGB.Size = new Size(928, 96);
            filterGB.TabIndex = 38;
            filterGB.TabStop = false;
            filterGB.Text = "Filter";
            // 
            // ddlFilterBook
            // 
            ddlFilterBook.FormattingEnabled = true;
            ddlFilterBook.Location = new Point(512, 38);
            ddlFilterBook.Margin = new Padding(4, 5, 4, 5);
            ddlFilterBook.Name = "ddlFilterBook";
            ddlFilterBook.Size = new Size(168, 32);
            ddlFilterBook.TabIndex = 41;
            // 
            // FilterbyBook
            // 
            FilterbyBook.AutoSize = true;
            FilterbyBook.Font = new Font("Britannic Bold", 10F);
            FilterbyBook.Location = new Point(373, 45);
            FilterbyBook.Name = "FilterbyBook";
            FilterbyBook.Size = new Size(140, 22);
            FilterbyBook.TabIndex = 40;
            FilterbyBook.Text = "Filter by Book:";
            // 
            // btnResetFilter
            // 
            btnResetFilter.BackColor = Color.Cornsilk;
            btnResetFilter.FlatAppearance.BorderSize = 0;
            btnResetFilter.Font = new Font("Britannic Bold", 10F);
            btnResetFilter.ForeColor = Color.Black;
            btnResetFilter.Location = new Point(809, 35);
            btnResetFilter.Margin = new Padding(4, 5, 4, 5);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(105, 38);
            btnResetFilter.TabIndex = 39;
            btnResetFilter.Text = "Reset ";
            btnResetFilter.UseVisualStyleBackColor = false;
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Cornsilk;
            btnFilter.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.Black;
            btnFilter.Location = new Point(693, 35);
            btnFilter.Margin = new Padding(2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(105, 38);
            btnFilter.TabIndex = 38;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // txtFilterRecordNo
            // 
            txtFilterRecordNo.Location = new Point(194, 41);
            txtFilterRecordNo.Name = "txtFilterRecordNo";
            txtFilterRecordNo.Size = new Size(168, 32);
            txtFilterRecordNo.TabIndex = 1;
            // 
            // FilterbyRecourdNo
            // 
            FilterbyRecourdNo.AutoSize = true;
            FilterbyRecourdNo.Font = new Font("Britannic Bold", 10F);
            FilterbyRecourdNo.Location = new Point(10, 45);
            FilterbyRecourdNo.Name = "FilterbyRecourdNo";
            FilterbyRecourdNo.Size = new Size(187, 22);
            FilterbyRecourdNo.TabIndex = 0;
            FilterbyRecourdNo.Text = "Filter by Record No:";
            // 
            // returnRecord
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(filterGB);
            Controls.Add(btnDetails);
            Controls.Add(btnRefresh);
            Controls.Add(dgvReturnRecourd);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            Controls.Add(pageTitleTxt);
            DoubleBuffered = true;
            Name = "returnRecord";
            Text = "returnRecord";
            Load += returnRecord_Load;
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReturnRecourd).EndInit();
            filterGB.ResumeLayout(false);
            filterGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pageTitleTxt;
        private PictureBox exitIcon;
        private PictureBox homeIcon;
        private PictureBox userIcon;
        private DataGridView dgvReturnRecourd;
        private Button btnRefresh;
        private Button btnDetails;
        private GroupBox filterGB;
        private Button btnResetFilter;
        private TextBox txtFilterRecordNo;
        private Label FilterbyRecourdNo;
        private ComboBox ddlFilterBook;
        private Label FilterbyBook;
        private Button btnFilter;
    }
}