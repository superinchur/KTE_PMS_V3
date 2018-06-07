namespace KTE_PMS
{
    partial class Modbus_Setup
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtWriteValue = new System.Windows.Forms.TextBox();
            this.txtWriteRegister = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.lstDataType = new System.Windows.Forms.ComboBox();
            this.txtSampleRate = new System.Windows.Forms.TextBox();
            this.txtRegisterQty = new System.Windows.Forms.TextBox();
            this.txtStartAddr = new System.Windows.Forms.TextBox();
            this.txtSlaveID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstBaudrate = new System.Windows.Forms.ComboBox();
            this.lstPorts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstRegisterValues = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(105, 60);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(96, 21);
            this.btnWrite.TabIndex = 8;
            this.btnWrite.Text = "Do Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            // 
            // txtWriteValue
            // 
            this.txtWriteValue.Location = new System.Drawing.Point(105, 36);
            this.txtWriteValue.Name = "txtWriteValue";
            this.txtWriteValue.Size = new System.Drawing.Size(95, 21);
            this.txtWriteValue.TabIndex = 7;
            // 
            // txtWriteRegister
            // 
            this.txtWriteRegister.Location = new System.Drawing.Point(105, 12);
            this.txtWriteRegister.Name = "txtWriteRegister";
            this.txtWriteRegister.Size = new System.Drawing.Size(95, 21);
            this.txtWriteRegister.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "Register:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWrite);
            this.groupBox3.Controls.Add(this.txtWriteValue);
            this.groupBox3.Controls.Add(this.txtWriteRegister);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(14, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 90);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Write Info";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "Value:";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Ready";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "Data Type:";
            // 
            // lstDataType
            // 
            this.lstDataType.FormattingEnabled = true;
            this.lstDataType.Location = new System.Drawing.Point(105, 108);
            this.lstDataType.Name = "lstDataType";
            this.lstDataType.Size = new System.Drawing.Size(95, 20);
            this.lstDataType.TabIndex = 9;
            // 
            // txtSampleRate
            // 
            this.txtSampleRate.Location = new System.Drawing.Point(105, 84);
            this.txtSampleRate.Name = "txtSampleRate";
            this.txtSampleRate.Size = new System.Drawing.Size(95, 21);
            this.txtSampleRate.TabIndex = 8;
            // 
            // txtRegisterQty
            // 
            this.txtRegisterQty.Location = new System.Drawing.Point(105, 60);
            this.txtRegisterQty.Name = "txtRegisterQty";
            this.txtRegisterQty.Size = new System.Drawing.Size(95, 21);
            this.txtRegisterQty.TabIndex = 7;
            // 
            // txtStartAddr
            // 
            this.txtStartAddr.Location = new System.Drawing.Point(105, 36);
            this.txtStartAddr.Name = "txtStartAddr";
            this.txtStartAddr.Size = new System.Drawing.Size(95, 21);
            this.txtStartAddr.TabIndex = 6;
            // 
            // txtSlaveID
            // 
            this.txtSlaveID.Location = new System.Drawing.Point(105, 12);
            this.txtSlaveID.Name = "txtSlaveID";
            this.txtSlaveID.Size = new System.Drawing.Size(95, 21);
            this.txtSlaveID.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sample Rate:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 314);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(579, 22);
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "statusStrip";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(475, 277);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(96, 21);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(272, 277);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 21);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Register Qty:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Start Addr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Slave ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lstDataType);
            this.groupBox2.Controls.Add(this.txtSampleRate);
            this.groupBox2.Controls.Add(this.txtRegisterQty);
            this.groupBox2.Controls.Add(this.txtStartAddr);
            this.groupBox2.Controls.Add(this.txtSlaveID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(14, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 136);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Poll Info";
            // 
            // lstBaudrate
            // 
            this.lstBaudrate.FormattingEnabled = true;
            this.lstBaudrate.Location = new System.Drawing.Point(105, 37);
            this.lstBaudrate.Name = "lstBaudrate";
            this.lstBaudrate.Size = new System.Drawing.Size(95, 20);
            this.lstBaudrate.TabIndex = 3;
            // 
            // lstPorts
            // 
            this.lstPorts.FormattingEnabled = true;
            this.lstPorts.Location = new System.Drawing.Point(105, 12);
            this.lstPorts.Name = "lstPorts";
            this.lstPorts.Size = new System.Drawing.Size(95, 20);
            this.lstPorts.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudrate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // lstRegisterValues
            // 
            this.lstRegisterValues.FormattingEnabled = true;
            this.lstRegisterValues.ItemHeight = 12;
            this.lstRegisterValues.Location = new System.Drawing.Point(272, 7);
            this.lstRegisterValues.Name = "lstRegisterValues";
            this.lstRegisterValues.Size = new System.Drawing.Size(298, 244);
            this.lstRegisterValues.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBaudrate);
            this.groupBox1.Controls.Add(this.lstPorts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 63);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Info";
            // 
            // Modbus_Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 336);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstRegisterValues);
            this.Controls.Add(this.groupBox1);
            this.Name = "Modbus_Setup";
            this.Text = "Modbus_Setup";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtWriteValue;
        private System.Windows.Forms.TextBox txtWriteRegister;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox lstDataType;
        private System.Windows.Forms.TextBox txtSampleRate;
        private System.Windows.Forms.TextBox txtRegisterQty;
        private System.Windows.Forms.TextBox txtStartAddr;
        private System.Windows.Forms.TextBox txtSlaveID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox lstBaudrate;
        private System.Windows.Forms.ComboBox lstPorts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstRegisterValues;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}