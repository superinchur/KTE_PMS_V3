namespace KTE_PMS.MIMIC
{
    partial class Setting_PageViewer
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting_PageViewer));
            this.btn_Access_To_Operating_System = new System.Windows.Forms.Button();
            this.btn_Password_Change = new System.Windows.Forms.Button();
            this.btn_Export_Data = new System.Windows.Forms.Button();
            this.btn_Import_Data = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Discharging_Period_Start = new System.Windows.Forms.MaskedTextBox();
            this.tb_Discharging_Period_End = new System.Windows.Forms.MaskedTextBox();
            this.tb_Charging_Period_Start = new System.Windows.Forms.MaskedTextBox();
            this.tb_Charging_Period_End = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_Charging_Stop_SOC = new System.Windows.Forms.MaskedTextBox();
            this.tb_Discharging_Stop_SOC = new System.Windows.Forms.MaskedTextBox();
            this.tb_Charging_Limit_Voltage = new System.Windows.Forms.MaskedTextBox();
            this.tb_Discharging_Limit_Voltage = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Access_To_Operating_System
            // 
            this.btn_Access_To_Operating_System.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Access_To_Operating_System.BackgroundImage")));
            this.btn_Access_To_Operating_System.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Access_To_Operating_System.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Access_To_Operating_System.Location = new System.Drawing.Point(747, 298);
            this.btn_Access_To_Operating_System.Name = "btn_Access_To_Operating_System";
            this.btn_Access_To_Operating_System.Size = new System.Drawing.Size(90, 40);
            this.btn_Access_To_Operating_System.TabIndex = 6;
            this.btn_Access_To_Operating_System.UseVisualStyleBackColor = true;
            this.btn_Access_To_Operating_System.Click += new System.EventHandler(this.btn_Access_To_Operating_System_Click);
            // 
            // btn_Password_Change
            // 
            this.btn_Password_Change.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Password_Change.BackgroundImage")));
            this.btn_Password_Change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Password_Change.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Password_Change.Location = new System.Drawing.Point(747, 238);
            this.btn_Password_Change.Name = "btn_Password_Change";
            this.btn_Password_Change.Size = new System.Drawing.Size(90, 40);
            this.btn_Password_Change.TabIndex = 8;
            this.btn_Password_Change.UseVisualStyleBackColor = true;
            this.btn_Password_Change.Click += new System.EventHandler(this.btn_Password_Change_Click);
            // 
            // btn_Export_Data
            // 
            this.btn_Export_Data.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Export_Data.BackgroundImage")));
            this.btn_Export_Data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Export_Data.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Export_Data.Location = new System.Drawing.Point(747, 182);
            this.btn_Export_Data.Name = "btn_Export_Data";
            this.btn_Export_Data.Size = new System.Drawing.Size(90, 40);
            this.btn_Export_Data.TabIndex = 9;
            this.btn_Export_Data.UseVisualStyleBackColor = true;
            this.btn_Export_Data.Click += new System.EventHandler(this.btn_Export_Data_Click);
            // 
            // btn_Import_Data
            // 
            this.btn_Import_Data.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Import_Data.BackgroundImage")));
            this.btn_Import_Data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Import_Data.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Import_Data.Location = new System.Drawing.Point(747, 125);
            this.btn_Import_Data.Name = "btn_Import_Data";
            this.btn_Import_Data.Size = new System.Drawing.Size(90, 40);
            this.btn_Import_Data.TabIndex = 10;
            this.btn_Import_Data.UseVisualStyleBackColor = true;
            this.btn_Import_Data.Click += new System.EventHandler(this.btn_Import_Data_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(97, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "충전 정지 SOC 값";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(97, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "방전 정지 SOC 값";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(97, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "충전 전압 제한 값";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(97, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "방전 전압 제한 값";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(97, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "방전 시작 설정";
            // 
            // tb_Discharging_Period_Start
            // 
            this.tb_Discharging_Period_Start.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Discharging_Period_Start.Location = new System.Drawing.Point(213, 267);
            this.tb_Discharging_Period_Start.Mask = "90시90분";
            this.tb_Discharging_Period_Start.Name = "tb_Discharging_Period_Start";
            this.tb_Discharging_Period_Start.Size = new System.Drawing.Size(87, 26);
            this.tb_Discharging_Period_Start.TabIndex = 29;
            this.tb_Discharging_Period_Start.TabStop = false;
            this.tb_Discharging_Period_Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Discharging_Period_Start.ValidatingType = typeof(System.DateTime);
            this.tb_Discharging_Period_Start.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.SOC_TextBox_MaskInputRejected);
            // 
            // tb_Discharging_Period_End
            // 
            this.tb_Discharging_Period_End.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Discharging_Period_End.Location = new System.Drawing.Point(315, 267);
            this.tb_Discharging_Period_End.Mask = "90시90분";
            this.tb_Discharging_Period_End.Name = "tb_Discharging_Period_End";
            this.tb_Discharging_Period_End.Size = new System.Drawing.Size(87, 26);
            this.tb_Discharging_Period_End.TabIndex = 31;
            this.tb_Discharging_Period_End.TabStop = false;
            this.tb_Discharging_Period_End.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Discharging_Period_End.ValidatingType = typeof(System.DateTime);
            this.tb_Discharging_Period_End.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.SOC_TextBox_MaskInputRejected);
            // 
            // tb_Charging_Period_Start
            // 
            this.tb_Charging_Period_Start.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Charging_Period_Start.Location = new System.Drawing.Point(213, 298);
            this.tb_Charging_Period_Start.Mask = "90시90분";
            this.tb_Charging_Period_Start.Name = "tb_Charging_Period_Start";
            this.tb_Charging_Period_Start.Size = new System.Drawing.Size(87, 26);
            this.tb_Charging_Period_Start.TabIndex = 32;
            this.tb_Charging_Period_Start.TabStop = false;
            this.tb_Charging_Period_Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Charging_Period_Start.ValidatingType = typeof(System.DateTime);
            this.tb_Charging_Period_Start.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.SOC_TextBox_MaskInputRejected);
            // 
            // tb_Charging_Period_End
            // 
            this.tb_Charging_Period_End.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Charging_Period_End.Location = new System.Drawing.Point(315, 298);
            this.tb_Charging_Period_End.Mask = "90시90분";
            this.tb_Charging_Period_End.Name = "tb_Charging_Period_End";
            this.tb_Charging_Period_End.Size = new System.Drawing.Size(87, 26);
            this.tb_Charging_Period_End.TabIndex = 33;
            this.tb_Charging_Period_End.TabStop = false;
            this.tb_Charging_Period_End.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Charging_Period_End.ValidatingType = typeof(System.DateTime);
            this.tb_Charging_Period_End.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.SOC_TextBox_MaskInputRejected);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(97, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 19);
            this.label11.TabIndex = 34;
            this.label11.Text = "충전 시간 설정";
            // 
            // tb_Charging_Stop_SOC
            // 
            this.tb_Charging_Stop_SOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tb_Charging_Stop_SOC.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Charging_Stop_SOC.Location = new System.Drawing.Point(319, 142);
            this.tb_Charging_Stop_SOC.Mask = "999.9";
            this.tb_Charging_Stop_SOC.Name = "tb_Charging_Stop_SOC";
            this.tb_Charging_Stop_SOC.Size = new System.Drawing.Size(59, 26);
            this.tb_Charging_Stop_SOC.TabIndex = 102;
            this.tb_Charging_Stop_SOC.TabStop = false;
            this.tb_Charging_Stop_SOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Charging_Stop_SOC.ValidatingType = typeof(int);
            this.tb_Charging_Stop_SOC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.SOC_TextBox_MaskInputRejected);
            this.tb_Charging_Stop_SOC.Leave += new System.EventHandler(this.tb_Charging_Stop_SOC_Leave);
            // 
            // tb_Discharging_Stop_SOC
            // 
            this.tb_Discharging_Stop_SOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tb_Discharging_Stop_SOC.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Discharging_Stop_SOC.Location = new System.Drawing.Point(319, 174);
            this.tb_Discharging_Stop_SOC.Mask = "999.9";
            this.tb_Discharging_Stop_SOC.Name = "tb_Discharging_Stop_SOC";
            this.tb_Discharging_Stop_SOC.Size = new System.Drawing.Size(59, 26);
            this.tb_Discharging_Stop_SOC.TabIndex = 103;
            this.tb_Discharging_Stop_SOC.TabStop = false;
            this.tb_Discharging_Stop_SOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Discharging_Stop_SOC.ValidatingType = typeof(int);
            this.tb_Discharging_Stop_SOC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.SOC_TextBox_MaskInputRejected);
            this.tb_Discharging_Stop_SOC.Leave += new System.EventHandler(this.SOC_TextBox_TextChanged);
            // 
            // tb_Charging_Limit_Voltage
            // 
            this.tb_Charging_Limit_Voltage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tb_Charging_Limit_Voltage.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Charging_Limit_Voltage.Location = new System.Drawing.Point(319, 206);
            this.tb_Charging_Limit_Voltage.Mask = "999.9";
            this.tb_Charging_Limit_Voltage.Name = "tb_Charging_Limit_Voltage";
            this.tb_Charging_Limit_Voltage.Size = new System.Drawing.Size(59, 26);
            this.tb_Charging_Limit_Voltage.TabIndex = 104;
            this.tb_Charging_Limit_Voltage.TabStop = false;
            this.tb_Charging_Limit_Voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Charging_Limit_Voltage.ValidatingType = typeof(int);
            this.tb_Charging_Limit_Voltage.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.SOC_TextBox_MaskInputRejected);
            this.tb_Charging_Limit_Voltage.Leave += new System.EventHandler(this.Voltage_TextBox_TextChanged);
            // 
            // tb_Discharging_Limit_Voltage
            // 
            this.tb_Discharging_Limit_Voltage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tb_Discharging_Limit_Voltage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Discharging_Limit_Voltage.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Discharging_Limit_Voltage.Location = new System.Drawing.Point(319, 239);
            this.tb_Discharging_Limit_Voltage.Mask = "999.9";
            this.tb_Discharging_Limit_Voltage.Name = "tb_Discharging_Limit_Voltage";
            this.tb_Discharging_Limit_Voltage.Size = new System.Drawing.Size(59, 19);
            this.tb_Discharging_Limit_Voltage.TabIndex = 105;
            this.tb_Discharging_Limit_Voltage.TabStop = false;
            this.tb_Discharging_Limit_Voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Discharging_Limit_Voltage.ValidatingType = typeof(int);
            this.tb_Discharging_Limit_Voltage.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.SOC_TextBox_MaskInputRejected);
            this.tb_Discharging_Limit_Voltage.Leave += new System.EventHandler(this.Voltage_TextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(375, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 19);
            this.label6.TabIndex = 109;
            this.label6.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(375, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 19);
            this.label10.TabIndex = 110;
            this.label10.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(376, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 19);
            this.label12.TabIndex = 111;
            this.label12.Text = "V";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(376, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 19);
            this.label13.TabIndex = 112;
            this.label13.Text = "V";
            // 
            // btn_Apply
            // 
            this.btn_Apply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Apply.BackgroundImage")));
            this.btn_Apply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Apply.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Apply.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Apply.Location = new System.Drawing.Point(312, 341);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(90, 40);
            this.btn_Apply.TabIndex = 113;
            this.btn_Apply.Text = "적용";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // Setting_PageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Discharging_Limit_Voltage);
            this.Controls.Add(this.tb_Charging_Limit_Voltage);
            this.Controls.Add(this.tb_Discharging_Stop_SOC);
            this.Controls.Add(this.tb_Charging_Stop_SOC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_Charging_Period_End);
            this.Controls.Add(this.tb_Charging_Period_Start);
            this.Controls.Add(this.tb_Discharging_Period_End);
            this.Controls.Add(this.tb_Discharging_Period_Start);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Import_Data);
            this.Controls.Add(this.btn_Export_Data);
            this.Controls.Add(this.btn_Password_Change);
            this.Controls.Add(this.btn_Access_To_Operating_System);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Setting_PageViewer";
            this.Load += new System.EventHandler(this.Setting_PageViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Access_To_Operating_System;
        private System.Windows.Forms.Button btn_Password_Change;
        private System.Windows.Forms.Button btn_Export_Data;
        private System.Windows.Forms.Button btn_Import_Data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox tb_Discharging_Period_Start;
        private System.Windows.Forms.MaskedTextBox tb_Discharging_Period_End;
        private System.Windows.Forms.MaskedTextBox tb_Charging_Period_Start;
        private System.Windows.Forms.MaskedTextBox tb_Charging_Period_End;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox tb_Charging_Stop_SOC;
        private System.Windows.Forms.MaskedTextBox tb_Discharging_Stop_SOC;
        private System.Windows.Forms.MaskedTextBox tb_Charging_Limit_Voltage;
        private System.Windows.Forms.MaskedTextBox tb_Discharging_Limit_Voltage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_Apply;
    }
}
