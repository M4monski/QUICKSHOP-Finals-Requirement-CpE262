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
            Label_ADash.BackColor = Color.Transparent;
            But_AddProd.BackColor = Color.Transparent;
            But_DelProd.BackColor = Color.Transparent;
            But_ManageProducts.BackColor = Color.Transparent;
            But_ManageAcc.BackColor = Color.Transparent;
            But_SalesRep.BackColor = Color.Transparent;
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

        private void But_ManageAcc_Click(object sender, EventArgs e)
        {
            ManageAccounts accounts = new ManageAccounts();
            accounts.Show();
            this.Hide();
        }

        private void But_AddProd_Click(object sender, EventArgs e)
        {
            AddProduct product = new AddProduct();
            product.Show();
            this.Hide();
        }

        private void But_DelProd_Click(object sender, EventArgs e)
        {
            DeleteProduct delprod = new DeleteProduct();
            delprod.Show();
            this.Hide();
        }

        private void But_SalesRep_Click(object sender, EventArgs e)
        {
            SalesHistory sales = new SalesHistory();
            this.Hide();
            sales.Show();
        }

        private void But_ManageProducts_Click(object sender, EventArgs e)
        {
            ManageProducts manage = new ManageProducts();
            this.Hide();
            manage.Show();
        }

        private void G2But_CashierPOS_Click(object sender, EventArgs e)
        {
            CashierShop cashier = new CashierShop();
            cashier.Show();
            this.Hide();    
        }
    }
}
