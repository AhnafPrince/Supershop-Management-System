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
    public partial class Manage_Customer : Form
    {

        private Database.DatabaseHandler db;
        private String query;
        private int num;
        private int id;
        private String email;
        //private MySqlConnection connection = new MySqlConnection(connectionString);
        public Manage_Customer()
        {
            InitializeComponent();
        }

        

        private void view_customer_details()
        {
            db = new Database.DatabaseHandler();

            db.openConnection();

            //query = "SELECT * FROM customer";
            query = "SELECT c.C_Name, c.Email, m.Type from customer as c inner join membership as m on c.M_ID = m.M_ID";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());

                MySqlDataAdapter myAdapter = new MySqlDataAdapter();

                myAdapter.SelectCommand = cmd;

                DataTable dt = new DataTable();

                myAdapter.Fill(dt);

                customerGridView.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            db.closeConnection();
        }


        private void customer_Insert_Click(object sender, EventArgs e)
        {
            db = new Database.DatabaseHandler();
            db.openConnection();

            //int num;
            String type = customer_comboBox.Text;

            MessageBox.Show(type);

            if (string.Equals(type, "silver", StringComparison.OrdinalIgnoreCase))
                num = 2;
            else if (string.Equals(type, "gold", StringComparison.OrdinalIgnoreCase))
                num = 3;
            else if (string.Equals(type, "platinum", StringComparison.OrdinalIgnoreCase))
                num = 4;
            else
                num = 1;
            query = "INSERT INTO customer(C_Name,Email,M_ID) VALUES('" + customer_Fname.Text + "','" + customer_Email.Text + "'," + num + ")";
            
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Inserted");
                view_customer_details();
                
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }

            db.closeConnection();

        }

        
        private void customer_View_Click(object sender, EventArgs e)
        {
            view_customer_details();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customer_Update_Click(object sender, EventArgs e)
        {
            db = new Database.DatabaseHandler();
            db.openConnection();

            String type = customer_comboBox.Text;

            //MessageBox.Show(type);

            if (string.Equals(type, "silver", StringComparison.OrdinalIgnoreCase))
                num = 2;
            else if (string.Equals(type, "gold", StringComparison.OrdinalIgnoreCase))
                num = 3;
            else if (string.Equals(type, "platinum", StringComparison.OrdinalIgnoreCase))
                num = 4;
            else
                num = 1;


            string i = Convert.ToString(id);
            //MessageBox.Show(i);


            query = "UPDATE customer SET C_Name='" + customer_Fname.Text + "'" +
                " , Email = '" + customer_Email.Text + "' , M_ID =" + num + " where Email ='" + email+"'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Updated");

                view_customer_details();
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }
            db.closeConnection();
        }

        private void customerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void customer_Delete_Click(object sender, EventArgs e)
        {
            db = new Database.DatabaseHandler();
            db.openConnection();

            query = "DELETE FROM customer WHERE Email ='" + email + "'";
            //MessageBox.Show(email);

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Deleted");
                view_customer_details();
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }
            db.closeConnection();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Admin_View().Show();
        }

        private void customerGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            email = customerGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }

    
}
