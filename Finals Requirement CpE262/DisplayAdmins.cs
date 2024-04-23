using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Finals_Requirement_CpE262
{
    public partial class DisplayAdmins : Form
    {
        public DisplayAdmins()
        {
            InitializeComponent();
        }

        private void But_LoadAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    string query = "SELECT Username, Password, SECURITYPIN FROM LOGIN_INFO WHERE ID IS NOT NULL";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    DGV_Admins.DataSource = data;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void But_Back_Click(object sender, EventArgs e)
        {
            ManageAccounts manage = new ManageAccounts();
            manage.Show();
            this.Hide();
        }

        private void But_DeleteAdmin_Click(object sender, EventArgs e)
        {
            DeleteAdmin delete = new DeleteAdmin();
            delete.Show();
        }
    }
}
