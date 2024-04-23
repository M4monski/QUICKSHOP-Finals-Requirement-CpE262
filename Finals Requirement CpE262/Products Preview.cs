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
    public partial class Products_Preview : Form
    {
        public Products_Preview()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            LBL_ProdName.BackColor = Color.Transparent;
            LBL_ProdDesc.BackColor = Color.Transparent;
            LBL_ProdPrice.BackColor = Color.Transparent;
            LBL_ProdQuant.BackColor = Color.Transparent;
        }

        private void But_RefreshList_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    string query = "SELECT ProductName FROM Products";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    G2CBox_ProdNames.Items.Clear();

                    foreach (DataRow row in data.Rows)
                    {
                        G2CBox_ProdNames.Items.Add(row["ProductName"].ToString());
                    }

                    if (G2CBox_ProdNames.Items.Count == 0)
                    {
                        MessageBox.Show("No product names found in the database.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void But_ProdLoad_Click(object sender, EventArgs e)
        {
            if (G2CBox_ProdNames.SelectedItem != null)
            {
                string selectedProductName = G2CBox_ProdNames.SelectedItem.ToString();

                try
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                    {
                        string query = "SELECT ProductName, ProductDescription, ProductPrice, ProductQuantity, ImageLogo FROM Products WHERE ProductName = @ProductName";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@ProductName", selectedProductName);
                        conn.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            // Display product details in labels
                            label1.Text = reader["ProductName"].ToString();
                            label2.Text = reader["ProductDescription"].ToString();

                            decimal productPrice = Convert.ToDecimal(reader["ProductPrice"]);
                            label3.Text = productPrice.ToString("F2");

                            label4.Text = reader["ProductQuantity"].ToString();

                            // Display product image in GunaUI PictureBox
                            byte[] imageData = (byte[])reader["ImageLogo"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                G2PB_ProductPic.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Product details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a product from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void But_Back_Click(object sender, EventArgs e)
        {
            AddProduct add = new AddProduct();
            this.Hide();
            add.Show();
        }

        private void Products_Preview_Load(object sender, EventArgs e)
        {

        }

        private void But_EBack_Click(object sender, EventArgs e)
        {
            ManageProducts manage = new ManageProducts();
            this.Hide();
            manage.Show();
        }
    }
}
