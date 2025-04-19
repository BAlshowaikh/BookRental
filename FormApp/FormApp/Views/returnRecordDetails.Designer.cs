namespace FormApp.Views
{
    partial class returnRecordDetails
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
            lblLateReturnFee = new Label();
            lblActualReturnDate = new Label();
            lblTotalCost = new Label();
            lblExpectedReturnDate = new Label();
            txtExpectedReturnDate = new TextBox();
            txtBookName = new TextBox();
            lblTransactionID = new Label();
            txtRecordID = new TextBox();
            lblRecordID = new Label();
            txtLateReturnFee = new TextBox();
            txtTotalCost = new TextBox();
            txtTransactionID = new TextBox();
            lblBookName = new Label();
            lblBookCondition = new Label();
            btnGenerate = new Button();
            btnCancel = new Button();
            ddlBookCondition = new ComboBox();
            dtpActualReturnDate = new DateTimePicker();
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
            returnIcon.TabIndex = 26;
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
            exitIcon.TabIndex = 25;
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
            homeIcon.TabIndex = 24;
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
            userIcon.TabIndex = 23;
            userIcon.TabStop = false;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.BackColor = Color.Transparent;
            lbltitle.Font = new Font("Tahoma", 26F, FontStyle.Bold);
            lbltitle.ForeColor = Color.Cornsilk;
            lbltitle.Location = new Point(174, 9);
            lbltitle.Margin = new Padding(2, 0, 2, 0);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(603, 63);
            lbltitle.TabIndex = 22;
            lbltitle.Text = "Return Record Details";
            // 
            // lblLateReturnFee
            // 
            lblLateReturnFee.AutoSize = true;
            lblLateReturnFee.BackColor = Color.Transparent;
            lblLateReturnFee.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLateReturnFee.ForeColor = Color.Black;
            lblLateReturnFee.Location = new Point(19, 467);
            lblLateReturnFee.Margin = new Padding(2, 0, 2, 0);
            lblLateReturnFee.Name = "lblLateReturnFee";
            lblLateReturnFee.Size = new Size(202, 29);
            lblLateReturnFee.TabIndex = 65;
            lblLateReturnFee.Text = "Late Return Fee";
            // 
            // lblActualReturnDate
            // 
            lblActualReturnDate.AutoSize = true;
            lblActualReturnDate.BackColor = Color.Transparent;
            lblActualReturnDate.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActualReturnDate.ForeColor = Color.Black;
            lblActualReturnDate.Location = new Point(503, 363);
            lblActualReturnDate.Margin = new Padding(2, 0, 2, 0);
            lblActualReturnDate.Name = "lblActualReturnDate";
            lblActualReturnDate.Size = new Size(203, 24);
            lblActualReturnDate.TabIndex = 64;
            lblActualReturnDate.Text = "Actual Return Date";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.BackColor = Color.Transparent;
            lblTotalCost.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCost.ForeColor = Color.Black;
            lblTotalCost.Location = new Point(542, 467);
            lblTotalCost.Margin = new Padding(2, 0, 2, 0);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(134, 29);
            lblTotalCost.TabIndex = 63;
            lblTotalCost.Text = "Total Cost";
            // 
            // lblExpectedReturnDate
            // 
            lblExpectedReturnDate.AutoSize = true;
            lblExpectedReturnDate.BackColor = Color.Transparent;
            lblExpectedReturnDate.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpectedReturnDate.ForeColor = Color.Black;
            lblExpectedReturnDate.Location = new Point(4, 364);
            lblExpectedReturnDate.Margin = new Padding(2, 0, 2, 0);
            lblExpectedReturnDate.Name = "lblExpectedReturnDate";
            lblExpectedReturnDate.Size = new Size(232, 24);
            lblExpectedReturnDate.TabIndex = 62;
            lblExpectedReturnDate.Text = "Expected Return Date";
            // 
            // txtExpectedReturnDate
            // 
            txtExpectedReturnDate.Location = new Point(240, 360);
            txtExpectedReturnDate.Margin = new Padding(2);
            txtExpectedReturnDate.Name = "txtExpectedReturnDate";
            txtExpectedReturnDate.ReadOnly = true;
            txtExpectedReturnDate.Size = new Size(250, 31);
            txtExpectedReturnDate.TabIndex = 60;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(240, 259);
            txtBookName.Margin = new Padding(2);
            txtBookName.Name = "txtBookName";
            txtBookName.ReadOnly = true;
            txtBookName.Size = new Size(250, 31);
            txtBookName.TabIndex = 59;
            // 
            // lblTransactionID
            // 
            lblTransactionID.AutoSize = true;
            lblTransactionID.BackColor = Color.Transparent;
            lblTransactionID.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactionID.ForeColor = Color.Black;
            lblTransactionID.Location = new Point(516, 149);
            lblTransactionID.Margin = new Padding(2, 0, 2, 0);
            lblTransactionID.Name = "lblTransactionID";
            lblTransactionID.Size = new Size(190, 29);
            lblTransactionID.TabIndex = 58;
            lblTransactionID.Text = "Transaction ID";
            // 
            // txtRecordID
            // 
            txtRecordID.Location = new Point(240, 150);
            txtRecordID.Margin = new Padding(2);
            txtRecordID.Name = "txtRecordID";
            txtRecordID.ReadOnly = true;
            txtRecordID.Size = new Size(250, 31);
            txtRecordID.TabIndex = 57;
            // 
            // lblRecordID
            // 
            lblRecordID.AutoSize = true;
            lblRecordID.BackColor = Color.Transparent;
            lblRecordID.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordID.ForeColor = Color.Black;
            lblRecordID.Location = new Point(19, 145);
            lblRecordID.Margin = new Padding(2, 0, 2, 0);
            lblRecordID.Name = "lblRecordID";
            lblRecordID.Size = new Size(134, 29);
            lblRecordID.TabIndex = 56;
            lblRecordID.Text = "Record ID";
            // 
            // txtLateReturnFee
            // 
            txtLateReturnFee.Location = new Point(240, 465);
            txtLateReturnFee.Margin = new Padding(2);
            txtLateReturnFee.Name = "txtLateReturnFee";
            txtLateReturnFee.Size = new Size(250, 31);
            txtLateReturnFee.TabIndex = 55;
            // 
            // txtTotalCost
            // 
            txtTotalCost.Location = new Point(710, 465);
            txtTotalCost.Margin = new Padding(2);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.ReadOnly = true;
            txtTotalCost.Size = new Size(250, 31);
            txtTotalCost.TabIndex = 54;
            // 
            // txtTransactionID
            // 
            txtTransactionID.Location = new Point(710, 149);
            txtTransactionID.Margin = new Padding(2);
            txtTransactionID.Name = "txtTransactionID";
            txtTransactionID.ReadOnly = true;
            txtTransactionID.Size = new Size(250, 31);
            txtTransactionID.TabIndex = 52;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.BackColor = Color.Transparent;
            lblBookName.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookName.ForeColor = Color.Black;
            lblBookName.Location = new Point(19, 259);
            lblBookName.Margin = new Padding(2, 0, 2, 0);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(150, 29);
            lblBookName.TabIndex = 51;
            lblBookName.Text = "Book Name";
            // 
            // lblBookCondition
            // 
            lblBookCondition.AutoSize = true;
            lblBookCondition.BackColor = Color.Transparent;
            lblBookCondition.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookCondition.ForeColor = Color.Black;
            lblBookCondition.Location = new Point(503, 258);
            lblBookCondition.Margin = new Padding(2, 0, 2, 0);
            lblBookCondition.Name = "lblBookCondition";
            lblBookCondition.Size = new Size(195, 29);
            lblBookCondition.TabIndex = 50;
            lblBookCondition.Text = "Book Condition";
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Cornsilk;
            btnGenerate.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.Black;
            btnGenerate.Location = new Point(290, 565);
            btnGenerate.Margin = new Padding(2);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(200, 50);
            btnGenerate.TabIndex = 66;
            btnGenerate.Text = "Generate Record";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(516, 565);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(200, 50);
            btnCancel.TabIndex = 67;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ddlBookCondition
            // 
            ddlBookCondition.FormattingEnabled = true;
            ddlBookCondition.Location = new Point(710, 255);
            ddlBookCondition.Margin = new Padding(4, 5, 4, 5);
            ddlBookCondition.Name = "ddlBookCondition";
            ddlBookCondition.Size = new Size(250, 33);
            ddlBookCondition.TabIndex = 68;
            // 
            // dtpActualReturnDate
            // 
            dtpActualReturnDate.Location = new Point(710, 359);
            dtpActualReturnDate.Margin = new Padding(4, 5, 4, 5);
            dtpActualReturnDate.Name = "dtpActualReturnDate";
            dtpActualReturnDate.Size = new Size(250, 31);
            dtpActualReturnDate.TabIndex = 69;
            // 
            // returnRecordDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(dtpActualReturnDate);
            Controls.Add(ddlBookCondition);
            Controls.Add(btnCancel);
            Controls.Add(btnGenerate);
            Controls.Add(lblLateReturnFee);
            Controls.Add(lblActualReturnDate);
            Controls.Add(lblTotalCost);
            Controls.Add(lblExpectedReturnDate);
            Controls.Add(txtExpectedReturnDate);
            Controls.Add(txtBookName);
            Controls.Add(lblTransactionID);
            Controls.Add(txtRecordID);
            Controls.Add(lblRecordID);
            Controls.Add(txtLateReturnFee);
            Controls.Add(txtTotalCost);
            Controls.Add(txtTransactionID);
            Controls.Add(lblBookName);
            Controls.Add(lblBookCondition);
            Controls.Add(returnIcon);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            Controls.Add(lbltitle);
            DoubleBuffered = true;
            Name = "returnRecordDetails";
            Text = "returnRecordDetails";
            Load += returnRecordDetails_Load;
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
        private Label lblLateReturnFee;
        private Label lblActualReturnDate;
        private Label lblTotalCost;
        private Label lblExpectedReturnDate;
        private TextBox txtExpectedReturnDate;
        private TextBox txtBookName;
        private Label lblTransactionID;
        private TextBox txtRecordID;
        private Label lblRecordID;
        private TextBox txtLateReturnFee;
        private TextBox txtTotalCost;
        private TextBox txtTransactionID;
        private Label lblBookName;
        private Label lblBookCondition;
        private Button btnGenerate;
        private Button btnCancel;
        private ComboBox ddlBookCondition;
        private DateTimePicker dtpActualReturnDate;
    }
}