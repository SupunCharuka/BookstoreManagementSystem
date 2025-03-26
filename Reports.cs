using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace BookstoreManagementSystem
{
    public partial class Reports : Form
    {
        private string con = "datasource=localhost;port=3306;username=root;password=;database=BookHavenDB";
        public Reports()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            LoadSalesReport();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabSalesReport)
            {
                LoadSalesReport();
            }
            else if (tabControl1.SelectedTab == tabOrderReport)
            {
                LoadOrderReport();
            }
        }

        private void LoadSalesReport()
        {
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                string query = @"
        SELECT 
            DATE_FORMAT(s.sale_date, '%Y-%m-%d %H:%i') AS 'Date',
            c.CustomerName AS 'Customer',
            u.Username AS 'Cashier',
            COUNT(si.id) AS 'Items',
            s.total_amount AS 'Subtotal',
            s.discount AS 'Discount %',
            s.final_amount AS 'Total',
            s.payment_method AS 'Payment Method'
        FROM sales s
        LEFT JOIN customers c ON s.customer_id = c.id
        LEFT JOIN users u ON s.user_id = u.id
        LEFT JOIN sale_items si ON si.sale_id = s.id
        WHERE s.sale_date BETWEEN @startDate AND @endDate
        GROUP BY s.id
        ORDER BY s.sale_date DESC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@startDate", dtpStartDate.Value.ToString("yyyy-MM-dd HH:mm"));
                    cmd.Parameters.AddWithValue("@endDate", dtpEndDate.Value.ToString("yyyy-MM-dd HH:mm"));

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSalesReport.DataSource = dt;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) => PrintReportPage(ev);

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();
        }

        private void PrintReportPage(PrintPageEventArgs ev)
        {
            Graphics g = ev.Graphics;
            Font headerFont = new Font("Segoe UI", 18, FontStyle.Bold);
            Font subHeaderFont = new Font("Segoe UI", 12);
            Font bodyFont = new Font("Segoe UI", 10);

            int startX = 50;
            int startY = 50;
            int offset = 30;

            // Print header
            g.DrawString("BOOKHAVEN SALES REPORT", headerFont, Brushes.Navy, startX, startY);
            startY += offset;

            // Print date range
            g.DrawString($"Period: {dtpStartDate.Value:d} to {dtpEndDate.Value:d}",
                        subHeaderFont, Brushes.Black, startX, startY);
            startY += offset;

            // Create table for printing
            DataTable dt = (DataTable)dgvSalesReport.DataSource;
            if (dt != null && dt.Rows.Count > 0)
            {
                // Print column headers
                int columnWidth = 100;
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    g.DrawString(dt.Columns[i].ColumnName,
                                new Font(bodyFont, FontStyle.Bold),
                                Brushes.Black,
                                startX + (i * columnWidth), startY);
                }
                startY += offset / 2;

                // Print rows
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        g.DrawString(row[i].ToString(),
                                    bodyFont,
                                    Brushes.Black,
                                    startX + (i * columnWidth), startY);
                    }
                    startY += offset / 2;
                }

                // Print summary
                decimal totalSales = dt.AsEnumerable()
                    .Sum(row => row.Field<decimal>("Total"));

                g.DrawString($"Total Sales: {totalSales.ToString("C")}",
                            new Font(bodyFont, FontStyle.Bold),
                            Brushes.Navy,
                            startX, startY + offset);
            }
            else
            {
                g.DrawString("No sales data available", subHeaderFont, Brushes.Red, startX, startY);
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadOrderReport();
        }

        private void LoadOrderReport()
        {
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                string query = @"
            SELECT 
                DATE_FORMAT(o.OrderDate, '%Y-%m-%d %H:%i') AS 'Date',
                c.CustomerName AS 'Customer',
                COUNT(oi.Id) AS 'Items',
                o.TotalAmount AS 'Total Amount',
                o.PaymentStatus AS 'Payment Status',
                o.DeliveryOption AS 'Delivery Option'
            FROM Orders o
            LEFT JOIN Customers c ON o.CustomerId = c.Id
            LEFT JOIN OrderItems oi ON oi.OrderId = o.Id
            WHERE o.OrderDate BETWEEN @startDate AND @endDate
            GROUP BY o.Id
            ORDER BY o.OrderDate DESC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@startDate", dtpOrderStartDate.Value.ToString("yyyy-MM-dd HH:mm"));
                    cmd.Parameters.AddWithValue("@endDate", dtpOrderEndDate.Value.ToString("yyyy-MM-dd HH:mm"));

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvOrderReport.DataSource = dt;
                }
            }
        }

        private void btnPrintOrder_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) => PrintOrderReportPage(ev);

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();
        }

        private void PrintOrderReportPage(PrintPageEventArgs ev)
        {
            Graphics g = ev.Graphics;
            Font headerFont = new Font("Segoe UI", 18, FontStyle.Bold);
            Font subHeaderFont = new Font("Segoe UI", 12);
            Font bodyFont = new Font("Segoe UI", 10);

            int startX = 50;
            int startY = 50;
            int offset = 30;

            // Print header
            g.DrawString("BOOKHAVEN ORDER REPORT", headerFont, Brushes.Navy, startX, startY);
            startY += offset;

            // Print date range
            g.DrawString($"Period: {dtpOrderStartDate.Value:d} to {dtpOrderEndDate.Value:d}",
                        subHeaderFont, Brushes.Black, startX, startY);
            startY += offset;

            // Create table for printing
            DataTable dt = (DataTable)dgvOrderReport.DataSource;
            if (dt != null && dt.Rows.Count > 0)
            {
                // Print column headers
                int columnWidth = 120;
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    g.DrawString(dt.Columns[i].ColumnName,
                                new Font(bodyFont, FontStyle.Bold),
                                Brushes.Black,
                                startX + (i * columnWidth), startY);
                }
                startY += offset / 2;

                // Print rows
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        g.DrawString(row[i].ToString(),
                                    bodyFont,
                                    Brushes.Black,
                                    startX + (i * columnWidth), startY);
                    }
                    startY += offset / 2;
                }

                // Print summary
                decimal totalOrders = dt.AsEnumerable()
                    .Sum(row => row.Field<decimal>("Total Amount"));

                g.DrawString($"Total Order Amount: {totalOrders.ToString("C")}",
                            new Font(bodyFont, FontStyle.Bold),
                            Brushes.Navy,
                            startX, startY + offset);
            }
            else
            {
                g.DrawString("No order data available", subHeaderFont, Brushes.Red, startX, startY);
            }
        }
    }
}
