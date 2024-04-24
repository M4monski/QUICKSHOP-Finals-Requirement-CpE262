using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals_Requirement_CpE262
{
    public partial class Checkout : Form
    {
        private static readonly RandomNumberGenerator rng = RandomNumberGenerator.Create();

        public Checkout()
        {
            InitializeComponent();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            Lbl_Payment.BackColor = Color.Transparent;
            Lbl_Total.BackColor = Color.Transparent;
            Lbl_CustName.BackColor = Color.Transparent;
            G2GBox_CardDetails.FillColor = Color.Transparent;
            G2GBox_CardDetails.BorderColor = Color.Transparent;

            label5.Text = CalculateTotalPrice().ToString("₱" + "#,##0.00");
            try
            {
                loadDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private decimal GetChange(decimal Payment, decimal Total)
        {
            decimal change = 0;
            change = Payment - Total;
            return change;
        }

        private static string GenerateInvoiceNumber()
        {
            byte[] bytes = new byte[8];
            rng.GetBytes(bytes);
            long invoiceNumber = BitConverter.ToInt64(bytes, 0);
            return $"{DateTime.Now:yyyyMMdd}-{invoiceNumber:X}";
        }


        private void G2But_ConfirmPayment_Click_1(object sender, EventArgs e) //Button
        {
            try
            {
                // Check if the DataGridView has any rows
                if (G2DGV_Products.Rows.Count > 1)
                {
                    if (G2IRB_Cash.Checked)
                    {
                        // Display the receipt for cash payment
                        if (GetChange(decimal.Parse(G2Tbox_Payment.Text), CalculateTotalPrice()) >= 0)
                        {
                            SaveReceiptToDatabase();

                            //ANG CODE NGA NAGHIMO SA PAPEL NA BUTANGAN SA RESIBO
                            printPreviewDialog1.Document = PrintReceipt;
                            PrintReceipt.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Receipt", 600, 800); // Adjusted paper size
                            printPreviewDialog1.ShowDialog();

                            ClearCartTable();
                        }
                        else
                        {
                            MessageBox.Show("Invalid payment amount.", "Invalid payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    if (G2IRB_Card.Checked)
                    {
                        string cardNumberInput = G2Tbox_CardNumber.Text.Trim().Replace(" ", "");
                        long cvv;
                        if (long.TryParse(cardNumberInput, out long cardNumber) && long.TryParse(G2Tbox_CVV.Text.Trim(), out cvv))
                        {
                            if (cardNumberInput.Length == 16)
                            {

                                if (G2Tbox_CVV.Text.Trim().Length == 3)
                                {
                                    if (G2Cbox_Month.SelectedItem != null && G2Cbox_Year.SelectedItem != null)
                                    {
                                        SaveReceiptToDatabase();

                                        printPreviewDialog1.Document = PrintReceipt; //printpreviewdialog1 is toolbox pud, and ang printrecipt tool
                                        PrintReceipt.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Receipt", 600, 800); // Adjusted paper size
                                        printPreviewDialog1.ShowDialog();

                                        ClearCartTable();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please select a month", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid card CVV", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid card number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numeric values for card number and CVV", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    // Cart is empty, display message or handle accordingly
                    MessageBox.Show("Your cart is empty. Please add products before confirming payment.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Please input valid card details", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PrintReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) //ANG CODE SA PAGSUWAT MISMO SA PAPEL ANG DETAILS BTW ADD PRINT DOCUMENT NA TOOLBOX AND AKO GINAME IS PrintReceipt
        {
            Graphics graphics = e.Graphics;
            Font headerFont = new Font("Inter", 18, FontStyle.Bold);
            Font itemFont = new Font("Inter", 12);
            float fontHeight = itemFont.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 20;  // Reduced spacing between QUICKSHOP header and store information
            string invoiceNumber = GenerateInvoiceNumber();

            // Get the width of the graphics area
            int graphicsWidth = e.PageBounds.Width;

            // Get the width of the text for header ("QUICKSHOP")
            SizeF headerTextSize = graphics.MeasureString("QUICKSHOP", headerFont);
            int headerTextWidth = (int)headerTextSize.Width;

            // Calculate the center position for header
            int centerXHeader = (graphicsWidth - headerTextWidth) / 2;

            // Draw centered header ("QUICKSHOP")
            graphics.DrawString("QUICKSHOP", headerFont, Brushes.Black, centerXHeader, startY);
            offset = offset + (int)fontHeight + 2;  // Adjusted vertical spacing

            // Draw store information
            string addressLine1 = "N. Bacalso Ave, Cebu City, 6000 Cebu";
            string contactInfo = "0927 576 7079 / keithharvey.angel@cit.edu";
            string currentDate = DateTime.Now.ToString();
            string invoiceID = $"Invoice ID: {invoiceNumber}";
            string customerName = "Customer: " + G2Tbox_CustName.Text.Trim();


            // Calculate the width of the longest line to determine the center position
            SizeF addressSize = graphics.MeasureString(addressLine1, itemFont);
            SizeF contactSize = graphics.MeasureString(contactInfo, itemFont);
            SizeF dateSize = graphics.MeasureString(currentDate, itemFont);
            SizeF invoiceSize = graphics.MeasureString(invoiceID, itemFont);

            // Calculate the center position for each line
            float centerXAddress = (graphicsWidth - addressSize.Width) / 2;
            float centerXContact = (graphicsWidth - contactSize.Width) / 2;
            float centerXDate = (graphicsWidth - dateSize.Width) / 2;
            float centerXInvoice = (graphicsWidth - invoiceSize.Width) / 2;

            // Draw centered store information lines
            graphics.DrawString(addressLine1, itemFont, Brushes.Black, centerXAddress, startY + offset);
            offset += (int)fontHeight + 2;  // Adjust vertical spacing

            graphics.DrawString(contactInfo, itemFont, Brushes.Black, centerXContact, startY + offset);
            offset += (int)fontHeight + 2;  // Adjust vertical spacing

            graphics.DrawString(invoiceID, itemFont, Brushes.Black, centerXInvoice, startY + offset);
            offset += (int)fontHeight + 2;  // Adjust vertical spacing

            graphics.DrawString(currentDate, itemFont, Brushes.Black, centerXDate, startY + offset);
            offset += (int)fontHeight + 2;  // Adjust vertical spacing

            // Draw Customer Name
            graphics.DrawString(customerName, itemFont, Brushes.Black, startX, startY + offset);
            offset += (int)fontHeight + 10;  // Adjust vertical spacing

            // Draw line separator ("-") after store information
            int lineY = startY + offset;
            graphics.DrawLine(Pens.Black, startX, lineY, graphicsWidth - startX, lineY);
            offset += 10;  // Adjusted vertical spacing after line

            // Draw item list headers
            string headers = "Item".PadRight(77) + "Price".PadRight(22) + "Quantity";
            graphics.DrawString(headers, itemFont, Brushes.Black, startX, startY + offset);
            offset = offset + (int)fontHeight + 5;  // Adjusted vertical spacing

            // Fetch data from Cart table
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    string query = "SELECT ProductName, ProductPrice, ProductQuantity FROM Cart";
                    SqlCommand command = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string itemName = reader["ProductName"].ToString();
                        string itemPrice = "₱" + Convert.ToDecimal(reader["ProductPrice"]).ToString("#,##0.00");
                        string itemQuantity = reader["ProductQuantity"].ToString();

                        // Draw itemName at a fixed position
                        graphics.DrawString(itemName, itemFont, Brushes.Black, startX, startY + offset);

                        // Draw itemPrice at 80 pixels from the left
                        graphics.DrawString(itemPrice, itemFont, Brushes.Black, startX + 375, startY + offset);

                        // Draw itemQuantity at 100 pixels from the left
                        graphics.DrawString(itemQuantity, itemFont, Brushes.Black, startX + 500, startY + offset);

                        offset = offset + (int)fontHeight;  // Move to the next line
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Draw line separator ("-") after store information
            lineY = startY + offset;
            graphics.DrawLine(Pens.Black, startX, lineY + 5, graphicsWidth - startX, lineY + 5);
            offset += 5;  // Adjusted vertical spacing after line

            // Calculate and draw total price
            decimal totalPrice = CalculateTotalPrice();

            if (G2IRB_Cash.Checked)
            {

                // Draw labels at startX + 325
                graphics.DrawString("Total Price:", itemFont, Brushes.Black, startX + 375, startY + offset + 20);
                graphics.DrawString("Cash          :", itemFont, Brushes.Black, startX + 375, startY + offset + 40);
                graphics.DrawString("Change     :", itemFont, Brushes.Black, startX + 375, startY + offset + 60);

                // Draw corresponding values at startX + 375
                graphics.DrawString(totalPrice.ToString("₱" + "#,##0.00"), itemFont, Brushes.Black, startX + 470, startY + offset + 20);
                graphics.DrawString(decimal.Parse(G2Tbox_Payment.Text).ToString("₱" + "#,##0.00"), itemFont, Brushes.Black, startX + 470, startY + offset + 40);
                graphics.DrawString(GetChange(decimal.Parse(G2Tbox_Payment.Text), CalculateTotalPrice()).ToString("₱" + "#,##0.00"), itemFont, Brushes.Black, startX + 470, startY + offset + 60);
            }

            if (G2IRB_Card.Checked)
            {
                // Draw labels at startX + 325
                graphics.DrawString("Total Price:", itemFont, Brushes.Black, startX + 375, startY + offset + 20);
                graphics.DrawString("Card          :", itemFont, Brushes.Black, startX + 375, startY + offset + 40);
                graphics.DrawString("Change     :", itemFont, Brushes.Black, startX + 375, startY + offset + 60);

                // Draw corresponding values at startX + 375
                graphics.DrawString(totalPrice.ToString("₱" + "#,##0.00"), itemFont, Brushes.Black, startX + 470, startY + offset + 20);
                graphics.DrawString(totalPrice.ToString("₱" + "#,##0.00"), itemFont, Brushes.Black, startX + 470, startY + offset + 40);
                graphics.DrawString(GetChange(totalPrice, CalculateTotalPrice()).ToString("₱" + "#,##0.00"), itemFont, Brushes.Black, startX + 470, startY + offset + 60);
            }
            string Gratitude = "~Thank you for shopping!~";
            string Storename = "~Quickshop~";

            // Calculate the width of the longest line to determine the center position
            SizeF GratitudeSize = graphics.MeasureString(Gratitude, itemFont);
            SizeF StorenameSize = graphics.MeasureString(Storename, itemFont);

            // Calculate the center position for each line
            float centerXGratitude = (graphicsWidth - GratitudeSize.Width) / 2;
            float centerYGratitude = startY + offset + 100; // Vertical centering

            float centerXStorename = (graphicsWidth - StorenameSize.Width) / 2;
            float centerYStorename = startY + offset + 120; // Vertical centering

            // Draw centered store information lines
            graphics.DrawString(Gratitude, itemFont, Brushes.Black, centerXGratitude, centerYGratitude);

            graphics.DrawString(Storename, itemFont, Brushes.Black, centerXStorename, centerYStorename);


        }


        private decimal CalculateTotalPrice() //calculate katong total price na makitan ha resibo
        {
            decimal totalPrice = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    string query = "SELECT SUM(ProductPrice * ProductQuantity) AS TotalPrice FROM Cart";
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

        private void loadDGV()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
            {
                string query = "SELECT ImageLogo, ProductName, ProductPrice, ProductQuantity FROM Cart";
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
        private void G2IRB_Cash_CheckedChanged(object sender, EventArgs e)
        {
            Lbl_Payment.Visible = true;
            G2Tbox_Payment.Visible = true;
            G2GBox_CardDetails.Visible = false;
        }

        private void G2IRB_Card_CheckedChanged(object sender, EventArgs e)
        {
            Lbl_Payment.Visible = false;
            G2Tbox_Payment.Visible = false;
            G2GBox_CardDetails.Visible = true;
        }

        private void printPreviewDialog1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void ClearCartTable()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    string query = "DELETE FROM Cart";
                    SqlCommand command = new SqlCommand(query, conn);

                    conn.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected <= 0)
                    {
                        MessageBox.Show("No items found in the cart.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing cart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SaveReceiptToDatabase()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    conn.Open();

                    string query = @"INSERT INTO SalesHistory (InvoiceNumber, ChosenProducts, Quantity, Price, TotalCost, DateOfSale, CustomerName)
                     VALUES (@InvoiceNumber, @ChosenProducts, @Quantity, @Price, @TotalCost, @DateOfSale, @CustomerName)";

                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@InvoiceNumber", GenerateInvoiceNumber());
                    command.Parameters.AddWithValue("@ChosenProducts", GetChosenProducts(conn).Trim()); // Trim the product names
                    command.Parameters.AddWithValue("@Quantity", GetProductQuantities(conn)); // Fetch quantities from Cart table
                    command.Parameters.AddWithValue("@Price", GetProductPrices(conn)); // Fetch prices from Cart table
                    command.Parameters.AddWithValue("@TotalCost", CalculateTotalPrice());
                    command.Parameters.AddWithValue("@DateOfSale", DateTime.Now);
                    command.Parameters.AddWithValue("@CustomerName", G2Tbox_CustName.Text.Trim());
                    //command.Parameters.AddWithValue("@CashierName", "YourCashierNameHere"); // You can set the cashier name dynamically

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected <= 0)
                    {
                        MessageBox.Show("Failed to save receipt details to database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving receipt details to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper methods to get product details from Cart table
        private string GetChosenProducts(SqlConnection conn)
        {
            string products = string.Empty;
            try
            {
                string query = "SELECT ProductName FROM Cart";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Trim each product name before appending to the string
                    string productName = reader["ProductName"].ToString().Trim();
                    products += productName + ", ";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching chosen products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return products.TrimEnd(',', ' '); // Trim any trailing comma and space
        }

        private string GetProductQuantities(SqlConnection conn)
        {
            string quantities = "";
            string query = "SELECT ProductQuantity FROM Cart";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                quantities += reader["ProductQuantity"].ToString() + ", ";
            }
            reader.Close();
            return quantities.TrimEnd(',', ' '); // Remove trailing comma and space
        }

        private string GetProductPrices(SqlConnection conn)
        {
            string prices = "";
            string query = "SELECT ProductPrice FROM Cart";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                prices += Convert.ToDecimal(reader["ProductPrice"]).ToString("#,##0.00") + ", "; // Format as currency
            }
            reader.Close();
            return prices.TrimEnd(',', ' '); // Remove trailing comma and space
        }

        private void G2TBut_Home_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void G2TButt_ViewCart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Hide();

        }

        private void G2TButton_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
