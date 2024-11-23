using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan
{
    public partial class SiswaForm : Form
    {
        private adminLogin adminLogin;
        public SiswaForm(adminLogin _adminLogin)
        {
            InitializeComponent();
            siswalabel.Text = "Welcome. " + userinfo.info + "!";
            adminLogin = _adminLogin;
            pnlHighlight.Location = (new Point(pnlHighlight.Location.X, btnDash.Location.Y));
            dashboard1.BringToFront();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            pnlHighlight.Location = (new Point(pnlHighlight.Location.X, btnDash.Location.Y));
            dashboard1.BringToFront();
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            pnlHighlight.Location = (new Point(pnlHighlight.Location.X, btnOperator.Location.Y));
            masterOperator1.BringToFront();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            pnlHighlight.Location = (new Point(pnlHighlight.Location.X, btnBook.Location.Y));
            masterBook1.BringToFront();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            pnlHighlight.Location = (new Point(pnlHighlight.Location.X, btnBorrow.Location.Y));
            borrowing1.BringToFront();
        }


        private void SiswaForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {

        }

        private void SiswaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            adminLogin.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
