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
    public partial class SalesDashboard : Form
    {
        private string con = "datasource=localhost;port=3306;username=root;password=;database=BookHavenDB";
        public SalesDashboard()
        {
            InitializeComponent();

        }

        private void SalesDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardCounts();
            lblUsername.Text = UserSession.Username;
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                       "Confirm Logout",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clear session data
                ClearUserSession();

                // Show login form
                ShowLoginForm();

                // Close current dashboard
                this.Close();
            }
        }

        private void ClearUserSession()
        {
            UserSession.CurrentUserId = 0;
            UserSession.Username = null;
            UserSession.Role = null;
        }

        private void ShowLoginForm()
        {
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void booksBtn_Click(object sender, EventArgs e)
        {
            Books booksForm = new Books();
            booksForm.Show();
            this.Hide();
        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            Customers customersForm = new Customers();
            customersForm.Show();
            this.Hide();
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            Suppliers suppliersForm = new Suppliers();
            suppliersForm.Show();
            this.Hide();
        }

        private void ordersBtn_Click(object sender, EventArgs e)
        {
            Orders ordersForm = new Orders();
            ordersForm.Show();
            this.Hide();
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            Sales salesForm = new Sales();
            salesForm.Show();
            this.Hide();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "Admin")
            {
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                this.Hide();
            }
            else if (UserSession.Role == "SalesClerk")
            {
                SalesDashboard salesDashboard = new SalesDashboard();
                salesDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Unknown user role. Please contact support.",
                              "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Return to login
                Login login = new Login();
                login.Show();
            }
        }
    }
}
