namespace ElectricStore_ChauHan
{
    partial class frmManagement
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgv = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            cbCateName = new ComboBox();
            dtpDate = new DateTimePicker();
            txtPrice = new TextBox();
            txtCode = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(161, 24);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(384, 27);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(561, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 28);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgv.Location = new Point(20, 64);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(824, 405);
            dgv.TabIndex = 2;
            dgv.CellClick += dgv_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Product ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Product Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Product Code";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Date Created";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Category Name";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbCateName);
            groupBox1.Controls.Add(dtpDate);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(853, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 405);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // cbCateName
            // 
            cbCateName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCateName.FormattingEnabled = true;
            cbCateName.Location = new Point(138, 301);
            cbCateName.Name = "cbCateName";
            cbCateName.Size = new Size(177, 28);
            cbCateName.TabIndex = 14;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(138, 252);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(180, 27);
            dtpDate.TabIndex = 13;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(138, 199);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(180, 27);
            txtPrice.TabIndex = 12;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(138, 145);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(180, 27);
            txtCode.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 27);
            txtName.TabIndex = 10;
            // 
            // txtID
            // 
            txtID.Location = new Point(138, 49);
            txtID.Name = "txtID";
            txtID.Size = new Size(180, 27);
            txtID.TabIndex = 9;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(227, 359);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 27);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(118, 359);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 27);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(8, 359);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 27);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 304);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 5;
            label6.Text = "Category Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 257);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 4;
            label5.Text = "Date Created";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 202);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 148);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 98);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 52);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(570, 475);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 36);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 523);
            Controls.Add(btnExit);
            Controls.Add(groupBox1);
            Controls.Add(dgv);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Name = "frmManagement";
            Text = "frmManagement";
            Load += frmManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn Price;
        private GroupBox groupBox1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnExit;
        private TextBox txtID;
        private TextBox txtCode;
        private TextBox txtName;
        private ComboBox cbCateName;
        private DateTimePicker dtpDate;
        private TextBox txtPrice;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}