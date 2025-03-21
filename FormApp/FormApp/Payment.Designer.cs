namespace FormApp
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Tahoma", 26F, FontStyle.Bold);
            label1.ForeColor = Color.LightSteelBlue;
            label1.Location = new Point(451, 24);
            label1.Name = "label1";
            label1.Size = new Size(258, 63);
            label1.TabIndex = 2;
            label1.Text = "Payment";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(42, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1028, 150);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(29, 63);
            label2.Name = "label2";
            label2.Size = new Size(85, 34);
            label2.TabIndex = 3;
            label2.Text = "Book";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(346, 31);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(527, 70);
            label3.Name = "label3";
            label3.Size = new Size(85, 34);
            label3.TabIndex = 5;
            label3.Text = "Price";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(618, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(346, 31);
            textBox2.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(42, 298);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1028, 267);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(29, 43);
            label4.Name = "label4";
            label4.Size = new Size(333, 34);
            label4.TabIndex = 7;
            label4.Text = "Select a payment method";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(368, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(390, 33);
            comboBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(361, 596);
            button1.Name = "button1";
            button1.Size = new Size(162, 51);
            button1.TabIndex = 9;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(613, 596);
            button3.Name = "button3";
            button3.Size = new Size(162, 51);
            button3.TabIndex = 13;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1045, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 75);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1140, 680);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Payment";
            Text = "Payment";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Label label4;
        private Button button1;
        private Button button3;
        private PictureBox pictureBox1;
    }
}