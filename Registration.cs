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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnexitreg_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btncreateacc_Click(object sender, EventArgs e)
        {
            if (txtregurname.Text == "")
                lblregerrorurname.Visible = true;
            else
                lblregerrorurname.Visible = false;

            if (txtregpass.Text == "")
                lblregerrorpass.Visible = true;
            else
                lblregerrorpass.Visible = false;

            if (txtregemail.Text == "")
                lblregerroremail.Visible = true;
            else
                lblregerroremail.Visible = false;

            if (txtregaddress.Text == "")
                lblregerroraddress.Visible = true;
            else
                lblregerroraddress.Visible = false;

            if (cmbregrole.Text == "")
                lblregerrorrole.Visible = true;
            else
                lblregerrorrole.Visible = false;

            if (!rbreggenderM.Checked && !rbreggenderF.Checked)
                lblregerrorgender.Visible = true;
            else lblregerrorgender.Visible = false;

            if (lblregerrorurname.Visible || lblregerrorpass.Visible || lblregerroremail.Visible || lblregerroraddress.Visible || lblregerrorrole.Visible || lblregerrorgender.Visible)
                return;


            string username = txtregurname.Text.Trim();
            string email = txtregemail.Text.Trim();
            string password = txtregpass.Text.Trim();
            string role = cmbregrole.Text;
            string address = txtregaddress.Text.Trim();
            string gender = rbreggenderM.Checked ? "Male" : "Female";
            string dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            int isApproved = 0;



            try
            {
                string query = $"INSERT INTO users (username, email, password, gender, role, address, dateofbirth, is_approved) " +
                $"VALUES ('{username}','{email}','{password}','{gender}','{role}','{address}','{dob}',{isApproved})";


                bool success = DatabaseHelper.Execute(query);
                if (success)
                {
                    MessageBox.Show(
                    "Registration successful \n Please wait for admin approval",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Registration failed");
                }
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Error:" + ex.Message);
                }

            }

                if (!lblregerrorurname.Visible && !lblregerrorpass.Visible && !lblregerroremail.Visible &&
                       !lblregerroraddress.Visible && !lblregerrorrole.Visible && !lblregerrorgender.Visible)
                {
                    this.Close();
                    Login login = new Login();
                    login.Show();
                }
        }
        private void Registration_Load(object sender, EventArgs e)
        {
            lblregerrorurname.Visible = false;
            lblregerrorpass.Visible = false;
            lblregerroremail.Visible = false;
            lblregerroraddress.Visible = false;
            lblregerrorrole.Visible = false;
            lblregerrorgender.Visible = false;
        }

        private void btnregclr_Click(object sender, EventArgs e)
        {
            txtregurname.Text = "";
            txtregpass.Text = "";
            txtregemail.Text = "";
            txtregaddress.Text = "";
            cmbregrole.SelectedIndex = -1;
            rbreggenderM.Checked = false;
            rbreggenderF.Checked = false;
            lblregerrorurname.Visible = false;
            lblregerrorpass.Visible = false;
            lblregerroremail.Visible = false;
            lblregerroraddress.Visible = false;
            lblregerrorrole.Visible = false;
            lblregerrorgender.Visible = false;

        }
    }
}
