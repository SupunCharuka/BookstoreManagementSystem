﻿using System;
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
    public partial class Books : Form
    {
        private string con = "datasource=localhost;port=3306;username=root;password=;database=BookHavenDB";
       
        public Books()
        {
            InitializeComponent();
            LoadBooks();
            PopulateGenreComboBox();
            ClearFields();
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

        private void LoadBooks()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con))
                {
                    connection.Open();
                    string query = "SELECT BookID, Title, Author, Genre, ISBN, Price, StockQuantity FROM Books";
                 
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewBooks.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PopulateGenreComboBox()
        {
            // Add predefined genres to the ComboBox
            cmbGenre.Items.AddRange(new string[] { "Fiction", "Non-Fiction", "Mystery", "Science Fiction", "Fantasy", "Romance", "Thriller", "Biography", "History", "Self-Help" });
            cmbGenre.SelectedIndex = 0; // Set the default selected genre
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Users usersForm = new Users();
            usersForm.Show();
            this.Hide();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string genre = cmbGenre.SelectedItem.ToString(); 
            string isbn = txtISBN.Text.Trim();
            decimal price;
            int stockQuantity;

            // Validate inputs
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(isbn) || 
                !decimal.TryParse(txtPrice.Text, out price) || !int.TryParse(txtStockQuantity.Text, out stockQuantity))
            {
                MessageBox.Show("Please fill in all fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(genre) || cmbGenre.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a valid genre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                using (MySqlConnection conn = new MySqlConnection(con))
                {
                    conn.Open();
                    string query = "INSERT INTO Books (Title, Author, Genre, ISBN, Price, StockQuantity) VALUES (@Title, @Author, @Genre, @ISBN, @Price, @StockQuantity)";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Author", author);
                        command.Parameters.AddWithValue("@Genre", genre);
                        command.Parameters.AddWithValue("@ISBN", isbn);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@StockQuantity", stockQuantity);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBooks();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                int bookID = Convert.ToInt32(dataGridViewBooks.SelectedRows[0].Cells["BookID"].Value);
                string title = txtTitle.Text.Trim();
                string author = txtAuthor.Text.Trim();
                string genre = cmbGenre.SelectedItem.ToString();
                string isbn = txtISBN.Text.Trim();
                decimal price = decimal.Parse(txtPrice.Text);
                int stockQuantity = int.Parse(txtStockQuantity.Text);

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(con))
                    {
                        connection.Open();
                        string query = "UPDATE Books SET Title = @Title, Author = @Author, Genre = @Genre, ISBN = @ISBN, Price = @Price, StockQuantity = @StockQuantity WHERE BookID = @BookID";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Author", author);
                        command.Parameters.AddWithValue("@Genre", genre);
                        command.Parameters.AddWithValue("@ISBN", isbn);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@StockQuantity", stockQuantity);
                        command.Parameters.AddWithValue("@BookID", bookID);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadBooks();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                int bookID = Convert.ToInt32(dataGridViewBooks.SelectedRows[0].Cells["BookID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(con))
                        {
                            connection.Open();
                            string query = "DELETE FROM Books WHERE BookID = @BookID";
                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@BookID", bookID);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadBooks();
                                ClearFields();
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewBooks_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void ClearFields()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            cmbGenre.SelectedIndex = 0;
            txtISBN.Clear();
            txtPrice.Clear();
            txtStockQuantity.Clear();
        }

        private void Books_Load(object sender, EventArgs e)
        {

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

        private void booksBtn_Click_1(object sender, EventArgs e)
        {
            Books booksForm = new Books();
            booksForm.Show();
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

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewBooks.Rows[e.RowIndex];

                txtTitle.Text = row.Cells["Title"].Value?.ToString() ?? "";
                txtAuthor.Text = row.Cells["Author"].Value?.ToString() ?? "";
                cmbGenre.SelectedItem = row.Cells["Genre"].Value?.ToString() ?? null;
                txtISBN.Text = row.Cells["ISBN"].Value?.ToString() ?? "";
                txtPrice.Text = row.Cells["Price"].Value?.ToString() ?? "";
                txtStockQuantity.Text = row.Cells["StockQuantity"].Value?.ToString() ?? "";
            }
        }
    }
}
