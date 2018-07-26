namespace KTE_PMS
{
    partial class LEMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LEMS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_alarm_count = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CLOCK_TIMER = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEVICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_Current_PCS_MODE = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Status_PMS_BMS = new System.Windows.Forms.PictureBox();
            this.Status_PMS_PCS = new System.Windows.Forms.PictureBox();
            this.Status_LEMS_BMS = new System.Windows.Forms.PictureBox();
            this.Status_LEMS_PMS = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NAVI_SETTING = new System.Windows.Forms.Button();
            this.NAVI_CONTROL = new System.Windows.Forms.Button();
            this.NAVI_MEASURE = new System.Windows.Forms.Button();
            this.btn_PCS_STOP = new System.Windows.Forms.Button();
            this.NAVI_TREND = new System.Windows.Forms.Button();
            this.NAVI_MIMIC = new System.Windows.Forms.Button();
            this.NAVI_ALARM = new System.Windows.Forms.Button();
            this.NAVI_MAIN = new System.Windows.Forms.Button();
            this.btn_Monitor_OFF = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_PMS_BMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_PMS_PCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_LEMS_BMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_LEMS_PMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lb_alarm_count);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(960, 434);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lb_alarm_count
            // 
            this.lb_alarm_count.AutoSize = true;
            this.lb_alarm_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lb_alarm_count.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_alarm_count.Location = new System.Drawing.Point(377, 118);
            this.lb_alarm_count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_alarm_count.Name = "lb_alarm_count";
            this.lb_alarm_count.Size = new System.Drawing.Size(35, 21);
            this.lb_alarm_count.TabIndex = 37;
            this.lb_alarm_count.Tag = "";
            this.lb_alarm_count.Text = "4개";
            this.lb_alarm_count.Visible = false;
            this.lb_alarm_count.Click += new System.EventHandler(this.lb_alarm_count_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(426, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 49);
            this.button1.TabIndex = 17;
            this.button1.Text = "ACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(72, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 14);
            this.label6.TabIndex = 15;
            this.label6.Tag = "TEST1";
            this.label6.Text = "2018-03-20";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CLOCK_TIMER
            // 
            this.CLOCK_TIMER.Interval = 1000;
            this.CLOCK_TIMER.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.dataGridView1.Location = new System.Drawing.Point(152, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 27;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataGridView1.RowTemplate.Height = 17;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(397, 49);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.TabStop = false;
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
            this.TIME.Width = 140;
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
            this.CLASS.Visible = false;
            this.CLASS.Width = 70;
            // 
            // DEVICE
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DEVICE.DefaultCellStyle = dataGridViewCellStyle11;
            this.DEVICE.HeaderText = "DEVICE";
            this.DEVICE.MinimumWidth = 2;
            this.DEVICE.Name = "DEVICE";
            this.DEVICE.ReadOnly = true;
            this.DEVICE.Width = 70;
            // 
            // DESCRIPTION
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DESCRIPTION.DefaultCellStyle = dataGridViewCellStyle12;
            this.DESCRIPTION.HeaderText = "DESCRIPTION";
            this.DESCRIPTION.MinimumWidth = 200;
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.ReadOnly = true;
            this.DESCRIPTION.Width = 300;
            // 
            // IO
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IO.DefaultCellStyle = dataGridViewCellStyle13;
            this.IO.HeaderText = "IO";
            this.IO.MinimumWidth = 100;
            this.IO.Name = "IO";
            this.IO.ReadOnly = true;
            this.IO.Width = 170;
            // 
            // lb_Current_PCS_MODE
            // 
            this.lb_Current_PCS_MODE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lb_Current_PCS_MODE.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Current_PCS_MODE.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_Current_PCS_MODE.Location = new System.Drawing.Point(806, 35);
            this.lb_Current_PCS_MODE.Name = "lb_Current_PCS_MODE";
            this.lb_Current_PCS_MODE.Size = new System.Drawing.Size(77, 20);
            this.lb_Current_PCS_MODE.TabIndex = 36;
            this.lb_Current_PCS_MODE.Text = "배터리 충전 중";
            this.lb_Current_PCS_MODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Current_PCS_MODE.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(69, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 83;
            this.label1.Tag = "TEST1";
            this.label1.Text = "11:35:26";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Status_PMS_BMS
            // 
            this.Status_PMS_BMS.Image = ((System.Drawing.Image)(resources.GetObject("Status_PMS_BMS.Image")));
            this.Status_PMS_BMS.Location = new System.Drawing.Point(749, 25);
            this.Status_PMS_BMS.Name = "Status_PMS_BMS";
            this.Status_PMS_BMS.Size = new System.Drawing.Size(33, 12);
            this.Status_PMS_BMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Status_PMS_BMS.TabIndex = 87;
            this.Status_PMS_BMS.TabStop = false;
            // 
            // Status_PMS_PCS
            // 
            this.Status_PMS_PCS.Image = ((System.Drawing.Image)(resources.GetObject("Status_PMS_PCS.Image")));
            this.Status_PMS_PCS.Location = new System.Drawing.Point(690, 25);
            this.Status_PMS_PCS.Name = "Status_PMS_PCS";
            this.Status_PMS_PCS.Size = new System.Drawing.Size(33, 12);
            this.Status_PMS_PCS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Status_PMS_PCS.TabIndex = 86;
            this.Status_PMS_PCS.TabStop = false;
            // 
            // Status_LEMS_BMS
            // 
            this.Status_LEMS_BMS.Image = ((System.Drawing.Image)(resources.GetObject("Status_LEMS_BMS.Image")));
            this.Status_LEMS_BMS.Location = new System.Drawing.Point(630, 25);
            this.Status_LEMS_BMS.Name = "Status_LEMS_BMS";
            this.Status_LEMS_BMS.Size = new System.Drawing.Size(33, 12);
            this.Status_LEMS_BMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Status_LEMS_BMS.TabIndex = 85;
            this.Status_LEMS_BMS.TabStop = false;
            this.Status_LEMS_BMS.Click += new System.EventHandler(this.btn_Reconnect_Click);
            // 
            // Status_LEMS_PMS
            // 
            this.Status_LEMS_PMS.Image = ((System.Drawing.Image)(resources.GetObject("Status_LEMS_PMS.Image")));
            this.Status_LEMS_PMS.Location = new System.Drawing.Point(571, 25);
            this.Status_LEMS_PMS.Name = "Status_LEMS_PMS";
            this.Status_LEMS_PMS.Size = new System.Drawing.Size(33, 12);
            this.Status_LEMS_PMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Status_LEMS_PMS.TabIndex = 82;
            this.Status_LEMS_PMS.TabStop = false;
            this.Status_LEMS_PMS.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // NAVI_SETTING
            // 
            this.NAVI_SETTING.BackgroundImage = global::KTE_PMS.Properties.Resources.setting_off;
            this.NAVI_SETTING.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_SETTING.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NAVI_SETTING.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_SETTING.Location = new System.Drawing.Point(821, 493);
            this.NAVI_SETTING.Margin = new System.Windows.Forms.Padding(0);
            this.NAVI_SETTING.Name = "NAVI_SETTING";
            this.NAVI_SETTING.Size = new System.Drawing.Size(139, 91);
            this.NAVI_SETTING.TabIndex = 7;
            this.NAVI_SETTING.UseVisualStyleBackColor = true;
            this.NAVI_SETTING.Click += new System.EventHandler(this.NAVI_SETTING_Click);
            // 
            // NAVI_CONTROL
            // 
            this.NAVI_CONTROL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NAVI_CONTROL.BackgroundImage = global::KTE_PMS.Properties.Resources.control_off;
            this.NAVI_CONTROL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_CONTROL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NAVI_CONTROL.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_CONTROL.Location = new System.Drawing.Point(684, 493);
            this.NAVI_CONTROL.Margin = new System.Windows.Forms.Padding(0);
            this.NAVI_CONTROL.Name = "NAVI_CONTROL";
            this.NAVI_CONTROL.Size = new System.Drawing.Size(139, 91);
            this.NAVI_CONTROL.TabIndex = 6;
            this.NAVI_CONTROL.UseVisualStyleBackColor = true;
            this.NAVI_CONTROL.Click += new System.EventHandler(this.NAVI_CONTROL_Click);
            // 
            // NAVI_MEASURE
            // 
            this.NAVI_MEASURE.BackgroundImage = global::KTE_PMS.Properties.Resources.measure_off;
            this.NAVI_MEASURE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_MEASURE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NAVI_MEASURE.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_MEASURE.Location = new System.Drawing.Point(547, 493);
            this.NAVI_MEASURE.Margin = new System.Windows.Forms.Padding(0);
            this.NAVI_MEASURE.Name = "NAVI_MEASURE";
            this.NAVI_MEASURE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NAVI_MEASURE.Size = new System.Drawing.Size(139, 91);
            this.NAVI_MEASURE.TabIndex = 5;
            this.NAVI_MEASURE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NAVI_MEASURE.UseVisualStyleBackColor = true;
            this.NAVI_MEASURE.Click += new System.EventHandler(this.NAVI_MEASURE_Click);
            // 
            // btn_PCS_STOP
            // 
            this.btn_PCS_STOP.BackgroundImage = global::KTE_PMS.Properties.Resources.PCS_STOP_on;
            this.btn_PCS_STOP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_PCS_STOP.FlatAppearance.BorderSize = 0;
            this.btn_PCS_STOP.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_PCS_STOP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_PCS_STOP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_PCS_STOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PCS_STOP.Location = new System.Drawing.Point(888, 6);
            this.btn_PCS_STOP.Name = "btn_PCS_STOP";
            this.btn_PCS_STOP.Size = new System.Drawing.Size(54, 49);
            this.btn_PCS_STOP.TabIndex = 19;
            this.btn_PCS_STOP.UseVisualStyleBackColor = true;
            this.btn_PCS_STOP.Click += new System.EventHandler(this.btn_PCS_STOP_Click);
            this.btn_PCS_STOP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_PCS_STOP_MouseDown);
            this.btn_PCS_STOP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_PCS_STOP_MouseUp);
            // 
            // NAVI_TREND
            // 
            this.NAVI_TREND.BackgroundImage = global::KTE_PMS.Properties.Resources.trend_off;
            this.NAVI_TREND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_TREND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NAVI_TREND.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_TREND.Location = new System.Drawing.Point(273, 493);
            this.NAVI_TREND.Margin = new System.Windows.Forms.Padding(0);
            this.NAVI_TREND.Name = "NAVI_TREND";
            this.NAVI_TREND.Size = new System.Drawing.Size(139, 91);
            this.NAVI_TREND.TabIndex = 3;
            this.NAVI_TREND.UseVisualStyleBackColor = true;
            this.NAVI_TREND.Click += new System.EventHandler(this.NAVI_TREND_Click);
            // 
            // NAVI_MIMIC
            // 
            this.NAVI_MIMIC.BackgroundImage = global::KTE_PMS.Properties.Resources.mimic_off;
            this.NAVI_MIMIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_MIMIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NAVI_MIMIC.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_MIMIC.Location = new System.Drawing.Point(410, 493);
            this.NAVI_MIMIC.Margin = new System.Windows.Forms.Padding(0);
            this.NAVI_MIMIC.Name = "NAVI_MIMIC";
            this.NAVI_MIMIC.Size = new System.Drawing.Size(139, 91);
            this.NAVI_MIMIC.TabIndex = 4;
            this.NAVI_MIMIC.UseVisualStyleBackColor = true;
            this.NAVI_MIMIC.Click += new System.EventHandler(this.NAVI_MIMIC_Click);
            // 
            // NAVI_ALARM
            // 
            this.NAVI_ALARM.BackgroundImage = global::KTE_PMS.Properties.Resources.alarm_off;
            this.NAVI_ALARM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_ALARM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NAVI_ALARM.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_ALARM.Location = new System.Drawing.Point(137, 493);
            this.NAVI_ALARM.Margin = new System.Windows.Forms.Padding(0);
            this.NAVI_ALARM.Name = "NAVI_ALARM";
            this.NAVI_ALARM.Size = new System.Drawing.Size(139, 91);
            this.NAVI_ALARM.TabIndex = 2;
            this.NAVI_ALARM.UseVisualStyleBackColor = true;
            this.NAVI_ALARM.Click += new System.EventHandler(this.NAVI_ALARM_Click);
            // 
            // NAVI_MAIN
            // 
            this.NAVI_MAIN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NAVI_MAIN.BackgroundImage = global::KTE_PMS.Properties.Resources.main_off;
            this.NAVI_MAIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NAVI_MAIN.FlatAppearance.BorderSize = 0;
            this.NAVI_MAIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NAVI_MAIN.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NAVI_MAIN.Location = new System.Drawing.Point(0, 493);
            this.NAVI_MAIN.Margin = new System.Windows.Forms.Padding(0);
            this.NAVI_MAIN.Name = "NAVI_MAIN";
            this.NAVI_MAIN.Size = new System.Drawing.Size(139, 91);
            this.NAVI_MAIN.TabIndex = 1;
            this.NAVI_MAIN.UseVisualStyleBackColor = true;
            this.NAVI_MAIN.Click += new System.EventHandler(this.NAVI_MAIN_Click);
            // 
            // btn_Monitor_OFF
            // 
            this.btn_Monitor_OFF.BackgroundImage = global::KTE_PMS.Properties.Resources.monitoroff_on;
            this.btn_Monitor_OFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Monitor_OFF.FlatAppearance.BorderSize = 0;
            this.btn_Monitor_OFF.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Monitor_OFF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Monitor_OFF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Monitor_OFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Monitor_OFF.Location = new System.Drawing.Point(806, 8);
            this.btn_Monitor_OFF.Name = "btn_Monitor_OFF";
            this.btn_Monitor_OFF.Size = new System.Drawing.Size(77, 23);
            this.btn_Monitor_OFF.TabIndex = 20;
            this.btn_Monitor_OFF.UseVisualStyleBackColor = true;
            this.btn_Monitor_OFF.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Monitor_OFF_MouseClick);
            this.btn_Monitor_OFF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Monitor_OFF_MouseDown);
            this.btn_Monitor_OFF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Monitor_OFF_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KTE_PMS.Properties.Resources.통신상태;
            this.pictureBox3.Location = new System.Drawing.Point(561, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(231, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 84;
            this.pictureBox3.TabStop = false;
            // 
            // LEMS
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(962, 580);
            this.ControlBox = false;
            this.Controls.Add(this.Status_PMS_BMS);
            this.Controls.Add(this.Status_PMS_PCS);
            this.Controls.Add(this.Status_LEMS_BMS);
            this.Controls.Add(this.Status_LEMS_PMS);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Current_PCS_MODE);
            this.Controls.Add(this.NAVI_SETTING);
            this.Controls.Add(this.NAVI_CONTROL);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NAVI_MEASURE);
            this.Controls.Add(this.btn_PCS_STOP);
            this.Controls.Add(this.NAVI_TREND);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NAVI_MIMIC);
            this.Controls.Add(this.NAVI_ALARM);
            this.Controls.Add(this.NAVI_MAIN);
            this.Controls.Add(this.btn_Monitor_OFF);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "LEMS";
            this.ShowIcon = false;
            this.Text = "KTE_PMS";
            this.Load += new System.EventHandler(this.KTE_PMS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_PMS_BMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_PMS_PCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_LEMS_BMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_LEMS_PMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lb_Current_PCS_MODE;
        private System.Windows.Forms.Label lb_alarm_count;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Status_LEMS_PMS;
        private System.Windows.Forms.PictureBox Status_LEMS_BMS;
        private System.Windows.Forms.PictureBox Status_PMS_PCS;
        private System.Windows.Forms.PictureBox Status_PMS_BMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEVICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IO;
    }
}

