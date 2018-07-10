namespace KTE_PMS.MIMIC
{
    partial class Calculate_Power_Prices
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
            this.tb_REC_ratio = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_SMP_Prices = new System.Windows.Forms.MaskedTextBox();
            this.tb_REC_Prices = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_REC_ratio
            // 
            this.tb_REC_ratio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tb_REC_ratio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_REC_ratio.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_REC_ratio.Location = new System.Drawing.Point(128, 22);
            this.tb_REC_ratio.Mask = "9.9";
            this.tb_REC_ratio.Name = "tb_REC_ratio";
            this.tb_REC_ratio.Size = new System.Drawing.Size(86, 19);
            this.tb_REC_ratio.TabIndex = 125;
            this.tb_REC_ratio.TabStop = false;
            this.tb_REC_ratio.Text = "15";
            this.tb_REC_ratio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_REC_ratio.ValidatingType = typeof(int);
            this.tb_REC_ratio.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(20, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 19);
            this.label14.TabIndex = 124;
            this.label14.Text = "REC 가중치";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 126;
            this.label1.Text = "SMP 단가";
            // 
            // tb_SMP_Prices
            // 
            this.tb_SMP_Prices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tb_SMP_Prices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SMP_Prices.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_SMP_Prices.Location = new System.Drawing.Point(133, 63);
            this.tb_SMP_Prices.Mask = "999.9";
            this.tb_SMP_Prices.Name = "tb_SMP_Prices";
            this.tb_SMP_Prices.Size = new System.Drawing.Size(81, 19);
            this.tb_SMP_Prices.TabIndex = 127;
            this.tb_SMP_Prices.TabStop = false;
            this.tb_SMP_Prices.Text = "1300";
            this.tb_SMP_Prices.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_SMP_Prices.ValidatingType = typeof(int);
            this.tb_SMP_Prices.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // tb_REC_Prices
            // 
            this.tb_REC_Prices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.tb_REC_Prices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_REC_Prices.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_REC_Prices.Location = new System.Drawing.Point(114, 105);
            this.tb_REC_Prices.Mask = "999999";
            this.tb_REC_Prices.Name = "tb_REC_Prices";
            this.tb_REC_Prices.Size = new System.Drawing.Size(100, 19);
            this.tb_REC_Prices.TabIndex = 129;
            this.tb_REC_Prices.TabStop = false;
            this.tb_REC_Prices.Text = "100000";
            this.tb_REC_Prices.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_REC_Prices.ValidatingType = typeof(int);
            this.tb_REC_Prices.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 128;
            this.label2.Text = "REC 입찰단가";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(220, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 19);
            this.label4.TabIndex = 131;
            this.label4.Text = "원";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("나눔바른고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(220, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 19);
            this.label5.TabIndex = 132;
            this.label5.Text = "원";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(44, 147);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 133;
            this.btn_OK.Text = "확인";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(133, 147);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 134;
            this.btn_Cancel.Text = "취소";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Calculate_Power_Prices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(281, 198);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_REC_Prices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_SMP_Prices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_REC_ratio);
            this.Controls.Add(this.label14);
            this.Name = "Calculate_Power_Prices";
            this.Text = "Calculate_Power_Prices";
            this.Load += new System.EventHandler(this.Calculate_Power_Prices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tb_REC_ratio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tb_SMP_Prices;
        private System.Windows.Forms.MaskedTextBox tb_REC_Prices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
    }
}