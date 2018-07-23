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
            CSafeSetText(lbGRID_R_VOLTAGE, Repository.Instance.GnEPS_PCS.GRID_R_Voltage.ToString());
            CSafeSetText(lbGRID_S_VOLTAGE, Repository.Instance.GnEPS_PCS.GRID_S_Voltage.ToString());
            CSafeSetText(lbGRID_T_VOLTAGE, Repository.Instance.GnEPS_PCS.GRID_T_Voltage.ToString());
            CSafeSetText(lbGRID_R_CURRENT, Repository.Instance.GnEPS_PCS.GRID_R_Current.ToString());
            CSafeSetText(lbGRID_S_CURRENT, Repository.Instance.GnEPS_PCS.GRID_S_Current.ToString());
            CSafeSetText(lbGRID_T_CURRENT, Repository.Instance.GnEPS_PCS.GRID_T_Current.ToString());
            CSafeSetText(lbGRID_POWER, Repository.Instance.GnEPS_PCS.GRID_Power.ToString());
            CSafeSetText(lbGRID_Frequency, Repository.Instance.GnEPS_PCS.GRID_Frequency.ToString());
            if (Repository.Instance.GnEPS_PCS.isTemperatureWarning == 1)
            {
                CSafeSetText(lbisTemperatureWarning, "WARNING");
            }
            else
            {
                CSafeSetText(lbisTemperatureWarning, "NORMAL");
            }

            CSafeSetText(lbLOAD_R_CURRENT, Repository.Instance.GnEPS_PCS.LOAD_R_Current.ToString());
            CSafeSetText(lbLOAD_S_CURRENT, Repository.Instance.GnEPS_PCS.LOAD_S_Current.ToString());
            CSafeSetText(lbLOAD_T_CURRENT, Repository.Instance.GnEPS_PCS.LOAD_T_Current.ToString());
            CSafeSetText(lbLOAD_POWER, Repository.Instance.GnEPS_PCS.LOAD_Power.ToString());
            CSafeSetText(lbINVERTER_POWER, Repository.Instance.GnEPS_PCS.INVERTER_Power .ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
