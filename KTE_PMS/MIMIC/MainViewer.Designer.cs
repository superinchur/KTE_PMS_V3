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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.Label lb11;
        private System.Windows.Forms.Label lb12;
        private System.Windows.Forms.Label lb13;
        private System.Windows.Forms.Label lb14;
        private System.Windows.Forms.Label lb15;
        private System.Windows.Forms.Label lb16;
        private System.Windows.Forms.Label lb17;
        private System.Windows.Forms.Label lb18;
        private System.Windows.Forms.Label lb19;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb20;
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
            this.pb_Battery_to_PCS = new System.Windows.Forms.PictureBox();
            this.PCS_to_Load = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pb_PCS_to_Grid = new System.Windows.Forms.PictureBox();
            this.lb11 = new System.Windows.Forms.Label();
            this.lb10 = new System.Windows.Forms.Label();
            this.lb9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lb17 = new System.Windows.Forms.Label();
            this.lb16 = new System.Windows.Forms.Label();
            this.lb15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb20 = new System.Windows.Forms.Label();
            this.lb19 = new System.Windows.Forms.Label();
            this.lb18 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lb14 = new System.Windows.Forms.Label();
            this.lb13 = new System.Windows.Forms.Label();
            this.lb12 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.btn_ChargingMode = new System.Windows.Forms.Button();
            this.btn_DisChargingMode = new System.Windows.Forms.Button();
            this.btn_CustomMode = new System.Windows.Forms.Button();
            this.btn_ReCreate = new System.Windows.Forms.Button();
            this.btn_PeakCutMode = new System.Windows.Forms.Button();
            this.btn_uPMS = new System.Windows.Forms.Button();
            this.btn_LEMS = new System.Windows.Forms.Button();
            this.lb_System_Status = new System.Windows.Forms.Label();
            this.lb_PCS_System_Status = new System.Windows.Forms.Label();
            this.esS_Scheduler1 = new KTE_PMS.ESS_Scheduler();
            this.lb_Battery_Control_Authority = new System.Windows.Forms.Label();
            this.lb_PCS_Control_Authority = new System.Windows.Forms.Label();
            this.btn_Battery_Control = new System.Windows.Forms.Button();
            this.btn_PCS_Control = new System.Windows.Forms.Button();
            this.pb_Battery_Abnormal = new System.Windows.Forms.PictureBox();
            this.pb_PCS_Abnormal = new System.Windows.Forms.PictureBox();
            this.il_Battery_List = new System.Windows.Forms.ImageList(this.components);
            this.pb_Battery = new System.Windows.Forms.PictureBox();
            this.pb_PCS_to_Load = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Battery_to_PCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PCS_to_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Battery_Abnormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PCS_Abnormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Battery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PCS_to_Load)).BeginInit();
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
            this.lb8.Location = new System.Drawing.Point(837, 235);
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
            this.lb7.Location = new System.Drawing.Point(837, 219);
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
            this.lb6.Location = new System.Drawing.Point(837, 204);
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
            this.lb5.Location = new System.Drawing.Point(837, 188);
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
            // pb_Battery_to_PCS
            // 
            this.pb_Battery_to_PCS.Image = global::KTE_PMS.Properties.Resources.dot_battery_PCS_001;
            this.pb_Battery_to_PCS.Location = new System.Drawing.Point(502, 164);
            this.pb_Battery_to_PCS.Name = "pb_Battery_to_PCS";
            this.pb_Battery_to_PCS.Size = new System.Drawing.Size(102, 34);
            this.pb_Battery_to_PCS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Battery_to_PCS.TabIndex = 31;
            this.pb_Battery_to_PCS.TabStop = false;
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
            // pb_PCS_to_Grid
            // 
            this.pb_PCS_to_Grid.Image = global::KTE_PMS.Properties.Resources.dot_Grid_PCS_0011;
            this.pb_PCS_to_Grid.Location = new System.Drawing.Point(733, 95);
            this.pb_PCS_to_Grid.Name = "pb_PCS_to_Grid";
            this.pb_PCS_to_Grid.Size = new System.Drawing.Size(102, 73);
            this.pb_PCS_to_Grid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PCS_to_Grid.TabIndex = 36;
            this.pb_PCS_to_Grid.TabStop = false;
            // 
            // lb11
            // 
            this.lb11.BackColor = System.Drawing.Color.Transparent;
            this.lb11.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb11.ForeColor = System.Drawing.Color.Black;
            this.lb11.Location = new System.Drawing.Point(356, 382);
            this.lb11.Name = "lb11";
            this.lb11.Size = new System.Drawing.Size(51, 17);
            this.lb11.TabIndex = 39;
            this.lb11.Text = "12.34 ";
            this.lb11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb11.Visible = false;
            // 
            // lb10
            // 
            this.lb10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb10.BackColor = System.Drawing.Color.Transparent;
            this.lb10.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb10.ForeColor = System.Drawing.Color.Black;
            this.lb10.Location = new System.Drawing.Point(356, 362);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(51, 17);
            this.lb10.TabIndex = 38;
            this.lb10.Text = "12.34 ";
            this.lb10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb10.Visible = false;
            // 
            // lb9
            // 
            this.lb9.BackColor = System.Drawing.Color.Transparent;
            this.lb9.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb9.ForeColor = System.Drawing.Color.Black;
            this.lb9.Location = new System.Drawing.Point(356, 344);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(51, 17);
            this.lb9.TabIndex = 37;
            this.lb9.Text = "12.34 ";
            this.lb9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb9.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(322, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 14);
            this.label7.TabIndex = 43;
            this.label7.Text = "일별 :";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(320, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 14);
            this.label8.TabIndex = 44;
            this.label8.Text = "월별 :";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(320, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 14);
            this.label9.TabIndex = 45;
            this.label9.Text = "년별 :";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(410, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 14);
            this.label10.TabIndex = 48;
            this.label10.Text = "kW";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(410, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 14);
            this.label11.TabIndex = 47;
            this.label11.Text = "kW";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(410, 347);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 14);
            this.label12.TabIndex = 46;
            this.label12.Text = "kW";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(730, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 14);
            this.label13.TabIndex = 57;
            this.label13.Text = "kW";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(730, 366);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 14);
            this.label14.TabIndex = 56;
            this.label14.Text = "kW";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(730, 347);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 14);
            this.label15.TabIndex = 55;
            this.label15.Text = "kW";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(618, 383);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 14);
            this.label16.TabIndex = 54;
            this.label16.Text = "년별 :";
            this.label16.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(618, 366);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 14);
            this.label17.TabIndex = 53;
            this.label17.Text = "월별 :";
            this.label17.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(618, 347);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 14);
            this.label18.TabIndex = 52;
            this.label18.Text = "일별 :";
            this.label18.Visible = false;
            // 
            // lb17
            // 
            this.lb17.BackColor = System.Drawing.Color.Transparent;
            this.lb17.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb17.ForeColor = System.Drawing.Color.Black;
            this.lb17.Location = new System.Drawing.Point(677, 380);
            this.lb17.Name = "lb17";
            this.lb17.Size = new System.Drawing.Size(51, 17);
            this.lb17.TabIndex = 51;
            this.lb17.Text = "12.34 ";
            this.lb17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb17.Visible = false;
            // 
            // lb16
            // 
            this.lb16.BackColor = System.Drawing.Color.Transparent;
            this.lb16.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb16.ForeColor = System.Drawing.Color.Black;
            this.lb16.Location = new System.Drawing.Point(677, 362);
            this.lb16.Name = "lb16";
            this.lb16.Size = new System.Drawing.Size(51, 17);
            this.lb16.TabIndex = 50;
            this.lb16.Text = "12.34 ";
            this.lb16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb16.Visible = false;
            // 
            // lb15
            // 
            this.lb15.BackColor = System.Drawing.Color.Transparent;
            this.lb15.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb15.ForeColor = System.Drawing.Color.Black;
            this.lb15.Location = new System.Drawing.Point(677, 344);
            this.lb15.Name = "lb15";
            this.lb15.Size = new System.Drawing.Size(51, 17);
            this.lb15.TabIndex = 49;
            this.lb15.Text = "12.34 ";
            this.lb15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb15.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(818, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 14);
            this.label4.TabIndex = 63;
            this.label4.Text = "kW";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(818, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 14);
            this.label5.TabIndex = 62;
            this.label5.Text = "kW";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(818, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 14);
            this.label6.TabIndex = 61;
            this.label6.Text = "kW";
            this.label6.Visible = false;
            // 
            // lb20
            // 
            this.lb20.BackColor = System.Drawing.Color.Transparent;
            this.lb20.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb20.ForeColor = System.Drawing.Color.Black;
            this.lb20.Location = new System.Drawing.Point(764, 380);
            this.lb20.Name = "lb20";
            this.lb20.Size = new System.Drawing.Size(51, 17);
            this.lb20.TabIndex = 60;
            this.lb20.Text = "12.34 ";
            this.lb20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb20.Visible = false;
            // 
            // lb19
            // 
            this.lb19.BackColor = System.Drawing.Color.Transparent;
            this.lb19.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb19.ForeColor = System.Drawing.Color.Black;
            this.lb19.Location = new System.Drawing.Point(764, 362);
            this.lb19.Name = "lb19";
            this.lb19.Size = new System.Drawing.Size(51, 17);
            this.lb19.TabIndex = 59;
            this.lb19.Text = "12.34 ";
            this.lb19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb19.Visible = false;
            // 
            // lb18
            // 
            this.lb18.BackColor = System.Drawing.Color.Transparent;
            this.lb18.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb18.ForeColor = System.Drawing.Color.Black;
            this.lb18.Location = new System.Drawing.Point(764, 344);
            this.lb18.Name = "lb18";
            this.lb18.Size = new System.Drawing.Size(51, 17);
            this.lb18.TabIndex = 58;
            this.lb18.Text = "12.34 ";
            this.lb18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb18.Visible = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(489, 383);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(25, 14);
            this.label25.TabIndex = 69;
            this.label25.Text = "kW";
            this.label25.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(489, 366);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(25, 14);
            this.label26.TabIndex = 68;
            this.label26.Text = "kW";
            this.label26.Visible = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(489, 347);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(25, 14);
            this.label27.TabIndex = 67;
            this.label27.Text = "kW";
            this.label27.Visible = false;
            // 
            // lb14
            // 
            this.lb14.BackColor = System.Drawing.Color.Transparent;
            this.lb14.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb14.ForeColor = System.Drawing.Color.Black;
            this.lb14.Location = new System.Drawing.Point(436, 382);
            this.lb14.Name = "lb14";
            this.lb14.Size = new System.Drawing.Size(51, 17);
            this.lb14.TabIndex = 66;
            this.lb14.Text = "12.34 ";
            this.lb14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb14.Visible = false;
            // 
            // lb13
            // 
            this.lb13.BackColor = System.Drawing.Color.Transparent;
            this.lb13.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb13.ForeColor = System.Drawing.Color.Black;
            this.lb13.Location = new System.Drawing.Point(436, 362);
            this.lb13.Name = "lb13";
            this.lb13.Size = new System.Drawing.Size(51, 17);
            this.lb13.TabIndex = 65;
            this.lb13.Text = "12.34 ";
            this.lb13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb13.Visible = false;
            // 
            // lb12
            // 
            this.lb12.BackColor = System.Drawing.Color.Transparent;
            this.lb12.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb12.ForeColor = System.Drawing.Color.Black;
            this.lb12.Location = new System.Drawing.Point(436, 344);
            this.lb12.Name = "lb12";
            this.lb12.Size = new System.Drawing.Size(51, 17);
            this.lb12.TabIndex = 64;
            this.lb12.Text = "12.34 ";
            this.lb12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb12.Visible = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(369, 328);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(29, 14);
            this.label31.TabIndex = 70;
            this.label31.Text = "충전";
            this.label31.Visible = false;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(448, 328);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(29, 14);
            this.label32.TabIndex = 71;
            this.label32.Text = "방전";
            this.label32.Visible = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Location = new System.Drawing.Point(777, 328);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(29, 14);
            this.label33.TabIndex = 73;
            this.label33.Text = "방전";
            this.label33.Visible = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(689, 328);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(29, 14);
            this.label34.TabIndex = 72;
            this.label34.Text = "충전";
            this.label34.Visible = false;
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
            // lb_System_Status
            // 
            this.lb_System_Status.BackColor = System.Drawing.Color.Transparent;
            this.lb_System_Status.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_System_Status.Location = new System.Drawing.Point(430, 255);
            this.lb_System_Status.Name = "lb_System_Status";
            this.lb_System_Status.Size = new System.Drawing.Size(87, 14);
            this.lb_System_Status.TabIndex = 88;
            this.lb_System_Status.Text = "NORMAL";
            this.lb_System_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_PCS_System_Status
            // 
            this.lb_PCS_System_Status.BackColor = System.Drawing.Color.Transparent;
            this.lb_PCS_System_Status.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PCS_System_Status.Location = new System.Drawing.Point(641, 255);
            this.lb_PCS_System_Status.Name = "lb_PCS_System_Status";
            this.lb_PCS_System_Status.Size = new System.Drawing.Size(87, 14);
            this.lb_PCS_System_Status.TabIndex = 87;
            this.lb_PCS_System_Status.Text = "NORMAL";
            this.lb_PCS_System_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Battery_Control_Authority
            // 
            this.lb_Battery_Control_Authority.BackColor = System.Drawing.Color.Transparent;
            this.lb_Battery_Control_Authority.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Battery_Control_Authority.Location = new System.Drawing.Point(430, 234);
            this.lb_Battery_Control_Authority.Name = "lb_Battery_Control_Authority";
            this.lb_Battery_Control_Authority.Size = new System.Drawing.Size(87, 14);
            this.lb_Battery_Control_Authority.TabIndex = 90;
            this.lb_Battery_Control_Authority.Text = "uPMS";
            this.lb_Battery_Control_Authority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_PCS_Control_Authority
            // 
            this.lb_PCS_Control_Authority.BackColor = System.Drawing.Color.Transparent;
            this.lb_PCS_Control_Authority.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PCS_Control_Authority.Location = new System.Drawing.Point(641, 234);
            this.lb_PCS_Control_Authority.Name = "lb_PCS_Control_Authority";
            this.lb_PCS_Control_Authority.Size = new System.Drawing.Size(87, 14);
            this.lb_PCS_Control_Authority.TabIndex = 89;
            this.lb_PCS_Control_Authority.Text = "uPMS";
            this.lb_PCS_Control_Authority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_Battery_Control.Location = new System.Drawing.Point(400, 272);
            this.btn_Battery_Control.Name = "btn_Battery_Control";
            this.btn_Battery_Control.Size = new System.Drawing.Size(93, 23);
            this.btn_Battery_Control.TabIndex = 91;
            this.btn_Battery_Control.UseVisualStyleBackColor = false;
            this.btn_Battery_Control.Click += new System.EventHandler(this.btn_Battery_Control_Click);
            this.btn_Battery_Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Battery_Control_MouseDown);
            this.btn_Battery_Control.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Battery_Control_MouseUp);
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
            this.btn_PCS_Control.Location = new System.Drawing.Point(612, 272);
            this.btn_PCS_Control.Name = "btn_PCS_Control";
            this.btn_PCS_Control.Size = new System.Drawing.Size(93, 23);
            this.btn_PCS_Control.TabIndex = 92;
            this.btn_PCS_Control.UseVisualStyleBackColor = false;
            this.btn_PCS_Control.Click += new System.EventHandler(this.btn_PCS_Control_Click);
            this.btn_PCS_Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_PCS_Control_MouseDown);
            this.btn_PCS_Control.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_PCS_Control_MouseUp);
            // 
            // pb_Battery_Abnormal
            // 
            this.pb_Battery_Abnormal.Image = global::KTE_PMS.Properties.Resources.lamp_off;
            this.pb_Battery_Abnormal.Location = new System.Drawing.Point(440, 105);
            this.pb_Battery_Abnormal.Name = "pb_Battery_Abnormal";
            this.pb_Battery_Abnormal.Size = new System.Drawing.Size(13, 13);
            this.pb_Battery_Abnormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Battery_Abnormal.TabIndex = 93;
            this.pb_Battery_Abnormal.TabStop = false;
            // 
            // pb_PCS_Abnormal
            // 
            this.pb_PCS_Abnormal.Image = global::KTE_PMS.Properties.Resources.lamp_off;
            this.pb_PCS_Abnormal.Location = new System.Drawing.Point(652, 105);
            this.pb_PCS_Abnormal.Name = "pb_PCS_Abnormal";
            this.pb_PCS_Abnormal.Size = new System.Drawing.Size(13, 13);
            this.pb_PCS_Abnormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PCS_Abnormal.TabIndex = 94;
            this.pb_PCS_Abnormal.TabStop = false;
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
            // pb_Battery
            // 
            this.pb_Battery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pb_Battery.Image = global::KTE_PMS.Properties.Resources.alarm_battery_5;
            this.pb_Battery.Location = new System.Drawing.Point(425, 124);
            this.pb_Battery.Name = "pb_Battery";
            this.pb_Battery.Size = new System.Drawing.Size(41, 97);
            this.pb_Battery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Battery.TabIndex = 95;
            this.pb_Battery.TabStop = false;
            // 
            // pb_PCS_to_Load
            // 
            this.pb_PCS_to_Load.Image = global::KTE_PMS.Properties.Resources.dot_LOAD_001;
            this.pb_PCS_to_Load.Location = new System.Drawing.Point(733, 252);
            this.pb_PCS_to_Load.Name = "pb_PCS_to_Load";
            this.pb_PCS_to_Load.Size = new System.Drawing.Size(102, 73);
            this.pb_PCS_to_Load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PCS_to_Load.TabIndex = 96;
            this.pb_PCS_to_Load.TabStop = false;
            // 
            // MainViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
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
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.lb14);
            this.Controls.Add(this.lb13);
            this.Controls.Add(this.lb12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb20);
            this.Controls.Add(this.lb19);
            this.Controls.Add(this.lb18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lb17);
            this.Controls.Add(this.lb16);
            this.Controls.Add(this.lb15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb11);
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_Battery_to_PCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PCS_to_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Battery_Abnormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PCS_Abnormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Battery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PCS_to_Load)).EndInit();
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
