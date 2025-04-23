namespace FormApp.Views
{
    partial class EditTransaction
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
            pictureBox1 = new PictureBox();
            pageTitle = new Label();
            cancelBttn = new Button();
            saveBttn = new Button();
            grpboxUserInfo = new GroupBox();
            ddlPaymentStatus = new ComboBox();
            ddlPaymentMethod = new ComboBox();
            dtpReturnDate = new DateTimePicker();
            dtpRentalStartDate = new DateTimePicker();
            txtRentalFee = new TextBox();
            lblRentalFee = new Label();
            txtRentalPeriod = new TextBox();
            label2 = new Label();
            lblPaymentMethod = new Label();
            lblPaymentStatus = new Label();
            txtTransactionID = new TextBox();
            lblTransactionID = new Label();
            txtBookName = new TextBox();
            txtCustomerName = new TextBox();
            lblCustomerName = new Label();
            lblRole = new Label();
            lblBookName = new Label();
            lblEmail = new Label();
            ((System.ComponentModel.ISupportInitialize)returnIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpboxUserInfo.SuspendLayout();
            SuspendLayout();
            // 
            // returnIcon
            // 
            returnIcon.BackColor = Color.Transparent;
            returnIcon.Image = Properties.Resources._return;
            returnIcon.Location = new Point(840, 20);
            returnIcon.Margin = new Padding(2);
            returnIcon.Name = "returnIcon";
            returnIcon.Size = new Size(32, 32);
            returnIcon.SizeMode = PictureBoxSizeMode.Zoom;
            returnIcon.TabIndex = 44;
            returnIcon.TabStop = false;
            // 
            // exitIcon
            // 
            exitIcon.BackColor = Color.Transparent;
            exitIcon.Image = Properties.Resources.exit_icon;
            exitIcon.Location = new Point(920, 20);
            exitIcon.Margin = new Padding(2);
            exitIcon.Name = "exitIcon";
            exitIcon.Size = new Size(32, 32);
            exitIcon.SizeMode = PictureBoxSizeMode.Zoom;
            exitIcon.TabIndex = 43;
            exitIcon.TabStop = false;
            // 
            // homeIcon
            // 
            homeIcon.BackColor = Color.Transparent;
            homeIcon.Image = Properties.Resources.home__2_;
            homeIcon.Location = new Point(880, 20);
            homeIcon.Margin = new Padding(2);
            homeIcon.Name = "homeIcon";
            homeIcon.Size = new Size(32, 32);
            homeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            homeIcon.TabIndex = 42;
            homeIcon.TabStop = false;
            // 
            // userIcon
            // 
            userIcon.BackColor = Color.Transparent;
            userIcon.Image = Properties.Resources.user;
            userIcon.Location = new Point(-156, 25);
            userIcon.Margin = new Padding(2);
            userIcon.Name = "userIcon";
            userIcon.Size = new Size(32, 32);
            userIcon.SizeMode = PictureBoxSizeMode.Zoom;
            userIcon.TabIndex = 41;
            userIcon.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(30, 20);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // pageTitle
            // 
            pageTitle.AutoSize = true;
            pageTitle.BackColor = Color.Transparent;
            pageTitle.Font = new Font("Tahoma", 26F, FontStyle.Bold);
            pageTitle.ForeColor = Color.Cornsilk;
            pageTitle.Location = new Point(235, 10);
            pageTitle.Margin = new Padding(2, 0, 2, 0);
            pageTitle.Name = "pageTitle";
            pageTitle.Size = new Size(380, 53);
            pageTitle.TabIndex = 48;
            pageTitle.Text = "Edit Transaction";
            // 
            // cancelBttn
            // 
            cancelBttn.BackColor = Color.IndianRed;
            cancelBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBttn.ForeColor = Color.White;
            cancelBttn.Location = new Point(614, 481);
            cancelBttn.Margin = new Padding(2);
            cancelBttn.Name = "cancelBttn";
            cancelBttn.Size = new Size(160, 40);
            cancelBttn.TabIndex = 51;
            cancelBttn.Text = "Cancel";
            cancelBttn.UseVisualStyleBackColor = false;
            cancelBttn.Click += cancelBttn_Click;
            // 
            // saveBttn
            // 
            saveBttn.BackColor = Color.Cornsilk;
            saveBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBttn.ForeColor = Color.Black;
            saveBttn.Location = new Point(180, 481);
            saveBttn.Margin = new Padding(2);
            saveBttn.Name = "saveBttn";
            saveBttn.Size = new Size(171, 40);
            saveBttn.TabIndex = 50;
            saveBttn.Text = "Save Transaction";
            saveBttn.UseVisualStyleBackColor = false;
            saveBttn.Click += saveBttn_Click;
            // 
            // grpboxUserInfo
            // 
            grpboxUserInfo.BackColor = Color.Transparent;
            grpboxUserInfo.Controls.Add(ddlPaymentStatus);
            grpboxUserInfo.Controls.Add(ddlPaymentMethod);
            grpboxUserInfo.Controls.Add(dtpReturnDate);
            grpboxUserInfo.Controls.Add(dtpRentalStartDate);
            grpboxUserInfo.Controls.Add(txtRentalFee);
            grpboxUserInfo.Controls.Add(lblRentalFee);
            grpboxUserInfo.Controls.Add(txtRentalPeriod);
            grpboxUserInfo.Controls.Add(label2);
            grpboxUserInfo.Controls.Add(lblPaymentMethod);
            grpboxUserInfo.Controls.Add(lblPaymentStatus);
            grpboxUserInfo.Controls.Add(txtTransactionID);
            grpboxUserInfo.Controls.Add(lblTransactionID);
            grpboxUserInfo.Controls.Add(txtBookName);
            grpboxUserInfo.Controls.Add(txtCustomerName);
            grpboxUserInfo.Controls.Add(lblCustomerName);
            grpboxUserInfo.Controls.Add(lblRole);
            grpboxUserInfo.Controls.Add(lblBookName);
            grpboxUserInfo.Controls.Add(lblEmail);
            grpboxUserInfo.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpboxUserInfo.Location = new Point(12, 127);
            grpboxUserInfo.Name = "grpboxUserInfo";
            grpboxUserInfo.Size = new Size(949, 322);
            grpboxUserInfo.TabIndex = 49;
            grpboxUserInfo.TabStop = false;
            grpboxUserInfo.Text = "Transaction Info";
            // 
            // ddlPaymentStatus
            // 
            ddlPaymentStatus.FormattingEnabled = true;
            ddlPaymentStatus.Location = new Point(647, 203);
            ddlPaymentStatus.Name = "ddlPaymentStatus";
            ddlPaymentStatus.Size = new Size(295, 30);
            ddlPaymentStatus.TabIndex = 42;
            // 
            // ddlPaymentMethod
            // 
            ddlPaymentMethod.FormattingEnabled = true;
            ddlPaymentMethod.Location = new Point(647, 145);
            ddlPaymentMethod.Name = "ddlPaymentMethod";
            ddlPaymentMethod.Size = new Size(295, 30);
            ddlPaymentMethod.TabIndex = 41;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Font = new Font("Britannic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpReturnDate.Location = new Point(183, 262);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(295, 27);
            dtpReturnDate.TabIndex = 40;
            dtpReturnDate.ValueChanged += dtpReturnDate_ValueChanged;
            // 
            // dtpRentalStartDate
            // 
            dtpRentalStartDate.Font = new Font("Britannic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpRentalStartDate.Location = new Point(183, 204);
            dtpRentalStartDate.Name = "dtpRentalStartDate";
            dtpRentalStartDate.Size = new Size(295, 27);
            dtpRentalStartDate.TabIndex = 39;
            dtpRentalStartDate.ValueChanged += dtpRentalStartDate_ValueChanged;
            // 
            // txtRentalFee
            // 
            txtRentalFee.Location = new Point(647, 36);
            txtRentalFee.Name = "txtRentalFee";
            txtRentalFee.Size = new Size(295, 30);
            txtRentalFee.TabIndex = 38;
            // 
            // lblRentalFee
            // 
            lblRentalFee.AutoSize = true;
            lblRentalFee.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRentalFee.Location = new Point(484, 43);
            lblRentalFee.Name = "lblRentalFee";
            lblRentalFee.Size = new Size(108, 22);
            lblRentalFee.TabIndex = 37;
            lblRentalFee.Text = "Rental Fee:";
            // 
            // txtRentalPeriod
            // 
            txtRentalPeriod.Location = new Point(647, 89);
            txtRentalPeriod.Name = "txtRentalPeriod";
            txtRentalPeriod.Size = new Size(295, 30);
            txtRentalPeriod.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(484, 96);
            label2.Name = "label2";
            label2.Size = new Size(137, 22);
            label2.TabIndex = 31;
            label2.Text = "Rental Period:";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Location = new Point(484, 151);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(161, 22);
            lblPaymentMethod.TabIndex = 32;
            lblPaymentMethod.Text = "Payment Method:";
            // 
            // lblPaymentStatus
            // 
            lblPaymentStatus.AutoSize = true;
            lblPaymentStatus.Location = new Point(484, 209);
            lblPaymentStatus.Name = "lblPaymentStatus";
            lblPaymentStatus.Size = new Size(152, 22);
            lblPaymentStatus.TabIndex = 33;
            lblPaymentStatus.Text = "Payment Status:";
            // 
            // txtTransactionID
            // 
            txtTransactionID.Location = new Point(183, 36);
            txtTransactionID.Name = "txtTransactionID";
            txtTransactionID.ReadOnly = true;
            txtTransactionID.Size = new Size(295, 30);
            txtTransactionID.TabIndex = 30;
            // 
            // lblTransactionID
            // 
            lblTransactionID.AutoSize = true;
            lblTransactionID.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransactionID.Location = new Point(15, 43);
            lblTransactionID.Name = "lblTransactionID";
            lblTransactionID.Size = new Size(147, 22);
            lblTransactionID.TabIndex = 29;
            lblTransactionID.Text = "Transaction ID:";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(183, 144);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(295, 30);
            txtBookName.TabIndex = 27;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(183, 89);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(295, 30);
            txtCustomerName.TabIndex = 25;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(15, 96);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(156, 22);
            lblCustomerName.TabIndex = 21;
            lblCustomerName.Text = "Customer Name:";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(15, 267);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(122, 22);
            lblRole.TabIndex = 24;
            lblRole.Text = "Return Date:";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(15, 151);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(117, 22);
            lblBookName.TabIndex = 22;
            lblBookName.Text = "Book Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(15, 209);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(167, 22);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Rental Start Date:";
            // 
            // EditTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            ClientSize = new Size(982, 653);
            Controls.Add(cancelBttn);
            Controls.Add(saveBttn);
            Controls.Add(grpboxUserInfo);
            Controls.Add(pageTitle);
            Controls.Add(pictureBox1);
            Controls.Add(returnIcon);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            Name = "EditTransaction";
            Text = "EditTransaction";
            Load += EditTransaction_Load;
            ((System.ComponentModel.ISupportInitialize)returnIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpboxUserInfo.ResumeLayout(false);
            grpboxUserInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox returnIcon;
        private PictureBox exitIcon;
        private PictureBox homeIcon;
        private PictureBox userIcon;
        private PictureBox pictureBox1;
        private Label pageTitle;
        private Button cancelBttn;
        private Button saveBttn;
        private GroupBox grpboxUserInfo;
        private TextBox txtTransactionID;
        private Label lblTransactionID;
        private ComboBox ddlRole;
        private TextBox txtBookName;
        private TextBox txtCustomerName;
        private Label lblCustomerName;
        private Label lblRole;
        private Label lblBookName;
        private Label lblEmail;
        private TextBox txtRentalFee;
        private Label lblRentalFee;
        private TextBox txtRentalPeriod;
        private Label label2;
        private Label lblPaymentMethod;
        private Label lblPaymentStatus;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dtpRentalStartDate;
        private DateTimePicker dtpReturnDate;
        private ComboBox ddlPaymentStatus;
        private ComboBox ddlPaymentMethod;
    }
}