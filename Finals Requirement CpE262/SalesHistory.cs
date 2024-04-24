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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Finals_Requirement_CpE262
{
    public partial class SalesHistory : Form
    {
        public SalesHistory()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
        }

        private void But_LoadSales_Click(object sender, EventArgs e)
        {
            if (G2CRB_SalesToday.Checked)
            {
                // Get today's date
                DateTime today = DateTime.Now.Date;
                // Connect to your database and fetch sales data for today
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    string query = "SELECT * FROM SalesHistory WHERE CONVERT(date, DateOfSale) = @TodayDate";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@TodayDate", today);

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable salesData = new DataTable();
                        salesData.Load(reader);

                        // Bind the fetched data to your DataGridView
                        G2DGV_SalesHistory.DataSource = salesData;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching sales data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (G2CRB_LifetimeSales.Checked)
            {
                refresh();
            }

            if (G2CBox_Year.SelectedItem != null)
            {
                int year = int.Parse(G2CBox_Year.Text);

                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    string query = "SELECT * FROM SalesHistory WHERE YEAR(DateOfSale) = @ChosenYear";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@ChosenYear", year);

                    try
                    {
                        conn.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable salesData = new DataTable();
                        salesData.Load(reader);

                        // Bind the fetched data to your DataGridView
                        G2DGV_SalesHistory.DataSource = salesData;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching sales data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (G2CBox_Year.SelectedItem != null && G2Cbox_Month.SelectedItem != null)
                {
                    string monthName = G2Cbox_Month.Text; // Get the selected month name from the combo box
                    int month = GetMonthNumber(monthName); // Convert the month name to its corresponding number

                    using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                    {
                        string query = "SELECT * FROM SalesHistory WHERE YEAR(DateOfSale) = @ChosenYear AND MONTH(DateOfSale) = @ChosenMonth";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@ChosenYear", year);
                        command.Parameters.AddWithValue("@ChosenMonth", month);

                        try
                        {
                            conn.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            DataTable salesData = new DataTable();
                            salesData.Load(reader);

                            // Bind the fetched data to your DataGridView
                            G2DGV_SalesHistory.DataSource = salesData;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error fetching sales data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (G2CBox_Year.SelectedItem != null && G2Cbox_Month.SelectedItem != null && G2Cbox_Week.SelectedItem != null)
                    {
                        string week = G2Cbox_Week.Text;
                        int startDay, endDay;

                        // Determine the start and end day based on the selected week
                        switch (week)
                        {
                            case "1st (1-7)":
                                startDay = 1;
                                endDay = 7; // Include the 1st day of the next week
                                break;
                            case "2nd (8-16)":
                                startDay = 8;
                                endDay = 16; // Include the 16th day of the next week
                                break;
                            case "3rd (17-24)":
                                startDay = 17;
                                endDay = 24; // Include the 24th day of the next week
                                break;
                            case "4th (25-31)":
                                startDay = 25;
                                endDay = DateTime.DaysInMonth(year, month); // Include the last day of the month
                                break;
                            default:
                                // Handle invalid selection or default case
                                MessageBox.Show("Invalid week selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }

                        using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                        {
                            string query = "SELECT * FROM SalesHistory WHERE YEAR(DateOfSale) = @ChosenYear AND MONTH(DateOfSale) = @ChosenMonth AND DAY(DateOfSale) >= @StartDay AND DAY(DateOfSale) <= @EndDay";
                            SqlCommand command = new SqlCommand(query, conn);
                            command.Parameters.AddWithValue("@ChosenYear", year);
                            command.Parameters.AddWithValue("@ChosenMonth", month);
                            command.Parameters.AddWithValue("@StartDay", startDay);
                            command.Parameters.AddWithValue("@EndDay", endDay);

                            try
                            {
                                conn.Open();
                                SqlDataReader reader = command.ExecuteReader();
                                DataTable salesData = new DataTable();
                                salesData.Load(reader);

                                // Bind the fetched data to your DataGridView
                                G2DGV_SalesHistory.DataSource = salesData;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error fetching sales data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }
        private int GetMonthNumber(string monthName)
        {
            switch (monthName.ToLower())
            {
                case "january":
                    return 1;
                case "february":
                    return 2;
                case "march":
                    return 3;
                case "april":
                    return 4;
                case "may":
                    return 5;
                case "june":
                    return 6;
                case "july":
                    return 7;
                case "august":
                    return 8;
                case "september":
                    return 9;
                case "october":
                    return 10;
                case "november":
                    return 11;
                case "december":
                    return 12;
                default:
                    throw new ArgumentException("Invalid month name.");
            }
        }

        private void But_Back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }

        private void But_DeleteSalesRecord_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
                {
                    string query = "DELETE FROM SalesHistory WHERE ReceiptID = @Receiptid";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Receiptid", G2DGV_SalesHistory.CurrentRow.Cells[8].Value);

                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();

                    refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refresh()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\CPELOGIN;Initial Catalog=LOGIN;Integrated Security=True"))
            {
                string query = "SELECT * FROM SalesHistory";
                SqlCommand command = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable salesData = new DataTable();
                    salesData.Load(reader);

                    // Bind the fetched data to your DataGridView
                    G2DGV_SalesHistory.DataSource = salesData;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching sales data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void But_ClearSearchFilters_Click(object sender, EventArgs e)
        {
            G2Cbox_Month.SelectedItem = null;
            G2Cbox_Week.SelectedItem = null;
            G2CBox_Year.SelectedItem = null;

            G2CRB_LifetimeSales.Checked = false;
            G2CRB_SalesToday.Checked = false;

            G2DGV_SalesHistory.DataSource = null;
            G2DGV_SalesHistory.Columns.Clear();
            Lbl_DataGrossSales.Text = string.Empty;
        }

        private void SalesHistory_Load(object sender, EventArgs e)
        {
            label7.BackColor = Color.Transparent;
            Lbl_GrossSales.BackColor = Color.Transparent;
            Lbl_DataGrossSales.BackColor = Color.Transparent;
        }

        private void But_GenerateSalesReport_Click(object sender, EventArgs e)
        {
            Lbl_DataGrossSales.Text = CalculateTotalSales().ToString("₱" + "#,##0.00");
        }

        private decimal CalculateTotalSales() //calculate katong total sales
        {
            decimal totalSales = 0;

            foreach (DataGridViewRow row in G2DGV_SalesHistory.Rows)
            {
                try
                {
                    // Check if the cell in the TotalCost column is not empty and can be converted to a decimal
                    if (row.Cells["TotalCost"].Value != null && decimal.TryParse(row.Cells["TotalCost"].Value.ToString(), out decimal cost))
                    {
                        totalSales += cost;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error calculating total sales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return totalSales;
        }
    }
}
