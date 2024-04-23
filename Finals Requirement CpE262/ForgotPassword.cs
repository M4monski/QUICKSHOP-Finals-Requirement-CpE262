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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void But_FPASSBACK_Click(object sender, EventArgs e)
        {
            AdminLogin admin = new AdminLogin();
            admin.Show();
            this.Hide();
        }

        private void BUT_CHANGEPASS_Click(object sender, EventArgs e)
        {
            string username = Tbox_FPASSUSER.Text;
            string newPassword = Tbox_FPASSPASS.Text;
            string pin = Tbox_FPASSPIN.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(pin))
            {
                MessageBox.Show("Please enter both username, new password, and PIN.");
                Tbox_FPASSUSER.Clear();
                Tbox_FPASSPASS.Clear();
                Tbox_FPASSPIN.Clear();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    conn.Open();

                    // Check if the PIN is correct
                    string pinQuery = "SELECT COUNT(*) FROM LOGIN_INFO WHERE Username = @Username AND SECURITYPIN = @Pin";
                    using (SqlCommand pinCommand = new SqlCommand(pinQuery, conn))
                    {
                        pinCommand.Parameters.AddWithValue("@Username", username);
                        pinCommand.Parameters.AddWithValue("@Pin", pin);

                        int pinCount = (int)pinCommand.ExecuteScalar();

                        if (pinCount == 0)
                        {
                            MessageBox.Show("Incorrect Details.");
                            Tbox_FPASSUSER.Clear();
                            Tbox_FPASSPASS.Clear();
                            Tbox_FPASSPIN.Clear();
                            return;
                        }
                    }

                    // Prepare the SQL query with parameters to prevent SQL injection
                    string query = "UPDATE LOGIN_INFO SET Password = @NewPassword WHERE Username = @Username";

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@NewPassword", newPassword);
                        command.Parameters.AddWithValue("@Username", username);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            AdminLogin login = new AdminLogin();
                            MessageBox.Show("Password updated successfully.");
                            this.Hide();
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show("Username not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            LBL_FPASS.BackColor = Color.Transparent;
            LBL_FPASSNEW.BackColor = Color.Transparent;
            LBL_FPASSPIN.BackColor = Color.Transparent;
            LBL_FPASSUSER.BackColor = Color.Transparent;
        }
    }
}
