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
    public partial class InventoryManager : Form
    {
        public InventoryManager()
        {
            InitializeComponent();
        }

        private void btnexitim_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btnbacktoadmin_Click(object sender, EventArgs e)
        {
            if (Session.Role == "Admin")
            {
                new Admin().Show();
                this.Hide();
            }
            else if (Session.Role == "Inventory Manager")
            {
                MessageBox.Show("You don't have admin access");
            }
            else
            {
                MessageBox.Show("Access denied");
            }
        }
        private void InventoryManager_Load(object sender, EventArgs e)
        {
            string query = "SELECT item_name FROM inventory_items";
            DataTable dt = DatabaseHelper.GetData(query);
            cmbInvitemname.DisplayMember = "item_name";
            cmbInvitemname.DataSource = dt;
            cmbInvitemname.SelectedIndex = -1;

        }
        public void Loaditems()
        {
            dgvInventoryitem.DataSource =
       DatabaseHelper.GetData("SELECT * FROM inventory_items");
        }
        private void btnviewinventory_Click(object sender, EventArgs e)
        {
            Loaditems();
        }

        private void btnInvbuyproduct_Click(object sender, EventArgs e)
        {
            if (cmbInvitemname.SelectedIndex == -1 || txtInvitemquan.Text == "")
            {
                MessageBox.Show("Please enter product name and quantity");
                return;
            }
            object exists = DatabaseHelper.GetValue(
             $"SELECT COUNT(*) FROM inventory_items WHERE item_name = '{cmbInvitemname.Text}'");
            if (Convert.ToInt32(exists) == 0)
            {
                MessageBox.Show("Please select a valid item from the list to buy");
                return;
            }
            int QT;
            try
            {
                QT = Convert.ToInt32(txtInvitemquan.Text);
                if (QT <= 0)
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
            string query = $"UPDATE inventory_items SET quantity = quantity + {QT} WHERE item_name = '{cmbInvitemname.Text}'";
            bool success = DatabaseHelper.Execute(query);
            if (success)
            {
                MessageBox.Show("inventory updated successfully");
            }
            else
            {
                MessageBox.Show("Failed to update inventory");
            }
            Loaditems();
            cmbInvitemname.SelectedIndex = -1; 
            txtInvitemquan.Clear();
            cmbInvunit.SelectedIndex = -1;

        }

        private void btnInvremove_Click(object sender, EventArgs e)
        {
            if (dgvInventoryitem.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item first");
                return;
            }
            int itemId = Convert.ToInt32(
            dgvInventoryitem.SelectedRows[0].Cells["item_id"].Value);
            string query = "DELETE FROM inventory_items WHERE item_id = " + itemId;
            bool success = DatabaseHelper.Execute(query);
            if (success)
            {
                MessageBox.Show("Successfully removed item");
            }
            else
            {
                MessageBox.Show("failed to removed item");
            }
            Loaditems();
        }

        private void btnInvadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbInvitemname.Text) || txtInvitemquan.Text == ""|| cmbInvunit.SelectedIndex ==-1)
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            int QT;
            try
            {
                QT = Convert.ToInt32(txtInvitemquan.Text);
                if (QT <= 0)
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
            object exists = DatabaseHelper.GetValue(
     $"SELECT COUNT(*) FROM inventory_items WHERE item_name = '{cmbInvitemname.Text}'");
            if (Convert.ToInt32(exists) > 0)
            {
                MessageBox.Show("This item already exists in inventory");
                return;
            }
            string query = $"INSERT INTO inventory_items (item_name, quantity, unit) VALUES ('{cmbInvitemname.Text}', {QT}, '{cmbInvunit.Text}')";
            bool success = DatabaseHelper.Execute(query);
            if (success)
            {
                MessageBox.Show("item added successfully");
            }
            else
            {
                MessageBox.Show("Failed to add item");
            }
            Loaditems();
            cmbInvitemname.SelectedIndex = -1;
            txtInvitemquan.Clear();
            cmbInvunit.SelectedIndex = -1;
        }

    }
}