﻿using System;

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
            this.lb_Power_Set = new System.Windows.Forms.Label();
            this.tb_Power_Set = new System.Windows.Forms.MaskedTextBox();
            this.btn_LEMS = new System.Windows.Forms.Button();
            this.btn_uPMS = new System.Windows.Forms.Button();
            this.btn_CustomMode = new System.Windows.Forms.Button();
            this.btn_PeakCutMode = new System.Windows.Forms.Button();
            this.btn_DisChargingMode = new System.Windows.Forms.Button();
            this.btn_ChargingMode = new System.Windows.Forms.Button();
            this.lb_Charging_Stop_SOC = new System.Windows.Forms.Label();
            this.lb_Discharging_Stop_SOC = new System.Windows.Forms.Label();
            this.tb_Discharging_Stop_SOC = new System.Windows.Forms.MaskedTextBox();
            this.btn_Confirm_Discharging_Stop_SOC = new System.Windows.Forms.Button();
            this.cover_control = new System.Windows.Forms.PictureBox();
            this.cover_scheduling = new System.Windows.Forms.PictureBox();
            this.btn_BMS_RESET = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.esS_Scheduler1 = new KTE_PMS.ESS_Scheduler();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cover_control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cover_scheduling)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlTimer
            // 
            this.ControlTimer.Interval = 400;
            this.ControlTimer.Tick += new System.EventHandler(this.ControlTimer_Tick);
            // 
            // lb_Power_Set
            // 
            this.lb_Power_Set.BackColor = System.Drawing.Color.Transparent;
            this.lb_Power_Set.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Power_Set.Location = new System.Drawing.Point(997, 198);
            this.lb_Power_Set.Name = "lb_Power_Set";
            this.lb_Power_Set.Size = new System.Drawing.Size(132, 28);
            this.lb_Power_Set.TabIndex = 91;
            this.lb_Power_Set.Text = "12.34";
            this.lb_Power_Set.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Power_Set
            // 
            this.tb_Power_Set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tb_Power_Set.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Power_Set.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Power_Set.Location = new System.Drawing.Point(1029, 239);
            this.tb_Power_Set.Mask = "99.9";
            this.tb_Power_Set.Name = "tb_Power_Set";
            this.tb_Power_Set.Size = new System.Drawing.Size(59, 14);
            this.tb_Power_Set.TabIndex = 101;
            this.tb_Power_Set.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Power_Set.ValidatingType = typeof(int);
            this.tb_Power_Set.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tb_Power_Set_MaskInputRejected);
            this.tb_Power_Set.TextChanged += new System.EventHandler(this.tb_Power_Set_TextChanged);
            this.tb_Power_Set.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Power_Set_KeyPress);
            this.tb_Power_Set.Leave += new System.EventHandler(this.tb_Power_Set_Leave);
            this.tb_Power_Set.Validated += new System.EventHandler(this.tb_Power_Set_Validated);
            // 
            // btn_LEMS
            // 
            this.btn_LEMS.BackColor = System.Drawing.Color.Transparent;
            this.btn_LEMS.BackgroundImage = global::KTE_PMS.Properties.Resources.LEMS_off;
            this.btn_LEMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_LEMS.FlatAppearance.BorderSize = 0;
            this.btn_LEMS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_LEMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_LEMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LEMS.Location = new System.Drawing.Point(348, 141);
            this.btn_LEMS.Name = "btn_LEMS";
            this.btn_LEMS.Size = new System.Drawing.Size(186, 52);
            this.btn_LEMS.TabIndex = 108;
            this.btn_LEMS.UseVisualStyleBackColor = false;
            this.btn_LEMS.Click += new System.EventHandler(this.btn_LEMS_Click);
            this.btn_LEMS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_LEMS_MouseDown);
            this.btn_LEMS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_LEMS_MouseUp);
            // 
            // btn_uPMS
            // 
            this.btn_uPMS.BackColor = System.Drawing.Color.Transparent;
            this.btn_uPMS.BackgroundImage = global::KTE_PMS.Properties.Resources.uPMS_off;
            this.btn_uPMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_uPMS.FlatAppearance.BorderSize = 0;
            this.btn_uPMS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_uPMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_uPMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uPMS.Location = new System.Drawing.Point(103, 141);
            this.btn_uPMS.Name = "btn_uPMS";
            this.btn_uPMS.Size = new System.Drawing.Size(186, 52);
            this.btn_uPMS.TabIndex = 107;
            this.btn_uPMS.UseVisualStyleBackColor = false;
            this.btn_uPMS.Click += new System.EventHandler(this.btn_uPMS_Click);
            this.btn_uPMS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_uPMS_MouseDown);
            this.btn_uPMS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_uPMS_MouseUp);
            // 
            // btn_CustomMode
            // 
            this.btn_CustomMode.BackColor = System.Drawing.Color.Transparent;
            this.btn_CustomMode.BackgroundImage = global::KTE_PMS.Properties.Resources.사용자정의_off;
            this.btn_CustomMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CustomMode.FlatAppearance.BorderSize = 0;
            this.btn_CustomMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CustomMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CustomMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CustomMode.Location = new System.Drawing.Point(460, 349);
            this.btn_CustomMode.Name = "btn_CustomMode";
            this.btn_CustomMode.Size = new System.Drawing.Size(108, 60);
            this.btn_CustomMode.TabIndex = 112;
            this.btn_CustomMode.UseVisualStyleBackColor = false;
            this.btn_CustomMode.Click += new System.EventHandler(this.btn_CustomMode_Click);
            this.btn_CustomMode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_CustomMode_MouseDown);
            this.btn_CustomMode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_CustomMode_MouseUp);
            // 
            // btn_PeakCutMode
            // 
            this.btn_PeakCutMode.BackColor = System.Drawing.Color.Transparent;
            this.btn_PeakCutMode.BackgroundImage = global::KTE_PMS.Properties.Resources.피크저감_off;
            this.btn_PeakCutMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PeakCutMode.FlatAppearance.BorderSize = 0;
            this.btn_PeakCutMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_PeakCutMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_PeakCutMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PeakCutMode.Location = new System.Drawing.Point(81, 349);
            this.btn_PeakCutMode.Name = "btn_PeakCutMode";
            this.btn_PeakCutMode.Size = new System.Drawing.Size(108, 60);
            this.btn_PeakCutMode.TabIndex = 111;
            this.btn_PeakCutMode.UseVisualStyleBackColor = false;
            this.btn_PeakCutMode.Click += new System.EventHandler(this.btn_PeakCutMode_Click);
            this.btn_PeakCutMode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_PeakCutMode_MouseDown);
            this.btn_PeakCutMode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_PeakCutMode_MouseUp);
            // 
            // btn_DisChargingMode
            // 
            this.btn_DisChargingMode.BackColor = System.Drawing.Color.Transparent;
            this.btn_DisChargingMode.BackgroundImage = global::KTE_PMS.Properties.Resources.방전_off;
            this.btn_DisChargingMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DisChargingMode.FlatAppearance.BorderSize = 0;
            this.btn_DisChargingMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_DisChargingMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_DisChargingMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DisChargingMode.Location = new System.Drawing.Point(337, 349);
            this.btn_DisChargingMode.Name = "btn_DisChargingMode";
            this.btn_DisChargingMode.Size = new System.Drawing.Size(108, 60);
            this.btn_DisChargingMode.TabIndex = 110;
            this.btn_DisChargingMode.UseVisualStyleBackColor = false;
            this.btn_DisChargingMode.Click += new System.EventHandler(this.btn_DisChargingMode_Click);
            this.btn_DisChargingMode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_DisChargingMode_MouseDown);
            this.btn_DisChargingMode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_DisChargingMode_MouseUp);
            // 
            // btn_ChargingMode
            // 
            this.btn_ChargingMode.BackColor = System.Drawing.Color.Transparent;
            this.btn_ChargingMode.BackgroundImage = global::KTE_PMS.Properties.Resources.충전_off;
            this.btn_ChargingMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ChargingMode.FlatAppearance.BorderSize = 0;
            this.btn_ChargingMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ChargingMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ChargingMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChargingMode.Location = new System.Drawing.Point(211, 349);
            this.btn_ChargingMode.Name = "btn_ChargingMode";
            this.btn_ChargingMode.Size = new System.Drawing.Size(108, 60);
            this.btn_ChargingMode.TabIndex = 109;
            this.btn_ChargingMode.UseVisualStyleBackColor = false;
            this.btn_ChargingMode.Click += new System.EventHandler(this.btn_ChargingMode_Click);
            this.btn_ChargingMode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_ChargingMode_MouseDown);
            this.btn_ChargingMode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_ChargingMode_MouseUp);
            // 
            // lb_Charging_Stop_SOC
            // 
            this.lb_Charging_Stop_SOC.BackColor = System.Drawing.Color.Transparent;
            this.lb_Charging_Stop_SOC.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Charging_Stop_SOC.Location = new System.Drawing.Point(979, 513);
            this.lb_Charging_Stop_SOC.Name = "lb_Charging_Stop_SOC";
            this.lb_Charging_Stop_SOC.Size = new System.Drawing.Size(132, 28);
            this.lb_Charging_Stop_SOC.TabIndex = 114;
            this.lb_Charging_Stop_SOC.Text = "12.34";
            this.lb_Charging_Stop_SOC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_Discharging_Stop_SOC
            // 
            this.lb_Discharging_Stop_SOC.BackColor = System.Drawing.Color.Transparent;
            this.lb_Discharging_Stop_SOC.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Discharging_Stop_SOC.Location = new System.Drawing.Point(1476, 198);
            this.lb_Discharging_Stop_SOC.Name = "lb_Discharging_Stop_SOC";
            this.lb_Discharging_Stop_SOC.Size = new System.Drawing.Size(132, 28);
            this.lb_Discharging_Stop_SOC.TabIndex = 115;
            this.lb_Discharging_Stop_SOC.Text = "12.34";
            this.lb_Discharging_Stop_SOC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Discharging_Stop_SOC
            // 
            this.tb_Discharging_Stop_SOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tb_Discharging_Stop_SOC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Discharging_Stop_SOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Discharging_Stop_SOC.Location = new System.Drawing.Point(1549, 239);
            this.tb_Discharging_Stop_SOC.Mask = "999.9";
            this.tb_Discharging_Stop_SOC.Name = "tb_Discharging_Stop_SOC";
            this.tb_Discharging_Stop_SOC.Size = new System.Drawing.Size(59, 14);
            this.tb_Discharging_Stop_SOC.TabIndex = 119;
            this.tb_Discharging_Stop_SOC.TabStop = false;
            this.tb_Discharging_Stop_SOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Discharging_Stop_SOC.ValidatingType = typeof(int);
            this.tb_Discharging_Stop_SOC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tb_Charging_Stop_SOC_MaskInputRejected);
            this.tb_Discharging_Stop_SOC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Power_Set_KeyPress);
            this.tb_Discharging_Stop_SOC.Leave += new System.EventHandler(this.tb_Charging_Stop_SOC_Leave);
            // 
            // btn_Confirm_Discharging_Stop_SOC
            // 
            this.btn_Confirm_Discharging_Stop_SOC.BackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm_Discharging_Stop_SOC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Confirm_Discharging_Stop_SOC.FlatAppearance.BorderSize = 0;
            this.btn_Confirm_Discharging_Stop_SOC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm_Discharging_Stop_SOC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm_Discharging_Stop_SOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm_Discharging_Stop_SOC.Location = new System.Drawing.Point(1303, 298);
            this.btn_Confirm_Discharging_Stop_SOC.Name = "btn_Confirm_Discharging_Stop_SOC";
            this.btn_Confirm_Discharging_Stop_SOC.Size = new System.Drawing.Size(91, 25);
            this.btn_Confirm_Discharging_Stop_SOC.TabIndex = 122;
            this.btn_Confirm_Discharging_Stop_SOC.UseVisualStyleBackColor = false;
            this.btn_Confirm_Discharging_Stop_SOC.Click += new System.EventHandler(this.btn_Confirm_Discharging_Stop_SOC_Click);
            this.btn_Confirm_Discharging_Stop_SOC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Confirm_Power_Set_MouseDown);
            this.btn_Confirm_Discharging_Stop_SOC.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Confirm_Power_Set_MouseUp);
            // 
            // cover_control
            // 
            this.cover_control.BackColor = System.Drawing.Color.Transparent;
            this.cover_control.Image = global::KTE_PMS.Properties.Resources.스케줄링상태_커버;
            this.cover_control.Location = new System.Drawing.Point(51, 274);
            this.cover_control.Name = "cover_control";
            this.cover_control.Size = new System.Drawing.Size(568, 166);
            this.cover_control.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cover_control.TabIndex = 124;
            this.cover_control.TabStop = false;
            this.cover_control.Visible = false;
            // 
            // cover_scheduling
            // 
            this.cover_scheduling.BackColor = System.Drawing.Color.Transparent;
            this.cover_scheduling.Image = global::KTE_PMS.Properties.Resources.스케줄링상태_커버;
            this.cover_scheduling.Location = new System.Drawing.Point(51, 503);
            this.cover_scheduling.Name = "cover_scheduling";
            this.cover_scheduling.Size = new System.Drawing.Size(568, 254);
            this.cover_scheduling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cover_scheduling.TabIndex = 123;
            this.cover_scheduling.TabStop = false;
            this.cover_scheduling.Visible = false;
            // 
            // btn_BMS_RESET
            // 
            this.btn_BMS_RESET.BackColor = System.Drawing.Color.Transparent;
            this.btn_BMS_RESET.BackgroundImage = global::KTE_PMS.Properties.Resources.적용_off;
            this.btn_BMS_RESET.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BMS_RESET.FlatAppearance.BorderSize = 0;
            this.btn_BMS_RESET.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_BMS_RESET.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_BMS_RESET.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_BMS_RESET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BMS_RESET.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_BMS_RESET.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_BMS_RESET.Location = new System.Drawing.Point(1422, 512);
            this.btn_BMS_RESET.Name = "btn_BMS_RESET";
            this.btn_BMS_RESET.Size = new System.Drawing.Size(186, 46);
            this.btn_BMS_RESET.TabIndex = 125;
            this.btn_BMS_RESET.UseVisualStyleBackColor = false;
            this.btn_BMS_RESET.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_BMS_RESET_MouseClick);
            this.btn_BMS_RESET.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_BMS_RESET_MouseDown);
            this.btn_BMS_RESET.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_BMS_RESET_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::KTE_PMS.Properties.Resources.변경_off;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(942, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 46);
            this.button1.TabIndex = 126;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_Confirm_Power_Set_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Confirm_Power_Set_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Confirm_Power_Set_MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(1422, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 46);
            this.button2.TabIndex = 127;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_Confirm_Discharging_Stop_SOC_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Confirm_Power_Set_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Confirm_Power_Set_MouseUp);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(942, 588);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 46);
            this.button3.TabIndex = 128;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btn_Confirm_Charging_Stop_SOC_Click);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Confirm_Power_Set_MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Confirm_Power_Set_MouseUp);
            // 
            // esS_Scheduler1
            // 
            this.esS_Scheduler1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("esS_Scheduler1.BackgroundImage")));
            this.esS_Scheduler1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.esS_Scheduler1.Location = new System.Drawing.Point(61, 512);
            this.esS_Scheduler1.Name = "esS_Scheduler1";
            this.esS_Scheduler1.Size = new System.Drawing.Size(538, 234);
            this.esS_Scheduler1.TabIndex = 129;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label14.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(215, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(230, 28);
            this.label14.TabIndex = 131;
            this.label14.Text = "PCS 제어권한";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label13.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(215, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 28);
            this.label13.TabIndex = 130;
            this.label13.Text = "모드설정";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(917, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 28);
            this.label1.TabIndex = 132;
            this.label1.Text = "유효 전력 제어";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(917, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 28);
            this.label2.TabIndex = 133;
            this.label2.Text = "충전 제한 SOC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(1397, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 28);
            this.label3.TabIndex = 134;
            this.label3.Text = "방전 제한 SOC";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(1397, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 28);
            this.label4.TabIndex = 135;
            this.label4.Text = "BMS 초기화";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label5.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(877, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 28);
            this.label5.TabIndex = 136;
            this.label5.Text = "현재 전력";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label6.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(1339, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 28);
            this.label6.TabIndex = 137;
            this.label6.Text = "현재 값";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label7.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(877, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 28);
            this.label7.TabIndex = 138;
            this.label7.Text = "현재 값";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label8.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(1135, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 28);
            this.label8.TabIndex = 139;
            this.label8.Text = "kW";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label9.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(1135, 510);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 28);
            this.label9.TabIndex = 140;
            this.label9.Text = "%";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label10.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(1614, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 28);
            this.label10.TabIndex = 141;
            this.label10.Text = "%";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ControlViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cover_scheduling);
            this.Controls.Add(this.esS_Scheduler1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_BMS_RESET);
            this.Controls.Add(this.cover_control);
            this.Controls.Add(this.btn_Confirm_Discharging_Stop_SOC);
            this.Controls.Add(this.tb_Discharging_Stop_SOC);
            this.Controls.Add(this.lb_Discharging_Stop_SOC);
            this.Controls.Add(this.lb_Charging_Stop_SOC);
            this.Controls.Add(this.btn_CustomMode);
            this.Controls.Add(this.btn_PeakCutMode);
            this.Controls.Add(this.btn_DisChargingMode);
            this.Controls.Add(this.btn_ChargingMode);
            this.Controls.Add(this.btn_LEMS);
            this.Controls.Add(this.btn_uPMS);
            this.Controls.Add(this.tb_Power_Set);
            this.Controls.Add(this.lb_Power_Set);
            this.Controls.Add(this.label13);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlViewer";
            this.Size = new System.Drawing.Size(1920, 796);
            this.Load += new System.EventHandler(this.ControlViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cover_control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cover_scheduling)).EndInit();
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
        private System.Windows.Forms.Label lb_Power_Set;
        private System.Windows.Forms.MaskedTextBox tb_Power_Set;
        private System.Windows.Forms.Button btn_LEMS;
        private System.Windows.Forms.Button btn_uPMS;
        private System.Windows.Forms.Button btn_CustomMode;
        private System.Windows.Forms.Button btn_PeakCutMode;
        private System.Windows.Forms.Button btn_DisChargingMode;
        private System.Windows.Forms.Button btn_ChargingMode;
        private System.Windows.Forms.Label lb_Charging_Stop_SOC;
        private System.Windows.Forms.Label lb_Discharging_Stop_SOC;
        private System.Windows.Forms.MaskedTextBox tb_Discharging_Stop_SOC;
        private System.Windows.Forms.Button btn_Confirm_Discharging_Stop_SOC;

        private System.Windows.Forms.PictureBox cover_control;
        private System.Windows.Forms.PictureBox cover_scheduling;
        private System.Windows.Forms.Button btn_BMS_RESET;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private ESS_Scheduler esS_Scheduler1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
