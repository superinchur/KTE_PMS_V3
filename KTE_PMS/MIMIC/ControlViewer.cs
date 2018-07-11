using KTE_PMS.CLASS;
using System;
using System.Drawing;
using System.Windows.Forms;

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

            ControlTimer.Enabled = true;
            ControlTimer.Interval = 2000;
            ControlTimer.Start();

        }

        private void ControlTimer_Tick(object sender, EventArgs e)
        {
            // 현재 상태를 보고 BTN의 불을 켤것인지 말것인지 결정하자.

            // 값을 써주자.
            if (Repository.Instance.samsung_bcs.Mode_Charging == 1)
            {
                lb_System_Status.Text = "CHARGING";
            }
            else if (Repository.Instance.samsung_bcs.Mode_Discharging == 1)
            {
                lb_System_Status.Text = "DISCHARGING";
            }
            else if (Repository.Instance.samsung_bcs.Mode_Offline == 1)
            {
                lb_System_Status.Text = "OFFLINE";
            }
            else if (Repository.Instance.samsung_bcs.Mode_Idle == 1)
            {
                lb_System_Status.Text = "IDLE";
            }
            else if (Repository.Instance.samsung_bcs.Mode_Ready == 1)
            {
                lb_System_Status.Text = "READY";
            }
            else
            {
                lb_System_Status.Text = "UNEXPECTED";
            }
            int common_warning = Repository.Instance.samsung_bcs.Alarm_Summary1 +
                                Repository.Instance.samsung_bcs.Alarm_Summary2 +
                                Repository.Instance.samsung_bcs.Alarm_Summary3 +
                                Repository.Instance.samsung_bcs.Alarm_Summary4;
            int common_alarm = Repository.Instance.samsung_bcs.Protection_Summary1  +
                                Repository.Instance.samsung_bcs.Protection_Summary2 +
                                Repository.Instance.samsung_bcs.Protection_Summary3 +
                                Repository.Instance.samsung_bcs.Protection_Summary4;
            if (common_alarm > 0)
            {
                lb_Common_Alarm_Status.Text = "PROTECTION";
            }
            else if (common_warning > 0)
            {
                lb_Common_Alarm_Status.Text = "ALARM";
            }
            else
            {
                lb_Common_Alarm_Status.Text = "NORMAL";
            }


            if (Repository.Instance.GnEPS_PCS.Mode_Standby == 1)
            {
                lb_PCS_System_Status.Text = "STANDBY";
                ImageResize.ResizeImage(Properties.Resources.STOP_003, btn_IDLE.Width, btn_IDLE.Height);
                btn_Charging.Image = null;
                btn_Discharging = null;
            }
            else if (Repository.Instance.GnEPS_PCS.Mode_Charging == 1)
            {
                lb_PCS_System_Status.Text = "CHARGING";
                ImageResize.ResizeImage(Properties.Resources.RUN_003, btn_Charging.Width, btn_Charging.Height);
                btn_IDLE = null;
                btn_Discharging = null;
            }
            else if (Repository.Instance.GnEPS_PCS.Mode_Discharging == 1)
            {
                lb_PCS_System_Status.Text = "DISCHARGING";
                ImageResize.ResizeImage(Properties.Resources.RUN_003, btn_Discharging.Width, btn_Discharging.Height);
                btn_IDLE = null;
                btn_Charging.Image = null;
            }
            else
            {
                lb_PCS_System_Status.Text = "NO STANDBY";
            }

            if (Repository.Instance.bmsviewer.Connected() > 0)
            {
                // BCS가 끊어진것이 아닌 상태에서, 값이 올라올때만 버튼을 표시하자.
                if (Repository.Instance.samsung_bcs.Mode_Idle == 1 ||
                    Repository.Instance.samsung_bcs.Mode_Offline == 1)
                {
                    btn_Grid_ON.Image = null;
                    btn_Grid_OFF.Image = ImageResize.ResizeImage(Properties.Resources.STOP_003, btn_Grid_OFF.Width, btn_Grid_OFF.Height);
                }
                else if (Repository.Instance.samsung_bcs.Mode_Ready == 1 ||
                    Repository.Instance.samsung_bcs.Mode_Charging == 1 ||
                    Repository.Instance.samsung_bcs.Mode_Discharging == 1)
                {
                    btn_Grid_ON.Image = ImageResize.ResizeImage(Properties.Resources.RUN_003, btn_Grid_ON.Width, btn_Grid_ON.Height);
                    btn_Grid_OFF.Image = null;
                }
            }
            else
            {
                btn_Grid_ON.Image = null;
                btn_Grid_OFF.Image = null;
            }

            

                int PCS_alarm = Repository.Instance.GnEPS_PCS.PCS_GRID_Status +
                            Repository.Instance.GnEPS_PCS.PCS_Fault_Status;

            if (PCS_alarm > 0)
            {
                lb_PCS_Common_Alarm.Text = "ALARM";
            }
            else
            {
                lb_PCS_Common_Alarm.Text = "NORMAL";
            }

            if (Repository.Instance.bmsviewer.Connected() > 0)
            {
                lb_Batt_Comm_Status.Text = "NORMAL";
            }
            else
            {
                lb_Batt_Comm_Status.Text = "FAULT";

            }

            if (Repository.Instance.pmdviewer.Connected() > 0)
            {
                lb_PCS_Comm_Status.Text = "NORMAL";
            }
            else
            {
                lb_PCS_Comm_Status.Text = "FAULT";
            }

            // 버튼 색상 정하기.
            // Local Remote 상태를 보고 결정하기
            if (Repository.Instance.GnEPS_PCS.Authority_PMS)
            {
                btn_Control_uPMS.Image = null;
                btn_Control_LPMS.Image = ImageResize.ResizeImage(Properties.Resources.RUN_003, btn_Control_LPMS.Width, btn_Control_LPMS.Height);

                btn_Charging.Enabled = true;
                btn_Discharging.Enabled = true;
                btn_Grid_ON.Enabled = true;
                btn_Grid_OFF.Enabled = true;
                btn_IDLE.Enabled = true;
                btn_Manual_Mode.Enabled = true;
                btn_Scheduling_Mode.Enabled = true;
                tb_Power_Set.Enabled = true;


            }
            else
            {
                btn_Control_uPMS.Image = ImageResize.ResizeImage(Properties.Resources.RUN_003, btn_Control_uPMS.Width, btn_Control_uPMS.Height);
                btn_Control_LPMS.Image = null;

                btn_Charging.Enabled = false;
                btn_Discharging.Enabled = false;
                btn_Grid_ON.Enabled = false;
                btn_Grid_OFF.Enabled = false;
                btn_IDLE.Enabled = false;
                btn_Manual_Mode.Enabled = false;
                btn_Scheduling_Mode.Enabled = false;
                tb_Power_Set.Enabled = false;

            }
            
            index++;
            if (index == 5)
            {
                index = 0;
            }
        }

       
        
        private void btn_Grid_ON_MouseDown(object sender, MouseEventArgs e)
        {
            //Button button = (Button)sender;
  //          button.Image = ImageResize.ResizeImage(Properties.Resources.RUN_003, button.Width, button.Height);
        }

        private void btn_Grid_ON_MouseClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("GRID ON 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Repository.Instance.bmsviewer.GRID_ON();
            }
            
        }

        private void btn_Grid_OFF_MouseDown(object sender, MouseEventArgs e)
        {
            //Button button = (Button)sender;
//            button.Image = ImageResize.ResizeImage(Properties.Resources.RUN_003, button.Width, button.Height);
        }

        private void btn_Grid_OFF_MouseClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("GRID OFF 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Repository.Instance.bmsviewer.GRID_OFF();
            }
        }

        private void btn_IDLE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정지모드로 변경 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // PCS Mode 설정
                Repository.Instance.current_pcs_mode = 1;

                Repository.Instance.pmdviewer.Control_Idle();
            }
        }

        private void btn_Charging_Click(object sender, EventArgs e)
        {
            if (Repository.Instance.current_pcs_mode == 3)
            {
                MessageBox.Show("스케줄모드일때는 사용할 수 없습니다", "확인", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("충전모드로 변경 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Repository.Instance.pmdviewer.Control_Charge();
            }
        }

        private void btn_Discharging_Click(object sender, EventArgs e)
        {
            if (Repository.Instance.current_pcs_mode == 3)
            {
                MessageBox.Show("스케줄모드일때는 사용할 수 없습니다", "확인", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("방전모드로 변경 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Repository.Instance.pmdviewer.Control_Discharge();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void tb_Power_Set_TextChanged(object sender, EventArgs e)
        {
            Check_Active_Power_Input();
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

        private void btn_Manual_Mode_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("메뉴얼모드로 변경 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;

                Repository.Instance.current_pcs_mode = 2;   // 2 indicates Manual Mode
                btn_Manual_Mode.Image = ImageResize.ResizeImage(Properties.Resources.RUN_003, button.Width, button.Height);
                btn_Scheduling_Mode.Image = null;
            }
        }

        private void btn_Scheduling_Mode_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("스케줄모드로 변경 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                System.Windows.Forms.Button button = (System.Windows.Forms.Button)sender;

                btn_Manual_Mode.Image = null;
                btn_Scheduling_Mode.Image = ImageResize.ResizeImage(Properties.Resources.RUN_003, button.Width, button.Height);
                Repository.Instance.current_pcs_mode = 3;   // 3 indicates Scheduling Mode
            }
        }

        private void tb_Power_Set_Leave(object sender, EventArgs e)
        {
            if (MessageBox.Show("해당 설정을 적용하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Check_Active_Power_Input();
            }
        }
        // ----------------------------------------------
        // 2018-07-10 
        // Parameter로 설정된 Active_Power값을 검사하고
        // 적당할 값일 경우 데이터를 변수안에 집어넣는 함수이다
        // Check_Active_Power_Input
        // ----------------------------------------------
        private void Check_Active_Power_Input()
        {
            try
            {
                    double a = Convert.ToSingle(tb_Power_Set.Text);


                    if (a > Repository.Instance.p_setting.Limit_Active_Power)
                    {
                        a = Repository.Instance.p_setting.Limit_Active_Power;
                        MessageBox.Show("Power를 " + Repository.Instance.p_setting.Limit_Active_Power + "kW 이상 설정할 수 없습니다");
                    }
                    Repository.Instance.remote_power = Convert.ToUInt16(a * 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // -----------------------------------------------
        // KeyChar이 Enter가 들어오면 Enable의 Positive Edge를
        // 만들어줌으로 써, Focus를 잃게 만든다
        // -----------------------------------------------
        private void tb_Power_Set_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Enter:
                    tb_Power_Set.Enabled = false;
                    tb_Power_Set.Enabled = true;
                    break;
            }
        }

        private void tb_Power_Set_Validated(object sender, EventArgs e)
        {
            
        }

        private void btn_Control_LPMS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("LEMS 제어모드로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Repository.Instance.GnEPS_PCS.Authority_PMS = true;
            }
        }

        private void btn_Control_uPMS_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("uPMS 제어모드로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { 
                Repository.Instance.GnEPS_PCS.Authority_PMS = false;
            }
        }

        private void ControlViewer_Load(object sender, EventArgs e)
        {
            Repository.Instance.p_setting.Set_Current_PCS_Operating_Mode(Repository.Instance.p_setting.Charging_StartTime, Repository.Instance.p_setting.Charging_EndTime, Repository.Instance.p_setting.Discharging_StartTime, Repository.Instance.p_setting.Discharging_EndTime);
            Repository.Instance.p_setting.Set_Scheduler_Setting(Repository.Instance.p_setting.Charging_StartTime, Repository.Instance.p_setting.Charging_EndTime, Repository.Instance.p_setting.Discharging_StartTime, Repository.Instance.p_setting.Discharging_EndTime);
            Set_Scheduler_Color();

        }

        public void Set_Scheduler_Color()
        {
            
            foreach (Control gb in this.Controls)
            {
                if (gb_scheduler is GroupBox)
                {
                    foreach (Control btn in gb.Controls)
                    {
                        if (btn is Button)
                        {
                            string[] parse = btn.Name.Split('_');

                            int index = Convert.ToInt16(parse[2]);

                            if (Repository.Instance.scheduler[index] == 1)
                            {
                                btn.BackColor = Color.Red;
                            }
                            else if (Repository.Instance.scheduler[index] == 2)
                            {
                                btn.BackColor = Color.Blue;
                            }
                            else
                            {
                                btn.BackColor = Color.Gray;

                            }

                        }
                    }
                }
            }
        }
    }
}
