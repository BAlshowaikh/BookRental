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
            generateRecordBttn = new Button();
            returnIcon = new PictureBox();
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
            pageTitle = new Label();
            editBttn = new Button();
            ((System.ComponentModel.ISupportInitialize)returnIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransaction).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // generateRecordBttn
            // 
            generateRecordBttn.BackColor = Color.Cornsilk;
            generateRecordBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generateRecordBttn.ForeColor = Color.Black;
            generateRecordBttn.Location = new Point(590, 602);
            generateRecordBttn.Margin = new Padding(2);
            generateRecordBttn.Name = "generateRecordBttn";
            generateRecordBttn.Size = new Size(185, 40);
            generateRecordBttn.TabIndex = 42;
            generateRecordBttn.Text = "Generate Record";
            generateRecordBttn.UseVisualStyleBackColor = false;
            generateRecordBttn.Click += generateRecordBttn_Click;
            // 
            // returnIcon
            // 
            returnIcon.BackColor = Color.Transparent;
            returnIcon.Image = Properties.Resources._return;
            returnIcon.Location = new Point(840, 20);
            returnIcon.Margin = new Padding(2);
            returnIcon.Name = "returnIcon";
            returnIcon.Size = new Size(32, 32);
            returnIcon.SizeMode = PictureBoxSizeMode.Zoom;
            returnIcon.TabIndex = 40;
            returnIcon.TabStop = false;
            // 
            // exitIcon
            // 
            exitIcon.BackColor = Color.Transparent;
            exitIcon.Image = Properties.Resources.exit_icon;
            exitIcon.Location = new Point(920, 20);
            exitIcon.Margin = new Padding(2);
            exitIcon.Name = "exitIcon";
            exitIcon.Size = new Size(32, 32);
            exitIcon.SizeMode = PictureBoxSizeMode.Zoom;
            exitIcon.TabIndex = 39;
            exitIcon.TabStop = false;
            // 
            // homeIcon
            // 
            homeIcon.BackColor = Color.Transparent;
            homeIcon.Image = Properties.Resources.home__2_;
            homeIcon.Location = new Point(880, 20);
            homeIcon.Margin = new Padding(2);
            homeIcon.Name = "homeIcon";
            homeIcon.Size = new Size(32, 32);
            homeIcon.SizeMode = PictureBoxSizeMode.Zoom;
            homeIcon.TabIndex = 38;
            homeIcon.TabStop = false;
            // 
            // userIcon
            // 
            userIcon.BackColor = Color.Transparent;
            userIcon.Image = Properties.Resources.user;
            userIcon.Location = new Point(30, 20);
            userIcon.Margin = new Padding(2);
            userIcon.Name = "userIcon";
            userIcon.Size = new Size(32, 32);
            userIcon.SizeMode = PictureBoxSizeMode.Zoom;
            userIcon.TabIndex = 37;
            userIcon.TabStop = false;
            // 
            // dgvTransaction
            // 
            dgvTransaction.BackgroundColor = SystemColors.Control;
            dgvTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaction.GridColor = SystemColors.ButtonFace;
            dgvTransaction.Location = new Point(33, 221);
            dgvTransaction.Margin = new Padding(2);
            dgvTransaction.Name = "dgvTransaction";
            dgvTransaction.RowHeadersWidth = 62;
            dgvTransaction.Size = new Size(744, 359);
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
            groupBox1.Location = new Point(33, 84);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(742, 118);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // txtTransactionID
            // 
            txtTransactionID.Location = new Point(160, 30);
            txtTransactionID.Name = "txtTransactionID";
            txtTransactionID.Size = new Size(205, 28);
            txtTransactionID.TabIndex = 22;
            // 
            // ddlCustomer
            // 
            ddlCustomer.FormattingEnabled = true;
            ddlCustomer.Location = new Point(489, 25);
            ddlCustomer.Name = "ddlCustomer";
            ddlCustomer.Size = new Size(223, 29);
            ddlCustomer.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(383, 32);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 22);
            label1.TabIndex = 20;
            label1.Text = "Customer:";
            // 
            // refreshBttn
            // 
            refreshBttn.BackColor = Color.Cornsilk;
            refreshBttn.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshBttn.ForeColor = Color.Black;
            refreshBttn.Location = new Point(600, 70);
            refreshBttn.Margin = new Padding(2);
            refreshBttn.Name = "refreshBttn";
            refreshBttn.Size = new Size(112, 30);
            refreshBttn.TabIndex = 19;
            refreshBttn.Text = "Refresh";
            refreshBttn.UseVisualStyleBackColor = false;
            refreshBttn.Click += refreshBttn_Click;
            // 
            // filterBttn
            // 
            filterBttn.BackColor = Color.Cornsilk;
            filterBttn.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterBttn.ForeColor = Color.Black;
            filterBttn.Location = new Point(478, 70);
            filterBttn.Margin = new Padding(2);
            filterBttn.Name = "filterBttn";
            filterBttn.Size = new Size(112, 30);
            filterBttn.TabIndex = 10;
            filterBttn.Text = "Filter";
            filterBttn.UseVisualStyleBackColor = false;
            filterBttn.Click += filterBttn_Click;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFilter.ForeColor = Color.Black;
            lblFilter.Location = new Point(11, 32);
            lblFilter.Margin = new Padding(2, 0, 2, 0);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(147, 22);
            lblFilter.TabIndex = 0;
            lblFilter.Text = "Transaction ID:";
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
            pageTitle.Size = new Size(425, 53);
            pageTitle.TabIndex = 48;
            pageTitle.Text = "View Transactions";
            // 
            // editBttn
            // 
            editBttn.BackColor = Color.Cornsilk;
            editBttn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editBttn.ForeColor = Color.Black;
            editBttn.Location = new Point(392, 602);
            editBttn.Margin = new Padding(2);
            editBttn.Name = "editBttn";
            editBttn.Size = new Size(171, 40);
            editBttn.TabIndex = 51;
            editBttn.Text = "Edit Transaction";
            editBttn.UseVisualStyleBackColor = false;
            editBttn.Click += editBttn_Click;
            // 
            // ViewTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Book_trans_bg;
            ClientSize = new Size(982, 653);
            Controls.Add(editBttn);
            Controls.Add(pageTitle);
            Controls.Add(generateRecordBttn);
            Controls.Add(returnIcon);
            Controls.Add(exitIcon);
            Controls.Add(homeIcon);
            Controls.Add(userIcon);
            Controls.Add(dgvTransaction);
            Controls.Add(groupBox1);
            Name = "ViewTransactions";
            Text = "ViewTransactions";
            Load += ViewTransactions_Load;
            ((System.ComponentModel.ISupportInitialize)returnIcon).EndInit();
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
        private Button generateRecordBttn;
        private PictureBox returnIcon;
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
        private Label pageTitle;
        private Button editBttn;
    }
}