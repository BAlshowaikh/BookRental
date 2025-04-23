namespace FormApp.Views
{
    partial class Logging
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
            dgvLogTrail = new DataGridView();
            exitIcon = new PictureBox();
            homeIcon = new PictureBox();
            userIcon = new PictureBox();
            btnRefresh = new Button();
            filterGB = new GroupBox();
            btnResetFilter = new Button();
            btnFilter = new Button();
            ddlFilterUser = new ComboBox();
            FilterbyUser = new Label();
            txtFilterTrailsNo = new TextBox();
            FilterbyLoginTrailsNo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLogTrail).BeginInit();
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
            pageTitleTxt.Location = new Point(315, 9);
            pageTitleTxt.Margin = new Padding(2, 0, 2, 0);
            pageTitleTxt.Name = "pageTitleTxt";
            pageTitleTxt.Size = new Size(331, 63);
            pageTitleTxt.TabIndex = 4;
            pageTitleTxt.Text = "Login Trails";
            // 
            // dgvLogTrail
            // 
            dgvLogTrail.BackgroundColor = SystemColors.Control;
            dgvLogTrail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogTrail.Location = new Point(31, 230);
            dgvLogTrail.Margin = new Padding(2);
            dgvLogTrail.Name = "dgvLogTrail";
            dgvLogTrail.RowHeadersWidth = 62;
            dgvLogTrail.Size = new Size(930, 329);
            dgvLogTrail.TabIndex = 5;
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
            exitIcon.TabIndex = 26;
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
            homeIcon.TabIndex = 25;
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
            userIcon.TabIndex = 28;
            userIcon.TabStop = false;
            userIcon.Click += userIcon_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightGray;
            btnRefresh.Font = new Font("Britannic Bold", 10F);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(851, 567);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 35);
            btnRefresh.TabIndex = 29;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // filterGB
            // 
            filterGB.BackColor = Color.Transparent;
            filterGB.Controls.Add(btnResetFilter);
            filterGB.Controls.Add(btnFilter);
            filterGB.Controls.Add(ddlFilterUser);
            filterGB.Controls.Add(FilterbyUser);
            filterGB.Controls.Add(txtFilterTrailsNo);
            filterGB.Controls.Add(FilterbyLoginTrailsNo);
            filterGB.Font = new Font("Tahoma", 10F);
            filterGB.Location = new Point(31, 117);
            filterGB.Name = "filterGB";
            filterGB.Size = new Size(928, 96);
            filterGB.TabIndex = 38;
            filterGB.TabStop = false;
            filterGB.Text = "Filter";
            // 
            // btnResetFilter
            // 
            btnResetFilter.BackColor = Color.Cornsilk;
            btnResetFilter.FlatAppearance.BorderSize = 0;
            btnResetFilter.Font = new Font("Britannic Bold", 10F);
            btnResetFilter.ForeColor = Color.Black;
            btnResetFilter.Location = new Point(801, 34);
            btnResetFilter.Margin = new Padding(2);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(105, 38);
            btnResetFilter.TabIndex = 39;
            btnResetFilter.Text = "Reset";
            btnResetFilter.UseVisualStyleBackColor = false;
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Cornsilk;
            btnFilter.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.Black;
            btnFilter.Location = new Point(686, 34);
            btnFilter.Margin = new Padding(2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(105, 38);
            btnFilter.TabIndex = 38;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // ddlFilterUser
            // 
            ddlFilterUser.FormattingEnabled = true;
            ddlFilterUser.Location = new Point(504, 38);
            ddlFilterUser.Margin = new Padding(4, 5, 4, 5);
            ddlFilterUser.Name = "ddlFilterUser";
            ddlFilterUser.Size = new Size(160, 32);
            ddlFilterUser.TabIndex = 38;
            // 
            // FilterbyUser
            // 
            FilterbyUser.AutoSize = true;
            FilterbyUser.Font = new Font("Britannic Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterbyUser.Location = new Point(354, 47);
            FilterbyUser.Name = "FilterbyUser";
            FilterbyUser.Size = new Size(147, 25);
            FilterbyUser.TabIndex = 2;
            FilterbyUser.Text = "Filter by User:";
            // 
            // txtFilterTrailsNo
            // 
            txtFilterTrailsNo.Location = new Point(185, 41);
            txtFilterTrailsNo.Name = "txtFilterTrailsNo";
            txtFilterTrailsNo.Size = new Size(150, 32);
            txtFilterTrailsNo.TabIndex = 1;
            // 
            // FilterbyLoginTrailsNo
            // 
            FilterbyLoginTrailsNo.AutoSize = true;
            FilterbyLoginTrailsNo.Font = new Font("Britannic Bold", 10F);
            FilterbyLoginTrailsNo.Location = new Point(11, 48);
            FilterbyLoginTrailsNo.Name = "FilterbyLoginTrailsNo";
            FilterbyLoginTrailsNo.Size = new Size(174, 22);
            FilterbyLoginTrailsNo.TabIndex = 0;
            FilterbyLoginTrailsNo.Text = "Filter by Trails No:";
            // 
            // Logging
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(filterGB);
            Controls.Add(btnRefresh);
            Controls.Add(userIcon);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(dgvLogTrail);
            Controls.Add(pageTitleTxt);
            DoubleBuffered = true;
            Name = "Logging";
            Text = "Logging";
            Load += Logging_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLogTrail).EndInit();
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
        private DataGridView dgvLogTrail;
        private PictureBox exitIcon;
        private PictureBox homeIcon;
        private PictureBox userIcon;
        private Button btnRefresh;
        private GroupBox filterGB;
        private Button btnResetFilter;
        private Button btnFilter;
        private ComboBox ddlFilterUser;
        private Label FilterbyUser;
        private TextBox txtFilterTrailsNo;
        private Label FilterbyLoginTrailsNo;
    }
}