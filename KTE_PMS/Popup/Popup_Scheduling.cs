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
    public partial class Popup_Scheduling : Form
    {
        public Popup_Scheduling()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("현재 창을 닫으시겠습니까??", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("해당 설정을 적용 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    TimeSpan current = DateTime.Now.TimeOfDay;
                    /*
                    TimeSpan StartTime1 = Convert_From_MaskedTextBox_To_TimeSpan(tb_Charging_Period_Start);
                    TimeSpan EndTime1 = Convert_From_MaskedTextBox_To_TimeSpan(tb_Charging_Period_End);

                    TimeSpan StartTime2 = Convert_From_MaskedTextBox_To_TimeSpan(tb_Discharging_Period_Start);
                    TimeSpan EndTime2 = Convert_From_MaskedTextBox_To_TimeSpan(tb_Discharging_Period_End);
                    Repository.Instance.Charging_StartTime = Convert_From_MaskedTextBox_To_TimeSpan(tb_Charging_Period_Start);
                    Repository.Instance.Charging_EndTime = Convert_From_MaskedTextBox_To_TimeSpan(tb_Charging_Period_End);
                    Repository.Instance.Discharging_StartTime = Convert_From_MaskedTextBox_To_TimeSpan(tb_Discharging_Period_Start);
                    Repository.Instance.Discharging_EndTime = Convert_From_MaskedTextBox_To_TimeSpan(tb_Discharging_Period_End);
                    */

                    // StartTime1은 충전, StartTime2는 방전 t11~4는 방전, t21~4도 방전.
                    TimeSpan StartTime1 = new TimeSpan(Convert.ToInt16(t21.Value), Convert.ToInt16(t22.Value), 0);
                    TimeSpan EndTime1 = new TimeSpan(Convert.ToInt16(t23.Value), Convert.ToInt16(t24.Value), 0);

                    TimeSpan StartTime2 = new TimeSpan(Convert.ToInt16(t11.Value), Convert.ToInt16(t12.Value), 0);
                    TimeSpan EndTime2 = new TimeSpan(Convert.ToInt16(t13.Value), Convert.ToInt16(t14.Value), 0);

                    Repository.Instance.Charging_StartTime = StartTime1;
                    Repository.Instance.Charging_EndTime = EndTime1;
                    Repository.Instance.Discharging_StartTime = StartTime2;
                    Repository.Instance.Discharging_EndTime = EndTime2;




                    Repository.Instance.Set_Scheduler_Setting(StartTime1, EndTime1, StartTime2, EndTime2);

                    if ((StartTime1 < StartTime2) && (StartTime2 < EndTime1))
                    {
                        MessageBox.Show("방전 시간과 충전 시간이 겹칩니다. 다시 설정하여 주십시오");
                        return;
                    }
                    else if ((StartTime1 < EndTime2) && (EndTime2 < EndTime1))
                    {
                        MessageBox.Show("방전 시간과 충전 시간이 겹칩니다. 다시 설정하여 주십시오");
                        return;
                    }

                    Repository.Instance.Set_Scheduler_Setting(
                    Repository.Instance.Charging_StartTime,
                    Repository.Instance.Charging_EndTime,
                    Repository.Instance.Discharging_StartTime,
                    Repository.Instance.Discharging_EndTime);


                    Repository.Instance.current_pcs_mode = 5;


                    this.Dispose();

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("올바르지 않은 데이터가 들어갔습니다, 다시 확인해주시길 바랍니다 이유 : " + exc.Message);

            }

}

        
        private float Convert_From_MaskedTextBox_To_Single(MaskedTextBox maskedTextBox)
        {
            string temp;

            temp = maskedTextBox.Text.Replace("_", "0");
            temp = temp.Trim();
            return Convert.ToSingle(temp);
        }

        private TimeSpan Convert_From_MaskedTextBox_To_TimeSpan(MaskedTextBox maskedTextBox)
        {
            string temp;

            temp = maskedTextBox.Text.Trim();
            temp = temp.Replace("시", ":");
            temp = temp.Replace("분", "");
            TimeSpan time;

            if (!TimeSpan.TryParse(temp, out time))
            {
                MessageBox.Show("올바르지 않은 데이터가 들어갔습니다, 다시 확인해주시길 바랍니다");
            }
            return time;
        }

        #region 버튼_IMG처리

        private void btn_OK_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.확인_on, button.Width, button.Height);
        }

        private void btn_OK_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }
        private void btn_Cancel_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.닫기_on, button.Width, button.Height);
        }

        private void btn_Cancel_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }
        #endregion

        private void Popup_Scheduling_Load(object sender, EventArgs e)
        {

            t21.Value = Repository.Instance.Charging_StartTime.Hours;
            t22.Value = Repository.Instance.Charging_StartTime.Minutes;
            t23.Value = Repository.Instance.Charging_EndTime.Hours;
            t24.Value = Repository.Instance.Charging_EndTime.Minutes;

            t11.Value = Repository.Instance.Discharging_StartTime.Hours;
            t12.Value = Repository.Instance.Discharging_StartTime.Minutes;
            t13.Value = Repository.Instance.Discharging_EndTime.Hours;
            t14.Value = Repository.Instance.Discharging_EndTime.Minutes;
            /*
            tb_Charging_Period_Start.Text = String.Format("{0:00}시{1:00}분", Repository.Instance.Charging_StartTime.Hours, Repository.Instance.Charging_StartTime.Minutes);
            tb_Charging_Period_End.Text = String.Format("{0:00}시{1:00}분", Repository.Instance.Charging_EndTime.Hours, Repository.Instance.Charging_EndTime.Minutes);

            tb_Discharging_Period_Start.Text = String.Format("{0:00}시{1:00}분", Repository.Instance.Discharging_StartTime.Hours, Repository.Instance.Discharging_StartTime.Minutes);
            tb_Discharging_Period_End.Text = String.Format("{0:00}시{1:00}분", Repository.Instance.Discharging_EndTime.Hours, Repository.Instance.Discharging_EndTime.Minutes);
            */
        }
    }
}
