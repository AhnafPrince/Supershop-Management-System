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
    public partial class Sales_View : Form
    {
        public Sales_View()
        {
            InitializeComponent();
        }

        private void pro_availibility_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Product_Availibility().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cashier_view_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Salesman_View().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Log_In().Show();
        }
    }
}
