using KTE_PMS.CLASS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTE_PMS.Popup
{
    public partial class Popup_Power_Active_Set : Form
    {
        float Range_Min = 0.0f;
        float Range_Max = 30.0f;

        public Popup_Power_Active_Set()
        {
            InitializeComponent();
            timer1_Tick(new object(), new EventArgs());
        }

        private void btn_Confirm_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void btn_Confirm_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.확인_on, button.Width, button.Height);
        }

        private void btn_Confirm_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                float temp = new cConvertFromMaskedTextBox().ToSingle(tb_Power_Set);

                if (temp >= Range_Min && temp <= Range_Max)
                {
                    if (MessageBox.Show("해당 설정을 적용하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Check_Active_Power_Input();
                        Repository.Instance.pmdviewer.Control_Power_Active_Set();
                        Repository.Instance.p_setting.Export_Setting_Parameter_Value();

                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show(String.Format("{0:0.0}과 {1:0.0}사이의 값을 넣어 주십시오.", Range_Min, Range_Max));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);

                MessageBox.Show("다시 입력해주십시오");
            }
        }
        public void Check_Active_Power_Input()
        {
            try
            {

                //고오오오급 기술을 넣어야 함

                double a = new cConvertFromMaskedTextBox().ToSingle(tb_Power_Set);


                if (a > Repository.Instance.p_setting.Limit_Active_Power)
                {
                    a = Repository.Instance.p_setting.Limit_Active_Power;
                    MessageBox.Show("Power를 " + Repository.Instance.p_setting.Limit_Active_Power + "kW 을 초과 설정할 수 없습니다");
                }
                Repository.Instance.remote_power = Convert.ToUInt16(a * 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_Power_Set.Text = String.Format("{0:0.0}", Repository.Instance.remote_power / 10);
        }
    }
}
