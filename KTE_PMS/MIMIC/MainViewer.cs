using KTE_PMS.Observer;
using System;
using System.Windows.Forms;


namespace KTE_PMS.MIMIC
{

    public partial class MainViewer : Viewer, IUpdate
    {
        private int index;

        //private System.Threading.Timer threadingtimer; // 1초 타이머를 위한 함수(Main Timer)

        public MainViewer()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Interval = 1000;
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
                lb_Current_Status.Text = "배터리 충전 중";
                lb_Current_Status.Visible = true;
            }
            else if (Repository.Instance.samsung_bcs.Mode_Discharging == 1)
            {
                pb_Battery_to_PCS.Image = Battery_to_PCS.Images[index];
                lb_Current_Status.Text = "배터리 방전 중";
                lb_Current_Status.Visible = true;
            }
            else
            {
                pb_Battery_to_PCS.Image = Battery_to_PCS.Images[0];
                lb_Current_Status.Text = "배터리 방전 중";
                lb_Current_Status.Visible = false;
            }

            if (Repository.Instance.GnEPS_PCS.Mode_Standby == 1)
            {
                pb_PCS_to_Grid.Image = Battery_to_PCS.Images[0];
            }
            else if (Repository.Instance.GnEPS_PCS.Mode_Charging == 1)
            {
                pb_PCS_to_Grid.Image = Battery_to_PCS.Images[index];
            }
            else if (Repository.Instance.GnEPS_PCS.Mode_Discharging == 1)
            {
                pb_PCS_to_Grid.Image = Battery_to_PCS.Images[reverse_index];
            }
            else
            {
                pb_PCS_to_Grid.Image = Battery_to_PCS.Images[0];
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
                Repository.Instance.p_setting.Set_Scheduler_Setting
                (
                Repository.Instance.p_setting.Charging_StartTime,
                Repository.Instance.p_setting.Charging_EndTime,
                Repository.Instance.p_setting.Discharging_StartTime,
                Repository.Instance.p_setting.Discharging_EndTime
                );
                Repository.Instance.p_control.Set_Scheduler_Color();
            }
        }

        private void btn_CustomMode_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("사용자 정의 모드로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // -------------------------------------------------------------------------------------
                // 180710
                // 현재 사용자 정의 모드는 어떤 식으로 할지 명확하게 정의가 안되어서 주석처리를 해놨음
                // -------------------------------------------------------------------------------------
                /*
                Repository.Instance.p_setting.Charging_StartTime = new TimeSpan(08, 00, 00);
                Repository.Instance.p_setting.Charging_EndTime = new TimeSpan(12, 00, 00);
                Repository.Instance.p_setting.Discharging_StartTime = new TimeSpan(16, 00, 00);
                Repository.Instance.p_setting.Discharging_EndTime = new TimeSpan(20, 00, 00);
                */
                Repository.Instance.p_setting.Set_Scheduler_Setting(
                Repository.Instance.p_setting.Charging_StartTime,
                Repository.Instance.p_setting.Charging_EndTime,
                Repository.Instance.p_setting.Discharging_StartTime,
                Repository.Instance.p_setting.Discharging_EndTime);
                Repository.Instance.p_control.Set_Scheduler_Color();
            }
        }

        private void btn_ChargingMode_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("사용자 정의 모드로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Repository.Instance.p_setting.Charging_StartTime = new TimeSpan(00, 00, 00);
                Repository.Instance.p_setting.Charging_EndTime = new TimeSpan(24, 00, 00);
                Repository.Instance.p_setting.Discharging_StartTime = new TimeSpan(00, 00, 00);
                Repository.Instance.p_setting.Discharging_EndTime = new TimeSpan(00, 00, 00);

                Repository.Instance.p_setting.Set_Scheduler_Setting(
                    Repository.Instance.p_setting.Charging_StartTime,
                    Repository.Instance.p_setting.Charging_EndTime,
                    Repository.Instance.p_setting.Discharging_StartTime,
                    Repository.Instance.p_setting.Discharging_EndTime);
                Repository.Instance.p_control.Set_Scheduler_Color();
            }
        }

        private void btn_DisChargingMode_Click(object sender, EventArgs e)
        {
            Repository.Instance.p_setting.Charging_StartTime = new TimeSpan(00, 00, 00);
            Repository.Instance.p_setting.Charging_EndTime = new TimeSpan(00, 00, 00);
            Repository.Instance.p_setting.Discharging_StartTime = new TimeSpan(00, 00, 00);
            Repository.Instance.p_setting.Discharging_EndTime = new TimeSpan(24, 00, 00);

            Repository.Instance.p_setting.Set_Scheduler_Setting(
                Repository.Instance.p_setting.Charging_StartTime,
                Repository.Instance.p_setting.Charging_EndTime,
                Repository.Instance.p_setting.Discharging_StartTime,
                Repository.Instance.p_setting.Discharging_EndTime);
            Repository.Instance.p_control.Set_Scheduler_Color();
        }
    }
}
