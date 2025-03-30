namespace FormApp.Views
{
    partial class profile
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
            label2 = new Label();
            firstNameTxt = new TextBox();
            label3 = new Label();
            lastNameTxt = new TextBox();
            label4 = new Label();
            emailTxt = new TextBox();
            saveBtn = new Button();
            cancelBtn = new Button();
            returnIcon = new PictureBox();
            homeIcon = new PictureBox();
            exitIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)returnIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 26F, FontStyle.Bold);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(396, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 63);
            label1.TabIndex = 1;
            label1.Text = "Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(185, 125);
            label2.Name = "label2";
            label2.Size = new Size(133, 27);
            label2.TabIndex = 2;
            label2.Text = "First Name:";
            // 
            // firstNameTxt
            // 
            firstNameTxt.Location = new Point(324, 125);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(399, 31);
            firstNameTxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(189, 226);
            label3.Name = "label3";
            label3.Size = new Size(129, 27);
            label3.TabIndex = 4;
            label3.Text = "Last Name:";
            // 
            // lastNameTxt
            // 
            lastNameTxt.Location = new Point(324, 226);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(399, 31);
            lastNameTxt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(185, 318);
            label4.Name = "label4";
            label4.Size = new Size(79, 27);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(324, 314);
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(399, 31);
            emailTxt.TabIndex = 7;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Cornsilk;
            saveBtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.Location = new Point(242, 413);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(200, 50);
            saveBtn.TabIndex = 9;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.IndianRed;
            cancelBtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(523, 413);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(200, 50);
            cancelBtn.TabIndex = 10;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // returnIcon
            // 
            returnIcon.BackColor = Color.Transparent;
            returnIcon.Image = Properties.Resources._return;
            returnIcon.Location = new Point(830, 12);
            returnIcon.Name = "returnIcon";
            returnIcon.Size = new Size(40, 40);
            returnIcon.SizeMode = PictureBoxSizeMode.Zoom;
            returnIcon.TabIndex = 11;
            returnIcon.TabStop = false;
            // 
            // homeIcon
            // 
            homeIcon.BackColor = Color.Transparent;
            homeIcon.Image = Properties.Resources.home__2_;
            homeIcon.Location = new Point(880, 12);
            homeIcon.Name = "homeIcon";
            homeIcon.Size = new Size(40, 40);
            homeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            homeIcon.TabIndex = 12;
            homeIcon.TabStop = false;
            homeIcon.Click += homeIcon_Click;
            // 
            // exitIcon
            // 
            exitIcon.BackColor = Color.Transparent;
            exitIcon.Image = Properties.Resources.exit_icon;
            exitIcon.Location = new Point(930, 12);
            exitIcon.Name = "exitIcon";
            exitIcon.Size = new Size(40, 40);
            exitIcon.SizeMode = PictureBoxSizeMode.Zoom;
            exitIcon.TabIndex = 13;
            exitIcon.TabStop = false;
            exitIcon.Click += exitIcon_Click;
            // 
            // profile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            ClientSize = new Size(978, 644);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(returnIcon);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(emailTxt);
            Controls.Add(label4);
            Controls.Add(lastNameTxt);
            Controls.Add(label3);
            Controls.Add(firstNameTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            HelpButton = true;
            Name = "profile";
            Text = "profile";
            Load += profile_Load;
            ((System.ComponentModel.ISupportInitialize)returnIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Button SaveBtn;
        private Button button1;
        private PictureBox returnIcon;
        private PictureBox homeIcon;
        private PictureBox exitIcon;
        private TextBox firstNameTxt;
        private TextBox lastNameTxt;
        private TextBox emailTxt;
        private Button saveBtn;
        private Button cancelBtn;
    }
}