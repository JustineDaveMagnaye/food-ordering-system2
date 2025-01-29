using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Food_Ordering_System.AdminPages
{
    public partial class Sales : UserControl
    {
        private string connectionString = "Server=localhost;Database=db_food_ordering_system;UserId=root;Password=jaydev;";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Sales()
        {
            InitializeComponent();
            PopulateSalesTable();
        }

        private void PopulateSalesTable()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = @"
            SELECT 
                e.full_name, 
                p.food_name,
                COUNT(s.product_id) AS quantity, 
                s.date, 
                s.time, 
                SUM(s.amount) AS total_amount
            FROM 
                tbl_sales s
            JOIN 
                tbl_product p ON s.product_id = p.product_id
            JOIN 
                tbl_account a ON s.account_id = a.account_id
            JOIN
                tbl_employee e ON s.account_id = e.account_id
            GROUP BY 
                e.full_name, p.food_name, s.date, s.time";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection))
                    {
                        tbl_sales.DataSource = null;
                        tbl_sales.Rows.Clear();
                        tbl_sales.Columns.Clear();
                        tbl_sales.BackgroundColor = Color.FromArgb(53, 70, 92);

                        DataTable salesDataTable = new DataTable();
                        adapter.Fill(salesDataTable);

                        tbl_sales.DataSource = salesDataTable;

                        // Customizing headers
                        tbl_sales.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 40, 45);
                        tbl_sales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        tbl_sales.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                        // Align header text
                        foreach (DataGridViewColumn column in tbl_sales.Columns)
                        {
                            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        }

                        // Rename column headers
                        tbl_sales.Columns["full_name"].HeaderText = "Employee";
                        tbl_sales.Columns["food_name"].HeaderText = "Product";
                        tbl_sales.Columns["quantity"].HeaderText = "Quantity";
                        tbl_sales.Columns["date"].HeaderText = "Date";
                        tbl_sales.Columns["time"].HeaderText = "Time";
                        tbl_sales.Columns["total_amount"].HeaderText = "Total Amount";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error populating sales table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void tbl_sales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
