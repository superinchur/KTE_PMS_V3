using System;

namespace KTE_PMS.MIMIC
{
    partial class ControlViewer
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlViewer));
            this.ControlTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_Grid_OFF = new System.Windows.Forms.Button();
            this.btn_Grid_ON = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lb_Common_Alarm_Status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_PCS_System_Status = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_PCS_Common_Alarm = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_PCS_Comm_Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_System_Status = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Charging = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_Discharging = new System.Windows.Forms.Button();
            this.btn_IDLE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Batt_Comm_Status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Power_Set = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Manual_Mode = new System.Windows.Forms.Button();
            this.btn_Scheduling_Mode = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_Control_uPMS = new System.Windows.Forms.Button();
            this.btn_Control_LPMS = new System.Windows.Forms.Button();
            this.btn_t_0 = new System.Windows.Forms.Button();
            this.btn_t_1 = new System.Windows.Forms.Button();
            this.btn_t_2 = new System.Windows.Forms.Button();
            this.btn_t_3 = new System.Windows.Forms.Button();
            this.btn_t_7 = new System.Windows.Forms.Button();
            this.btn_t_6 = new System.Windows.Forms.Button();
            this.btn_t_5 = new System.Windows.Forms.Button();
            this.btn_t_4 = new System.Windows.Forms.Button();
            this.btn_t_11 = new System.Windows.Forms.Button();
            this.btn_t_10 = new System.Windows.Forms.Button();
            this.btn_t_9 = new System.Windows.Forms.Button();
            this.btn_t_8 = new System.Windows.Forms.Button();
            this.btn_t_23 = new System.Windows.Forms.Button();
            this.btn_t_22 = new System.Windows.Forms.Button();
            this.btn_t_21 = new System.Windows.Forms.Button();
            this.btn_t_20 = new System.Windows.Forms.Button();
            this.btn_t_19 = new System.Windows.Forms.Button();
            this.btn_t_18 = new System.Windows.Forms.Button();
            this.btn_t_17 = new System.Windows.Forms.Button();
            this.btn_t_16 = new System.Windows.Forms.Button();
            this.btn_t_15 = new System.Windows.Forms.Button();
            this.btn_t_14 = new System.Windows.Forms.Button();
            this.btn_t_13 = new System.Windows.Forms.Button();
            this.btn_t_12 = new System.Windows.Forms.Button();
            this.gb_scheduler = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.gb_scheduler.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlTimer
            // 
            this.ControlTimer.Interval = 400;
            this.ControlTimer.Tick += new System.EventHandler(this.ControlTimer_Tick);
            // 
            // btn_Grid_OFF
            // 
            this.btn_Grid_OFF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Grid_OFF.BackgroundImage")));
            this.btn_Grid_OFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Grid_OFF.Location = new System.Drawing.Point(663, 161);
            this.btn_Grid_OFF.Name = "btn_Grid_OFF";
            this.btn_Grid_OFF.Size = new System.Drawing.Size(51, 51);
            this.btn_Grid_OFF.TabIndex = 25;
            this.btn_Grid_OFF.TabStop = false;
            this.btn_Grid_OFF.UseVisualStyleBackColor = true;
            this.btn_Grid_OFF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Grid_OFF_MouseClick);
            this.btn_Grid_OFF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Grid_OFF_MouseDown);
            // 
            // btn_Grid_ON
            // 
            this.btn_Grid_ON.BackgroundImage = global::KTE_PMS.Properties.Resources.RUN_003_1;
            this.btn_Grid_ON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Grid_ON.Location = new System.Drawing.Point(563, 161);
            this.btn_Grid_ON.Name = "btn_Grid_ON";
            this.btn_Grid_ON.Size = new System.Drawing.Size(51, 51);
            this.btn_Grid_ON.TabIndex = 24;
            this.btn_Grid_ON.TabStop = false;
            this.btn_Grid_ON.UseVisualStyleBackColor = true;
            this.btn_Grid_ON.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Grid_ON_MouseClick);
            this.btn_Grid_ON.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Grid_ON_MouseDown);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(404, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 121);
            this.button1.TabIndex = 22;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(404, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 121);
            this.button5.TabIndex = 21;
            this.button5.TabStop = false;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // lb_Common_Alarm_Status
            // 
            this.lb_Common_Alarm_Status.AutoSize = true;
            this.lb_Common_Alarm_Status.BackColor = System.Drawing.Color.Transparent;
            this.lb_Common_Alarm_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Common_Alarm_Status.Location = new System.Drawing.Point(254, 121);
            this.lb_Common_Alarm_Status.Name = "lb_Common_Alarm_Status";
            this.lb_Common_Alarm_Status.Size = new System.Drawing.Size(72, 18);
            this.lb_Common_Alarm_Status.TabIndex = 78;
            this.lb_Common_Alarm_Status.Text = "NORMAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 18);
            this.label3.TabIndex = 79;
            this.label3.Text = "Common Alarm Status";
            // 
            // lb_PCS_System_Status
            // 
            this.lb_PCS_System_Status.AutoSize = true;
            this.lb_PCS_System_Status.BackColor = System.Drawing.Color.Transparent;
            this.lb_PCS_System_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PCS_System_Status.Location = new System.Drawing.Point(254, 279);
            this.lb_PCS_System_Status.Name = "lb_PCS_System_Status";
            this.lb_PCS_System_Status.Size = new System.Drawing.Size(72, 18);
            this.lb_PCS_System_Status.TabIndex = 80;
            this.lb_PCS_System_Status.Text = "NORMAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 81;
            this.label5.Text = "System Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 83;
            this.label6.Text = "Common Alarm";
            // 
            // lb_PCS_Common_Alarm
            // 
            this.lb_PCS_Common_Alarm.AutoSize = true;
            this.lb_PCS_Common_Alarm.BackColor = System.Drawing.Color.Transparent;
            this.lb_PCS_Common_Alarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PCS_Common_Alarm.Location = new System.Drawing.Point(254, 311);
            this.lb_PCS_Common_Alarm.Name = "lb_PCS_Common_Alarm";
            this.lb_PCS_Common_Alarm.Size = new System.Drawing.Size(72, 18);
            this.lb_PCS_Common_Alarm.TabIndex = 82;
            this.lb_PCS_Common_Alarm.Text = "NORMAL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 18);
            this.label8.TabIndex = 85;
            this.label8.Text = "Communication Status";
            // 
            // lb_PCS_Comm_Status
            // 
            this.lb_PCS_Comm_Status.AutoSize = true;
            this.lb_PCS_Comm_Status.BackColor = System.Drawing.Color.Transparent;
            this.lb_PCS_Comm_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PCS_Comm_Status.Location = new System.Drawing.Point(254, 342);
            this.lb_PCS_Comm_Status.Name = "lb_PCS_Comm_Status";
            this.lb_PCS_Comm_Status.Size = new System.Drawing.Size(72, 18);
            this.lb_PCS_Comm_Status.TabIndex = 84;
            this.lb_PCS_Comm_Status.Text = "NORMAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 87;
            this.label1.Text = "System Status";
            // 
            // lb_System_Status
            // 
            this.lb_System_Status.AutoSize = true;
            this.lb_System_Status.BackColor = System.Drawing.Color.Transparent;
            this.lb_System_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_System_Status.Location = new System.Drawing.Point(254, 89);
            this.lb_System_Status.Name = "lb_System_Status";
            this.lb_System_Status.Size = new System.Drawing.Size(72, 18);
            this.lb_System_Status.TabIndex = 86;
            this.lb_System_Status.Text = "NORMAL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(562, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 88;
            this.label11.Text = "Grid ON";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(660, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 18);
            this.label12.TabIndex = 89;
            this.label12.Text = "Grid OFF";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(568, 297);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 18);
            this.label13.TabIndex = 91;
            this.label13.Text = "Idle";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(628, 297);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 18);
            this.label14.TabIndex = 93;
            this.label14.Text = "Charging";
            // 
            // btn_Charging
            // 
            this.btn_Charging.BackgroundImage = global::KTE_PMS.Properties.Resources.RUN_003_1;
            this.btn_Charging.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Charging.Location = new System.Drawing.Point(639, 318);
            this.btn_Charging.Name = "btn_Charging";
            this.btn_Charging.Size = new System.Drawing.Size(51, 51);
            this.btn_Charging.TabIndex = 92;
            this.btn_Charging.TabStop = false;
            this.btn_Charging.UseVisualStyleBackColor = true;
            this.btn_Charging.Click += new System.EventHandler(this.btn_Charging_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(701, 297);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 18);
            this.label15.TabIndex = 95;
            this.label15.Text = "Discharging";
            // 
            // btn_Discharging
            // 
            this.btn_Discharging.BackgroundImage = global::KTE_PMS.Properties.Resources.RUN_003_1;
            this.btn_Discharging.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Discharging.Location = new System.Drawing.Point(717, 318);
            this.btn_Discharging.Name = "btn_Discharging";
            this.btn_Discharging.Size = new System.Drawing.Size(51, 51);
            this.btn_Discharging.TabIndex = 94;
            this.btn_Discharging.TabStop = false;
            this.btn_Discharging.UseVisualStyleBackColor = true;
            this.btn_Discharging.Click += new System.EventHandler(this.btn_Discharging_Click);
            // 
            // btn_IDLE
            // 
            this.btn_IDLE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_IDLE.BackgroundImage")));
            this.btn_IDLE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_IDLE.Location = new System.Drawing.Point(560, 318);
            this.btn_IDLE.Name = "btn_IDLE";
            this.btn_IDLE.Size = new System.Drawing.Size(51, 51);
            this.btn_IDLE.TabIndex = 96;
            this.btn_IDLE.TabStop = false;
            this.btn_IDLE.UseVisualStyleBackColor = true;
            this.btn_IDLE.Click += new System.EventHandler(this.btn_IDLE_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 18);
            this.label2.TabIndex = 98;
            this.label2.Text = "Communication Status";
            // 
            // lb_Batt_Comm_Status
            // 
            this.lb_Batt_Comm_Status.AutoSize = true;
            this.lb_Batt_Comm_Status.BackColor = System.Drawing.Color.Transparent;
            this.lb_Batt_Comm_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Batt_Comm_Status.Location = new System.Drawing.Point(254, 150);
            this.lb_Batt_Comm_Status.Name = "lb_Batt_Comm_Status";
            this.lb_Batt_Comm_Status.Size = new System.Drawing.Size(72, 18);
            this.lb_Batt_Comm_Status.TabIndex = 97;
            this.lb_Batt_Comm_Status.Text = "NORMAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(794, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 100;
            this.label4.Text = "Power 설정값";
            // 
            // tb_Power_Set
            // 
            this.tb_Power_Set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tb_Power_Set.Font = new System.Drawing.Font("나눔바른고딕", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Power_Set.Location = new System.Drawing.Point(784, 326);
            this.tb_Power_Set.Mask = "99.9";
            this.tb_Power_Set.Name = "tb_Power_Set";
            this.tb_Power_Set.Size = new System.Drawing.Size(101, 48);
            this.tb_Power_Set.TabIndex = 101;
            this.tb_Power_Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Power_Set.ValidatingType = typeof(int);
            this.tb_Power_Set.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tb_Power_Set_MaskInputRejected);
            this.tb_Power_Set.TextChanged += new System.EventHandler(this.tb_Power_Set_TextChanged);
            this.tb_Power_Set.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Power_Set_KeyPress);
            this.tb_Power_Set.Leave += new System.EventHandler(this.tb_Power_Set_Leave);
            this.tb_Power_Set.Validated += new System.EventHandler(this.tb_Power_Set_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(886, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 27);
            this.label7.TabIndex = 102;
            this.label7.Text = "kW";
            // 
            // btn_Manual_Mode
            // 
            this.btn_Manual_Mode.BackgroundImage = global::KTE_PMS.Properties.Resources.RUN_003_1;
            this.btn_Manual_Mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Manual_Mode.Location = new System.Drawing.Point(563, 246);
            this.btn_Manual_Mode.Name = "btn_Manual_Mode";
            this.btn_Manual_Mode.Size = new System.Drawing.Size(51, 51);
            this.btn_Manual_Mode.TabIndex = 103;
            this.btn_Manual_Mode.TabStop = false;
            this.btn_Manual_Mode.UseVisualStyleBackColor = true;
            this.btn_Manual_Mode.Click += new System.EventHandler(this.btn_Manual_Mode_Click);
            // 
            // btn_Scheduling_Mode
            // 
            this.btn_Scheduling_Mode.BackgroundImage = global::KTE_PMS.Properties.Resources.RUN_003_1;
            this.btn_Scheduling_Mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Scheduling_Mode.Location = new System.Drawing.Point(663, 246);
            this.btn_Scheduling_Mode.Name = "btn_Scheduling_Mode";
            this.btn_Scheduling_Mode.Size = new System.Drawing.Size(51, 51);
            this.btn_Scheduling_Mode.TabIndex = 104;
            this.btn_Scheduling_Mode.TabStop = false;
            this.btn_Scheduling_Mode.UseVisualStyleBackColor = true;
            this.btn_Scheduling_Mode.Click += new System.EventHandler(this.btn_Scheduling_Mode_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(539, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 105;
            this.label9.Text = "Manual Mode";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(631, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 18);
            this.label10.TabIndex = 106;
            this.label10.Text = "Scheduling Mode";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(428, 187);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 17);
            this.label16.TabIndex = 107;
            this.label16.Text = "BATTERY";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(446, 346);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 17);
            this.label17.TabIndex = 108;
            this.label17.Text = "PCS";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(665, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 18);
            this.label18.TabIndex = 112;
            this.label18.Text = "uPMS";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(565, 67);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 18);
            this.label19.TabIndex = 111;
            this.label19.Text = "LPMS";
            // 
            // btn_Control_uPMS
            // 
            this.btn_Control_uPMS.BackgroundImage = global::KTE_PMS.Properties.Resources.RUN_003_1;
            this.btn_Control_uPMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Control_uPMS.Location = new System.Drawing.Point(663, 88);
            this.btn_Control_uPMS.Name = "btn_Control_uPMS";
            this.btn_Control_uPMS.Size = new System.Drawing.Size(51, 51);
            this.btn_Control_uPMS.TabIndex = 110;
            this.btn_Control_uPMS.TabStop = false;
            this.btn_Control_uPMS.UseVisualStyleBackColor = true;
            this.btn_Control_uPMS.Click += new System.EventHandler(this.btn_Control_uPMS_Click);
            // 
            // btn_Control_LPMS
            // 
            this.btn_Control_LPMS.BackgroundImage = global::KTE_PMS.Properties.Resources.RUN_003_1;
            this.btn_Control_LPMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Control_LPMS.Location = new System.Drawing.Point(563, 88);
            this.btn_Control_LPMS.Name = "btn_Control_LPMS";
            this.btn_Control_LPMS.Size = new System.Drawing.Size(51, 51);
            this.btn_Control_LPMS.TabIndex = 109;
            this.btn_Control_LPMS.TabStop = false;
            this.btn_Control_LPMS.UseVisualStyleBackColor = true;
            this.btn_Control_LPMS.Click += new System.EventHandler(this.btn_Control_LPMS_Click);
            // 
            // btn_t_0
            // 
            this.btn_t_0.Location = new System.Drawing.Point(37, 13);
            this.btn_t_0.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_0.Name = "btn_t_0";
            this.btn_t_0.Size = new System.Drawing.Size(16, 25);
            this.btn_t_0.TabIndex = 113;
            this.btn_t_0.UseVisualStyleBackColor = true;
            // 
            // btn_t_1
            // 
            this.btn_t_1.Location = new System.Drawing.Point(54, 13);
            this.btn_t_1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_1.Name = "btn_t_1";
            this.btn_t_1.Size = new System.Drawing.Size(16, 25);
            this.btn_t_1.TabIndex = 114;
            this.btn_t_1.UseVisualStyleBackColor = true;
            // 
            // btn_t_2
            // 
            this.btn_t_2.Location = new System.Drawing.Point(71, 13);
            this.btn_t_2.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_2.Name = "btn_t_2";
            this.btn_t_2.Size = new System.Drawing.Size(16, 25);
            this.btn_t_2.TabIndex = 115;
            this.btn_t_2.UseVisualStyleBackColor = true;
            // 
            // btn_t_3
            // 
            this.btn_t_3.Location = new System.Drawing.Point(88, 13);
            this.btn_t_3.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_3.Name = "btn_t_3";
            this.btn_t_3.Size = new System.Drawing.Size(16, 25);
            this.btn_t_3.TabIndex = 116;
            this.btn_t_3.UseVisualStyleBackColor = true;
            // 
            // btn_t_7
            // 
            this.btn_t_7.Location = new System.Drawing.Point(156, 13);
            this.btn_t_7.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_7.Name = "btn_t_7";
            this.btn_t_7.Size = new System.Drawing.Size(16, 25);
            this.btn_t_7.TabIndex = 120;
            this.btn_t_7.UseVisualStyleBackColor = true;
            // 
            // btn_t_6
            // 
            this.btn_t_6.Location = new System.Drawing.Point(139, 13);
            this.btn_t_6.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_6.Name = "btn_t_6";
            this.btn_t_6.Size = new System.Drawing.Size(16, 25);
            this.btn_t_6.TabIndex = 119;
            this.btn_t_6.UseVisualStyleBackColor = true;
            // 
            // btn_t_5
            // 
            this.btn_t_5.Location = new System.Drawing.Point(122, 13);
            this.btn_t_5.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_5.Name = "btn_t_5";
            this.btn_t_5.Size = new System.Drawing.Size(16, 25);
            this.btn_t_5.TabIndex = 118;
            this.btn_t_5.UseVisualStyleBackColor = true;
            // 
            // btn_t_4
            // 
            this.btn_t_4.Location = new System.Drawing.Point(105, 13);
            this.btn_t_4.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_4.Name = "btn_t_4";
            this.btn_t_4.Size = new System.Drawing.Size(16, 25);
            this.btn_t_4.TabIndex = 117;
            this.btn_t_4.UseVisualStyleBackColor = true;
            // 
            // btn_t_11
            // 
            this.btn_t_11.Location = new System.Drawing.Point(224, 13);
            this.btn_t_11.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_11.Name = "btn_t_11";
            this.btn_t_11.Size = new System.Drawing.Size(16, 25);
            this.btn_t_11.TabIndex = 124;
            this.btn_t_11.UseVisualStyleBackColor = true;
            // 
            // btn_t_10
            // 
            this.btn_t_10.Location = new System.Drawing.Point(207, 13);
            this.btn_t_10.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_10.Name = "btn_t_10";
            this.btn_t_10.Size = new System.Drawing.Size(16, 25);
            this.btn_t_10.TabIndex = 123;
            this.btn_t_10.UseVisualStyleBackColor = true;
            // 
            // btn_t_9
            // 
            this.btn_t_9.Location = new System.Drawing.Point(190, 13);
            this.btn_t_9.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_9.Name = "btn_t_9";
            this.btn_t_9.Size = new System.Drawing.Size(16, 25);
            this.btn_t_9.TabIndex = 122;
            this.btn_t_9.UseVisualStyleBackColor = true;
            // 
            // btn_t_8
            // 
            this.btn_t_8.Location = new System.Drawing.Point(173, 13);
            this.btn_t_8.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_8.Name = "btn_t_8";
            this.btn_t_8.Size = new System.Drawing.Size(16, 25);
            this.btn_t_8.TabIndex = 121;
            this.btn_t_8.UseVisualStyleBackColor = true;
            // 
            // btn_t_23
            // 
            this.btn_t_23.Location = new System.Drawing.Point(223, 38);
            this.btn_t_23.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_23.Name = "btn_t_23";
            this.btn_t_23.Size = new System.Drawing.Size(16, 25);
            this.btn_t_23.TabIndex = 136;
            this.btn_t_23.UseVisualStyleBackColor = true;
            // 
            // btn_t_22
            // 
            this.btn_t_22.Location = new System.Drawing.Point(206, 38);
            this.btn_t_22.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_22.Name = "btn_t_22";
            this.btn_t_22.Size = new System.Drawing.Size(16, 25);
            this.btn_t_22.TabIndex = 135;
            this.btn_t_22.UseVisualStyleBackColor = true;
            // 
            // btn_t_21
            // 
            this.btn_t_21.Location = new System.Drawing.Point(189, 38);
            this.btn_t_21.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_21.Name = "btn_t_21";
            this.btn_t_21.Size = new System.Drawing.Size(16, 25);
            this.btn_t_21.TabIndex = 134;
            this.btn_t_21.UseVisualStyleBackColor = true;
            // 
            // btn_t_20
            // 
            this.btn_t_20.Location = new System.Drawing.Point(172, 38);
            this.btn_t_20.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_20.Name = "btn_t_20";
            this.btn_t_20.Size = new System.Drawing.Size(16, 25);
            this.btn_t_20.TabIndex = 133;
            this.btn_t_20.UseVisualStyleBackColor = true;
            // 
            // btn_t_19
            // 
            this.btn_t_19.Location = new System.Drawing.Point(155, 38);
            this.btn_t_19.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_19.Name = "btn_t_19";
            this.btn_t_19.Size = new System.Drawing.Size(16, 25);
            this.btn_t_19.TabIndex = 132;
            this.btn_t_19.UseVisualStyleBackColor = true;
            // 
            // btn_t_18
            // 
            this.btn_t_18.Location = new System.Drawing.Point(138, 38);
            this.btn_t_18.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_18.Name = "btn_t_18";
            this.btn_t_18.Size = new System.Drawing.Size(16, 25);
            this.btn_t_18.TabIndex = 131;
            this.btn_t_18.UseVisualStyleBackColor = true;
            // 
            // btn_t_17
            // 
            this.btn_t_17.Location = new System.Drawing.Point(121, 38);
            this.btn_t_17.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_17.Name = "btn_t_17";
            this.btn_t_17.Size = new System.Drawing.Size(16, 25);
            this.btn_t_17.TabIndex = 130;
            this.btn_t_17.UseVisualStyleBackColor = true;
            // 
            // btn_t_16
            // 
            this.btn_t_16.Location = new System.Drawing.Point(104, 38);
            this.btn_t_16.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_16.Name = "btn_t_16";
            this.btn_t_16.Size = new System.Drawing.Size(16, 25);
            this.btn_t_16.TabIndex = 129;
            this.btn_t_16.UseVisualStyleBackColor = true;
            // 
            // btn_t_15
            // 
            this.btn_t_15.Location = new System.Drawing.Point(87, 38);
            this.btn_t_15.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_15.Name = "btn_t_15";
            this.btn_t_15.Size = new System.Drawing.Size(16, 25);
            this.btn_t_15.TabIndex = 128;
            this.btn_t_15.UseVisualStyleBackColor = true;
            // 
            // btn_t_14
            // 
            this.btn_t_14.Location = new System.Drawing.Point(70, 38);
            this.btn_t_14.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_14.Name = "btn_t_14";
            this.btn_t_14.Size = new System.Drawing.Size(16, 25);
            this.btn_t_14.TabIndex = 127;
            this.btn_t_14.UseVisualStyleBackColor = true;
            // 
            // btn_t_13
            // 
            this.btn_t_13.Location = new System.Drawing.Point(53, 38);
            this.btn_t_13.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_13.Name = "btn_t_13";
            this.btn_t_13.Size = new System.Drawing.Size(16, 25);
            this.btn_t_13.TabIndex = 126;
            this.btn_t_13.UseVisualStyleBackColor = true;
            // 
            // btn_t_12
            // 
            this.btn_t_12.Location = new System.Drawing.Point(36, 38);
            this.btn_t_12.Margin = new System.Windows.Forms.Padding(0);
            this.btn_t_12.Name = "btn_t_12";
            this.btn_t_12.Size = new System.Drawing.Size(16, 25);
            this.btn_t_12.TabIndex = 125;
            this.btn_t_12.UseVisualStyleBackColor = true;
            // 
            // gb_scheduler
            // 
            this.gb_scheduler.Controls.Add(this.label20);
            this.gb_scheduler.Controls.Add(this.label21);
            this.gb_scheduler.Controls.Add(this.btn_t_11);
            this.gb_scheduler.Controls.Add(this.btn_t_23);
            this.gb_scheduler.Controls.Add(this.btn_t_0);
            this.gb_scheduler.Controls.Add(this.btn_t_22);
            this.gb_scheduler.Controls.Add(this.btn_t_1);
            this.gb_scheduler.Controls.Add(this.btn_t_21);
            this.gb_scheduler.Controls.Add(this.btn_t_2);
            this.gb_scheduler.Controls.Add(this.btn_t_20);
            this.gb_scheduler.Controls.Add(this.btn_t_3);
            this.gb_scheduler.Controls.Add(this.btn_t_19);
            this.gb_scheduler.Controls.Add(this.btn_t_4);
            this.gb_scheduler.Controls.Add(this.btn_t_18);
            this.gb_scheduler.Controls.Add(this.btn_t_5);
            this.gb_scheduler.Controls.Add(this.btn_t_17);
            this.gb_scheduler.Controls.Add(this.btn_t_6);
            this.gb_scheduler.Controls.Add(this.btn_t_16);
            this.gb_scheduler.Controls.Add(this.btn_t_7);
            this.gb_scheduler.Controls.Add(this.btn_t_15);
            this.gb_scheduler.Controls.Add(this.btn_t_8);
            this.gb_scheduler.Controls.Add(this.btn_t_14);
            this.gb_scheduler.Controls.Add(this.btn_t_9);
            this.gb_scheduler.Controls.Add(this.btn_t_13);
            this.gb_scheduler.Controls.Add(this.btn_t_10);
            this.gb_scheduler.Controls.Add(this.btn_t_12);
            this.gb_scheduler.Location = new System.Drawing.Point(77, 171);
            this.gb_scheduler.Name = "gb_scheduler";
            this.gb_scheduler.Size = new System.Drawing.Size(240, 70);
            this.gb_scheduler.TabIndex = 137;
            this.gb_scheduler.TabStop = false;
            this.gb_scheduler.Text = "Scheduler";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(7, 44);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 14);
            this.label20.TabIndex = 140;
            this.label20.Text = "오후";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(7, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 14);
            this.label21.TabIndex = 139;
            this.label21.Text = "오전";
            // 
            // ControlViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gb_scheduler);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btn_Control_uPMS);
            this.Controls.Add(this.btn_Control_LPMS);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Scheduling_Mode);
            this.Controls.Add(this.btn_Manual_Mode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_Power_Set);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Batt_Comm_Status);
            this.Controls.Add(this.btn_IDLE);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_Discharging);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_Charging);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_System_Status);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_PCS_Comm_Status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_PCS_Common_Alarm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_PCS_System_Status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_Common_Alarm_Status);
            this.Controls.Add(this.btn_Grid_OFF);
            this.Controls.Add(this.btn_Grid_ON);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlViewer";
            this.Size = new System.Drawing.Size(960, 434);
            this.Load += new System.EventHandler(this.ControlViewer_Load);
            this.gb_scheduler.ResumeLayout(false);
            this.gb_scheduler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public byte[] getTextBox1()
        {
            byte[] kk = new byte[6];

            //kk[0] = Convert.ToByte(textBox1.Text);
            //kk[1] = Convert.ToByte(textBox2.Text);
            //kk[2] = Convert.ToByte(textBox3.Text);
            //kk[3] = Convert.ToByte(textBox4.Text);
            //kk[4] = Convert.ToByte(textBox5.Text);
            //kk[5] = Convert.ToByte(textBox6.Text);

            return kk;
        }

        public byte[] set_TextBox(int a, int b, int c, int d, int e)
        {
            byte[] kk = new byte[6];



            return kk;
        }
        private System.Windows.Forms.Timer ControlTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_Grid_OFF;
        private System.Windows.Forms.Button btn_Grid_ON;
        private System.Windows.Forms.Label lb_Common_Alarm_Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_PCS_System_Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_PCS_Common_Alarm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_PCS_Comm_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_System_Status;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Charging;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_Discharging;
        private System.Windows.Forms.Button btn_IDLE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Batt_Comm_Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tb_Power_Set;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Manual_Mode;
        private System.Windows.Forms.Button btn_Scheduling_Mode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_Control_uPMS;
        private System.Windows.Forms.Button btn_Control_LPMS;
        private System.Windows.Forms.Button btn_t_0;
        private System.Windows.Forms.Button btn_t_1;
        private System.Windows.Forms.Button btn_t_2;
        private System.Windows.Forms.Button btn_t_3;
        private System.Windows.Forms.Button btn_t_7;
        private System.Windows.Forms.Button btn_t_6;
        private System.Windows.Forms.Button btn_t_5;
        private System.Windows.Forms.Button btn_t_4;
        private System.Windows.Forms.Button btn_t_11;
        private System.Windows.Forms.Button btn_t_10;
        private System.Windows.Forms.Button btn_t_9;
        private System.Windows.Forms.Button btn_t_8;
        private System.Windows.Forms.Button btn_t_23;
        private System.Windows.Forms.Button btn_t_22;
        private System.Windows.Forms.Button btn_t_21;
        private System.Windows.Forms.Button btn_t_20;
        private System.Windows.Forms.Button btn_t_19;
        private System.Windows.Forms.Button btn_t_18;
        private System.Windows.Forms.Button btn_t_17;
        private System.Windows.Forms.Button btn_t_16;
        private System.Windows.Forms.Button btn_t_15;
        private System.Windows.Forms.Button btn_t_14;
        private System.Windows.Forms.Button btn_t_13;
        private System.Windows.Forms.Button btn_t_12;
        private System.Windows.Forms.GroupBox gb_scheduler;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}
