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
    public partial class Manage_Product : Form
    {
        private Database.DatabaseHandler db;
        private Database.DatabaseAdmin dbAdmin;
        private String query;
        private String s_ID, prod_name, quantity, selling_price, s_date, buy_price, catg;

        public Manage_Product()
        {
            db = new Database.DatabaseHandler();
            dbAdmin = new Database.DatabaseAdmin();

            InitializeComponent();

            loadCategory();
        }

        private void view_bttn_Click(object sender, EventArgs e)
        {
            viewDetails();
        }

        private void pro_update_Click(object sender, EventArgs e)
        {
            catg = up_product.SelectedItem.ToString();
            selling_price = up_price.Text;
            s_date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            buy_price = warehouse_Price.Text;
            quantity = wareHouse_Inventory.Text;

            if (catg == "Electronics")
            {
                catg = "2";
            }
            else if (catg == "Cosmetics")
            {
                catg = "1";
            }
            try
            {
                dbAdmin.updateprod(prod_name, up_name.Text.ToString(), catg, selling_price);
                dbAdmin.warehouseUpdate(s_ID, s_date, quantity, buy_price);

                viewDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void productGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                dateTimePicker1.Value = Convert.ToDateTime(productGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                s_ID = getS_ID(e.RowIndex);
                up_name.Text = productGridView.Rows[e.RowIndex].Cells[1].Value.ToString();//1
                prod_name = up_name.Text;
                up_price.Text = productGridView.Rows[e.RowIndex].Cells[2].Value.ToString();//2
                warehouse_Price.Text = productGridView.Rows[e.RowIndex].Cells[4].Value.ToString();//4
                wareHouse_Inventory.Text = productGridView.Rows[e.RowIndex].Cells[3].Value.ToString();//3
                up_product.Text = productGridView.Rows[e.RowIndex].Cells[5].Value.ToString();//5
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pro_delete_Click(object sender, EventArgs e)
        {
            try
            {
                dbAdmin.deleteprod(s_ID);
                
                viewDetails();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Admin_View().Show();
        }

        private void pro_insert_Click(object sender, EventArgs e)
        {
            catg = up_product.SelectedItem.ToString();
            prod_name = up_name.Text;
            selling_price = up_price.Text;
            s_date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            buy_price = warehouse_Price.Text;
            quantity = wareHouse_Inventory.Text;

            if (catg == "Electronics")
            {
                catg = "2";
            }
            else if (catg == "Cosmetics")
            {
                catg = "1";
            }

            try
            {
                dbAdmin.productAdd(prod_name, catg, selling_price);
                dbAdmin.warehouseAdd(prod_name, s_date, quantity, buy_price);

                viewDetails();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       

        private void viewDetails()
        {
            up_product.Text = null;
            up_name.Text = null;
            up_price.Text = null;
            warehouse_Price.Text = null;
            wareHouse_Inventory.Text = null;

            db.openConnection();

            query = "SELECT w.S_Date as Supply_Date, p.P_Name as Product_Name,p.Selling_Price,w.P_Quantity as Quantity, w.Price as Buying_Price,C_Name as Category " +
                    "FROM product as p" +
                    " inner join category as c on c.C_ID = p.C_ID" +
                    " inner join warehouse as w on w.P_ID = p.P_ID";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();

                myAdapter.SelectCommand = cmd;

                DataTable dt = new DataTable();

                myAdapter.Fill(dt);

                productGridView.DataSource = dt;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            db.closeConnection();
        }

        private void loadCategory()
        {
            db.openConnection();

            query = "SELECT C_Name FROM category";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    up_product.Items.Add(dataReader.GetString("C_Name"));
                }

                up_product.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.closeConnection();
        }

        private String getS_ID(int indx)
        {
            db.openConnection();

            query = "SELECT S_ID FROM warehouse";
            List<String> arr = new List<string>();

            try
            {
                
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());

                MySqlDataReader dReader = cmd.ExecuteReader();

                while(dReader.Read())
                {
                    arr.Add(dReader["S_ID"].ToString());
                }

                dReader.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return arr[indx];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
