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

namespace BakeryShopManagementSystem
{
    public partial class ProductionManager : Form
    {
        bool isDoneClicked = false;
        bool isInvDeduct = false;

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

            DataTable inv = DatabaseHelper.GetData("SELECT item_name FROM inventory_items");
            cmbpminv_item.DisplayMember = "item_name";
            cmbpminv_item.DataSource = inv;
            cmbpminv_item.SelectedIndex = -1;
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
            if (!isDoneClicked)
            {
                MessageBox.Show("Inventory deduction isn't finished. Click Done first.");
                return;
            }

            if (cmbpmproductname.SelectedIndex == -1 || txtpmproductquan.Text == "")
            {
                MessageBox.Show("Please select product and enter quantity");
                return;
            }

            object exists = DatabaseHelper.GetValue(
                $"SELECT COUNT(*) FROM products WHERE product_name = '{cmbpmproductname.Text}'"
            );

            if (Convert.ToInt32(exists) == 0)
            {
                MessageBox.Show("Product doesn't exist");
                return;
            }

            int productQty;
            try
            {
                productQty = Convert.ToInt32(txtpmproductquan.Text);
                if (productQty <= 0)
                {
                    MessageBox.Show("Enter a positive product quantity");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Enter a valid integer quantity");
                return;
            }

            bool success = DatabaseHelper.Execute(
                $"UPDATE products SET quantity = quantity + {productQty} " +
                $"WHERE product_name = '{cmbpmproductname.Text}'"
            );

            if (success)
                MessageBox.Show("Product stock updated successfully");
            else
                MessageBox.Show("Failed to update product stock");

            isDoneClicked = false;

            dgvpm.DataSource = DatabaseHelper.GetData("SELECT * FROM products");

            cmbpmproductname.SelectedIndex = -1;
            txtpmproductquan.Clear();
        }


        private void btnpmnewproduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbpmproductname.Text) || txtpmproductprice.Text == "")
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
            int QU = 0;
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
                $"INSERT INTO products (product_name, price, quantity) VALUES ('{cmbpmproductname.Text}',{QP},{QU})";

            bool success = DatabaseHelper.Execute(query);

            if (success)
                MessageBox.Show("Product added successfully");
            else
                MessageBox.Show("Failed to add product");

            dgvpm.DataSource = DatabaseHelper.GetData("SELECT * FROM products");
            cmbpmproductname.SelectedIndex = -1;
            txtpmproductprice.Clear();
            txtpmproductquan.Clear();
        }

        private void btnpmrefreshinv_Click(object sender, EventArgs e)
        {
            dgvpminv.DataSource =
            DatabaseHelper.GetData("SELECT * FROM inventory_items");
        }

        private void btnpmdone_Click(object sender, EventArgs e)
        {
            if (!isInvDeduct)
            {
                MessageBox.Show("Please deduct inventory before clicking Done.");
                return;
            }

            isDoneClicked = true;
            MessageBox.Show("Inventory deduction completed");
        }


        private void btnpmdeduct_Click(object sender, EventArgs e)
        {
            if (cmbpminv_item.SelectedIndex == -1 || txtUsedInventoryQty.Text == "")
            {
                MessageBox.Show("Select inventory item and quantity");
                return;
            }

            decimal usedQty;
            try
            {
                usedQty = Convert.ToDecimal(txtUsedInventoryQty.Text);
                if (usedQty <= 0)
                {
                    MessageBox.Show("Enter positive quantity");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Enter valid quantity");
                return;
            }

            object invQtyObj = DatabaseHelper.GetValue(
                $"SELECT quantity FROM inventory_items WHERE item_name = '{cmbpminv_item.Text}'"
            );

            if (invQtyObj == null)
            {
                MessageBox.Show("Inventory item not found");
                return;
            }

            decimal availableQty = Convert.ToDecimal(invQtyObj);

            if (availableQty < usedQty)
            {
                MessageBox.Show("Inventory low stock!");
                return;
            }

            DatabaseHelper.Execute(
                $"UPDATE inventory_items SET quantity = quantity - {usedQty} " +
                $"WHERE item_name = '{cmbpminv_item.Text}'"
            );

            isInvDeduct = true;
            isDoneClicked = false;
            MessageBox.Show("Inventory deducted");

            dgvpminv.DataSource =
                DatabaseHelper.GetData("SELECT * FROM inventory_items");

            cmbpminv_item.SelectedIndex = -1;
            txtUsedInventoryQty.Clear();
        }

        private void pmprofile_Click(object sender, EventArgs e)
        {
            profile pf=new profile();
            pf.Show();
            this.Close();
        }
    }
}