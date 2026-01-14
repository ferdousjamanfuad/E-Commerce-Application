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
        private void btnexitadmin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void tousers_Click(object sender, EventArgs e)
        {
            tabControlmain.SelectedTab = User;
        }

        private void toproduct_Click(object sender, EventArgs e)
        {
            tabControlmain.SelectedTab = Product;

        }

        private void tocategory_Click(object sender, EventArgs e)
        {
            tabControlmain.SelectedTab = Category;
        }

        private void todashboard_Click(object sender, EventArgs e)
        {
            tabControlmain.SelectedTab = Dashboard;

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

        private void dgvadminusers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void dgvpanelpending_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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

        }
    }
}

