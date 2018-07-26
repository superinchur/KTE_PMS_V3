using KTE_PMS.Observer;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{
    public partial class MimicViewer : Viewer, IUpdate
    {
        public MimicViewer()
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

        public void ObserverUpdate()
        {
            // 값 써주기
            CSafeSetText(lbGRID_R_VOLTAGE, Repository.Instance.GnEPS_PCS.GRID_R_Voltage.ToString() + " V");
            CSafeSetText(lbGRID_S_VOLTAGE, Repository.Instance.GnEPS_PCS.GRID_S_Voltage.ToString() + " V");
            CSafeSetText(lbGRID_T_VOLTAGE, Repository.Instance.GnEPS_PCS.GRID_T_Voltage.ToString() + " V");
            CSafeSetText(lbGRID_R_CURRENT, Repository.Instance.GnEPS_PCS.GRID_R_Current.ToString() + " A");
            CSafeSetText(lbGRID_S_CURRENT, Repository.Instance.GnEPS_PCS.GRID_S_Current.ToString() + " A");
            CSafeSetText(lbGRID_T_CURRENT, Repository.Instance.GnEPS_PCS.GRID_T_Current.ToString() + " A");
            CSafeSetText(lbGRID_POWER, Repository.Instance.GnEPS_PCS.GRID_Power.ToString() + " kW");
            CSafeSetText(lbGRID_Frequency, Repository.Instance.GnEPS_PCS.GRID_Frequency.ToString() + " Hz");
            if (Repository.Instance.GnEPS_PCS.isTemperatureWarning == 1)
            {
                //CSafeSetText(lbisTemperatureWarning, "WARNING");
            }
            else
            {
                //CSafeSetText(lbisTemperatureWarning, "NORMAL");
            }

            CSafeSetText(lbLOAD_R_CURRENT, Repository.Instance.GnEPS_PCS.LOAD_R_Current.ToString() + " A");
            CSafeSetText(lbLOAD_S_CURRENT, Repository.Instance.GnEPS_PCS.LOAD_S_Current.ToString() + " A");
            CSafeSetText(lbLOAD_T_CURRENT, Repository.Instance.GnEPS_PCS.LOAD_T_Current.ToString() + " A");
            CSafeSetText(lbLOAD_POWER, Repository.Instance.GnEPS_PCS.LOAD_Power.ToString() + " kW");
            //CSafeSetText(lbINVERTER_POWER, Repository.Instance.GnEPS_PCS.INVERTER_Power .ToString());

            CSafeSetText(lb_Battery_Power, Repository.Instance.samsung_bcs.System_Power.ToString() + " kW");
            CSafeSetText(lb_Battery_Voltage, Repository.Instance.samsung_bcs.System_Voltage.ToString() + " V");
            CSafeSetText(lb_Battery_Current, Repository.Instance.samsung_bcs.System_Current.ToString() + " A");
            CSafeSetText(lb_Battery_SOC, Repository.Instance.samsung_bcs.System_SOC.ToString() + " %");
            CSafeSetText(lb_Battery_SOH, Repository.Instance.samsung_bcs.System_SOH.ToString() + " %");


        }
        private void Display_Device_Control_Authority()
        {
            // 180726 버튼 색상 정하기.

            // Local Remote 상태를 보고 결정하기
            if (Repository.Instance.GnEPS_PCS.Authority_PMS)
            {
                //lb_Battery_Control_Authority.Text = "LEMS";
                lb_PCS_Control_Authority.Text = "LEMS";
                // 색상도 정하자
            }
            else
            {
                //lb_Battery_Control_Authority.Text = "uPMS";
                lb_PCS_Control_Authority.Text = "uPMS";
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


        private void Display_Device_Connection_Status()
        {
            if (Repository.Instance.GnEPS_PCS.common_alarm || (Repository.Instance.bmsviewer.Connected() == 0))
            {
                pb_Battery_Abnormal.Visible = false;
            }
            else
            {
                pb_Battery_Abnormal.Visible = true;
            }

            if (Repository.Instance.samsung_bcs.common_alarm || (Repository.Instance.pmdviewer.Connected() == 0))
            {
                pb_PCS_Abnormal.Visible = false;
            }
            else
            {
                pb_PCS_Abnormal.Visible = true;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Display_Device_Connection_Status();
            Display_Textbox_Device_Status();
            Display_Device_Control_Authority();
        }

        private void MimicViewer_Load(object sender, EventArgs e)
        {

        }
    }

}
