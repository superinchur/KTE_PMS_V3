using KTE_PMS.CLASS;
using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace KTE_PMS
{

    public partial class KTE_PMS : DevExpress.XtraEditors.XtraForm
    {
        public System.Threading.Timer threadingtimer; // 1초 타이머를 위한 함수(Main Timer)
        public Repository repository;

        //private MIMIC.VKeyboard vkeyboard = null;
        // ---------------------------------------------------------
        // KMS_PMS_ Initialize
        // ---------------------------------------------------------
        public KTE_PMS()
        {
            InitializeComponent();
            repository = Repository.Instance;

            CLOCK_TIMER.Enabled = true;
            CLOCK_TIMER.Interval = 1000;
        }

        // ---------------------------------------------------------
        // KMS_PMS_ Load
        // ---------------------------------------------------------
        private void KTE_PMS_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(Repository.Instance.p_main);
        }

        // ---------------------------------------------------------
        // Timer 처리를 위한 함수들
        // ---------------------------------------------------------

        public void BSC_Control()
        {
            byte[] data;

            // Byte 배열로 받고
            data = Repository.Instance.p_control.getTextBox1();
            //Trigger로 날려주기.
            repository.Set_BSC_Control(data);
        }
        // ---------------------------------------------------------
        // Mimic 이동을 위한 버튼 함수들
        // ---------------------------------------------------------
        private void NAVI_MAIN_Click(object sender, EventArgs e)
        {

            // 모든 Button의 Image를 Null로 변경 해서 초기화 //
            Navigation_Button_Initialize();

            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.main_on, button.Width, button.Height);

            panel1.Controls.Clear();
            panel1.Controls.Add(Repository.Instance.p_main);

        }
        private void NAVI_ALARM_Click(object sender, EventArgs e)
        {
            // 모든 Button의 Image를 Null로 변경 해서 초기화 //
            Navigation_Button_Initialize();

            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.alarm_on, button.Width, button.Height);

            panel1.Controls.Clear();
            panel1.Controls.Add(repository.p_alarm);
        }
        private void NAVI_TREND_Click(object sender, EventArgs e)
        {
            // 모든 Button의 Image를 Null로 변경 해서 초기화 //
            Navigation_Button_Initialize();

            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.trend_on, button.Width, button.Height);

            panel1.Controls.Clear();
            panel1.Controls.Add(Repository.Instance.p_trend);
        }
        private void NAVI_MIMIC_Click(object sender, EventArgs e)
        {
            // 모든 Button의 Image를 Null로 변경 해서 초기화 //
            Navigation_Button_Initialize();

            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.mimic_on, button.Width, button.Height);
            
            panel1.Controls.Clear();
            panel1.Controls.Add(Repository.Instance.p_mimic);
        }
        private void NAVI_MEASURE_Click(object sender, EventArgs e)
        {
            // 모든 Button의 Image를 Null로 변경 해서 초기화 //
            Navigation_Button_Initialize();

            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.measure_on_1, button.Width, button.Height);

            panel1.Controls.Clear();
            panel1.Controls.Add(Repository.Instance.p_measure);
        }
        private void NAVI_CONTROL_Click(object sender, EventArgs e)
        {
            // 모든 Button의 Image를 Null로 변경 해서 초기화 //
            Navigation_Button_Initialize();

            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.control_on, button.Width, button.Height);

            panel1.Controls.Clear();
            panel1.Controls.Add(Repository.Instance.p_control);

        }
        private void NAVI_SETTING_Click(object sender, EventArgs e)
        {
            // 모든 Button의 Image를 Null로 변경 해서 초기화 //
            Navigation_Button_Initialize();

            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.setting_on, button.Width, button.Height);

            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(Repository.Instance.p_setting);
        }

        private void Navigation_Button_Initialize()
        {
            this.NAVI_MAIN.Image = null;
            this.NAVI_ALARM.Image = null;
            this.NAVI_TREND.Image = null;
            this.NAVI_MIMIC.Image = null;
            this.NAVI_MEASURE.Image = null;
            this.NAVI_CONTROL.Image = null;
            this.NAVI_SETTING.Image = null;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //bms.Connect_to_BSC();
        }

        internal class MyImageButton
        {
        }


        private void CONTROL_PCSSTOP_MouseDown(object sender, MouseEventArgs e)
        {         
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.PCS_STOP_off, button.Width, button.Height);
        }

        private void CONTROL_PCSSTOP_MouseUp(object sender, MouseEventArgs e)
        {
            this.CONTROL_PCSSTOP.Image = null;
        }

        private void MONITOR_OFF_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.PCS_STOP_off, button.Width, button.Height);
        }

        private void MONITOR_OFF_MouseUp(object sender, MouseEventArgs e)
        {
            this.MONITOR_OFF.Image = null;
        }

        // ---------------------------------------------------------
        // Timer 처리를 위한 함수들
        // ---------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 1초 Timer에 의해서 수행되는 코드

            // 1초마다 Flashing을 하자
            // 1초 Timer에 의해서 수행되는 코드

            label6.Text = DateTime.Now.ToString();
        }

        internal class MIMIC
        {
            internal class myTextBox
            {
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Repository.Instance.pmdviewer.Control_Idle();
        }

        private void btn_GRID_ON_Click(object sender, EventArgs e)
        {
            Repository.Instance.pmdviewer.Control_Charge();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Repository.Instance.pmdviewer.Control_Discharge();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            int power = Convert.ToUInt16(Regex.Replace(textBox1.Text, @"\D", "")) * 10 ;

            if (power > 500)
            {
                power = 500;
            }
            else if ( power < 0 )
            {
                power = 0;
            }
            Repository.Instance.remote_power = Convert.ToUInt16(power);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
