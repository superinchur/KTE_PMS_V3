using KTE_PMS.Observer;
using System;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{
    public partial class MeasureViewer : Viewer, IUpdate
    {
        public MeasureViewer()
        {
            InitializeComponent();
        }

        private void Measure_Load(object sender, EventArgs e)
        {
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
            ObserverUpdate_BMS_System();

            
            CSafeSetText(lb1, Repository.Instance.samsung_bcs.System_Voltage.ToString() + " " + "V");
            CSafeSetText(lb3, Repository.Instance.samsung_bcs.System_SOC.ToString() + " " + "%");
            CSafeSetText(lb5, Repository.Instance.samsung_bcs.Rack_Voltage.ToString() + " " + "V");
        }

        private void ObserverUpdate_BMS_System()
        {
            // BMS : System용 이다
            // 값 써주기
            CSafeSetText(lb1, Repository.Instance.samsung_bcs.System_Voltage.ToString() + " " + "V");
            CSafeSetText(lb3, Repository.Instance.samsung_bcs.System_SOC.ToString() + " " + "%");
            CSafeSetText(lb5, Repository.Instance.samsung_bcs.Rack_Voltage.ToString() + " " + "V");

            CSafeSetText(lb7, Repository.Instance.samsung_bcs.String1_Rack_Voltage.ToString() + " " + "V");
            CSafeSetText(lb9, Repository.Instance.samsung_bcs.String2_Rack_Voltage.ToString() + " " + "V");
            CSafeSetText(lb11, Repository.Instance.samsung_bcs.String1_Cell_Summation_Voltage.ToString() + " " + "V");
            CSafeSetText(lb13, Repository.Instance.samsung_bcs.String2_Cell_Summation_Voltage.ToString() + " " + "V");
            CSafeSetText(lb15, Repository.Instance.samsung_bcs.Rack_Current.ToString() + " " + "A");
            CSafeSetText(lb17, Repository.Instance.samsung_bcs.String1_Rack_Current.ToString() + " " + "A");
            CSafeSetText(lb19, Repository.Instance.samsung_bcs.String2_Rack_Current.ToString() + " " + "A");
            CSafeSetText(lb21, Repository.Instance.samsung_bcs.Rack_Current_Average.ToString() + " " + "A");
            CSafeSetText(lb23, Repository.Instance.samsung_bcs.Rack_SOC.ToString() + " " + "%");
            CSafeSetText(lb22, Repository.Instance.samsung_bcs.Rack_SOH.ToString() + " " + "%");

            CSafeSetText(lb2, Repository.Instance.samsung_bcs.System_Current.ToString() + " " + "A");
            CSafeSetText(lb4, Repository.Instance.samsung_bcs.System_SOH.ToString() + " " + "%");
            CSafeSetText(lb6, Repository.Instance.samsung_bcs.System_Mode.ToString());
            CSafeSetText(lb8, Repository.Instance.samsung_bcs.System_Max_Voltage.ToString() + " " + "V");
            CSafeSetText(lb10, Repository.Instance.samsung_bcs.System_Min_Voltage.ToString() + " " + "V");
            CSafeSetText(lb12, Repository.Instance.samsung_bcs.System_Max_Temp.ToString() + " " + "°C");
            CSafeSetText(lb14, Repository.Instance.samsung_bcs.System_Min_Temp.ToString() + " " + "°C");


            CSafeSetText(lb24, Repository.Instance.samsung_bcs.Discharge_Current_Limit_of_Rack.ToString() + " " + "A");
            CSafeSetText(lb25, Repository.Instance.samsung_bcs.Charge_Current_Limit.ToString() + " " + "A");

            CSafeSetText(lb26, Repository.Instance.samsung_bcs.Watchdog_Response.ToString());
            CSafeSetText(lb27, Repository.Instance.samsung_bcs.System_Heartbit.ToString());
        }

        private void TBO24_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void TBO19_Click(object sender, EventArgs e)
        {

        }

        private void btn_Move_To_BMS_System_MouseClick(object sender, MouseEventArgs e)
        {
            Panel p = (Panel)Parent;
            p.Controls.Clear();
            p.Controls.Add(Repository.Instance.p_measure);
        }

        private void btn_Move_To_BMS_Rack_MouseClick(object sender, MouseEventArgs e)
        {
            Panel p = (Panel)Parent;
            p.Controls.Clear();
            p.Controls.Add(Repository.Instance.p_measure_BMS_Rack);
        }

        private void btn_Move_To_PCS_Data_MouseClick(object sender, MouseEventArgs e)
        {
            Panel p = (Panel)Parent;
            p.Controls.Clear();
            p.Controls.Add(Repository.Instance.p_measure_PCS);
        }

        private void btn_Move_To_PCS_Fault_MouseClick(object sender, MouseEventArgs e)
        {
            Panel p = (Panel)Parent;
            p.Controls.Clear();
            p.Controls.Add(Repository.Instance.p_measure_PCS_Fault );
        }
    }
}
