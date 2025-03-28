namespace FormApp.Views
{
    partial class rentalRequest
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
            dgvRentalRequest = new DataGridView();
            returnIcon = new PictureBox();
            exitIcon = new PictureBox();
            homeIcon = new PictureBox();
            userIcon = new PictureBox();
            btnDetails = new Button();
            btnRefresh = new Button();
            filterGB = new GroupBox();
            btnResetFilter = new Button();
            btnFilter = new Button();
            ddlFilterUser = new ComboBox();
            FilterbyUser = new Label();
            txtFilterRequestNo = new TextBox();
            FilterbyRequestNo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRentalRequest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)returnIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            filterGB.SuspendLayout();
            SuspendLayout();
            // 
            // pageTitleTxt
            // 
            pageTitleTxt.AutoSize = true;
            pageTitleTxt.BackColor = Color.Transparent;
            pageTitleTxt.Font = new Font("Tahoma", 26F, FontStyle.Bold);
            pageTitleTxt.ForeColor = Color.Cornsilk;
            pageTitleTxt.Location = new Point(264, 9);
            pageTitleTxt.Margin = new Padding(2, 0, 2, 0);
            pageTitleTxt.Name = "pageTitleTxt";
            pageTitleTxt.Size = new Size(428, 63);
            pageTitleTxt.TabIndex = 4;
            pageTitleTxt.Text = "Rental Request";
            // 
            // dgvRentalRequest
            // 
            dgvRentalRequest.BackgroundColor = SystemColors.Control;
            dgvRentalRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalRequest.Location = new Point(93, 175);
            dgvRentalRequest.Margin = new Padding(2);
            dgvRentalRequest.Name = "dgvRentalRequest";
            dgvRentalRequest.RowHeadersWidth = 62;
            dgvRentalRequest.Size = new Size(792, 392);
            dgvRentalRequest.TabIndex = 30;
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
            returnIcon.TabIndex = 34;
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
            exitIcon.TabIndex = 33;
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
            homeIcon.TabIndex = 32;
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
            userIcon.TabIndex = 31;
            userIcon.TabStop = false;
            // 
            // btnDetails
            // 
            btnDetails.BackColor = Color.Cornsilk;
            btnDetails.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDetails.ForeColor = Color.Black;
            btnDetails.Location = new Point(208, 576);
            btnDetails.Margin = new Padding(2);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(162, 51);
            btnDetails.TabIndex = 36;
            btnDetails.Text = "Details";
            btnDetails.UseVisualStyleBackColor = false;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Cornsilk;
            btnRefresh.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(31, 576);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(162, 51);
            btnRefresh.TabIndex = 35;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // filterGB
            // 
            filterGB.Controls.Add(btnResetFilter);
            filterGB.Controls.Add(btnFilter);
            filterGB.Controls.Add(ddlFilterUser);
            filterGB.Controls.Add(FilterbyUser);
            filterGB.Controls.Add(txtFilterRequestNo);
            filterGB.Controls.Add(FilterbyRequestNo);
            filterGB.Location = new Point(93, 86);
            filterGB.Name = "filterGB";
            filterGB.Size = new Size(792, 72);
            filterGB.TabIndex = 37;
            filterGB.TabStop = false;
            filterGB.Text = "Filter";
            // 
            // btnResetFilter
            // 
            btnResetFilter.BackColor = Color.WhiteSmoke;
            btnResetFilter.FlatAppearance.BorderSize = 0;
            btnResetFilter.FlatStyle = FlatStyle.Flat;
            btnResetFilter.ForeColor = Color.Black;
            btnResetFilter.Location = new Point(680, 29);
            btnResetFilter.Margin = new Padding(4, 5, 4, 5);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(105, 30);
            btnResetFilter.TabIndex = 39;
            btnResetFilter.Text = "Reset Filter";
            btnResetFilter.UseVisualStyleBackColor = false;
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Cornsilk;
            btnFilter.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.Black;
            btnFilter.Location = new Point(574, 29);
            btnFilter.Margin = new Padding(2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(105, 30);
            btnFilter.TabIndex = 38;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // ddlFilterUser
            // 
            ddlFilterUser.FormattingEnabled = true;
            ddlFilterUser.Location = new Point(394, 26);
            ddlFilterUser.Margin = new Padding(4, 5, 4, 5);
            ddlFilterUser.Name = "ddlFilterUser";
            ddlFilterUser.Size = new Size(174, 33);
            ddlFilterUser.TabIndex = 38;
            // 
            // FilterbyUser
            // 
            FilterbyUser.AutoSize = true;
            FilterbyUser.Location = new Point(268, 31);
            FilterbyUser.Name = "FilterbyUser";
            FilterbyUser.Size = new Size(119, 25);
            FilterbyUser.TabIndex = 2;
            FilterbyUser.Text = "Filter by User:";
            // 
            // txtFilterRequestNo
            // 
            txtFilterRequestNo.Location = new Point(194, 29);
            txtFilterRequestNo.Name = "txtFilterRequestNo";
            txtFilterRequestNo.Size = new Size(68, 31);
            txtFilterRequestNo.TabIndex = 1;
            // 
            // FilterbyRequestNo
            // 
            FilterbyRequestNo.AutoSize = true;
            FilterbyRequestNo.Location = new Point(12, 31);
            FilterbyRequestNo.Name = "FilterbyRequestNo";
            FilterbyRequestNo.Size = new Size(176, 25);
            FilterbyRequestNo.TabIndex = 0;
            FilterbyRequestNo.Text = "Filter by Request No:";
            // 
            // rentalRequest
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(filterGB);
            Controls.Add(btnDetails);
            Controls.Add(btnRefresh);
            Controls.Add(returnIcon);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            Controls.Add(dgvRentalRequest);
            Controls.Add(pageTitleTxt);
            DoubleBuffered = true;
            Name = "rentalRequest";
            Text = "rentalRequest";
            Load += rentalRequest_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRentalRequest).EndInit();
            ((System.ComponentModel.ISupportInitialize)returnIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            filterGB.ResumeLayout(false);
            filterGB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pageTitleTxt;
        private DataGridView dgvRentalRequest;
        private PictureBox returnIcon;
        private PictureBox exitIcon;
        private PictureBox homeIcon;
        private PictureBox userIcon;
        private Button btnDetails;
        private Button btnRefresh;
        private GroupBox filterGB;
        private Label FilterbyUser;
        private Label FilterbyRequestNo;
        private Button btnFilter;
        private ComboBox ddlFilterUser;
        private Button btnResetFilter;
        private TextBox txtFilterRequestNo;
    }
}