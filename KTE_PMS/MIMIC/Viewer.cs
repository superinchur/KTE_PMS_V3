using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{
    public partial class Viewer : UserControl
    {
        protected System.Threading.Timer threadingtimer = null; // 1초 타이머를 위한 함수(Main Timer)

        public Viewer()
        {
            InitializeComponent();


        }
        // Timer 처리를 위한 함수들
        // ---------------------------------------------------------
        public void ThreadingTimerCallback(object state)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    // 1초 Timer에 의해서 수행되는 코드

                    // 1초마다 Flashing을 하자

                }));
            }
            catch (ThreadAbortException ex)
            {
                MessageBox.Show("Abort", ex.Message);
                throw ex;
            }

        }
    }
}
