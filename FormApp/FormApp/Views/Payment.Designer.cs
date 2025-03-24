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
            pageTitleTxt = new Label();
            totalRentalPriceTxt = new TextBox();
            bookNameTxt = new TextBox();
            bookNameLbl = new Label();
            paymentMethodCb = new ComboBox();
            paymentMethodLbl = new Label();
            button1 = new Button();
            button3 = new Button();
            totalRentalPriceLbl = new Label();
            bookRentalPriceTxt = new TextBox();
            bookRentalPriceLbl = new Label();
            SuspendLayout();
            // 
            // pageTitleTxt
            // 
            pageTitleTxt.AutoSize = true;
            pageTitleTxt.BackColor = Color.Transparent;
            pageTitleTxt.Font = new Font("Tahoma", 26F, FontStyle.Bold);
            pageTitleTxt.ForeColor = Color.Cornsilk;
            pageTitleTxt.Location = new Point(277, 7);
            pageTitleTxt.Margin = new Padding(2, 0, 2, 0);
            pageTitleTxt.Name = "pageTitleTxt";
            pageTitleTxt.Size = new Size(217, 53);
            pageTitleTxt.TabIndex = 2;
            pageTitleTxt.Text = "Payment";
            pageTitleTxt.Click += label1_Click;
            // 
            // totalRentalPriceTxt
            // 
            totalRentalPriceTxt.Location = new Point(355, 256);
            totalRentalPriceTxt.Margin = new Padding(2, 2, 2, 2);
            totalRentalPriceTxt.Name = "totalRentalPriceTxt";
            totalRentalPriceTxt.Size = new Size(273, 27);
            totalRentalPriceTxt.TabIndex = 6;
            // 
            // bookNameTxt
            // 
            bookNameTxt.Location = new Point(350, 121);
            bookNameTxt.Margin = new Padding(2, 2, 2, 2);
            bookNameTxt.Name = "bookNameTxt";
            bookNameTxt.Size = new Size(273, 27);
            bookNameTxt.TabIndex = 4;
            // 
            // bookNameLbl
            // 
            bookNameLbl.AutoSize = true;
            bookNameLbl.BackColor = Color.Transparent;
            bookNameLbl.Font = new Font("Britannic Bold", 14F);
            bookNameLbl.ForeColor = Color.Black;
            bookNameLbl.Location = new Point(96, 118);
            bookNameLbl.Margin = new Padding(2, 0, 2, 0);
            bookNameLbl.Name = "bookNameLbl";
            bookNameLbl.Size = new Size(132, 27);
            bookNameLbl.TabIndex = 3;
            bookNameLbl.Text = "Book Name";
            bookNameLbl.Click += bookNameLbl_Click;
            // 
            // paymentMethodCb
            // 
            paymentMethodCb.FormattingEnabled = true;
            paymentMethodCb.Location = new Point(355, 321);
            paymentMethodCb.Margin = new Padding(2, 2, 2, 2);
            paymentMethodCb.Name = "paymentMethodCb";
            paymentMethodCb.Size = new Size(273, 28);
            paymentMethodCb.TabIndex = 8;
            // 
            // paymentMethodLbl
            // 
            paymentMethodLbl.AutoSize = true;
            paymentMethodLbl.BackColor = Color.Transparent;
            paymentMethodLbl.Font = new Font("Britannic Bold", 12F);
            paymentMethodLbl.ForeColor = Color.Black;
            paymentMethodLbl.Location = new Point(96, 321);
            paymentMethodLbl.Margin = new Padding(2, 0, 2, 0);
            paymentMethodLbl.Name = "paymentMethodLbl";
            paymentMethodLbl.Size = new Size(230, 22);
            paymentMethodLbl.TabIndex = 7;
            paymentMethodLbl.Text = "Select a payment method";
            // 
            // button1
            // 
            button1.BackColor = Color.Cornsilk;
            button1.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(234, 433);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(130, 41);
            button1.TabIndex = 9;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(394, 433);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(130, 41);
            button3.TabIndex = 13;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // totalRentalPriceLbl
            // 
            totalRentalPriceLbl.AutoSize = true;
            totalRentalPriceLbl.BackColor = Color.Transparent;
            totalRentalPriceLbl.Font = new Font("Britannic Bold", 14F);
            totalRentalPriceLbl.ForeColor = Color.Black;
            totalRentalPriceLbl.Location = new Point(96, 252);
            totalRentalPriceLbl.Margin = new Padding(2, 0, 2, 0);
            totalRentalPriceLbl.Name = "totalRentalPriceLbl";
            totalRentalPriceLbl.Size = new Size(203, 27);
            totalRentalPriceLbl.TabIndex = 5;
            totalRentalPriceLbl.Text = "Total Rental Price";
            // 
            // bookRentalPriceTxt
            // 
            bookRentalPriceTxt.Location = new Point(353, 189);
            bookRentalPriceTxt.Margin = new Padding(2, 2, 2, 2);
            bookRentalPriceTxt.Name = "bookRentalPriceTxt";
            bookRentalPriceTxt.Size = new Size(273, 27);
            bookRentalPriceTxt.TabIndex = 15;
            // 
            // bookRentalPriceLbl
            // 
            bookRentalPriceLbl.AutoSize = true;
            bookRentalPriceLbl.BackColor = Color.Transparent;
            bookRentalPriceLbl.Font = new Font("Britannic Bold", 14F);
            bookRentalPriceLbl.ForeColor = Color.Black;
            bookRentalPriceLbl.Location = new Point(96, 185);
            bookRentalPriceLbl.Margin = new Padding(2, 0, 2, 0);
            bookRentalPriceLbl.Name = "bookRentalPriceLbl";
            bookRentalPriceLbl.Size = new Size(204, 27);
            bookRentalPriceLbl.TabIndex = 14;
            bookRentalPriceLbl.Text = "Book Rental Price";
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 653);
            Controls.Add(bookRentalPriceTxt);
            Controls.Add(bookRentalPriceLbl);
            Controls.Add(totalRentalPriceTxt);
            Controls.Add(paymentMethodCb);
            Controls.Add(totalRentalPriceLbl);
            Controls.Add(paymentMethodLbl);
            Controls.Add(bookNameTxt);
            Controls.Add(bookNameLbl);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(pageTitleTxt);
            DoubleBuffered = true;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Payment";
            Text = "Payment";
            Load += Payment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pageTitleTxt;
        private TextBox totalRentalPriceTxt;
        private TextBox bookNameTxt;
        private Label bookNameLbl;
        private ComboBox paymentMethodCb;
        private Label paymentMethodLbl;
        private Button button1;
        private Button button3;
        private Label totalRentalPriceLbl;
        private TextBox bookRentalPriceTxt;
        private Label bookRentalPriceLbl;
    }
}