using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{
    public partial class Setting_PageViewer : Viewer
    {
        public Setting_PageViewer()
        {
            InitializeComponent();

        
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

                sw.WriteLine("// PCS Setting\r\n");
                sw.WriteLine("ID = 1\r\n");
                sw.WriteLine("port = COM1\r\n");
                sw.WriteLine("baudrate = 9600\r\n");
                sw.WriteLine("parity = ODD\r\n");
                sw.WriteLine("stopbit = 1bit\r\n");
                sw.WriteLine("readtimeout = 1000\r\n");
                sw.WriteLine("writetimeout = 1000\r\n");
                sw.WriteLine("// BSC Setting\r\n");
                sw.WriteLine("type = Samsung\r\n");
                sw.WriteLine("ip_address = 172.31.110.33\r\n");
                sw.WriteLine("port = 504)\r\n");
                sw.WriteLine("//PMD Setting\\\rn;");
                sw.WriteLine("ID = 1\r\n");
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
                        Repository.Instance.Charging_Stop_SOC = Convert.ToSingle(masktedTextBox.Text);
                    }
                    else if (masktedTextBox.Name == "tb_Discharging_Stop_SOC")
                    {
                        Repository.Instance.Discharging_Stop_SOC = Convert.ToSingle(masktedTextBox.Text);
                    }
                    else if (masktedTextBox.Name == "tb_Charging_Start_SOC")
                    {
                        Repository.Instance.Charging_Start_SOC = Convert.ToSingle(masktedTextBox.Text);
                    }
                    else if (masktedTextBox.Name == "tb_Discharging_Start_SOC")
                    {
                        Repository.Instance.Discharging_Start_SOC = Convert.ToSingle(masktedTextBox.Text);
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
            tb_Charging_Stop_SOC.Text = String.Format("{0:000.0}", Repository.Instance.Charging_Stop_SOC);
            tb_Discharging_Stop_SOC.Text = String.Format("{0:000.0}", Repository.Instance.Discharging_Stop_SOC);
            tb_Charging_Start_SOC.Text = String.Format("{0:000.0}", Repository.Instance.Discharging_Start_SOC);
            tb_Discharging_Start_SOC.Text = String.Format("{0:000.0}", Repository.Instance.Charging_Start_SOC);


            tb_Charging_Period_Start.Text = Repository.Instance.Charging_StartTime.Hours.ToString("D2") + "시" + Repository.Instance.Charging_StartTime.Minutes.ToString("D2") + "분";
            tb_Charging_Period_End.Text = Repository.Instance.Charging_EndTime.Hours.ToString("D2") + "시" + Repository.Instance.Charging_EndTime.Minutes.ToString("D2") + "분";
            tb_Discharging_Period_Start.Text = Repository.Instance.Discharging_StartTime.Hours.ToString("D2") + "시" + Repository.Instance.Discharging_StartTime.Minutes.ToString("D2") + "분";
            tb_Discharging_Period_End.Text = Repository.Instance.Discharging_EndTime.Hours.ToString("D2") + "시" + Repository.Instance.Discharging_EndTime.Minutes.ToString("D2") + "분";

        }

        private void tb_Charging_Stop_SOC_Leave(object sender, EventArgs e)
        {
            SOC_TextBox_TextChanged(sender, e);

        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("적용 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    TimeSpan current = DateTime.Now.TimeOfDay;
                    TimeSpan StartTime1 = Convert_From_MaskedTextBox_To_TimeSpan(tb_Charging_Period_Start);
                    TimeSpan EndTime1 = Convert_From_MaskedTextBox_To_TimeSpan(tb_Charging_Period_End);

                    TimeSpan StartTime2 = Convert_From_MaskedTextBox_To_TimeSpan(tb_Discharging_Period_Start);
                    TimeSpan EndTime2 = Convert_From_MaskedTextBox_To_TimeSpan(tb_Discharging_Period_End);

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

                    Repository.Instance.Charging_Stop_SOC = Convert_From_MaskedTextBox_To_Single(tb_Charging_Stop_SOC);

                    Repository.Instance.Discharging_Stop_SOC = Convert_From_MaskedTextBox_To_Single(tb_Discharging_Stop_SOC);
                    Repository.Instance.Charging_Start_SOC = Convert_From_MaskedTextBox_To_Single(tb_Discharging_Start_SOC);
                    Repository.Instance.Discharging_Start_SOC = Convert_From_MaskedTextBox_To_Single(tb_Discharging_Start_SOC);

                    Repository.Instance.Charging_StartTime = Convert_From_MaskedTextBox_To_TimeSpan(tb_Charging_Period_Start);
                    Repository.Instance.Charging_EndTime = Convert_From_MaskedTextBox_To_TimeSpan(tb_Charging_Period_End);
                    Repository.Instance.Discharging_StartTime = Convert_From_MaskedTextBox_To_TimeSpan(tb_Discharging_Period_Start);
                    Repository.Instance.Discharging_EndTime = Convert_From_MaskedTextBox_To_TimeSpan(tb_Discharging_Period_End);


                    // Scheduling Mode
                    // 현재시간이 방전모드인지, 충전모드인지를 먼저 확인한다.
                    if (StartTime1 > EndTime1 && (StartTime1 <= current || current < EndTime1))
                    {
                        //충전시간이다
                        Repository.Instance.flag_Charging_Time = true;
                        Repository.Instance.flag_DisCharging_Time = false;
                    }
                    else if (StartTime1 < EndTime1 && ( StartTime1 <= current && current < EndTime1))
                    {
                        // 충전시간이다
                        Repository.Instance.flag_Charging_Time = true;
                        Repository.Instance.flag_DisCharging_Time = false;
                    }
                    else if (StartTime2 > EndTime2 && ( StartTime2 <= current || current < EndTime2) )
                    {
                        Repository.Instance.flag_Charging_Time = false;
                        Repository.Instance.flag_DisCharging_Time = true;
                    }
                    else if (StartTime2 < EndTime2 && (StartTime2 <= current && current < EndTime2) )
                    {
                        Repository.Instance.flag_Charging_Time = false;
                        Repository.Instance.flag_DisCharging_Time = true;
                    }
                    else
                    {
                        Repository.Instance.flag_Charging_Time = false;
                        Repository.Instance.flag_DisCharging_Time = false;
                    }

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
    }
}
