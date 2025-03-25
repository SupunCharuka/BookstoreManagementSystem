using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookstoreManagementSystem
{
    public partial class Sales : Form
    {
        private string con = "datasource=localhost;port=3306;username=root;password=;database=BookHavenDB";
        private List<SaleItem> saleItems = new List<SaleItem>();
        private decimal _totalBeforeDiscount = 0;
        private decimal _discountAmount = 0;
        public Sales()
        {
            InitializeComponent();
            LoadCustomers();
            LoadBooks();

            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
            listBooks.SelectedIndexChanged += listBooks_SelectedIndexChanged;
            btnRemoveBook.Click += btnRemoveBook_Click;
            printDocument.PrintPage += printDocument_PrintPage;

            txtUserInfo.Text = $"{UserSession.Username}";
            txtDate.Text = $"{DateTime.Now.ToString("dd/MM/yyyy")}";
        }

        private void LoadCustomers()
        {
            string query = "SELECT id, CustomerName FROM customers";
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
                    cmbCustomer.ValueMember = "id";
                    cmbCustomer.SelectedIndex = -1; // Clear selection
                }
            }
        }

        private void LoadBooks()
        {
            string query = "SELECT BookID, Title, Author, ISBN, Price FROM Books";
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
                    listBooks.SelectedIndex = -1; // Clear selection
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {
         
        }

        private void UpdateSaleItemsGrid()
        {
            dgvSaleItems.DataSource = null;
            dgvSaleItems.DataSource = saleItems;

            dgvSaleItems.Columns["BookTitle"].HeaderText = "Book Title";
            dgvSaleItems.Columns["ISBN"].HeaderText = "ISBN";
            dgvSaleItems.Columns["Quantity"].HeaderText = "Qty";
            dgvSaleItems.Columns["Price"].HeaderText = "Price";
            dgvSaleItems.Columns["Subtotal"].HeaderText = "Subtotal";


            // Format columns if needed
            dgvSaleItems.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
            dgvSaleItems.Columns["Price"].DefaultCellStyle.Format = "N2";
        }
       
        private void addSale_Click(object sender, EventArgs e)
        {
            if (saleItems.Count == 0)
            {
                MessageBox.Show("Please add at least one book to the sale.");
                return;
            }

            if (cmbPaymentMethod.SelectedItem == null)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            if (!decimal.TryParse(txtDiscount.Text, out decimal discount) || discount < 0 || discount > 100)
            {
                MessageBox.Show("Please enter a valid discount (0-100%).");
                return;
            }

            // Get values from form
            int? customerId = cmbCustomer.SelectedValue != null ? (int)cmbCustomer.SelectedValue : (int?)null;
            int userId = UserSession.CurrentUserId;
            decimal totalAmount = saleItems.Sum(item => item.Subtotal);
            decimal discountAmount = totalAmount * (discount / 100);
            decimal finalAmount = totalAmount - discountAmount;
            string paymentMethod = cmbPaymentMethod.SelectedItem.ToString();

            // Save to sales table
            string saleQuery = @"
    INSERT INTO sales (customer_id, user_id, total_amount, discount, final_amount, payment_method, sale_date)
    VALUES ( @customerId, @userId, @totalAmount, @discount, @finalAmount, @paymentMethod, NOW());
    SELECT LAST_INSERT_ID();";

            int insertedSaleId = 0;

            using (MySqlConnection conn = new MySqlConnection(con))
            {
                try
                {
                    conn.Open();

                    // Start transaction
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Insert sale header
                            using (MySqlCommand cmd = new MySqlCommand(saleQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@customerId", customerId);
                                cmd.Parameters.AddWithValue("@userId", userId);
                                cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                                cmd.Parameters.AddWithValue("@discount", discount);
                                cmd.Parameters.AddWithValue("@finalAmount", finalAmount);
                                cmd.Parameters.AddWithValue("@paymentMethod", paymentMethod);

                                insertedSaleId = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            // Insert sale items
                            foreach (var item in saleItems)
                            {
                                string itemQuery = @"
                        INSERT INTO sale_items (sale_id, book_id, quantity, price, subtotal)
                        VALUES (@saleId, @bookId, @quantity, @price, @subtotal)";

                                using (MySqlCommand cmd = new MySqlCommand(itemQuery, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@saleId", insertedSaleId);
                                    cmd.Parameters.AddWithValue("@bookId", item.BookId);
                                    cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                                    cmd.Parameters.AddWithValue("@price", item.Price);
                                    cmd.Parameters.AddWithValue("@subtotal", item.Subtotal);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            // Commit transaction
                            transaction.Commit();

                            // Show success and clear form
                            MessageBox.Show($"Sale #{insertedSaleId} saved successfully!");
                            ClearForm();
                        }
                        catch (Exception ex)
                        {
                            // Rollback on error
                            transaction.Rollback();
                            MessageBox.Show($"Error saving sale: {ex.Message}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database connection error: {ex.Message}");
                }
            }
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
            string isbn = ((DataRowView)listBooks.SelectedItem)["ISBN"].ToString();

            var saleItem = new SaleItem
            {
                BookId = bookId,
                BookTitle = bookTitle,
                ISBN = isbn,
                Quantity = quantity,
                Price = price
            };
            saleItems.Add(saleItem);

            UpdateSaleItemsGrid();
            CalculateSubtotal();

            listBooks.SelectedIndex = -1;
            txtQuantity.Clear();
            txtISBN.Clear();
            txtPrice.Clear();
        }

        private void ClearForm()
        {
            saleItems.Clear();
            _totalBeforeDiscount = 0;
            _discountAmount = 0;
            UpdateSaleItemsGrid();
            txtTotalAmount.Text = "0.00";
            txtFinalAmount.Text = "0.00";
            txtDiscount.Text = "0";
            cmbCustomer.SelectedIndex = -1;
            cmbPaymentMethod.SelectedIndex = -1;
            txtCustomerId.Text = "";
            txtCustomerPhone.Text = "";
            txtISBN.Text = "";
            txtPrice.Text = "";
            listBooks.SelectedIndex = -1;
        }

        private void applyDiscount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiscount.Text) || !decimal.TryParse(txtDiscount.Text, out _discountAmount))
            {
                MessageBox.Show("Please enter a valid discount amount.");
                return;
            }

            if (_discountAmount < 0 || _discountAmount > 100)
            {
                MessageBox.Show("Discount must be between 0 and 100.");
                return;
            }

            CalculateTotalWithDiscount();
        }

        private void CalculateSubtotal()
        {
            _totalBeforeDiscount = saleItems.Sum(item => item.Subtotal);
            txtTotalAmount.Text = _totalBeforeDiscount.ToString("N2");
            txtFinalAmount.Text = _totalBeforeDiscount.ToString("N2"); 
        }

        private void CalculateTotalWithDiscount()
        {
            decimal discountPercentage = _discountAmount / 100;
            decimal discountValue = _totalBeforeDiscount * discountPercentage;
            decimal finalAmount = _totalBeforeDiscount - discountValue;

            txtDiscount.Text = _discountAmount.ToString("N2");
            txtFinalAmount.Text = finalAmount.ToString("N2");

            // Optional: Show discount value separately
            // txtDiscountValue.Text = discountValue.ToString("N2");
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue != null && cmbCustomer.SelectedValue is int)
            {
                int customerId = (int)cmbCustomer.SelectedValue;
                string phone = GetCustomerPhone(customerId);

                txtCustomerId.Text = customerId.ToString();
                txtCustomerPhone.Text = phone;
            }
            else
            {
                txtCustomerId.Text = "";
                txtCustomerPhone.Text = "";
            }
        }

        private string GetCustomerPhone(int customerId)
        {
            string phone = "";
            string query = "SELECT Phone FROM Customers WHERE Id = @CustomerId";

            using (MySqlConnection conn = new MySqlConnection(con))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);
                    var result = cmd.ExecuteScalar();
                    phone = result != null ? result.ToString() : "N/A";
                }
            }

            return phone;
        }

        private void listBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBooks.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)listBooks.SelectedItem;
                txtISBN.Text = selectedRow["ISBN"].ToString();
                txtPrice.Text = selectedRow["Price"].ToString();
            }
            else
            {
                txtISBN.Text = "";
                txtPrice.Text = "";
            }
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (dgvSaleItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to remove.");
                return;
            }

            // Get the selected item
            var selectedItem = (SaleItem)dgvSaleItems.SelectedRows[0].DataBoundItem;

            // Remove from the saleItems list
            saleItems.Remove(selectedItem);

            // Update the display
            UpdateSaleItemsGrid();
            CalculateSubtotal();

            // If discount was applied, recalculate with discount
            if (_discountAmount > 0)
            {
                CalculateTotalWithDiscount();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (saleItems.Count == 0)
            {
                MessageBox.Show("No items to print. Please add items to the sale.");
                return;
            }

            // Show print preview
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Fonts and styling
            Font headerFont = new Font("Arial", 18, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 12, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 10);
            Font footerFont = new Font("Arial", 8, FontStyle.Italic);

            Brush brush = Brushes.Black;
            Pen linePen = new Pen(Color.Black, 1);

            // Starting position and offsets
            int startX = 150;
            int startY = 150;
            int offset = 50;

            // Logo or header (optional)
            e.Graphics.DrawString("BOOKHAVEN", headerFont, brush, startX, startY);
            e.Graphics.DrawString("Sales Receipt", subHeaderFont, brush, startX, startY + offset);
            startY += offset * 2;

            // Draw line separator
            e.Graphics.DrawLine(linePen, startX, startY, startX + 500, startY);
            startY += offset;

            // Store and sale info
            e.Graphics.DrawString($"Date: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}", bodyFont, brush, startX, startY);
            e.Graphics.DrawString($"Receipt #: {txtCustomerId.Text}", bodyFont, brush, startX + 300, startY);
            startY += offset / 2;

            if (!string.IsNullOrEmpty(cmbCustomer.Text))
            {
                e.Graphics.DrawString($"Customer: {cmbCustomer.Text}", bodyFont, brush, startX, startY);
                startY += offset / 2;
            }

            e.Graphics.DrawString($"Cashier: {UserSession.Username}", bodyFont, brush, startX, startY);
            startY += offset;

            // Draw line separator
            e.Graphics.DrawLine(linePen, startX, startY, startX + 500, startY);
            startY += offset;

            // Column headers
            e.Graphics.DrawString("Item", subHeaderFont, brush, startX, startY);
            e.Graphics.DrawString("Qty", subHeaderFont, brush, startX + 200, startY);
            e.Graphics.DrawString("Price", subHeaderFont, brush, startX + 300, startY);
            e.Graphics.DrawString("Total", subHeaderFont, brush, startX + 400, startY);
            startY += offset / 2;

            // Draw line separator
            e.Graphics.DrawLine(linePen, startX, startY, startX + 500, startY);
            startY += offset / 2;

            // Sale items
            foreach (var item in saleItems)
            {
                e.Graphics.DrawString(item.BookTitle, bodyFont, brush, startX, startY);
                e.Graphics.DrawString(item.Quantity.ToString(), bodyFont, brush, startX + 200, startY);
                e.Graphics.DrawString(item.Price.ToString("N2"), bodyFont, brush, startX + 300, startY);
                e.Graphics.DrawString(item.Subtotal.ToString("N2"), bodyFont, brush, startX + 400, startY);
                startY += offset / 2;
            }

            // Draw line separator
            e.Graphics.DrawLine(linePen, startX, startY, startX + 500, startY);
            startY += offset / 2;

            // Totals
            e.Graphics.DrawString("Subtotal:", subHeaderFont, brush, startX + 200, startY);
            e.Graphics.DrawString(txtTotalAmount.Text, subHeaderFont, brush, startX + 400, startY);
            startY += offset / 2;

            e.Graphics.DrawString($"Discount ({txtDiscount.Text}%):", subHeaderFont, brush, startX + 200, startY);
            e.Graphics.DrawString((decimal.Parse(txtTotalAmount.Text) - decimal.Parse(txtFinalAmount.Text)).ToString("N2"),
                                 subHeaderFont, brush, startX + 400, startY);
            startY += offset / 2;

            e.Graphics.DrawString("Total:", subHeaderFont, brush, startX + 200, startY);
            e.Graphics.DrawString(txtFinalAmount.Text, subHeaderFont, brush, startX + 400, startY);
            startY += offset;

            // Payment method
            e.Graphics.DrawString($"Payment Method: {cmbPaymentMethod.Text}", subHeaderFont, brush, startX, startY);
            startY += offset;

            // Footer
            e.Graphics.DrawString("Thank you for shopping with us!", footerFont, brush, startX, startY);
            startY += offset / 2;
            e.Graphics.DrawString("Please come again!", footerFont, brush, startX, startY);
            startY += offset / 2;
            e.Graphics.DrawString("BookHaven - Your Favorite Book Store", footerFont, brush, startX, startY);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }

    public class SaleItem
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string ISBN { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Subtotal => Quantity * Price;
    }
}
