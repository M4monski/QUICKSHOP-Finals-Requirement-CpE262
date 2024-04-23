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
    public partial class DeleteAdmin : Form
    {
        public DeleteAdmin()
        {
            InitializeComponent();
        }

        private void DeleteAdmin_Load(object sender, EventArgs e)
        {
            LBL_DELETEACCOUNT.BackColor = Color.Transparent;
        }

        private void But_DeleteBack_Click(object sender, EventArgs e)
        {
            ManageAccounts manage = new ManageAccounts();
            this.Hide();
        }

        private void But_DeleteAccount_Click(object sender, EventArgs e)
        {
            string username = Tbox_DeleteUser.Text;
            string password = Tbox_DeletePass.Text;
            string PIN = Tbox_DeletePIN.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM LOGIN_INFO WHERE Username = @Username AND Password = @Password AND SECURITYPIN = @PIN";

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, conn))
                    {
                        checkCommand.Parameters.AddWithValue("@Username", username);
                        checkCommand.Parameters.AddWithValue("@Password", password);
                        checkCommand.Parameters.AddWithValue("@PIN", PIN);

                        int existingUserCount = (int)checkCommand.ExecuteScalar();

                        if (existingUserCount == 0)
                        {
                            MessageBox.Show("Incorrect username, password, or PIN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this admin account?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string deleteQuery = "DELETE FROM LOGIN_INFO WHERE Username = @Username";

                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, conn))
                        {
                            deleteCommand.Parameters.AddWithValue("@Username", username);
                            int rowsAffected = deleteCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Admin account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Tbox_DeleteUser.Clear();
                                Tbox_DeletePass.Clear();
                                Tbox_DeletePIN.Clear();
                                refresh();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete admin account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        Tbox_DeleteUser.Clear();
                        Tbox_DeletePass.Clear();
                        Tbox_DeletePIN.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void refresh()
        {
            try
            {
                // Get reference to the DisplayAdmins form
                DisplayAdmins displayAdminsForm = Application.OpenForms["DisplayAdmins"] as DisplayAdmins;

                if (displayAdminsForm != null)
                {
                    // Access the DataGridView DGV_Admins from the DisplayAdmins form
                    DataGridView dgvAdmins = displayAdminsForm.DGV_Admins;

                    using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                    {
                        string query = "SELECT Username, Password, SECURITYPIN FROM LOGIN_INFO WHERE ID IS NOT NULL";

                        // Create a SqlDataAdapter to fetch data from the database
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                        // Create a DataTable to hold the retrieved data
                        DataTable data = new DataTable();

                        // Fill the DataTable with data from the database using the SqlDataAdapter
                        adapter.Fill(data);

                        // Bind the DataTable to the DataGridView in the DisplayAdmins form
                        dgvAdmins.DataSource = data;
                    }
                }
                else
                {
                    MessageBox.Show("DisplayAdmins form not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
