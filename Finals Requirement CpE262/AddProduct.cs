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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
        }

        private void But_Back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }

        private void But_LoadProducts_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    string query = "SELECT ProductName, ProductDescription, ProductPrice, ProductQuantity FROM Products";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    G2DGV_Products.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void G2DGV_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Define a list to store image data temporarily
        List<byte[]> imageDataList = new List<byte[]>();
        private void IButton_InsertPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files (*.*)|*.*";
            opf.Title = "Select Image Files";
            opf.Multiselect = true; // Allow selecting multiple files

            // Show OpenFileDialog and check if the user selected files
            if (opf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Loop through each selected file
                    foreach (string imagePath in opf.FileNames)
                    {
                        // Read the image file into an Image object
                        Image img = Image.FromFile(imagePath);

                        // Convert the Image to bytes
                        byte[] imageData;
                        using (MemoryStream ms = new MemoryStream())
                        {
                            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Change the format if needed
                            imageData = ms.ToArray();
                        }

                        // Add image data to the list
                        imageDataList.Add(imageData);
                    }

                    MessageBox.Show("Image selected and ready to be saved with the product!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void IButton_SaveProduct_Click(object sender, EventArgs e)
        {
            string prodname = G2Tbox_ProdName.Text;
            string proddesc = RTB_ProdDesc.Text;
            string prodprice = G2Tbox_ProdPrice.Text;
            string prodquant = G2Tbox_ProdQuant.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    conn.Open();

                    // Check if the product already exists
                    string checkQuery = "SELECT COUNT(*) FROM Products WHERE ProductName = @Prodname";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, conn))
                    {
                        checkCommand.Parameters.AddWithValue("@Prodname", prodname);
                        int existingUserCount = (int)checkCommand.ExecuteScalar();

                        if (existingUserCount > 0)
                        {
                            MessageBox.Show("Product already exists. Please add a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert the new product into the database
                    string insertQuery = "INSERT INTO Products (ProductName, ProductDescription, ProductPrice, ProductQuantity, ImageLogo) VALUES (@Prodname, @ProdDesc, @ProdPrice, @ProdQuant, @ImageLogo)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
                    {
                        insertCommand.Parameters.AddWithValue("@Prodname", prodname);
                        insertCommand.Parameters.AddWithValue("@ProdDesc", proddesc);
                        insertCommand.Parameters.AddWithValue("@ProdPrice", prodprice);
                        insertCommand.Parameters.AddWithValue("@ProdQuant", prodquant);

                        // Check if there are images to be saved
                        if (imageDataList.Count > 0)
                        {
                            // Take the first image data from the list (you can modify this logic based on your requirements)
                            byte[] imageData = imageDataList[0];
                            insertCommand.Parameters.AddWithValue("@ImageLogo", (object)imageData);
                        }
                        else
                        {
                            // If no images were selected, set the image parameter to null or an empty byte array as per your database schema
                            insertCommand.Parameters.AddWithValue("@ImageLogo", DBNull.Value);
                        }

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            G2Tbox_ProdName.Clear();
                            RTB_ProdDesc.Clear();
                            G2Tbox_ProdPrice.Clear();
                            G2Tbox_ProdQuant.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add Product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Clear the image data list after saving the product
            imageDataList.Clear();
        }

        private void But_ViewPhotos_Click(object sender, EventArgs e)
        {
            Products_Preview prod = new Products_Preview();
            this.Hide();
            prod.Show();
        }
    }
}
