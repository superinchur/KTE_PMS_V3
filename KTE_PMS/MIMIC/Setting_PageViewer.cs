using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{
    public partial class Setting_PageViewer : Viewer
    {


        public TimeSpan Charging_StartTime { get; set; }
        public TimeSpan Charging_EndTime { get; set; }
        public TimeSpan Discharging_StartTime { get; set; }
        public TimeSpan Discharging_EndTime { get; set; }

        public sPower power { get; set; }
        public sPower power_day { get; set; }
        public sPower power_month { get; set; }
        public sPower power_year { get; set; }

        public float total_power { get; set; }

        public float Charging_Stop_SOC { get; set; }
        public float Discharging_Stop_SOC { get; set; }
        public float Discharging_Limit_Voltage { get; set; }
        public float Charging_Limit_Voltage { get; set; }

        public float Limit_Active_Power { get; set; }
        public bool flag_Charging_Time { get; set; }
        public bool flag_DisCharging_Time { get; set; }

        public Setting_PageViewer()
        {
            InitializeComponent();

            Initialize_Parameter_Settings();
        }

        private void Initialize_Parameter_Settings()
        {
            Charging_StartTime = new TimeSpan(08, 00, 00);
            Charging_EndTime = new TimeSpan(12, 00, 00);
            Discharging_StartTime = new TimeSpan(16, 00, 00);
            Discharging_EndTime = new TimeSpan(20, 00, 00);

            power = new sPower();
            power_day = new sPower();
            power_month = new sPower();
            power_year = new sPower();

            Charging_Stop_SOC = 80.0F;
            Discharging_Stop_SOC = 30.0F;
            Discharging_Limit_Voltage = 85.0F;
            Charging_Limit_Voltage = 30.0F;

            Limit_Active_Power = 50.0F;

        }

        private void btn_Access_To_Operating_System_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to finish the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                // exit program    
                Application.Exit();
            }
            else
            {
                // nothing happened
            }
        }

        private void btn_Export_Data_Click(object sender, EventArgs e)
        {
            try
            {
                //Pass the file path and file name to the StreamReader constructor

                string directory = System.Windows.Forms.Application.StartupPath;
                string fn = "\\Configs.dat";

                StreamWriter sw = new StreamWriter(directory + fn);

                sw.WriteLine("// PCS Setting");
                sw.WriteLine("ID = 1");
                sw.WriteLine("port = COM1");
                sw.WriteLine("baudrate = 9600");
                sw.WriteLine("parity = ODD");
                sw.WriteLine("stopbit = 1bit");
                sw.WriteLine("readtimeout = 1000");
                sw.WriteLine("writetimeout = 1000");
                sw.WriteLine("// BSC Setting");
                sw.WriteLine("type = Samsung");
                sw.WriteLine("ip_address = 172.31.110.33");
                sw.WriteLine("port = 504");
                sw.WriteLine("//PMD Setting;");
                sw.WriteLine("ID = 1");
                sw.WriteLine("ip_address = 172.31.110.33");
                sw.WriteLine("port = 1004");

                //close the file
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private void btn_Import_Data_Click(object sender, EventArgs e)
        {
            //Import 할 데이터들을 정하자?
            // 사실 생각해보면 Import는 의미가 없는데?
            // 어차피 읽어오는 것을 데이터 파일에서 읽어온다면 Import의 의미가 없다. Export의 의미는 있음
            // 
            string filename = "\\TAGLIST.csv";
            try
            {
                //FileStream fs = File.OpenRead(directory + filename);
                FileStream fs = File.OpenRead("c:\\TEST.txt");

                StreamReader r = new StreamReader(fs, System.Text.Encoding.Default);
                // 문자 스트림 변환
                r.BaseStream.Seek(0, SeekOrigin.Begin);

                // Skip First Line //
                string temp = r.ReadLine();
                while (r.Peek() > -1)
                {
                        temp = r.ReadLine();


                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Abort");
            }
            

        }

        private void btn_Password_Change_Click(object sender, EventArgs e)
        {
            VKeyboardViewer viewer = new VKeyboardViewer();
            // ShowDialog
            // Password 확인
            viewer.ShowDialog();
            if (Repository.Instance.user_level == 5)
            {
                VKeyboardViewer viewer2 = new VKeyboardViewer("새로운 비밀번호");
                // Password 새로 입력
                viewer2.ShowDialog();
                VKeyboardViewer viewer3 = new VKeyboardViewer("비밀번호 확인");
                // Password 추가 확인
                viewer3.ShowDialog();
            }
        }

        private void SOC_TextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MaskedTextBox masktedTextBox = (MaskedTextBox)sender;

            if (masktedTextBox.MaskFull)
            {
                MessageBox.Show("모든 사항이 입력되었습니다. 추가입력이 불가합니다");
            }
            else if (e.Position == masktedTextBox.Mask.Length)
            {
                MessageBox.Show("마스크 위치를 넘어섰습니다. 입력이 불가합니다");
            }
            else
            {
                MessageBox.Show("숫자만 입력해야 합니다. 입력이 불가합니다");
            }
        }

        private void SOC_TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MaskedTextBox masktedTextBox = (MaskedTextBox)sender;

                masktedTextBox.Text = masktedTextBox.Text.Replace("_", string.Empty);

                if (Convert.ToDouble(masktedTextBox.Text) > 100)
                {
                    MessageBox.Show("SOC는 100을 초과할 수 없습니다. 입력이 불가합니다");
                    masktedTextBox.Text = "100.0";
                }
                else if (Convert.ToDouble(masktedTextBox.Text) < 0)
                {
                    MessageBox.Show("SOC는 음수가 될 수 없습니다. 입력이 불가합니다");
                    masktedTextBox.Text = "000.0";
                }
                else
                {
                    if (masktedTextBox.Name == "tb_Charging_Stop_SOC")
                    {
                        Charging_Stop_SOC = Convert.ToSingle(masktedTextBox.Text);
                    }
                    else if (masktedTextBox.Name == "tb_Discharging_Stop_SOC")
                    {
                        Discharging_Stop_SOC = Convert.ToSingle(masktedTextBox.Text);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("올바르지 않은 데이터가 들어갔습니다, 다시 확인해주시길 바랍니다 이유 : " + exc.Message);

            }
        }

        private void Voltage_TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MaskedTextBox masktedTextBox = (MaskedTextBox)sender;

                masktedTextBox.Text = masktedTextBox.Text.Replace("_", string.Empty);

                if (Convert.ToDouble(masktedTextBox.Text) > 1000)
                {
                    MessageBox.Show("전압은 1000V을 초과할 수 없습니다. 입력이 불가합니다");
                    masktedTextBox.Text = "1000.0V";
                }
                else if (Convert.ToDouble(masktedTextBox.Text) < 0)
                {
                    MessageBox.Show("전압은 음수가 될 수 없습니다. 입력이 불가합니다");
                    masktedTextBox.Text = "000.0";
                }
                else
                {
                    if (masktedTextBox.Name == "tb_Charging_Limit_Voltage")
                    {
                        Charging_Limit_Voltage = Convert.ToSingle(masktedTextBox.Text);
                    }
                    else if (masktedTextBox.Name == "tb_Discharging_Limit_Voltage")
                    {
                        Discharging_Limit_Voltage = Convert.ToSingle(masktedTextBox.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void Setting_PageViewer_Load(object sender, EventArgs e)
        {
            tb_Charging_Stop_SOC.Text = String.Format("{0:000.0}", Charging_Stop_SOC);
            tb_Discharging_Stop_SOC.Text = String.Format("{0:000.0}", Discharging_Stop_SOC);
            tb_Charging_Limit_Voltage.Text = String.Format("{0:000.0}", Discharging_Limit_Voltage);
            tb_Discharging_Limit_Voltage.Text = String.Format("{0:000.0}", Charging_Limit_Voltage);


            tb_Charging_Period_Start.Text = Charging_StartTime.Hours.ToString("D2") + "시" + Charging_StartTime.Minutes.ToString("D2") + "분";
            tb_Charging_Period_End.Text = Charging_EndTime.Hours.ToString("D2") + "시" + Charging_EndTime.Minutes.ToString("D2") + "분";
            tb_Discharging_Period_Start.Text = Discharging_StartTime.Hours.ToString("D2") + "시" + Discharging_StartTime.Minutes.ToString("D2") + "분";
            tb_Discharging_Period_End.Text = Discharging_EndTime.Hours.ToString("D2") + "시" + Discharging_EndTime.Minutes.ToString("D2") + "분";

        }

        private void tb_Charging_Stop_SOC_Leave(object sender, EventArgs e)
        {
            SOC_TextBox_TextChanged(sender, e);

        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("해당 설정을 적용 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Set_Current_PCS_Operating_Mode();
                    TimeSpan current = DateTime.Now.TimeOfDay;
                    TimeSpan StartTime1 = Convert_From_MaskedTextBox_To_TimeSpan(tb_Charging_Period_Start);
                    TimeSpan EndTime1 = Convert_From_MaskedTextBox_To_TimeSpan(tb_Charging_Period_End);

                    TimeSpan StartTime2 = Convert_From_MaskedTextBox_To_TimeSpan(tb_Discharging_Period_Start);
                    TimeSpan EndTime2 = Convert_From_MaskedTextBox_To_TimeSpan(tb_Discharging_Period_End);

                    Charging_StartTime = Convert_From_MaskedTextBox_To_TimeSpan(tb_Charging_Period_Start);
                    Charging_EndTime = Convert_From_MaskedTextBox_To_TimeSpan(tb_Charging_Period_End);
                    Discharging_StartTime = Convert_From_MaskedTextBox_To_TimeSpan(tb_Discharging_Period_Start);
                    Discharging_EndTime = Convert_From_MaskedTextBox_To_TimeSpan(tb_Discharging_Period_End);

                    Set_Scheduler_Setting(StartTime1, EndTime1, StartTime2, EndTime2);

                    if ((StartTime1 < StartTime2) && (StartTime2 < EndTime1))
                    {
                        MessageBox.Show("방전 시간과 충전 시간이 겹칩니다. 다시 설정하여 주십시오");
                        return;
                    }
                    else if ((StartTime1 < EndTime2) && (EndTime2 < EndTime1))
                    {
                        MessageBox.Show("방전 시간과 충전 시간이 겹칩니다. 다시 설정하여 주십시오");
                        return;
                    }

                    Charging_Stop_SOC = Convert_From_MaskedTextBox_To_Single(tb_Charging_Stop_SOC);

                    Discharging_Stop_SOC = Convert_From_MaskedTextBox_To_Single(tb_Discharging_Stop_SOC);
                    Charging_Limit_Voltage = Convert_From_MaskedTextBox_To_Single(tb_Discharging_Limit_Voltage);
                    Discharging_Limit_Voltage = Convert_From_MaskedTextBox_To_Single(tb_Discharging_Limit_Voltage);

                    Charging_StartTime = Convert_From_MaskedTextBox_To_TimeSpan(tb_Charging_Period_Start);
                    Charging_EndTime = Convert_From_MaskedTextBox_To_TimeSpan(tb_Charging_Period_End);
                    Discharging_StartTime = Convert_From_MaskedTextBox_To_TimeSpan(tb_Discharging_Period_Start);
                    Discharging_EndTime = Convert_From_MaskedTextBox_To_TimeSpan(tb_Discharging_Period_End);

                    Set_Current_PCS_Operating_Mode(StartTime1, EndTime1, StartTime2, EndTime2);
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("올바르지 않은 데이터가 들어갔습니다, 다시 확인해주시길 바랍니다 이유 : " + exc.Message);

            }
        }

        public void Set_Current_PCS_Operating_Mode(TimeSpan StartTime1, TimeSpan EndTime1, TimeSpan StartTime2, TimeSpan EndTime2)
        {
            TimeSpan current = DateTime.Now.TimeOfDay;
            // Scheduling Mode
            // 현재시간이 방전모드인지, 충전모드인지를 먼저 확인한다.
            if (StartTime1 > EndTime1 && (StartTime1 <= current || current < EndTime1))
            {
                //충전시간이다
                flag_Charging_Time = true;
                flag_DisCharging_Time = false;
            }
            else if (StartTime1 < EndTime1 && (StartTime1 <= current && current < EndTime1))
            {
                // 충전시간이다
                flag_Charging_Time = true;
                flag_DisCharging_Time = false;
            }
            else if (StartTime2 > EndTime2 && (StartTime2 <= current || current < EndTime2))
            {
                flag_Charging_Time = false;
                flag_DisCharging_Time = true;
            }
            else if (StartTime2 < EndTime2 && (StartTime2 <= current && current < EndTime2))
            {
                flag_Charging_Time = false;
                flag_DisCharging_Time = true;
            }
            else
            {
                flag_Charging_Time = false;
                flag_DisCharging_Time = false;
            }
        }

        public void Set_Scheduler_Setting(TimeSpan StartTime1, TimeSpan EndTime1, TimeSpan StartTime2, TimeSpan EndTime2)
        {
            for (int i = 0; i < 24; i++)
            {
                TimeSpan tempTime = new TimeSpan(i, 0, 0);

                if (StartTime1 > EndTime1 && (StartTime1 <= tempTime || tempTime < EndTime1))
                {
                    //충전시간이다
                    Repository.Instance.scheduler[i] = 1;
                }
                else if (StartTime1 < EndTime1 && (StartTime1 <= tempTime && tempTime < EndTime1))
                {
                    // 충전시간이다
                    Repository.Instance.scheduler[i] = 1;
                }
                else if (StartTime2 > EndTime2 && (StartTime2 <= tempTime || tempTime < EndTime2))
                {
                    Repository.Instance.scheduler[i] = 2;
                }
                else if (StartTime2 < EndTime2 && (StartTime2 <= tempTime && tempTime < EndTime2))
                {
                    Repository.Instance.scheduler[i] = 2;
                }
                else
                {
                    Repository.Instance.scheduler[i] = 0;
                }

            }
        }

        private void Set_Current_PCS_Operating_Mode()
        {
            
        }

        private float Convert_From_MaskedTextBox_To_Single(MaskedTextBox maskedTextBox)
        {
            string temp;

            temp = maskedTextBox.Text.Replace("_", "0");
            temp = temp.Trim();
            return Convert.ToSingle(temp);
        }
        private TimeSpan Convert_From_MaskedTextBox_To_TimeSpan(MaskedTextBox maskedTextBox)
        {
            string temp;

            temp = maskedTextBox.Text.Trim();
            temp = temp.Replace("시", ":");
            temp = temp.Replace("분", "");
            TimeSpan time;

            if (!TimeSpan.TryParse(temp, out time))
            {
                MessageBox.Show("올바르지 않은 데이터가 들어갔습니다, 다시 확인해주시길 바랍니다");
            }
            return time;
        }

        private void btn_DateTime_Setup_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rundll32.exe", "shell32.dll,Control_RunDLL TimeDate.cpl");
        }



        private void btn_Comm_Setup_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rundll32.exe", "shell32.dll,Control_RunDLL ncpa.cpl");
        }

        private void btn_Power_Setup_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rundll32.exe", "shell32.dll,Control_RunDLL powercfg.cpl");
        }

        private void btn_Language_Setup_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rundll32.exe", "shell32.dll,Control_RunDLL intl.cpl");
        }

        private void tb_Power_Prices_Click(object sender, EventArgs e)
        {
            Calculate_Power_Prices a = new Calculate_Power_Prices();
            a.ShowDialog();
        }
        public void SetPowerPrices(float total_prices)
        {
            tb_Power_Prices.Text = total_prices.ToString();
        }
    }
}
