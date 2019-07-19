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
    public partial class Top_Selling : Form
    {
        private Database.DatabaseHandler db;
        private String query;
        String cat_name = "";
        private String fromDate, toDate;

        public Top_Selling()
        {
            InitializeComponent();
            loadCategory();
        }

        private void loadCategory()
        {
            db = new Database.DatabaseHandler();

            db.openConnection();

            query = "SELECT C_Name FROM category";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    top_pro_cat.Items.Add(dataReader.GetString("C_Name"));
                    cat_name = dataReader.GetString("C_Name");
                }

                top_pro_cat.Show();

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

        private void top_sell_search_Click(object sender, EventArgs e)
        {
            cat_name = top_pro_cat.SelectedItem.ToString();
            fromDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            toDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            db = new Database.DatabaseHandler();

            db.openConnection();

            query = "SELECT p.P_Name FROM product as p INNER JOIN transaction as t on t.P_ID = p.P_ID INNER JOIN category as c on c.C_ID = p.C_ID"+
                " WHERE t.Date between '" + fromDate + "' AND '" + toDate +"' "+
                "AND c.C_Name = '" + cat_name + "' GROUP BY p.P_Name ORDER BY sum(t.Quantity) DESC";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();

                myAdapter.SelectCommand = cmd;

                DataTable dt = new DataTable();

                myAdapter.Fill(dt);

                topSellGridView.DataSource = dt;
                topSellGridView.AutoResizeColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            db.closeConnection();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Admin_View().Show();
        }
    }
}
