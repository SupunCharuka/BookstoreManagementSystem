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
    public partial class Customers : Form
    {
        private string con = "datasource=localhost;port=3306;username=root;password=;database=BookHavenDB";
        public Customers()
        {
            InitializeComponent();
            SetupUIBasedOnRole();
        }
        private void SetupUIBasedOnRole()
        {
            if (UserSession.Role == "SalesClerk")
            {
                staffBtn.Visible = false;
                reportsBtn.Visible = false;
            }
        }

        private void LoadCustomers()
        {
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                conn.Open();
                string query = "SELECT * FROM Customers";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCustomers.DataSource = dt;
            }
        }
        private void button13_Click(object sender, EventArgs e)
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

        private void Customers_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Name and phone are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsPhoneExists(phone))
            {
                MessageBox.Show("Phone number already exists.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(con))
            {
                conn.Open();
                string query = "INSERT INTO Customers (CustomerName, Phone, Address) VALUES (@Name, @Phone, @Address)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomers();
                ResetForm();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["Id"].Value);
            string name = txtCustomerName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Name and phone are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsPhoneExists(phone, id))
            {
                MessageBox.Show("Phone number already exists.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(con))
            {
                conn.Open();
                string query = "UPDATE Customers SET CustomerName=@Name, Phone=@Phone, Address=@Address WHERE Id=@Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomers();
                ResetForm();
            }
        }

        private void brnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["Id"].Value);

            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(con))
                {
                    conn.Open();
                    string query = "DELETE FROM Customers WHERE Id=@Id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomers();
                    ResetForm();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtCustomerName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }
        private bool IsPhoneExists(string phone, int? excludeId = null)
        {
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                conn.Open();
                string query = excludeId == null
                    ? "SELECT COUNT(*) FROM Customers WHERE Phone = @Phone"
                    : "SELECT COUNT(*) FROM Customers WHERE Phone = @Phone AND Id != @Id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Phone", phone);
                if (excludeId != null)
                    cmd.Parameters.AddWithValue("@Id", excludeId);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void booksBtn_Click_1(object sender, EventArgs e)
        {
            Books booksForm = new Books();
            booksForm.Show();
            this.Hide();
        }

        private void customersBtn_Click_1(object sender, EventArgs e)
        {
            Customers customersForm = new Customers();
            customersForm.Show();
            this.Hide();
        }

        private void supplierBtn_Click_1(object sender, EventArgs e)
        {
            Suppliers suppliersForm = new Suppliers();
            suppliersForm.Show();
            this.Hide();
        }

        private void ordersBtn_Click_1(object sender, EventArgs e)
        {
            Orders ordersForm = new Orders();
            ordersForm.Show();
            this.Hide();
        }

        private void salesBtn_Click_1(object sender, EventArgs e)
        {
            Sales salesForm = new Sales();
            salesForm.Show();
            this.Hide();
        }

        private void staffBtn_Click_1(object sender, EventArgs e)
        {
            Users usersForm = new Users();
            usersForm.Show();
            this.Hide();
            
        }

        private void reportsBtn_Click_1(object sender, EventArgs e)
        {
            Reports reportsForm = new Reports();
            reportsForm.Show();
            this.Hide();

        }

        private void logoutBtn_Click_1(object sender, EventArgs e)
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
    }
}
