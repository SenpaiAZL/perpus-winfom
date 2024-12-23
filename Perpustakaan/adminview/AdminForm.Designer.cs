﻿namespace Perpustakaan
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            pnlHighlight = new Panel();
            btnOperator = new Button();
            button7 = new Button();
            button6 = new Button();
            btnReturn = new Button();
            btnDash = new Button();
            btnBorrow = new Button();
            btnBook = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            sidePanel = new Panel();
            panel1 = new Panel();
            mainPanel = new Panel();
            returning1 = new Returning();
            masterOperator1 = new MasterOperator();
            masterBook1 = new MasterBook();
            borrowing1 = new Borrowing();
            dashboard1 = new Dashboard();
            labelname = new Label();
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
            // btnOperator
            // 
            btnOperator.BackColor = SystemColors.ControlDarkDark;
            btnOperator.FlatAppearance.BorderSize = 0;
            btnOperator.FlatStyle = FlatStyle.Flat;
            btnOperator.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOperator.ForeColor = SystemColors.ButtonFace;
            btnOperator.Location = new Point(11, 232);
            btnOperator.Margin = new Padding(3, 4, 3, 4);
            btnOperator.Name = "btnOperator";
            btnOperator.Size = new Size(269, 44);
            btnOperator.TabIndex = 13;
            btnOperator.Text = "Master Operator";
            btnOperator.UseVisualStyleBackColor = false;
            btnOperator.Click += btnOperator_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlDarkDark;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(39, 728);
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
            // btnReturn
            // 
            btnReturn.BackColor = SystemColors.ControlDarkDark;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = SystemColors.ButtonHighlight;
            btnReturn.Location = new Point(14, 381);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(269, 44);
            btnReturn.TabIndex = 9;
            btnReturn.Text = "Returning Book";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
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
            // btnBorrow
            // 
            btnBorrow.BackColor = SystemColors.ControlDarkDark;
            btnBorrow.FlatAppearance.BorderSize = 0;
            btnBorrow.FlatStyle = FlatStyle.Flat;
            btnBorrow.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrow.ForeColor = SystemColors.ButtonHighlight;
            btnBorrow.Location = new Point(14, 332);
            btnBorrow.Margin = new Padding(3, 4, 3, 4);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(269, 44);
            btnBorrow.TabIndex = 7;
            btnBorrow.Text = "Book Borrowing";
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnBook
            // 
            btnBook.BackColor = SystemColors.ControlDarkDark;
            btnBook.FlatAppearance.BorderSize = 0;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBook.ForeColor = SystemColors.ButtonHighlight;
            btnBook.Location = new Point(14, 283);
            btnBook.Margin = new Padding(3, 4, 3, 4);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(269, 44);
            btnBook.TabIndex = 6;
            btnBook.Text = "Master Book";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
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
            sidePanel.Controls.Add(btnOperator);
            sidePanel.Controls.Add(panel1);
            sidePanel.Controls.Add(button7);
            sidePanel.Controls.Add(button6);
            sidePanel.Controls.Add(btnReturn);
            sidePanel.Controls.Add(btnDash);
            sidePanel.Controls.Add(btnBorrow);
            sidePanel.Controls.Add(btnBook);
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
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = SystemColors.ControlDark;
            mainPanel.Controls.Add(returning1);
            mainPanel.Controls.Add(masterOperator1);
            mainPanel.Controls.Add(masterBook1);
            mainPanel.Controls.Add(borrowing1);
            mainPanel.Controls.Add(dashboard1);
            mainPanel.Location = new Point(287, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(830, 824);
            mainPanel.TabIndex = 51;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // returning1
            // 
            returning1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            returning1.BackColor = SystemColors.ControlDark;
            returning1.Location = new Point(0, 0);
            returning1.Name = "returning1";
            returning1.Size = new Size(830, 821);
            returning1.TabIndex = 4;
            // 
            // masterOperator1
            // 
            masterOperator1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            masterOperator1.BackColor = SystemColors.ControlDark;
            masterOperator1.Location = new Point(0, 0);
            masterOperator1.Name = "masterOperator1";
            masterOperator1.Size = new Size(830, 824);
            masterOperator1.TabIndex = 3;
            // 
            // masterBook1
            // 
            masterBook1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            masterBook1.BackColor = SystemColors.ControlDark;
            masterBook1.Location = new Point(0, 0);
            masterBook1.Name = "masterBook1";
            masterBook1.Size = new Size(830, 827);
            masterBook1.TabIndex = 2;
            // 
            // borrowing1
            // 
            borrowing1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            borrowing1.BackColor = SystemColors.ControlDark;
            borrowing1.Location = new Point(0, 3);
            borrowing1.Name = "borrowing1";
            borrowing1.Size = new Size(830, 824);
            borrowing1.TabIndex = 1;
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
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.BackColor = SystemColors.ControlDarkDark;
            labelname.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelname.ForeColor = SystemColors.ButtonFace;
            labelname.Location = new Point(320, 50);
            labelname.Name = "labelname";
            labelname.Size = new Size(135, 38);
            labelname.TabIndex = 5;
            labelname.Text = "Welcome";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1117, 824);
            Controls.Add(labelname);
            Controls.Add(mainPanel);
            Controls.Add(panel2);
            Controls.Add(sidePanel);
            Name = "AdminForm";
            Text = "AdminForm";
            HelpButtonClicked += AdminForm_HelpButtonClicked;
            FormClosing += AdminForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sidePanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlHighlight;
        private Button btnOperator;
        private Button button7;
        private Button button6;
        private Button btnReturn;
        private Button btnDash;
        private Button btnBorrow;
        private Button btnBook;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel sidePanel;
        private Panel mainPanel;
        private Dashboard dashboard1;
        private Borrowing borrowing1;
        private MasterOperator masterOperator1;
        private MasterBook masterBook1;
        private Returning returning1;
        private Panel panel1;
        private Label labelname;
    }
}