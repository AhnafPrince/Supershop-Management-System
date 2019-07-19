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
    public partial class Salesman_View : Form
    {
        private int n = 0;
        private int m_ID = 0, id = 0;
        private Database.DatabaseHandler db;
        private String query;
        private int flag = 0;

        private int q = 0, p = 0;
        private double total_Cost = 0;


        public Salesman_View()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void set_m_ID(int id, int m_ID)
        {
            this.id = id;
            this.m_ID = m_ID;
        }


        private void transactionAdd_Click(object sender, EventArgs e)
        {
            n++;

            int quantity = Convert.ToInt32(salesman_quantity.Text);


            db = new Database.DatabaseHandler();
            db.openConnection();
            int id = Convert.ToInt32(salesman_P_ID.Text);
            query = "select P_Name  from product where P_ID=" + id;
            string p_Name = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());
                cmd.ExecuteNonQuery();
                p_Name = (String)cmd.ExecuteScalar();

            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }
            db.closeConnection();
            db.openConnection();
            query = "select Selling_Price  from product where P_ID=" + id;
            //string s_Price;
            int price = 0;
            //double price = 0.0 ;

            try
            {
                //MySql.Data.MySqlClient.MySqlCommand myCommand =
                //new MySql.Data.MySqlClient.MySqlCommand(insertQuery, connection);

                //  MySql.Data.MySqlClient.MySqlCommand cmd =
                //    new MySql.Data.MySqlClient.MySqlCommand(query, db.getmyConn());

                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());
                cmd.ExecuteNonQuery();
                price = Convert.ToInt32(cmd.ExecuteScalar());
                p = price;
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }
            db.closeConnection();
            if (flag == 0)
            {
                salesman_gridview.Columns.Add("Product Barcode", "Product Barcode");
                salesman_gridview.Columns.Add("Product Name ", "Product Name ");
                salesman_gridview.Columns.Add("Price", "Price");
                salesman_gridview.Columns.Add("Quantity", "Quantity");
                flag = 1;
            }

            q = Convert.ToInt32(salesman_quantity.Text);
            total_Cost = total_Cost + (double)(p * q);
            price = p * q;
            salesman_gridview.Rows.Add(new object[] { id, p_Name, price, quantity });
        }

        private void member_bttn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Salesman.Check_Membership().Show();

        }

        private void transactionTotalAmount_Click(object sender, EventArgs e)
        {
            if (m_ID == 1)
                total_Cost = total_Cost - (total_Cost * 0.05);
            if (m_ID == 2)
                total_Cost = total_Cost - (total_Cost * 0.1);
            if (m_ID == 3)
                total_Cost = total_Cost - (total_Cost * 0.2);
            if (m_ID == 4)
                total_Cost = total_Cost - (total_Cost * 0.25);

            salesview_TotalAmountText.Text = Convert.ToString(total_Cost);
        }

        private void transactionSave_Click(object sender, EventArgs e)
        {
            db = new Database.DatabaseHandler();
            db.openConnection();

            String dates = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            for (int i = 0; i < salesman_gridview.RowCount - 1; i++)
            {
                string P_ID = salesman_gridview.Rows[i].Cells[0].Value.ToString();
                string Quantity = salesman_gridview.Rows[i].Cells[3].Value.ToString();
                string Total_Price = salesman_gridview.Rows[i].Cells[2].Value.ToString();

                //for (int i = 0; i < salesman_gridview.RowCount; i++)

                double total_Cost = Convert.ToDouble(Total_Price);
                if (m_ID == 1)
                    total_Cost = total_Cost - (total_Cost * 0.05);
                if (m_ID == 2)
                    total_Cost = total_Cost - (total_Cost * 0.1);
                if (m_ID == 3)
                    total_Cost = total_Cost - (total_Cost * 0.2);
                if (m_ID == 4)
                    total_Cost = total_Cost - (total_Cost * 0.25);

                if (i == 0)
                {
                    query = "INSERT INTO transaction(P_ID , Quantity , Total_Price , Date) VALUES('"
                            + (P_ID) + "','" + (Quantity) +
                            "','" + total_Cost + "','" + dates + "')";
                }
                else
                {
                    query = "INSERT INTO transaction " +
                            "SELECT transaction.T_ID, " +
                            "'" + (P_ID) + "','" + (Quantity) + "','" + total_Cost + "','" + dates + "' " +
                            "FROM transaction ORDER BY transaction.T_ID DESC LIMIT 1";
                }

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ev)
                {
                    MessageBox.Show(ev.ToString());
                }


            }

            if (id != 0)
            {
                try
                {
                    query = "INSERT INTO proceed " +
                            "SELECT transaction.T_ID, " +
                            "'" + id + "'"+
                            " FROM transaction ORDER BY transaction.T_ID DESC LIMIT 1";

                    MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            MessageBox.Show("Saved");

            db.closeConnection();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Sales_View().Show();
        }
    }
}
