namespace FormApp.Views
{
    partial class ViewTransactions
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
            btnGenerateRecord = new Button();
            exitIcon = new PictureBox();
            homeIcon = new PictureBox();
            userIcon = new PictureBox();
            dgvTransaction = new DataGridView();
            groupBox1 = new GroupBox();
            txtTransactionID = new TextBox();
            ddlCustomer = new ComboBox();
            label1 = new Label();
            refreshBttn = new Button();
            filterBttn = new Button();
            lblFilter = new Label();
            pageTitleTxt = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransaction).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGenerateRecord
            // 
            btnGenerateRecord.BackColor = Color.Cornsilk;
            btnGenerateRecord.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerateRecord.ForeColor = Color.Black;
            btnGenerateRecord.Location = new Point(344, 582);
            btnGenerateRecord.Margin = new Padding(2);
            btnGenerateRecord.Name = "btnGenerateRecord";
            btnGenerateRecord.Size = new Size(276, 50);
            btnGenerateRecord.TabIndex = 42;
            btnGenerateRecord.Text = "Generate Return Record";
            btnGenerateRecord.UseVisualStyleBackColor = false;
            btnGenerateRecord.Click += btnGenerateRecord_Click;
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
            exitIcon.TabIndex = 39;
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
            homeIcon.TabIndex = 38;
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
            userIcon.TabIndex = 37;
            userIcon.TabStop = false;
            userIcon.Click += userIcon_Click;
            // 
            // dgvTransaction
            // 
            dgvTransaction.BackgroundColor = SystemColors.Control;
            dgvTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaction.GridColor = SystemColors.ButtonFace;
            dgvTransaction.Location = new Point(22, 192);
            dgvTransaction.Margin = new Padding(2);
            dgvTransaction.Name = "dgvTransaction";
            dgvTransaction.RowHeadersWidth = 62;
            dgvTransaction.Size = new Size(928, 362);
            dgvTransaction.TabIndex = 36;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtTransactionID);
            groupBox1.Controls.Add(ddlCustomer);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(refreshBttn);
            groupBox1.Controls.Add(filterBttn);
            groupBox1.Controls.Add(lblFilter);
            groupBox1.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(22, 82);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(928, 96);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // txtTransactionID
            // 
            txtTransactionID.Location = new Point(211, 38);
            txtTransactionID.Margin = new Padding(4);
            txtTransactionID.Name = "txtTransactionID";
            txtTransactionID.Size = new Size(150, 32);
            txtTransactionID.TabIndex = 22;
            // 
            // ddlCustomer
            // 
            ddlCustomer.FormattingEnabled = true;
            ddlCustomer.Location = new Point(546, 38);
            ddlCustomer.Margin = new Padding(4);
            ddlCustomer.Name = "ddlCustomer";
            ddlCustomer.Size = new Size(150, 32);
            ddlCustomer.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(368, 44);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 22);
            label1.TabIndex = 20;
            label1.Text = "Filter By Customer:";
            // 
            // refreshBttn
            // 
            refreshBttn.BackColor = Color.Cornsilk;
            refreshBttn.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshBttn.ForeColor = Color.Black;
            refreshBttn.Location = new Point(815, 35);
            refreshBttn.Margin = new Padding(2);
            refreshBttn.Name = "refreshBttn";
            refreshBttn.Size = new Size(105, 38);
            refreshBttn.TabIndex = 19;
            refreshBttn.Text = "Reset";
            refreshBttn.UseVisualStyleBackColor = false;
            refreshBttn.Click += refreshBttn_Click;
            // 
            // filterBttn
            // 
            filterBttn.BackColor = Color.Cornsilk;
            filterBttn.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterBttn.ForeColor = Color.Black;
            filterBttn.Location = new Point(706, 35);
            filterBttn.Margin = new Padding(2);
            filterBttn.Name = "filterBttn";
            filterBttn.Size = new Size(105, 38);
            filterBttn.TabIndex = 10;
            filterBttn.Text = "Filter";
            filterBttn.UseVisualStyleBackColor = false;
            filterBttn.Click += filterBttn_Click;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFilter.ForeColor = Color.Black;
            lblFilter.Location = new Point(6, 47);
            lblFilter.Margin = new Padding(2, 0, 2, 0);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(204, 20);
            lblFilter.TabIndex = 0;
            lblFilter.Text = "Filter By Transaction ID:";
            // 
            // pageTitleTxt
            // 
            pageTitleTxt.AutoSize = true;
            pageTitleTxt.BackColor = Color.Transparent;
            pageTitleTxt.Font = new Font("Tahoma", 22F, FontStyle.Bold);
            pageTitleTxt.ForeColor = Color.Cornsilk;
            pageTitleTxt.Location = new Point(165, 9);
            pageTitleTxt.Name = "pageTitleTxt";
            pageTitleTxt.Size = new Size(646, 53);
            pageTitleTxt.TabIndex = 43;
            pageTitleTxt.Text = "Manage Rental Transactions";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Britannic Bold", 10F);
            button1.Location = new Point(839, 561);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 44;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            // 
            // ViewTransactions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 644);
            Controls.Add(button1);
            Controls.Add(pageTitleTxt);
            Controls.Add(btnGenerateRecord);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            Controls.Add(dgvTransaction);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Margin = new Padding(4);
            Name = "ViewTransactions";
            Text = "ViewTransactions";
            Load += ViewTransactions_Load;
            ((System.ComponentModel.ISupportInitialize)exitIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransaction).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGenerateRecord;
        private PictureBox exitIcon;
        private PictureBox homeIcon;
        private PictureBox userIcon;
        private DataGridView dgvTransaction;
        private GroupBox groupBox1;
        private Button refreshBttn;
        private Button filterBttn;
        private Label lblFilter;
        private ComboBox ddlCustomer;
        private Label label1;
        private TextBox txtTransactionID;
        private Label pageTitleTxt;
        private Button button1;
    }
}