using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;



namespace KTE_PMS.MIMIC
{
    public partial class ControlViewer : Viewer
    {

        private int index = 0;

        public int grid_run = 0;
        public int grid_stop = 0;
        public int gen_run = 0;
        public int gen_stop = 0;
        public int bat_run = 0;
        public int bat_stop = 0;
        public int pv_run = 0;
        public int pv_stop = 0;

        public ControlViewer()
        {
            InitializeComponent();
            //this.elementHost1.Child = new SingerOSK.SingerOnScreenKeyboard(this.Handle);

            threadingtimer = new System.Threading.Timer(ThreadingTimerCallback, null, 5000, 1000);
        }

              

    public new void ThreadingTimerCallback(object state)
    {
        try
        {
 
                /*
            this.Invoke(new MethodInvoker(delegate ()
            {
                // 1초 Timer에 의해서 수행되는 코드

                
                


            }));
            */
            }
        catch (ThreadAbortException ex)
        {
            MessageBox.Show("Abort", ex.Message);
            throw ex;
        }

    }
    private void button2_Click(object sender, EventArgs e)
        {
            display_RUN_button(button2, ref grid_run);
        }

        private void ControlTimer_Tick(object sender, EventArgs e)
        {
            // 1초마다 Flashing을 하자

                //pictureBox1.Image = Arrow.Images[index];
            index++;
            if (index == 5)
            {
                index = 0;
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void display_RUN_button(Button button, ref int a)
        {

            if (a == 0)
            {
                a = 1;
            }
            else
            {
                a = 0;
            }

            if (a == 1)
            {
                button.BackgroundImage  = global::KTE_PMS.Properties.Resources.RUN_003;
                
            }
            else
            {
                button.BackgroundImage = global::KTE_PMS.Properties.Resources.RUN_003_1; ;
            }

        }
        private void display_STOP_button(Button button, ref int a)
        {

            if (a == 0)
            {
                a = 1;
            }
            else
            {
                a = 0;
            }

            if (a == 1)
            {
                button.BackgroundImage = global::KTE_PMS.Properties.Resources.STOP_003;


            }
            else
            {
                button.BackgroundImage = global::KTE_PMS.Properties.Resources.STOP_003_1;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            display_STOP_button(button3, ref grid_stop);
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            display_RUN_button(button8, ref gen_run);
        }

        private void button7_Click(object sender, EventArgs e)
        {         

            display_STOP_button(button7, ref gen_stop);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            display_RUN_button(button10, ref bat_run);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display_STOP_button(button9, ref bat_stop);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            display_RUN_button(button12, ref pv_run);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            display_STOP_button(button11, ref pv_stop);
        }
    }
}
