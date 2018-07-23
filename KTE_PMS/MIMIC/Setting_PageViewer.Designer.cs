﻿namespace KTE_PMS.MIMIC
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
            this.tb_Charging_Stop_SOC = new System.Windows.Forms.MaskedTextBox();
            this.tb_Discharging_Stop_SOC = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_DateTime_Setup = new System.Windows.Forms.Button();
            this.btn_Language_Setup = new System.Windows.Forms.Button();
            this.btn_Comm_Setup = new System.Windows.Forms.Button();
            this.btn_Power_Setup = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_Power_Prices = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_Active_Power_Maximum = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Access_To_Operating_System
            // 
            this.btn_Access_To_Operating_System.BackColor = System.Drawing.Color.Transparent;
            this.btn_Access_To_Operating_System.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Access_To_Operating_System.BackgroundImage")));
            this.btn_Access_To_Operating_System.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Access_To_Operating_System.FlatAppearance.BorderSize = 0;
            this.btn_Access_To_Operating_System.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Access_To_Operating_System.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Access_To_Operating_System.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Access_To_Operating_System.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Access_To_Operating_System.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Access_To_Operating_System.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Access_To_Operating_System.Location = new System.Drawing.Point(285, 350);
            this.btn_Access_To_Operating_System.Name = "btn_Access_To_Operating_System";
            this.btn_Access_To_Operating_System.Size = new System.Drawing.Size(93, 23);
            this.btn_Access_To_Operating_System.TabIndex = 6;
            this.btn_Access_To_Operating_System.UseVisualStyleBackColor = false;
            this.btn_Access_To_Operating_System.Click += new System.EventHandler(this.btn_Access_To_Operating_System_Click);
            this.btn_Access_To_Operating_System.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseDown);
            this.btn_Access_To_Operating_System.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseUp);
            // 
            // btn_Password_Change
            // 
            this.btn_Password_Change.BackColor = System.Drawing.Color.Transparent;
            this.btn_Password_Change.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Password_Change.BackgroundImage")));
            this.btn_Password_Change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Password_Change.FlatAppearance.BorderSize = 0;
            this.btn_Password_Change.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Password_Change.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Password_Change.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Password_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Password_Change.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Password_Change.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Password_Change.Location = new System.Drawing.Point(582, 350);
            this.btn_Password_Change.Name = "btn_Password_Change";
            this.btn_Password_Change.Size = new System.Drawing.Size(93, 23);
            this.btn_Password_Change.TabIndex = 8;
            this.btn_Password_Change.UseVisualStyleBackColor = false;
            this.btn_Password_Change.Click += new System.EventHandler(this.btn_Password_Change_Click);
            this.btn_Password_Change.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseDown);
            this.btn_Password_Change.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseUp);
            // 
            // btn_Export_Data
            // 
            this.btn_Export_Data.BackColor = System.Drawing.Color.Transparent;
            this.btn_Export_Data.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Export_Data.BackgroundImage")));
            this.btn_Export_Data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Export_Data.FlatAppearance.BorderSize = 0;
            this.btn_Export_Data.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Export_Data.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Export_Data.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Export_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export_Data.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Export_Data.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Export_Data.Location = new System.Drawing.Point(747, 198);
            this.btn_Export_Data.Name = "btn_Export_Data";
            this.btn_Export_Data.Size = new System.Drawing.Size(93, 23);
            this.btn_Export_Data.TabIndex = 9;
            this.btn_Export_Data.UseVisualStyleBackColor = false;
            this.btn_Export_Data.Click += new System.EventHandler(this.btn_Export_Data_Click);
            this.btn_Export_Data.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseDown);
            this.btn_Export_Data.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseUp);
            // 
            // btn_Import_Data
            // 
            this.btn_Import_Data.BackColor = System.Drawing.Color.Transparent;
            this.btn_Import_Data.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Import_Data.BackgroundImage")));
            this.btn_Import_Data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Import_Data.FlatAppearance.BorderSize = 0;
            this.btn_Import_Data.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Import_Data.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Import_Data.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Import_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Import_Data.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Import_Data.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Import_Data.Location = new System.Drawing.Point(747, 141);
            this.btn_Import_Data.Name = "btn_Import_Data";
            this.btn_Import_Data.Size = new System.Drawing.Size(93, 23);
            this.btn_Import_Data.TabIndex = 10;
            this.btn_Import_Data.UseVisualStyleBackColor = false;
            this.btn_Import_Data.Click += new System.EventHandler(this.btn_Import_Data_Click);
            this.btn_Import_Data.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseDown);
            this.btn_Import_Data.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "충전 정지 SOC 값";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "방전 정지 SOC 값";
            this.label2.Visible = false;
            // 
            // tb_Charging_Stop_SOC
            // 
            this.tb_Charging_Stop_SOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tb_Charging_Stop_SOC.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Charging_Stop_SOC.Location = new System.Drawing.Point(177, 28);
            this.tb_Charging_Stop_SOC.Mask = "999.9";
            this.tb_Charging_Stop_SOC.Name = "tb_Charging_Stop_SOC";
            this.tb_Charging_Stop_SOC.Size = new System.Drawing.Size(59, 26);
            this.tb_Charging_Stop_SOC.TabIndex = 102;
            this.tb_Charging_Stop_SOC.TabStop = false;
            this.tb_Charging_Stop_SOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Charging_Stop_SOC.ValidatingType = typeof(int);
            this.tb_Charging_Stop_SOC.Visible = false;
            this.tb_Charging_Stop_SOC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.SOC_TextBox_MaskInputRejected);
            this.tb_Charging_Stop_SOC.Leave += new System.EventHandler(this.tb_Charging_Stop_SOC_Leave);
            // 
            // tb_Discharging_Stop_SOC
            // 
            this.tb_Discharging_Stop_SOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tb_Discharging_Stop_SOC.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Discharging_Stop_SOC.Location = new System.Drawing.Point(177, 60);
            this.tb_Discharging_Stop_SOC.Mask = "999.9";
            this.tb_Discharging_Stop_SOC.Name = "tb_Discharging_Stop_SOC";
            this.tb_Discharging_Stop_SOC.Size = new System.Drawing.Size(59, 26);
            this.tb_Discharging_Stop_SOC.TabIndex = 103;
            this.tb_Discharging_Stop_SOC.TabStop = false;
            this.tb_Discharging_Stop_SOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Discharging_Stop_SOC.ValidatingType = typeof(int);
            this.tb_Discharging_Stop_SOC.Visible = false;
            this.tb_Discharging_Stop_SOC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.SOC_TextBox_MaskInputRejected);
            this.tb_Discharging_Stop_SOC.Leave += new System.EventHandler(this.SOC_TextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(233, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 19);
            this.label6.TabIndex = 109;
            this.label6.Text = "%";
            this.label6.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(233, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 19);
            this.label10.TabIndex = 110;
            this.label10.Text = "%";
            this.label10.Visible = false;
            // 
            // btn_Apply
            // 
            this.btn_Apply.BackColor = System.Drawing.Color.Transparent;
            this.btn_Apply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Apply.BackgroundImage")));
            this.btn_Apply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Apply.FlatAppearance.BorderSize = 0;
            this.btn_Apply.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Apply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Apply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apply.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Apply.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Apply.Location = new System.Drawing.Point(21, 173);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(93, 23);
            this.btn_Apply.TabIndex = 113;
            this.btn_Apply.UseVisualStyleBackColor = false;
            this.btn_Apply.Visible = false;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseDown);
            this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseUp);
            // 
            // btn_DateTime_Setup
            // 
            this.btn_DateTime_Setup.BackColor = System.Drawing.Color.Transparent;
            this.btn_DateTime_Setup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DateTime_Setup.BackgroundImage")));
            this.btn_DateTime_Setup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DateTime_Setup.FlatAppearance.BorderSize = 0;
            this.btn_DateTime_Setup.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_DateTime_Setup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_DateTime_Setup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_DateTime_Setup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DateTime_Setup.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_DateTime_Setup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_DateTime_Setup.Location = new System.Drawing.Point(286, 224);
            this.btn_DateTime_Setup.Name = "btn_DateTime_Setup";
            this.btn_DateTime_Setup.Size = new System.Drawing.Size(93, 23);
            this.btn_DateTime_Setup.TabIndex = 114;
            this.btn_DateTime_Setup.UseVisualStyleBackColor = false;
            this.btn_DateTime_Setup.Click += new System.EventHandler(this.btn_DateTime_Setup_Click);
            this.btn_DateTime_Setup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseDown);
            this.btn_DateTime_Setup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseUp);
            // 
            // btn_Language_Setup
            // 
            this.btn_Language_Setup.BackColor = System.Drawing.Color.Transparent;
            this.btn_Language_Setup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Language_Setup.BackgroundImage")));
            this.btn_Language_Setup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Language_Setup.FlatAppearance.BorderSize = 0;
            this.btn_Language_Setup.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Language_Setup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Language_Setup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Language_Setup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Language_Setup.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Language_Setup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Language_Setup.Location = new System.Drawing.Point(286, 98);
            this.btn_Language_Setup.Name = "btn_Language_Setup";
            this.btn_Language_Setup.Size = new System.Drawing.Size(93, 23);
            this.btn_Language_Setup.TabIndex = 116;
            this.btn_Language_Setup.UseVisualStyleBackColor = false;
            this.btn_Language_Setup.Click += new System.EventHandler(this.btn_Language_Setup_Click);
            this.btn_Language_Setup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseDown);
            this.btn_Language_Setup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseUp);
            // 
            // btn_Comm_Setup
            // 
            this.btn_Comm_Setup.BackColor = System.Drawing.Color.Transparent;
            this.btn_Comm_Setup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Comm_Setup.BackgroundImage")));
            this.btn_Comm_Setup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Comm_Setup.FlatAppearance.BorderSize = 0;
            this.btn_Comm_Setup.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Comm_Setup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Comm_Setup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Comm_Setup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Comm_Setup.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Comm_Setup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Comm_Setup.Location = new System.Drawing.Point(582, 98);
            this.btn_Comm_Setup.Name = "btn_Comm_Setup";
            this.btn_Comm_Setup.Size = new System.Drawing.Size(93, 23);
            this.btn_Comm_Setup.TabIndex = 118;
            this.btn_Comm_Setup.UseVisualStyleBackColor = false;
            this.btn_Comm_Setup.Click += new System.EventHandler(this.btn_Comm_Setup_Click);
            this.btn_Comm_Setup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseDown);
            this.btn_Comm_Setup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseUp);
            // 
            // btn_Power_Setup
            // 
            this.btn_Power_Setup.BackColor = System.Drawing.Color.Transparent;
            this.btn_Power_Setup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Power_Setup.BackgroundImage")));
            this.btn_Power_Setup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Power_Setup.FlatAppearance.BorderSize = 0;
            this.btn_Power_Setup.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Power_Setup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Power_Setup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Power_Setup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Power_Setup.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Power_Setup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Power_Setup.Location = new System.Drawing.Point(582, 224);
            this.btn_Power_Setup.Name = "btn_Power_Setup";
            this.btn_Power_Setup.Size = new System.Drawing.Size(93, 23);
            this.btn_Power_Setup.TabIndex = 120;
            this.btn_Power_Setup.UseVisualStyleBackColor = false;
            this.btn_Power_Setup.Click += new System.EventHandler(this.btn_Power_Setup_Click);
            this.btn_Power_Setup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseDown);
            this.btn_Power_Setup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Apply_MouseUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(3, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 19);
            this.label14.TabIndex = 122;
            this.label14.Text = "전력가격 설정";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(191, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 19);
            this.label15.TabIndex = 124;
            this.label15.Text = "원 / kW";
            this.label15.Visible = false;
            // 
            // tb_Power_Prices
            // 
            this.tb_Power_Prices.BackColor = System.Drawing.Color.Transparent;
            this.tb_Power_Prices.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Power_Prices.ForeColor = System.Drawing.Color.Black;
            this.tb_Power_Prices.Location = new System.Drawing.Point(99, 91);
            this.tb_Power_Prices.Name = "tb_Power_Prices";
            this.tb_Power_Prices.Size = new System.Drawing.Size(97, 19);
            this.tb_Power_Prices.TabIndex = 125;
            this.tb_Power_Prices.Text = "280";
            this.tb_Power_Prices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tb_Power_Prices.Visible = false;
            this.tb_Power_Prices.Click += new System.EventHandler(this.tb_Power_Prices_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(219, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 19);
            this.label16.TabIndex = 128;
            this.label16.Text = "kW";
            this.label16.Visible = false;
            // 
            // tb_Active_Power_Maximum
            // 
            this.tb_Active_Power_Maximum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tb_Active_Power_Maximum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Active_Power_Maximum.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Active_Power_Maximum.Location = new System.Drawing.Point(162, 125);
            this.tb_Active_Power_Maximum.Mask = "999.9";
            this.tb_Active_Power_Maximum.Name = "tb_Active_Power_Maximum";
            this.tb_Active_Power_Maximum.Size = new System.Drawing.Size(59, 19);
            this.tb_Active_Power_Maximum.TabIndex = 127;
            this.tb_Active_Power_Maximum.TabStop = false;
            this.tb_Active_Power_Maximum.Text = "0500";
            this.tb_Active_Power_Maximum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Active_Power_Maximum.ValidatingType = typeof(int);
            this.tb_Active_Power_Maximum.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(3, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(153, 19);
            this.label17.TabIndex = 126;
            this.label17.Text = "유효전력설정값 최대치";
            this.label17.Visible = false;
            // 
            // Setting_PageViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.BackgroundImage = global::KTE_PMS.Properties.Resources.setting_배치;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb_Active_Power_Maximum);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tb_Power_Prices);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_Power_Setup);
            this.Controls.Add(this.btn_Comm_Setup);
            this.Controls.Add(this.btn_Language_Setup);
            this.Controls.Add(this.btn_DateTime_Setup);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Discharging_Stop_SOC);
            this.Controls.Add(this.tb_Charging_Stop_SOC);
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
        private System.Windows.Forms.MaskedTextBox tb_Charging_Stop_SOC;
        private System.Windows.Forms.MaskedTextBox tb_Discharging_Stop_SOC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_DateTime_Setup;
        private System.Windows.Forms.Button btn_Language_Setup;
        private System.Windows.Forms.Button btn_Comm_Setup;
        private System.Windows.Forms.Button btn_Power_Setup;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label tb_Power_Prices;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox tb_Active_Power_Maximum;
        private System.Windows.Forms.Label label17;
    }
}
