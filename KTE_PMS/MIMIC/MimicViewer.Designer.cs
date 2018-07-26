namespace KTE_PMS.MIMIC
{
    partial class MimicViewer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MimicViewer));
            this.lbGRID_R_VOLTAGE = new System.Windows.Forms.Label();
            this.lbGRID_S_VOLTAGE = new System.Windows.Forms.Label();
            this.lbGRID_T_VOLTAGE = new System.Windows.Forms.Label();
            this.lbGRID_R_CURRENT = new System.Windows.Forms.Label();
            this.lbGRID_S_CURRENT = new System.Windows.Forms.Label();
            this.lbGRID_T_CURRENT = new System.Windows.Forms.Label();
            this.lbGRID_Frequency = new System.Windows.Forms.Label();
            this.lbGRID_POWER = new System.Windows.Forms.Label();
            this.lbLOAD_POWER = new System.Windows.Forms.Label();
            this.lbLOAD_R_CURRENT = new System.Windows.Forms.Label();
            this.lbLOAD_S_CURRENT = new System.Windows.Forms.Label();
            this.lbLOAD_T_CURRENT = new System.Windows.Forms.Label();
            this.pb_PCS_Abnormal = new System.Windows.Forms.PictureBox();
            this.pb_Battery_Abnormal = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_Battery_SOC = new System.Windows.Forms.Label();
            this.lb_Battery_SOH = new System.Windows.Forms.Label();
            this.lb_Battery_Current = new System.Windows.Forms.Label();
            this.lb_Battery_Voltage = new System.Windows.Forms.Label();
            this.lb_Battery_Power = new System.Windows.Forms.Label();
            this.lb_System_Status = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lb_PCS_Control_Authority = new System.Windows.Forms.Label();
            this.lb_PCS_System_Status = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PCS_Abnormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Battery_Abnormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGRID_R_VOLTAGE
            // 
            this.lbGRID_R_VOLTAGE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbGRID_R_VOLTAGE.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbGRID_R_VOLTAGE.ForeColor = System.Drawing.Color.Black;
            this.lbGRID_R_VOLTAGE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbGRID_R_VOLTAGE.Location = new System.Drawing.Point(233, 47);
            this.lbGRID_R_VOLTAGE.Name = "lbGRID_R_VOLTAGE";
            this.lbGRID_R_VOLTAGE.Size = new System.Drawing.Size(60, 12);
            this.lbGRID_R_VOLTAGE.TabIndex = 94;
            this.lbGRID_R_VOLTAGE.Text = "### V";
            this.lbGRID_R_VOLTAGE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbGRID_S_VOLTAGE
            // 
            this.lbGRID_S_VOLTAGE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbGRID_S_VOLTAGE.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbGRID_S_VOLTAGE.ForeColor = System.Drawing.Color.Black;
            this.lbGRID_S_VOLTAGE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbGRID_S_VOLTAGE.Location = new System.Drawing.Point(301, 47);
            this.lbGRID_S_VOLTAGE.Name = "lbGRID_S_VOLTAGE";
            this.lbGRID_S_VOLTAGE.Size = new System.Drawing.Size(60, 12);
            this.lbGRID_S_VOLTAGE.TabIndex = 96;
            this.lbGRID_S_VOLTAGE.Text = "### V";
            this.lbGRID_S_VOLTAGE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbGRID_T_VOLTAGE
            // 
            this.lbGRID_T_VOLTAGE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbGRID_T_VOLTAGE.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbGRID_T_VOLTAGE.ForeColor = System.Drawing.Color.Black;
            this.lbGRID_T_VOLTAGE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbGRID_T_VOLTAGE.Location = new System.Drawing.Point(369, 47);
            this.lbGRID_T_VOLTAGE.Name = "lbGRID_T_VOLTAGE";
            this.lbGRID_T_VOLTAGE.Size = new System.Drawing.Size(60, 12);
            this.lbGRID_T_VOLTAGE.TabIndex = 97;
            this.lbGRID_T_VOLTAGE.Text = "### V";
            this.lbGRID_T_VOLTAGE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbGRID_R_CURRENT
            // 
            this.lbGRID_R_CURRENT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbGRID_R_CURRENT.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbGRID_R_CURRENT.ForeColor = System.Drawing.Color.Black;
            this.lbGRID_R_CURRENT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbGRID_R_CURRENT.Location = new System.Drawing.Point(233, 73);
            this.lbGRID_R_CURRENT.Name = "lbGRID_R_CURRENT";
            this.lbGRID_R_CURRENT.Size = new System.Drawing.Size(60, 12);
            this.lbGRID_R_CURRENT.TabIndex = 109;
            this.lbGRID_R_CURRENT.Text = "## A";
            this.lbGRID_R_CURRENT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbGRID_S_CURRENT
            // 
            this.lbGRID_S_CURRENT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbGRID_S_CURRENT.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbGRID_S_CURRENT.ForeColor = System.Drawing.Color.Black;
            this.lbGRID_S_CURRENT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbGRID_S_CURRENT.Location = new System.Drawing.Point(301, 73);
            this.lbGRID_S_CURRENT.Name = "lbGRID_S_CURRENT";
            this.lbGRID_S_CURRENT.Size = new System.Drawing.Size(60, 12);
            this.lbGRID_S_CURRENT.TabIndex = 110;
            this.lbGRID_S_CURRENT.Text = "## A";
            this.lbGRID_S_CURRENT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbGRID_T_CURRENT
            // 
            this.lbGRID_T_CURRENT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbGRID_T_CURRENT.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbGRID_T_CURRENT.ForeColor = System.Drawing.Color.Black;
            this.lbGRID_T_CURRENT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbGRID_T_CURRENT.Location = new System.Drawing.Point(370, 73);
            this.lbGRID_T_CURRENT.Name = "lbGRID_T_CURRENT";
            this.lbGRID_T_CURRENT.Size = new System.Drawing.Size(60, 12);
            this.lbGRID_T_CURRENT.TabIndex = 111;
            this.lbGRID_T_CURRENT.Text = "## A";
            this.lbGRID_T_CURRENT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbGRID_Frequency
            // 
            this.lbGRID_Frequency.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbGRID_Frequency.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbGRID_Frequency.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbGRID_Frequency.ForeColor = System.Drawing.Color.Black;
            this.lbGRID_Frequency.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbGRID_Frequency.Location = new System.Drawing.Point(375, 109);
            this.lbGRID_Frequency.Name = "lbGRID_Frequency";
            this.lbGRID_Frequency.Size = new System.Drawing.Size(60, 12);
            this.lbGRID_Frequency.TabIndex = 105;
            this.lbGRID_Frequency.Text = "## Hz";
            this.lbGRID_Frequency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbGRID_POWER
            // 
            this.lbGRID_POWER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbGRID_POWER.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbGRID_POWER.ForeColor = System.Drawing.Color.Black;
            this.lbGRID_POWER.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbGRID_POWER.Location = new System.Drawing.Point(234, 109);
            this.lbGRID_POWER.Name = "lbGRID_POWER";
            this.lbGRID_POWER.Size = new System.Drawing.Size(60, 12);
            this.lbGRID_POWER.TabIndex = 103;
            this.lbGRID_POWER.Text = "## kW";
            this.lbGRID_POWER.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLOAD_POWER
            // 
            this.lbLOAD_POWER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbLOAD_POWER.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLOAD_POWER.ForeColor = System.Drawing.Color.Black;
            this.lbLOAD_POWER.Location = new System.Drawing.Point(235, 266);
            this.lbLOAD_POWER.Name = "lbLOAD_POWER";
            this.lbLOAD_POWER.Size = new System.Drawing.Size(60, 12);
            this.lbLOAD_POWER.TabIndex = 101;
            this.lbLOAD_POWER.Text = "## kW";
            this.lbLOAD_POWER.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLOAD_R_CURRENT
            // 
            this.lbLOAD_R_CURRENT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbLOAD_R_CURRENT.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLOAD_R_CURRENT.ForeColor = System.Drawing.Color.Black;
            this.lbLOAD_R_CURRENT.Location = new System.Drawing.Point(234, 229);
            this.lbLOAD_R_CURRENT.Name = "lbLOAD_R_CURRENT";
            this.lbLOAD_R_CURRENT.Size = new System.Drawing.Size(60, 12);
            this.lbLOAD_R_CURRENT.TabIndex = 94;
            this.lbLOAD_R_CURRENT.Text = "## kW";
            this.lbLOAD_R_CURRENT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLOAD_S_CURRENT
            // 
            this.lbLOAD_S_CURRENT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbLOAD_S_CURRENT.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLOAD_S_CURRENT.ForeColor = System.Drawing.Color.Black;
            this.lbLOAD_S_CURRENT.Location = new System.Drawing.Point(302, 229);
            this.lbLOAD_S_CURRENT.Name = "lbLOAD_S_CURRENT";
            this.lbLOAD_S_CURRENT.Size = new System.Drawing.Size(60, 12);
            this.lbLOAD_S_CURRENT.TabIndex = 96;
            this.lbLOAD_S_CURRENT.Text = "## kW";
            this.lbLOAD_S_CURRENT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLOAD_T_CURRENT
            // 
            this.lbLOAD_T_CURRENT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbLOAD_T_CURRENT.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLOAD_T_CURRENT.ForeColor = System.Drawing.Color.Black;
            this.lbLOAD_T_CURRENT.Location = new System.Drawing.Point(371, 229);
            this.lbLOAD_T_CURRENT.Name = "lbLOAD_T_CURRENT";
            this.lbLOAD_T_CURRENT.Size = new System.Drawing.Size(60, 12);
            this.lbLOAD_T_CURRENT.TabIndex = 97;
            this.lbLOAD_T_CURRENT.Text = "## kW";
            this.lbLOAD_T_CURRENT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pb_PCS_Abnormal
            // 
            this.pb_PCS_Abnormal.Image = global::KTE_PMS.Properties.Resources.lamp_off;
            this.pb_PCS_Abnormal.Location = new System.Drawing.Point(786, 96);
            this.pb_PCS_Abnormal.Name = "pb_PCS_Abnormal";
            this.pb_PCS_Abnormal.Size = new System.Drawing.Size(13, 13);
            this.pb_PCS_Abnormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_PCS_Abnormal.TabIndex = 133;
            this.pb_PCS_Abnormal.TabStop = false;
            // 
            // pb_Battery_Abnormal
            // 
            this.pb_Battery_Abnormal.Image = global::KTE_PMS.Properties.Resources.lamp_off;
            this.pb_Battery_Abnormal.Location = new System.Drawing.Point(476, 96);
            this.pb_Battery_Abnormal.Name = "pb_Battery_Abnormal";
            this.pb_Battery_Abnormal.Size = new System.Drawing.Size(13, 13);
            this.pb_Battery_Abnormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Battery_Abnormal.TabIndex = 132;
            this.pb_Battery_Abnormal.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(718, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 134;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(718, 306);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 135;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(718, 343);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(141, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 136;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(718, 232);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(141, 31);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 139;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(721, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 140;
            this.label1.Text = "운전상태";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(724, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 141;
            this.label2.Text = "전력";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(724, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 142;
            this.label3.Text = "전압";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(724, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 143;
            this.label4.Text = "전류";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label5.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(672, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 144;
            this.label5.Text = "SOC";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(671, 380);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(112, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 145;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(789, 380);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(112, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 146;
            this.pictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label6.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(794, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 12);
            this.label6.TabIndex = 147;
            this.label6.Text = "SOH";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Battery_SOC
            // 
            this.lb_Battery_SOC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lb_Battery_SOC.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Battery_SOC.ForeColor = System.Drawing.Color.Black;
            this.lb_Battery_SOC.Location = new System.Drawing.Point(722, 388);
            this.lb_Battery_SOC.Name = "lb_Battery_SOC";
            this.lb_Battery_SOC.Size = new System.Drawing.Size(60, 12);
            this.lb_Battery_SOC.TabIndex = 152;
            this.lb_Battery_SOC.Text = "80.5%";
            this.lb_Battery_SOC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_Battery_SOH
            // 
            this.lb_Battery_SOH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lb_Battery_SOH.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Battery_SOH.ForeColor = System.Drawing.Color.Black;
            this.lb_Battery_SOH.Location = new System.Drawing.Point(838, 388);
            this.lb_Battery_SOH.Name = "lb_Battery_SOH";
            this.lb_Battery_SOH.Size = new System.Drawing.Size(60, 12);
            this.lb_Battery_SOH.TabIndex = 153;
            this.lb_Battery_SOH.Text = "96.0%";
            this.lb_Battery_SOH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_Battery_Current
            // 
            this.lb_Battery_Current.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lb_Battery_Current.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Battery_Current.ForeColor = System.Drawing.Color.Black;
            this.lb_Battery_Current.Location = new System.Drawing.Point(779, 352);
            this.lb_Battery_Current.Name = "lb_Battery_Current";
            this.lb_Battery_Current.Size = new System.Drawing.Size(70, 12);
            this.lb_Battery_Current.TabIndex = 151;
            this.lb_Battery_Current.Text = "50 A";
            this.lb_Battery_Current.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_Battery_Voltage
            // 
            this.lb_Battery_Voltage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lb_Battery_Voltage.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Battery_Voltage.ForeColor = System.Drawing.Color.Black;
            this.lb_Battery_Voltage.Location = new System.Drawing.Point(779, 314);
            this.lb_Battery_Voltage.Name = "lb_Battery_Voltage";
            this.lb_Battery_Voltage.Size = new System.Drawing.Size(70, 12);
            this.lb_Battery_Voltage.TabIndex = 150;
            this.lb_Battery_Voltage.Text = "830 V";
            this.lb_Battery_Voltage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_Battery_Power
            // 
            this.lb_Battery_Power.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lb_Battery_Power.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Battery_Power.ForeColor = System.Drawing.Color.Black;
            this.lb_Battery_Power.Location = new System.Drawing.Point(779, 277);
            this.lb_Battery_Power.Name = "lb_Battery_Power";
            this.lb_Battery_Power.Size = new System.Drawing.Size(70, 12);
            this.lb_Battery_Power.TabIndex = 149;
            this.lb_Battery_Power.Text = "100 kW";
            this.lb_Battery_Power.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_System_Status
            // 
            this.lb_System_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lb_System_Status.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_System_Status.ForeColor = System.Drawing.Color.Black;
            this.lb_System_Status.Location = new System.Drawing.Point(789, 239);
            this.lb_System_Status.Name = "lb_System_Status";
            this.lb_System_Status.Size = new System.Drawing.Size(61, 12);
            this.lb_System_Status.TabIndex = 148;
            this.lb_System_Status.Text = "NORMAL";
            this.lb_System_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label15.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(185, 266);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 12);
            this.label15.TabIndex = 157;
            this.label15.Text = "전력";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label16.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(185, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 12);
            this.label16.TabIndex = 156;
            this.label16.Text = "전류";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(181, 221);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(256, 31);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 155;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(181, 258);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(123, 31);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 154;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Image = global::KTE_PMS.Properties.Resources.PCS하단;
            this.pictureBox9.Location = new System.Drawing.Point(392, 268);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(175, 94);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 158;
            this.pictureBox9.TabStop = false;
            // 
            // lb_PCS_Control_Authority
            // 
            this.lb_PCS_Control_Authority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lb_PCS_Control_Authority.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_PCS_Control_Authority.ForeColor = System.Drawing.Color.Black;
            this.lb_PCS_Control_Authority.Location = new System.Drawing.Point(474, 279);
            this.lb_PCS_Control_Authority.Name = "lb_PCS_Control_Authority";
            this.lb_PCS_Control_Authority.Size = new System.Drawing.Size(70, 12);
            this.lb_PCS_Control_Authority.TabIndex = 159;
            this.lb_PCS_Control_Authority.Text = "NORMAL";
            this.lb_PCS_Control_Authority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_PCS_System_Status
            // 
            this.lb_PCS_System_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lb_PCS_System_Status.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_PCS_System_Status.ForeColor = System.Drawing.Color.Black;
            this.lb_PCS_System_Status.Location = new System.Drawing.Point(474, 305);
            this.lb_PCS_System_Status.Name = "lb_PCS_System_Status";
            this.lb_PCS_System_Status.Size = new System.Drawing.Size(70, 12);
            this.lb_PCS_System_Status.TabIndex = 160;
            this.lb_PCS_System_Status.Text = "NORMAL";
            this.lb_PCS_System_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label17.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(184, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 12);
            this.label17.TabIndex = 163;
            this.label17.Text = "전압";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.BackgroundImage")));
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Image = global::KTE_PMS.Properties.Resources.전압전류_RST;
            this.pictureBox10.Location = new System.Drawing.Point(180, 14);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(257, 83);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 162;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox11.BackgroundImage")));
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Location = new System.Drawing.Point(180, 102);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(123, 31);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 161;
            this.pictureBox11.TabStop = false;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label18.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(184, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 12);
            this.label18.TabIndex = 165;
            this.label18.Text = "전류";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox13.BackgroundImage")));
            this.pictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox13.Location = new System.Drawing.Point(307, 102);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(129, 31);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 166;
            this.pictureBox13.TabStop = false;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label19.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(185, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 12);
            this.label19.TabIndex = 167;
            this.label19.Text = "전류";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label21.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(318, 109);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 12);
            this.label21.TabIndex = 168;
            this.label21.Text = "주파수";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox12.BackgroundImage")));
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox12.Image = global::KTE_PMS.Properties.Resources.arrow_1;
            this.pictureBox12.Location = new System.Drawing.Point(304, 152);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(34, 16);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 169;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox14.BackgroundImage")));
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox14.Image = global::KTE_PMS.Properties.Resources.arrow_1;
            this.pictureBox14.Location = new System.Drawing.Point(304, 199);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(34, 16);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 170;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox15.BackgroundImage")));
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox15.Image = global::KTE_PMS.Properties.Resources.arrow_1;
            this.pictureBox15.Location = new System.Drawing.Point(629, 171);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(34, 16);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 171;
            this.pictureBox15.TabStop = false;
            // 
            // MimicViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.BackgroundImage = global::KTE_PMS.Properties.Resources.아이콘_선1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lbGRID_POWER);
            this.Controls.Add(this.lbGRID_Frequency);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.lbGRID_R_CURRENT);
            this.Controls.Add(this.lbGRID_S_CURRENT);
            this.Controls.Add(this.lbGRID_T_CURRENT);
            this.Controls.Add(this.lbGRID_T_VOLTAGE);
            this.Controls.Add(this.lbGRID_S_VOLTAGE);
            this.Controls.Add(this.lbGRID_R_VOLTAGE);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.lb_PCS_System_Status);
            this.Controls.Add(this.lb_PCS_Control_Authority);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lb_Battery_SOC);
            this.Controls.Add(this.lb_Battery_SOH);
            this.Controls.Add(this.lb_Battery_Current);
            this.Controls.Add(this.lb_Battery_Voltage);
            this.Controls.Add(this.lb_Battery_Power);
            this.Controls.Add(this.lb_System_Status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_PCS_Abnormal);
            this.Controls.Add(this.pb_Battery_Abnormal);
            this.Controls.Add(this.lbLOAD_POWER);
            this.Controls.Add(this.lbLOAD_R_CURRENT);
            this.Controls.Add(this.lbLOAD_S_CURRENT);
            this.Controls.Add(this.lbLOAD_T_CURRENT);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MimicViewer";
            this.Load += new System.EventHandler(this.MimicViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_PCS_Abnormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Battery_Abnormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbGRID_R_VOLTAGE;
        private System.Windows.Forms.Label lbGRID_S_VOLTAGE;
        private System.Windows.Forms.Label lbGRID_T_VOLTAGE;
        private System.Windows.Forms.Label lbGRID_Frequency;
        private System.Windows.Forms.Label lbGRID_POWER;
        private System.Windows.Forms.Label lbLOAD_POWER;
        private System.Windows.Forms.Label lbLOAD_R_CURRENT;
        private System.Windows.Forms.Label lbLOAD_S_CURRENT;
        private System.Windows.Forms.Label lbLOAD_T_CURRENT;
        private System.Windows.Forms.Label lbGRID_R_CURRENT;
        private System.Windows.Forms.Label lbGRID_S_CURRENT;
        private System.Windows.Forms.Label lbGRID_T_CURRENT;
        private System.Windows.Forms.PictureBox pb_PCS_Abnormal;
        private System.Windows.Forms.PictureBox pb_Battery_Abnormal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_Battery_SOC;
        private System.Windows.Forms.Label lb_Battery_SOH;
        private System.Windows.Forms.Label lb_Battery_Current;
        private System.Windows.Forms.Label lb_Battery_Voltage;
        private System.Windows.Forms.Label lb_Battery_Power;
        private System.Windows.Forms.Label lb_System_Status;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lb_PCS_Control_Authority;
        private System.Windows.Forms.Label lb_PCS_System_Status;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
    }
}
