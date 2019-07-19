using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Super_Shop_Management.Salesman
{
    public partial class Check_Membership : Form
    {
        private int id = 0;
        private int mid;
        private Database.DatabaseHandler db;
        private String query;
        Salesman_View sv = new Salesman_View();


        public Check_Membership()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Salesman_View().Show();
        }

        private void id_search_bttn_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(c_id_value.Text);

            db = new Database.DatabaseHandler();
            db.openConnection();
            query = "select M_ID  from customer where C_ID=" + id;

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());
                cmd.ExecuteNonQuery();
                mid = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }
            db.closeConnection();

            sv.set_m_ID(id,mid);
            
            this.Close();
            sv.Visible = true;

        }
    }
}
