using KTE_PMS.CLASS;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{
    public partial class TrendViewer : Viewer
    {

        private double Dest_Voltage;
        private double Dest_Current;
        private double Dest_Power;

        private int Current_Mode = 0;

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
                    /*
                    chart1.Series["Series1"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), vScrollBar1.Value);
                    chart2.Series["Series1"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), vScrollBar2.Value);
                    chart3.Series["Series1"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), vScrollBar3.Value);
                    */
                    // Dest_Value에 있는 값을 넣기.

                    switch (Current_Mode)
                    {
                        case 1:
                            
                            break;
                        case 2:
                            
                            break;
                        case 3:
                            Dest_Voltage = Repository.Instance.samsung_bcs.System_Voltage;
                            Dest_Current = Repository.Instance.samsung_bcs.System_Current;
                            Dest_Power = Repository.Instance.samsung_bcs.System_Power;
                            break;
                        default:
                            
                            break;
                    }

                    chart1.Series["Series1"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), Dest_Voltage);
                    chart2.Series["Series1"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), Dest_Current);
                    chart3.Series["Series1"].Points.AddXY(DateTime.Now.ToString("hh:mm:ss"), Dest_Power);

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

        #region Button_Image_Processing

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(global::KTE_PMS.Properties.Resources.TREND_button_grid_on_1, button.Width, button.Height);
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(global::KTE_PMS.Properties.Resources.TREND_button_generator_on_1, button.Width, button.Height);
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(global::KTE_PMS.Properties.Resources.TREND_button_battery_on_1, button.Width, button.Height);
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(global::KTE_PMS.Properties.Resources.TREND_button_solar_on_1, button.Width, button.Height);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.Image = null;
        }

        private void button2_KeyUp(object sender, KeyEventArgs e)
        {
            Button button = (Button)sender;
            button.Image = null;
        }

        private void button3_KeyUp(object sender, KeyEventArgs e)
        {
            Button button = (Button)sender;
            button.Image = null;
        }

        private void button4_KeyUp(object sender, KeyEventArgs e)
        {
            Button button = (Button)sender;
            button.Image = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            // Current Mode = 3 은 Battery Mode
            Current_Mode = 3;


        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
