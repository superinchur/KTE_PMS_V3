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
        //private System.Threading.Timer threadingtimer; // 1초 타이머를 위한 함수(Main Timer)

        public MainViewer()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            CSafeSetText(dg_System_Power, "123.45");
            CSafeSetText(dg_System_Voltage, "123.45");
            CSafeSetText(dg_System_Current, "123.45");
            CSafeSetText(dg_System_SOC, "123.45");
        }

        private void CSafeSetText(DigitalGauge ctl, string text)
        {
            /*
             * InvokeRequired 속성 (Control.InvokeRequired, MSDN)
             *   짧게 말해서, 이 컨트롤이 만들어진 스레드와 현재의 스레드가 달라서
             *   컨트롤에서 스레드를 만들어야 하는지를 나타내는 속성입니다.  
             * 
             * InvokeRequired 속성의 값이 참이면, 컨트롤에서 스레드를 만들어 텍스트를 변경하고,
             * 그렇지 않은 경우에는 그냥 변경해도 아무 오류가 없기 때문에 텍스트를 변경합니다.
             */

            //if (ctl.InvokeRequired)
                //ctl.Invoke(new CrossThreadSafetySetText(CSafeSetText), ctl, text);
            //else
                ctl.Text = text;
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

            CSafeSetText(dg_System_Power, String.Format("{0:F2}", Repository.Instance.samsung_bcs.System_Power));
            CSafeSetText(dg_System_Voltage, Repository.Instance.samsung_bcs.System_Voltage.ToString());
            CSafeSetText(dg_System_Current , Repository.Instance.samsung_bcs.System_Current.ToString());
            CSafeSetText(dg_SOC, Repository.Instance.samsung_bcs.System_SOC.ToString());
            CSafeSetText(dg_heartbit, Repository.Instance.samsung_bcs.System_Heartbit.ToString());
            CSafeSetText(lb_Watchdog, Repository.Instance.samsung_bcs.Watchdog_Response.ToString());
            
            /*
            15 Charge Mode
            14 Discharge Mode
            11~13 Reserved
            10 Off - line
            09 Idle
            08 Ready
            07 Input Status No.4
            06 Input Status No.3
            05 Input Status No.2
            04 Input Status No.1
            01 Output Control No.2
            00 Output Control No.1
            */

            
            if (((Repository.Instance.samsung_bcs.System_Mode >> 15) & 0x01) == 1) CSafeSetText(current_Status,"Charge Mode");
            else if (((Repository.Instance.samsung_bcs.System_Mode >> 14 & 0x01)) == 1) CSafeSetText(current_Status,"Discharge Mode");
            else if ((Repository.Instance.samsung_bcs.System_Mode >> 10 & 0x01) == 1) CSafeSetText(current_Status,"Off-line");
            else if ((Repository.Instance.samsung_bcs.System_Mode >> 9 & 0x01) == 1) CSafeSetText(current_Status, "Idle");
            else if ((Repository.Instance.samsung_bcs.System_Mode >> 8 & 0x01) == 1) CSafeSetText(current_Status, "Ready");
            else if ((Repository.Instance.samsung_bcs.System_Mode >> 7 & 0x01) == 1) CSafeSetText(current_Status, "Input Status No.4");
            else if ((Repository.Instance.samsung_bcs.System_Mode >> 6 & 0x01) == 1) CSafeSetText(current_Status, "Input Status No.3");
            else if ((Repository.Instance.samsung_bcs.System_Mode >> 5 & 0x01) == 1) CSafeSetText(current_Status, "Input Status No.2");
            else if ((Repository.Instance.samsung_bcs.System_Mode >> 4 & 0x01) == 1) CSafeSetText(current_Status, "Input Status No.1");
            else if ((Repository.Instance.samsung_bcs.System_Mode >> 1 & 0x01) == 1) CSafeSetText(current_Status, "Output Control No.2");
            else if ((Repository.Instance.samsung_bcs.System_Mode >> 0 & 0x01) == 1) CSafeSetText(current_Status, "Output Control No.1");


            /*
            13 Control Invalid
            12 Control Not Valid
            11 System Stop
            10 Rack Voltage Imbalance
            09 Under Voltage Fault
            08 Under Voltage Warning
            07 Disconnect TCP(602) Fault
            06 Disconnect TCP(602) Warning
            05 Disconnect TCP(502) Fault
            04 Disconnect TCP(502) Warning
            03 Disconnect RTU Fault
            02 Disconnect RTU Warning
            01 Disconnect CANB Fault
            00 Disconnect CANB Warning
             */
            //mybit = new BitArray(S);
            ushort temp_alarm = Repository.Instance.samsung_bcs.System_Alarm_Status;
            
            if ((temp_alarm >> 13 & 0x01) == 1) CSafeSetText(lb_System_Alarm_Status ,"Control Invalid");
            else if ((temp_alarm >> 12 & 0x01) == 1) CSafeSetText(lb_System_Alarm_Status,"Control Not Valid");
            else if ((temp_alarm >> 11 & 0x01) == 1) CSafeSetText(lb_System_Alarm_Status, "System Stop");
            else if ((temp_alarm >> 10 & 0x01) == 1) CSafeSetText(lb_System_Alarm_Status, "Rack Voltage Imbalance");
            else if ((temp_alarm >> 9 & 0x01) == 1) CSafeSetText(lb_System_Alarm_Status, "Under Voltage Fault");
            else if ((temp_alarm >> 8 & 0x01) == 1) CSafeSetText(lb_System_Alarm_Status, "Under Voltage Warning");
            else if ((temp_alarm >> 7 & 0x01) == 1) CSafeSetText(lb_System_Alarm_Status, "Disconnect TCP(602) Fault");
            else if ((temp_alarm >> 6 & 0x01) == 1) CSafeSetText(lb_System_Alarm_Status, "Disconnect TCP(602) Warning");
            else if ((temp_alarm >> 5 & 0x01) == 1) CSafeSetText(lb_System_Alarm_Status, "Disconnect TCP(502) Fault");
            else if ((temp_alarm >> 4 & 0x01) == 1) CSafeSetText(lb_System_Alarm_Status, "Disconnect TCP(502) Warning");
            else if ((temp_alarm >> 3 & 0x01) == 1) CSafeSetText(lb_System_Alarm_Status, "Disconnect RTU Fault");
            else if ((temp_alarm >> 2 & 0x01) == 1) CSafeSetText(lb_System_Alarm_Status, "Disconnect RTU Warning");
            else if ((temp_alarm >> 1 & 0x01) == 1) CSafeSetText(lb_System_Alarm_Status, "Disconnect CANB Fault");
            else if ((temp_alarm >> 0 & 0x01) == 1) CSafeSetText(lb_System_Alarm_Status, "Disconnect CANB Warning");
            else CSafeSetText(lb_System_Alarm_Status, "Normal");

        }


            // 값 써주기
            /*
            CSafeSetText(lb1, Repository.Instance.samsung_bcs.System_Voltage.ToString());
            CSafeSetText(lb3, Repository.Instance.samsung_bcs.System_SOC.ToString());
            CSafeSetText(lb5, Repository.Instance.samsung_bcs.Rack_Voltage.ToString());

            CSafeSetText(lb7, Repository.Instance.samsung_bcs.String1_Rack_Voltage.ToString());
            CSafeSetText(lb9, Repository.Instance.samsung_bcs.String2_Rack_Voltage.ToString());
            CSafeSetText(lb11, Repository.Instance.samsung_bcs.String1_Cell_Summation_Voltage.ToString());
            CSafeSetText(lb13, Repository.Instance.samsung_bcs.String2_Cell_Summation_Voltage.ToString());
            CSafeSetText(lb15, Repository.Instance.samsung_bcs.Rack_Current.ToString());
            CSafeSetText(lb17, Repository.Instance.samsung_bcs.String1_Rack_Current.ToString());
            CSafeSetText(lb19, Repository.Instance.samsung_bcs.String2_Rack_Current.ToString());
            CSafeSetText(lb21, Repository.Instance.samsung_bcs.Rack_Current_Average.ToString());
            CSafeSetText(lb23, Repository.Instance.samsung_bcs.Rack_SOC.ToString());

            CSafeSetText(lb2, Repository.Instance.samsung_bcs.System_Current.ToString());
            CSafeSetText(lb4, Repository.Instance.samsung_bcs.System_SOH.ToString());
            CSafeSetText(lb6, Repository.Instance.samsung_bcs.System_Mode.ToString());
            CSafeSetText(lb8, Repository.Instance.samsung_bcs.System_Max_Voltage.ToString());
            CSafeSetText(lb10, Repository.Instance.samsung_bcs.System_Min_Voltage.ToString());
            CSafeSetText(lb12, Repository.Instance.samsung_bcs.System_Max_Temp.ToString());
            CSafeSetText(lb14, Repository.Instance.samsung_bcs.System_Min_Temp.ToString());
            */



            private void btn_GRID_ON_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("GRID ON 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Repository.Instance.bmsviewer.GRID_ON();
            }
        }

        private void btn_GRID_OFF_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("GRID OFF 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Repository.Instance.bmsviewer.GRID_OFF();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            short a;

            if (textBox1.Text == "")
            {

            }
                else
            {
                a =   Convert.ToInt16( Regex.Replace(textBox1.Text, @"\D", ""));
                Repository.Instance.bmsviewer.WATCHDOG(a);
            }

        }
    }
}
