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
    public partial class Admin_View : Form
    {
        public Admin_View()
        {
            InitializeComponent();
        }

        
        private void manage_prd_bttn_Click(object sender, EventArgs e)
        {
            this.Close();
            new Manage_Product().Show();
        }

        private void manage_customer_bttn_Click(object sender, EventArgs e)
        {
            this.Close();
            new Manage_Customer().Show();
        }

        private void top_selling_bttn_Click(object sender, EventArgs e)
        {
            this.Close();
            new Top_Selling().Show();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Log_In().Show();
        }

        private void warehouse_dis_bttn_Click(object sender, EventArgs e)
        {
            this.Close();
            new Admin.Warehouse_Distribution().Show();
        }

        private void sales_report_bttn_Click(object sender, EventArgs e)
        {
            this.Close();
            new Admin.Sales_Report().Show();
        }
    }
}
