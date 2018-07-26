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
            this.lb_Power_Set = new System.Windows.Forms.Label();
            this.tb_Power_Set = new System.Windows.Forms.MaskedTextBox();
            this.btn_LEMS = new System.Windows.Forms.Button();
            this.btn_uPMS = new System.Windows.Forms.Button();
            this.btn_CustomMode = new System.Windows.Forms.Button();
            this.btn_PeakCutMode = new System.Windows.Forms.Button();
            this.btn_DisChargingMode = new System.Windows.Forms.Button();
            this.btn_ChargingMode = new System.Windows.Forms.Button();
            this.esS_Scheduler1 = new KTE_PMS.ESS_Scheduler();
            this.lb_Charging_Stop_SOC = new System.Windows.Forms.Label();
            this.lb_Discharging_Stop_SOC = new System.Windows.Forms.Label();
            this.tb_Charging_Stop_SOC = new System.Windows.Forms.MaskedTextBox();
            this.tb_Discharging_Stop_SOC = new System.Windows.Forms.MaskedTextBox();
            this.btn_Confirm_Power_Set = new System.Windows.Forms.Button();
            this.btn_Confirm_Charging_Stop_SOC = new System.Windows.Forms.Button();
            this.btn_Confirm_Discharging_Stop_SOC = new System.Windows.Forms.Button();
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
            this.lb_Power_Set.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Power_Set.Location = new System.Drawing.Point(521, 64);
            this.lb_Power_Set.Name = "lb_Power_Set";
            this.lb_Power_Set.Size = new System.Drawing.Size(66, 22);
            this.lb_Power_Set.TabIndex = 91;
            this.lb_Power_Set.Text = "12.34";
            this.lb_Power_Set.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Power_Set
            // 
            this.tb_Power_Set.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tb_Power_Set.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Power_Set.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Power_Set.Location = new System.Drawing.Point(680, 61);
            this.tb_Power_Set.Mask = "99.9";
            this.tb_Power_Set.Name = "tb_Power_Set";
            this.tb_Power_Set.Size = new System.Drawing.Size(59, 22);
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
            this.btn_LEMS.Location = new System.Drawing.Point(181, 69);
            this.btn_LEMS.Name = "btn_LEMS";
            this.btn_LEMS.Size = new System.Drawing.Size(91, 26);
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
            this.btn_uPMS.Location = new System.Drawing.Point(51, 68);
            this.btn_uPMS.Name = "btn_uPMS";
            this.btn_uPMS.Size = new System.Drawing.Size(91, 26);
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
            this.btn_CustomMode.Location = new System.Drawing.Point(233, 195);
            this.btn_CustomMode.Name = "btn_CustomMode";
            this.btn_CustomMode.Size = new System.Drawing.Size(54, 30);
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
            this.btn_PeakCutMode.Location = new System.Drawing.Point(38, 195);
            this.btn_PeakCutMode.Name = "btn_PeakCutMode";
            this.btn_PeakCutMode.Size = new System.Drawing.Size(54, 30);
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
            this.btn_DisChargingMode.Location = new System.Drawing.Point(168, 195);
            this.btn_DisChargingMode.Name = "btn_DisChargingMode";
            this.btn_DisChargingMode.Size = new System.Drawing.Size(54, 30);
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
            this.btn_ChargingMode.Location = new System.Drawing.Point(103, 195);
            this.btn_ChargingMode.Name = "btn_ChargingMode";
            this.btn_ChargingMode.Size = new System.Drawing.Size(54, 30);
            this.btn_ChargingMode.TabIndex = 109;
            this.btn_ChargingMode.UseVisualStyleBackColor = false;
            this.btn_ChargingMode.Click += new System.EventHandler(this.btn_ChargingMode_Click);
            this.btn_ChargingMode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_ChargingMode_MouseDown);
            this.btn_ChargingMode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_ChargingMode_MouseUp);
            // 
            // esS_Scheduler1
            // 
            this.esS_Scheduler1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("esS_Scheduler1.BackgroundImage")));
            this.esS_Scheduler1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.esS_Scheduler1.Location = new System.Drawing.Point(31, 274);
            this.esS_Scheduler1.Name = "esS_Scheduler1";
            this.esS_Scheduler1.Size = new System.Drawing.Size(269, 117);
            this.esS_Scheduler1.TabIndex = 113;
            this.esS_Scheduler1.Click += new System.EventHandler(this.esS_Scheduler1_Click);
            // 
            // lb_Charging_Stop_SOC
            // 
            this.lb_Charging_Stop_SOC.BackColor = System.Drawing.Color.Transparent;
            this.lb_Charging_Stop_SOC.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Charging_Stop_SOC.Location = new System.Drawing.Point(521, 206);
            this.lb_Charging_Stop_SOC.Name = "lb_Charging_Stop_SOC";
            this.lb_Charging_Stop_SOC.Size = new System.Drawing.Size(66, 22);
            this.lb_Charging_Stop_SOC.TabIndex = 114;
            this.lb_Charging_Stop_SOC.Text = "12.34";
            this.lb_Charging_Stop_SOC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_Discharging_Stop_SOC
            // 
            this.lb_Discharging_Stop_SOC.BackColor = System.Drawing.Color.Transparent;
            this.lb_Discharging_Stop_SOC.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Discharging_Stop_SOC.Location = new System.Drawing.Point(521, 335);
            this.lb_Discharging_Stop_SOC.Name = "lb_Discharging_Stop_SOC";
            this.lb_Discharging_Stop_SOC.Size = new System.Drawing.Size(66, 22);
            this.lb_Discharging_Stop_SOC.TabIndex = 115;
            this.lb_Discharging_Stop_SOC.Text = "12.34";
            this.lb_Discharging_Stop_SOC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Charging_Stop_SOC
            // 
            this.tb_Charging_Stop_SOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tb_Charging_Stop_SOC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Charging_Stop_SOC.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Charging_Stop_SOC.Location = new System.Drawing.Point(680, 207);
            this.tb_Charging_Stop_SOC.Mask = "999.9";
            this.tb_Charging_Stop_SOC.Name = "tb_Charging_Stop_SOC";
            this.tb_Charging_Stop_SOC.Size = new System.Drawing.Size(59, 19);
            this.tb_Charging_Stop_SOC.TabIndex = 118;
            this.tb_Charging_Stop_SOC.TabStop = false;
            this.tb_Charging_Stop_SOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Charging_Stop_SOC.ValidatingType = typeof(int);
            this.tb_Charging_Stop_SOC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tb_Charging_Stop_SOC_MaskInputRejected);
            this.tb_Charging_Stop_SOC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Power_Set_KeyPress);
            this.tb_Charging_Stop_SOC.Leave += new System.EventHandler(this.tb_Charging_Stop_SOC_Leave);
            // 
            // tb_Discharging_Stop_SOC
            // 
            this.tb_Discharging_Stop_SOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tb_Discharging_Stop_SOC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Discharging_Stop_SOC.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Discharging_Stop_SOC.Location = new System.Drawing.Point(680, 335);
            this.tb_Discharging_Stop_SOC.Mask = "999.9";
            this.tb_Discharging_Stop_SOC.Name = "tb_Discharging_Stop_SOC";
            this.tb_Discharging_Stop_SOC.Size = new System.Drawing.Size(59, 19);
            this.tb_Discharging_Stop_SOC.TabIndex = 119;
            this.tb_Discharging_Stop_SOC.TabStop = false;
            this.tb_Discharging_Stop_SOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Discharging_Stop_SOC.ValidatingType = typeof(int);
            this.tb_Discharging_Stop_SOC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tb_Charging_Stop_SOC_MaskInputRejected);
            this.tb_Discharging_Stop_SOC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Power_Set_KeyPress);
            this.tb_Discharging_Stop_SOC.Leave += new System.EventHandler(this.tb_Charging_Stop_SOC_Leave);
            // 
            // btn_Confirm_Power_Set
            // 
            this.btn_Confirm_Power_Set.BackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm_Power_Set.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Confirm_Power_Set.FlatAppearance.BorderSize = 0;
            this.btn_Confirm_Power_Set.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm_Power_Set.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm_Power_Set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm_Power_Set.Location = new System.Drawing.Point(573, 96);
            this.btn_Confirm_Power_Set.Name = "btn_Confirm_Power_Set";
            this.btn_Confirm_Power_Set.Size = new System.Drawing.Size(91, 25);
            this.btn_Confirm_Power_Set.TabIndex = 120;
            this.btn_Confirm_Power_Set.UseVisualStyleBackColor = false;
            this.btn_Confirm_Power_Set.Click += new System.EventHandler(this.btn_Confirm_Power_Set_Click);
            this.btn_Confirm_Power_Set.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Confirm_Power_Set_MouseDown);
            this.btn_Confirm_Power_Set.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Confirm_Power_Set_MouseUp);
            // 
            // btn_Confirm_Charging_Stop_SOC
            // 
            this.btn_Confirm_Charging_Stop_SOC.BackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm_Charging_Stop_SOC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Confirm_Charging_Stop_SOC.FlatAppearance.BorderSize = 0;
            this.btn_Confirm_Charging_Stop_SOC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm_Charging_Stop_SOC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm_Charging_Stop_SOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm_Charging_Stop_SOC.Location = new System.Drawing.Point(573, 239);
            this.btn_Confirm_Charging_Stop_SOC.Name = "btn_Confirm_Charging_Stop_SOC";
            this.btn_Confirm_Charging_Stop_SOC.Size = new System.Drawing.Size(91, 25);
            this.btn_Confirm_Charging_Stop_SOC.TabIndex = 121;
            this.btn_Confirm_Charging_Stop_SOC.UseVisualStyleBackColor = false;
            this.btn_Confirm_Charging_Stop_SOC.Click += new System.EventHandler(this.btn_Confirm_Charging_Stop_SOC_Click);
            this.btn_Confirm_Charging_Stop_SOC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Confirm_Power_Set_MouseDown);
            this.btn_Confirm_Charging_Stop_SOC.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Confirm_Power_Set_MouseUp);
            // 
            // btn_Confirm_Discharging_Stop_SOC
            // 
            this.btn_Confirm_Discharging_Stop_SOC.BackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm_Discharging_Stop_SOC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Confirm_Discharging_Stop_SOC.FlatAppearance.BorderSize = 0;
            this.btn_Confirm_Discharging_Stop_SOC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm_Discharging_Stop_SOC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm_Discharging_Stop_SOC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm_Discharging_Stop_SOC.Location = new System.Drawing.Point(573, 367);
            this.btn_Confirm_Discharging_Stop_SOC.Name = "btn_Confirm_Discharging_Stop_SOC";
            this.btn_Confirm_Discharging_Stop_SOC.Size = new System.Drawing.Size(91, 25);
            this.btn_Confirm_Discharging_Stop_SOC.TabIndex = 122;
            this.btn_Confirm_Discharging_Stop_SOC.UseVisualStyleBackColor = false;
            this.btn_Confirm_Discharging_Stop_SOC.Click += new System.EventHandler(this.btn_Confirm_Discharging_Stop_SOC_Click);
            this.btn_Confirm_Discharging_Stop_SOC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Confirm_Power_Set_MouseDown);
            this.btn_Confirm_Discharging_Stop_SOC.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Confirm_Power_Set_MouseUp);
            // 
            // ControlViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.BackgroundImage = global::KTE_PMS.Properties.Resources.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_Confirm_Discharging_Stop_SOC);
            this.Controls.Add(this.btn_Confirm_Charging_Stop_SOC);
            this.Controls.Add(this.btn_Confirm_Power_Set);
            this.Controls.Add(this.tb_Discharging_Stop_SOC);
            this.Controls.Add(this.tb_Charging_Stop_SOC);
            this.Controls.Add(this.lb_Discharging_Stop_SOC);
            this.Controls.Add(this.lb_Charging_Stop_SOC);
            this.Controls.Add(this.esS_Scheduler1);
            this.Controls.Add(this.btn_CustomMode);
            this.Controls.Add(this.btn_PeakCutMode);
            this.Controls.Add(this.btn_DisChargingMode);
            this.Controls.Add(this.btn_ChargingMode);
            this.Controls.Add(this.btn_LEMS);
            this.Controls.Add(this.btn_uPMS);
            this.Controls.Add(this.tb_Power_Set);
            this.Controls.Add(this.lb_Power_Set);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlViewer";
            this.Load += new System.EventHandler(this.ControlViewer_Load);
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
        private System.Windows.Forms.MaskedTextBox tb_Charging_Stop_SOC;
        private System.Windows.Forms.MaskedTextBox tb_Discharging_Stop_SOC;
        private System.Windows.Forms.Button btn_Confirm_Power_Set;
        private System.Windows.Forms.Button btn_Confirm_Charging_Stop_SOC;
        private System.Windows.Forms.Button btn_Confirm_Discharging_Stop_SOC;
        public ESS_Scheduler esS_Scheduler1;
    }
}
