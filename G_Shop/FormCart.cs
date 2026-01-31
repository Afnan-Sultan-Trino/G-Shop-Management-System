using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace G_Shop
{
    public partial class FormCart : Form
    {
        private DataAccess Da = new DataAccess();
        private DataTable productTable = new DataTable();
        public string SalesmanName { get; set; } = "Unknown";

        public FormCart()
        {
            InitializeComponent();
            this.SalesmanName = Session.SalesmanName ?? "Guest";
        }

        // ===== FORM LOAD =====
        private void FormCart_Load(object sender, EventArgs e)
        {
            LoadAllProducts();
        }

        // ===== LOAD PRODUCTS =====
        private void LoadAllProducts()
        {
            productTable = Da.ExecuteQueryTable("SELECT * FROM ProductInfoDB");
            dgvProductList.DataSource = productTable;
        }

        // ===== CALCULATE SUMMARY =====
        private void CalculateSummary()
        {
            decimal subTotal = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["Total"].Value != null && !row.IsNewRow)
                    subTotal += Convert.ToDecimal(row.Cells["Total"].Value);
            }

            decimal discount = 0m;
            decimal tax = 0m;
            decimal total = subTotal - discount + tax;

            txtSubTotal.Text = subTotal.ToString("0.00");
            txtDiscount.Text = discount.ToString("0.00");
            txtTax.Text = tax.ToString("0.00");
            txtTotal.Text = total.ToString("0.00");
        }

        // ===== SELECT PRODUCT =====
        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvProductList.Rows[e.RowIndex];

            // Use ACTUAL database column names from your debug
            txtProductName.Text = row.Cells["ProductName"].Value?.ToString();
            txtProductPrice.Text = row.Cells["ProductPrice"].Value?.ToString();
            txtProductQuantity.Clear();
            txtProductQuantity.Focus();
        }

        // ===== ADD TO CART =====
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (!int.TryParse(txtProductQuantity.Text, out int addQty) || addQty <= 0)
            {
                MessageBox.Show("Enter valid quantity.");
                return;
            }

            if (!decimal.TryParse(txtProductPrice.Text, out decimal price))
            {
                MessageBox.Show("Enter valid price.");
                return;
            }

            string productName = txtProductName.Text.Trim();

            try
            {
                // Check if enough stock exists - using ACTUAL column name "Quantity"
                string stockCheckQuery = $@"
                    SELECT Quantity 
                    FROM ProductInfoDB 
                    WHERE [Product Name] = '{productName.Replace("'", "''")}'";

                DataTable stockTable = Da.ExecuteQueryTable(stockCheckQuery);

                if (stockTable.Rows.Count == 0)
                {
                    MessageBox.Show("Product not found in database.");
                    return;
                }

                int currentStock = Convert.ToInt32(stockTable.Rows[0]["Quantity"]);
                if (addQty > currentStock)
                {
                    MessageBox.Show($"Only {currentStock} items available in stock.");
                    return;
                }

                // Check existing quantity in cart
                int cartQty = 0;
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (!row.IsNewRow && row.Cells["ProductNameC"].Value?.ToString() == productName)
                    {
                        cartQty = Convert.ToInt32(row.Cells["Quantity"].Value);
                        break;
                    }
                }

                // Update or add to cart
                bool found = false;
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (!row.IsNewRow && row.Cells["ProductNameC"].Value?.ToString() == productName)
                    {
                        int newQty = cartQty + addQty;
                        row.Cells["Quantity"].Value = newQty;
                        row.Cells["Total"].Value = newQty * price;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    dgvCart.Rows.Add(productName, price, addQty, price * addQty);
                }

                // Update stock in database - using ACTUAL column name "Quantity"
                string updateQuery = $@"
                    UPDATE ProductInfoDB 
                    SET Quantity = Quantity - {addQty} 
                    WHERE [Product Name] = '{productName.Replace("'", "''")}'";

                Da.ExecuteDMLQuery(updateQuery);

                CalculateSummary();
                txtProductQuantity.Clear();
                LoadAllProducts(); // Refresh stock display
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding to cart: {ex.Message}", "Error");
            }
        }

        // ===== DELETE ITEM FROM CART =====
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null || dgvCart.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Select an item to delete.");
                return;
            }

            DataGridViewRow row = dgvCart.CurrentRow;
            string productName = row.Cells["ProductNameC"].Value.ToString();
            int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

            DialogResult dr = MessageBox.Show($"Remove {productName} from cart?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;

            try
            {
                // Restore stock BEFORE removing from cart - using ACTUAL column name "Quantity"
                string updateQuery = $@"
                    UPDATE ProductInfoDB 
                    SET Quantity = Quantity + {quantity} 
                    WHERE [Product Name] = '{productName.Replace("'", "''")}'";

                Da.ExecuteDMLQuery(updateQuery);

                dgvCart.Rows.Remove(row);

                CalculateSummary();
                LoadAllProducts(); // Refresh stock display
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting item: {ex.Message}", "Error");
            }
        }

        // ===== SEARCH =====
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (productTable.Rows.Count == 0) return;

            DataView dv = productTable.DefaultView;
            string searchText = txtSearch.Text.Replace("'", "''");

            // Use ACTUAL column name "Product Name" with brackets
            dv.RowFilter = $"[Product Name] LIKE '%{searchText}%'";

            dgvProductList.DataSource = dv;
        }

        // ===== CHECKOUT =====
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0 || (dgvCart.Rows.Count == 1 && dgvCart.Rows[0].IsNewRow))
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            try
            {
                // First, save all cart items to sales database
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (row.IsNewRow) continue;

                    string productName = row.Cells["ProductNameC"].Value.ToString();
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    decimal total = Convert.ToDecimal(row.Cells["Total"].Value);

                    // Using ACTUAL column name "ProductName" (SalesInfoDB has ProductName, not [Product Name])
                    string query = $@"
                        INSERT INTO SalesInfoDB 
                        (ProductName, Price, Quantity, Total, SaleDate, SalesmanName)
                        VALUES
                        ('{productName.Replace("'", "''")}', {price}, {quantity}, {total}, GETDATE(), '{SalesmanName.Replace("'", "''")}')";

                    Da.ExecuteDMLQuery(query);
                }

                MessageBox.Show($"Order Confirmed!\nTotal: {txtTotal.Text}\nSalesman: {SalesmanName}",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear cart and reset
                dgvCart.Rows.Clear();
                txtProductName.Clear();
                txtProductPrice.Clear();
                txtProductQuantity.Clear();
                CalculateSummary();
                LoadAllProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during checkout: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== BACK BUTTON =====
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSalesman fs = new FormSalesman();
            fs.Show();
        }

        private void FormCart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // ===== QUANTITY VALIDATION =====
        private void txtProductQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtProductQuantity.Text, out int quantity) && quantity <= 0)
            {
                MessageBox.Show("Quantity must be positive");
                txtProductQuantity.Text = "";
            }
        }

        // ===== DESIGNER GENERATED METHODS =====
        private void txtProductPrice_TextChanged(object sender, EventArgs e) { }
        private void txtProductQuantity_TextChanged_1(object sender, EventArgs e) { }
        private void txtProductName_TextChanged_1(object sender, EventArgs e) { }
        private void btnShowAllPrduct_Click_1(object sender, EventArgs e) { LoadAllProducts(); }
        private void btnAddProduct_Click_1(object sender, EventArgs e) { btnAddProduct_Click(sender, e); }

        private void dgvProductList_DoubleClick(object sender, EventArgs e)
        {
            // Use the CellDoubleClick handler
            if (dgvProductList.CurrentRow != null && dgvProductList.CurrentRow.Index >= 0)
            {
                dgvProductList_CellDoubleClick(sender, new DataGridViewCellEventArgs(0, dgvProductList.CurrentRow.Index));
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e) { btnDelete_Click(sender, e); }
        private void btnCheckOut_Click_1(object sender, EventArgs e) { btnCheckOut_Click(sender, e); }
        private void btnBack_Click_1(object sender, EventArgs e) { btnBack_Click(sender, e); }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                var sql = "select * from ProductInfoDB where [Product Name] like '" + this.txtSearch.Text + "%';";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An ERROR has Occured.Please Try it Again!" + exc.Message);

            }
        }
        public void PopulateGridView(string sql = "select * from ProductInfoDB;")
        {
            try
            {
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    this.dgvProductList.AutoGenerateColumns = false;
                    this.dgvProductList.DataSource = ds.Tables[0];
                }
                else
                {
                    this.dgvProductList.DataSource = null;
                    MessageBox.Show($"Product '{txtSearch.Text}' is not found.",
                               "Search Result",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An ERROR has Occured.Please Try it Again!" + exc.Message);
            }
        }
    }
}