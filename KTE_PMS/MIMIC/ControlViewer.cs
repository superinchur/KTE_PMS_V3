using KTE_PMS.CLASS;
using KTE_PMS.Popup;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{
    public partial class ControlViewer : Viewer
    {
        public int grid_run = 0;
        public int grid_stop = 0;
        public int gen_run = 0;
        public int gen_stop = 0;
        public int bat_run = 0;
        public int bat_stop = 0;
        public int pv_run = 0;
        public int pv_stop = 0;

        public float Charging_Stop_SOC { get; set; }
        public float Discharging_Stop_SOC { get; set; }

        public ControlViewer()
        {
            InitializeComponent();

            ControlTimer.Enabled = true;
            ControlTimer.Interval = 500;
            ControlTimer.Start();



        }

        private void ControlTimer_Tick(object sender, EventArgs e)
        {
            // 현재 상태를 보고 BTN의 불을 켤것인지 말것인지 결정하자.
            //lb_Power_Set.Text = Powerset
            lb_Charging_Stop_SOC.Text = Repository.Instance.p_control.Charging_Stop_SOC.ToString();
            lb_Discharging_Stop_SOC.Text = Repository.Instance.p_control.Discharging_Stop_SOC.ToString();

            lb_Power_Set.Text = String.Format("{0:0.0}", Repository.Instance.remote_power / 10);
            esS_Scheduler1.Color_Update();
            
            Display_Button_Color();
        }



        private void Display_Button_Color()
        {
            if (Repository.Instance.GnEPS_PCS.Authority_PMS)
            {
                btn_uPMS.Image = null;
                btn_LEMS.Image = ImageResize.ResizeImage(Properties.Resources.LEMS_on_G, btn_LEMS.Width, btn_LEMS.Height);
                cover_control.Visible = false;
                cover_scheduling.Visible = false;


                if (Repository.Instance.current_pcs_mode == 1)
                {
                    btn_PeakCutMode.Image = null;
                    btn_ChargingMode.Image = null;
                    btn_DisChargingMode.Image = null;
                    btn_CustomMode.Image = null;
                    cover_control.Visible = false;
                    cover_scheduling.Visible = false;

                }
                else if (Repository.Instance.current_pcs_mode == 2)
                {
                    btn_PeakCutMode.Image = null;
                    btn_ChargingMode.Image = ImageResize.ResizeImage(Properties.Resources.충전_on_G, btn_ChargingMode.Width, btn_ChargingMode.Height);
                    btn_DisChargingMode.Image = null;
                    btn_CustomMode.Image = null;
                    cover_scheduling.Visible = true;
                }
                else if (Repository.Instance.current_pcs_mode == 3)
                {
                    btn_PeakCutMode.Image = null;
                    btn_ChargingMode.Image = null;
                    btn_DisChargingMode.Image = ImageResize.ResizeImage(Properties.Resources.방전_on_G, btn_DisChargingMode.Width, btn_DisChargingMode.Height);
                    btn_CustomMode.Image = null;
                    cover_scheduling.Visible = true;
                }
                else if (Repository.Instance.current_pcs_mode == 4)
                {
                    btn_PeakCutMode.Image = ImageResize.ResizeImage(Properties.Resources.피크저감_on_G, btn_PeakCutMode.Width, btn_PeakCutMode.Height);
                    btn_ChargingMode.Image = null;
                    btn_DisChargingMode.Image = null;
                    btn_CustomMode.Image = null;
                    cover_control.Visible = false;
                    cover_scheduling.Visible = false;
                }
                else if (Repository.Instance.current_pcs_mode == 5)
                {
                    btn_PeakCutMode.Image = null;
                    btn_ChargingMode.Image = null;
                    btn_DisChargingMode.Image = null;
                    btn_CustomMode.Image = ImageResize.ResizeImage(Properties.Resources.사용자정의_on_G, btn_CustomMode.Width, btn_CustomMode.Height);
                    cover_control.Visible = false;
                    cover_scheduling.Visible = false;
                }
            }
            else
            {
                btn_uPMS.Image = ImageResize.ResizeImage(Properties.Resources.uPMS_on_G, btn_uPMS.Width, btn_uPMS.Height);
                btn_LEMS.Image = null;

                cover_control.Visible = true;
                cover_scheduling.Visible = true;

            }

        }

        private void tb_Power_Set_TextChanged(object sender, EventArgs e)
        {
        }

        private void tb_Power_Set_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (tb_Power_Set.MaskFull)
            {
                tb_Power_Set.Enabled = false;
                tb_Power_Set.Enabled = true;
                //MessageBox.Show("모든 사항이 입력되었습니다. 추가입력이 불가합니다");
            }
            else if (e.Position == tb_Power_Set.Mask.Length)
            {
                MessageBox.Show("마스크 위치를 넘어섰습니다. 입력이 불가합니다");
            }
            else
            {
                MessageBox.Show("숫자만 입력해야 합니다. 입력이 불가합니다");
            }
        }


        private void tb_Power_Set_Leave(object sender, EventArgs e)
        {

        }
        // ----------------------------------------------
        // 2018-07-10 
        // Parameter로 설정된 Active_Power값을 검사하고
        // 적당할 값일 경우 데이터를 변수안에 집어넣는 함수이다
        // Check_Active_Power_Input
        // ----------------------------------------------
       

        // -----------------------------------------------
        // KeyChar이 Enter가 들어오면 Enable의 Positive Edge를
        // 만들어줌으로 써, Focus를 잃게 만든다
        // -----------------------------------------------
        private void tb_Power_Set_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Enter:
                    //tb_Power_Set.Enabled = false;
                    //tb_Power_Set.Enabled = true;

                    //tb_Charging_Stop_SOC.Enabled = false;
                    //tb_Charging_Stop_SOC.Enabled = true;

                    //tb_Discharging_Stop_SOC.Enabled = false;
                    //tb_Discharging_Stop_SOC.Enabled = true;
                    break;
            }
        }

        private void tb_Power_Set_Validated(object sender, EventArgs e)
        {

        }


        private void ControlViewer_Load(object sender, EventArgs e)
        {
            Repository.Instance.Set_Current_PCS_Operating_Mode(Repository.Instance.Charging_StartTime, Repository.Instance.Charging_EndTime, Repository.Instance.Discharging_StartTime, Repository.Instance.Discharging_EndTime);
            Repository.Instance.Set_Scheduler_Setting(Repository.Instance.Charging_StartTime, Repository.Instance.Charging_EndTime, Repository.Instance.Discharging_StartTime, Repository.Instance.Discharging_EndTime);
        }

        private void btn_uPMS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("uPMS 제어모드로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Repository.Instance.GnEPS_PCS.Authority_PMS = false;
            }
        }

        private void btn_LEMS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("LEMS 제어모드로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Repository.Instance.GnEPS_PCS.Authority_PMS = true;
            }
        }

        private void btn_PeakCutMode_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("피크저감 모드로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // -------------------------------------------------------------------------------------
                // 180710
                // 현재 피크저감 모드는 어떤 식으로 할지 명확하게 정의가 안되어서 주석처리를 해놨음
                // -------------------------------------------------------------------------------------

                Repository.Instance.Set_Scheduler_Setting
                (
                new TimeSpan(08, 00, 00),
                new TimeSpan(12, 00, 00),
                new TimeSpan(16, 00, 00),
                new TimeSpan(20, 00, 00)
                );

                // MainViewer에 있는 Scheduler를 위한 항목
                esS_Scheduler1.Color_Update();

                // 피크저감 모드로 지정
                Repository.Instance.current_pcs_mode = 4;

                Display_Button_Color();
                cover_scheduling.Visible = false;
                // 2018-08-07 설정값 저장
                Repository.Instance.p_setting.Export_Setting_Parameter_Value();
            }
        }

        private void btn_CustomMode_Click(object sender, EventArgs e)
        {
            Popup_Scheduling a = new Popup_Scheduling();
            a.ShowDialog();

            // MainViewer에 있는 Scheduler를 위한 항목
            esS_Scheduler1.Color_Update();
            // 사용자 정의 모드로 지정
            Display_Button_Color();
            cover_scheduling.Visible = false;
            // 2018-08-07 설정값 저장
            Repository.Instance.p_setting.Export_Setting_Parameter_Value();
        }

        private void btn_ChargingMode_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("충전 모드로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Repository.Instance.current_pcs_mode = 2; // 충전모드로 변경 (current_pcs_mode == 2)

                // 2018-08-07 설정값 저장
                Repository.Instance.p_setting.Export_Setting_Parameter_Value();


            }
        }

        private void btn_DisChargingMode_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("방전 모드로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Repository.Instance.current_pcs_mode = 3; // 방전 모드로 변경 (current_pcs_mode == 3)

                // 2018-08-07 설정값 저장
                Repository.Instance.p_setting.Export_Setting_Parameter_Value();
            }
        }

        private void tb_Charging_Stop_SOC_Leave(object sender, EventArgs e)
        {

        }

        private void tb_Charging_Stop_SOC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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

        private void tb_Charging_Stop_SOC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Confirm_Power_Set_Click(object sender, EventArgs e)
        {
            Popup_Power_Active_Set a = new Popup_Power_Active_Set();
            a.ShowDialog();
        }

        private void btn_Confirm_Charging_Stop_SOC_Click(object sender, EventArgs e)
        {
            Popup_Charging_Stop_SOC a = new Popup_Charging_Stop_SOC();
            a.ShowDialog();
        }

        private void btn_Confirm_Discharging_Stop_SOC_Click(object sender, EventArgs e)
        {
            Popup_DisCharging_Stop_SOC a = new Popup_DisCharging_Stop_SOC();
            a.ShowDialog();

        }


        #region 버튼이미지_설정_함수


        private void btn_uPMS_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.uPMS_on, button.Width, button.Height);
        }

        private void btn_uPMS_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void btn_PeakCutMode_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.피크저감_on, button.Width, button.Height);
        }

        private void btn_PeakCutMode_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void btn_ChargingMode_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.충전_on, button.Width, button.Height);
        }

        private void btn_ChargingMode_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void btn_DisChargingMode_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.방전_on, button.Width, button.Height);
        }

        private void btn_DisChargingMode_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void btn_CustomMode_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.사용자정의_on, button.Width, button.Height);
        }

        private void btn_CustomMode_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }


        private void btn_LEMS_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.LEMS_on, button.Width, button.Height);
        }

        private void btn_LEMS_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void btn_Confirm_Power_Set_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.변경_on, button.Width, button.Height);
        }

        private void btn_Confirm_Power_Set_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        #endregion

        private void esS_Scheduler1_Click(object sender, EventArgs e)
        {
            Popup_Scheduling a = new Popup_Scheduling();
            a.ShowDialog();
        }

        private void btn_BMS_RESET_MouseUp(object sender, MouseEventArgs e)
        {

            if (MessageBox.Show("BMS를 리셋하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Repository.Instance.bmsviewer.GRID_OFF();
                Delay(2000);
                Repository.Instance.bmsviewer.GRID_ON();
            }

        }

        private void btn_BMS_RESET_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.적용_on, button.Width, button.Height);
        }

        private void btn_BMS_RESET_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            button.Image = null;
        }

        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }
    }
}