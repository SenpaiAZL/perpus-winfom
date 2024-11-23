namespace Perpustakaan
{
    partial class adminLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminLogin));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            Account = new LinkLabel();
            Pass = new Label();
            name = new Label();
            password = new TextBox();
            username = new TextBox();
            Log = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 590);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(64, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 362);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(602, 110);
            label1.Name = "label1";
            label1.Size = new Size(150, 55);
            label1.TabIndex = 1;
            label1.Text = "Log In";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(Account);
            panel2.Controls.Add(Pass);
            panel2.Controls.Add(name);
            panel2.Controls.Add(password);
            panel2.Controls.Add(username);
            panel2.Controls.Add(Log);
            panel2.Location = new Point(476, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 269);
            panel2.TabIndex = 2;
            // 
            // Account
            // 
            Account.ActiveLinkColor = Color.MidnightBlue;
            Account.AutoSize = true;
            Account.Location = new Point(211, 155);
            Account.Name = "Account";
            Account.Size = new Size(160, 20);
            Account.TabIndex = 6;
            Account.TabStop = true;
            Account.Text = "Forgot your password?";
            // 
            // Pass
            // 
            Pass.AutoSize = true;
            Pass.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pass.Location = new Point(11, 119);
            Pass.Name = "Pass";
            Pass.Size = new Size(118, 27);
            Pass.TabIndex = 5;
            Pass.Text = "Password";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.Location = new Point(11, 69);
            name.Name = "name";
            name.Size = new Size(126, 27);
            name.TabIndex = 4;
            name.Text = "Username";
            // 
            // password
            // 
            password.BackColor = Color.Gainsboro;
            password.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(135, 108);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(234, 44);
            password.TabIndex = 3;
            // 
            // username
            // 
            username.BackColor = Color.Gainsboro;
            username.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(135, 58);
            username.Name = "username";
            username.Size = new Size(234, 44);
            username.TabIndex = 2;
            // 
            // Log
            // 
            Log.BackColor = Color.Silver;
            Log.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Log.Location = new Point(223, 200);
            Log.Name = "Log";
            Log.Size = new Size(146, 54);
            Log.TabIndex = 1;
            Log.Text = "Log in";
            Log.UseVisualStyleBackColor = false;
            Log.Click += Log_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(0, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(41, 570);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(458, 178);
            panel4.Name = "panel4";
            panel4.Size = new Size(432, 269);
            panel4.TabIndex = 3;
            // 
            // adminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(986, 584);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "adminLogin";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button Log;
        private Panel panel3;
        private TextBox password;
        private TextBox username;
        private Label Pass;
        private Label name;
        private LinkLabel Account;
        private Panel panel4;
    }
}
