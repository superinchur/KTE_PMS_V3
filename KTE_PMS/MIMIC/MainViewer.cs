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
        }


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


    }
}
