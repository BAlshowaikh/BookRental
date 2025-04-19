namespace FormApp.Views
{
    partial class rentalRequestDetails
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
            lbltitle = new Label();
            btnApprove = new Button();
            btnReject = new Button();
            txtStartDate = new TextBox();
            txtBookName = new TextBox();
            lblUserName = new Label();
            txtRequestID = new TextBox();
            lblRequestID = new Label();
            txtStatus = new TextBox();
            txtTotalCost = new TextBox();
            txtBookID = new TextBox();
            txtUserName = new TextBox();
            lblBookName = new Label();
            lblBookID = new Label();
            txtReturnDate = new TextBox();
            lblStartDate = new Label();
            lblTotalCost = new Label();
            lblReturnDate = new Label();
            lblStatus = new Label();
            lblBookStatus = new Label();
            lblUserID = new Label();
            ((System.ComponentModel.ISupportInitialize)returnIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
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
            returnIcon.TabIndex = 21;
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
            exitIcon.TabIndex = 20;
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
            homeIcon.TabIndex = 19;
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
            userIcon.TabIndex = 18;
            userIcon.TabStop = false;
            userIcon.Click += userIcon_Click;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.BackColor = Color.Transparent;
            lbltitle.Font = new Font("Tahoma", 26F, FontStyle.Bold);
            lbltitle.ForeColor = Color.Cornsilk;
            lbltitle.Location = new Point(147, 9);
            lbltitle.Margin = new Padding(2, 0, 2, 0);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(625, 63);
            lbltitle.TabIndex = 17;
            lbltitle.Text = "Rental Request Details";
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.Cornsilk;
            btnApprove.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApprove.ForeColor = Color.Black;
            btnApprove.Location = new Point(234, 565);
            btnApprove.Margin = new Padding(2);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(200, 50);
            btnApprove.TabIndex = 22;
            btnApprove.Text = "Approve Request";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.IndianRed;
            btnReject.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(542, 565);
            btnReject.Margin = new Padding(2);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(200, 50);
            btnReject.TabIndex = 23;
            btnReject.Text = "Reject Request";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // txtStartDate
            // 
            txtStartDate.Location = new Point(240, 343);
            txtStartDate.Margin = new Padding(2);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.ReadOnly = true;
            txtStartDate.Size = new Size(250, 31);
            txtStartDate.TabIndex = 43;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(710, 236);
            txtBookName.Margin = new Padding(2);
            txtBookName.Name = "txtBookName";
            txtBookName.ReadOnly = true;
            txtBookName.Size = new Size(250, 31);
            txtBookName.TabIndex = 41;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.Black;
            lblUserName.Location = new Point(540, 132);
            lblUserName.Margin = new Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(144, 29);
            lblUserName.TabIndex = 40;
            lblUserName.Text = "User Name";
            // 
            // txtRequestID
            // 
            txtRequestID.Location = new Point(240, 133);
            txtRequestID.Margin = new Padding(2);
            txtRequestID.Name = "txtRequestID";
            txtRequestID.ReadOnly = true;
            txtRequestID.Size = new Size(250, 31);
            txtRequestID.TabIndex = 38;
            // 
            // lblRequestID
            // 
            lblRequestID.AutoSize = true;
            lblRequestID.BackColor = Color.Transparent;
            lblRequestID.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequestID.ForeColor = Color.Black;
            lblRequestID.Location = new Point(19, 128);
            lblRequestID.Margin = new Padding(2, 0, 2, 0);
            lblRequestID.Name = "lblRequestID";
            lblRequestID.Size = new Size(147, 29);
            lblRequestID.TabIndex = 37;
            lblRequestID.Text = "Request ID";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(710, 448);
            txtStatus.Margin = new Padding(2);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(250, 31);
            txtStatus.TabIndex = 36;
            // 
            // txtTotalCost
            // 
            txtTotalCost.Location = new Point(240, 451);
            txtTotalCost.Margin = new Padding(2);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.ReadOnly = true;
            txtTotalCost.Size = new Size(250, 31);
            txtTotalCost.TabIndex = 34;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(240, 239);
            txtBookID.Margin = new Padding(2);
            txtBookID.Name = "txtBookID";
            txtBookID.ReadOnly = true;
            txtBookID.Size = new Size(250, 31);
            txtBookID.TabIndex = 33;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(710, 132);
            txtUserName.Margin = new Padding(2);
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(250, 31);
            txtUserName.TabIndex = 32;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.BackColor = Color.Transparent;
            lblBookName.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookName.ForeColor = Color.Black;
            lblBookName.Location = new Point(540, 238);
            lblBookName.Margin = new Padding(2, 0, 2, 0);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(150, 29);
            lblBookName.TabIndex = 31;
            lblBookName.Text = "Book Name";
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.BackColor = Color.Transparent;
            lblBookID.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookID.ForeColor = Color.Black;
            lblBookID.Location = new Point(19, 235);
            lblBookID.Margin = new Padding(2, 0, 2, 0);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(110, 29);
            lblBookID.TabIndex = 30;
            lblBookID.Text = "Book ID";
            // 
            // txtReturnDate
            // 
            txtReturnDate.Location = new Point(710, 344);
            txtReturnDate.Margin = new Padding(2);
            txtReturnDate.Name = "txtReturnDate";
            txtReturnDate.ReadOnly = true;
            txtReturnDate.Size = new Size(250, 31);
            txtReturnDate.TabIndex = 44;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.BackColor = Color.Transparent;
            lblStartDate.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartDate.ForeColor = Color.Black;
            lblStartDate.Location = new Point(19, 342);
            lblStartDate.Margin = new Padding(2, 0, 2, 0);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(135, 29);
            lblStartDate.TabIndex = 46;
            lblStartDate.Text = "Start Date";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.BackColor = Color.Transparent;
            lblTotalCost.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCost.ForeColor = Color.Black;
            lblTotalCost.Location = new Point(19, 450);
            lblTotalCost.Margin = new Padding(2, 0, 2, 0);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(134, 29);
            lblTotalCost.TabIndex = 47;
            lblTotalCost.Text = "Total Cost";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.BackColor = Color.Transparent;
            lblReturnDate.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReturnDate.ForeColor = Color.Black;
            lblReturnDate.Location = new Point(540, 343);
            lblReturnDate.Margin = new Padding(2, 0, 2, 0);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(157, 29);
            lblReturnDate.TabIndex = 48;
            lblReturnDate.Text = "Return Date";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(540, 450);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(89, 29);
            lblStatus.TabIndex = 49;
            lblStatus.Text = "Status";
            // 
            // lblBookStatus
            // 
            lblBookStatus.AutoSize = true;
            lblBookStatus.BackColor = Color.Transparent;
            lblBookStatus.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookStatus.ForeColor = Color.Black;
            lblBookStatus.Location = new Point(240, 272);
            lblBookStatus.Margin = new Padding(2, 0, 2, 0);
            lblBookStatus.Name = "lblBookStatus";
            lblBookStatus.Size = new Size(131, 24);
            lblBookStatus.TabIndex = 50;
            lblBookStatus.Text = "lblBookStatus";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.BackColor = Color.Transparent;
            lblUserID.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = Color.Black;
            lblUserID.Location = new Point(710, 165);
            lblUserID.Margin = new Padding(2, 0, 2, 0);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(92, 24);
            lblUserID.TabIndex = 51;
            lblUserID.Text = "lblUserID";
            // 
            // rentalRequestDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(lblUserID);
            Controls.Add(lblBookStatus);
            Controls.Add(lblStatus);
            Controls.Add(lblReturnDate);
            Controls.Add(lblTotalCost);
            Controls.Add(lblStartDate);
            Controls.Add(txtReturnDate);
            Controls.Add(txtStartDate);
            Controls.Add(txtBookName);
            Controls.Add(lblUserName);
            Controls.Add(txtRequestID);
            Controls.Add(lblRequestID);
            Controls.Add(txtStatus);
            Controls.Add(txtTotalCost);
            Controls.Add(txtBookID);
            Controls.Add(txtUserName);
            Controls.Add(lblBookName);
            Controls.Add(lblBookID);
            Controls.Add(btnReject);
            Controls.Add(btnApprove);
            Controls.Add(returnIcon);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            Controls.Add(lbltitle);
            DoubleBuffered = true;
            Name = "rentalRequestDetails";
            Text = "rentalRequestDetails";
            Load += rentalRequestDetails_Load;
            ((System.ComponentModel.ISupportInitialize)returnIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox returnIcon;
        private PictureBox exitIcon;
        private PictureBox homeIcon;
        private PictureBox userIcon;
        private Label lbltitle;
        private Button btnApprove;
        private Button btnReject;
        private TextBox txtStartDate;
        private TextBox txtBookName;
        private Label lblUserName;
        private TextBox txtRequestID;
        private Label lblRequestID;
        private TextBox txtStatus;
        private TextBox txtTotalCost;
        private TextBox txtBookID;
        private TextBox txtUserName;
        private Label lblBookName;
        private Label lblBookID;
        private TextBox txtReturnDate;
        private Label lblStartDate;
        private Label lblTotalCost;
        private Label lblReturnDate;
        private Label lblStatus;
        private Label lblBookStatus;
        private Label lblUserID;
    }
}