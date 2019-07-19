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
    public partial class Sales_Report : Form
    {
        private Database.DatabaseHandler db;
        private String query, dateTimefrom, dateTimeto;

        public Sales_Report()
        {
            InitializeComponent();
            db = new Database.DatabaseHandler();
        }

       

        private void ok_bttn_Click(object sender, EventArgs e)
        {
            db.openConnection();
            dateTimefrom = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            dateTimeto = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            String[] columns = new[] { "Total_Cost", "Total_Sold", "report" };

            List<List<String>> list = new List<List<string>>();

            query = "SELECT SUM(warehouse.Price) as Total_Cost,SUM(transaction.Total_Price) as Total_Sold,( SUM(warehouse.Price) - SUM(transaction.Total_Price) ) as report " +
                    "FROM transaction, warehouse " +
                    "WHERE warehouse.S_Date between '" + dateTimefrom + "' AND '" + dateTimeto +
                    "' AND transaction.Date between '" + dateTimefrom + "' AND '" + dateTimeto + "'";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, db.getmyConn());

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    List<String> arr = new List<string>();
                    
                    for (int i = 0; i < 3; i++)
                    {
                        arr.Add(dataReader[columns[i]].ToString());

                    }
                    list.Add(arr);
                }
                dataReader.Close();

                dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    String report = null;
                    report = dataReader.GetString(2);

                    int rep = Convert.ToInt32(report);

                    if (rep < 0)
                    {
                        columns[2] = "Loss";
                        rep = Math.Abs(rep);
                        list[0][2] = Convert.ToString(rep);
                    }
                    else
                    {
                        columns[2] = "Benefit";
                    }
                }
                dataReader.Close();

                DataTable dt = new DataTable();

                for (int j = 0; j < 3; j++)
                {
                    dt.Columns.Add(columns[j]);
                }
                foreach (var array in list)
                {
                    dt.Rows.Add(array.ToArray());
                }

                salesReportView.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            db.closeConnection();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Admin_View().Show();
        }
    }
}
