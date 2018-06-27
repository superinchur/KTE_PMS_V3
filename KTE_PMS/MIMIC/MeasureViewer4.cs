using KTE_PMS.Observer;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{
    public partial class MeasureViewer4 : Viewer, IUpdate
    {
        public MeasureViewer4()
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

            // BMS : System용 이다
            // 값 써주기
            CSafeSetText(lb1, Repository.Instance.GnEPS_PCS.GRID_R_Voltage.ToString() + " " + "V");
            CSafeSetText(lb2, Repository.Instance.GnEPS_PCS.GRID_S_Voltage.ToString() + " " + "V");
            CSafeSetText(lb3, Repository.Instance.GnEPS_PCS.GRID_T_Voltage.ToString() + " " + "V");

            CSafeSetText(lb4, Repository.Instance.GnEPS_PCS.GRID_R_Voltage.ToString() + " " + "A");
            CSafeSetText(lb5, Repository.Instance.GnEPS_PCS.GRID_S_Current.ToString() + " " + "A");
            CSafeSetText(lb6, Repository.Instance.GnEPS_PCS.GRID_T_Current.ToString() + " " + "A");

            CSafeSetText(lb7, Repository.Instance.GnEPS_PCS.GRID_Power.ToString() + " " + "kW");
            CSafeSetText(lb8, Repository.Instance.GnEPS_PCS.GRID_Frequency.ToString() + " " + "Hz");

            CSafeSetText(lb9, Repository.Instance.GnEPS_PCS.isTemperatureWarning.ToString());

            CSafeSetText(lb10, Repository.Instance.GnEPS_PCS.LOAD_R_Current.ToString() + " " + "A");
            CSafeSetText(lb11, Repository.Instance.GnEPS_PCS.LOAD_S_Current.ToString() + " " + "A");
            CSafeSetText(lb12, Repository.Instance.GnEPS_PCS.LOAD_T_Current.ToString() + " " + "A");

            CSafeSetText(lb13, Repository.Instance.GnEPS_PCS.LOAD_Power.ToString() + " " + "kW");
            CSafeSetText(lb14, Repository.Instance.GnEPS_PCS.INVERTER_Power.ToString() + " " + "kW");
            CSafeSetText(lb15, Repository.Instance.GnEPS_PCS.Mode_Standby.ToString());
            CSafeSetText(lb16, Repository.Instance.GnEPS_PCS.Control_MODE .ToString());

            CSafeSetText(lb17, Repository.Instance.GnEPS_PCS.Inverter_Current_Reference.ToString() + " " + "A");
            CSafeSetText(lb18, Repository.Instance.GnEPS_PCS.Inverter_Q_Current.ToString() + " " + "A");
            CSafeSetText(lb19, Repository.Instance.GnEPS_PCS.Inverter_D_Current.ToString() + " " + "A");
            CSafeSetText(lb20, Repository.Instance.GnEPS_PCS.Battery_Voltage.ToString() + " " + "V");
            CSafeSetText(lb21, Repository.Instance.GnEPS_PCS.Battery_Current.ToString() + " " + "A");


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
            p.Controls.Add(Repository.Instance.p_measure_PCS_Fault);
        }

    }
}
