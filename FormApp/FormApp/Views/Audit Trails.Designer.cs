namespace FormApp
{
    partial class Audit_Trails
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
            dgvAuditTrail = new DataGridView();
            exitIcon = new PictureBox();
            homeIcon = new PictureBox();
            userIcon = new PictureBox();
            filterGB = new GroupBox();
            btnReset = new Button();
            btnFilter = new Button();
            ddlFilterUser = new ComboBox();
            FilterbyUser = new Label();
            txtFilterTrailsNo = new TextBox();
            FilterbyLoginTrailsNo = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAuditTrail).BeginInit();
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
            pageTitleTxt.Size = new Size(327, 63);
            pageTitleTxt.TabIndex = 3;
            pageTitleTxt.Text = "Audit Trails";
            // 
            // dgvAuditTrail
            // 
            dgvAuditTrail.BackgroundColor = SystemColors.Control;
            dgvAuditTrail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditTrail.Location = new Point(31, 224);
            dgvAuditTrail.Margin = new Padding(2);
            dgvAuditTrail.Name = "dgvAuditTrail";
            dgvAuditTrail.RowHeadersWidth = 62;
            dgvAuditTrail.Size = new Size(930, 329);
            dgvAuditTrail.TabIndex = 4;
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
            exitIcon.TabIndex = 23;
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
            homeIcon.TabIndex = 22;
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
            userIcon.TabIndex = 21;
            userIcon.TabStop = false;
            userIcon.Click += userIcon_Click;
            // 
            // filterGB
            // 
            filterGB.BackColor = Color.Transparent;
            filterGB.Controls.Add(btnReset);
            filterGB.Controls.Add(btnFilter);
            filterGB.Controls.Add(ddlFilterUser);
            filterGB.Controls.Add(FilterbyUser);
            filterGB.Controls.Add(txtFilterTrailsNo);
            filterGB.Controls.Add(FilterbyLoginTrailsNo);
            filterGB.Font = new Font("Tahoma", 10F);
            filterGB.Location = new Point(31, 103);
            filterGB.Name = "filterGB";
            filterGB.Size = new Size(930, 96);
            filterGB.TabIndex = 39;
            filterGB.TabStop = false;
            filterGB.Text = "Filter";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Cornsilk;
            btnReset.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(809, 32);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(105, 38);
            btnReset.TabIndex = 39;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Cornsilk;
            btnFilter.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFilter.ForeColor = Color.Black;
            btnFilter.Location = new Point(700, 32);
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
            ddlFilterUser.Location = new Point(505, 35);
            ddlFilterUser.Margin = new Padding(4, 5, 4, 5);
            ddlFilterUser.Name = "ddlFilterUser";
            ddlFilterUser.Size = new Size(180, 32);
            ddlFilterUser.TabIndex = 38;
            // 
            // FilterbyUser
            // 
            FilterbyUser.AutoSize = true;
            FilterbyUser.Font = new Font("Britannic Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterbyUser.Location = new Point(357, 44);
            FilterbyUser.Name = "FilterbyUser";
            FilterbyUser.Size = new Size(147, 25);
            FilterbyUser.TabIndex = 2;
            FilterbyUser.Text = "Filter by User:";
            // 
            // txtFilterTrailsNo
            // 
            txtFilterTrailsNo.Location = new Point(187, 37);
            txtFilterTrailsNo.Name = "txtFilterTrailsNo";
            txtFilterTrailsNo.Size = new Size(150, 32);
            txtFilterTrailsNo.TabIndex = 1;
            // 
            // FilterbyLoginTrailsNo
            // 
            FilterbyLoginTrailsNo.AutoSize = true;
            FilterbyLoginTrailsNo.Font = new Font("Britannic Bold", 10F);
            FilterbyLoginTrailsNo.Location = new Point(12, 46);
            FilterbyLoginTrailsNo.Name = "FilterbyLoginTrailsNo";
            FilterbyLoginTrailsNo.Size = new Size(174, 22);
            FilterbyLoginTrailsNo.TabIndex = 0;
            FilterbyLoginTrailsNo.Text = "Filter by Trails No:";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightGray;
            btnRefresh.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(851, 570);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 35);
            btnRefresh.TabIndex = 40;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // Audit_Trails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(btnRefresh);
            Controls.Add(filterGB);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            Controls.Add(dgvAuditTrail);
            Controls.Add(pageTitleTxt);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "Audit_Trails";
            Text = "Audit_Trails";
            Load += Audit_Trails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuditTrail).EndInit();
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
        private DataGridView dgvAuditTrail;
        private PictureBox exitIcon;
        private PictureBox homeIcon;
        private PictureBox userIcon;
        private GroupBox filterGB;
        private Button btnFilter;
        private ComboBox ddlFilterUser;
        private Label FilterbyUser;
        private TextBox txtFilterTrailsNo;
        private Label FilterbyLoginTrailsNo;
        private Button btnReset;
        private Button btnRefresh;
    }
}