namespace KTE_PMS
{
    partial class MainViewer
    {
        private System.Windows.Forms.ImageList Battery_to_PCS;
        private System.Windows.Forms.Button btn_ChargingMode;
        private System.Windows.Forms.Button btn_CustomMode;
        private System.Windows.Forms.Button btn_DisChargingMode;
        private System.Windows.Forms.Button btn_PeakCutMode;
        private System.Windows.Forms.Button btn_ReCreate;
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Label lb12;
        private System.Windows.Forms.Label lb13;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Label lb9;
        private System.Windows.Forms.PictureBox pb_Battery_to_PCS;
        private System.Windows.Forms.PictureBox pb_PCS_to_Grid;
        private System.Windows.Forms.ImageList PCS_to_Load;
        private System.Windows.Forms.ImageList PCS_to_Grid;
        private System.Windows.Forms.Timer timer1;

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainViewer));
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb8 = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.Battery_to_PCS = new System.Windows.Forms.ImageList(this.components);
            this.PCS_to_Grid = new System.Windows.Forms.ImageList(this.components);
            this.PCS_to_Load = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb10 = new System.Windows.Forms.Label();
            this.lb9 = new System.Windows.Forms.Label();
            this.lb13 = new System.Windows.Forms.Label();
            this.lb12 = new System.Windows.Forms.Label();
            this.btn_ReCreate = new System.Windows.Forms.Button();
            this.lb_System_Status = new System.Windows.Forms.Label();
            this.lb_PCS_System_Status = new System.Windows.Forms.Label();
            this.lb_Battery_Control_Authority = new System.Windows.Forms.Label();
            this.lb_PCS_Control_Authority = new System.Windows.Forms.Label();
            this.il_Battery_List = new System.Windows.Forms.ImageList(this.components);
            this.pb_PCS_to_Load = new System.Windows.Forms.PictureBox();
            this.pb_Battery = new System.Windows.Forms.PictureBox();
            this.pb_PCS_Abnormal = new System.Windows.Forms.PictureBox();
            this.pb_Battery_Abnormal = new System.Windows.Forms.PictureBox();
            this.btn_PCS_Control = new System.Windows.Forms.Button();
            this.btn_Battery_Control = new System.Windows.Forms.Button();
            this.btn_LEMS = new System.Windows.Forms.Button();
            this.btn_uPMS = new System.Windows.Forms.Button();
            this.esS_Scheduler1 = new KTE_PMS.ESS_Scheduler();
            this.btn_CustomMode = new System.Windows.Forms.Button();
            this.btn_PeakCutMode = new System.Windows.Forms.Button();
            this.btn_DisChargingMode = new System.Windows.Forms.Button();
            this.btn_ChargingMode = new System.Windows.Forms.Button();
            this.pb_PCS_to_Grid = new System.Windows.Forms.PictureBox();
            this.pb_Battery_to_PCS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PCS_to_Load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Battery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PCS_Abnormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Battery_Abnormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PCS_to_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Battery_to_PCS)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb1.ForeColor = System.Drawing.Color.Black;
            this.lb1.Location = new System.Drawing.Point(318, 136);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(51, 17);
            this.lb1.TabIndex = 15;
            this.lb1.Text = "12.34 ";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb1.Visible = false;
            // 
            // lb2
            // 
            this.lb2.BackColor = System.Drawing.Color.Transparent;
            this.lb2.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb2.ForeColor = System.Drawing.Color.Black;
            this.lb2.Location = new System.Drawing.Point(319, 151);
            this.lb2.Margin = new System.Windows.Forms.Padding(0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(51, 17);
            this.lb2.TabIndex = 16;
            this.lb2.Text = "12.34 ";
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb2.Visible = false;
            // 
            // lb3
            // 
            this.lb3.BackColor = System.Drawing.Color.Transparent;
            this.lb3.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb3.ForeColor = System.Drawing.Color.Black;
            this.lb3.Location = new System.Drawing.Point(319, 165);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(51, 17);
            this.lb3.TabIndex = 17;
            this.lb3.Text = "12.34 ";
            this.lb3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb3.Visible = false;
            // 
            // lb4
            // 
            this.lb4.BackColor = System.Drawing.Color.Transparent;
            this.lb4.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb4.ForeColor = System.Drawing.Color.Black;
            this.lb4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb4.Location = new System.Drawing.Point(319, 182);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(51, 17);
            this.lb4.TabIndex = 18;
            this.lb4.Text = "12.34 ";
            this.lb4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb4.Visible = false;
            // 
            // lb8
            // 
            this.lb8.BackColor = System.Drawing.Color.Transparent;
            this.lb8.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb8.ForeColor = System.Drawing.Color.Black;
            this.lb8.Location = new System.Drawing.Point(536, 69);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(51, 17);
            this.lb8.TabIndex = 30;
            this.lb8.Text = "12.34 ";
            this.lb8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb8.Visible = false;
            // 
            // lb7
            // 
            this.lb7.BackColor = System.Drawing.Color.Transparent;
            this.lb7.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb7.ForeColor = System.Drawing.Color.Black;
            this.lb7.Location = new System.Drawing.Point(536, 53);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(51, 17);
            this.lb7.TabIndex = 29;
            this.lb7.Text = "12.34 ";
            this.lb7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb7.Visible = false;
            // 
            // lb6
            // 
            this.lb6.BackColor = System.Drawing.Color.Transparent;
            this.lb6.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb6.ForeColor = System.Drawing.Color.Black;
            this.lb6.Location = new System.Drawing.Point(536, 38);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(51, 17);
            this.lb6.TabIndex = 28;
            this.lb6.Text = "12.34 ";
            this.lb6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb6.Visible = false;
            // 
            // lb5
            // 
            this.lb5.BackColor = System.Drawing.Color.Transparent;
            this.lb5.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb5.ForeColor = System.Drawing.Color.Black;
            this.lb5.Location = new System.Drawing.Point(536, 22);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(51, 17);
            this.lb5.TabIndex = 27;
            this.lb5.Text = "12.34 ";
            this.lb5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb5.Visible = false;
            // 
            // Battery_to_PCS
            // 
            this.Battery_to_PCS.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Battery_to_PCS.ImageStream")));
            this.Battery_to_PCS.TransparentColor = System.Drawing.Color.Transparent;
            this.Battery_to_PCS.Images.SetKeyName(0, "dot_battery_PCS_001.png");
            this.Battery_to_PCS.Images.SetKeyName(1, "dot_battery_PCS_002.png");
            this.Battery_to_PCS.Images.SetKeyName(2, "dot_battery_PCS_003.png");
            this.Battery_to_PCS.Images.SetKeyName(3, "dot_battery_PCS_004.png");
            this.Battery_to_PCS.Images.SetKeyName(4, "dot_battery_PCS_005.png");
            // 
            // PCS_to_Grid
            // 
            this.PCS_to_Grid.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PCS_to_Grid.ImageStream")));
            this.PCS_to_Grid.TransparentColor = System.Drawing.Color.Transparent;
            this.PCS_to_Grid.Images.SetKeyName(0, "dot_Grid_PCS_001.png");
            this.PCS_to_Grid.Images.SetKeyName(1, "dot_Grid_PCS_002.png");
            this.PCS_to_Grid.Images.SetKeyName(2, "dot_Grid_PCS_003.png");
            this.PCS_to_Grid.Images.SetKeyName(3, "dot_Grid_PCS_004.png");
            this.PCS_to_Grid.Images.SetKeyName(4, "dot_Grid_PCS_005.png");
            // 
            // PCS_to_Load
            // 
            this.PCS_to_Load.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PCS_to_Load.ImageStream")));
            this.PCS_to_Load.TransparentColor = System.Drawing.Color.Transparent;
            this.PCS_to_Load.Images.SetKeyName(0, "dot_LOAD_001.png");
            this.PCS_to_Load.Images.SetKeyName(1, "dot_LOAD_002.png");
            this.PCS_to_Load.Images.SetKeyName(2, "dot_LOAD_003.png");
            this.PCS_to_Load.Images.SetKeyName(3, "dot_LOAD_004.png");
            this.PCS_to_Load.Images.SetKeyName(4, "dot_LOAD_005.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb10
            // 
            this.lb10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb10.BackColor = System.Drawing.Color.Transparent;
            this.lb10.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb10.ForeColor = System.Drawing.Color.Black;
            this.lb10.Location = new System.Drawing.Point(482, 359);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(70, 12);
            this.lb10.TabIndex = 38;
            this.lb10.Text = "10.0 kW";
            this.lb10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb9
            // 
            this.lb9.BackColor = System.Drawing.Color.Transparent;
            this.lb9.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb9.ForeColor = System.Drawing.Color.Black;
            this.lb9.Location = new System.Drawing.Point(482, 331);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(70, 12);
            this.lb9.TabIndex = 37;
            this.lb9.Text = "10.0 kW";
            this.lb9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb13
            // 
            this.lb13.BackColor = System.Drawing.Color.Transparent;
            this.lb13.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb13.ForeColor = System.Drawing.Color.Black;
            this.lb13.Location = new System.Drawing.Point(590, 359);
            this.lb13.Name = "lb13";
            this.lb13.Size = new System.Drawing.Size(70, 12);
            this.lb13.TabIndex = 65;
            this.lb13.Text = "10.0 kW";
            this.lb13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb12
            // 
            this.lb12.BackColor = System.Drawing.Color.Transparent;
            this.lb12.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb12.ForeColor = System.Drawing.Color.Black;
            this.lb12.Location = new System.Drawing.Point(590, 331);
            this.lb12.Name = "lb12";
            this.lb12.Size = new System.Drawing.Size(70, 12);
            this.lb12.TabIndex = 64;
            this.lb12.Text = "10.0 kW";
            this.lb12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_ReCreate
            // 
            this.btn_ReCreate.Location = new System.Drawing.Point(539, 402);
            this.btn_ReCreate.Name = "btn_ReCreate";
            this.btn_ReCreate.Size = new System.Drawing.Size(116, 23);
            this.btn_ReCreate.TabIndex = 78;
            this.btn_ReCreate.Text = "Dispose";
            this.btn_ReCreate.UseVisualStyleBackColor = true;
            this.btn_ReCreate.Visible = false;
            this.btn_ReCreate.Click += new System.EventHandler(this.btn_ReCreate_Click);
            // 
            // lb_System_Status
            // 
            this.lb_System_Status.BackColor = System.Drawing.Color.Transparent;
            this.lb_System_Status.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_System_Status.Location = new System.Drawing.Point(419, 234);
            this.lb_System_Status.Name = "lb_System_Status";
            this.lb_System_Status.Size = new System.Drawing.Size(87, 12);
            this.lb_System_Status.TabIndex = 88;
            this.lb_System_Status.Text = "NORMAL";
            this.lb_System_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_System_Status.Click += new System.EventHandler(this.lb_System_Status_Click);
            // 
            // lb_PCS_System_Status
            // 
            this.lb_PCS_System_Status.BackColor = System.Drawing.Color.Transparent;
            this.lb_PCS_System_Status.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PCS_System_Status.Location = new System.Drawing.Point(630, 234);
            this.lb_PCS_System_Status.Name = "lb_PCS_System_Status";
            this.lb_PCS_System_Status.Size = new System.Drawing.Size(87, 12);
            this.lb_PCS_System_Status.TabIndex = 87;
            this.lb_PCS_System_Status.Text = "NORMAL";
            this.lb_PCS_System_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_PCS_System_Status.Click += new System.EventHandler(this.lb_PCS_System_Status_Click);
            // 
            // lb_Battery_Control_Authority
            // 
            this.lb_Battery_Control_Authority.BackColor = System.Drawing.Color.Transparent;
            this.lb_Battery_Control_Authority.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Battery_Control_Authority.Location = new System.Drawing.Point(419, 213);
            this.lb_Battery_Control_Authority.Name = "lb_Battery_Control_Authority";
            this.lb_Battery_Control_Authority.Size = new System.Drawing.Size(87, 12);
            this.lb_Battery_Control_Authority.TabIndex = 90;
            this.lb_Battery_Control_Authority.Text = "uPMS";
            this.lb_Battery_Control_Authority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_PCS_Control_Authority
            // 
            this.lb_PCS_Control_Authority.BackColor = System.Drawing.Color.Transparent;
            this.lb_PCS_Control_Authority.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PCS_Control_Authority.Location = new System.Drawing.Point(630, 213);
            this.lb_PCS_Control_Authority.Name = "lb_PCS_Control_Authority";
            this.lb_PCS_Control_Authority.Size = new System.Drawing.Size(87, 12);
            this.lb_PCS_Control_Authority.TabIndex = 89;
            this.lb_PCS_Control_Authority.Text = "uPMS";
            this.lb_PCS_Control_Authority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_PCS_Control_Authority.Click += new System.EventHandler(this.lb_PCS_Control_Authority_Click);
            // 
            // il_Battery_List
            // 
            this.il_Battery_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_Battery_List.ImageStream")));
            this.il_Battery_List.TransparentColor = System.Drawing.Color.Transparent;
            this.il_Battery_List.Images.SetKeyName(0, "alarm_battery_1.png");
            this.il_Battery_List.Images.SetKeyName(1, "alarm_battery_2.png");
            this.il_Battery_List.Images.SetKeyName(2, "alarm_battery_3.png");
            this.il_Battery_List.Images.SetKeyName(3, "alarm_battery_4.png");
            this.il_Battery_List.Images.SetKeyName(4, "alarm_battery_5.png");
            // 
            // pb_PCS_to_Load
            // 
            this.pb_PCS_to_Load.Image = global::KTE_PMS.Properties.Resources.dot_LOAD_001;
            this.pb_PCS_to_Load.Location = new System.Drawing.Point(723, 169);
            this.pb_PCS_to_Load.Name = "pb_PCS_to_Load";
            this.pb_PCS_to_Load.Size = new System.Drawing.Size(102, 73);
            this.pb_PCS_to_Load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PCS_to_Load.TabIndex = 96;
            this.pb_PCS_to_Load.TabStop = false;
            // 
            // pb_Battery
            // 
            this.pb_Battery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pb_Battery.Image = global::KTE_PMS.Properties.Resources.alarm_battery_5;
            this.pb_Battery.Location = new System.Drawing.Point(418, 87);
            this.pb_Battery.Name = "pb_Battery";
            this.pb_Battery.Size = new System.Drawing.Size(41, 97);
            this.pb_Battery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Battery.TabIndex = 95;
            this.pb_Battery.TabStop = false;
            this.pb_Battery.Click += new System.EventHandler(this.pb_Battery_Click);
            // 
            // pb_PCS_Abnormal
            // 
            this.pb_PCS_Abnormal.Image = global::KTE_PMS.Properties.Resources.lamp_off;
            this.pb_PCS_Abnormal.Location = new System.Drawing.Point(643, 71);
            this.pb_PCS_Abnormal.Name = "pb_PCS_Abnormal";
            this.pb_PCS_Abnormal.Size = new System.Drawing.Size(13, 13);
            this.pb_PCS_Abnormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PCS_Abnormal.TabIndex = 94;
            this.pb_PCS_Abnormal.TabStop = false;
            // 
            // pb_Battery_Abnormal
            // 
            this.pb_Battery_Abnormal.Image = global::KTE_PMS.Properties.Resources.lamp_off;
            this.pb_Battery_Abnormal.Location = new System.Drawing.Point(432, 70);
            this.pb_Battery_Abnormal.Name = "pb_Battery_Abnormal";
            this.pb_Battery_Abnormal.Size = new System.Drawing.Size(13, 13);
            this.pb_Battery_Abnormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Battery_Abnormal.TabIndex = 93;
            this.pb_Battery_Abnormal.TabStop = false;
            // 
            // btn_PCS_Control
            // 
            this.btn_PCS_Control.BackColor = System.Drawing.Color.Transparent;
            this.btn_PCS_Control.BackgroundImage = global::KTE_PMS.Properties.Resources.제어_off;
            this.btn_PCS_Control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_PCS_Control.FlatAppearance.BorderSize = 0;
            this.btn_PCS_Control.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_PCS_Control.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_PCS_Control.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PCS_Control.Location = new System.Drawing.Point(609, 253);
            this.btn_PCS_Control.Name = "btn_PCS_Control";
            this.btn_PCS_Control.Size = new System.Drawing.Size(93, 23);
            this.btn_PCS_Control.TabIndex = 92;
            this.btn_PCS_Control.UseVisualStyleBackColor = false;
            this.btn_PCS_Control.Click += new System.EventHandler(this.btn_PCS_Control_Click);
            this.btn_PCS_Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_PCS_Control_MouseDown);
            this.btn_PCS_Control.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_PCS_Control_MouseUp);
            // 
            // btn_Battery_Control
            // 
            this.btn_Battery_Control.BackColor = System.Drawing.Color.Transparent;
            this.btn_Battery_Control.BackgroundImage = global::KTE_PMS.Properties.Resources.제어_off;
            this.btn_Battery_Control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Battery_Control.FlatAppearance.BorderSize = 0;
            this.btn_Battery_Control.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Battery_Control.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Battery_Control.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Battery_Control.Location = new System.Drawing.Point(397, 253);
            this.btn_Battery_Control.Name = "btn_Battery_Control";
            this.btn_Battery_Control.Size = new System.Drawing.Size(93, 23);
            this.btn_Battery_Control.TabIndex = 91;
            this.btn_Battery_Control.UseVisualStyleBackColor = false;
            this.btn_Battery_Control.Click += new System.EventHandler(this.btn_Battery_Control_Click);
            this.btn_Battery_Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Battery_Control_MouseDown);
            this.btn_Battery_Control.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Battery_Control_MouseUp);
            // 
            // btn_LEMS
            // 
            this.btn_LEMS.BackColor = System.Drawing.Color.Transparent;
            this.btn_LEMS.BackgroundImage = global::KTE_PMS.Properties.Resources.LEMS_off;
            this.btn_LEMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_LEMS.FlatAppearance.BorderSize = 0;
            this.btn_LEMS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_LEMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_LEMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LEMS.Location = new System.Drawing.Point(180, 70);
            this.btn_LEMS.Name = "btn_LEMS";
            this.btn_LEMS.Size = new System.Drawing.Size(93, 26);
            this.btn_LEMS.TabIndex = 81;
            this.btn_LEMS.UseVisualStyleBackColor = false;
            this.btn_LEMS.Click += new System.EventHandler(this.btn_LEMS_Click);
            this.btn_LEMS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_LEMS_MouseDown);
            this.btn_LEMS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_LEMS_MouseUp);
            // 
            // btn_uPMS
            // 
            this.btn_uPMS.BackColor = System.Drawing.Color.Transparent;
            this.btn_uPMS.BackgroundImage = global::KTE_PMS.Properties.Resources.uPMS_off;
            this.btn_uPMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_uPMS.FlatAppearance.BorderSize = 0;
            this.btn_uPMS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_uPMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_uPMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uPMS.Location = new System.Drawing.Point(49, 72);
            this.btn_uPMS.Name = "btn_uPMS";
            this.btn_uPMS.Size = new System.Drawing.Size(93, 26);
            this.btn_uPMS.TabIndex = 80;
            this.btn_uPMS.UseVisualStyleBackColor = false;
            this.btn_uPMS.Click += new System.EventHandler(this.btn_uPMS_Click);
            this.btn_uPMS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_uPMS_MouseDown);
            this.btn_uPMS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_uPMS_MouseUp);
            // 
            // esS_Scheduler1
            // 
            this.esS_Scheduler1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("esS_Scheduler1.BackgroundImage")));
            this.esS_Scheduler1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.esS_Scheduler1.Location = new System.Drawing.Point(30, 281);
            this.esS_Scheduler1.Name = "esS_Scheduler1";
            this.esS_Scheduler1.Size = new System.Drawing.Size(269, 117);
            this.esS_Scheduler1.TabIndex = 79;
            this.esS_Scheduler1.Click += new System.EventHandler(this.esS_Scheduler1_Click);
            // 
            // btn_CustomMode
            // 
            this.btn_CustomMode.BackColor = System.Drawing.Color.Transparent;
            this.btn_CustomMode.BackgroundImage = global::KTE_PMS.Properties.Resources.사용자정의_off;
            this.btn_CustomMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_CustomMode.FlatAppearance.BorderSize = 0;
            this.btn_CustomMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CustomMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CustomMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CustomMode.Location = new System.Drawing.Point(233, 195);
            this.btn_CustomMode.Name = "btn_CustomMode";
            this.btn_CustomMode.Size = new System.Drawing.Size(54, 30);
            this.btn_CustomMode.TabIndex = 77;
            this.btn_CustomMode.UseVisualStyleBackColor = false;
            this.btn_CustomMode.Click += new System.EventHandler(this.btn_CustomMode_Click);
            this.btn_CustomMode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_CustomMode_MouseDown);
            this.btn_CustomMode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_CustomMode_MouseUp);
            // 
            // btn_PeakCutMode
            // 
            this.btn_PeakCutMode.BackColor = System.Drawing.Color.Transparent;
            this.btn_PeakCutMode.BackgroundImage = global::KTE_PMS.Properties.Resources.피크저감_off;
            this.btn_PeakCutMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_PeakCutMode.FlatAppearance.BorderSize = 0;
            this.btn_PeakCutMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_PeakCutMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_PeakCutMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PeakCutMode.Location = new System.Drawing.Point(38, 195);
            this.btn_PeakCutMode.Name = "btn_PeakCutMode";
            this.btn_PeakCutMode.Size = new System.Drawing.Size(54, 30);
            this.btn_PeakCutMode.TabIndex = 76;
            this.btn_PeakCutMode.UseVisualStyleBackColor = false;
            this.btn_PeakCutMode.Click += new System.EventHandler(this.btn_PeakCutMode_Click);
            this.btn_PeakCutMode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_PeakCutMode_MouseDown);
            this.btn_PeakCutMode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_PeakCutMode_MouseUp);
            // 
            // btn_DisChargingMode
            // 
            this.btn_DisChargingMode.BackColor = System.Drawing.Color.Transparent;
            this.btn_DisChargingMode.BackgroundImage = global::KTE_PMS.Properties.Resources.방전_off;
            this.btn_DisChargingMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_DisChargingMode.FlatAppearance.BorderSize = 0;
            this.btn_DisChargingMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_DisChargingMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_DisChargingMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DisChargingMode.Location = new System.Drawing.Point(168, 195);
            this.btn_DisChargingMode.Name = "btn_DisChargingMode";
            this.btn_DisChargingMode.Size = new System.Drawing.Size(54, 30);
            this.btn_DisChargingMode.TabIndex = 75;
            this.btn_DisChargingMode.UseVisualStyleBackColor = false;
            this.btn_DisChargingMode.Click += new System.EventHandler(this.btn_DisChargingMode_Click);
            this.btn_DisChargingMode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_DisChargingMode_MouseDown);
            this.btn_DisChargingMode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_DisChargingMode_MouseUp);
            // 
            // btn_ChargingMode
            // 
            this.btn_ChargingMode.BackColor = System.Drawing.Color.Transparent;
            this.btn_ChargingMode.BackgroundImage = global::KTE_PMS.Properties.Resources.충전_off;
            this.btn_ChargingMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ChargingMode.FlatAppearance.BorderSize = 0;
            this.btn_ChargingMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ChargingMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ChargingMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChargingMode.Location = new System.Drawing.Point(103, 195);
            this.btn_ChargingMode.Name = "btn_ChargingMode";
            this.btn_ChargingMode.Size = new System.Drawing.Size(54, 30);
            this.btn_ChargingMode.TabIndex = 74;
            this.btn_ChargingMode.UseVisualStyleBackColor = false;
            this.btn_ChargingMode.Click += new System.EventHandler(this.btn_ChargingMode_Click);
            this.btn_ChargingMode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_ChargingMode_MouseDown);
            this.btn_ChargingMode.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_ChargingMode_MouseUp);
            // 
            // pb_PCS_to_Grid
            // 
            this.pb_PCS_to_Grid.Image = global::KTE_PMS.Properties.Resources.dot_Grid_PCS_0011;
            this.pb_PCS_to_Grid.Location = new System.Drawing.Point(723, 95);
            this.pb_PCS_to_Grid.Name = "pb_PCS_to_Grid";
            this.pb_PCS_to_Grid.Size = new System.Drawing.Size(102, 73);
            this.pb_PCS_to_Grid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PCS_to_Grid.TabIndex = 36;
            this.pb_PCS_to_Grid.TabStop = false;
            // 
            // pb_Battery_to_PCS
            // 
            this.pb_Battery_to_PCS.Image = global::KTE_PMS.Properties.Resources.dot_battery_PCS_001;
            this.pb_Battery_to_PCS.Location = new System.Drawing.Point(492, 119);
            this.pb_Battery_to_PCS.Name = "pb_Battery_to_PCS";
            this.pb_Battery_to_PCS.Size = new System.Drawing.Size(102, 34);
            this.pb_Battery_to_PCS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Battery_to_PCS.TabIndex = 31;
            this.pb_Battery_to_PCS.TabStop = false;
            // 
            // MainViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.BackgroundImage = global::KTE_PMS.Properties.Resources.Main1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pb_PCS_to_Load);
            this.Controls.Add(this.pb_Battery);
            this.Controls.Add(this.pb_PCS_Abnormal);
            this.Controls.Add(this.pb_Battery_Abnormal);
            this.Controls.Add(this.btn_PCS_Control);
            this.Controls.Add(this.btn_Battery_Control);
            this.Controls.Add(this.lb_Battery_Control_Authority);
            this.Controls.Add(this.lb_PCS_Control_Authority);
            this.Controls.Add(this.lb_System_Status);
            this.Controls.Add(this.lb_PCS_System_Status);
            this.Controls.Add(this.btn_LEMS);
            this.Controls.Add(this.btn_uPMS);
            this.Controls.Add(this.esS_Scheduler1);
            this.Controls.Add(this.btn_ReCreate);
            this.Controls.Add(this.btn_CustomMode);
            this.Controls.Add(this.btn_PeakCutMode);
            this.Controls.Add(this.btn_DisChargingMode);
            this.Controls.Add(this.btn_ChargingMode);
            this.Controls.Add(this.lb13);
            this.Controls.Add(this.lb12);
            this.Controls.Add(this.lb10);
            this.Controls.Add(this.lb9);
            this.Controls.Add(this.pb_PCS_to_Grid);
            this.Controls.Add(this.pb_Battery_to_PCS);
            this.Controls.Add(this.lb8);
            this.Controls.Add(this.lb7);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MainViewer";
            this.Load += new System.EventHandler(this.MainViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_PCS_to_Load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Battery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PCS_Abnormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Battery_Abnormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PCS_to_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Battery_to_PCS)).EndInit();
            this.ResumeLayout(false);

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

        private ESS_Scheduler esS_Scheduler1;
        private System.Windows.Forms.Button btn_uPMS;
        private System.Windows.Forms.Button btn_LEMS;
        private System.Windows.Forms.Label lb_System_Status;
        private System.Windows.Forms.Label lb_PCS_System_Status;
        private System.Windows.Forms.Label lb_Battery_Control_Authority;
        private System.Windows.Forms.Label lb_PCS_Control_Authority;
        private System.Windows.Forms.Button btn_Battery_Control;
        private System.Windows.Forms.Button btn_PCS_Control;
        private System.Windows.Forms.PictureBox pb_Battery_Abnormal;
        private System.Windows.Forms.PictureBox pb_PCS_Abnormal;
        private System.Windows.Forms.ImageList il_Battery_List;
        private System.Windows.Forms.PictureBox pb_Battery;
        private System.Windows.Forms.PictureBox pb_PCS_to_Load;
    }
}
