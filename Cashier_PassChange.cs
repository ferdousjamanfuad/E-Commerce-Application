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
    public partial class Cashier_PassChange : Form
    {
        public Cashier_PassChange()
        {
            InitializeComponent();
        }

        private void btnRetunr_Cash_Profile_Click(object sender, EventArgs e)
        {
            Cashier_Profile cp=new Cashier_Profile();
            cp.Show();
            this.Close();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPass.Text;
            string newPassword = txtNewPass.Text;
            string confirmPassword = txtConfirmPass.Text;

            if (oldPassword == "" || newPassword == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill all the boxes.");
                return;
            }
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.");
                return;
            }
            string checkQuery = "SELECT COUNT(*) FROM users WHERE user_id = " + Session.UserId + " AND password = '" + oldPassword + "'";
            object result = DatabaseHelper.GetValue(checkQuery);

            if (Convert.ToInt32(result) == 0)
            {
                MessageBox.Show("Old password is incorrect.");
                return;
            }
            string updateQuery = "UPDATE users SET password = '" + newPassword + "' WHERE user_id = " + Session.UserId;

            if (DatabaseHelper.Execute(updateQuery))
            {
                MessageBox.Show("Password changed successfully!");
                Cashier_Profile cp = new Cashier_Profile();
                cp.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to change password. Please try again.");
            }

        }

        bool showPassword = false;

        private void btnEye_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;

            txtOldPass.UseSystemPasswordChar = !showPassword;
            txtNewPass.UseSystemPasswordChar = !showPassword;
            txtConfirmPass.UseSystemPasswordChar = !showPassword;
        }
    }
}
