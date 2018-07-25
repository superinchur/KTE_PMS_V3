using KTE_PMS.CLASS;
using KTE_PMS.MIMIC;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KTE_PMS
{

    public partial class LEMS : DevExpress.XtraEditors.XtraForm
    {
        const int MONITOR_OFF = 2;
        const int MONITOR_ON = -1;
        const int MONITOR_STANBY = 1;
        const int SC_MONITORPOWER = 0xF170;

        //private MIMIC.VKeyboard vkeyboard = null;
        // ---------------------------------------------------------
        // KMS_PMS_ Initialize
        // ---------------------------------------------------------

        // 모니터 On/Off 관련
        const int WM_SYSCOMMAND = 0x0112;

        Color flashColor;

        int prev_minute;
        int prev_hour;
        int prev_day;
        int prev_month;
        int prev_year;

        public LEMS()
        {
            InitializeComponent();

            CLOCK_TIMER.Enabled = true;
            CLOCK_TIMER.Interval = 1000;
            Repository.Instance.p_setting.Import_Data();
        }
        ~LEMS()
        {

        }
        private void btn_Monitor_OFF_MouseClick(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle.ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_OFF);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Repository.Instance.TagManager.ALARM_ACK(3);
        }

        private void Cell_Color_Painting()
        {
            string type;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                type = dataGridView1.Rows[i].Cells[4].Value.ToString();

                switch (type)
                {
                    case "ACK":
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        break;
                    case "UNACK":
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = flashColor;
                        break;
                    case "UNACK NORMAL":
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                        break;
                }
            }
        }

        private void Display_Current_Alarm_Count()
        {
            lb_alarm_count.Text = Repository.Instance.TagManager.htCurrentFault.Count() + "개";
        }

        private void Display_Current_PCS_Mode()
        {
            switch (Repository.Instance.current_pcs_mode)
            {
                case 1:
                    lb_Current_PCS_MODE.Visible = true;
                    lb_Current_PCS_MODE.Text = "IDLE";
                    break;
                case 2:
                    lb_Current_PCS_MODE.Visible = true;
                    lb_Current_PCS_MODE.Text = "메뉴얼모드";
                    break;
                case 3:
                    lb_Current_PCS_MODE.Visible = true;
                    lb_Current_PCS_MODE.Text = "스케줄모드";
                    break;
                default:
                    lb_Current_PCS_MODE.Visible = false;
                    break;
            }
        }

        private void Display_Current_Time()
        {
            label6.Text = DateTime.Now.Date.ToString();

            DateTime.Now.ToLocalTime().ToString();
                

        }

        private void Flashing_Row()
        {
            if (flashColor == Color.Gray)
            {
                flashColor = Color.Red;
            }
            else
            {
                flashColor = Color.Gray;
            }
        }

        // ---------------------------------------------------------
        // KMS_PMS_ Load
        // ---------------------------------------------------------
        private void KTE_PMS_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(Repository.Instance.p_main);

            prev_minute = DateTime.Now.Minute;
            prev_hour = DateTime.Now.Hour;
            prev_day = DateTime.Now.Day;
            prev_month = DateTime.Now.Month;
            prev_year = DateTime.Now.Year;

            //-----------------------------
            // 20180709
            // DataTable안에다가 Tag관련 정보를 CSV에서 받아서 넣는다.
            // TagManager는 Alarm 관련 항목
            //-----------------------------
            tag_data tag_data = new tag_data();
            Repository.Instance.Tag_Data_Table = tag_data.Tables[0];

            Repository.Instance.TagManager.Read_AlarmData(ref Repository.Instance.TagManager.tt);


        }
        private void NAVI_ALARM_Click(object sender, EventArgs e)
        {
            // 모든 Button의 Image를 Null로 변경 해서 초기화 //
            Navigation_Button_Initialize();

            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.alarm_on, button.Width, button.Height);

            panel1.Controls.Clear();
            panel1.Controls.Add(Repository.Instance.p_alarm);
        }
        private void NAVI_CONTROL_Click(object sender, EventArgs e)
        {
            // 모든 Button의 Image를 Null로 변경 해서 초기화 //
            Navigation_Button_Initialize();

            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.control_on, button.Width, button.Height);

            panel1.Controls.Clear();
            panel1.Controls.Add(Repository.Instance.p_control);

        }
        // ---------------------------------------------------------
        // Mimic 이동을 위한 버튼 함수들
        // ---------------------------------------------------------
        private void NAVI_MAIN_Click(object sender, EventArgs e)
        {

            // 모든 Button의 Image를 Null로 변경 해서 초기화 //
            Navigation_Button_Initialize();

            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.main_on, button.Width, button.Height);

            panel1.Controls.Clear();
            panel1.Controls.Add(Repository.Instance.p_main);

            Repository.Instance.p_main.timer1.Start();


        }
        private void NAVI_MEASURE_Click(object sender, EventArgs e)
        {
            // 모든 Button의 Image를 Null로 변경 해서 초기화 //
            Navigation_Button_Initialize();

            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.measure_on , button.Width, button.Height);

            panel1.Controls.Clear();
            panel1.Controls.Add(Repository.Instance.p_measure);
        }
        private void NAVI_MIMIC_Click(object sender, EventArgs e)
        {
            // 모든 Button의 Image를 Null로 변경 해서 초기화 //
            Navigation_Button_Initialize();

            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.mimic_on, button.Width, button.Height);

            panel1.Controls.Clear();
            panel1.Controls.Add(Repository.Instance.p_mimic);
        }
        private void NAVI_SETTING_Click(object sender, EventArgs e)
        {
            // 모든 Button의 Image를 Null로 변경 해서 초기화 //
            Navigation_Button_Initialize();

            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.setting_on, button.Width, button.Height);

            //VKeyboardViewer a = new VKeyboardViewer();
            //var password = a.ShowDialogAsync();
            VKeyboardViewer a = new VKeyboardViewer();
            a.ShowDialog();

            //a.Close();
            //await data;

            if (Repository.Instance.user_level == 5)
            {
                this.panel1.Controls.Clear();
                this.panel1.Controls.Add(Repository.Instance.p_setting);
            }
            else
            {
                MessageBox.Show("권한이 없어서 SETTING 화면에 들어갈 수 없습니다");
            }
        }
        private void NAVI_TREND_Click(object sender, EventArgs e)
        {
            // 모든 Button의 Image를 Null로 변경 해서 초기화 //
            Navigation_Button_Initialize();

            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.trend_on, button.Width, button.Height);

            panel1.Controls.Clear();
            panel1.Controls.Add(Repository.Instance.p_trend);
        }

        private void Navigation_Button_Initialize()
        {
            this.NAVI_MAIN.Image = null;
            this.NAVI_ALARM.Image = null;
            this.NAVI_TREND.Image = null;
            this.NAVI_MIMIC.Image = null;
            this.NAVI_MEASURE.Image = null;
            this.NAVI_CONTROL.Image = null;
            this.NAVI_SETTING.Image = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        [System.Runtime.InteropServices.DllImport("User32.dll")]

        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

        // ---------------------------------------------------------
        // Timer 처리를 위한 함수들
        // ---------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 1초 Timer에 의해서 수행되는 코드

            // 1초마다 Flashing을 하자
            // 1초 Timer에 의해서 수행되는 코드
            
            Display_Current_Time();
            Display_Current_PCS_Mode();
            Display_Current_Alarm_Count();

            Display_Current_Communication_Status();

            Flashing_Row();// TOP에 위치한 Alarm의 Flashing을 하기위해서 있는 항목 // 최적화 필요성 있음
            LoadCurrentFault();  // TOP에 위치한 Alarm을 표시하기위해서 있는 항목 // 최적화 필요성 있음
            Cell_Color_Painting(); // TOP에 위치한 Alarm List의 색상을 표시하기위해서 있는 항목 // 최적화 필요성 있음
            Calculate_Power(); // 전력량 계산하기
            

        }

        private void Display_Current_Communication_Status()
        {



            if (Repository.Instance.bmsviewer.Connected() > 0)
            {
                Status_LEMS_BMS.Image = Properties.Resources.통신연결;
            }
            else
            {
                Status_LEMS_BMS.Image = Properties.Resources.통신연결_끊김;

            }

            //TODO : 현재 uPMS - BMS간의 연결확인은 하지 않고 있으므로 일단은 LEMS와 BMS간의 통신 연결로 두자.
            // 추후 수정해야함
            if (Repository.Instance.bmsviewer.Connected() > 0)
            {
                Status_PMS_BMS.Image = Properties.Resources.통신연결;
            }
            else
            {
                Status_PMS_BMS.Image = Properties.Resources.통신연결_끊김;

            }

            if (Repository.Instance.pmdviewer.Connected() > 0)
            {
                // uPMS - PCS의 상태는 uPMS로 부터 받아오므로 PMS와의 연결이 끊어진다면 상황을 파악할 수 없다
                // 그러므로 통신연결이 정상적으로 이뤄질때만 PCS 값을 이용해서 체크한다.
                Status_LEMS_PMS.Image = Properties.Resources.통신연결;
                int PCS_alarm = Repository.Instance.GnEPS_PCS.PCS_GRID_Status +
                Repository.Instance.GnEPS_PCS.PCS_Fault_Status;

                if (PCS_alarm > 0)
                {
                    Status_PMS_PCS.Image = Properties.Resources.통신연결_끊김;

                }
                else
                {
                    Status_PMS_PCS.Image = Properties.Resources.통신연결;
                }
            }
            else
            {
                Status_LEMS_PMS.Image = Properties.Resources.통신연결_끊김;
                Status_PMS_PCS.Image = Properties.Resources.통신연결_끊김;
            }
        }

        private void Calculate_Power()
        {

            /////////////////////////////
            // 전력량 계산하기
            /////////////////////////////

            // 매 분마다 전력량을 DB에 저장하자

            DateTime today = DateTime.Now;
            // 하루가 지날때 마다 전력량을 DB에 또 저장하자. (SELECT문으로 그날 있었던 전력량을 모두 저장해서 하루에 저장)

            // 현재는 1분 주기지만 1초든 10초든 다 가능하드아~
            if (prev_minute != today.Minute)
            {
                // 저장된 데이터를 DB에 저장한다.
                
                Repository.Instance.dbConnector.Insert_Power();
                // 처리 완료 후, prev값을 새로 갱신
                prev_minute = today.Minute;
            }
            if (prev_hour != today.Hour)
            {
                // 저장된 데이터를 DB에 저장한다.
                Repository.Instance.dbConnector.Insert_Power_Hour();

                prev_hour = today.Hour;
            }
            if (prev_day != today.Day)
            {
                // 저장된 데이터를 DB에 저장한다.              
                Repository.Instance.dbConnector.Insert_Power_Day();
                prev_day = today.Day;
            }
            if (prev_month != today.Month)
            {
                Repository.Instance.dbConnector.Insert_Power_Month();
                prev_month = today.Month;
            }
            if (prev_year != today.Year)
            {
                Repository.Instance.dbConnector.Insert_Power_year();
                prev_year = today.Year;
            }
            
        }

        // ---------------------------------------------------------
        // Timer 처리를 위한 함수들
        // ---------------------------------------------------------

        public void BSC_Control()
        {
            byte[] data;

            // Byte 배열로 받고
            data = Repository.Instance.p_control.getTextBox1();
            //Trigger로 날려주기.
            Repository.Instance.Set_BSC_Control(data);
        }


        public void LoadCurrentFault()
        {
            Repository.Instance.TagManager.Alarm_Display(ref dataGridView1, 3);
            
        }

        private void lb_alarm_count_Click(object sender, EventArgs e)
        {
            Repository.Instance.dbConnector.Insert_Power_Hour();
        }

        private void btn_PCS_STOP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("긴급정지 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // PCS Mode 설정
                Repository.Instance.current_pcs_mode = 1;
                Repository.Instance.pmdviewer.Control_Idle();
            }
        }

        private void btn_Reconnect_Click(object sender, EventArgs e)
        {
            Repository.Instance.bms_dispose();

            //Repository.Instance.Dispose();
            //Repository.Instance.Reset();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Repository.Instance.pmd_dispose();
        }

        private void btn_Monitor_OFF_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.monitoroff_on, button.Width, button.Height);
        }

        private void btn_Monitor_OFF_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void btn_PCS_STOP_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.PCS_STOP_off, button.Width, button.Height);
        }

        private void btn_PCS_STOP_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }
    }
}
