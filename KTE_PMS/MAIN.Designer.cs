namespace KTE_PMS
{
    partial class KTE_PMS
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.NAVI_CONTROL = new System.Windows.Forms.Button();
            this.CLOCK_TIMER = new System.Windows.Forms.Timer(this.components);
            this.NAVI_SETTING = new System.Windows.Forms.Button();
            this.NAVI_MEASURE = new System.Windows.Forms.Button();
            this.NAVI_MIMIC = new System.Windows.Forms.Button();
            this.NAVI_TREND = new System.Windows.Forms.Button();
            this.NAVI_ALARM = new System.Windows.Forms.Button();
            this.NAVI_MAIN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEVICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_PCS_STOP = new System.Windows.Forms.Button();
            this.btn_Monitor_OFF = new System.Windows.Forms.Button();
            this.lb_Current_PCS_MODE = new System.Windows.Forms.Label();
            this.lb_alarm_count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(960, 510);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(26, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 21);
            this.label6.TabIndex = 15;
            this.label6.Tag = "TEST1";
            this.label6.Text = "2018-03-20 11:35:26";
            // 
            // NAVI_CONTROL
            // 
            this.NAVI_CONTROL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NAVI_CONTROL.BackgroundImage = global::KTE_PMS.Properties.Resources.control_off;
            this.NAVI_CONTROL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_CONTROL.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_CONTROL.Location = new System.Drawing.Point(274, 606);
            this.NAVI_CONTROL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NAVI_CONTROL.Name = "NAVI_CONTROL";
            this.NAVI_CONTROL.Size = new System.Drawing.Size(135, 102);
            this.NAVI_CONTROL.TabIndex = 6;
            this.NAVI_CONTROL.UseVisualStyleBackColor = true;
            this.NAVI_CONTROL.Click += new System.EventHandler(this.NAVI_CONTROL_Click);
            // 
            // CLOCK_TIMER
            // 
            this.CLOCK_TIMER.Interval = 1000;
            this.CLOCK_TIMER.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NAVI_SETTING
            // 
            this.NAVI_SETTING.BackgroundImage = global::KTE_PMS.Properties.Resources.setting_off;
            this.NAVI_SETTING.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_SETTING.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_SETTING.Location = new System.Drawing.Point(823, 606);
            this.NAVI_SETTING.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NAVI_SETTING.Name = "NAVI_SETTING";
            this.NAVI_SETTING.Size = new System.Drawing.Size(135, 102);
            this.NAVI_SETTING.TabIndex = 7;
            this.NAVI_SETTING.UseVisualStyleBackColor = true;
            this.NAVI_SETTING.Click += new System.EventHandler(this.NAVI_SETTING_Click);
            // 
            // NAVI_MEASURE
            // 
            this.NAVI_MEASURE.BackgroundImage = global::KTE_PMS.Properties.Resources.measure_off_1;
            this.NAVI_MEASURE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_MEASURE.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_MEASURE.Location = new System.Drawing.Point(548, 606);
            this.NAVI_MEASURE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NAVI_MEASURE.Name = "NAVI_MEASURE";
            this.NAVI_MEASURE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NAVI_MEASURE.Size = new System.Drawing.Size(135, 102);
            this.NAVI_MEASURE.TabIndex = 5;
            this.NAVI_MEASURE.Text = "Measure";
            this.NAVI_MEASURE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NAVI_MEASURE.UseVisualStyleBackColor = true;
            this.NAVI_MEASURE.Click += new System.EventHandler(this.NAVI_MEASURE_Click);
            // 
            // NAVI_MIMIC
            // 
            this.NAVI_MIMIC.BackgroundImage = global::KTE_PMS.Properties.Resources.mimic_off;
            this.NAVI_MIMIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_MIMIC.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_MIMIC.Location = new System.Drawing.Point(411, 606);
            this.NAVI_MIMIC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NAVI_MIMIC.Name = "NAVI_MIMIC";
            this.NAVI_MIMIC.Size = new System.Drawing.Size(135, 102);
            this.NAVI_MIMIC.TabIndex = 4;
            this.NAVI_MIMIC.UseVisualStyleBackColor = true;
            this.NAVI_MIMIC.Click += new System.EventHandler(this.NAVI_MIMIC_Click);
            // 
            // NAVI_TREND
            // 
            this.NAVI_TREND.BackgroundImage = global::KTE_PMS.Properties.Resources.trend_off;
            this.NAVI_TREND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_TREND.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_TREND.Location = new System.Drawing.Point(685, 606);
            this.NAVI_TREND.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NAVI_TREND.Name = "NAVI_TREND";
            this.NAVI_TREND.Size = new System.Drawing.Size(135, 102);
            this.NAVI_TREND.TabIndex = 3;
            this.NAVI_TREND.UseVisualStyleBackColor = true;
            this.NAVI_TREND.Click += new System.EventHandler(this.NAVI_TREND_Click);
            // 
            // NAVI_ALARM
            // 
            this.NAVI_ALARM.BackgroundImage = global::KTE_PMS.Properties.Resources.alarm_off;
            this.NAVI_ALARM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_ALARM.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_ALARM.Location = new System.Drawing.Point(137, 606);
            this.NAVI_ALARM.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NAVI_ALARM.Name = "NAVI_ALARM";
            this.NAVI_ALARM.Size = new System.Drawing.Size(135, 102);
            this.NAVI_ALARM.TabIndex = 2;
            this.NAVI_ALARM.UseVisualStyleBackColor = true;
            this.NAVI_ALARM.Click += new System.EventHandler(this.NAVI_ALARM_Click);
            // 
            // NAVI_MAIN
            // 
            this.NAVI_MAIN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NAVI_MAIN.BackgroundImage = global::KTE_PMS.Properties.Resources.main_off;
            this.NAVI_MAIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_MAIN.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_MAIN.Location = new System.Drawing.Point(0, 606);
            this.NAVI_MAIN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NAVI_MAIN.Name = "NAVI_MAIN";
            this.NAVI_MAIN.Size = new System.Drawing.Size(135, 102);
            this.NAVI_MAIN.TabIndex = 1;
            this.NAVI_MAIN.UseVisualStyleBackColor = true;
            this.NAVI_MAIN.Click += new System.EventHandler(this.NAVI_MAIN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "ACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 25;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TIME,
            this.CLASS,
            this.DEVICE,
            this.DESCRIPTION,
            this.IO});
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(223, 9);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(480, 69);
            this.dataGridView1.TabIndex = 18;
            // 
            // TIME
            // 
            this.TIME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TIME.DefaultCellStyle = dataGridViewCellStyle9;
            this.TIME.HeaderText = "TIME";
            this.TIME.MinimumWidth = 100;
            this.TIME.Name = "TIME";
            this.TIME.ReadOnly = true;
            this.TIME.Width = 160;
            // 
            // CLASS
            // 
            this.CLASS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CLASS.DefaultCellStyle = dataGridViewCellStyle10;
            this.CLASS.HeaderText = "CLASS";
            this.CLASS.MinimumWidth = 2;
            this.CLASS.Name = "CLASS";
            this.CLASS.ReadOnly = true;
            this.CLASS.Width = 2;
            // 
            // DEVICE
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DEVICE.DefaultCellStyle = dataGridViewCellStyle11;
            this.DEVICE.HeaderText = "DEVICE";
            this.DEVICE.MinimumWidth = 2;
            this.DEVICE.Name = "DEVICE";
            this.DEVICE.ReadOnly = true;
            this.DEVICE.Width = 2;
            // 
            // DESCRIPTION
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DESCRIPTION.DefaultCellStyle = dataGridViewCellStyle12;
            this.DESCRIPTION.HeaderText = "DESCRIPTION";
            this.DESCRIPTION.MinimumWidth = 200;
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.ReadOnly = true;
            this.DESCRIPTION.Width = 400;
            // 
            // IO
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IO.DefaultCellStyle = dataGridViewCellStyle13;
            this.IO.HeaderText = "IO";
            this.IO.MinimumWidth = 100;
            this.IO.Name = "IO";
            this.IO.ReadOnly = true;
            this.IO.Visible = false;
            this.IO.Width = 170;
            // 
            // btn_PCS_STOP
            // 
            this.btn_PCS_STOP.BackgroundImage = global::KTE_PMS.Properties.Resources.PCS_STOP_on;
            this.btn_PCS_STOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PCS_STOP.Location = new System.Drawing.Point(753, 9);
            this.btn_PCS_STOP.Name = "btn_PCS_STOP";
            this.btn_PCS_STOP.Size = new System.Drawing.Size(85, 72);
            this.btn_PCS_STOP.TabIndex = 19;
            this.btn_PCS_STOP.UseVisualStyleBackColor = true;
            // 
            // btn_Monitor_OFF
            // 
            this.btn_Monitor_OFF.BackgroundImage = global::KTE_PMS.Properties.Resources.Monitor_off_on;
            this.btn_Monitor_OFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Monitor_OFF.Location = new System.Drawing.Point(850, 9);
            this.btn_Monitor_OFF.Name = "btn_Monitor_OFF";
            this.btn_Monitor_OFF.Size = new System.Drawing.Size(85, 72);
            this.btn_Monitor_OFF.TabIndex = 20;
            this.btn_Monitor_OFF.UseVisualStyleBackColor = true;
            this.btn_Monitor_OFF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Monitor_OFF_MouseClick);
            // 
            // lb_Current_PCS_MODE
            // 
            this.lb_Current_PCS_MODE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lb_Current_PCS_MODE.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Current_PCS_MODE.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_Current_PCS_MODE.Location = new System.Drawing.Point(109, 9);
            this.lb_Current_PCS_MODE.Name = "lb_Current_PCS_MODE";
            this.lb_Current_PCS_MODE.Size = new System.Drawing.Size(99, 20);
            this.lb_Current_PCS_MODE.TabIndex = 36;
            this.lb_Current_PCS_MODE.Text = "배터리 충전 중";
            this.lb_Current_PCS_MODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Current_PCS_MODE.Visible = false;
            // 
            // lb_alarm_count
            // 
            this.lb_alarm_count.AutoSize = true;
            this.lb_alarm_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lb_alarm_count.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_alarm_count.Location = new System.Drawing.Point(708, 57);
            this.lb_alarm_count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_alarm_count.Name = "lb_alarm_count";
            this.lb_alarm_count.Size = new System.Drawing.Size(35, 21);
            this.lb_alarm_count.TabIndex = 37;
            this.lb_alarm_count.Tag = "";
            this.lb_alarm_count.Text = "4개";
            this.lb_alarm_count.Click += new System.EventHandler(this.lb_alarm_count_Click);
            // 
            // KTE_PMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::KTE_PMS.Properties.Resources.main_버튼7개;
            this.ClientSize = new System.Drawing.Size(962, 708);
            this.Controls.Add(this.lb_alarm_count);
            this.Controls.Add(this.lb_Current_PCS_MODE);
            this.Controls.Add(this.NAVI_ALARM);
            this.Controls.Add(this.btn_Monitor_OFF);
            this.Controls.Add(this.btn_PCS_STOP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NAVI_SETTING);
            this.Controls.Add(this.NAVI_MIMIC);
            this.Controls.Add(this.NAVI_TREND);
            this.Controls.Add(this.NAVI_MAIN);
            this.Controls.Add(this.NAVI_MEASURE);
            this.Controls.Add(this.NAVI_CONTROL);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "KTE_PMS";
            this.ShowIcon = false;
            this.Text = "KTE_PMS";
            this.Load += new System.EventHandler(this.KTE_PMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NAVI_MAIN;
        private System.Windows.Forms.Button NAVI_ALARM;
        private System.Windows.Forms.Button NAVI_TREND;
        private System.Windows.Forms.Button NAVI_MIMIC;
        private System.Windows.Forms.Button NAVI_MEASURE;
        private System.Windows.Forms.Button NAVI_CONTROL;
        private System.Windows.Forms.Button NAVI_SETTING;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer CLOCK_TIMER;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_PCS_STOP;
        private System.Windows.Forms.Button btn_Monitor_OFF;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEVICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IO;
        private System.Windows.Forms.Label lb_Current_PCS_MODE;
        private System.Windows.Forms.Label lb_alarm_count;
    }
}

