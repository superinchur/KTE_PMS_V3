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
            this.SuspendLayout();
            // 
            // tb_Charging_Period_End
            // 
            this.tb_Charging_Period_End.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Charging_Period_End.Location = new System.Drawing.Point(315, 159);
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
            this.tb_Charging_Period_Start.Location = new System.Drawing.Point(172, 159);
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
            this.tb_Discharging_Period_End.Location = new System.Drawing.Point(315, 108);
            this.tb_Discharging_Period_End.Mask = "90시90분";
            this.tb_Discharging_Period_End.Name = "tb_Discharging_Period_End";
            this.tb_Discharging_Period_End.Size = new System.Drawing.Size(114, 29);
            this.tb_Discharging_Period_End.TabIndex = 35;
            this.tb_Discharging_Period_End.TabStop = false;
            this.tb_Discharging_Period_End.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Discharging_Period_End.ValidatingType = typeof(System.DateTime);
            // 
            // tb_Discharging_Period_Start
            // 
            this.tb_Discharging_Period_Start.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Discharging_Period_Start.Location = new System.Drawing.Point(172, 108);
            this.tb_Discharging_Period_Start.Mask = "90시90분";
            this.tb_Discharging_Period_Start.Name = "tb_Discharging_Period_Start";
            this.tb_Discharging_Period_Start.Size = new System.Drawing.Size(114, 29);
            this.tb_Discharging_Period_Start.TabIndex = 34;
            this.tb_Discharging_Period_Start.TabStop = false;
            this.tb_Discharging_Period_Start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Discharging_Period_Start.ValidatingType = typeof(System.DateTime);
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
            this.btn_OK.Location = new System.Drawing.Point(29, 205);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(187, 46);
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
            this.btn_Cancel.Location = new System.Drawing.Point(242, 205);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(187, 46);
            this.btn_Cancel.TabIndex = 94;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Cancel_MouseDown);
            this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Cancel_MouseUp);
            // 
            // Popup_Scheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KTE_PMS.Properties.Resources.popup_글만;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(453, 263);
            this.ControlBox = false;
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
    }
}