namespace KTE_PMS.Popup
{
    partial class Popup_Scheduling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Charging_Period_End = new System.Windows.Forms.MaskedTextBox();
            this.tb_Charging_Period_Start = new System.Windows.Forms.MaskedTextBox();
            this.tb_Discharging_Period_End = new System.Windows.Forms.MaskedTextBox();
            this.tb_Discharging_Period_Start = new System.Windows.Forms.MaskedTextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.t11 = new System.Windows.Forms.NumericUpDown();
            this.t12 = new System.Windows.Forms.NumericUpDown();
            this.t21 = new System.Windows.Forms.NumericUpDown();
            this.t22 = new System.Windows.Forms.NumericUpDown();
            this.lb_PCS_Control_Authority = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.t24 = new System.Windows.Forms.NumericUpDown();
            this.t23 = new System.Windows.Forms.NumericUpDown();
            this.t14 = new System.Windows.Forms.NumericUpDown();
            this.t13 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.t11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t13)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Charging_Period_End
            // 
            this.tb_Charging_Period_End.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Charging_Period_End.Location = new System.Drawing.Point(220, 309);
            this.tb_Charging_Period_End.Mask = "90시90분";
            this.tb_Charging_Period_End.Name = "tb_Charging_Period_End";
            this.tb_Charging_Period_End.Size = new System.Drawing.Size(114, 29);
            this.tb_Charging_Period_End.TabIndex = 37;
            this.tb_Charging_Period_End.TabStop = false;
            this.tb_Charging_Period_End.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Charging_Period_End.ValidatingType = typeof(System.DateTime);
            // 
            // tb_Charging_Period_Start
            // 
            this.tb_Charging_Period_Start.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Charging_Period_Start.Location = new System.Drawing.Point(77, 309);
            this.tb_Charging_Period_Start.Mask = "90시90분";
            this.tb_Charging_Period_Start.Name = "tb_Charging_Period_Start";
            this.tb_Charging_Period_Start.Size = new System.Drawing.Size(114, 29);
            this.tb_Charging_Period_Start.TabIndex = 36;
            this.tb_Charging_Period_Start.TabStop = false;
            this.tb_Charging_Period_Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Charging_Period_Start.ValidatingType = typeof(System.DateTime);
            // 
            // tb_Discharging_Period_End
            // 
            this.tb_Discharging_Period_End.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Discharging_Period_End.Location = new System.Drawing.Point(275, 260);
            this.tb_Discharging_Period_End.Mask = "90시90분";
            this.tb_Discharging_Period_End.Name = "tb_Discharging_Period_End";
            this.tb_Discharging_Period_End.Size = new System.Drawing.Size(114, 29);
            this.tb_Discharging_Period_End.TabIndex = 35;
            this.tb_Discharging_Period_End.TabStop = false;
            this.tb_Discharging_Period_End.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Discharging_Period_End.ValidatingType = typeof(System.DateTime);
            this.tb_Discharging_Period_End.Visible = false;
            // 
            // tb_Discharging_Period_Start
            // 
            this.tb_Discharging_Period_Start.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Discharging_Period_Start.Location = new System.Drawing.Point(132, 260);
            this.tb_Discharging_Period_Start.Mask = "90시90분";
            this.tb_Discharging_Period_Start.Name = "tb_Discharging_Period_Start";
            this.tb_Discharging_Period_Start.Size = new System.Drawing.Size(114, 29);
            this.tb_Discharging_Period_Start.TabIndex = 34;
            this.tb_Discharging_Period_Start.TabStop = false;
            this.tb_Discharging_Period_Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Discharging_Period_Start.ValidatingType = typeof(System.DateTime);
            this.tb_Discharging_Period_Start.Visible = false;
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.Transparent;
            this.btn_OK.BackgroundImage = global::KTE_PMS.Properties.Resources.확인_off;
            this.btn_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Location = new System.Drawing.Point(185, 204);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(121, 29);
            this.btn_OK.TabIndex = 93;
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            this.btn_OK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_OK_MouseDown);
            this.btn_OK.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_OK_MouseUp);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.BackgroundImage = global::KTE_PMS.Properties.Resources.닫기_off;
            this.btn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Location = new System.Drawing.Point(312, 204);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(120, 29);
            this.btn_Cancel.TabIndex = 94;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Cancel_MouseDown);
            this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Cancel_MouseUp);
            // 
            // t11
            // 
            this.t11.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.t11.Location = new System.Drawing.Point(150, 112);
            this.t11.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.t11.Name = "t11";
            this.t11.Size = new System.Drawing.Size(50, 25);
            this.t11.TabIndex = 95;
            this.t11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t11.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // t12
            // 
            this.t12.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.t12.Location = new System.Drawing.Point(220, 112);
            this.t12.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.t12.Name = "t12";
            this.t12.Size = new System.Drawing.Size(50, 25);
            this.t12.TabIndex = 96;
            this.t12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t12.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // t21
            // 
            this.t21.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.t21.Location = new System.Drawing.Point(150, 160);
            this.t21.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.t21.Name = "t21";
            this.t21.Size = new System.Drawing.Size(50, 25);
            this.t21.TabIndex = 97;
            this.t21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t21.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // t22
            // 
            this.t22.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.t22.Location = new System.Drawing.Point(220, 160);
            this.t22.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.t22.Name = "t22";
            this.t22.Size = new System.Drawing.Size(50, 25);
            this.t22.TabIndex = 98;
            this.t22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t22.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // lb_PCS_Control_Authority
            // 
            this.lb_PCS_Control_Authority.BackColor = System.Drawing.Color.Transparent;
            this.lb_PCS_Control_Authority.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_PCS_Control_Authority.ForeColor = System.Drawing.Color.Black;
            this.lb_PCS_Control_Authority.Location = new System.Drawing.Point(200, 112);
            this.lb_PCS_Control_Authority.Name = "lb_PCS_Control_Authority";
            this.lb_PCS_Control_Authority.Size = new System.Drawing.Size(20, 25);
            this.lb_PCS_Control_Authority.TabIndex = 160;
            this.lb_PCS_Control_Authority.Text = "시";
            this.lb_PCS_Control_Authority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(200, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 161;
            this.label1.Text = "시";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(270, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 25);
            this.label2.TabIndex = 163;
            this.label2.Text = "분";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(270, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 162;
            this.label3.Text = "분";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(432, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 25);
            this.label4.TabIndex = 171;
            this.label4.Text = "분";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(432, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 25);
            this.label5.TabIndex = 170;
            this.label5.Text = "분";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(362, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 25);
            this.label6.TabIndex = 169;
            this.label6.Text = "시";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(362, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 25);
            this.label7.TabIndex = 168;
            this.label7.Text = "시";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t24
            // 
            this.t24.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.t24.Location = new System.Drawing.Point(382, 160);
            this.t24.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.t24.Name = "t24";
            this.t24.Size = new System.Drawing.Size(50, 25);
            this.t24.TabIndex = 167;
            this.t24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t24.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // t23
            // 
            this.t23.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.t23.Location = new System.Drawing.Point(312, 160);
            this.t23.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.t23.Name = "t23";
            this.t23.Size = new System.Drawing.Size(50, 25);
            this.t23.TabIndex = 166;
            this.t23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t23.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // t14
            // 
            this.t14.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.t14.Location = new System.Drawing.Point(382, 112);
            this.t14.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.t14.Name = "t14";
            this.t14.Size = new System.Drawing.Size(50, 25);
            this.t14.TabIndex = 165;
            this.t14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t14.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // t13
            // 
            this.t13.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.t13.Location = new System.Drawing.Point(312, 112);
            this.t13.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.t13.Name = "t13";
            this.t13.Size = new System.Drawing.Size(50, 25);
            this.t13.TabIndex = 164;
            this.t13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.t13.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // Popup_Scheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KTE_PMS.Properties.Resources.popup_글만;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(461, 301);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.t24);
            this.Controls.Add(this.t23);
            this.Controls.Add(this.t14);
            this.Controls.Add(this.t13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_PCS_Control_Authority);
            this.Controls.Add(this.t22);
            this.Controls.Add(this.t21);
            this.Controls.Add(this.t12);
            this.Controls.Add(this.t11);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.tb_Charging_Period_End);
            this.Controls.Add(this.tb_Charging_Period_Start);
            this.Controls.Add(this.tb_Discharging_Period_End);
            this.Controls.Add(this.tb_Discharging_Period_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Popup_Scheduling";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Popup_Scheduling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.t11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tb_Charging_Period_End;
        private System.Windows.Forms.MaskedTextBox tb_Charging_Period_Start;
        private System.Windows.Forms.MaskedTextBox tb_Discharging_Period_End;
        private System.Windows.Forms.MaskedTextBox tb_Discharging_Period_Start;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.NumericUpDown t11;
        private System.Windows.Forms.NumericUpDown t12;
        private System.Windows.Forms.NumericUpDown t21;
        private System.Windows.Forms.NumericUpDown t22;
        private System.Windows.Forms.Label lb_PCS_Control_Authority;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown t24;
        private System.Windows.Forms.NumericUpDown t23;
        private System.Windows.Forms.NumericUpDown t14;
        private System.Windows.Forms.NumericUpDown t13;
    }
}