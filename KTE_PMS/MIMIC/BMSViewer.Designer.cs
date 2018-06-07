namespace KTE_PMS.MIMIC
{
    partial class BMSViewer
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtIP4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIP3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIP2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_IP = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 24F);
            this.label5.Location = new System.Drawing.Point(266, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 32);
            this.label5.TabIndex = 37;
            this.label5.Text = "BMS";
            // 
            // txtIP4
            // 
            this.txtIP4.Font = new System.Drawing.Font("굴림", 24F);
            this.txtIP4.Location = new System.Drawing.Point(470, 74);
            this.txtIP4.Name = "txtIP4";
            this.txtIP4.Size = new System.Drawing.Size(66, 44);
            this.txtIP4.TabIndex = 36;
            this.txtIP4.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 24F);
            this.label4.Location = new System.Drawing.Point(450, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 32);
            this.label4.TabIndex = 35;
            this.label4.Text = ".";
            // 
            // txtIP3
            // 
            this.txtIP3.Font = new System.Drawing.Font("굴림", 24F);
            this.txtIP3.Location = new System.Drawing.Point(378, 74);
            this.txtIP3.Name = "txtIP3";
            this.txtIP3.Size = new System.Drawing.Size(66, 44);
            this.txtIP3.TabIndex = 34;
            this.txtIP3.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 24F);
            this.label3.Location = new System.Drawing.Point(359, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 32);
            this.label3.TabIndex = 33;
            this.label3.Text = ".";
            // 
            // txtIP2
            // 
            this.txtIP2.Font = new System.Drawing.Font("굴림", 24F);
            this.txtIP2.Location = new System.Drawing.Point(287, 74);
            this.txtIP2.Name = "txtIP2";
            this.txtIP2.Size = new System.Drawing.Size(66, 44);
            this.txtIP2.TabIndex = 32;
            this.txtIP2.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 24F);
            this.label2.Location = new System.Drawing.Point(266, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 32);
            this.label2.TabIndex = 31;
            this.label2.Text = ".";
            // 
            // BT_Connect
            // 
            this.BT_Connect.Location = new System.Drawing.Point(347, 131);
            this.BT_Connect.Name = "BT_Connect";
            this.BT_Connect.Size = new System.Drawing.Size(118, 39);
            this.BT_Connect.TabIndex = 30;
            this.BT_Connect.Text = "Connect";
            this.BT_Connect.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 24F);
            this.label1.Location = new System.Drawing.Point(113, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "Port";
            // 
            // LB_IP
            // 
            this.LB_IP.AutoSize = true;
            this.LB_IP.Font = new System.Drawing.Font("굴림", 24F);
            this.LB_IP.Location = new System.Drawing.Point(11, 84);
            this.LB_IP.Name = "LB_IP";
            this.LB_IP.Size = new System.Drawing.Size(177, 32);
            this.LB_IP.TabIndex = 28;
            this.LB_IP.Text = "IP Address";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("굴림", 24F);
            this.txtPort.Location = new System.Drawing.Point(198, 124);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 44);
            this.txtPort.TabIndex = 27;
            this.txtPort.Text = "502";
            // 
            // txtIP1
            // 
            this.txtIP1.Font = new System.Drawing.Font("굴림", 24F);
            this.txtIP1.Location = new System.Drawing.Point(198, 74);
            this.txtIP1.Name = "txtIP1";
            this.txtIP1.Size = new System.Drawing.Size(66, 44);
            this.txtIP1.TabIndex = 26;
            this.txtIP1.Text = "127";
            this.txtIP1.TextChanged += new System.EventHandler(this.txtIP1_TextChanged);
            // 
            // BMSViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 206);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIP4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIP3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIP2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BT_Connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_IP);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP1);
            this.Name = "BMSViewer";
            this.Text = "BMS_Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIP4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIP3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIP2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_IP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP1;
    }
}