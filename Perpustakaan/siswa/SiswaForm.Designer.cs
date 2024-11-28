namespace Perpustakaan
{
    partial class SiswaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiswaForm));
            pnlHighlight = new Panel();
            btnSearchBook = new Button();
            button7 = new Button();
            button6 = new Button();
            btnDash = new Button();
            btnReturned = new Button();
            btnBorrowed = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            sidePanel = new Panel();
            panel1 = new Panel();
            siswalabel = new Label();
            mainPanel = new Panel();
            searchReturn1 = new siswa.SearchReturn();
            searchBorrowed1 = new siswa.SearchBorrowed();
            search1 = new siswa.SearchBook();
            dashboard1 = new Dashboard();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sidePanel.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHighlight
            // 
            pnlHighlight.BackColor = Color.SteelBlue;
            pnlHighlight.Location = new Point(272, 232);
            pnlHighlight.Margin = new Padding(3, 4, 3, 4);
            pnlHighlight.Name = "pnlHighlight";
            pnlHighlight.Size = new Size(11, 44);
            pnlHighlight.TabIndex = 12;
            // 
            // btnSearchBook
            // 
            btnSearchBook.BackColor = SystemColors.ControlDarkDark;
            btnSearchBook.FlatAppearance.BorderSize = 0;
            btnSearchBook.FlatStyle = FlatStyle.Flat;
            btnSearchBook.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchBook.ForeColor = SystemColors.ButtonFace;
            btnSearchBook.Location = new Point(11, 232);
            btnSearchBook.Margin = new Padding(3, 4, 3, 4);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(269, 44);
            btnSearchBook.TabIndex = 13;
            btnSearchBook.Text = "Search Book";
            btnSearchBook.UseVisualStyleBackColor = false;
            btnSearchBook.Click += btnOperator;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlDarkDark;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(38, 728);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(231, 44);
            button7.TabIndex = 11;
            button7.Text = "Change Account";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlDarkDark;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(14, 676);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(269, 44);
            button6.TabIndex = 10;
            button6.Text = "Log out";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // btnDash
            // 
            btnDash.BackColor = SystemColors.ControlDarkDark;
            btnDash.FlatAppearance.BorderSize = 0;
            btnDash.FlatStyle = FlatStyle.Flat;
            btnDash.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDash.ForeColor = SystemColors.ButtonHighlight;
            btnDash.Location = new Point(14, 181);
            btnDash.Margin = new Padding(3, 4, 3, 4);
            btnDash.Name = "btnDash";
            btnDash.Size = new Size(269, 44);
            btnDash.TabIndex = 8;
            btnDash.Text = "DashBoard";
            btnDash.UseVisualStyleBackColor = false;
            btnDash.Click += btnDash_Click;
            // 
            // btnReturned
            // 
            btnReturned.BackColor = SystemColors.ControlDarkDark;
            btnReturned.FlatAppearance.BorderSize = 0;
            btnReturned.FlatStyle = FlatStyle.Flat;
            btnReturned.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturned.ForeColor = SystemColors.ButtonHighlight;
            btnReturned.Location = new Point(14, 332);
            btnReturned.Margin = new Padding(3, 4, 3, 4);
            btnReturned.Name = "btnReturned";
            btnReturned.Size = new Size(269, 44);
            btnReturned.TabIndex = 7;
            btnReturned.Text = "Returned History";
            btnReturned.UseVisualStyleBackColor = false;
            btnReturned.Click += btnBorrow_Click;
            // 
            // btnBorrowed
            // 
            btnBorrowed.BackColor = SystemColors.ControlDarkDark;
            btnBorrowed.FlatAppearance.BorderSize = 0;
            btnBorrowed.FlatStyle = FlatStyle.Flat;
            btnBorrowed.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrowed.ForeColor = SystemColors.ButtonHighlight;
            btnBorrowed.Location = new Point(14, 283);
            btnBorrowed.Margin = new Padding(3, 4, 3, 4);
            btnBorrowed.Name = "btnBorrowed";
            btnBorrowed.Size = new Size(269, 44);
            btnBorrowed.TabIndex = 6;
            btnBorrowed.Text = "Borrowed History";
            btnBorrowed.UseVisualStyleBackColor = false;
            btnBorrowed.Click += btnBook_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(53, -31);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 231);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(-5, 3);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(27, 821);
            panel2.TabIndex = 29;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = SystemColors.ControlDarkDark;
            sidePanel.Controls.Add(pnlHighlight);
            sidePanel.Controls.Add(btnSearchBook);
            sidePanel.Controls.Add(panel1);
            sidePanel.Controls.Add(button7);
            sidePanel.Controls.Add(button6);
            sidePanel.Controls.Add(btnDash);
            sidePanel.Controls.Add(btnReturned);
            sidePanel.Controls.Add(btnBorrowed);
            sidePanel.Controls.Add(pictureBox1);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Margin = new Padding(3, 4, 3, 4);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(283, 824);
            sidePanel.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(14, 232);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 44);
            panel1.TabIndex = 5;
            // 
            // siswalabel
            // 
            siswalabel.AutoSize = true;
            siswalabel.BackColor = SystemColors.ControlDarkDark;
            siswalabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siswalabel.ForeColor = SystemColors.ButtonFace;
            siswalabel.Location = new Point(320, 50);
            siswalabel.Name = "siswalabel";
            siswalabel.Size = new Size(130, 38);
            siswalabel.TabIndex = 5;
            siswalabel.Text = "welcome";
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = SystemColors.ControlDark;
            mainPanel.Controls.Add(searchReturn1);
            mainPanel.Controls.Add(searchBorrowed1);
            mainPanel.Controls.Add(search1);
            mainPanel.Controls.Add(dashboard1);
            mainPanel.Location = new Point(287, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(830, 824);
            mainPanel.TabIndex = 51;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // searchReturn1
            // 
            searchReturn1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchReturn1.BackColor = SystemColors.ControlDark;
            searchReturn1.Location = new Point(-1, 3);
            searchReturn1.Name = "searchReturn1";
            searchReturn1.Size = new Size(831, 821);
            searchReturn1.TabIndex = 3;
            // 
            // searchBorrowed1
            // 
            searchBorrowed1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchBorrowed1.BackColor = SystemColors.ControlDark;
            searchBorrowed1.Location = new Point(-12, 0);
            searchBorrowed1.Name = "searchBorrowed1";
            searchBorrowed1.Size = new Size(852, 834);
            searchBorrowed1.TabIndex = 2;
            // 
            // search1
            // 
            search1.BackColor = SystemColors.ControlDark;
            search1.Location = new Point(-12, 3);
            search1.Name = "search1";
            search1.Size = new Size(852, 831);
            search1.TabIndex = 1;
            // 
            // dashboard1
            // 
            dashboard1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dashboard1.BackColor = SystemColors.ControlDark;
            dashboard1.Location = new Point(0, 3);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(830, 821);
            dashboard1.TabIndex = 0;
            // 
            // SiswaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1117, 824);
            Controls.Add(siswalabel);
            Controls.Add(mainPanel);
            Controls.Add(panel2);
            Controls.Add(sidePanel);
            Name = "SiswaForm";
            Text = "SiswaForm";
            HelpButtonClicked += SiswaForm_HelpButtonClicked;
            FormClosing += SiswaForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sidePanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlHighlight;
        private Button btnSearchBook;
        private Button button7;
        private Button button6;
        private Button btnDash;
        private Button btnReturned;
        private Button btnBorrowed;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel sidePanel;
        private Panel mainPanel;
        private Dashboard dashboard1;
        private Panel panel1;
        private Label siswalabel;
        private siswa.SearchBook search1;
        private siswa.SearchReturn searchReturn1;
        private siswa.SearchBorrowed searchBorrowed1;
    }
}