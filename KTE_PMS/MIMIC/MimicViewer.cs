using KTE_PMS.CLASS;
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
            timer1.Interval = 500;
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


        private void Display_Battery_SOC()
        {
            double soc = Repository.Instance.samsung_bms.System_SOC;

            lb_Battery_SOC.Text = String.Format("{0:0.0 %}", soc / 100);
            if (soc < 20)
            {
                pb_Battery.Image = ImageResize.ResizeImage(il_Battery_List.Images[0], il_Battery_List.ImageSize.Width, il_Battery_List.ImageSize.Height);
            }
            else if (soc >= 20 && soc < 40)
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



            CSafeSetText(lbGRID_Frequency, String.Format("{0:0.0}", Repository.Instance.GnEPS_PCS.GRID_Frequency) + " Hz");
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
            CSafeSetText(lbLOAD_POWER, String.Format("{0:0.0}", Repository.Instance.GnEPS_PCS.LOAD_Power) + " kW");
            //CSafeSetText(lbINVERTER_POWER, Repository.Instance.GnEPS_PCS.INVERTER_Power .ToString());

            CSafeSetText(lb_Battery_Power, String.Format("{0:0.0}", Repository.Instance.samsung_bms.System_Power) + " kW");

            CSafeSetText(lb_Battery_Voltage, String.Format("{0:0.0}", Repository.Instance.samsung_bms.System_Voltage) + " V");
            CSafeSetText(lb_Battery_Current, String.Format("{0:0.0}", Repository.Instance.samsung_bms.System_Current) + " A");
            CSafeSetText(lb_Battery_SOC, String.Format("{0:0.0}", Repository.Instance.samsung_bms.System_SOC) + " %");
            CSafeSetText(lb_Battery_SOH, String.Format("{0:0.0}", Repository.Instance.samsung_bms.System_SOH) + " %");


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
            if (Repository.Instance.samsung_bms.Mode_Charging == 1)
            {
                lb_System_Status.Text = "CHARGING";
                pb_Arrow_PCS_Battery.Visible = true;
                pb_Arrow_PCS_Battery.Image = ImageResize.ResizeImage(Properties.Resources.arrow, pb_Arrow_PCS_Battery.Width, pb_Arrow_PCS_Battery.Height);
            }
            else if (Repository.Instance.samsung_bms.Mode_Discharging == 1)
            {
                lb_System_Status.Text = "DISCHARGING";
                pb_Arrow_PCS_Battery.Visible = true;
                pb_Arrow_PCS_Battery.Image = ImageResize.ResizeImage(Properties.Resources.arrow_1, pb_Arrow_PCS_Battery.Width, pb_Arrow_PCS_Battery.Height);
            }
            else if (Repository.Instance.samsung_bms.Mode_Offline == 1)
            {
                lb_System_Status.Text = "OFFLINE";
                pb_Arrow_PCS_Battery.Visible = false;
            }
            else if (Repository.Instance.samsung_bms.Mode_Idle == 1)
            {
                lb_System_Status.Text = "IDLE";
                pb_Arrow_PCS_Battery.Visible = false;
            }
            else if (Repository.Instance.samsung_bms.Mode_Ready == 1)
            {
                lb_System_Status.Text = "READY";
                pb_Arrow_PCS_Battery.Visible = false;
            }
            else
            {
                lb_System_Status.Text = "-";
                pb_Arrow_PCS_Battery.Visible = false;
            }
            if (Repository.Instance.GnEPS_PCS.Mode_Standby == 1)
            {
                lb_PCS_System_Status.Text = "STANDBY";
                pb_Arrow_Grid_PCS.Visible = false;
                pb_Arrow_Load_PCS.Visible = false;

            }
            else if (Repository.Instance.GnEPS_PCS.Mode_Charging == 1 || Repository.Instance.samsung_bms.Mode_Charging == 1)
            {
                lb_PCS_System_Status.Text = "CHARGING";
                pb_Arrow_Grid_PCS.Visible = true;
                pb_Arrow_Load_PCS.Visible = false;
                pb_Arrow_Grid_PCS.Image = ImageResize.ResizeImage(Properties.Resources.arrow, pb_Arrow_Grid_PCS.Width, pb_Arrow_Grid_PCS.Height);
               
            }
            else if (Repository.Instance.GnEPS_PCS.Mode_Discharging == 1 || Repository.Instance.samsung_bms.Mode_Discharging == 1)
            {
                lb_PCS_System_Status.Text = "DISCHARGING";
                pb_Arrow_Grid_PCS.Visible = false;
                pb_Arrow_Load_PCS.Visible = true;
                pb_Arrow_Grid_PCS.Image = ImageResize.ResizeImage(Properties.Resources.arrow_1, pb_Arrow_Grid_PCS.Width, pb_Arrow_Grid_PCS.Height);
                pb_Arrow_Load_PCS.Image = ImageResize.ResizeImage(Properties.Resources.arrow_1, pb_Arrow_Load_PCS.Width, pb_Arrow_Load_PCS.Height);

            }
            else
            {
                lb_PCS_System_Status.Text = "-";
                pb_Arrow_Grid_PCS.Visible = false;
                pb_Arrow_Load_PCS.Visible = false;
            }
        }


        private void Display_Device_Connection_Status()
        {
            if (Repository.Instance.GnEPS_PCS.common_alarm || (Repository.Instance.pmdviewer.Connected() == 0))
            {
                // 에러 상황에는 빨간색으로 표시되어야 하므로, 회색이 나타나서는 안된다,
                pb_PCS_Abnormal.Visible = false;
            }
            else
            {
                // 정상 상황에는 회색으로 표시되어야 하므로, 회색이 나타나야한다
                pb_PCS_Abnormal.Visible = true;
            }

            if (Repository.Instance.samsung_bms.common_alarm || (Repository.Instance.bmsviewer.Connected() == 0))
            {
                // 에러 상황에는 빨간색으로 표시되어야 하므로, 회색이 나타나서는 안된다,
                pb_Battery_Abnormal.Visible = false;

            }
            else
            {
                // 정상 상황에는 회색으로 표시되어야 하므로, 회색이 나타나야한다
                pb_Battery_Abnormal.Visible = true;

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
            Display_Battery_SOC();

        }

        private void MimicViewer_Load(object sender, EventArgs e)
        {

        }

        private void btn_PCS_Control_Click(object sender, EventArgs e)
        {
            LEMS a = (LEMS)Parent.Parent;
            
            a.Click_Control();
        }

        private void btn_PCS_Control_MouseUp(object sender, MouseEventArgs e)
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
    }

}
