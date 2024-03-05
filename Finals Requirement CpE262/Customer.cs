using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals_Requirement_CpE262
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void But_CustBack_Click(object sender, EventArgs e)
        {
            MainUI main = new MainUI();
            main.Show();
            this.Hide();
        }

        private void But_CustExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void But_Browse_Click(object sender, EventArgs e)
        {

        }
    }
}
