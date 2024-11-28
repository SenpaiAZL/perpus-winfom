namespace Perpustakaan
{
    partial class Borrowing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgvBorrowing = new DataGridView();
            dtgvBorrowingDetail = new DataGridView();
            txtSearch = new TextBox();
            label9 = new Label();
            btnSave = new Button();
            btnDel = new Button();
            btnEdit = new Button();
            btnInsert = new Button();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            txtNIS = new TextBox();
            label1 = new Label();
            cbName = new ComboBox();
            txtBookID = new TextBox();
            cbTitle = new ComboBox();
            label4 = new Label();
            numStock = new NumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvBorrowing).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvBorrowingDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // dtgvBorrowing
            // 
            dtgvBorrowing.AllowUserToAddRows = false;
            dtgvBorrowing.AllowUserToDeleteRows = false;
            dtgvBorrowing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvBorrowing.BackgroundColor = Color.Gray;
            dtgvBorrowing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBorrowing.Location = new Point(20, 464);
            dtgvBorrowing.Margin = new Padding(3, 2, 3, 2);
            dtgvBorrowing.MultiSelect = false;
            dtgvBorrowing.Name = "dtgvBorrowing";
            dtgvBorrowing.ReadOnly = true;
            dtgvBorrowing.RowHeadersWidth = 51;
            dtgvBorrowing.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvBorrowing.Size = new Size(555, 104);
            dtgvBorrowing.TabIndex = 54;
            dtgvBorrowing.CellClick += dtgvBorrowing_CellClick;
            // 
            // dtgvBorrowingDetail
            // 
            dtgvBorrowingDetail.AllowUserToAddRows = false;
            dtgvBorrowingDetail.AllowUserToDeleteRows = false;
            dtgvBorrowingDetail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgvBorrowingDetail.BackgroundColor = Color.Gray;
            dtgvBorrowingDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBorrowingDetail.Location = new Point(335, 88);
            dtgvBorrowingDetail.Margin = new Padding(3, 2, 3, 2);
            dtgvBorrowingDetail.MultiSelect = false;
            dtgvBorrowingDetail.Name = "dtgvBorrowingDetail";
            dtgvBorrowingDetail.ReadOnly = true;
            dtgvBorrowingDetail.RowHeadersWidth = 51;
            dtgvBorrowingDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvBorrowingDetail.Size = new Size(240, 218);
            dtgvBorrowingDetail.TabIndex = 53;
            dtgvBorrowingDetail.CellClick += dtgvBorrowingDetail_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(115, 426);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(243, 36);
            txtSearch.TabIndex = 52;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 430);
            label9.Name = "label9";
            label9.Size = new Size(86, 25);
            label9.TabIndex = 51;
            label9.Text = "Search";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.BackColor = SystemColors.ButtonFace;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(16, 368);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(559, 42);
            btnSave.TabIndex = 50;
            btnSave.Text = "Save ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Maroon;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDel.ForeColor = SystemColors.ButtonFace;
            btnDel.Location = new Point(299, 310);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(122, 42);
            btnDel.TabIndex = 49;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkGreen;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ButtonFace;
            btnEdit.Location = new Point(164, 310);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(122, 42);
            btnEdit.TabIndex = 48;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ButtonFace;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(28, 309);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(122, 42);
            btnInsert.TabIndex = 47;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 185);
            label3.Name = "label3";
            label3.Size = new Size(102, 30);
            label3.TabIndex = 44;
            label3.Text = "Book ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 86);
            label2.Name = "label2";
            label2.Size = new Size(49, 30);
            label2.TabIndex = 41;
            label2.Text = "NIS";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Location = new Point(0, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(602, 55);
            panel3.TabIndex = 40;
            // 
            // txtNIS
            // 
            txtNIS.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNIS.Location = new Point(127, 88);
            txtNIS.Name = "txtNIS";
            txtNIS.Size = new Size(190, 32);
            txtNIS.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 119);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 56;
            label1.Text = "Name";
            // 
            // cbName
            // 
            cbName.FormattingEnabled = true;
            cbName.Location = new Point(127, 126);
            cbName.Name = "cbName";
            cbName.Size = new Size(190, 23);
            cbName.TabIndex = 57;
            // 
            // txtBookID
            // 
            txtBookID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookID.Location = new Point(127, 181);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(190, 32);
            txtBookID.TabIndex = 58;
            // 
            // cbTitle
            // 
            cbTitle.FormattingEnabled = true;
            cbTitle.Location = new Point(127, 219);
            cbTitle.Name = "cbTitle";
            cbTitle.Size = new Size(190, 23);
            cbTitle.TabIndex = 59;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 215);
            label4.Name = "label4";
            label4.Size = new Size(60, 30);
            label4.TabIndex = 60;
            label4.Text = "Title";
            // 
            // numStock
            // 
            numStock.Location = new Point(127, 248);
            numStock.Name = "numStock";
            numStock.Size = new Size(120, 23);
            numStock.TabIndex = 61;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 248);
            label5.Name = "label5";
            label5.Size = new Size(77, 30);
            label5.TabIndex = 62;
            label5.Text = "Stock";
            // 
            // Borrowing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(label5);
            Controls.Add(numStock);
            Controls.Add(label4);
            Controls.Add(cbTitle);
            Controls.Add(txtBookID);
            Controls.Add(cbName);
            Controls.Add(label1);
            Controls.Add(txtNIS);
            Controls.Add(dtgvBorrowing);
            Controls.Add(dtgvBorrowingDetail);
            Controls.Add(txtSearch);
            Controls.Add(label9);
            Controls.Add(btnSave);
            Controls.Add(btnDel);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Borrowing";
            Size = new Size(592, 582);
            ((System.ComponentModel.ISupportInitialize)dtgvBorrowing).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvBorrowingDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvBorrowing;
        private DataGridView dtgvBorrowingDetail;
        private TextBox txtSearch;
        private Label label9;
        private Button btnSave;
        private Button btnDel;
        private Button btnEdit;
        private Button btnInsert;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private TextBox txtNIS;
        private Label label1;
        private ComboBox cbName;
        private TextBox txtBookID;
        private ComboBox cbTitle;
        private Label label4;
        private NumericUpDown numStock;
        private Label label5;
    }
}
