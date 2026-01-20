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
            dgvCashierloadProducts.DataSource =
                DatabaseHelper.GetData(
                    "SELECT * FROM products");
        }
        private void btntoPandB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCcustomername.Text) ||
                string.IsNullOrWhiteSpace(txtCphonenumber.Text))
            {
                MessageBox.Show("Please enter customer name and phone number");
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
            if (string.IsNullOrWhiteSpace(txtCproductname.Text) || string.IsNullOrWhiteSpace(txtCprice.Text)||
                string.IsNullOrWhiteSpace(txtCquantity.Text))
            {
                MessageBox.Show("Select a product and enter quantity");
                return;
            }

            int quantity;
            try
            {
                quantity = Convert.ToInt32(txtCquantity.Text);
                if (quantity <= 0)
                {
                    MessageBox.Show("Please enter a positive quantity");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Enter an integer quantity");
                return;
            }
            decimal price;
            price = Convert.ToDecimal(txtCprice.Text);

            int productId = Convert.ToInt32(
             dgvCashierloadProducts.CurrentRow.Cells["product_id"].Value);


            decimal total = price * quantity;

            foreach (DataRow row in cart.Rows)
            {
                if (Convert.ToInt32(row["Product ID"]) == productId)
                {
                    row["Quantity"] = Convert.ToInt32(row["Quantity"]) + quantity;
                    row["Total"] =
                        Convert.ToDecimal(row["Price"]) * Convert.ToInt32(row["Quantity"]);
                    CalculateTotal();
                    return;
                }
            }


            cart.Rows.Add(
                productId,
                txtCproductname.Text,
                price,
                quantity,
                total
            );

            CalculateTotal();
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
                DatabaseHelper.GetData(
                    "SELECT product_id, product_name, price, quantity FROM products");
        }
        private void btnCBill_Click(object sender, EventArgs e)
        {
            if (cart.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty");
                return;
            }
            foreach (DataRow row in cart.Rows)
            {
                int productId = Convert.ToInt32(row["Product ID"]);
                int cartQty = Convert.ToInt32(row["Quantity"]);

                object stockObj = DatabaseHelper.GetValue(
                    "SELECT quantity FROM products WHERE product_id = " + productId);

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
            string insertOrder =
                "INSERT INTO orders (customer_name, phone_number, cashier_id, total_amount) VALUES (" +
                "'" + txtCcustomername.Text + "', " +
                "'" + txtCphonenumber.Text + "', " +
                Session.UserId + ", " +
                totalAmount + ")";

            bool orderInserted = DatabaseHelper.Execute(insertOrder);

            if (!orderInserted)
            {
                MessageBox.Show("Failed to create order");
                return;
            }
            int orderId = Convert.ToInt32(
                DatabaseHelper.GetValue("SELECT LAST_INSERT_ID()"));

            foreach (DataRow row in cart.Rows)
            {
                int productId = Convert.ToInt32(row["Product ID"]);
                int quantity = Convert.ToInt32(row["Quantity"]);
                decimal price = Convert.ToDecimal(row["Price"]);
                string productName = row["Product Name"].ToString();

                string insertDetails =
                    "INSERT INTO order_details (order_id, product_id, product_name, quantity, price) VALUES (" +
                    orderId + ", " +
                    productId + ", " +
                    "'" + productName + "', " +
                    quantity + ", " +
                    price + ")";

                DatabaseHelper.Execute(insertDetails);

                string updateStock =
                    "UPDATE products SET quantity = quantity - " + quantity +
                    " WHERE product_id = " + productId;

                DatabaseHelper.Execute(updateStock);
            }

            lblCustomerName.Text = "Customer Name: " + txtCcustomername.Text;
            lblPhoneNo.Text = "Phone No: " + txtCphonenumber.Text;
            lblTotalAmount.Text = "Total Amount: " + totalAmount.ToString("0.00");
            lblbilldate.Text = "Billing Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            cart.Rows.Clear();
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
            cart.Columns.Add("Product ID", typeof(int));
            cart.Columns.Add("Product Name", typeof(string));
            cart.Columns.Add("Price", typeof(decimal));
            cart.Columns.Add("Quantity", typeof(int));
            cart.Columns.Add("Total", typeof(decimal));

            dgvCcart.DataSource = cart;
        }

        private void dgvCashierloadProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCproductname.Text =
                dgvCashierloadProducts.Rows[e.RowIndex]
                .Cells["product_name"].Value.ToString();

                txtCprice.Text =
                dgvCashierloadProducts.Rows[e.RowIndex]
               .Cells["price"].Value.ToString();

               txtCquantity.Clear();
            }
        }
    }
}
