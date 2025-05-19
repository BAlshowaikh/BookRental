namespace FormApp
{
    partial class Login
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
            Email = new Label();
            Password = new Label();
            txtUserEmail = new TextBox();
            txtPassword = new TextBox();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(412, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 63);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = Color.Transparent;
            Email.Font = new Font("Britannic Bold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Email.ForeColor = Color.Black;
            Email.Location = new Point(243, 183);
            Email.Margin = new Padding(2, 0, 2, 0);
            Email.Name = "Email";
            Email.Size = new Size(88, 31);
            Email.TabIndex = 2;
            Email.Text = "Email";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.Transparent;
            Password.Font = new Font("Britannic Bold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Password.ForeColor = Color.Black;
            Password.Location = new Point(243, 326);
            Password.Margin = new Padding(2, 0, 2, 0);
            Password.Name = "Password";
            Password.Size = new Size(140, 31);
            Password.TabIndex = 3;
            Password.Text = "Password";
            // 
            // txtUserEmail
            // 
            txtUserEmail.Location = new Point(252, 220);
            txtUserEmail.Margin = new Padding(2);
            txtUserEmail.Name = "txtUserEmail";
            txtUserEmail.Size = new Size(500, 31);
            txtUserEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(252, 363);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(500, 31);
            txtPassword.TabIndex = 5;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Cornsilk;
            loginBtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.Location = new Point(400, 432);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(200, 50);
            loginBtn.TabIndex = 8;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(loginBtn);
            Controls.Add(txtPassword);
            Controls.Add(txtUserEmail);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Email;
        private Label Password;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button loginBtn;
        private TextBox txtUserEmail;
        private TextBox txtPassword;
    }
}