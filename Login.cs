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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BakeryShopManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txturname.Text = "";
            txtpass.Text = "";
        }

        private void btnlgn_Click(object sender, EventArgs e)
        {
            string username = txturname.Text.Trim();
            string password = txtpass.Text.Trim();

            if (txturname.Text == "")
              lblerrorurname.Visible = true;
            else
                lblerrorurname.Visible = false;

            if (txtpass.Text == "")
                  lblerrorpass.Visible = true;
              else
                  lblerrorpass.Visible = false;

            if (txturname.Text == "" || txtpass.Text == "")
                return;

            try
            {
                DataTable dt = DatabaseHelper.GetData($"select user_id,username,role from users where username='{username}' and password='{password}' and is_approved=1");

                if (dt.Rows.Count > 0)
                {
                    Session.UserId = Convert.ToInt32(dt.Rows[0]["user_id"]);
                    Session.Name=dt.Rows[0]["username"].ToString();
                    Session.Role = dt.Rows[0]["role"].ToString();


                    if (Session.Role == "Admin")
                    {
                        this.Hide();
                        Admin admin = new Admin();
                        admin.Show();
                    }
                    else if (Session.Role == "Cashier")
                    {
                        this.Hide();
                        Cashier cashier = new Cashier();
                        cashier.Show();
                    }
                    else if (Session.Role == "ProductionManager")
                    {
                        this.Hide();
                        ProductionManager pm = new ProductionManager();
                        pm.Show();
                    }
                    else if (Session.Role == "InventoryManager")
                    {
                        this.Hide();
                        InventoryManager im = new InventoryManager();
                        im.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Role");
                    }


                }
                else
                {
                    MessageBox.Show("Invalid User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txturname.Text = "";
                    txtpass.Text = "";
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Database Error:" + ex.Message);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblerrorurname.Visible = false;
            lblerrorpass.Visible = false;
        }

        private void linklblreg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }
    }
}