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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KTE_PMS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NAVI_CONTROL = new System.Windows.Forms.Button();
            this.CLOCK_TIMER = new System.Windows.Forms.Timer(this.components);
            this.MONITOR_OFF = new System.Windows.Forms.Button();
            this.CONTROL_PCSSTOP = new System.Windows.Forms.Button();
            this.NAVI_SETTING = new System.Windows.Forms.Button();
            this.NAVI_MEASURE = new System.Windows.Forms.Button();
            this.NAVI_MIMIC = new System.Windows.Forms.Button();
            this.NAVI_TREND = new System.Windows.Forms.Button();
            this.NAVI_ALARM = new System.Windows.Forms.Button();
            this.NAVI_MAIN = new System.Windows.Forms.Button();
            this.btn_GRID_ON = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(10, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 462);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 16F);
            this.label6.Location = new System.Drawing.Point(10, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(377, 30);
            this.label6.TabIndex = 15;
            this.label6.Tag = "TEST1";
            this.label6.Text = "############################";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // NAVI_CONTROL
            // 
            this.NAVI_CONTROL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NAVI_CONTROL.BackgroundImage = global::KTE_PMS.Properties.Resources.control_off;
            this.NAVI_CONTROL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_CONTROL.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_CONTROL.Location = new System.Drawing.Point(268, 532);
            this.NAVI_CONTROL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NAVI_CONTROL.Name = "NAVI_CONTROL";
            this.NAVI_CONTROL.Size = new System.Drawing.Size(128, 80);
            this.NAVI_CONTROL.TabIndex = 6;
            this.NAVI_CONTROL.UseVisualStyleBackColor = true;
            this.NAVI_CONTROL.Visible = false;
            this.NAVI_CONTROL.Click += new System.EventHandler(this.NAVI_CONTROL_Click);
            // 
            // CLOCK_TIMER
            // 
            this.CLOCK_TIMER.Interval = 1000;
            this.CLOCK_TIMER.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MONITOR_OFF
            // 
            this.MONITOR_OFF.BackgroundImage = global::KTE_PMS.Properties.Resources.Monitor_off_on;
            this.MONITOR_OFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MONITOR_OFF.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MONITOR_OFF.Location = new System.Drawing.Point(829, 11);
            this.MONITOR_OFF.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MONITOR_OFF.Name = "MONITOR_OFF";
            this.MONITOR_OFF.Size = new System.Drawing.Size(128, 80);
            this.MONITOR_OFF.TabIndex = 9;
            this.MONITOR_OFF.UseVisualStyleBackColor = true;
            this.MONITOR_OFF.Visible = false;
            this.MONITOR_OFF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MONITOR_OFF_MouseDown);
            this.MONITOR_OFF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MONITOR_OFF_MouseUp);
            // 
            // CONTROL_PCSSTOP
            // 
            this.CONTROL_PCSSTOP.BackgroundImage = global::KTE_PMS.Properties.Resources.PCS_STOP_on;
            this.CONTROL_PCSSTOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CONTROL_PCSSTOP.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CONTROL_PCSSTOP.Image = global::KTE_PMS.Properties.Resources.PCS_STOP_on;
            this.CONTROL_PCSSTOP.Location = new System.Drawing.Point(696, 11);
            this.CONTROL_PCSSTOP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CONTROL_PCSSTOP.Name = "CONTROL_PCSSTOP";
            this.CONTROL_PCSSTOP.Size = new System.Drawing.Size(128, 80);
            this.CONTROL_PCSSTOP.TabIndex = 8;
            this.CONTROL_PCSSTOP.UseVisualStyleBackColor = true;
            this.CONTROL_PCSSTOP.Visible = false;
            this.CONTROL_PCSSTOP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CONTROL_PCSSTOP_MouseDown);
            this.CONTROL_PCSSTOP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CONTROL_PCSSTOP_MouseUp);
            // 
            // NAVI_SETTING
            // 
            this.NAVI_SETTING.BackgroundImage = global::KTE_PMS.Properties.Resources.setting_off;
            this.NAVI_SETTING.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_SETTING.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_SETTING.Location = new System.Drawing.Point(799, 532);
            this.NAVI_SETTING.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NAVI_SETTING.Name = "NAVI_SETTING";
            this.NAVI_SETTING.Size = new System.Drawing.Size(128, 80);
            this.NAVI_SETTING.TabIndex = 7;
            this.NAVI_SETTING.UseVisualStyleBackColor = true;
            this.NAVI_SETTING.Visible = false;
            this.NAVI_SETTING.Click += new System.EventHandler(this.NAVI_SETTING_Click);
            // 
            // NAVI_MEASURE
            // 
            this.NAVI_MEASURE.BackgroundImage = global::KTE_PMS.Properties.Resources.measure_off_1;
            this.NAVI_MEASURE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_MEASURE.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_MEASURE.Location = new System.Drawing.Point(534, 532);
            this.NAVI_MEASURE.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NAVI_MEASURE.Name = "NAVI_MEASURE";
            this.NAVI_MEASURE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NAVI_MEASURE.Size = new System.Drawing.Size(128, 80);
            this.NAVI_MEASURE.TabIndex = 5;
            this.NAVI_MEASURE.Text = "Measure";
            this.NAVI_MEASURE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NAVI_MEASURE.UseVisualStyleBackColor = true;
            this.NAVI_MEASURE.Visible = false;
            this.NAVI_MEASURE.Click += new System.EventHandler(this.NAVI_MEASURE_Click);
            // 
            // NAVI_MIMIC
            // 
            this.NAVI_MIMIC.BackgroundImage = global::KTE_PMS.Properties.Resources.mimic_off;
            this.NAVI_MIMIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_MIMIC.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_MIMIC.Location = new System.Drawing.Point(401, 532);
            this.NAVI_MIMIC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NAVI_MIMIC.Name = "NAVI_MIMIC";
            this.NAVI_MIMIC.Size = new System.Drawing.Size(128, 80);
            this.NAVI_MIMIC.TabIndex = 4;
            this.NAVI_MIMIC.UseVisualStyleBackColor = true;
            this.NAVI_MIMIC.Visible = false;
            this.NAVI_MIMIC.Click += new System.EventHandler(this.NAVI_MIMIC_Click);
            // 
            // NAVI_TREND
            // 
            this.NAVI_TREND.BackgroundImage = global::KTE_PMS.Properties.Resources.trend_off;
            this.NAVI_TREND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_TREND.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_TREND.Location = new System.Drawing.Point(666, 532);
            this.NAVI_TREND.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NAVI_TREND.Name = "NAVI_TREND";
            this.NAVI_TREND.Size = new System.Drawing.Size(128, 80);
            this.NAVI_TREND.TabIndex = 3;
            this.NAVI_TREND.UseVisualStyleBackColor = true;
            this.NAVI_TREND.Visible = false;
            this.NAVI_TREND.Click += new System.EventHandler(this.NAVI_TREND_Click);
            // 
            // NAVI_ALARM
            // 
            this.NAVI_ALARM.BackgroundImage = global::KTE_PMS.Properties.Resources.alarm_off;
            this.NAVI_ALARM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_ALARM.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_ALARM.Location = new System.Drawing.Point(135, 532);
            this.NAVI_ALARM.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NAVI_ALARM.Name = "NAVI_ALARM";
            this.NAVI_ALARM.Size = new System.Drawing.Size(128, 80);
            this.NAVI_ALARM.TabIndex = 2;
            this.NAVI_ALARM.UseVisualStyleBackColor = true;
            this.NAVI_ALARM.Visible = false;
            this.NAVI_ALARM.Click += new System.EventHandler(this.NAVI_ALARM_Click);
            // 
            // NAVI_MAIN
            // 
            this.NAVI_MAIN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NAVI_MAIN.BackgroundImage = global::KTE_PMS.Properties.Resources.main_off;
            this.NAVI_MAIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_MAIN.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_MAIN.Location = new System.Drawing.Point(2, 532);
            this.NAVI_MAIN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.NAVI_MAIN.Name = "NAVI_MAIN";
            this.NAVI_MAIN.Size = new System.Drawing.Size(128, 80);
            this.NAVI_MAIN.TabIndex = 1;
            this.NAVI_MAIN.UseVisualStyleBackColor = true;
            this.NAVI_MAIN.Visible = false;
            this.NAVI_MAIN.Click += new System.EventHandler(this.NAVI_MAIN_Click);
            // 
            // btn_GRID_ON
            // 
            this.btn_GRID_ON.BackgroundImage = global::KTE_PMS.Properties.Resources.RUN_003;
            this.btn_GRID_ON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_GRID_ON.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btn_GRID_ON.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btn_GRID_ON.Location = new System.Drawing.Point(337, 31);
            this.btn_GRID_ON.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_GRID_ON.Name = "btn_GRID_ON";
            this.btn_GRID_ON.Size = new System.Drawing.Size(64, 61);
            this.btn_GRID_ON.TabIndex = 82;
            this.btn_GRID_ON.Click += new System.EventHandler(this.btn_GRID_ON_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.BackgroundImage = global::KTE_PMS.Properties.Resources.RUN_003;
            this.simpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton1.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.Location = new System.Drawing.Point(426, 30);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(64, 61);
            this.simpleButton1.TabIndex = 83;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.BackgroundImage = global::KTE_PMS.Properties.Resources.RUN_003;
            this.simpleButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton2.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton2.Location = new System.Drawing.Point(246, 31);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(64, 61);
            this.simpleButton2.TabIndex = 84;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(240, -2);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 31);
            this.label4.TabIndex = 85;
            this.label4.Text = "초기화";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(342, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 31);
            this.label1.TabIndex = 86;
            this.label1.Text = "충전";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(429, -2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 31);
            this.label2.TabIndex = 87;
            this.label2.Text = "방전";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(508, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 39);
            this.textBox1.TabIndex = 100;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(518, -2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 31);
            this.label3.TabIndex = 101;
            this.label3.Text = "전력량";
            // 
            // KTE_PMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(966, 622);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btn_GRID_ON);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NAVI_CONTROL);
            this.Controls.Add(this.MONITOR_OFF);
            this.Controls.Add(this.CONTROL_PCSSTOP);
            this.Controls.Add(this.NAVI_SETTING);
            this.Controls.Add(this.NAVI_MEASURE);
            this.Controls.Add(this.NAVI_MIMIC);
            this.Controls.Add(this.NAVI_TREND);
            this.Controls.Add(this.NAVI_ALARM);
            this.Controls.Add(this.NAVI_MAIN);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "KTE_PMS";
            this.ShowIcon = false;
            this.Text = "KTE_PMS";
            this.Load += new System.EventHandler(this.KTE_PMS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button CONTROL_PCSSTOP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button MONITOR_OFF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer CLOCK_TIMER;
        private DevExpress.XtraEditors.SimpleButton btn_GRID_ON;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}

