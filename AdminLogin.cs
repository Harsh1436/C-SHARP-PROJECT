using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarraigeHallMan
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(PassTb.Text == "")
            {
                MessageBox.Show("Enter the Admin Password");
            }
            else if(PassTb.Text == "Mycodespace")
            {
                Staff staff = new Staff();
                staff.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("incorrect Admin Password **** Contact the Admin of the System");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
