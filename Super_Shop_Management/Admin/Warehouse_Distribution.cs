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

namespace Super_Shop_Management.Admin
{
    public partial class Warehouse_Distribution : Form
    {
        private Database.DatabaseHandler db;
        private String query;
        private String prod_name, branch_Name, prod_quantity;

        private void ok_bttn_Click(object sender, EventArgs e)
        {

        }

        private void insert_bttn_Click(object sender, EventArgs e)
        {
            db.openConnection();

            prod_name = product_name.Text;
            branch_Name = branch_name.Text;
            prod_quantity = product_quantity.Text;

            query = "insert into stores_in(P_ID,P_Quantity,Branch_ID) values((select p.P_ID from product as p where p.P_Name='"+prod_name+"'),"+prod_quantity+",(select b.Branch_ID from branch as b where location = '"+branch_Name+"'))";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Inserted");
                view();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Admin_View().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void update_bttn_Click(object sender, EventArgs e)
        {
            db.openConnection();

            prod_quantity = product_quantity.Text;

            query = "UPDATE stores_in SET P_Quantity = "+prod_quantity+" WHERE Branch_ID = (Select Branch_ID from branch where location = '"
                    +branch_Name+"' AND P_ID = (SELECT P_ID FROM product WHERE P_Name = '"+prod_name+"') )";
            
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Updated");
                view();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void view()
        {
            db.openConnection();

            query = "SELECT p.P_Name as 'Product Name',st.P_Quantity as 'Product Quantity',b.Location as 'Branch' FROM stores_in as st INNER JOIN product AS p ON st.P_ID = p.P_ID INNER JOIN branch as b ON st.Branch_ID = b.Branch_ID";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();

                myAdapter.SelectCommand = cmd;

                DataTable dt = new DataTable();

                myAdapter.Fill(dt);

                sales_distributeView.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.closeConnection();
        }

        private void sales_distributeView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            prod_name = sales_distributeView.Rows[e.RowIndex].Cells[0].Value.ToString();
            branch_Name = sales_distributeView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void view_bttn_Click(object sender, EventArgs e)
        {
            db.openConnection();

            query = "SELECT p.P_Name as 'Product Name',st.P_Quantity as 'Product Quantity',b.Location as 'Branch' FROM stores_in as st INNER JOIN product AS p ON st.P_ID = p.P_ID INNER JOIN branch as b ON st.Branch_ID = b.Branch_ID";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();

                myAdapter.SelectCommand = cmd;

                DataTable dt = new DataTable();

                myAdapter.Fill(dt);

                sales_distributeView.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.closeConnection();
        }

        public Warehouse_Distribution()
        {
            db = new Database.DatabaseHandler();
            InitializeComponent();
        }
    }
}
