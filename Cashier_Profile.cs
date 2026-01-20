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
    public partial class Cashier_Profile : Form
    {
        public Cashier_Profile()
        {
            InitializeComponent();
        }

        private void Cashier_Profile_Load(object sender, EventArgs e)
        {
            lbl_Cash_Pro_Id.Text = "User ID: " + Session.UserId;
            lbl_Cash_Pro_Name.Text = "Logged in As: " + Session.Name;
            lbl_Cash_Pro_Role.Text = "Role: " + Session.Role;
            lbl_Cash_Pro_Email.Text = "Email: " + DatabaseHelper.GetValue("SELECT email FROM users WHERE user_id=" + Session.UserId);
            lbl_Cash_Pro_Gender.Text = "Gender: " + DatabaseHelper.GetValue("SELECT gender FROM users WHERE user_id=" + Session.UserId);
            lbl_Cash_Pro_Address.Text = "Address: " + DatabaseHelper.GetValue("SELECT address FROM users WHERE user_id=" + Session.UserId);
            lbl_Cash_Pro_Joindate.Text = "Joining Date: " + Convert.ToDateTime(DatabaseHelper.GetValue("SELECT created_date FROM users WHERE user_id=" + Session.UserId)).ToString("yyyy-MM-dd");
        }
     

        private void btnCashier_PassChange_Click(object sender, EventArgs e)
        {
            Cashier_PassChange pc = new Cashier_PassChange();
            pc.Show();
            this.Hide();
        }

        private void btnCashier_Profile_Dashboard_Click_1(object sender, EventArgs e)
        {
            Cashier cash = new Cashier();
            cash.Show();
            this.Close();
        }
    }
}
