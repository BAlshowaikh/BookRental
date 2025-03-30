namespace FormApp.Views
{
    partial class AddEditBook
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
            userIcon = new PictureBox();
            returnIcon = new PictureBox();
            homeIcon = new PictureBox();
            exitIcon = new PictureBox();
            txtBookId = new TextBox();
            lblBookID = new Label();
            txtBookName = new TextBox();
            lblBookName = new Label();
            txtBookISBN = new TextBox();
            lblISBN = new Label();
            txtBookDesc = new TextBox();
            lblBookDesc = new Label();
            lblPublishDate = new Label();
            lblRentalPrice = new Label();
            txtRentalPrice = new TextBox();
            lblAuthorName = new Label();
            lblBookCategory = new Label();
            lblBookCondition = new Label();
            lblAvailability = new Label();
            pageTitle = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            dtpPublishedDate = new DateTimePicker();
            ddlAuthorName = new ComboBox();
            ddlBookCategory = new ComboBox();
            ddlBookCondition = new ComboBox();
            ddlAvailability = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)returnIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            SuspendLayout();
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
            userIcon.TabIndex = 14;
            userIcon.TabStop = false;
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
            returnIcon.TabIndex = 17;
            returnIcon.TabStop = false;
            returnIcon.Click += returnIcon_Click;
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
            homeIcon.TabIndex = 18;
            homeIcon.TabStop = false;
            homeIcon.Click += homeIcon_Click;
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
            exitIcon.TabIndex = 19;
            exitIcon.TabStop = false;
            exitIcon.Click += exitIcon_Click;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(240, 137);
            txtBookId.Margin = new Padding(2);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(250, 31);
            txtBookId.TabIndex = 22;
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.BackColor = Color.Transparent;
            lblBookID.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookID.ForeColor = Color.Black;
            lblBookID.Location = new Point(19, 132);
            lblBookID.Margin = new Padding(2, 0, 2, 0);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(110, 29);
            lblBookID.TabIndex = 21;
            lblBookID.Text = "Book ID";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(240, 218);
            txtBookName.Margin = new Padding(2);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(250, 31);
            txtBookName.TabIndex = 24;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.BackColor = Color.Transparent;
            lblBookName.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookName.ForeColor = Color.Black;
            lblBookName.Location = new Point(19, 214);
            lblBookName.Margin = new Padding(2, 0, 2, 0);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(150, 29);
            lblBookName.TabIndex = 23;
            lblBookName.Text = "Book Name";
            // 
            // txtBookISBN
            // 
            txtBookISBN.Location = new Point(240, 290);
            txtBookISBN.Margin = new Padding(2);
            txtBookISBN.Name = "txtBookISBN";
            txtBookISBN.Size = new Size(250, 31);
            txtBookISBN.TabIndex = 31;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.BackColor = Color.Transparent;
            lblISBN.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(19, 287);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(88, 34);
            lblISBN.TabIndex = 30;
            lblISBN.Text = "ISBN";
            // 
            // txtBookDesc
            // 
            txtBookDesc.Location = new Point(240, 375);
            txtBookDesc.Margin = new Padding(2);
            txtBookDesc.Name = "txtBookDesc";
            txtBookDesc.Size = new Size(250, 31);
            txtBookDesc.TabIndex = 33;
            // 
            // lblBookDesc
            // 
            lblBookDesc.AutoSize = true;
            lblBookDesc.BackColor = Color.Transparent;
            lblBookDesc.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookDesc.ForeColor = Color.Black;
            lblBookDesc.Location = new Point(19, 377);
            lblBookDesc.Margin = new Padding(2, 0, 2, 0);
            lblBookDesc.Name = "lblBookDesc";
            lblBookDesc.Size = new Size(223, 29);
            lblBookDesc.TabIndex = 32;
            lblBookDesc.Text = "Book Description ";
            // 
            // lblPublishDate
            // 
            lblPublishDate.AutoSize = true;
            lblPublishDate.BackColor = Color.Transparent;
            lblPublishDate.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPublishDate.ForeColor = Color.Black;
            lblPublishDate.Location = new Point(19, 455);
            lblPublishDate.Margin = new Padding(2, 0, 2, 0);
            lblPublishDate.Name = "lblPublishDate";
            lblPublishDate.Size = new Size(192, 29);
            lblPublishDate.TabIndex = 34;
            lblPublishDate.Text = "Published Date";
            // 
            // lblRentalPrice
            // 
            lblRentalPrice.AutoSize = true;
            lblRentalPrice.BackColor = Color.Transparent;
            lblRentalPrice.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentalPrice.ForeColor = Color.Black;
            lblRentalPrice.Location = new Point(540, 136);
            lblRentalPrice.Margin = new Padding(2, 0, 2, 0);
            lblRentalPrice.Name = "lblRentalPrice";
            lblRentalPrice.Size = new Size(157, 29);
            lblRentalPrice.TabIndex = 37;
            lblRentalPrice.Text = "Rental Price";
            // 
            // txtRentalPrice
            // 
            txtRentalPrice.Location = new Point(710, 136);
            txtRentalPrice.Margin = new Padding(2);
            txtRentalPrice.Name = "txtRentalPrice";
            txtRentalPrice.Size = new Size(250, 31);
            txtRentalPrice.TabIndex = 36;
            // 
            // lblAuthorName
            // 
            lblAuthorName.AutoSize = true;
            lblAuthorName.BackColor = Color.Transparent;
            lblAuthorName.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthorName.ForeColor = Color.Black;
            lblAuthorName.Location = new Point(540, 217);
            lblAuthorName.Margin = new Padding(2, 0, 2, 0);
            lblAuthorName.Name = "lblAuthorName";
            lblAuthorName.Size = new Size(167, 29);
            lblAuthorName.TabIndex = 38;
            lblAuthorName.Text = "Author name";
            // 
            // lblBookCategory
            // 
            lblBookCategory.AutoSize = true;
            lblBookCategory.BackColor = Color.Transparent;
            lblBookCategory.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookCategory.ForeColor = Color.Black;
            lblBookCategory.Location = new Point(540, 297);
            lblBookCategory.Margin = new Padding(2, 0, 2, 0);
            lblBookCategory.Name = "lblBookCategory";
            lblBookCategory.Size = new Size(163, 24);
            lblBookCategory.TabIndex = 41;
            lblBookCategory.Text = "Book Category ";
            // 
            // lblBookCondition
            // 
            lblBookCondition.AutoSize = true;
            lblBookCondition.BackColor = Color.Transparent;
            lblBookCondition.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookCondition.ForeColor = Color.Black;
            lblBookCondition.Location = new Point(538, 381);
            lblBookCondition.Margin = new Padding(2, 0, 2, 0);
            lblBookCondition.Name = "lblBookCondition";
            lblBookCondition.Size = new Size(162, 24);
            lblBookCondition.TabIndex = 42;
            lblBookCondition.Text = "Book Condition";
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.BackColor = Color.Transparent;
            lblAvailability.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailability.ForeColor = Color.Black;
            lblAvailability.Location = new Point(540, 455);
            lblAvailability.Margin = new Padding(2, 0, 2, 0);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(145, 29);
            lblAvailability.TabIndex = 44;
            lblAvailability.Text = "Availability";
            // 
            // pageTitle
            // 
            pageTitle.AutoSize = true;
            pageTitle.BackColor = Color.Transparent;
            pageTitle.Font = new Font("Tahoma", 26F, FontStyle.Bold);
            pageTitle.ForeColor = Color.Cornsilk;
            pageTitle.Location = new Point(289, 9);
            pageTitle.Margin = new Padding(2, 0, 2, 0);
            pageTitle.Name = "pageTitle";
            pageTitle.Size = new Size(408, 63);
            pageTitle.TabIndex = 46;
            pageTitle.Text = "Add/Edit Book";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Cornsilk;
            btnSave.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(291, 557);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 50);
            btnSave.TabIndex = 47;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.IndianRed;
            btnCancel.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(526, 557);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(200, 50);
            btnCancel.TabIndex = 48;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtpPublishedDate
            // 
            dtpPublishedDate.Location = new Point(240, 456);
            dtpPublishedDate.Name = "dtpPublishedDate";
            dtpPublishedDate.Size = new Size(250, 31);
            dtpPublishedDate.TabIndex = 49;
            // 
            // ddlAuthorName
            // 
            ddlAuthorName.FormattingEnabled = true;
            ddlAuthorName.Location = new Point(710, 213);
            ddlAuthorName.Name = "ddlAuthorName";
            ddlAuthorName.Size = new Size(250, 33);
            ddlAuthorName.TabIndex = 50;
            // 
            // ddlBookCategory
            // 
            ddlBookCategory.FormattingEnabled = true;
            ddlBookCategory.Location = new Point(713, 292);
            ddlBookCategory.Name = "ddlBookCategory";
            ddlBookCategory.Size = new Size(250, 33);
            ddlBookCategory.TabIndex = 51;
            // 
            // ddlBookCondition
            // 
            ddlBookCondition.FormattingEnabled = true;
            ddlBookCondition.Location = new Point(710, 375);
            ddlBookCondition.Name = "ddlBookCondition";
            ddlBookCondition.Size = new Size(250, 33);
            ddlBookCondition.TabIndex = 52;
            // 
            // ddlAvailability
            // 
            ddlAvailability.FormattingEnabled = true;
            ddlAvailability.Location = new Point(710, 455);
            ddlAvailability.Name = "ddlAvailability";
            ddlAvailability.Size = new Size(250, 33);
            ddlAvailability.TabIndex = 53;
            // 
            // AddEditBook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            ClientSize = new Size(978, 644);
            Controls.Add(ddlAvailability);
            Controls.Add(ddlBookCondition);
            Controls.Add(ddlBookCategory);
            Controls.Add(ddlAuthorName);
            Controls.Add(dtpPublishedDate);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(pageTitle);
            Controls.Add(lblAvailability);
            Controls.Add(lblBookCondition);
            Controls.Add(lblBookCategory);
            Controls.Add(lblAuthorName);
            Controls.Add(lblRentalPrice);
            Controls.Add(txtRentalPrice);
            Controls.Add(lblPublishDate);
            Controls.Add(txtBookDesc);
            Controls.Add(lblBookDesc);
            Controls.Add(txtBookISBN);
            Controls.Add(lblISBN);
            Controls.Add(txtBookName);
            Controls.Add(lblBookName);
            Controls.Add(txtBookId);
            Controls.Add(lblBookID);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(returnIcon);
            Controls.Add(userIcon);
            Name = "AddEditBook";
            Text = "Add/Edit Book Page";
            Load += AddEditBook_Load;
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)returnIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox userIcon;
        private PictureBox returnIcon;
        private PictureBox homeIcon;
        private PictureBox exitIcon;
        private TextBox txtBookId;
        private Label lblBookID;
        private TextBox txtBookName;
        private Label lblBookName;
        private TextBox txtBookISBN;
        private Label lblISBN;
        private TextBox txtBookDesc;
        private Label lblBookDesc;
        private Label lblPublishDate;
        private Label lblRentalPrice;
        private TextBox txtRentalPrice;
        private Label lblAuthorName;
        private Label lblBookCategory;
        private Label lblBookCondition;
        private Label lblAvailability;
        private Label pageTitle;
        private Button btnSave;
        private Button btnCancel;
        private DateTimePicker dtpPublishedDate;
        private ComboBox ddlAuthorName;
        private ComboBox ddlBookCategory;
        private ComboBox ddlBookCondition;
        private ComboBox ddlAvailability;
    }
}