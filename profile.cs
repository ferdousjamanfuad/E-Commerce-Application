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
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }

        private void btnbackadmindashboard_Click(object sender, EventArgs e)
        {
            if (Session.Role == "Admin")
            {
                Admin admin = new Admin();
                admin.Show();
            }
            else if (Session.Role == "Production Manager")
            {
                ProductionManager pm = new ProductionManager();
                pm.Show();
            }
            else if (Session.Role == "Cashier")
            {
                Cashier ch = new Cashier();
                ch.Show();
            }
            else if (Session.Role == "Inventory Manager")
            {
                InventoryManager im = new InventoryManager();
                im.Show();
            }
            else
            {
                MessageBox.Show("Access denied");
            }

            this.Close();
        }
        private void profile_Load_1(object sender, EventArgs e)
        {
            lblprofileuserid.Text = "User ID: " + Session.UserId;
            if(Session.Role=="Admin")
                lblprofilename.Text = "Name: " + "Fuad";
            else
                lblprofilename.Text = "Name: " + Session.Name;
            lblprofilerole.Text = "Role: " + Session.Role;

            object joinDate = DatabaseHelper.GetValue(
                "SELECT created_date FROM users WHERE user_id = " + Session.UserId);

            if (joinDate != null)
            {
                lblprofilejoiningdate.Text =
                    "Joined On: " +
                    Convert.ToDateTime(joinDate).ToString("yyyy-MM-dd");
            }
            else
            {
                lblprofilejoiningdate.Text = "Joined On: N/A";
            }
        }
    }
}
