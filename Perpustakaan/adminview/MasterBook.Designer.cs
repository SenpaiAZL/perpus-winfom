namespace Perpustakaan
{
    partial class MasterBook
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
            dataGridView1 = new DataGridView();
            id_buku = new DataGridViewTextBoxColumn();
            judul_buku = new DataGridViewTextBoxColumn();
            pengarang = new DataGridViewTextBoxColumn();
            penerbit = new DataGridViewTextBoxColumn();
            tahun_terbit = new DataGridViewTextBoxColumn();
            stok = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            label9 = new Label();
            button10 = new Button();
            button9 = new Button();
            button2 = new Button();
            txtPublisher = new TextBox();
            txtTitle = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtReleaseYear = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtAuthor = new TextBox();
            panel3 = new Panel();
            numStok = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStok).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_buku, judul_buku, pengarang, penerbit, tahun_terbit, stok });
            dataGridView1.Location = new Point(14, 374);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(642, 101);
            dataGridView1.TabIndex = 61;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // id_buku
            // 
            id_buku.DataPropertyName = "id_buku";
            id_buku.HeaderText = "ID Buku";
            id_buku.Name = "id_buku";
            id_buku.ReadOnly = true;
            id_buku.Visible = false;
            // 
            // judul_buku
            // 
            judul_buku.DataPropertyName = "judul_buku";
            judul_buku.HeaderText = "Title";
            judul_buku.Name = "judul_buku";
            judul_buku.ReadOnly = true;
            // 
            // pengarang
            // 
            pengarang.DataPropertyName = "pengarang";
            pengarang.HeaderText = "Author";
            pengarang.Name = "pengarang";
            pengarang.ReadOnly = true;
            // 
            // penerbit
            // 
            penerbit.DataPropertyName = "penerbit";
            penerbit.HeaderText = "Publisher";
            penerbit.Name = "penerbit";
            penerbit.ReadOnly = true;
            // 
            // tahun_terbit
            // 
            tahun_terbit.DataPropertyName = "tahun_terbit";
            tahun_terbit.HeaderText = "Release Year";
            tahun_terbit.Name = "tahun_terbit";
            tahun_terbit.ReadOnly = true;
            // 
            // stok
            // 
            stok.DataPropertyName = "stok";
            stok.HeaderText = "Stock";
            stok.Name = "stok";
            stok.ReadOnly = true;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(104, 335);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(243, 36);
            txtSearch.TabIndex = 60;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(4, 335);
            label9.Name = "label9";
            label9.Size = new Size(86, 25);
            label9.TabIndex = 59;
            label9.Text = "Search";
            // 
            // button10
            // 
            button10.BackColor = Color.Maroon;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.ButtonFace;
            button10.Location = new Point(464, 265);
            button10.Name = "button10";
            button10.Size = new Size(130, 40);
            button10.TabIndex = 58;
            button10.Text = "Delete";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.DarkGreen;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ButtonFace;
            button9.Location = new Point(280, 265);
            button9.Name = "button9";
            button9.Size = new Size(130, 40);
            button9.TabIndex = 57;
            button9.Text = "Edit";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(93, 265);
            button2.Name = "button2";
            button2.Size = new Size(130, 40);
            button2.TabIndex = 56;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtPublisher
            // 
            txtPublisher.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPublisher.Location = new Point(123, 193);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(190, 32);
            txtPublisher.TabIndex = 55;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(123, 115);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(190, 32);
            txtTitle.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(365, 155);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 53;
            label6.Text = "Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(318, 115);
            label7.Name = "label7";
            label7.Size = new Size(170, 30);
            label7.TabIndex = 52;
            label7.Text = "Release Year";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReleaseYear.Location = new Point(507, 115);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(132, 32);
            txtReleaseYear.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 196);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 49;
            label5.Text = "Publisher";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 155);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 48;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 116);
            label2.Name = "label2";
            label2.Size = new Size(60, 30);
            label2.TabIndex = 47;
            label2.Text = "Title";
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAuthor.Location = new Point(123, 155);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(190, 32);
            txtAuthor.TabIndex = 46;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Location = new Point(0, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(682, 55);
            panel3.TabIndex = 45;
            // 
            // numStok
            // 
            numStok.Location = new Point(507, 153);
            numStok.Name = "numStok";
            numStok.Size = new Size(120, 23);
            numStok.TabIndex = 62;
            // 
            // MasterBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(numStok);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearch);
            Controls.Add(label9);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button2);
            Controls.Add(txtPublisher);
            Controls.Add(txtTitle);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtReleaseYear);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtAuthor);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MasterBook";
            Size = new Size(678, 486);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Label label9;
        private Button button10;
        private Button button9;
        private Button button2;
        private TextBox txtPublisher;
        private TextBox txtTitle;
        private Label label6;
        private Label label7;
        private TextBox txtReleaseYear;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox txtAuthor;
        private Panel panel3;
        private NumericUpDown numStok;
        private DataGridViewTextBoxColumn id_buku;
        private DataGridViewTextBoxColumn judul_buku;
        private DataGridViewTextBoxColumn pengarang;
        private DataGridViewTextBoxColumn penerbit;
        private DataGridViewTextBoxColumn tahun_terbit;
        private DataGridViewTextBoxColumn stok;
    }
}
