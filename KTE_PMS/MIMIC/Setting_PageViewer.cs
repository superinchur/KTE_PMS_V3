using KTE_PMS.CLASS;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{
    public partial class Setting_PageViewer : Viewer
    {



        public sPower power { get; set; }
        public sPower power_hour { get; set; }
        public sPower power_day { get; set; }
        public sPower power_month { get; set; }
        public sPower power_year { get; set; }

        public float total_power { get; set; }

        public float Charging_Stop_SOC { get; set; }
        public float Discharging_Stop_SOC { get; set; }

        public float Limit_Active_Power { get; set; }


        public Setting_PageViewer()
        {
            InitializeComponent();

            Initialize_Parameter_Settings();
        }

        private void Initialize_Parameter_Settings()
        {


            power = new sPower();
            power_hour = new sPower();
            power_day = new sPower();
            power_month = new sPower();
            power_year = new sPower();
            
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
            Export_Setting_Parameter_Value();


        }

        public void Export_Setting_Parameter_Value()
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


                sw.WriteLine("//BASIC Setting");
                sw.WriteLine("Charging_StartTime = " + Repository.Instance.Charging_StartTime.ToString());
                sw.WriteLine("Charging_EndTime = " + Repository.Instance.Charging_EndTime.ToString());
                sw.WriteLine("DisCharging_StartTime = " + Repository.Instance.Discharging_StartTime.ToString());
                sw.WriteLine("DisCharging_EndTime = " + Repository.Instance.Discharging_EndTime.ToString());
                sw.WriteLine("Charging_Stop_SOC = " + Repository.Instance.p_control.Charging_Stop_SOC.ToString());
                sw.WriteLine("Discharging_Stop_SOC = " + Repository.Instance.p_control.Discharging_Stop_SOC.ToString());
                sw.WriteLine("remote_power = " + Repository.Instance.remote_power.ToString());
                sw.WriteLine("Current_Mode = " + Repository.Instance.current_pcs_mode.ToString());
                sw.WriteLine("Limit_Active_Power = " + Repository.Instance.p_setting.Limit_Active_Power.ToString());
                
                // 추후 이값은 PCS에서 받아오는 값으로 변경해야 한다. 현재는 Noise 문제때문에 하고있지 않음
                sw.WriteLine("Authority_PMS = " + Repository.Instance.GnEPS_PCS.Authority_PMS.ToString());

              
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
            Import_Data();

        }

        public void Import_Data()
        {

            //Import 할 데이터들을 정하자?
            // 사실 생각해보면 Import는 의미가 없는데?
            // 어차피 읽어오는 것을 데이터 파일에서 읽어온다면 Import의 의미가 없다. Export의 의미는 있음
            // 
            //string filename = "\\TAGLIST.csv";
            try
            {

                string directory = Application.StartupPath;
                string fn = "\\Configs.dat";

                FileStream fs = File.OpenRead(directory + fn);
                StreamReader r = new StreamReader(fs, System.Text.Encoding.Default);
                // 문자 스트림 변환
                r.BaseStream.Seek(0, SeekOrigin.Begin);

                // Skip First Line //
                string temp = r.ReadLine();
                while (r.Peek() > -1)
                {
                    temp = r.ReadLine();
                    string[] parsing;


                    parsing = temp.Split('=');
                    string[] values;
                    TimeSpan ts;

                    switch (parsing[0].Trim())
                    {
                        case "Charging_StartTime":
                            values = parsing[1].Split(':');
                            ts = new TimeSpan(Convert.ToInt16(values[0]), Convert.ToInt16(values[1]), Convert.ToInt16(values[2]));
                            Repository.Instance.Charging_StartTime = ts;
                            break;
                        case "Charging_EndTime":
                            values = parsing[1].Split(':');
                            ts = new TimeSpan(Convert.ToInt16(values[0]), Convert.ToInt16(values[1]), Convert.ToInt16(values[2]));
                            Repository.Instance.Charging_EndTime = ts;
                            break;
                        case "DisCharging_StartTime":
                            values = parsing[1].Split(':');
                            ts = new TimeSpan(Convert.ToInt16(values[0]), Convert.ToInt16(values[1]), Convert.ToInt16(values[2]));
                            Repository.Instance.Discharging_StartTime = ts;
                            break;
                        case "DisCharging_EndTime":
                            values = parsing[1].Split(':');
                            ts = new TimeSpan(Convert.ToInt16(values[0]), Convert.ToInt16(values[1]), Convert.ToInt16(values[2]));
                            Repository.Instance.Discharging_EndTime = ts;
                            break;
                        case "Charging_Stop_SOC":
                            Repository.Instance.p_control.Charging_Stop_SOC = Convert.ToSingle(parsing[1].Trim());
                            break;
                        case "Discharging_Stop_SOC":
                            Repository.Instance.p_control.Discharging_Stop_SOC = Convert.ToSingle(parsing[1].Trim());
                            break;
                        case "remote_power":
                            Repository.Instance.remote_power = Convert.ToUInt16(parsing[1].Trim());
                            break;
                        case "Current_Mode":
                            Repository.Instance.current_pcs_mode = Convert.ToUInt16(parsing[1].Trim());
                            break;

                        case "Authority_PMS":
                            Repository.Instance.GnEPS_PCS.Authority_PMS = Convert.ToBoolean(parsing[1].Trim());
                            break;

                        case "Limit_Active_Power":
                            Repository.Instance.p_setting.Limit_Active_Power = Convert.ToSingle(parsing[1].Trim());
                            break;
                    }

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
        
        private void Setting_PageViewer_Load(object sender, EventArgs e)
        {
            tb_Charging_Stop_SOC.Text = String.Format("{0:000.0}", Charging_Stop_SOC);
            tb_Discharging_Stop_SOC.Text = String.Format("{0:000.0}", Discharging_Stop_SOC);


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
                    //Repository.Instance.Set_Current_PCS_Operating_Mode();
                    TimeSpan current = DateTime.Now.TimeOfDay;



                    Charging_Stop_SOC = Convert_From_MaskedTextBox_To_Single(tb_Charging_Stop_SOC);
                    Discharging_Stop_SOC = Convert_From_MaskedTextBox_To_Single(tb_Discharging_Stop_SOC);

                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("올바르지 않은 데이터가 들어갔습니다, 다시 확인해주시길 바랍니다 이유 : " + exc.Message);

            }
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
            MessageBox.Show("추후 작업 예정입니다.");
            //System.Diagnostics.Process.Start("rundll32.exe", "shell32.dll,Control_RunDLL intl.cpl");
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

        private void btn_Apply_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.적용_on, button.Width, button.Height);
        }

        private void btn_Apply_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }
    }
}
