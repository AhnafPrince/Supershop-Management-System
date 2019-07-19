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

namespace Super_Shop_Management
{
    public partial class Product_Availibility : Form
    {
        private Database.DatabaseHandler db;
        private String query;
        String search_av = "";

        public Product_Availibility()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            search_av = search_product_availibility.Text;

            db = new Database.DatabaseHandler();
            db.openConnection();

            query = "SELECT p.P_Name, s.P_Quantity, b.Location, b.Phone from product as p inner join stores_in as s on p.P_ID = s.P_ID inner join branch as b on b.Branch_ID = s.Branch_ID where p.P_Name LIKE '"+search_av+"%'";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();

                myAdapter.SelectCommand = cmd;

                DataTable dt = new DataTable();

                myAdapter.Fill(dt);

                productAvailGridView.DataSource = dt;
                productAvailGridView.AutoResizeColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            db.closeConnection();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Sales_View().Show();
        }
    }
}
