using System;
using System.Data;

namespace KTE_PMS
{
    public class DBConnector
    {

        public DBConnector()
        {
            //string connStr = "server=127.0.0.1;user=root;database=mysql;port=3306;password=1234";
            //MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                DataSet ds = new DataSet();
                Console.WriteLine("Connecting to MySQL...");
                //conn.Open();

                //String sql = "INSERT INTO alarmhistory (Al_Start_Time, Al_Start_Time, Al_Tag) " + "VALUES ('2017-10-13 15:47:00', 567, 'ID1')";

              //  MySqlCommand cmd = new MySqlCommand(sql, conn);
                //cmd.ExecuteNonQuery();

                /*
                String sql = "SELECT * FROM alarmhistory";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "Al_Start_Time");
                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow r in ds.Tables[0].Rows)
                    {
                        Console.WriteLine(r["Al_Start_Time"]);
                    }
                }
                */
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //conn.Close();
            Console.WriteLine("Done.");
        }


    }

}
