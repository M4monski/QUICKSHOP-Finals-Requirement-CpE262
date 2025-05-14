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
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }

        public ManageAccounts ManageAccounts
        {
            get => default;
            set
            {
            }
        }

        private void But_AddBack_Click(object sender, EventArgs e)
        {
            ManageAccounts manage = new ManageAccounts();
            manage.Show();
            this.Hide();
        }

        private void But_AddAccount_Click(object sender, EventArgs e)
        {
            string username = Tbox_AddUser.Text;
            string password = Tbox_AddPass.Text;
            string pin = Tbox_AddPIN.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    conn.Open();

                    // Check if the username already exists
                    string checkQuery = "SELECT COUNT(*) FROM LOGIN_INFO WHERE Username = @Username";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, conn))
                    {
                        checkCommand.Parameters.AddWithValue("@Username", username);
                        int existingUserCount = (int)checkCommand.ExecuteScalar();

                        if (existingUserCount > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO LOGIN_INFO (Username, Password, SECURITYPIN) VALUES (@Username, @Password, @Pin)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
                    {
                        insertCommand.Parameters.AddWithValue("@Username", username);
                        insertCommand.Parameters.AddWithValue("@Password", password);
                        insertCommand.Parameters.AddWithValue("@Pin", pin);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Admin account added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Tbox_AddUser.Clear();
                            Tbox_AddPass.Clear();
                            Tbox_AddPIN.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add admin account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void G2But_ViewPass_Click(object sender, EventArgs e)
        {
            Tbox_AddPass.UseSystemPasswordChar = !Tbox_AddPass.UseSystemPasswordChar;
        }

        private void G2But_ViewPin_Click(object sender, EventArgs e)
        {
            Tbox_AddPIN.UseSystemPasswordChar = !Tbox_AddPIN.UseSystemPasswordChar;
        }
    }
}