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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void But_Back_Click(object sender, EventArgs e)
        {
            MainUI main = new MainUI();
            main.Show();
            this.Hide();
        }

        private void But_AdminExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
