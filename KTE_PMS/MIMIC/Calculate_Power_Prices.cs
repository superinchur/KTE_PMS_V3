using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{
    public partial class Calculate_Power_Prices : Form
    {
        public Calculate_Power_Prices()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

                MaskedTextBox masktedTextBox = (MaskedTextBox)sender;

                if (masktedTextBox.MaskFull)
                {
                    MessageBox.Show("모든 사항이 입력되었습니다. 추가입력이 불가합니다");
                }
                else if (e.Position == masktedTextBox.Mask.Length)
                {
                    MessageBox.Show("마스크 위치를 넘어섰습니다. 입력이 불가합니다");
                }
                else
                {
                    MessageBox.Show("숫자만 입력해야 합니다. 입력이 불가합니다");
                }

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("해당 설정을 적용 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // 전력 * REC 가중치 / 1000
                // REC 입찰수익
                // 연간 총 수익 = REC 입찰수익 + 연간 SMP 수익 
                float power = Repository.Instance.p_setting.total_power;

                //--- Debugging을 위해서 임시로 넣어놓은 것
                power = 127750.0f;
                float REC = power * Convert.ToSingle(tb_REC_ratio.Text) / 1000;
                float REC_Prices = REC * Convert.ToSingle(tb_REC_Prices.Text);
                float SMP_Prices = power * Convert.ToSingle(tb_SMP_Prices.Text);

                float total_prices = SMP_Prices + REC_Prices;

                Repository.Instance.p_setting.SetPowerPrices(total_prices / power);

                this.Dispose();

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("취소하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();

            }
        }

        private void Calculate_Power_Prices_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
