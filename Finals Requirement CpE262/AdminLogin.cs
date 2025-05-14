using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Input;

namespace Finals_Requirement_CpE262
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void Tbox_AdminUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tbox_AdminPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void LLBL_AdminFPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fpass = new ForgotPassword();
            fpass.Show();
            this.Hide();
        }

        private void But_AdminLOGIN_Click(object sender, EventArgs e)
        {
            string username = Tbox_AdminUser.Text;
            string password = Tbox_AdminPass.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    conn.Open();

                    string query = "SELECT * FROM LOGIN_INFO WHERE Username = @Username AND Password = @Password";

                    // Use one instance of SqlCommand
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dtable = new DataTable();
                        sda.Fill(dtable);

                        if (dtable.Rows.Count > 0)
                        {
                            Admin admin = new Admin();
                            admin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error: Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Tbox_AdminUser.Clear();
                            Tbox_AdminPass.Clear();
                            Tbox_AdminUser.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void But_ReturnLogin_Click(object sender, EventArgs e)
        {
            MainUI main = new MainUI();
            main.Show();
            this.Hide();
        }
        private void AdminLogin_Load(object sender, EventArgs e)
        {
            LBL_LOGIN.BackColor = Color.Transparent;
            LBL_HELLOADMIN.BackColor = Color.Transparent;
            LBL_USERNAME.BackColor = Color.Transparent;
            LBL_PASSWORD.BackColor = Color.Transparent;
            LLBL_AdminFPass.BackColor = Color.Transparent;
        }
        private void G2But_ViewPass_Click(object sender, EventArgs e)
        {
            Tbox_AdminPass.UseSystemPasswordChar = !Tbox_AdminPass.UseSystemPasswordChar;
        }
    }
}
