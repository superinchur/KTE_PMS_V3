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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGRID_R_CURRENT = new System.Windows.Forms.Label();
            this.lbGRID_S_CURRENT = new System.Windows.Forms.Label();
            this.lbGRID_T_CURRENT = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbGRID_Frequency = new System.Windows.Forms.Label();
            this.lbGRID_POWER = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbINVERTER_POWER = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbLOAD_POWER = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbLOAD_R_CURRENT = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbLOAD_S_CURRENT = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbLOAD_T_CURRENT = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbisTemperatureWarning = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbGRID_R_VOLTAGE
            // 
            this.lbGRID_R_VOLTAGE.AutoSize = true;
            this.lbGRID_R_VOLTAGE.BackColor = System.Drawing.Color.Transparent;
            this.lbGRID_R_VOLTAGE.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbGRID_R_VOLTAGE.ForeColor = System.Drawing.Color.Black;
            this.lbGRID_R_VOLTAGE.Location = new System.Drawing.Point(9, 52);
            this.lbGRID_R_VOLTAGE.Name = "lbGRID_R_VOLTAGE";
            this.lbGRID_R_VOLTAGE.Size = new System.Drawing.Size(46, 15);
            this.lbGRID_R_VOLTAGE.TabIndex = 94;
            this.lbGRID_R_VOLTAGE.Text = "12.34 ";
            // 
            // lbGRID_S_VOLTAGE
            // 
            this.lbGRID_S_VOLTAGE.AutoSize = true;
            this.lbGRID_S_VOLTAGE.BackColor = System.Drawing.Color.Transparent;
            this.lbGRID_S_VOLTAGE.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbGRID_S_VOLTAGE.ForeColor = System.Drawing.Color.Black;
            this.lbGRID_S_VOLTAGE.Location = new System.Drawing.Point(65, 52);
            this.lbGRID_S_VOLTAGE.Name = "lbGRID_S_VOLTAGE";
            this.lbGRID_S_VOLTAGE.Size = new System.Drawing.Size(46, 15);
            this.lbGRID_S_VOLTAGE.TabIndex = 96;
            this.lbGRID_S_VOLTAGE.Text = "12.34 ";
            // 
            // lbGRID_T_VOLTAGE
            // 
            this.lbGRID_T_VOLTAGE.AutoSize = true;
            this.lbGRID_T_VOLTAGE.BackColor = System.Drawing.Color.Transparent;
            this.lbGRID_T_VOLTAGE.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbGRID_T_VOLTAGE.ForeColor = System.Drawing.Color.Black;
            this.lbGRID_T_VOLTAGE.Location = new System.Drawing.Point(118, 52);
            this.lbGRID_T_VOLTAGE.Name = "lbGRID_T_VOLTAGE";
            this.lbGRID_T_VOLTAGE.Size = new System.Drawing.Size(46, 15);
            this.lbGRID_T_VOLTAGE.TabIndex = 97;
            this.lbGRID_T_VOLTAGE.Text = "12.34 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(22, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 98;
            this.label3.Text = "R상";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(74, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 99;
            this.label4.Text = "S상";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(126, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 100;
            this.label5.Text = "T상";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbGRID_R_CURRENT);
            this.groupBox1.Controls.Add(this.lbGRID_S_CURRENT);
            this.groupBox1.Controls.Add(this.lbGRID_T_CURRENT);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.lbGRID_Frequency);
            this.groupBox1.Controls.Add(this.lbGRID_POWER);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lbGRID_R_VOLTAGE);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbGRID_S_VOLTAGE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbGRID_T_VOLTAGE);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(9, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 152);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GRID Voltage";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(105, 75);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(15, 15);
            this.label30.TabIndex = 117;
            this.label30.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(159, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 116;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(49, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 115;
            this.label2.Text = "A";
            // 
            // lbGRID_R_CURRENT
            // 
            this.lbGRID_R_CURRENT.AutoSize = true;
            this.lbGRID_R_CURRENT.BackColor = System.Drawing.Color.Transparent;
            this.lbGRID_R_CURRENT.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbGRID_R_CURRENT.ForeColor = System.Drawing.Color.Black;
            this.lbGRID_R_CURRENT.Location = new System.Drawing.Point(9, 75);
            this.lbGRID_R_CURRENT.Name = "lbGRID_R_CURRENT";
            this.lbGRID_R_CURRENT.Size = new System.Drawing.Size(46, 15);
            this.lbGRID_R_CURRENT.TabIndex = 109;
            this.lbGRID_R_CURRENT.Text = "12.34 ";
            // 
            // lbGRID_S_CURRENT
            // 
            this.lbGRID_S_CURRENT.AutoSize = true;
            this.lbGRID_S_CURRENT.BackColor = System.Drawing.Color.Transparent;
            this.lbGRID_S_CURRENT.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbGRID_S_CURRENT.ForeColor = System.Drawing.Color.Black;
            this.lbGRID_S_CURRENT.Location = new System.Drawing.Point(65, 75);
            this.lbGRID_S_CURRENT.Name = "lbGRID_S_CURRENT";
            this.lbGRID_S_CURRENT.Size = new System.Drawing.Size(46, 15);
            this.lbGRID_S_CURRENT.TabIndex = 110;
            this.lbGRID_S_CURRENT.Text = "12.34 ";
            // 
            // lbGRID_T_CURRENT
            // 
            this.lbGRID_T_CURRENT.AutoSize = true;
            this.lbGRID_T_CURRENT.BackColor = System.Drawing.Color.Transparent;
            this.lbGRID_T_CURRENT.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbGRID_T_CURRENT.ForeColor = System.Drawing.Color.Black;
            this.lbGRID_T_CURRENT.Location = new System.Drawing.Point(118, 75);
            this.lbGRID_T_CURRENT.Name = "lbGRID_T_CURRENT";
            this.lbGRID_T_CURRENT.Size = new System.Drawing.Size(46, 15);
            this.lbGRID_T_CURRENT.TabIndex = 111;
            this.lbGRID_T_CURRENT.Text = "12.34 ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(159, 52);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(15, 15);
            this.label26.TabIndex = 108;
            this.label26.Text = "V";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(105, 52);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(15, 15);
            this.label25.TabIndex = 106;
            this.label25.Text = "V";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(49, 52);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(15, 15);
            this.label24.TabIndex = 105;
            this.label24.Text = "V";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(142, 126);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 15);
            this.label23.TabIndex = 107;
            this.label23.Text = "Hz";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(55, 126);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(27, 15);
            this.label22.TabIndex = 104;
            this.label22.Text = "kW";
            // 
            // lbGRID_Frequency
            // 
            this.lbGRID_Frequency.AutoSize = true;
            this.lbGRID_Frequency.BackColor = System.Drawing.Color.Transparent;
            this.lbGRID_Frequency.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbGRID_Frequency.ForeColor = System.Drawing.Color.Black;
            this.lbGRID_Frequency.Location = new System.Drawing.Point(102, 126);
            this.lbGRID_Frequency.Name = "lbGRID_Frequency";
            this.lbGRID_Frequency.Size = new System.Drawing.Size(46, 15);
            this.lbGRID_Frequency.TabIndex = 105;
            this.lbGRID_Frequency.Text = "12.34 ";
            // 
            // lbGRID_POWER
            // 
            this.lbGRID_POWER.AutoSize = true;
            this.lbGRID_POWER.BackColor = System.Drawing.Color.Transparent;
            this.lbGRID_POWER.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbGRID_POWER.ForeColor = System.Drawing.Color.Black;
            this.lbGRID_POWER.Location = new System.Drawing.Point(13, 126);
            this.lbGRID_POWER.Name = "lbGRID_POWER";
            this.lbGRID_POWER.Size = new System.Drawing.Size(46, 15);
            this.lbGRID_POWER.TabIndex = 103;
            this.lbGRID_POWER.Text = "12.34 ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(86, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 15);
            this.label17.TabIndex = 106;
            this.label17.Text = "Frequency";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(26, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 15);
            this.label15.TabIndex = 104;
            this.label15.Text = "Power";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.lbINVERTER_POWER);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.lbLOAD_POWER);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbLOAD_R_CURRENT);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbLOAD_S_CURRENT);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lbLOAD_T_CURRENT);
            this.groupBox2.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(768, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 178);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LOAD Voltage";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(161, 52);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(15, 15);
            this.label29.TabIndex = 111;
            this.label29.Text = "V";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(105, 52);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(15, 15);
            this.label28.TabIndex = 110;
            this.label28.Text = "V";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(45, 52);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(15, 15);
            this.label27.TabIndex = 109;
            this.label27.Text = "V";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(110, 152);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 15);
            this.label21.TabIndex = 104;
            this.label21.Text = "kW";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(109, 102);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 15);
            this.label20.TabIndex = 103;
            this.label20.Text = "kW";
            // 
            // lbINVERTER_POWER
            // 
            this.lbINVERTER_POWER.AutoSize = true;
            this.lbINVERTER_POWER.BackColor = System.Drawing.Color.Transparent;
            this.lbINVERTER_POWER.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbINVERTER_POWER.ForeColor = System.Drawing.Color.Black;
            this.lbINVERTER_POWER.Location = new System.Drawing.Point(61, 152);
            this.lbINVERTER_POWER.Name = "lbINVERTER_POWER";
            this.lbINVERTER_POWER.Size = new System.Drawing.Size(46, 15);
            this.lbINVERTER_POWER.TabIndex = 103;
            this.lbINVERTER_POWER.Text = "12.34 ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(24, 131);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 15);
            this.label19.TabIndex = 104;
            this.label19.Text = "INVERTER Power";
            // 
            // lbLOAD_POWER
            // 
            this.lbLOAD_POWER.AutoSize = true;
            this.lbLOAD_POWER.BackColor = System.Drawing.Color.Transparent;
            this.lbLOAD_POWER.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLOAD_POWER.ForeColor = System.Drawing.Color.Black;
            this.lbLOAD_POWER.Location = new System.Drawing.Point(61, 102);
            this.lbLOAD_POWER.Name = "lbLOAD_POWER";
            this.lbLOAD_POWER.Size = new System.Drawing.Size(46, 15);
            this.lbLOAD_POWER.TabIndex = 101;
            this.lbLOAD_POWER.Text = "12.34 ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(39, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 15);
            this.label13.TabIndex = 102;
            this.label13.Text = "LOAD Power";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(128, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 100;
            this.label6.Text = "T상";
            // 
            // lbLOAD_R_CURRENT
            // 
            this.lbLOAD_R_CURRENT.AutoSize = true;
            this.lbLOAD_R_CURRENT.BackColor = System.Drawing.Color.Transparent;
            this.lbLOAD_R_CURRENT.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLOAD_R_CURRENT.ForeColor = System.Drawing.Color.Black;
            this.lbLOAD_R_CURRENT.Location = new System.Drawing.Point(6, 52);
            this.lbLOAD_R_CURRENT.Name = "lbLOAD_R_CURRENT";
            this.lbLOAD_R_CURRENT.Size = new System.Drawing.Size(46, 15);
            this.lbLOAD_R_CURRENT.TabIndex = 94;
            this.lbLOAD_R_CURRENT.Text = "12.34 ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(76, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 99;
            this.label8.Text = "S상";
            // 
            // lbLOAD_S_CURRENT
            // 
            this.lbLOAD_S_CURRENT.AutoSize = true;
            this.lbLOAD_S_CURRENT.BackColor = System.Drawing.Color.Transparent;
            this.lbLOAD_S_CURRENT.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLOAD_S_CURRENT.ForeColor = System.Drawing.Color.Black;
            this.lbLOAD_S_CURRENT.Location = new System.Drawing.Point(67, 52);
            this.lbLOAD_S_CURRENT.Name = "lbLOAD_S_CURRENT";
            this.lbLOAD_S_CURRENT.Size = new System.Drawing.Size(46, 15);
            this.lbLOAD_S_CURRENT.TabIndex = 96;
            this.lbLOAD_S_CURRENT.Text = "12.34 ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(24, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 15);
            this.label10.TabIndex = 98;
            this.label10.Text = "R상";
            // 
            // lbLOAD_T_CURRENT
            // 
            this.lbLOAD_T_CURRENT.AutoSize = true;
            this.lbLOAD_T_CURRENT.BackColor = System.Drawing.Color.Transparent;
            this.lbLOAD_T_CURRENT.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLOAD_T_CURRENT.ForeColor = System.Drawing.Color.Black;
            this.lbLOAD_T_CURRENT.Location = new System.Drawing.Point(120, 52);
            this.lbLOAD_T_CURRENT.Name = "lbLOAD_T_CURRENT";
            this.lbLOAD_T_CURRENT.Size = new System.Drawing.Size(46, 15);
            this.lbLOAD_T_CURRENT.TabIndex = 97;
            this.lbLOAD_T_CURRENT.Text = "12.34 ";
            // 
            // timer
            // 
            this.timer.Interval = 400;
            // 
            // lbisTemperatureWarning
            // 
            this.lbisTemperatureWarning.AutoSize = true;
            this.lbisTemperatureWarning.BackColor = System.Drawing.Color.Transparent;
            this.lbisTemperatureWarning.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbisTemperatureWarning.ForeColor = System.Drawing.Color.Black;
            this.lbisTemperatureWarning.Location = new System.Drawing.Point(56, 32);
            this.lbisTemperatureWarning.Name = "lbisTemperatureWarning";
            this.lbisTemperatureWarning.Size = new System.Drawing.Size(60, 15);
            this.lbisTemperatureWarning.TabIndex = 103;
            this.lbisTemperatureWarning.Text = "NORMAL";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox3.Controls.Add(this.lbisTemperatureWarning);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(9, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 60);
            this.groupBox3.TabIndex = 105;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "함내 내부 온도 이상 유무";
            // 
            // MimicViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MimicViewer";
            this.Size = new System.Drawing.Size(964, 454);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbGRID_R_VOLTAGE;
        private System.Windows.Forms.Label lbGRID_S_VOLTAGE;
        private System.Windows.Forms.Label lbGRID_T_VOLTAGE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbGRID_Frequency;
        private System.Windows.Forms.Label lbGRID_POWER;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbLOAD_POWER;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbLOAD_R_CURRENT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbLOAD_S_CURRENT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbLOAD_T_CURRENT;
        private System.Windows.Forms.Label lbINVERTER_POWER;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbGRID_R_CURRENT;
        private System.Windows.Forms.Label lbGRID_S_CURRENT;
        private System.Windows.Forms.Label lbGRID_T_CURRENT;
        private System.Windows.Forms.Label lbisTemperatureWarning;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
