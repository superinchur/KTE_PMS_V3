using KTE_PMS;
using KTE_PMS.CLASS;
using KTE_PMS.MIMIC;
using KTE_PMS.Observer;
using KTE_PMS.Popup;
using System;
using System.Windows.Forms;


namespace KTE_PMS
{

    public partial class MainViewer : Viewer, IUpdate
    {
        private int index;

        public MainViewer()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();


        }

        delegate void CrossThreadSafetySetText(Control ctl, String text);
        private void CSafeSetText(Control ctl, String text)
        {

            /*
             * InvokeRequired 속성 (Control.InvokeRequired, MSDN)
             *   짧게 말해서, 이 컨트롤이 만들어진 스레드와 현재의 스레드가 달라서
             *   컨트롤에서 스레드를 만들어야 하는지를 나타내는 속성입니다.  
             * 
             * InvokeRequired 속성의 값이 참이면, 컨트롤에서 스레드를 만들어 텍스트를 변경하고,
             * 그렇지 않은 경우에는 그냥 변경해도 아무 오류가 없기 때문에 텍스트를 변경합니다.
             */
            if (ctl.InvokeRequired)
                ctl.Invoke(new CrossThreadSafetySetText(CSafeSetText), ctl, text);
            else
                ctl.Text = text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Display_Animation();
            Display_Textbox_Power();
            Display_Textbox_Device_Status();
            Display_Device_Connection_Status();
            Display_Device_Control_Authority();
            Display_Battery_SOC();

            // MainViewer에 있는 Scheduler를 위한 항목
            esS_Scheduler1.Color_Update();
            //Repository.Instance.p_control.ess_S
            
        }

        private void Display_Battery_SOC()
        {
            double soc = Repository.Instance.samsung_bcs.System_SOC;
            if (soc < 20)
            {
                pb_Battery.Image = ImageResize.ResizeImage(il_Battery_List.Images[0], il_Battery_List.ImageSize.Width, il_Battery_List.ImageSize.Height);
            }
            else if (soc >=20 && soc < 40)
            {
                pb_Battery.Image = ImageResize.ResizeImage(il_Battery_List.Images[1], il_Battery_List.ImageSize.Width, il_Battery_List.ImageSize.Height);
            }
            else if (soc >= 40 && soc < 60)
            {
                pb_Battery.Image = ImageResize.ResizeImage(il_Battery_List.Images[2], il_Battery_List.ImageSize.Width, il_Battery_List.ImageSize.Height);
            }
            else if (soc >= 60 && soc < 80)
            {
                pb_Battery.Image = ImageResize.ResizeImage(il_Battery_List.Images[3], il_Battery_List.ImageSize.Width, il_Battery_List.ImageSize.Height);
            }
            else if (soc >= 80)
            {
                pb_Battery.Image = ImageResize.ResizeImage(il_Battery_List.Images[4], il_Battery_List.ImageSize.Width, il_Battery_List.ImageSize.Height);
            }


        }
        private void Display_Device_Control_Authority()
        {
            // 버튼 색상 정하기.
            // Local Remote 상태를 보고 결정하기
            if (Repository.Instance.GnEPS_PCS.Authority_PMS)
            {
                lb_Battery_Control_Authority.Text = "LEMS";
                lb_PCS_Control_Authority.Text = "LEMS";
            }
            else
            {
                lb_Battery_Control_Authority.Text = "uPMS";
                lb_PCS_Control_Authority.Text = "uPMS";
            }
        }

        private void Display_Device_Connection_Status()
        {
            if (Repository.Instance.bmsviewer.Connected() > 0)
            {
                pb_Battery_Abnormal.Visible = false;
            }
            else
            {
                pb_Battery_Abnormal.Visible = true;
            }

            if (Repository.Instance.pmdviewer.Connected() > 0)
            {
                pb_PCS_Abnormal.Visible = false;
            }
            else
            {
                pb_PCS_Abnormal.Visible = true;
            }
        }

        private void Display_Textbox_Device_Status()
        {
            // 값을 써주자.
            if (Repository.Instance.samsung_bcs.Mode_Charging == 1)
            {
                lb_System_Status.Text = "CHARGING";
            }
            else if (Repository.Instance.samsung_bcs.Mode_Discharging == 1)
            {
                lb_System_Status.Text = "DISCHARGING";
            }
            else if (Repository.Instance.samsung_bcs.Mode_Offline == 1)
            {
                lb_System_Status.Text = "OFFLINE";
            }
            else if (Repository.Instance.samsung_bcs.Mode_Idle == 1)
            {
                lb_System_Status.Text = "IDLE";
            }
            else if (Repository.Instance.samsung_bcs.Mode_Ready == 1)
            {
                lb_System_Status.Text = "READY";
            }
            else
            {
                lb_System_Status.Text = "UNEXPECTED";
            }
            if (Repository.Instance.GnEPS_PCS.Mode_Standby == 1)
            {
                lb_PCS_System_Status.Text = "STANDBY";

            }
            else if (Repository.Instance.GnEPS_PCS.Mode_Charging == 1)
            {
                lb_PCS_System_Status.Text = "CHARGING";
            }
            else if (Repository.Instance.GnEPS_PCS.Mode_Discharging == 1)
            {
                lb_PCS_System_Status.Text = "DISCHARGING";
            }
            else
            {
                lb_PCS_System_Status.Text = "NO STANDBY";
            }
        }

        private void Display_Textbox_Power()
        {

        }
        private void Display_Animation()
        {
            // Status Check
            // Reverse Mode가 있어야한다.
            int reverse_index = new int();

            switch (index)
            {
                case 0:
                    reverse_index = 0;
                    break;
                case 1:
                    reverse_index = 4;
                    break;
                case 2:
                    reverse_index = 3;
                    break;
                case 3:
                    reverse_index = 2;
                    break;
                case 4:
                    reverse_index = 1;
                    break;
                default:
                    reverse_index = 0;
                    break;
            }
            ////////////////////////////////////////////////////////////
            //   Depending a status, Determine a direction of signal  //
            ////////////////////////////////////////////////////////////
            if (Repository.Instance.samsung_bcs.Mode_Charging == 1)
            {
                pb_Battery_to_PCS.Image = Battery_to_PCS.Images[reverse_index];
            }
            else if (Repository.Instance.samsung_bcs.Mode_Discharging == 1)
            {
                pb_Battery_to_PCS.Image = Battery_to_PCS.Images[index];
            }
            else
            {
                pb_Battery_to_PCS.Image = Battery_to_PCS.Images[0];
            }

            // TODO : 현재 LOAD와 GRID간의 차이가 없다. 이것을 구분하기가 상당히 어려움.
            // 그래서 이것은 그냥 같은 취급을 한다.
            if (Repository.Instance.GnEPS_PCS.Mode_Standby == 1)
            {
                pb_PCS_to_Grid.Image = PCS_to_Grid.Images[0];
                pb_PCS_to_Load.Image = PCS_to_Load.Images[0];

            }
            else if (Repository.Instance.GnEPS_PCS.Mode_Charging == 1)
            {
                pb_PCS_to_Grid.Image = PCS_to_Grid.Images[index];
                pb_PCS_to_Load.Image = PCS_to_Load.Images[0];
            }
            else if (Repository.Instance.GnEPS_PCS.Mode_Discharging == 1)
            {
                pb_PCS_to_Grid.Image = PCS_to_Grid.Images[reverse_index];
                pb_PCS_to_Load.Image = PCS_to_Load.Images[index];
            }
            else
            {
                pb_PCS_to_Grid.Image = PCS_to_Grid.Images[0];
                pb_PCS_to_Load.Image = PCS_to_Load.Images[0];
            }

            // Index가 4 이상이라면(5라면) Index를 0으로 초기화해준다.
            index++;
            if (index > 4) index = 0;
        }

        public void ObserverUpdate()
        {
            // Battery SIde middle of left
            CSafeSetText(lb1, Repository.Instance.samsung_bcs.System_Voltage.ToString());
            CSafeSetText(lb2, Repository.Instance.samsung_bcs.System_Current.ToString());
            CSafeSetText(lb3, Repository.Instance.samsung_bcs.System_Power.ToString());
            CSafeSetText(lb4, Repository.Instance.samsung_bcs.System_SOC.ToString());

            // Grid Side at bottom of right
            double Grid_Voltage = (Repository.Instance.GnEPS_PCS.GRID_R_Voltage + Repository.Instance.GnEPS_PCS.GRID_S_Voltage + Repository.Instance.GnEPS_PCS.GRID_T_Voltage) / 3;
            double Grid_Current = (Repository.Instance.GnEPS_PCS.GRID_R_Current + Repository.Instance.GnEPS_PCS.GRID_S_Current + Repository.Instance.GnEPS_PCS.GRID_T_Current) / 3;

            CSafeSetText(lb5, Grid_Voltage.ToString());
            CSafeSetText(lb6, Grid_Current.ToString());
            CSafeSetText(lb7, Repository.Instance.GnEPS_PCS.GRID_Power.ToString());
            CSafeSetText(lb8, Repository.Instance.GnEPS_PCS.GRID_Frequency.ToString());
            
            CSafeSetText(lb9, Repository.Instance.p_setting.power_day.BMS_CHARGE_POWER.ToString()); // 배터리 일별 충전
            CSafeSetText(lb12, Repository.Instance.p_setting.power_day.BMS_DISCHARGE_POWER.ToString()); // 배터리 일별 방전
            CSafeSetText(lb15, Repository.Instance.p_setting.power_day.PCS_CHARGE_POWER.ToString()); // PCS 일별 충전
            CSafeSetText(lb18, Repository.Instance.p_setting.power_day.PCS_DISCHARGE_POWER.ToString()); // PCS 일별 방전

            CSafeSetText(lb10, Repository.Instance.p_setting.power_month.BMS_CHARGE_POWER.ToString()); // 배터리 월별 충전
            CSafeSetText(lb13, Repository.Instance.p_setting.power_month.BMS_DISCHARGE_POWER.ToString()); // 배터리 월별 방전
            CSafeSetText(lb16, Repository.Instance.p_setting.power_month.PCS_CHARGE_POWER.ToString()); // PCS 일별 월전
            CSafeSetText(lb19, Repository.Instance.p_setting.power_month.PCS_DISCHARGE_POWER.ToString()); // PCS 월별 방전

            CSafeSetText(lb11, Repository.Instance.p_setting.power_year.BMS_CHARGE_POWER.ToString()); // 배터리 년별 충전
            CSafeSetText(lb14, Repository.Instance.p_setting.power_year.BMS_DISCHARGE_POWER.ToString()); // 배터리 년별 방전
            CSafeSetText(lb17, Repository.Instance.p_setting.power_year.PCS_CHARGE_POWER.ToString()); // PCS 년별 충전
            CSafeSetText(lb20, Repository.Instance.p_setting.power_year.PCS_DISCHARGE_POWER.ToString()); // PCS 년별 방전


        }

        private void MainViewer_Load(object sender, EventArgs e)
        {
            Repository.Instance.Set_Current_PCS_Operating_Mode(Repository.Instance.Charging_StartTime, Repository.Instance.Charging_EndTime, Repository.Instance.Discharging_StartTime, Repository.Instance.Discharging_EndTime);
            Repository.Instance.Set_Scheduler_Setting(Repository.Instance.Charging_StartTime, Repository.Instance.Charging_EndTime, Repository.Instance.Discharging_StartTime, Repository.Instance.Discharging_EndTime);
        }

        private void btn_PeakCutMode_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("피크저감 모드로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // -------------------------------------------------------------------------------------
                // 180710
                // 현재 피크저감 모드는 어떤 식으로 할지 명확하게 정의가 안되어서 주석처리를 해놨음
                // -------------------------------------------------------------------------------------
                /*
                Repository.Instance.p_setting.Charging_StartTime = new TimeSpan(08, 00, 00);
                Repository.Instance.p_setting.Charging_EndTime = new TimeSpan(12, 00, 00);
                Repository.Instance.p_setting.Discharging_StartTime = new TimeSpan(16, 00, 00);
                Repository.Instance.p_setting.Discharging_EndTime = new TimeSpan(20, 00, 00);
                */
                Repository.Instance.Set_Scheduler_Setting
                (
                Repository.Instance.Charging_StartTime,
                Repository.Instance.Charging_EndTime,
                Repository.Instance.Discharging_StartTime,
                Repository.Instance.Discharging_EndTime
                );
                // MainViewer에 있는 Scheduler를 위한 항목
                esS_Scheduler1.Color_Update();

            }
        }

        private void btn_CustomMode_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("사용자 정의 모드로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // -------------------------------------------------------------------------------------
                // 180710
                // TODO : 현재 사용자 정의 모드는 어떤 식으로 할지 명확하게 정의가 안되어서 주석처리를 해놨음
                // -------------------------------------------------------------------------------------
                /*
                Repository.Instance.p_setting.Charging_StartTime = new TimeSpan(08, 00, 00);
                Repository.Instance.p_setting.Charging_EndTime = new TimeSpan(12, 00, 00);
                Repository.Instance.p_setting.Discharging_StartTime = new TimeSpan(16, 00, 00);
                Repository.Instance.p_setting.Discharging_EndTime = new TimeSpan(20, 00, 00);
                */

                
                Repository.Instance.Set_Scheduler_Setting(
                Repository.Instance.Charging_StartTime,
                Repository.Instance.Charging_EndTime,
                Repository.Instance.Discharging_StartTime,
                Repository.Instance.Discharging_EndTime);


                // MainViewer에 있는 Scheduler를 위한 항목
                esS_Scheduler1.Color_Update();
            }
        }

        private void btn_ChargingMode_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("충전 모드로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Repository.Instance.Charging_StartTime = new TimeSpan(00, 00, 00);
                Repository.Instance.Charging_EndTime = new TimeSpan(24, 00, 00);
                Repository.Instance.Discharging_StartTime = new TimeSpan(00, 00, 00);
                Repository.Instance.Discharging_EndTime = new TimeSpan(00, 00, 00);

                Repository.Instance.Set_Scheduler_Setting(
                    Repository.Instance.Charging_StartTime,
                    Repository.Instance.Charging_EndTime,
                    Repository.Instance.Discharging_StartTime,
                    Repository.Instance.Discharging_EndTime);
                // MainViewer에 있는 Scheduler를 위한 항목
                esS_Scheduler1.Color_Update();
            }
        }

        private void btn_DisChargingMode_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("방전 모드로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Repository.Instance.Charging_StartTime = new TimeSpan(00, 00, 00);
                Repository.Instance.Charging_EndTime = new TimeSpan(00, 00, 00);
                Repository.Instance.Discharging_StartTime = new TimeSpan(00, 00, 00);
                Repository.Instance.Discharging_EndTime = new TimeSpan(24, 00, 00);

                Repository.Instance.Set_Scheduler_Setting(
                    Repository.Instance.Charging_StartTime,
                    Repository.Instance.Charging_EndTime,
                    Repository.Instance.Discharging_StartTime,
                    Repository.Instance.Discharging_EndTime);

                // MainViewer에 있는 Scheduler를 위한 항목
                esS_Scheduler1.Color_Update();
            }
        }

        private void btn_ReCreate_Click(object sender, EventArgs e)
        {
            //Repository.Instance.RESE

            Repository.Instance.Dispose();
        }
        public void Scheduler_Update()
        {
            //esS_Scheduler1.Color_Update();
        }

        private void btn_uPMS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("uPMS 제어모드로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Repository.Instance.GnEPS_PCS.Authority_PMS = false;
            }
        }

        private void btn_LEMS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("LEMS 제어모드로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Repository.Instance.GnEPS_PCS.Authority_PMS = true;
            }
        }

        private void btn_Battery_Control_Click(object sender, EventArgs e)
        {

        }
        private void btn_PCS_Control_Click(object sender, EventArgs e)
        {

        }

        #region 버튼이미지_설정_함수
        private void btn_Battery_Control_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.제어_on, button.Width, button.Height);
        }

        private void btn_Battery_Control_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }



        private void btn_PCS_Control_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.제어_on, button.Width, button.Height);
        }

        private void btn_PCS_Control_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void btn_uPMS_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.uPMS_on, button.Width, button.Height);
        }

        private void btn_uPMS_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void btn_PeakCutMode_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.피크저감_on, button.Width, button.Height);
        }

        private void btn_PeakCutMode_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void btn_ChargingMode_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.충전_on, button.Width, button.Height);
        }

        private void btn_ChargingMode_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void btn_DisChargingMode_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.방전_on, button.Width, button.Height);
        }

        private void btn_DisChargingMode_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void btn_CustomMode_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.사용자정의_on, button.Width, button.Height);
        }

        private void btn_CustomMode_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }


        private void btn_LEMS_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.LEMS_on, button.Width, button.Height);
        }

        private void btn_LEMS_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }
        #endregion

        private void esS_Scheduler1_Click(object sender, EventArgs e)
        {
            Popup_Scheduling a = new Popup_Scheduling();
            a.ShowDialog();
        }
    }
}
