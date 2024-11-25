namespace Perpustakaan
{
    partial class MasterOperator
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
            id_siswa = new DataGridViewTextBoxColumn();
            id_user = new DataGridViewTextBoxColumn();
            nis = new DataGridViewTextBoxColumn();
            kelas = new DataGridViewTextBoxColumn();
            alamat = new DataGridViewTextBoxColumn();
            id_user1 = new DataGridViewTextBoxColumn();
            nama = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            no_telp = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            label9 = new Label();
            btnDel = new Button();
            btnEdit = new Button();
            btnInsert = new Button();
            label8 = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtUsername = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            panel3 = new Panel();
            txtNIS = new TextBox();
            txtClass = new TextBox();
            txtTelp = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_siswa, id_user, nis, kelas, alamat, id_user1, nama, role, email, no_telp, username, password });
            dataGridView1.Location = new Point(16, 482);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(663, 160);
            dataGridView1.TabIndex = 48;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // id_siswa
            // 
            id_siswa.DataPropertyName = "id_siswa";
            id_siswa.HeaderText = "ID Siswa";
            id_siswa.Name = "id_siswa";
            id_siswa.ReadOnly = true;
            id_siswa.Visible = false;
            // 
            // id_user
            // 
            id_user.DataPropertyName = "id_user";
            id_user.HeaderText = "ID User";
            id_user.Name = "id_user";
            id_user.ReadOnly = true;
            id_user.Visible = false;
            // 
            // nis
            // 
            nis.DataPropertyName = "nis";
            nis.HeaderText = "NIS";
            nis.Name = "nis";
            nis.ReadOnly = true;
            // 
            // kelas
            // 
            kelas.DataPropertyName = "kelas";
            kelas.HeaderText = "Kelas";
            kelas.Name = "kelas";
            kelas.ReadOnly = true;
            // 
            // alamat
            // 
            alamat.DataPropertyName = "alamat";
            alamat.HeaderText = "Alamat";
            alamat.Name = "alamat";
            alamat.ReadOnly = true;
            // 
            // id_user1
            // 
            id_user1.DataPropertyName = "id_user1";
            id_user1.HeaderText = "ID User 1";
            id_user1.Name = "id_user1";
            id_user1.ReadOnly = true;
            id_user1.Visible = false;
            // 
            // nama
            // 
            nama.DataPropertyName = "nama";
            nama.HeaderText = "Nama";
            nama.Name = "nama";
            nama.ReadOnly = true;
            // 
            // role
            // 
            role.DataPropertyName = "role";
            role.HeaderText = "Role";
            role.Name = "role";
            role.ReadOnly = true;
            role.Visible = false;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "E-mail";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // no_telp
            // 
            no_telp.DataPropertyName = "no_telp";
            no_telp.HeaderText = "No. Telp";
            no_telp.Name = "no_telp";
            no_telp.ReadOnly = true;
            // 
            // username
            // 
            username.DataPropertyName = "username";
            username.HeaderText = "Username";
            username.Name = "username";
            username.ReadOnly = true;
            // 
            // password
            // 
            password.DataPropertyName = "password";
            password.HeaderText = "Password";
            password.Name = "password";
            password.ReadOnly = true;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(119, 436);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(243, 36);
            txtSearch.TabIndex = 47;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(18, 436);
            label9.Name = "label9";
            label9.Size = new Size(86, 25);
            label9.TabIndex = 46;
            label9.Text = "Search";
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Maroon;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDel.ForeColor = SystemColors.ButtonFace;
            btnDel.Location = new Point(479, 365);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(130, 40);
            btnDel.TabIndex = 44;
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
            btnEdit.Location = new Point(295, 365);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(130, 40);
            btnEdit.TabIndex = 43;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.ButtonFace;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(108, 365);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(130, 40);
            btnInsert.TabIndex = 42;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(318, 242);
            label8.Name = "label8";
            label8.Size = new Size(114, 25);
            label8.TabIndex = 41;
            label8.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(448, 244);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(190, 32);
            txtPassword.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(312, 208);
            label6.Name = "label6";
            label6.Size = new Size(121, 25);
            label6.TabIndex = 39;
            label6.Text = "Username";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(329, 165);
            label7.Name = "label7";
            label7.Size = new Size(107, 30);
            label7.TabIndex = 38;
            label7.Text = "No. telp";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(448, 206);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(190, 32);
            txtUsername.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 205);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 35;
            label5.Text = "Class";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 248);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 33;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 166);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 31;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 126);
            label2.Name = "label2";
            label2.Size = new Size(49, 30);
            label2.TabIndex = 30;
            label2.Text = "NIS";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(112, 167);
            txtName.Name = "txtName";
            txtName.Size = new Size(190, 32);
            txtName.TabIndex = 29;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Location = new Point(0, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(725, 55);
            panel3.TabIndex = 28;
            // 
            // txtNIS
            // 
            txtNIS.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNIS.Location = new Point(112, 126);
            txtNIS.Name = "txtNIS";
            txtNIS.Size = new Size(190, 32);
            txtNIS.TabIndex = 49;
            // 
            // txtClass
            // 
            txtClass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClass.Location = new Point(112, 205);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(190, 32);
            txtClass.TabIndex = 50;
            // 
            // txtTelp
            // 
            txtTelp.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelp.Location = new Point(448, 167);
            txtTelp.Name = "txtTelp";
            txtTelp.Size = new Size(190, 32);
            txtTelp.TabIndex = 36;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(112, 250);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(190, 98);
            txtAddress.TabIndex = 51;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(448, 129);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(190, 32);
            txtEmail.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(358, 129);
            label1.Name = "label1";
            label1.Size = new Size(78, 30);
            label1.TabIndex = 52;
            label1.Text = "Email";
            // 
            // MasterOperator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(txtAddress);
            Controls.Add(txtClass);
            Controls.Add(txtNIS);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearch);
            Controls.Add(label9);
            Controls.Add(btnDel);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(label8);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtUsername);
            Controls.Add(txtTelp);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MasterOperator";
            Size = new Size(690, 651);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Label label9;
        private NumericUpDown numericUpDown1;
        private Button btnDel;
        private Button btnEdit;
        private Button btnInsert;
        private Label label8;
        private TextBox txtPassword;
        private Label label6;
        private Label label7;
        private TextBox txtUsername;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private TextBox txtName;
        private Panel panel3;
        private TextBox txtNIS;
        private TextBox txtClass;
        private TextBox txtTelp;
        private TextBox txtAddress;
        private DataGridViewTextBoxColumn id_siswa;
        private DataGridViewTextBoxColumn id_user;
        private DataGridViewTextBoxColumn nis;
        private DataGridViewTextBoxColumn kelas;
        private DataGridViewTextBoxColumn alamat;
        private DataGridViewTextBoxColumn id_user1;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn no_telp;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
        private TextBox txtEmail;
        private Label label1;
    }
}
