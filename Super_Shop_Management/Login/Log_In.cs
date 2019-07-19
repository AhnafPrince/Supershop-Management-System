using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Super_Shop_Management
{
    public partial class Log_In : Form
    {
        private String admin_name, admin_passwd;
        private String sales_name, sales_passwd;

        public Log_In()
        {
            InitializeComponent();
            admin_name = "arf";
            admin_passwd = "123";
            sales_name = "krf";
            sales_passwd = "345";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void admin_rbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Log_In_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (admin_rbtn.Checked == true)
            {
                if (username.Text.ToString() == admin_name && password.Text.ToString() == admin_passwd)
                {
                    new Admin_View().Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
                
            }

            if (salesman_rbtn.Checked == true)
            {
                if (username.Text.ToString() == sales_name && password.Text.ToString() == sales_passwd)
                {
                    new Sales_View().Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
            }

        }
    }
}
