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

            if(cmbregrole.Text== "")
                lblregerrorrole.Visible = true;
            else
                lblregerrorrole.Visible = false;

            if (!rbreggenderM.Checked && !rbreggenderF.Checked)
                lblregerrorgender.Visible = true;
            else lblregerrorgender.Visible = false;


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
