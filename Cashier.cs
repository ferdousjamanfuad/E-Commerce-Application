using System;
using System.Data;
using System.Windows.Forms;

namespace BakeryShopManagementSystem
{
    public partial class Cashier : Form
    {
        DataTable cart = new DataTable();

        public Cashier()
        {
            InitializeComponent();
        }
        private void btncashierloadproduct_Click(object sender, EventArgs e)
        {
            Cashier_Show_Product csp = new Cashier_Show_Product();
            csp.Show();
            this.Close();

        }
        private void btntoPandB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCcustomername.Text))
            {
                MessageBox.Show("Please enter customer name");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCcustomername.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Customer name can only contain letters and spaces");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCphonenumber.Text))
            {
                MessageBox.Show("Please enter phone number");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCphonenumber.Text, @"^\d{11}$"))
            {
                MessageBox.Show("Enter a valid 11 digits phone number)");
                return;
            }
            tabControlCmain.SelectedTab = tabPage3;
        }
        private void CalculateTotal()
        {
            decimal sum = 0;

            foreach (DataRow row in cart.Rows)
            {
                sum += Convert.ToDecimal(row["Total"]);
            }

            lblCtotal.Text = "Total: " + sum.ToString("0.00");
        }
        private void btnCtocart_Click(object sender, EventArgs e)
        {
            if (!ValidateProductInput()) return;

            int productId = Convert.ToInt32(dgvCashierloadProducts.CurrentRow.Cells["product_id"].Value);
            string productName = txtCproductname.Text;
            decimal price = Convert.ToDecimal(txtCprice.Text);
            int quantity = Convert.ToInt32(txtCquantity.Text);
            decimal total = price * quantity;

            foreach (DataRow row in cart.Rows)
            {
                if (Convert.ToInt32(row["Product Id"]) == productId)
                {
                    row["Quantity"] = Convert.ToInt32(row["Quantity"]) + quantity;
                    row["Total"] = Convert.ToDecimal(row["Price"]) * Convert.ToInt32(row["Quantity"]);
                    CalculateTotal();
                    return;
                }
            }
            cart.Rows.Add(productId, productName, price, quantity, total);
            CalculateTotal();
            }
private bool ValidateProductInput()
        {
            if (string.IsNullOrWhiteSpace(txtCproductname.Text) ||
                string.IsNullOrWhiteSpace(txtCprice.Text) ||
                string.IsNullOrWhiteSpace(txtCquantity.Text))
            {
                MessageBox.Show("Please select a product and enter quantity.");
                return false;
            }
            if (!int.TryParse(txtCquantity.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Enter a valid quantity.");
                return false;
            }
            return true;
        }
        private void btnCremovefromcart_Click(object sender, EventArgs e)
        {
            if (dgvCcart.CurrentRow == null)
            {
                MessageBox.Show("Please select an item to remove");
                return;
            }
            cart.Rows.RemoveAt(dgvCcart.CurrentRow.Index);
            CalculateTotal();
        }
        private void btnCrefreshproduct_Click(object sender, EventArgs e)
        {
            dgvCashierloadProducts.DataSource =
                DatabaseHelper.GetData( "SELECT product_id, product_name, price, quantity FROM products");
        }
        private void btnCBill_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCcustomername.Text))
            {
                MessageBox.Show("Please enter customer name");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCphonenumber.Text))
            {
                MessageBox.Show("Please enter phone number");
                return;
            }

            if (cart.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty");
                return;
            }
            foreach (DataRow row in cart.Rows)
            {
                int productId = Convert.ToInt32(row["Product ID"]);
                int cartQty = Convert.ToInt32(row["Quantity"]);

                object stockObj = DatabaseHelper.GetValue( "SELECT quantity FROM products WHERE product_id = " + productId);

                if (stockObj == null || stockObj == DBNull.Value)
                {
                    MessageBox.Show("Stock not found for product ID: " + productId);
                    return;
                }

                int stockQty = Convert.ToInt32(stockObj);

                if (cartQty > stockQty)
                {
                    MessageBox.Show(
                        "Not enough stock for product ID: " + productId);
                    return;
                }
            }
            decimal totalAmount = 0;
            foreach (DataRow row in cart.Rows)
            {
                totalAmount += Convert.ToDecimal(row["Total"]);
            }
              string insertOrder ="INSERT INTO orders (customer_name, phone_number, cashier_id, total_amount) " + "OUTPUT INSERTED.order_id " +"VALUES ('" + txtCcustomername.Text + "', '" + txtCphonenumber.Text + "', " +
                  Session.UserId + ", " +
                  totalAmount.ToString(System.Globalization.CultureInfo.InvariantCulture) + ")";

            object idObj = DatabaseHelper.GetValue(insertOrder);

            if (idObj == null || idObj == DBNull.Value)
            {
                MessageBox.Show("Order ID generation failed");
                return;
            }

            int orderId = Convert.ToInt32(idObj);

            foreach (DataRow row in cart.Rows)
            {
                int productId = Convert.ToInt32(row["Product ID"]);
                int quantity = Convert.ToInt32(row["Quantity"]);
                decimal price = Convert.ToDecimal(row["Price"]);
                string productName = row["Product Name"].ToString();

                string insertDetails = "INSERT INTO order_details (order_id, product_id, product_name, quantity, price) VALUES (" + orderId + ", " + productId + ", " + "'" + productName + "', " +quantity + ", " + price + ")";

                DatabaseHelper.Execute(insertDetails);

                string updateStock = "UPDATE products SET quantity = quantity - " + quantity +" WHERE product_id = " + productId;

                DatabaseHelper.Execute(updateStock);
            }

            lblCustomerName.Text = "Customer Name: " + txtCcustomername.Text;
            lblPhoneNo.Text = "Phone No: " + txtCphonenumber.Text;
            lblTotalAmount.Text = "Total Amount: " + totalAmount.ToString("0.00");
            lblbilldate.Text = "Billing Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            cart.Rows.Clear();
            txtCcustomername.Clear();
            txtCphonenumber.Clear();
            txtCproductname.Clear();
            txtCprice.Clear();

            CalculateTotal();
        
            MessageBox.Show("Bill generated successfully");

            tabControlCmain.SelectedTab = tabPage2;
        }
        private void btnClogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        private void btnCclear_Click(object sender, EventArgs e)
        {
            txtCproductname.Clear();
            txtCprice.Clear();
            txtCquantity.Clear();
        }
        private void Cashier_Load(object sender, EventArgs e)
        {
            InitializeCart();
            LoadProducts();                                 
        }
        private void InitializeCart()
        {
            cart.Columns.Add("Product Id", typeof(int));      
            cart.Columns.Add("Product Name", typeof(string)); 
            cart.Columns.Add("Price", typeof(decimal));
            cart.Columns.Add("Quantity", typeof(int));
            cart.Columns.Add("Total", typeof(decimal));

            dgvCcart.DataSource = cart;
        }
        private void LoadProducts()
        {
            dgvCashierloadProducts.DataSource =
                DatabaseHelper.GetData("SELECT product_id, product_name, price, quantity FROM products");
        }
        private void dgvCashierloadProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtCproductname.Text = dgvCashierloadProducts.Rows[e.RowIndex].Cells["product_name"].Value.ToString();
            txtCprice.Text = dgvCashierloadProducts.Rows[e.RowIndex].Cells["price"].Value.ToString();
            txtCquantity.Clear();

        }
        private void btncashierprofile_Click(object sender, EventArgs e)
        {
            Cashier_Profile cp = new Cashier_Profile();
            cp.Show();
            this.Hide();
        }
        private void blnCsales_Click(object sender, EventArgs e)
        {
            Cashier_Sales cs = new Cashier_Sales();
            cs.Show();
            this.Close();
        }
        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblCustomerName.Text) || string.IsNullOrWhiteSpace(lblPhoneNo.Text) || string.IsNullOrWhiteSpace(lblTotalAmount.Text))
            {
                MessageBox.Show("Please generate bill before printing.","Print Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            string customerName = lblCustomerName.Text.Replace("Customer Name: ", "");
            string phoneNo = lblPhoneNo.Text.Replace("Phone No: ", "");
            string totalText = lblTotalAmount.Text.Replace("Total Amount: ", "");

            if (!decimal.TryParse(totalText, out decimal totalAmount))
            {
                MessageBox.Show("Please generate bill before printing.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BillPDFHelper.PrintBill(customerName, phoneNo, totalAmount);
        }
    }
}
