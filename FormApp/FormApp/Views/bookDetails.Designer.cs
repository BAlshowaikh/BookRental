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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookDetails));
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 26F, FontStyle.Bold);
            label1.ForeColor = Color.LightSteelBlue;
            label1.Location = new Point(415, 9);
            label1.Name = "label1";
            label1.Size = new Size(355, 63);
            label1.TabIndex = 1;
            label1.Text = "Book Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(219, 128);
            label2.Name = "label2";
            label2.Size = new Size(88, 34);
            label2.TabIndex = 2;
            label2.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(219, 220);
            label3.Name = "label3";
            label3.Size = new Size(77, 34);
            label3.TabIndex = 3;
            label3.Text = "Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(219, 320);
            label4.Name = "label4";
            label4.Size = new Size(227, 34);
            label4.TabIndex = 4;
            label4.Text = "Published Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(219, 444);
            label5.Name = "label5";
            label5.Size = new Size(111, 34);
            label5.TabIndex = 5;
            label5.Text = "Author";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(514, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(374, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(514, 220);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(374, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(514, 323);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(374, 31);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(514, 444);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(374, 31);
            textBox4.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(168, 551);
            button1.Name = "button1";
            button1.Size = new Size(162, 51);
            button1.TabIndex = 10;
            button1.Text = "Rent";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(514, 551);
            button2.Name = "button2";
            button2.Size = new Size(162, 51);
            button2.TabIndex = 11;
            button2.Text = "Feedback";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(835, 551);
            button3.Name = "button3";
            button3.Size = new Size(162, 51);
            button3.TabIndex = 12;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1060, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 75);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // bookDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1140, 680);
            Controls.Add(pictureBox1);
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
            Name = "bookDetails";
            Text = "bookDetails";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}