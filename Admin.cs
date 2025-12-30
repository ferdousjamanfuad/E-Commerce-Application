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

        private void btnexitadmin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void tocustomer_Click(object sender, EventArgs e)
        {
            tabControlmain.SelectedTab = Customer;
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
    }
}
