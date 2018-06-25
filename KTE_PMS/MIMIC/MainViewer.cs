using DevExpress.XtraGauges.Win;
using KTE_PMS.Observer;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraGauges.Win.Gauges.Digital;
using System.Collections;
using System.Text.RegularExpressions;

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
            timer1.Interval = 400;
            timer1.Start();
        }

        delegate void CrossThreadSafetySetText(Control ctl, String text);

        private void btn_GRID_OFF_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("GRID OFF 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Repository.Instance.bmsviewer.GRID_OFF();
            }
        }


        private void btn_GRID_ON_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("GRID ON 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Repository.Instance.bmsviewer.GRID_ON();
            }
        }

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

        private void Main_Load(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Status Check
            // Reverse Mode가 있어야한다.
            #pragma warning disable CS0219 // 변수가 할당되었지만 해당 값이 사용되지 않았습니다.
            int reverse_index;
            #pragma warning restore CS0219 // 변수가 할당되었지만 해당 값이 사용되지 않았습니다. // 밑에서 쓰고있는데 왜 없다고 함? 노이해

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
            if (Repository.Instance.samsung_bcs.Mode_Charging == 1 )
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
        }
    }
}
