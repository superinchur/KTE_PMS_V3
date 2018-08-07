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

            DataSet ds = new DataSet();
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);

            adpt.Fill(ds);
            return ds;

        }
        public void Export_Data()
        {
            try
            {
                string directory = System.Windows.Forms.Application.StartupPath;
                string filename = "\\DB_Data_" + DateTime.Now.ToString("yyyyMMddHHmmss")+ ".csv";
                //string directory = "";
                //string filename = "DB_Data_" + DateTime.Now.ToString("yyyyMMddHHmmss")+ ".csv";

                String sql = "SELECT * INTO OUTFILE '" + directory + filename + "' "
                                 + "fields terminated by '\t' "
                                 + "lines terminated by '\r\n' "
                                 + "FROM power_data_hour";
                sql = sql.Replace("\\", "\\\\");
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                ExceptionManagement(ex);


            }
            

        }

        private void ExceptionManagement(Exception ex)
        {
            if (ex.Message == "Connection must be valid and open.")
            {
                DBConnector a = new DBConnector();

                Repository.Instance.dbConnector = a;

            }
        }

        public DataSet Get_Product(string strstartTime,string strendTime)
        {
            String sql = "SELECT * FROM alarm_data WHERE DATETIME BETWEEN '" + strstartTime + "' and '" + strendTime + "' ORDER BY DATETIME desc";

            DataSet ds = new DataSet();
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);


            adpt.Fill(ds);
            return ds;
        }

        public void Insert_BSC_Value_to_Database()
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ExceptionManagement(ex);
            }
        }
        public void Insert_BSC_Value_to_Database(string nameofDB, double voltage, double current, double power)
        {
            try
            {
                string strDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                String sql = "INSERT INTO " + nameofDB + "(DATETIME, VOLTAGE, CURRENT, POWER) " + "VALUES ('"
                    + strDateTime + "','"
                    + voltage.ToString() + "','"
                    + current.ToString() + "','"
                    + power.ToString() + "')";


                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ExceptionManagement(ex);
            }
        }

        public void Insert_Value_to_Database(string nameofDB, double voltage, double current, double power)
        {
            try
            {
                string strDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                String sql = "INSERT INTO " + nameofDB + "(DATETIME, VOLTAGE, CURRENT, POWER) " + "VALUES ('"
                    + strDateTime + "','"
                    + voltage.ToString() + "','"
                    + current.ToString() + "','"
                    + power.ToString() + "')";


                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ExceptionManagement(ex);
            }
        }

        public void Insert_Alarm_to_Database(string sz)
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ExceptionManagement(ex);
            }
        }
        public void Insert_START_PMS()
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ExceptionManagement(ex);
            }
        }
        public void Insert_EXIT_PMS()
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ExceptionManagement(ex);
            }
        }
        public void Insert_Power()
        {
            try
            {
                string strDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:00");


                sPower temp = Repository.Instance.p_setting.power.GetValue();

                String sql = "INSERT INTO power_data_minute (DATETIME, PCS_CHARGE_POWER, PCS_DISCHARGE_POWER, BMS_CHARGE_POWER, BMS_DISCHARGE_POWER) " + "VALUES ('"
                    + strDateTime + "','"
                    + temp.PCS_CHARGE_POWER + "','"
                    + temp.PCS_DISCHARGE_POWER + "','"
                    + temp.BMS_CHARGE_POWER + "','"
                    + temp.BMS_DISCHARGE_POWER + "')";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ExceptionManagement(ex);
            }
        }
        public void Insert_Power_Hour()
        {
            try
            {
                string strYesterday = DateTime.Now.AddHours(-1).ToString("yyyy-MM-dd HH:00:00");
                string strToday = DateTime.Now.ToString("yyyy-MM-dd HH:00:00");

                String sql = "SELECT * FROM power_data_minute WHERE DATETIME BETWEEN '"+ strYesterday + "' and '"+ strToday + "' ORDER BY DATETIME desc";

                DataSet ds = new DataSet();


                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds);

                sPower total_power = GetAveragePowerFromDatabase(ds);

                sql = "INSERT INTO power_data_hour (DATETIME, PCS_CHARGE_POWER, PCS_DISCHARGE_POWER, BMS_CHARGE_POWER, BMS_DISCHARGE_POWER) " + "VALUES ('"
                    + strYesterday + "','"
                    + total_power.PCS_CHARGE_POWER + "','"
                    + total_power.PCS_DISCHARGE_POWER + "','"
                    + total_power.BMS_CHARGE_POWER + "','"
                    + total_power.BMS_DISCHARGE_POWER + "')";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();


                ////////////////////////////////////////////////////////////////////////////////
                //////////////////////// 전력값 누적을 위해서 하는 항목  ///////////////////////
                ////////////////////////////////////////////////////////////////////////////////
                String sql2 = "SELECT * FROM power_data_hour_accu ORDER BY DATETIME desc LIMIT 1";
                DataSet ds2 = new DataSet();
                MySqlDataAdapter adpt2 = new MySqlDataAdapter(sql2, conn);
                adpt2.Fill(ds2);
                sPower total_power2 = GetAveragePowerFromDatabase(ds2);
                sql2 = "INSERT INTO power_data_hour_accu (DATETIME, PCS_CHARGE_POWER, PCS_DISCHARGE_POWER, BMS_CHARGE_POWER, BMS_DISCHARGE_POWER) " + "VALUES ('"
                    //+ strYesterday + "','"
                    + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','"
                    + (total_power.PCS_CHARGE_POWER + total_power2.PCS_CHARGE_POWER) + "','"
                    + (total_power.PCS_DISCHARGE_POWER + total_power2.PCS_DISCHARGE_POWER) + "','"
                    + (total_power.BMS_CHARGE_POWER + total_power2.BMS_CHARGE_POWER) + "','"
                    + (total_power.BMS_DISCHARGE_POWER + total_power2.BMS_DISCHARGE_POWER) + "')";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                cmd2.ExecuteNonQuery();
                ////////////////////////////////////////////////////////////////////////////////
                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ExceptionManagement(ex);
            }
        }

        public void Insert_Power_Day()
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ExceptionManagement(ex);
            }
        }

        public void Insert_Power_Month()
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ExceptionManagement(ex);
            }
        }
        public void Insert_Power_year()
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ExceptionManagement(ex);
            }
        }

        private  sPower GetAveragePowerFromDatabase(DataSet ds)
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

            power.PCS_CHARGE_POWER = power.PCS_CHARGE_POWER / total_count;
            power.PCS_DISCHARGE_POWER = power.PCS_DISCHARGE_POWER / total_count;
            power.BMS_CHARGE_POWER = power.BMS_CHARGE_POWER / total_count;
            power.BMS_DISCHARGE_POWER = power.BMS_DISCHARGE_POWER / total_count;

            return power;
        }


        private sPower GetPowerFromDatabase(DataSet ds)
        {
            sPower power = new sPower();

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    power.PCS_CHARGE_POWER = power.PCS_CHARGE_POWER + Convert.ToDouble(dr["PCS_CHARGE_POWER"]);
                    power.PCS_DISCHARGE_POWER = power.PCS_DISCHARGE_POWER + Convert.ToDouble(dr["PCS_DISCHARGE_POWER"]);
                    power.BMS_CHARGE_POWER = power.BMS_CHARGE_POWER + Convert.ToDouble(dr["BMS_CHARGE_POWER"]);
                    power.BMS_DISCHARGE_POWER = power.BMS_DISCHARGE_POWER + Convert.ToDouble(dr["BMS_DISCHARGE_POWER"]);

                }
            }

            power.PCS_CHARGE_POWER = power.PCS_CHARGE_POWER;
            power.PCS_DISCHARGE_POWER = power.PCS_DISCHARGE_POWER;
            power.BMS_CHARGE_POWER = power.BMS_CHARGE_POWER;
            power.BMS_DISCHARGE_POWER = power.BMS_DISCHARGE_POWER;

            return power;
        }

        public void Select_Power()
        {
            try
            {
                string str_start = DateTime.Now.ToString("yyyy-MM-dd 00:00:00");
                string str_end = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                String sql = "SELECT * FROM power_data_hour WHERE DATETIME BETWEEN '" + str_start + "' and '" + str_end + "' ORDER BY DATETIME desc";

                DataSet ds = new DataSet();
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds);

                Repository.Instance.p_setting.power_day = GetPowerFromDatabase(ds);

                //
                str_start = DateTime.Now.ToString("yyyy-MM-01 00:00:00");
                str_end = DateTime.Now.ToString("yyyy-MM-dd 00:00:00");

                sql = "SELECT * FROM power_data_day WHERE DATETIME BETWEEN '" + str_start + "' and '" + str_end + "' ORDER BY DATETIME desc";

                ds.Clear();
                adpt.Dispose();

                adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds);

                Repository.Instance.p_setting.power_month = Repository.Instance.p_setting.power_day + GetPowerFromDatabase(ds);

                //
                str_start = DateTime.Now.ToString("yyyy-01-01 00:00:00");
                str_end = DateTime.Now.ToString("yyyy-MM-dd 00:00:00");

                sql = "SELECT * FROM power_data_month WHERE DATETIME BETWEEN '" + str_start + "' and '" + str_end + "' ORDER BY DATETIME desc";

                ds.Clear();
                adpt.Dispose();

                adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds);

                Repository.Instance.p_setting.power_year = Repository.Instance.p_setting.power_month + GetPowerFromDatabase(ds);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
