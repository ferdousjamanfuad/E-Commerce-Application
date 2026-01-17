using BakeryShopManagementSystem;
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

namespace BakeryShopManagementSystem
{
    public partial class ProductionManager : Form
    {
        public ProductionManager()
        {
            InitializeComponent();
        }
        private void ProductionManager_Load(object sender, EventArgs e)
        {
            string query = "SELECT product_name FROM products";
            DataTable dt = DatabaseHelper.GetData(query);
            cmbpmproductname.DisplayMember = "product_name";
            cmbpmproductname.DataSource = dt;
            cmbpmproductname.SelectedIndex = -1;
        }

        private void btnexitpm_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnpmloadproduct_Click(object sender, EventArgs e)
        {
            dgvpm.DataSource =
       DatabaseHelper.GetData("SELECT * FROM products");
        }

        private void btnpmstock_Click(object sender, EventArgs e)
        {
            if (cmbpmproductname.SelectedIndex == -1 || txtpmproductquan.Text == "")
            {
                MessageBox.Show("Please enter an existing product then product quantity");
                return;
            }
            object exists = DatabaseHelper.GetValue(
            $"SELECT COUNT(*) FROM products WHERE product_name = '{cmbpmproductname.Text}'");
            if (Convert.ToInt32(exists) == 0)
            {
                MessageBox.Show("product doesn't exist");
                return;
            }

            int Qu;
            try
            {
                Qu = Convert.ToInt32(txtpmproductquan.Text);
                if (Qu <= 0)
                {
                    MessageBox.Show("Please enter a positive value");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Enter an integer quantity");
                return;
            }
            string query = $"UPDATE products SET quantity = quantity + {Qu} WHERE product_name = '{cmbpmproductname.Text}'";
            bool success = DatabaseHelper.Execute(query);
            if (success)
            {
                MessageBox.Show("production stock updated");
            }
            else
            {
                MessageBox.Show("failed to update production!");
            }
            dgvpm.DataSource =
                 DatabaseHelper.GetData("SELECT * FROM products");
            cmbpmproductname.SelectedIndex = -1;
            txtpmproductquan.Clear();
            txtpmproductprice.Clear();
        }

        private void btnpmnewproduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbpmproductname.Text)||txtpmproductprice.Text=="")
            {
                MessageBox.Show("Enter product name & price");
                return;
            }

            object exists = DatabaseHelper.GetValue(
                $"SELECT COUNT(*) FROM products WHERE product_name = '{cmbpmproductname.Text}'");

            if (Convert.ToInt32(exists) > 0)
            {
                MessageBox.Show("Product already exists");
                return;
            }

            int Qu;
            if (string.IsNullOrWhiteSpace(txtpmproductquan.Text))
            {
                Qu = 0;
            }
            else
            {
                try
                {
                    Qu = Convert.ToInt32(txtpmproductquan.Text);
                    if (Qu < 0)
                    {
                        MessageBox.Show("Quantity can't be negative");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Enter an integer quantity");
                    return;
                }
            }

            decimal QP;
            try
            {
                QP = Convert.ToDecimal(txtpmproductprice.Text);
                if (QP <= 0)
                {
                    MessageBox.Show("Please enter a positive price");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Enter a valid product price");
                return;
            }

            string query =
                $"INSERT INTO products (product_name, price, quantity) VALUES ('{cmbpmproductname.Text}',{QP},{Qu})";

            bool success = DatabaseHelper.Execute(query);

            if (success)
                MessageBox.Show("Product added successfully");
            else
                MessageBox.Show("Failed to add product");

            dgvpm.DataSource = DatabaseHelper.GetData("SELECT * FROM products");
            cmbpmproductname.SelectedIndex = -1;
            txtpmproductprice .Clear();
            txtpmproductquan .Clear();
        }
    }
}
