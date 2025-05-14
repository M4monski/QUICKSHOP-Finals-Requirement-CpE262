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
    public partial class CashierProductDetails : Form
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        public CashierProductDetails()
        {
            InitializeComponent();
        }

        public void SetProductDetails(string name, decimal price, int quantity)
        {
            ProductName = name;
            ProductPrice = price;
            ProductQuantity = quantity;
        }

        private void G2But_Back_Click(object sender, EventArgs e)
        {
            CashierShop test = new CashierShop();
            this.Hide();
            test.Show();
        }
        private void CashierProductDetails_Load(object sender, EventArgs e)
        {
            Lbl_TName.Text = ProductName;
            Lbl_TPrice.Text = ProductPrice.ToString("₱#,##0.00");
            Lbl_TQuant.Text = ProductQuantity.ToString();

            LBL_ProdName.BackColor = System.Drawing.Color.Transparent;
            Lbl_TName.BackColor = System.Drawing.Color.Transparent;
            LBL_ProdPrice.BackColor = System.Drawing.Color.Transparent;
            Lbl_TPrice.BackColor = System.Drawing.Color.Transparent;
            LBL_ProdDesc.BackColor = System.Drawing.Color.Transparent;
            Lbl_TDesc.BackColor = System.Drawing.Color.Transparent;
            LBL_ProdQuant.BackColor = System.Drawing.Color.Transparent;
            Lbl_TQuant.BackColor = System.Drawing.Color.Transparent;

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    string query = "SELECT ProductDescription, ImageLogo FROM Products WHERE ProductName = @ProductName";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@ProductName", ProductName);
                    conn.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Lbl_TDesc.Text = reader["ProductDescription"].ToString();
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
    }
}
