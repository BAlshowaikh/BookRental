namespace FormApp
{
    partial class bookList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookList));
            groupBox1 = new GroupBox();
            button2 = new Button();
            button4 = new Button();
            textBox2 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1106, 96);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter and Search";
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(946, 39);
            button2.Name = "button2";
            button2.Size = new Size(142, 33);
            button2.TabIndex = 17;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDark;
            button4.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(798, 38);
            button4.Name = "button4";
            button4.Size = new Size(142, 33);
            button4.TabIndex = 16;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(585, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 32);
            textBox2.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(327, 39);
            button1.Name = "button1";
            button1.Size = new Size(142, 33);
            button1.TabIndex = 10;
            button1.Text = "Filter";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(484, 43);
            label2.Name = "label2";
            label2.Size = new Size(105, 24);
            label2.TabIndex = 11;
            label2.Text = "Search By:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 32);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 35);
            label1.Name = "label1";
            label1.Size = new Size(90, 24);
            label1.TabIndex = 0;
            label1.Text = "Filter By:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1106, 467);
            dataGridView1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1050, 593);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 75);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSteelBlue;
            button3.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(17, 593);
            button3.Name = "button3";
            button3.Size = new Size(162, 51);
            button3.TabIndex = 17;
            button3.Text = "Add Book";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSteelBlue;
            button5.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(207, 593);
            button5.Name = "button5";
            button5.Size = new Size(162, 51);
            button5.TabIndex = 18;
            button5.Text = "Edit Book";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.LightSteelBlue;
            button6.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(395, 593);
            button6.Name = "button6";
            button6.Size = new Size(162, 51);
            button6.TabIndex = 19;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = false;
            // 
            // bookList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1140, 680);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "bookList";
            Text = "bookList";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Button button4;
        private TextBox textBox2;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button5;
        private Button button6;
    }
}