using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakeryShopManagementSystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void ViewProducts()
        {
         dgvadminproduct.DataSource =
        DatabaseHelper.GetData("SELECT * FROM products");
        }

        private void ViewUsers()
        {
         dgvadminusers.DataSource =
         DatabaseHelper.GetData("SELECT * FROM users");
        }    

        private void tousers_Click(object sender, EventArgs e)
        {
            tabControlmain.SelectedTab = User;
        }

        private void toproduct_Click(object sender, EventArgs e)
        {
            tabControlmain.SelectedTab = Product;

        }

        private void toinventory_Click(object sender, EventArgs e)
        {
            tabControlmain.SelectedTab = Inventory;
        }

        private void todashboard_Click(object sender, EventArgs e)
        {
         DataTable dt = DatabaseHelper.GetData(
          "SELECT DATE(order_date) AS sale_date, " +
         "SUM(total_amount) AS total_sales " +
         "FROM orders " +
         "GROUP BY DATE(order_date) " +
          "ORDER BY sale_date");

            chartSales.Series.Clear();
            chartSales.Series.Add("Sales");
            chartSales.Series["Sales"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            foreach (DataRow row in dt.Rows)
            {
                chartSales.Series["Sales"].Points.AddXY(
                    row["sale_date"].ToString(),
                    Convert.ToDecimal(row["total_sales"])
                );
            }
            tabControlmain.SelectedTab = Sales;

        }

        private void btnadminview_Click(object sender, EventArgs e)
        {
            ViewProducts();
        }

        private void dgvadminproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtproductid.Text = dgvadminproduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtproductname.Text = dgvadminproduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtproductprice.Text = dgvadminproduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnadminupdate_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtproductid.Text) ||
             string.IsNullOrWhiteSpace(txtproductname.Text) ||
             string.IsNullOrWhiteSpace(txtproductprice.Text))
            {
                MessageBox.Show("Please select a product and fill all fields before updating");
                return;
            }

            string query = $"UPDATE products SET product_name = '{txtproductname.Text}',price = '{txtproductprice.Text}' WHERE product_id = {txtproductid.Text}";
            bool success = DatabaseHelper.Execute(query);
            if(success)
                {
                MessageBox.Show("Product updated successfully");
            }
            else
            {
                MessageBox.Show("Failed to update product");
            }
             ViewProducts();
            txtproductid.Clear();
            txtproductname.Clear();
            txtproductprice.Clear();
        }
        private void btnadminpendinguser_Click(object sender, EventArgs e)
        {
            panelpending.Visible = true;

            panelpending.BringToFront();

            dgvpanelpending.DataSource = DatabaseHelper.GetData("SELECT * FROM Users WHERE is_approved=0");
        }

        private void btnadmdltproduct_Click(object sender, EventArgs e)
        {
            if (txtproductid.Text == "")
            {
                MessageBox.Show("Please select a product first");
                return;
            }
            string query = "DELETE FROM products WHERE product_id = " + txtproductid.Text;
            bool success = DatabaseHelper.Execute(query);

            if (success)
            {
                MessageBox.Show("Product deleted successfully");
                ViewProducts();
                txtproductid.Clear();
                txtproductname.Clear();
                txtproductprice.Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete product");
            }
        }

        private void btnadminsertproduct_Click(object sender, EventArgs e)
        {
            if (txtproductname.Text == "" || txtproductprice.Text == "")
            {
                MessageBox.Show("Please enter product name and price");
                return;
            }
                string query = $"INSERT INTO products (product_name, price) VALUES ('{txtproductname.Text}', '{txtproductprice.Text}')";
                bool success = DatabaseHelper.Execute(query);

                if (success)
                {
                    MessageBox.Show("Product added successfully!");
                    ViewProducts();
                    txtproductname.Clear();
                    txtproductprice.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to add product");
                }
        }

        private void btnadminviewuser_Click(object sender, EventArgs e)
        {
            ViewUsers();
        }

        private void btnapproveuser_Click(object sender, EventArgs e)
        {
            if (dgvpanelpending.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to approve");
                return;
            }
            int userId = Convert.ToInt32(dgvpanelpending.SelectedRows[0].Cells["user_id"].Value);
            string query = $"UPDATE users SET is_approved = 1 WHERE user_id = {userId}";
            bool success = DatabaseHelper.Execute(query);

            if (success)
            {
                MessageBox.Show("User approved successfully!");
                dgvpanelpending.DataSource = DatabaseHelper.GetData("SELECT * FROM users WHERE is_approved = 0");
            }
            else
            {
                MessageBox.Show("Failed to approve user");
            }
        }

        private void btndeclineuser_Click(object sender, EventArgs e)
        {
            if (dgvpanelpending.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to decline");
                return;
            }
            int userId = Convert.ToInt32(dgvpanelpending.SelectedRows[0].Cells["user_id"].Value);
            string query = $"DELETE FROM users WHERE user_id = {userId}";
            bool success = DatabaseHelper.Execute(query);
            if (success)
            {
                MessageBox.Show("User declined successfully!");
                dgvpanelpending.DataSource = DatabaseHelper.GetData("SELECT * FROM users WHERE is_approved = 0");
            }
            else
            {
                MessageBox.Show("Failed to decline user");
            }
        }

        private void btnexitpending_Click(object sender, EventArgs e)
        {
            panelpending.Visible = false;

        }

        private void Admin_Load(object sender, EventArgs e)
        {
           panelpending.Visible = false;
        }

        private void btnadmdltuser_Click(object sender, EventArgs e)
        {
            if (dgvadminusers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user first");
                return;
            }
            int userId = Convert.ToInt32(
           dgvadminusers.SelectedRows[0].Cells["user_id"].Value);
            string role = dgvadminusers.SelectedRows[0]
                         .Cells["role"].Value.ToString();
            if (role == "Admin") {
                MessageBox.Show("Admin can't be removed"); return; }

            string query = "DELETE FROM users WHERE user_id = " + userId;
            bool success = DatabaseHelper.Execute(query);

            if (success)
            {
                MessageBox.Show("User deleted successfully");
                ViewUsers(); 
            }
            else
            {
                MessageBox.Show("Failed to delete user");
            }
        }
            private void btnadminupdateuser_Click(object sender, EventArgs e)
            {
            if (dgvadminusers.SelectedRows.Count == 0) return;

            string role = dgvadminusers.SelectedRows[0]
                          .Cells["role"].Value.ToString();
            if (role == "Admin")
            {
                MessageBox.Show("Admin is immutable");
                return;
            }
            var row = dgvadminusers.SelectedRows[0];

            int id = Convert.ToInt32(row.Cells["user_id"].Value);
            string name = row.Cells["username"].Value.ToString();
            string email = row.Cells["email"].Value.ToString();
            string newRole = row.Cells["role"].Value.ToString();

            if (newRole == "Admin")
            {
                MessageBox.Show("Can't assign Admin role");
                return;
            }

            string q = $"UPDATE users SET username='{name}', email='{email}', role='{newRole}' WHERE user_id={id}";
            DatabaseHelper.Execute(q);
            MessageBox.Show("User updated successfully");
            ViewUsers();
        }

        private void btngotoinventory_Click(object sender, EventArgs e)
        {
            InventoryManager im=new InventoryManager();
            im.Show();
            this.Hide();
        }

        private void btnlogoutadmin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void adminprofile_Click(object sender, EventArgs e)
        {
            profile p = new profile();
            p.Show();
            this.Close();
        }
    }
}

