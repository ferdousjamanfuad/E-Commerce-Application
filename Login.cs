using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce_Application
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
            if (txturname.Text == "")
              lblerrorurname.Visible = true;
            else
                lblerrorurname.Visible = false;

            if (txtpass.Text == "")
                  lblerrorpass.Visible = true;
              else
                  lblerrorpass.Visible = false;



            if (txturname.Text == "admin" && txtpass.Text == "admin")
            {
                this.Hide();
                Admin admin = new Admin();
                admin.Show();
            }
            else if (txturname.Text == "employee" && txtpass.Text == "employee")
            {
                this.Hide();
                Employee employee = new Employee();
                employee.Show();
            }
            else if (txturname.Text == "user" && txtpass.Text == "user")
            {
                this.Hide();
                User user = new User();
                user.Show();
            }
            else
            {
                if (txturname.Text != "" && txtpass.Text != "")
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txturname.Text = "";
                    txtpass.Text = "";
                }
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