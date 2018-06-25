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
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
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
            this.btn_Grid_OFF.Location = new System.Drawing.Point(667, 162);
            this.btn_Grid_OFF.Name = "btn_Grid_OFF";
            this.btn_Grid_OFF.Size = new System.Drawing.Size(51, 51);
            this.btn_Grid_OFF.TabIndex = 25;
            this.btn_Grid_OFF.UseVisualStyleBackColor = true;
            this.btn_Grid_OFF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Grid_OFF_MouseClick);
            this.btn_Grid_OFF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Grid_OFF_MouseDown);
            // 
            // btn_Grid_ON
            // 
            this.btn_Grid_ON.BackgroundImage = global::KTE_PMS.Properties.Resources.RUN_003_1;
            this.btn_Grid_ON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Grid_ON.Location = new System.Drawing.Point(567, 162);
            this.btn_Grid_ON.Name = "btn_Grid_ON";
            this.btn_Grid_ON.Size = new System.Drawing.Size(51, 51);
            this.btn_Grid_ON.TabIndex = 24;
            this.btn_Grid_ON.UseVisualStyleBackColor = true;
            this.btn_Grid_ON.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Grid_ON_MouseClick);
            this.btn_Grid_ON.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Grid_ON_MouseDown);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(429, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 23;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(429, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(429, 314);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 21;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::KTE_PMS.Properties.Resources.TREND_button_grid_off_1;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(429, 69);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.TabIndex = 20;
            this.button6.UseVisualStyleBackColor = true;
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
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(562, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 18);
            this.label11.TabIndex = 88;
            this.label11.Text = "Grid ON";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(660, 141);
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
            this.label13.Location = new System.Drawing.Point(578, 302);
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
            this.label14.Location = new System.Drawing.Point(633, 302);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 18);
            this.label14.TabIndex = 93;
            this.label14.Text = "Charging";
            // 
            // btn_Charging
            // 
            this.btn_Charging.BackgroundImage = global::KTE_PMS.Properties.Resources.RUN_003_1;
            this.btn_Charging.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Charging.Location = new System.Drawing.Point(644, 323);
            this.btn_Charging.Name = "btn_Charging";
            this.btn_Charging.Size = new System.Drawing.Size(51, 51);
            this.btn_Charging.TabIndex = 92;
            this.btn_Charging.UseVisualStyleBackColor = true;
            this.btn_Charging.Click += new System.EventHandler(this.btn_Charging_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(706, 302);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 18);
            this.label15.TabIndex = 95;
            this.label15.Text = "Discharging";
            // 
            // btn_Discharging
            // 
            this.btn_Discharging.BackgroundImage = global::KTE_PMS.Properties.Resources.RUN_003_1;
            this.btn_Discharging.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Discharging.Location = new System.Drawing.Point(722, 323);
            this.btn_Discharging.Name = "btn_Discharging";
            this.btn_Discharging.Size = new System.Drawing.Size(51, 51);
            this.btn_Discharging.TabIndex = 94;
            this.btn_Discharging.UseVisualStyleBackColor = true;
            this.btn_Discharging.Click += new System.EventHandler(this.btn_Discharging_Click);
            // 
            // btn_IDLE
            // 
            this.btn_IDLE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_IDLE.BackgroundImage")));
            this.btn_IDLE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_IDLE.Location = new System.Drawing.Point(567, 323);
            this.btn_IDLE.Name = "btn_IDLE";
            this.btn_IDLE.Size = new System.Drawing.Size(51, 51);
            this.btn_IDLE.TabIndex = 96;
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
            this.label4.Location = new System.Drawing.Point(799, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 100;
            this.label4.Text = "Power 설정값";
            // 
            // tb_Power_Set
            // 
            this.tb_Power_Set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tb_Power_Set.Font = new System.Drawing.Font("나눔바른고딕", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Power_Set.Location = new System.Drawing.Point(799, 323);
            this.tb_Power_Set.Mask = "999.9";
            this.tb_Power_Set.Name = "tb_Power_Set";
            this.tb_Power_Set.Size = new System.Drawing.Size(81, 48);
            this.tb_Power_Set.TabIndex = 101;
            this.tb_Power_Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Power_Set.ValidatingType = typeof(int);
            this.tb_Power_Set.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tb_Power_Set_MaskInputRejected);
            this.tb_Power_Set.TextChanged += new System.EventHandler(this.tb_Power_Set_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(885, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 27);
            this.label7.TabIndex = 102;
            this.label7.Text = "kW";
            // 
            // btn_Manual_Mode
            // 
            this.btn_Manual_Mode.BackgroundImage = global::KTE_PMS.Properties.Resources.RUN_003_1;
            this.btn_Manual_Mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Manual_Mode.Location = new System.Drawing.Point(567, 239);
            this.btn_Manual_Mode.Name = "btn_Manual_Mode";
            this.btn_Manual_Mode.Size = new System.Drawing.Size(51, 51);
            this.btn_Manual_Mode.TabIndex = 103;
            this.btn_Manual_Mode.UseVisualStyleBackColor = true;
            this.btn_Manual_Mode.Click += new System.EventHandler(this.btn_Manual_Mode_Click);
            // 
            // btn_Scheduling_Mode
            // 
            this.btn_Scheduling_Mode.BackgroundImage = global::KTE_PMS.Properties.Resources.RUN_003_1;
            this.btn_Scheduling_Mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Scheduling_Mode.Location = new System.Drawing.Point(667, 239);
            this.btn_Scheduling_Mode.Name = "btn_Scheduling_Mode";
            this.btn_Scheduling_Mode.Size = new System.Drawing.Size(51, 51);
            this.btn_Scheduling_Mode.TabIndex = 104;
            this.btn_Scheduling_Mode.UseVisualStyleBackColor = true;
            this.btn_Scheduling_Mode.Click += new System.EventHandler(this.btn_Scheduling_Mode_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(545, 218);
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
            this.label10.Location = new System.Drawing.Point(649, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 18);
            this.label10.TabIndex = 106;
            this.label10.Text = "Scheduling Mode";
            // 
            // ControlViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlViewer";
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
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
    }
}
