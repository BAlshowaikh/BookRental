namespace FormApp
{
    partial class Audit_Trails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Audit_Trails));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Tahoma", 26F, FontStyle.Bold);
            label1.ForeColor = Color.LightSteelBlue;
            label1.Location = new Point(429, 9);
            label1.Name = "label1";
            label1.Size = new Size(327, 63);
            label1.TabIndex = 3;
            label1.Text = "Audit Trails";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1106, 467);
            dataGridView1.TabIndex = 4;
            // 
            // button6
            // 
            button6.BackColor = Color.LightSteelBlue;
            button6.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(956, 587);
            button6.Name = "button6";
            button6.Size = new Size(162, 51);
            button6.TabIndex = 20;
            button6.Text = "Refresh";
            button6.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1050, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 75);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // Audit_Trails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1140, 680);
            Controls.Add(pictureBox1);
            Controls.Add(button6);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Audit_Trails";
            Text = "Audit_Trails";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button6;
        private PictureBox pictureBox1;
    }
}