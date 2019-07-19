using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Super_Shop_Management.Database
{
    class DatabaseHandler
    {
        private MySqlConnection myConn;
        private String usr_id, password,database,server;
        private String conn;
    
        public void openConnection()
        {
            this.database = "super_shop";
            this.server = "localhost";
            this.usr_id = "root";
            this.password = "";
            
            conn = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + usr_id + ";" + "PASSWORD=" + password + ";";
            
            myConn = new MySqlConnection(conn);

            try
            {
                myConn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public MySqlConnection getmyConn()
        {
            return myConn;
        }

        public void closeConnection()
        {
            try
            {
                myConn.Close();
                
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
