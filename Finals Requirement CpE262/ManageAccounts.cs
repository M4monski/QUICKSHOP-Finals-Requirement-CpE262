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
    public partial class ManageAccounts : Form
    {
        public ManageAccounts()
        {
            InitializeComponent();
        }

        private void ManageAccounts_Load(object sender, EventArgs e)
        {
            LBL_ADMINACC.BackColor = Color.Transparent;
        }

        private void But_AdminBack_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void But_DisplayAdmins_Click(object sender, EventArgs e)
        {
            DisplayAdmins admins = new DisplayAdmins();
            admins.Show();
            this.Hide();
        }
        private void But_AddAdmin_Click(object sender, EventArgs e)
        {
            AddAdmin add = new AddAdmin();
            add.Show();
            this.Hide();
        }
    }
}
