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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            returnIcon = new PictureBox();
            exitIcon = new PictureBox();
            homeIcon = new PictureBox();
            userIcon = new PictureBox();
            textBox5 = new TextBox();
            label6 = new Label();
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
            label1.Name = "label1";
            label1.Size = new Size(355, 63);
            label1.TabIndex = 1;
            label1.Text = "Book Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(155, 126);
            label2.Name = "label2";
            label2.Size = new Size(88, 34);
            label2.TabIndex = 2;
            label2.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(155, 188);
            label3.Name = "label3";
            label3.Size = new Size(176, 34);
            label3.TabIndex = 3;
            label3.Text = "Book Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(155, 325);
            label4.Name = "label4";
            label4.Size = new Size(227, 34);
            label4.TabIndex = 4;
            label4.Text = "Published Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(155, 397);
            label5.Name = "label5";
            label5.Size = new Size(111, 34);
            label5.TabIndex = 5;
            label5.Text = "Author";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(452, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(374, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(452, 188);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(374, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(452, 328);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(374, 31);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(452, 397);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(374, 31);
            textBox4.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Cornsilk;
            button1.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(110, 559);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 10;
            button1.Text = "Rent";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Cornsilk;
            button2.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(396, 559);
            button2.Name = "button2";
            button2.Size = new Size(200, 50);
            button2.TabIndex = 11;
            button2.Text = "View Feedback";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(688, 559);
            button3.Name = "button3";
            button3.Size = new Size(200, 50);
            button3.TabIndex = 12;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            // 
            // returnIcon
            // 
            returnIcon.BackColor = Color.Transparent;
            returnIcon.Image = Properties.Resources._return;
            returnIcon.Location = new Point(766, 12);
            returnIcon.Name = "returnIcon";
            returnIcon.Size = new Size(60, 60);
            returnIcon.SizeMode = PictureBoxSizeMode.Zoom;
            returnIcon.TabIndex = 16;
            returnIcon.TabStop = false;
            // 
            // exitIcon
            // 
            exitIcon.BackColor = Color.Transparent;
            exitIcon.Image = Properties.Resources.logout;
            exitIcon.Location = new Point(898, 12);
            exitIcon.Name = "exitIcon";
            exitIcon.Size = new Size(60, 60);
            exitIcon.SizeMode = PictureBoxSizeMode.Zoom;
            exitIcon.TabIndex = 15;
            exitIcon.TabStop = false;
            // 
            // homeIcon
            // 
            homeIcon.BackColor = Color.Transparent;
            homeIcon.Image = Properties.Resources.home__1_;
            homeIcon.Location = new Point(832, 12);
            homeIcon.Name = "homeIcon";
            homeIcon.Size = new Size(60, 60);
            homeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            homeIcon.TabIndex = 14;
            homeIcon.TabStop = false;
            // 
            // userIcon
            // 
            userIcon.BackColor = Color.Transparent;
            userIcon.Image = Properties.Resources.user;
            userIcon.Location = new Point(19, 12);
            userIcon.Name = "userIcon";
            userIcon.Size = new Size(60, 60);
            userIcon.SizeMode = PictureBoxSizeMode.Zoom;
            userIcon.TabIndex = 13;
            userIcon.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(452, 257);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(374, 31);
            textBox5.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(155, 257);
            label6.Name = "label6";
            label6.Size = new Size(221, 34);
            label6.TabIndex = 17;
            label6.Text = "Book Category";
            // 
            // bookDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(returnIcon);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = Color.Black;
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox returnIcon;
        private PictureBox exitIcon;
        private PictureBox homeIcon;
        private PictureBox userIcon;
        private TextBox textBox5;
        private Label label6;
    }
}