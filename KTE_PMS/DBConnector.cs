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
                Insert_START_PMS();
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //conn.Close();
            Console.WriteLine("Done.");
        }

        public DataSet Get_Product()
        {
            String sql = "SELECT * FROM alarm_data ORDER BY DATETIME desc";

            DataTable dataTable1 = new DataTable();
            DataTable dataTable2 = new DataTable();
            DataTable dataTable3 = new DataTable();
            DataTable dataTable4 = new DataTable();
            DataTable dataTable5 = new DataTable();

            DataSet ds = new DataSet();
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);


            adpt.Fill(ds);
            return ds;

        }

        public void Insert_Value_to_Database()
        {
            string strDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            double voltage;
            double current;
            double power;

            voltage = Repository.Instance.samsung_bcs.System_Voltage;
            current = Repository.Instance.samsung_bcs.System_Current;
            power = Repository.Instance.samsung_bcs.System_Power;

            String sql = "INSERT INTO trend_data (DATETIME, VOLTAGE, CURRENT, POWER) " + "VALUES ('"
                + strDateTime + "','"
                + voltage.ToString() + "','"
                + current.ToString() + "','"
                + power.ToString() + "')";


            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public void Insert_Alarm_to_Database(string sz)
        {
            string[] szFault = sz.Split('|');

            String sql = "INSERT INTO alarm_data (DATETIME, CLASS, DEVICE, DESCRIPTION, IO) " + "VALUES ('"
                + szFault[0] + "','"
                + szFault[1] + "','"
                + szFault[2] + "','"
                + szFault[3] + "','"
                + szFault[4] + "')";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void Insert_START_PMS()
        {
            string strDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            String sql = "INSERT INTO alarm_data (DATETIME, CLASS, DEVICE, DESCRIPTION, IO) " + "VALUES ('"
                + strDateTime + "','"
                + "SYSTEM" + "','"
                + "PMS" + "','"
                + "PMS TURN ON" + "','"
                + "NORMAL" + "')";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void Insert_EXIT_PMS()
        {
            string strDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            String sql = "INSERT INTO alarm_data (DATETIME, CLASS, DEVICE, DESCRIPTION, IO) " + "VALUES ('"
                + strDateTime + "','"
                + "SYSTEM" + "','"
                + "PMS" + "','"
                + "PMS TURN OFF" + "','"
                + "NORMAL" + "')";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void Insert_Power()
        {
            string strDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            String sql = "INSERT INTO power_data_minute (DATETIME, PCS_CHARGE_POWER, PCS_DISCHARGE_POWER, BMS_CHARGE_POWER, BMS_DISCHARGE_POWER) " + "VALUES ('"
                + strDateTime + "','"
                + Repository.Instance.power.PCS_CHARGE_POWER + "','"
                + Repository.Instance.power.PCS_DISCHARGE_POWER + "','"
                + Repository.Instance.power.BMS_CHARGE_POWER + "','"
                + Repository.Instance.power.BMS_DISCHARGE_POWER + "')";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void Insert_Power_Hour()
        {
            string strYesterday = DateTime.Now.AddHours(-1).ToString("yyyy-MM-dd HH:00:00");
            string strToday = DateTime.Now.ToString("yyyy-MM-dd HH:00:00");

            String sql = "SELECT * FROM power_data_minute WHERE DATETIME BETWEEN '"+ strYesterday + "' and '"+ strToday + "' ORDER BY DATETIME desc";

            DataSet ds = new DataSet();


            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds);

            sPower total_power = GetPowerFromDatabase(ds);

            sql = "INSERT INTO power_data_hour (DATETIME, PCS_CHARGE_POWER, PCS_DISCHARGE_POWER, BMS_CHARGE_POWER, BMS_DISCHARGE_POWER) " + "VALUES ('"
                + strYesterday + "','"
                + total_power.PCS_CHARGE_POWER + "','"
                + total_power.PCS_DISCHARGE_POWER + "','"
                + total_power.BMS_CHARGE_POWER + "','"
                + total_power.BMS_DISCHARGE_POWER + "')";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public void Insert_Power_Day()
        {
            string strYesterday = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd 00:00:00");
            string strToday = DateTime.Now.ToString("yyyy-MM-dd 00:00:00");
            String sql = "SELECT * FROM power_data_hour WHERE DATETIME BETWEEN '" + strYesterday + "' and '" + strToday + "' ORDER BY DATETIME desc";

            DataSet ds = new DataSet();
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds);

            sPower total_power = GetPowerFromDatabase(ds);

            sql = "INSERT INTO power_data_day (DATETIME, PCS_CHARGE_POWER, PCS_DISCHARGE_POWER, BMS_CHARGE_POWER, BMS_DISCHARGE_POWER) " + "VALUES ('"
                + strYesterday + "','"
                + total_power.PCS_CHARGE_POWER + "','"
                + total_power.PCS_DISCHARGE_POWER + "','"
                + total_power.BMS_CHARGE_POWER + "','"
                + total_power.BMS_DISCHARGE_POWER + "')";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public void Insert_Power_Month()
        {
            string strYesterday = DateTime.Now.AddMonths(-1).ToString("yyyy-MM-01 00:00:00");
            string strToday = DateTime.Now.ToString("yyyy-MM-01 00:00:00");

            String sql = "SELECT * FROM power_data_day WHERE DATETIME BETWEEN '" + strYesterday + "' and '" + strToday + "' ORDER BY DATETIME desc";

            DataSet ds = new DataSet();
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds);

            sPower total_power = GetPowerFromDatabase(ds);

            sql = "INSERT INTO power_data_month (DATETIME, PCS_CHARGE_POWER, PCS_DISCHARGE_POWER, BMS_CHARGE_POWER, BMS_DISCHARGE_POWER) " + "VALUES ('"
                + strYesterday + "','"
                + total_power.PCS_CHARGE_POWER + "','"
                + total_power.PCS_DISCHARGE_POWER + "','"
                + total_power.BMS_CHARGE_POWER + "','"
                + total_power.BMS_DISCHARGE_POWER + "')";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        public void Insert_Power_year()
        {
            string strYesterday = DateTime.Now.AddYears(-1).ToString("yyyy-01-01 00:00:00");
            string strToday = DateTime.Now.ToString("yyyy-01-01 00:00:00");

            String sql = "SELECT * FROM power_data_month WHERE DATETIME BETWEEN '" + strYesterday + "' and '" + strToday + "' ORDER BY DATETIME desc";

            DataSet ds = new DataSet();
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds);

            sPower total_power = GetPowerFromDatabase(ds);

            sql = "INSERT INTO power_data_year (DATETIME, PCS_CHARGE_POWER, PCS_DISCHARGE_POWER, BMS_CHARGE_POWER, BMS_DISCHARGE_POWER) " + "VALUES ('"
                + strYesterday + "','"
                + total_power.PCS_CHARGE_POWER + "','"
                + total_power.PCS_DISCHARGE_POWER + "','"
                + total_power.BMS_CHARGE_POWER + "','"
                + total_power.BMS_DISCHARGE_POWER + "')";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
        private sPower GetPowerFromDatabase(DataSet ds)
        {
            sPower power = new sPower();
            int total_count = new int();

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    power.PCS_CHARGE_POWER = power.PCS_CHARGE_POWER + Convert.ToDouble(dr["PCS_CHARGE_POWER"]);
                    power.PCS_DISCHARGE_POWER = power.PCS_DISCHARGE_POWER + Convert.ToDouble(dr["PCS_DISCHARGE_POWER"]);
                    power.BMS_CHARGE_POWER = power.BMS_CHARGE_POWER + Convert.ToDouble(dr["BMS_CHARGE_POWER"]);
                    power.BMS_DISCHARGE_POWER = power.BMS_DISCHARGE_POWER + Convert.ToDouble(dr["BMS_DISCHARGE_POWER"]);

                    total_count = total_count + 1;
                }
            }
            if (total_count == 0) total_count = 1; // To protect zero-division Exception

            power.PCS_CHARGE_POWER = power.PCS_CHARGE_POWER / ds.Tables.Count;
            power.PCS_DISCHARGE_POWER = power.PCS_DISCHARGE_POWER / ds.Tables.Count;
            power.BMS_CHARGE_POWER = power.BMS_CHARGE_POWER / ds.Tables.Count;
            power.BMS_DISCHARGE_POWER = power.BMS_DISCHARGE_POWER / ds.Tables.Count;

            return power;
        }
    }

}
