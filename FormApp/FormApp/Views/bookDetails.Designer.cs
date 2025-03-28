namespace FormApp
{
    partial class bookDetails
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
            label1 = new Label();
            btnViewFeedback = new Button();
            returnIcon = new PictureBox();
            exitIcon = new PictureBox();
            homeIcon = new PictureBox();
            userIcon = new PictureBox();
            txtPublishDate = new TextBox();
            lblAuthorName = new Label();
            txtBookCategory = new TextBox();
            lblPublishDate = new Label();
            txtBookDesc = new TextBox();
            lblBookDesc = new Label();
            txtBookName = new TextBox();
            lblBookName = new Label();
            txtRentalPrice = new TextBox();
            txtBookId = new TextBox();
            lblBookID = new Label();
            lblBookCategory = new Label();
            lblRentalPrice = new Label();
            txtAuthorName = new TextBox();
            lblBookCondition = new Label();
            txtBookCondition = new TextBox();
            lblAvailability = new Label();
            txtAvailability = new TextBox();
            lblISBN = new Label();
            txtBookISBN = new TextBox();
            ((System.ComponentModel.ISupportInitialize)returnIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 26F, FontStyle.Bold);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(296, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(355, 63);
            label1.TabIndex = 1;
            label1.Text = "Book Details";
            // 
            // btnViewFeedback
            // 
            btnViewFeedback.BackColor = Color.Cornsilk;
            btnViewFeedback.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewFeedback.ForeColor = Color.Black;
            btnViewFeedback.Location = new Point(396, 559);
            btnViewFeedback.Margin = new Padding(2);
            btnViewFeedback.Name = "btnViewFeedback";
            btnViewFeedback.Size = new Size(200, 50);
            btnViewFeedback.TabIndex = 11;
            btnViewFeedback.Text = "View Feedback";
            btnViewFeedback.UseVisualStyleBackColor = false;
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
            returnIcon.TabIndex = 16;
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
            exitIcon.TabIndex = 15;
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
            homeIcon.TabIndex = 14;
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
            userIcon.TabIndex = 13;
            userIcon.TabStop = false;
            // 
            // txtPublishDate
            // 
            txtPublishDate.Location = new Point(240, 455);
            txtPublishDate.Margin = new Padding(2);
            txtPublishDate.Name = "txtPublishDate";
            txtPublishDate.Size = new Size(250, 31);
            txtPublishDate.TabIndex = 9;
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
            lblAuthorName.TabIndex = 5;
            lblAuthorName.Text = "Author name";
            // 
            // txtBookCategory
            // 
            txtBookCategory.Location = new Point(710, 293);
            txtBookCategory.Margin = new Padding(2);
            txtBookCategory.Name = "txtBookCategory";
            txtBookCategory.Size = new Size(250, 31);
            txtBookCategory.TabIndex = 8;
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
            lblPublishDate.TabIndex = 4;
            lblPublishDate.Text = "Published Date";
            // 
            // txtBookDesc
            // 
            txtBookDesc.Location = new Point(240, 375);
            txtBookDesc.Margin = new Padding(2);
            txtBookDesc.Name = "txtBookDesc";
            txtBookDesc.Size = new Size(250, 31);
            txtBookDesc.TabIndex = 18;
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
            lblBookDesc.TabIndex = 17;
            lblBookDesc.Text = "Book Description ";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(240, 218);
            txtBookName.Margin = new Padding(2);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(250, 31);
            txtBookName.TabIndex = 7;
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
            lblBookName.TabIndex = 3;
            lblBookName.Text = "Book Name";
            lblBookName.Click += label3_Click;
            // 
            // txtRentalPrice
            // 
            txtRentalPrice.Location = new Point(710, 136);
            txtRentalPrice.Margin = new Padding(2);
            txtRentalPrice.Name = "txtRentalPrice";
            txtRentalPrice.Size = new Size(250, 31);
            txtRentalPrice.TabIndex = 6;
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(240, 137);
            txtBookId.Margin = new Padding(2);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(250, 31);
            txtBookId.TabIndex = 20;
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
            lblBookID.TabIndex = 19;
            lblBookID.Text = "Book ID";
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
            lblBookCategory.TabIndex = 21;
            lblBookCategory.Text = "Book Category ";
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
            lblRentalPrice.TabIndex = 22;
            lblRentalPrice.Text = "Rental Price";
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(710, 215);
            txtAuthorName.Margin = new Padding(2);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(250, 31);
            txtAuthorName.TabIndex = 23;
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
            lblBookCondition.TabIndex = 24;
            lblBookCondition.Text = "Book Condition";
            // 
            // txtBookCondition
            // 
            txtBookCondition.Location = new Point(710, 375);
            txtBookCondition.Margin = new Padding(2);
            txtBookCondition.Name = "txtBookCondition";
            txtBookCondition.Size = new Size(250, 31);
            txtBookCondition.TabIndex = 25;
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
            lblAvailability.TabIndex = 26;
            lblAvailability.Text = "Availability";
            // 
            // txtAvailability
            // 
            txtAvailability.Location = new Point(710, 456);
            txtAvailability.Margin = new Padding(2);
            txtAvailability.Name = "txtAvailability";
            txtAvailability.Size = new Size(250, 31);
            txtAvailability.TabIndex = 27;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.BackColor = Color.Transparent;
            lblISBN.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(19, 287);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(88, 34);
            lblISBN.TabIndex = 28;
            lblISBN.Text = "ISBN";
            // 
            // txtBookISBN
            // 
            txtBookISBN.Location = new Point(240, 290);
            txtBookISBN.Margin = new Padding(2);
            txtBookISBN.Name = "txtBookISBN";
            txtBookISBN.Size = new Size(250, 31);
            txtBookISBN.TabIndex = 29;
            // 
            // bookDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(txtBookISBN);
            Controls.Add(lblISBN);
            Controls.Add(txtAvailability);
            Controls.Add(lblAvailability);
            Controls.Add(txtBookCondition);
            Controls.Add(lblBookCondition);
            Controls.Add(txtAuthorName);
            Controls.Add(lblRentalPrice);
            Controls.Add(lblBookCategory);
            Controls.Add(txtBookId);
            Controls.Add(lblBookID);
            Controls.Add(txtBookDesc);
            Controls.Add(lblBookDesc);
            Controls.Add(returnIcon);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            Controls.Add(btnViewFeedback);
            Controls.Add(txtPublishDate);
            Controls.Add(txtBookCategory);
            Controls.Add(txtBookName);
            Controls.Add(txtRentalPrice);
            Controls.Add(lblAuthorName);
            Controls.Add(lblPublishDate);
            Controls.Add(lblBookName);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            Margin = new Padding(2);
            Name = "bookDetails";
            Text = "bookDetails";
            ((System.ComponentModel.ISupportInitialize)returnIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnViewFeedback;
        private PictureBox returnIcon;
        private PictureBox exitIcon;
        private PictureBox homeIcon;
        private PictureBox userIcon;
        private TextBox txtPublishDate;
        private Label lblAuthorName;
        private TextBox txtBookCategory;
        private Label lblPublishDate;
        private TextBox txtBookDesc;
        private Label lblBookDesc;
        private TextBox txtBookName;
        private Label lblBookName;
        private TextBox txtRentalPrice;
        private TextBox txtBookId;
        private Label lblBookID;
        private Label lblBookCategory;
        private Label lblRentalPrice;
        private TextBox txtAuthorName;
        private Label lblBookCondition;
        private TextBox txtBookCondition;
        private Label lblAvailability;
        private TextBox txtAvailability;
        private Label lblISBN;
        private TextBox txtBookISBN;
    }
}