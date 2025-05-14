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
    public partial class CashierCart : Form
    {
        int temp = 0;
        int ctr = 0;
        int indexRow;
        public CashierCart()
        {
            InitializeComponent();
        }

        public Checkout Checkout
        {
            get => default;
            set
            {
            }
        }

        private void CashierCart_Load(object sender, EventArgs e)
        {
            refresh();
            Lbl_CalcTotal.Text = CalculateTotalPrice().ToString("₱" + "#,##0.00");
            LBL_QS.BackColor = Color.Transparent;
            Lbl_CalcTotal.BackColor = Color.Transparent;
            Lbl_Total.BackColor = Color.Transparent;
            //G2TBut_CartLogo.BackColor = Color.Transparent;
        }

        private decimal CalculateTotalPrice() //calculate katong total price na makitan ha resibo
        {
            decimal totalPrice = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    string query = "SELECT SUM(ProductPrice * ProductQuantity) AS TotalPrice FROM CashierCart";
                    SqlCommand command = new SqlCommand(query, conn);
                    conn.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        totalPrice = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total price: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return totalPrice;
        }

        private void G2TBut_Home_Click(object sender, EventArgs e)
        {
            CashierShop admin = new CashierShop();
            this.Hide();
            admin.Show();
        }

        private void G2TButton_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void G2TBut_Less_Click(object sender, EventArgs e)
        {
            try
            {
                if (G2TBox_Quantity.Text == null)
                {
                    G2TBox_Quantity.Clear();
                }
                if (G2TBox_Quantity.Text == "1")
                {
                    G2TBox_Quantity.Clear();
                }
                else
                {
                    temp = int.Parse(G2TBox_Quantity.Text);
                    temp--;
                    G2TBox_Quantity.Text = temp.ToString();
                    temp = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error please input a valid quantity.", "WRONG INPUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                G2TBox_Quantity.Clear();
            }
        }

        private void G2TBut_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (G2TBox_Quantity.Text == "")
                {
                    ctr = 0;
                    ctr++;
                    G2TBox_Quantity.Text = ctr.ToString();
                }
                else
                {
                    temp = int.Parse(G2TBox_Quantity.Text);
                    temp++;
                    G2TBox_Quantity.Text = temp.ToString();
                    temp = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error please input a valid quantity.", "WRONG INPUT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                G2TBox_Quantity.Clear();
            }
        }

        private void G2DGV_Products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = G2DGV_Products.Rows[indexRow];
            G2TBox_Quantity.Text = row.Cells[2].Value.ToString();
        }

        private void G2But_RemoveCart_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the cart DataGridView
            if (G2DGV_Products.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = G2DGV_Products.SelectedRows[0];

                // Extract product information from the selected row
                string productName = selectedRow.Cells["ProductName"].Value.ToString();
                int removedQuantity = Convert.ToInt32(selectedRow.Cells["ProductQuantity"].Value);

                // Remove the selected row from the cart DataGridView
                G2DGV_Products.Rows.Remove(selectedRow);
                // Update the product stock in the Product table
                try
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                    {
                        conn.Open();
                        string updateQuery = "UPDATE Products SET ProductQuantity = ProductQuantity + @RemovedQuantity WHERE ProductName = @ProductName";
                        using (SqlCommand command = new SqlCommand(updateQuery, conn))
                        {
                            command.Parameters.AddWithValue("@RemovedQuantity", removedQuantity);
                            command.Parameters.AddWithValue("@ProductName", productName);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating product stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Delete the product in the Cart table
                try
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM CashierCart WHERE ProductName = @ProductName";
                        using (SqlCommand command = new SqlCommand(deleteQuery, conn))
                        {
                            command.Parameters.AddWithValue("@ProductName", productName);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting product from cart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Please select a product to remove from the cart.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void G2But_ChangeQuant_Click(object sender, EventArgs e)
        {
            if (G2DGV_Products.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = G2DGV_Products.SelectedRows[0];

                // Assuming the product name is in the second column (index 1) of the DataGridView
                string productName = selectedRow.Cells[1].Value.ToString();

                // Check if the new quantity is provided and valid
                if (int.TryParse(G2TBox_Quantity.Text, out int newQuantity))
                {
                    if (newQuantity >= 0)
                    {
                        UpdateCartItem(productName, newQuantity);
                    }
                    else
                    {
                        MessageBox.Show("Quantity must be a positive number.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a product from the cart.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void UpdateCartItem(string productName, int newQuantity)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    conn.Open();

                    // Retrieve the current quantity of the product in the cart
                    string selectCartQuery = "SELECT ProductQuantity FROM CashierCart WHERE ProductName = @ProductName";
                    using (SqlCommand selectCartCommand = new SqlCommand(selectCartQuery, conn))
                    {
                        selectCartCommand.Parameters.AddWithValue("@ProductName", productName);
                        object currentQuantityObj = selectCartCommand.ExecuteScalar();

                        if (currentQuantityObj != null && int.TryParse(currentQuantityObj.ToString(), out int currentQuantity))
                        {
                            // Calculate the difference in quantities
                            int quantityDifference = newQuantity - currentQuantity;

                            // Retrieve the current stock quantity of the product in the Product table
                            string selectProductQuery = "SELECT ProductQuantity FROM Products WHERE ProductName = @ProductName";
                            using (SqlCommand selectProductCommand = new SqlCommand(selectProductQuery, conn))
                            {
                                selectProductCommand.Parameters.AddWithValue("@ProductName", productName);
                                object productStockObj = selectProductCommand.ExecuteScalar();

                                if (productStockObj != null && int.TryParse(productStockObj.ToString(), out int productStock))
                                {
                                    // Check if subtracting the quantity difference would result in a negative stock
                                    if (productStock - quantityDifference >= 0)
                                    {
                                        // Update the quantity in the cart
                                        string updateCartQuery = "UPDATE CashierCart SET ProductQuantity = @NewQuantity WHERE ProductName = @ProductName";
                                        using (SqlCommand updateCartCommand = new SqlCommand(updateCartQuery, conn))
                                        {
                                            updateCartCommand.Parameters.AddWithValue("@NewQuantity", newQuantity);
                                            updateCartCommand.Parameters.AddWithValue("@ProductName", productName);
                                            updateCartCommand.ExecuteNonQuery();
                                        }

                                        // Update the stock in the Product table based on the adjusted quantity difference
                                        string updateProductQuery = "UPDATE Products SET ProductQuantity = ProductQuantity - @QuantityDifference WHERE ProductName = @ProductName";
                                        using (SqlCommand updateProductCommand = new SqlCommand(updateProductQuery, conn))
                                        {
                                            updateProductCommand.Parameters.AddWithValue("@QuantityDifference", quantityDifference);
                                            updateProductCommand.Parameters.AddWithValue("@ProductName", productName);
                                            updateProductCommand.ExecuteNonQuery();
                                        }

                                        MessageBox.Show("Cart updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Cannot add more quantity than available stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Product not found in the Product table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Product not found in cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating cart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refresh()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    string query = "SELECT ImageLogo, ProductName, ProductPrice, ProductQuantity FROM CashierCart";
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
        }

        private void G2But_Checkout_Click(object sender, EventArgs e)
        {
            CashierCheckout checkout = new CashierCheckout();
            this.Hide();
            checkout.Show();
        }
    }
}
