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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Finals_Requirement_CpE262
{
    public partial class Customer : Form
    {
        int ctr = 0;
        int temp = 0;
        public Customer()
        {
            InitializeComponent();
        }

        private void FLP_Products_Paint(object sender, PaintEventArgs e)
        {

        }

        private Panel currentlySelectedPanel; // Keep track of the currently selected panel

        private void CustomerTEST_Load(object sender, EventArgs e)
        {
            LBL_Browse.BackColor = Color.Transparent;
            refresh();
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            if (clickedPanel != null && clickedPanel != currentlySelectedPanel)
            {
                // If another panel is already selected, deselect it
                if (currentlySelectedPanel != null)
                {
                    currentlySelectedPanel.BackColor = Color.White; // Reset background color
                }

                // Update the currently selected panel
                currentlySelectedPanel = clickedPanel;

                // Change the appearance of the clicked panel to indicate selection
                clickedPanel.BackColor = SystemColors.ControlDark; // Change to a grayish color
                clickedPanel.BorderStyle = BorderStyle.Fixed3D; // Add a border to indicate the click

                // Perform any other actions when the panel is clicked
                // For example, you can get the product details associated with the clicked panel
                // and show them in a separate form or perform some other operation.
            }
        }

        private void G2TBut_SHOWMAIN_Click(object sender, EventArgs e)
        {
            MainUI main = new MainUI();
            this.Hide();
            main.Show();
        }

        private void G2TButton_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void G2But_ProdDet_Click(object sender, EventArgs e)
        {
            if (currentlySelectedPanel != null)
            {
                // Find the labels within the selected panel
                Label nameLabel = null;
                Label priceLabel = null;
                Label quantityLabel = null;

                foreach (Control control in currentlySelectedPanel.Controls)
                {
                    if (control is Label label)
                    {
                        if (label.Text.StartsWith("Name: "))
                        {
                            nameLabel = label;
                        }
                        else if (label.Text.StartsWith("Price: ₱"))
                        {
                            priceLabel = label;
                        }
                        else if (label.Text.StartsWith("In Stock: "))
                        {
                            quantityLabel = label;
                        }
                    }
                }

                if (nameLabel != null && priceLabel != null && quantityLabel != null)
                {
                    // Get the product details from the labels
                    string productName = nameLabel.Text.Replace("Name: ", "");
                    decimal productPrice = decimal.Parse(priceLabel.Text.Replace("Price: ₱", ""));
                    int productQuantity = int.Parse(quantityLabel.Text.Replace("In Stock: ", ""));

                    // Create an instance of ProductDetails form
                    ProductDetails deets = new ProductDetails();

                    // Pass the product details to the ProductDetails form
                    deets.SetProductDetails(productName, productPrice, productQuantity);

                    // Show the ProductDetails form
                    this.Hide();
                    deets.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Product details labels not found in the selected panel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a product to view details.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void G2TBut_Home_Click(object sender, EventArgs e)
        {
            /*
            if (currentlySelectedPanel != null)
            {
                currentlySelectedPanel.BackColor = Color.White; // Reset background color
                currentlySelectedPanel.BorderStyle = BorderStyle.FixedSingle; // Reset border style
                currentlySelectedPanel = null; // Reset currently selected panel
            }
            */
            refresh();
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

        private void G2TBox_Quantity_TextChanged(object sender, EventArgs e)
        {

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

        private void G2But_Browse_Click(object sender, EventArgs e)
        {
            FLP_Products.Controls.Clear();
            string searchKeyword = G2Tbox_Search.Text.Trim().ToLower(); // Normalize input and convert to lowercase
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "";
                    if (searchKeyword.Length == 1) // First Letter Match
                    {
                        query = "SELECT ImageLogo, ProductName, ProductPrice, ProductQuantity FROM Products WHERE LOWER(SUBSTRING(ProductName, 1, 1)) = @SearchKeyword";
                    }
                    else // Exact Match or Substring Match
                    {
                        query = "SELECT ImageLogo, ProductName, ProductPrice, ProductQuantity FROM Products WHERE LOWER(ProductName) LIKE '%' + @SearchKeyword + '%'";
                    }

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@SearchKeyword", searchKeyword);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Create a new panel for each row in the DataTable
                                Panel panel = new Panel();
                                panel.BorderStyle = BorderStyle.FixedSingle;
                                panel.Width = 213; // Set the width of the panel
                                panel.Height = 263; // Set the height of the panel
                                panel.BackColor = Color.White; // Set the background color to white

                                // Create a PictureBox to display the image
                                PictureBox pictureBox = new PictureBox();
                                pictureBox.Width = panel.Width;
                                pictureBox.Height = 120; // Set the height of the PictureBox
                                pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Set the SizeMode to Zoom
                                byte[] imageData = (byte[])reader["ImageLogo"]; // Assuming "ImageLogo" is the byte[] column in your DataTable
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    pictureBox.Image = Image.FromStream(ms);
                                }

                                // Create labels for product name, price, and quantity
                                Label nameLabel = new Label();
                                nameLabel.Text = "Name: " + reader["ProductName"].ToString();
                                nameLabel.Font = new Font("Inter", 9f, FontStyle.Regular);
                                nameLabel.AutoSize = false; // Set AutoSize to false
                                nameLabel.Width = panel.Width - 10; // Adjust the width to fit the panel
                                nameLabel.Height = 40; // Set a fixed height to accommodate wrapping
                                nameLabel.Location = new Point(5, 125); // Set the location below the PictureBox
                                nameLabel.TextAlign = ContentAlignment.TopLeft; // Align text to the top left

                                Label priceLabel = new Label();
                                decimal productPrice = Convert.ToDecimal(reader["ProductPrice"]);
                                priceLabel.Text = "Price: ₱" + productPrice.ToString("#,##0.00"); // Format price with commas and 2 decimal places
                                priceLabel.Font = new Font("Inter", 9f, FontStyle.Regular);
                                priceLabel.AutoSize = true;
                                priceLabel.Location = new Point(5, 170); // Set the location below the nameLabel

                                Label quantityLabel = new Label();
                                quantityLabel.Text = "In Stock: " + reader["ProductQuantity"].ToString();
                                quantityLabel.Font = new Font("Inter", 9f, FontStyle.Regular);
                                quantityLabel.AutoSize = true;
                                quantityLabel.Location = new Point(5, 195); // Set the location below the priceLabel

                                // Add the PictureBox and labels to the panel
                                panel.Controls.Add(pictureBox);
                                panel.Controls.Add(nameLabel);
                                panel.Controls.Add(priceLabel);
                                panel.Controls.Add(quantityLabel);

                                // Add the click event handler to the panel
                                panel.Click += Panel_Click;

                                // Add the panel to the FlowLayoutPanel (FLP_Products in your case)
                                FLP_Products.Controls.Add(panel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void G2But_AddCart_Click(object sender, EventArgs e)
        {
            if (currentlySelectedPanel != null)
            {
                // Find the labels and picture box within the selected panel
                Label nameLabel = null;
                Label priceLabel = null;
                Label quantityLabel = null;
                PictureBox pictureBox = null;

                foreach (Control control in currentlySelectedPanel.Controls)
                {
                    if (control is Label label)
                    {
                        if (label.Text.StartsWith("Name: "))
                        {
                            nameLabel = label;
                        }
                        else if (label.Text.StartsWith("Price: ₱"))
                        {
                            priceLabel = label;
                        }
                        else if (label.Text.StartsWith("In Stock: "))
                        {
                            quantityLabel = label;
                        }
                    }
                    else if (control is PictureBox pb)
                    {
                        pictureBox = pb;
                    }
                }

                if (nameLabel != null && priceLabel != null && quantityLabel != null && pictureBox != null)
                {
                    // Get the product details from the labels
                    string productName = nameLabel.Text.Replace("Name: ", "");
                    decimal productPrice = decimal.Parse(priceLabel.Text.Replace("Price: ₱", ""));
                    int productQuantity = int.Parse(quantityLabel.Text.Replace("In Stock: ", ""));

                    // Get the image data from the picture box
                    Image productImage = pictureBox.Image;
                    byte[] imageBytes = null;
                    if (productImage != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            productImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            imageBytes = ms.ToArray();
                        }
                    }

                    // Check if the entered quantity is valid
                    int quantityToAdd;
                    if (int.TryParse(G2TBox_Quantity.Text, out quantityToAdd))
                    {
                        if (quantityToAdd > 0 && quantityToAdd <= productQuantity)
                        {
                            try
                            {
                                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                                {
                                    conn.Open();

                                    // Check if the product already exists in the Cart table
                                    string checkQuery = "SELECT ProductQuantity FROM Cart WHERE ProductName = @ProductName";
                                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, conn))
                                    {
                                        checkCommand.Parameters.AddWithValue("@ProductName", productName);
                                        object existingQuantity = checkCommand.ExecuteScalar();

                                        if (existingQuantity != null && existingQuantity != DBNull.Value)
                                        {
                                            // Product exists in the cart, update the quantity
                                            int currentQuantity = (int)existingQuantity;
                                            int newQuantity = currentQuantity + quantityToAdd;

                                            string updateQuery = "UPDATE Cart SET ProductQuantity = @NewQuantity WHERE ProductName = @ProductName";
                                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, conn))
                                            {
                                                updateCommand.Parameters.AddWithValue("@NewQuantity", newQuantity);
                                                updateCommand.Parameters.AddWithValue("@ProductName", productName);
                                                updateCommand.ExecuteNonQuery();
                                            }
                                        }
                                        else
                                        {
                                            // Product doesn't exist in the cart, insert a new record
                                            string insertQuery = "INSERT INTO Cart (ProductName, ProductPrice, ProductQuantity, ImageLogo) VALUES (@ProductName, @ProductPrice, @ProductQuantity, @ImageLogo)";
                                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
                                            {
                                                insertCommand.Parameters.AddWithValue("@ProductName", productName);
                                                insertCommand.Parameters.AddWithValue("@ProductPrice", productPrice);
                                                insertCommand.Parameters.AddWithValue("@ProductQuantity", quantityToAdd);
                                                insertCommand.Parameters.AddWithValue("@ImageLogo", imageBytes);
                                                insertCommand.ExecuteNonQuery();
                                            }
                                        }
                                    }

                                    // Update the database with the new quantity
                                    string updateStockQuery = "UPDATE Products SET ProductQuantity = ProductQuantity - @QuantityToAdd WHERE ProductName = @ProductName";
                                    using (SqlCommand updateStockCommand = new SqlCommand(updateStockQuery, conn))
                                    {
                                        updateStockCommand.Parameters.AddWithValue("@QuantityToAdd", quantityToAdd);
                                        updateStockCommand.Parameters.AddWithValue("@ProductName", productName);
                                        updateStockCommand.ExecuteNonQuery();
                                    }

                                    MessageBox.Show("Product added to cart successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    refresh();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error adding product to cart: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid quantity that is less than or equal to the available stock.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Product details labels or image not found in the selected panel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a product to add to cart.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void G2TButt_ViewCart_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            this.Hide();
            cart.Show();
        }


        private void refresh()
        {
            FLP_Products.Controls.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    string query = "SELECT ImageLogo, ProductName, ProductPrice, ProductQuantity FROM Products";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    foreach (DataRow row in data.Rows)
                    {
                        // Create a new panel for each row in the DataTable
                        Panel panel = new Panel();
                        panel.BorderStyle = BorderStyle.FixedSingle;
                        panel.Width = 213; // Set the width of the panel
                        panel.Height = 263; // Set the height of the panel
                        panel.BackColor = Color.White; // Set the background color to white

                        // Create a PictureBox to display the image
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Width = panel.Width;
                        pictureBox.Height = 120; // Set the height of the PictureBox
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Set the SizeMode to Zoom
                        byte[] imageData = (byte[])row["ImageLogo"]; // Assuming "ImageLogo" is the byte[] column in your DataTable
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            pictureBox.Image = Image.FromStream(ms);
                        }

                        // Create labels for product name, price, and quantity
                        Label nameLabel = new Label();
                        nameLabel.Text = "Name: " + row["ProductName"].ToString();
                        nameLabel.Font = new Font("Inter", 9f, FontStyle.Regular);
                        nameLabel.AutoSize = false; // Set AutoSize to false
                        nameLabel.Width = panel.Width - 10; // Adjust the width to fit the panel
                        nameLabel.Height = 40; // Set a fixed height to accommodate wrapping
                        nameLabel.Location = new Point(5, 125); // Set the location below the PictureBox
                        nameLabel.TextAlign = ContentAlignment.TopLeft; // Align text to the top left

                        Label priceLabel = new Label();
                        priceLabel.Text = "Price: ₱" + Convert.ToDecimal(row["ProductPrice"]).ToString("#,##0.00");
                        priceLabel.Font = new Font("Inter", 9f, FontStyle.Regular);
                        priceLabel.AutoSize = true;
                        priceLabel.Location = new Point(5, 170); // Set the location below the nameLabel

                        Label quantityLabel = new Label();
                        if (row["ProductQuantity"].ToString() == "0")
                        {
                            quantityLabel.Text = "OUT OF STOCK";
                        }   
                        else
                        {
                            quantityLabel.Text = "In Stock: " + row["ProductQuantity"].ToString();
                        }
                        quantityLabel.Font = new Font("Inter", 9f, FontStyle.Regular);
                        quantityLabel.AutoSize = true;
                        quantityLabel.Location = new Point(5, 195); // Set the location below the priceLabel

                        // Add the PictureBox and labels to the panel
                        panel.Controls.Add(pictureBox);
                        panel.Controls.Add(nameLabel);
                        panel.Controls.Add(priceLabel);
                        panel.Controls.Add(quantityLabel);

                        // Add the click event handler to the panel
                        panel.Click += Panel_Click;

                        // Add the panel to the FlowLayoutPanel (FLP_Products in your case)
                        FLP_Products.Controls.Add(panel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
