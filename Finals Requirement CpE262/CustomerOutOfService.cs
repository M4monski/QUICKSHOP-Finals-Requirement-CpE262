using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals_Requirement_CpE262
{
    public partial class CustomerOutOfService : Form
    {
        public CustomerOutOfService()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    string query = "SELECT ImageLogo, ProductName, ProductPrice, ProductQuantity FROM Products";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    // Set AutoGenerateColumns to false to prevent creating new columns
                    G2DGV_Products.AutoGenerateColumns = false;

                    // Assign the DataTable to the DataSource of the DataGridView
                    G2DGV_Products.DataSource = data;

                    // Optionally, you can map the columns to specific properties in the DataTable
                    G2DGV_Products.Columns["ImageLogo"].DataPropertyName = "ImageLogo";
                    G2DGV_Products.Columns["ProductName"].DataPropertyName = "ProductName";
                    G2DGV_Products.Columns["ProductPrice"].DataPropertyName = "ProductPrice";
                    G2DGV_Products.Columns["ProductQuantity"].DataPropertyName = "ProductQuantity";

                    // Format the ProductPrice column as currency with 2 decimal places, Pesos symbol, and comma for thousands
                    G2DGV_Products.Columns["ProductPrice"].DefaultCellStyle.Format = "₱#,##0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LBL_QS.BackColor = Color.Transparent;
        }

        private void G2TButton_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {

        }

        private void LBL_CartItems_Click(object sender, EventArgs e)
        {

        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
