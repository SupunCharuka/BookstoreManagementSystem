using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookstoreManagementSystem
{
    public partial class Orders : Form
    {
        private string con = "datasource=localhost;port=3306;username=root;password=;database=BookHavenDB";
        private List<OrderItem> orderItems = new List<OrderItem>();
        public Orders()
        {
            InitializeComponent();
            LoadCustomers();
            LoadBooks();
            printDocument.PrintPage += printDocument1_PrintPage;

        }

        private void LoadCustomers()
        {
            string query = "SELECT Id, CustomerName FROM Customers";
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbCustomer.DataSource = dt;
                    cmbCustomer.DisplayMember = "CustomerName";
                    cmbCustomer.ValueMember = "Id";
                    cmbCustomer.SelectedIndex = -1;
                }
            }
        }

        private void LoadBooks()
        {
            string query = "SELECT BookID, Title, Author, Price FROM Books";
            using (MySqlConnection conn = new MySqlConnection(con))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    listBooks.DataSource = dt;
                    listBooks.DisplayMember = "Title";
                    listBooks.ValueMember = "BookID";
                    listBooks.SelectedIndex = -1;
                    lblAuthor.Text = "";
                    lblPrice.Text = "";

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void addBook_Click(object sender, EventArgs e)
        {
            if (listBooks.SelectedValue == null || string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Please select a book and enter a quantity.");
                return;
            }

            int bookId = (int)listBooks.SelectedValue;
            int quantity = int.Parse(txtQuantity.Text);
            decimal price = ((DataRowView)listBooks.SelectedItem)["Price"] as decimal? ?? 0;
            string bookTitle = ((DataRowView)listBooks.SelectedItem)["Title"] as string;
            string author = ((DataRowView)listBooks.SelectedItem)["Author"] as string;


            var orderItem = new OrderItem
            {
                BookId = bookId,
                BookTitle = bookTitle,
                Author = author,
                Quantity = quantity,
                Price = price
               
            };
            orderItems.Add(orderItem);

            UpdateOrderItemsGrid();
            CalculateTotal();

            listBooks.SelectedIndex = -1; 
            txtQuantity.Clear();
            lblAuthor.Clear();
            lblPrice.Clear();
        }

        private void UpdateOrderItemsGrid()
        {
            // Clear existing columns (if any)
            dgvOrderItems.Columns.Clear();

            // Bind the DataGridView to the orderItems list
            dgvOrderItems.DataSource = null;
            dgvOrderItems.DataSource = orderItems;

            // Customize the columns
            dgvOrderItems.Columns["BookId"].Visible = false; // Hide the BookId column
            dgvOrderItems.Columns["BookTitle"].HeaderText = "Book Title";
            dgvOrderItems.Columns["Author"].HeaderText = "Author";
            dgvOrderItems.Columns["Quantity"].HeaderText = "Qty";
            dgvOrderItems.Columns["Price"].HeaderText = "Price";
            dgvOrderItems.Columns["TotalPrice"].HeaderText = "Total Price";

            // Format the columns
            dgvOrderItems.Columns["Price"].DefaultCellStyle.Format = "N2";
            dgvOrderItems.Columns["TotalPrice"].DefaultCellStyle.Format = "N2";
        }

        private void CalculateTotal()
        {
           
            decimal total = orderItems.Sum(item => item.TotalPrice);
            txtTotalAmount.Text = total.ToString("N2");

        }

        private void saveOrder_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue == null || orderItems.Count == 0)
            {
                MessageBox.Show("Please select a customer and add at least one book.");
                return;
            }
            if (cmbPaymentStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a payment status.");
                return;
            }

            int customerId = (int)cmbCustomer.SelectedValue;
            decimal totalAmount = orderItems.Sum(item => item.TotalPrice);
            DateTime orderDate = DateTime.Now;

            // Save Order
            string orderQuery = $@"
            INSERT INTO Orders (CustomerId, OrderDate, TotalAmount, PaymentStatus)
            VALUES (@CustomerId, @OrderDate, @TotalAmount, @PaymentStatus);
            SELECT LAST_INSERT_ID();";

            int orderId = 0;

            using (MySqlConnection conn = new MySqlConnection(con))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(orderQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);
                    cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    cmd.Parameters.AddWithValue("@OrderDate", orderDate);
                    cmd.Parameters.AddWithValue("@PaymentStatus", cmbPaymentStatus.Text);
             

                    orderId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            // Save Order Items
            foreach (var item in orderItems)
            {
                string itemQuery = $@"
                INSERT INTO OrderItems (OrderId, BookId, Quantity, Price, TotalPrice)
                VALUES (@OrderId, @BookId, @Quantity, @Price, @TotalPrice)";

                using (MySqlConnection conn = new MySqlConnection(con))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(itemQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@OrderId", orderId);
                        cmd.Parameters.AddWithValue("@BookId", item.BookId);
                        cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                        cmd.Parameters.AddWithValue("@Price", item.Price);
                        cmd.Parameters.AddWithValue("@TotalPrice", item.TotalPrice);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Order saved successfully!");

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();

            ClearForm();
            listBooks.SelectedIndex = -1;
            txtQuantity.Clear();
            lblAuthor.Clear();
            lblPrice.Clear();
           
        }
        private void ClearForm()
        {
            orderItems.Clear();
            UpdateOrderItemsGrid();
            txtTotalAmount.Text = "0.00";
            cmbCustomer.SelectedIndex = -1;
            lblCustomerId.Clear();
            lblPhoneNumber.Clear();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void listBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBooks.SelectedItem != null)
            {
                // Get the selected item as a DataRowView
                DataRowView selectedRow = (DataRowView)listBooks.SelectedItem;

                // Display the author and price in labels or textboxes
                lblAuthor.Text = selectedRow["Author"].ToString();
                lblPrice.Text = selectedRow["Price"].ToString();
            }
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            cmbCustomer.SelectedIndex = -1;
            listBooks.SelectedIndex = -1;
            listBooks.SelectedIndexChanged += listBooks_SelectedIndexChanged;
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (dgvOrderItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to remove.");
                return;
            }

           
            var selectedRow = dgvOrderItems.SelectedRows[0];
            var selectedItem = (OrderItem)selectedRow.DataBoundItem;

           
            orderItems.Remove(selectedItem);

           
            UpdateOrderItemsGrid();
            CalculateTotal();
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue != null)
            {
                // Safely cast SelectedValue to int
                if (int.TryParse(cmbCustomer.SelectedValue.ToString(), out int customerId))
                {
                    string phoneNumber = GetCustomerPhoneNumber(customerId);

                    // Display the customer ID and phone number
                    lblCustomerId.Text = $"{customerId}";
                    lblPhoneNumber.Text = $"{phoneNumber}";
                }
                else
                {
                   
                }
            }
        }
        private string GetCustomerPhoneNumber(int customerId)
        {
            string phoneNumber = string.Empty;
            string query = "SELECT Phone FROM Customers WHERE Id = @CustomerId";

            using (MySqlConnection conn = new MySqlConnection(con))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);
                    phoneNumber = cmd.ExecuteScalar()?.ToString() ?? "N/A";
                }
            }

            return phoneNumber;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font titleFont = new Font("Arial", 24, FontStyle.Bold);
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 12);
            Font footerFont = new Font("Arial", 10, FontStyle.Italic);

            // Define brushes
            Brush brush = Brushes.Black;
            Brush accentBrush = new SolidBrush(Color.DarkBlue);

            // Define starting position
            int startX = 60;
            int startY = 60;
            int offset = 50;

            // Draw the title with a creative design
            e.Graphics.DrawString("BookHaven", titleFont, accentBrush, startX, startY);
            e.Graphics.DrawString("  Invoice", titleFont, brush, startX + 180, startY);
            startY += offset + 20;

            // Draw a horizontal line
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), startX, startY, startX + 500, startY);
            startY += offset;

            // Draw customer details
            e.Graphics.DrawString("Customer Details:", headerFont, accentBrush, startX, startY);
            startY += offset / 2;
            e.Graphics.DrawString($"Name: {cmbCustomer.Text}", bodyFont, brush, startX, startY);
            startY += offset / 2;
            e.Graphics.DrawString($"ID: {cmbCustomer.SelectedValue}", bodyFont, brush, startX, startY);
            startY += offset / 2;
            e.Graphics.DrawString($"Phone: {lblPhoneNumber.Text}", bodyFont, brush, startX, startY);
            startY += offset;

            // Draw a horizontal line
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), startX, startY, startX + 500, startY);
            startY += offset;

            // Draw order items header
            e.Graphics.DrawString("Order Items:", headerFont, accentBrush, startX, startY);
            startY += offset / 2;

            // Draw order items in a table-like format
            int column1X = startX; // Book Title
            int column2X = startX + 200; // Quantity
            int column3X = startX + 300; // Price
            int column4X = startX + 400; // Total

            // Draw table headers
            e.Graphics.DrawString("Book Title", bodyFont, accentBrush, column1X, startY);
            e.Graphics.DrawString("Qty", bodyFont, accentBrush, column2X, startY);
            e.Graphics.DrawString("Price", bodyFont, accentBrush, column3X, startY);
            e.Graphics.DrawString("Total", bodyFont, accentBrush, column4X, startY);
            startY += offset / 2;

            // Draw order items
            foreach (var item in orderItems)
            {
                e.Graphics.DrawString(item.BookTitle, bodyFont, brush, column1X, startY);
                e.Graphics.DrawString(item.Quantity.ToString(), bodyFont, brush, column2X, startY);
                e.Graphics.DrawString(item.Price.ToString("N2"), bodyFont, brush, column3X, startY);
                e.Graphics.DrawString(item.TotalPrice.ToString("N2"), bodyFont, brush, column4X, startY);
                startY += offset / 2;
            }

            // Draw a horizontal line
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), startX, startY, startX + 500, startY);
            startY += offset;

            // Draw total amount
            e.Graphics.DrawString($"Total Amount: {txtTotalAmount.Text}", headerFont, accentBrush, startX, startY);
            startY += offset / 2;

            // Draw payment status
            e.Graphics.DrawString($"Payment Status: {cmbPaymentStatus.Text}", headerFont, accentBrush, startX, startY);
            startY += offset;

            // Draw a horizontal line
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), startX, startY, startX + 500, startY);
            startY += offset;

            // Draw footer
            e.Graphics.DrawString("Thank you for shopping at BookHaven!", footerFont, brush, startX, startY);
            startY += offset / 2;
            e.Graphics.DrawString("Visit us again soon!", footerFont, brush, startX, startY);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public class OrderItem
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice => Quantity * Price;
    }
}
