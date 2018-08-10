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
    public partial class Popup_Charging_Stop_SOC : Form
    {
        float Range_Min = 00.0f;
        float Range_Max = 100.0f;

        public Popup_Charging_Stop_SOC()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
            timer1_Tick(new object(), new EventArgs());

        }

        private void btn_Confirm_MouseClick(object sender, MouseEventArgs e)
        {
            
            try
            {
                if (MessageBox.Show("해당 설정을 적용하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    float temp = new cConvertFromMaskedTextBox().ToSingle(tb_Charging_Stop_SOC);

                    if (temp >= Range_Min && temp <= Range_Max)
                    {
                        Repository.Instance.p_control.Charging_Stop_SOC = temp;
                        Repository.Instance.p_setting.Export_Setting_Parameter_Value();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show(String.Format("{0:0.0}과 {1:0.0}사이의 값을 넣어 주십시오.", Range_Min, Range_Max));
                    }

                    
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);

                MessageBox.Show("다시 입력해주십시오");
            }

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_Charging_Stop_SOC.Text = Repository.Instance.p_control.Charging_Stop_SOC.ToString();
        }

        
    }
}
