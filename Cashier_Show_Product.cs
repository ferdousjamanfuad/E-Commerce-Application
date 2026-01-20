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
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Cashier c = new Cashier();
            c.Show();
            this.Close();
        }
    }
}
