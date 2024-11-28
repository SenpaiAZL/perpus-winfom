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

        private void SiswaForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {

        }

        private void SiswaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            adminLogin.Show();
        }

        private void returning1_Load(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            pnlHighlight.Location = (new Point(pnlHighlight.Location.X, btnBorrowed.Location.Y));
            searchBorrowed1.BringToFront();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            pnlHighlight.Location = (new Point(pnlHighlight.Location.X, btnReturned.Location.Y));
            searchReturn1.BringToFront();
        }

        private void btnOperator(object sender, EventArgs e)
        {
            pnlHighlight.Location = (new Point(pnlHighlight.Location.X, btnSearchBook.Location.Y));
            search1.BringToFront();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            pnlHighlight.Location = (new Point(pnlHighlight.Location.X, btnDash.Location.Y));
            dashboard1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
