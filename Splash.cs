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
    public partial class splash : Form
    {
        private int start = 0;
        public splash()
        {
            InitializeComponent();
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Value = start;
            start += 1;
            lblpercentage.Text = progressBar.Value + "%";
            if (progressBar.Value == 100)
            {
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
