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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
        }

        private void But_SalesHistory_Click(object sender, EventArgs e)
        {
            SalesHistory history = new SalesHistory();
            this.Hide();
            history.Show();
        }

        private void But_SalesReport_Click(object sender, EventArgs e)
        {
            SalesReport sales = new SalesReport();
            this.Hide();
            sales.Show();
        }

        private void But_Back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }
    }
}
