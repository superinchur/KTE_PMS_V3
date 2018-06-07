using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{
    public partial class TrendViewer : Viewer
    {


        public TrendViewer()
        {
            InitializeComponent();

        }

        private void Trend_Load(object sender, EventArgs e)
        {
            threadingtimer = new System.Threading.Timer(ThreadingTimerCallback, null, 0, 1000);

            chart1.ChartAreas[0].AxisX.Title = "Time(Hours)";
        }
        // ---------------------------------------------------------
        // Timer 처리를 위한 함수들
        // ---------------------------------------------------------
        public new void ThreadingTimerCallback(object state)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    // 1초 Timer에 의해서 수행되는 코드


                    //chart1.Series["Series1"].Points.Add(vScrollBar1.Value);
                    chart1.Series["Series1"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), vScrollBar1.Value);
                    chart2.Series["Series1"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), vScrollBar2.Value);
                    chart3.Series["Series1"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), vScrollBar3.Value);

                }));
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine("Abort!");
                throw ex;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            this.button1.Image = global::KTE_PMS.Properties.Resources.TREND_button_grid_on_1;
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            this.button1.Image = global::KTE_PMS.Properties.Resources.TREND_button_generator_on_1;
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            this.button1.Image = global::KTE_PMS.Properties.Resources.TREND_button_battery_on_1;
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            this.button1.Image = global::KTE_PMS.Properties.Resources.TREND_button_solar_on_1;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            this.button1.Image = null;
        }

        private void button2_KeyUp(object sender, KeyEventArgs e)
        {
            this.button2.Image = null;
        }

        private void button3_KeyUp(object sender, KeyEventArgs e)
        {
            this.button3.Image = null;
        }

        private void button4_KeyUp(object sender, KeyEventArgs e)
        {
            this.button4.Image = null;
        }
    }
}
