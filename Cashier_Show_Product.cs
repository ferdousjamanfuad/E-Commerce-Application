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
    public partial class Cashier_Show_Product : Form
    {
        public Cashier_Show_Product()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DataTable dt = DatabaseHelper.GetData("SELECT * FROM products");

            dgv_Cashier_Product.DataSource = dt;
            int lowStock = 5;

            foreach (DataGridViewRow row in dgv_Cashier_Product.Rows)
            {
                if (row.IsNewRow) continue;  // skip empty row

                object qtyObj = row.Cells["quantity"].Value;
                if (qtyObj == null) continue;

                if (!int.TryParse(qtyObj.ToString(), out int qty)) continue;

                if (qty <= lowStock)
                {

                    string productName = row.Cells["product_name"].Value?.ToString() ?? "Unknown";
                    MessageBox.Show($"Stock Alert: '{productName}' is low ({qty} left)!", "Low Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   
                }
            }
        }



        private void btnback_Click(object sender, EventArgs e)
        {
            Cashier c = new Cashier();
            c.Show();
            this.Close();
        }
    }
}
