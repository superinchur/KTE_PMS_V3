using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace KTE_PMS
{
    public class DBConnector
    {
        private static string connStr;
        private static MySqlConnection conn;
        public DBConnector()
        {
            try
            {
                connStr = "DATABASE=mysql; server = localhost; port = 3306; user id = root; password = 1234; database = mysql; persist security info = true; CharSet = utf8; SslMode = none";
                conn = new MySqlConnection(connStr);

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //conn.Close();
            Console.WriteLine("Done.");
        }

        public void Insert_Voltage()
        {
         
            string strDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            
            //String sql = "INSERT INTO trend_data (DATETIME, VOLTAGE) " + "VALUES ('" + strDateTime + "','" + rand_num.Next(100) + "')";

            
            //MySqlCommand cmd = new MySqlCommand(sql, conn);
            //cmd.ExecuteNonQuery();
        }

        public DataSet GetProduct()
        {
            DataSet ds = new DataSet();

            String sql = "SELECT * FROM alarm_data ORDER BY DATETIME desc";
          
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);

            adpt.Fill(ds);

            return ds;

        }
    }

}
