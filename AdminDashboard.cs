using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookstoreManagementSystem
{
    public partial class AdminDashboard: Form
    {
        private string con = "datasource=localhost;port=3306;username=root;password=;database=BookHavenDB";
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void LoadDashboardCounts()
        {
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT (SELECT COUNT(*) FROM Books) AS TotalBooks,
                       (SELECT COUNT(*) FROM Customers) AS TotalCustomers,
                       (SELECT COUNT(*) FROM Users) AS TotalUsers,
                       (SELECT COUNT(*) FROM Sales) AS TotalSales,
                       (SELECT COUNT(*) FROM Sales) AS TotalSales,
                       (SELECT COUNT(*) FROM Orders) AS TotalOrders,
                       (SELECT COUNT(*) FROM Suppliers) AS TotalSuppliers;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblBookCount.Text = reader["TotalBooks"].ToString();
                                lblCustomerCount.Text = reader["TotalCustomers"].ToString();
                                lblUserCount.Text = reader["TotalUsers"].ToString();
                                lblSalesCount.Text = reader["TotalSales"].ToString();
                                lblOrderCount.Text = reader["TotalOrders"].ToString();
                                lblSupplierCount.Text = reader["TotalSuppliers"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading dashboard data: " + ex.Message);
                }
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardCounts();
            lblUsername.Text = UserSession.Username;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
