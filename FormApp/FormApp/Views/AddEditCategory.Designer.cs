namespace FormApp.Views
{
    partial class AddEditCategory
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
            deleteBttn = new Button();
            addBttn = new Button();
            grpboxCategoryInfo = new GroupBox();
            txtCategoryID = new TextBox();
            lblCategoryID = new Label();
            txtCategoryName = new TextBox();
            lblCategoryName = new Label();
            returnIcon = new PictureBox();
            exitIcon = new PictureBox();
            homeIcon = new PictureBox();
            userIcon = new PictureBox();
            pageTitle = new Label();
            grpboxCategoryInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)returnIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            SuspendLayout();
            // 
            // deleteBttn
            // 
            deleteBttn.BackColor = Color.IndianRed;
            deleteBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBttn.ForeColor = Color.White;
            deleteBttn.Location = new Point(499, 446);
            deleteBttn.Margin = new Padding(2);
            deleteBttn.Name = "deleteBttn";
            deleteBttn.Size = new Size(200, 50);
            deleteBttn.TabIndex = 34;
            deleteBttn.Text = "Cancel";
            deleteBttn.UseVisualStyleBackColor = false;
            deleteBttn.Click += deleteBttn_Click;
            // 
            // addBttn
            // 
            addBttn.BackColor = Color.Cornsilk;
            addBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBttn.ForeColor = Color.Black;
            addBttn.Location = new Point(266, 446);
            addBttn.Margin = new Padding(2);
            addBttn.Name = "addBttn";
            addBttn.Size = new Size(200, 50);
            addBttn.TabIndex = 33;
            addBttn.Text = "Save Category";
            addBttn.UseVisualStyleBackColor = false;
            addBttn.Click += addBttn_Click;
            // 
            // grpboxCategoryInfo
            // 
            grpboxCategoryInfo.BackColor = Color.Transparent;
            grpboxCategoryInfo.Controls.Add(txtCategoryID);
            grpboxCategoryInfo.Controls.Add(lblCategoryID);
            grpboxCategoryInfo.Controls.Add(txtCategoryName);
            grpboxCategoryInfo.Controls.Add(lblCategoryName);
            grpboxCategoryInfo.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpboxCategoryInfo.Location = new Point(180, 137);
            grpboxCategoryInfo.Name = "grpboxCategoryInfo";
            grpboxCategoryInfo.Size = new Size(596, 281);
            grpboxCategoryInfo.TabIndex = 32;
            grpboxCategoryInfo.TabStop = false;
            grpboxCategoryInfo.Text = "Category Info";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(272, 93);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(261, 34);
            txtCategoryID.TabIndex = 30;
            // 
            // lblCategoryID
            // 
            lblCategoryID.AutoSize = true;
            lblCategoryID.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoryID.Location = new Point(50, 100);
            lblCategoryID.Name = "lblCategoryID";
            lblCategoryID.Size = new Size(143, 27);
            lblCategoryID.TabIndex = 29;
            lblCategoryID.Text = "Category ID:";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(272, 162);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(261, 34);
            txtCategoryName.TabIndex = 25;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoryName.Location = new Point(50, 169);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(179, 27);
            lblCategoryName.TabIndex = 21;
            lblCategoryName.Text = "Category Name:";
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
            returnIcon.TabIndex = 31;
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
            exitIcon.TabIndex = 30;
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
            homeIcon.TabIndex = 29;
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
            // 
            // pageTitle
            // 
            pageTitle.AutoSize = true;
            pageTitle.BackColor = Color.Transparent;
            pageTitle.Font = new Font("Tahoma", 26F, FontStyle.Bold);
            pageTitle.ForeColor = Color.Cornsilk;
            pageTitle.Location = new Point(218, 12);
            pageTitle.Margin = new Padding(2, 0, 2, 0);
            pageTitle.Name = "pageTitle";
            pageTitle.Size = new Size(514, 63);
            pageTitle.TabIndex = 47;
            pageTitle.Text = "Add/Edit Category";
            // 
            // AddEditCategory
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            ClientSize = new Size(978, 644);
            Controls.Add(pageTitle);
            Controls.Add(deleteBttn);
            Controls.Add(addBttn);
            Controls.Add(grpboxCategoryInfo);
            Controls.Add(returnIcon);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddEditCategory";
            Text = "AddEditCategory";
            Load += AddEditCategory_Load;
            grpboxCategoryInfo.ResumeLayout(false);
            grpboxCategoryInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)returnIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteBttn;
        private Button addBttn;
        private GroupBox grpboxCategoryInfo;
        private TextBox txtCategoryID;
        private Label lblCategoryID;
        private TextBox txtCategoryName;
        private Label lblCategoryName;
        private PictureBox returnIcon;
        private PictureBox exitIcon;
        private PictureBox homeIcon;
        private PictureBox userIcon;
        private Label pageTitle;
    }
}