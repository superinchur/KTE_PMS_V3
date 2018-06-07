using KTE_PMS.Observer;
using System;
using System.Linq;
using System.Threading;
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

            // 값 써주기
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
    }
}
