using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookstoreManagementSystem
{
    public partial class Users : Form
    {
        private string con = "datasource=localhost;port=3306;username=root;password=;database=BookHavenDB";
        public Users()
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(con))
                {
                    conn.Open();
                    string query = "SELECT * FROM Users";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewUsers.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            // Basic validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(address) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if username or email already exists
            if (IsUserExists(username, email))
            {
                MessageBox.Show("Username or Email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsUsernameExists(username))
            {
                MessageBox.Show("Username already exists. Please choose a different username.",
                               "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Hash the password
            string hashedPassword = HashPassword(password);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(con))

                {
                    conn.Open();
                    string query = "INSERT INTO Users (Username, Phone, Email, Address, Password, Role) VALUES (@Username, @Phone, @Email, @Address, @Password, @Role)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    cmd.Parameters.AddWithValue("@Role", role);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();
                        ClearForm();


                    }
                    else
                    {
                        MessageBox.Show("Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool IsUserExists(string username, string email)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(con))
                {
                 conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username OR Email = @Email";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Email", email);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }

            }

            catch
            {
                return false;
            }
     
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private bool IsUsernameExists(string username)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(con))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            txtUsername.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            cmbRole.SelectedIndex = -1;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            // Basic validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(address) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsEmailDuplicate(email, username))
            {
                MessageBox.Show("Email is already used by another user.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var currentRow = dataGridViewUsers.CurrentRow;
            if (currentRow != null)
            {
                string originalUsername = currentRow.Cells["Username"].Value.ToString();
                if (username != originalUsername && IsUsernameExists(username))
                {
                    MessageBox.Show("Username already exists. Please choose a different username.",
                                  "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Hash the password
            string hashedPassword = string.IsNullOrEmpty(password) ? GetExistingPassword(username) : HashPassword(password); // Keep existing password if no new password provided.

            try

            {
                using (MySqlConnection conn = new MySqlConnection(con))
                {
                    conn.Open();
                    string query = "UPDATE Users SET Phone = @Phone, Email = @Email, Address = @Address, Password = @Password, Role = @Role WHERE Username = @Username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    cmd.Parameters.AddWithValue("@Role", role);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers(); // Reload the users into the DataGridView
                        ClearForm(); // Clear the form after successful update
                    }
                    else
                    {
                        MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool IsEmailDuplicate(string email, string username)
        {
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND Username != @Username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Username", username);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }


        private string GetExistingPassword(string username)
        {
            string existingPassword = string.Empty;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(con))
                {
                    conn.Open();
                    string query = "SELECT Password FROM Users WHERE Username = @Username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        existingPassword = reader["Password"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving existing password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            return existingPassword;
        }

        private string originalUsername = string.Empty;
        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUsers.Rows[e.RowIndex];
                originalUsername = row.Cells["Username"].Value.ToString();
                txtUsername.Text = originalUsername;
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                cmbRole.SelectedItem = row.Cells["Role"].Value.ToString();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim(); // Get the username from the text box

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please select a user to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(con))
                    {
                        conn.Open();
                        string query = "DELETE FROM Users WHERE Username = @Username";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Username", username);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUsers(); // Reload the users into the DataGridView
                            ClearForm(); // Clear the form after successful deletion
                        }
                        else
                        {
                            MessageBox.Show("Delete failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


      



  
            

        private void button14_Click(object sender, EventArgs e)
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
