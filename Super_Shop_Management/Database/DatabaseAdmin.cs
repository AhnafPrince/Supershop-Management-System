using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Super_Shop_Management.Database
{
    class DatabaseAdmin
    {
        private DatabaseHandler db;
        private String query;
        private String p_id;
        public DatabaseAdmin()
        {
            this.db = new DatabaseHandler();
        }

        public void warehouseAdd(String p_name, String s_Date, String p_Quantity, String p_Price)
        {
            db.openConnection();

            query = "SELECT P_ID FROM product where P_Name='" + p_name + "'";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());

                p_id = cmd.ExecuteScalar().ToString();

                query = "INSERT INTO warehouse(S_Date,P_ID,P_Quantity,Price) VALUES('" + s_Date + "','" + p_id + "','" + p_Quantity + "','" + p_Price + "')";
                MySqlCommand cmd1 = new MySqlCommand(query, db.getmyConn());

                cmd1.ExecuteNonQuery();

                MessageBox.Show("Inserted");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.closeConnection();
        }

        public void warehouseUpdate(String s_ID, String s_Date, String p_Quantity, String p_Price)
        {
            db.openConnection();

            query = "UPDATE warehouse as wh SET wh.P_ID = '" + p_id + "', wh.P_Quantity = '" + p_Quantity + "',wh.Price = '" + p_Price + "', wh.S_Date = '" + s_Date + "'" +
            " WHERE wh.S_ID = '" + s_ID + "'";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());
                cmd.ExecuteNonQuery();
                MessageBox.Show("updated");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            db.closeConnection();
        }

        public void productAdd(String p_name, String category, String selling_price)
        {
            db.openConnection();

            query = "INSERT INTO product(Selling_Price,P_Name,C_ID) VALUES('" + selling_price + "','" + p_name + "','" + category + "')";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            db.closeConnection();
        }

        public void deleteprod(String p_name)
        {
            db.openConnection();

            query = "DELETE FROM warehouse WHERE S_ID='" + p_name + "'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            db.closeConnection();
        }
        public void updateprod(String p_name1, String p_name2, String category, String selling_price)
        {
            db.openConnection();

            query = "SELECT P_ID FROM product where P_Name='" + p_name1 + "'";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());

                p_id = cmd.ExecuteScalar().ToString();

                query = "UPDATE product as p SET p.P_Name = '" + p_name2 + "', p.Selling_Price = '" + selling_price + "', p.C_ID = '" + category +
                "' WHERE p.P_ID = '" + p_id + "'";

                MySqlCommand cmd1 = new MySqlCommand(query, db.getmyConn());

                cmd1.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            db.closeConnection();
        }
    }
}
