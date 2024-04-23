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
    public partial class ManageProducts : Form
    {
        int indexRow;
        public ManageProducts()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
        }

        private void But_ELoadProducts_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    string query = "SELECT ProdID, ProductName, ProductDescription, ProductPrice, ProductQuantity FROM Products";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    G2DGV_EProducts.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void But_ViewPhotos_Click(object sender, EventArgs e)
        {
            Products_Preview prod = new Products_Preview();
            this.Hide();
            prod.Show();
        }

        private void But_Back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }

        List<byte[]> imageDataList = new List<byte[]>();
        private void IButton_EInsertPhoto_Click(object sender, EventArgs e)
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

        private void G2DGV_EProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = G2DGV_EProducts.Rows[indexRow];
            G2Tbox_IDnum.Text = row.Cells[0].Value.ToString();
            G2Tbox_EProdName.Text = row.Cells[1].Value.ToString();
            RTB_EProdDesc.Text = row.Cells[2].Value.ToString();
            G2Tbox_EProdPrice.Text = row.Cells[3].Value.ToString();
            G2Tbox_EProdQuant.Text = row.Cells[4].Value.ToString();
        }

        private void But_UpdateProd_Click(object sender, EventArgs e)
        {
            string prodname = G2Tbox_EProdName.Text;
            string proddesc = RTB_EProdDesc.Text;
            string prodprice = G2Tbox_EProdPrice.Text;
            string prodquant = G2Tbox_EProdQuant.Text;
            string ID = G2Tbox_IDnum.Text;
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    conn.Open();

                    // Check if the product already exists
                    string checkQuery = "SELECT COUNT(*) FROM Products WHERE ProdID = @ID";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, conn))
                    {
                        checkCommand.Parameters.AddWithValue("@ID", ID);
                        int existingProdCount = (int)checkCommand.ExecuteScalar();

                        if (existingProdCount > 0)
                        {
                            // Get the existing details from the DataGridView or pre-existing data
                            DataRowView selectedRow = (DataRowView)G2DGV_EProducts.SelectedRows[0].DataBoundItem;
                            
                            string existingName = selectedRow["ProductName"].ToString();
                            string existingDesc = selectedRow["ProductDescription"].ToString();
                            string existingPrice = selectedRow["ProductPrice"].ToString();
                            string existingQuant = selectedRow["ProductQuantity"].ToString();

                            // Use existing data if the corresponding textboxes are cleared
                            prodname = string.IsNullOrEmpty(prodname) ? existingName : prodname;
                            proddesc = string.IsNullOrEmpty(proddesc) ? existingDesc : proddesc;
                            prodprice = string.IsNullOrEmpty(prodprice) ? existingPrice : prodprice;
                            prodquant = string.IsNullOrEmpty(prodquant) ? existingQuant : prodquant;
                        }
                    }

                    // Update the product in the database
                    string updateQuery = "UPDATE Products SET ProductName = @ProdName,ProductDescription = @ProdDesc, ProductPrice = @ProdPrice, ProductQuantity = @ProdQuant";

                    // Check if there are images to be saved
                    if (imageDataList.Count > 0)
                    {
                        // Take the first image data from the list (you can modify this logic based on your requirements)
                        byte[] imageData = imageDataList[0];
                        updateQuery += ", ImageLogo = @ImageLogo"; // Include image update in the query
                    }

                    updateQuery += " WHERE ProdID = @ID";

                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, conn))
                    {
                        updateCommand.Parameters.AddWithValue("@ID", ID);
                        updateCommand.Parameters.AddWithValue("@ProdName", prodname);
                        updateCommand.Parameters.AddWithValue("@ProdDesc", proddesc);
                        updateCommand.Parameters.AddWithValue("@ProdPrice", prodprice);
                        updateCommand.Parameters.AddWithValue("@ProdQuant", prodquant);

                        // Add image parameter if imageDataList is not empty
                        if (imageDataList.Count > 0)
                        {
                            byte[] imageData = imageDataList[0];
                            updateCommand.Parameters.AddWithValue("@ImageLogo", (object)imageData);
                        }

                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product edited successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to edit product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


    }
}
