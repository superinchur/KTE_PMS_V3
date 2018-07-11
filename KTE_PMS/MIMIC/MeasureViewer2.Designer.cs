namespace KTE_PMS.MIMIC
{
    partial class MeasureViewer2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeasureViewer2));
            this.btn_Move_To_PCS_Fault = new System.Windows.Forms.Button();
            this.btn_Move_To_PCS_Data = new System.Windows.Forms.Button();
            this.btn_Move_To_BMS_Rack = new System.Windows.Forms.Button();
            this.btn_Move_To_BMS_System = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Move_To_PCS_Fault
            // 
            this.btn_Move_To_PCS_Fault.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Move_To_PCS_Fault.BackgroundImage")));
            this.btn_Move_To_PCS_Fault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Move_To_PCS_Fault.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Move_To_PCS_Fault.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Move_To_PCS_Fault.Location = new System.Drawing.Point(793, 232);
            this.btn_Move_To_PCS_Fault.Name = "btn_Move_To_PCS_Fault";
            this.btn_Move_To_PCS_Fault.Size = new System.Drawing.Size(151, 59);
            this.btn_Move_To_PCS_Fault.TabIndex = 134;
            this.btn_Move_To_PCS_Fault.TabStop = false;
            this.btn_Move_To_PCS_Fault.Text = "PCS Fault시 데이터";
            this.btn_Move_To_PCS_Fault.UseVisualStyleBackColor = true;
            this.btn_Move_To_PCS_Fault.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Move_To_PCS_Fault_MouseClick);
            // 
            // btn_Move_To_PCS_Data
            // 
            this.btn_Move_To_PCS_Data.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Move_To_PCS_Data.BackgroundImage")));
            this.btn_Move_To_PCS_Data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Move_To_PCS_Data.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Move_To_PCS_Data.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Move_To_PCS_Data.Location = new System.Drawing.Point(793, 170);
            this.btn_Move_To_PCS_Data.Name = "btn_Move_To_PCS_Data";
            this.btn_Move_To_PCS_Data.Size = new System.Drawing.Size(151, 59);
            this.btn_Move_To_PCS_Data.TabIndex = 133;
            this.btn_Move_To_PCS_Data.TabStop = false;
            this.btn_Move_To_PCS_Data.Text = "PCS Data";
            this.btn_Move_To_PCS_Data.UseVisualStyleBackColor = true;
            this.btn_Move_To_PCS_Data.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Move_To_PCS_Data_MouseClick);
            // 
            // btn_Move_To_BMS_Rack
            // 
            this.btn_Move_To_BMS_Rack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Move_To_BMS_Rack.BackgroundImage")));
            this.btn_Move_To_BMS_Rack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Move_To_BMS_Rack.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Move_To_BMS_Rack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Move_To_BMS_Rack.Location = new System.Drawing.Point(793, 105);
            this.btn_Move_To_BMS_Rack.Name = "btn_Move_To_BMS_Rack";
            this.btn_Move_To_BMS_Rack.Size = new System.Drawing.Size(151, 59);
            this.btn_Move_To_BMS_Rack.TabIndex = 132;
            this.btn_Move_To_BMS_Rack.TabStop = false;
            this.btn_Move_To_BMS_Rack.Text = "BMS : Rack ";
            this.btn_Move_To_BMS_Rack.UseVisualStyleBackColor = true;
            this.btn_Move_To_BMS_Rack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Move_To_BMS_Rack_MouseClick);
            // 
            // btn_Move_To_BMS_System
            // 
            this.btn_Move_To_BMS_System.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Move_To_BMS_System.BackgroundImage")));
            this.btn_Move_To_BMS_System.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Move_To_BMS_System.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Move_To_BMS_System.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Move_To_BMS_System.Location = new System.Drawing.Point(793, 40);
            this.btn_Move_To_BMS_System.Name = "btn_Move_To_BMS_System";
            this.btn_Move_To_BMS_System.Size = new System.Drawing.Size(151, 59);
            this.btn_Move_To_BMS_System.TabIndex = 131;
            this.btn_Move_To_BMS_System.TabStop = false;
            this.btn_Move_To_BMS_System.Text = "BMS : System";
            this.btn_Move_To_BMS_System.UseVisualStyleBackColor = true;
            this.btn_Move_To_BMS_System.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Move_To_BMS_System_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(729, 415);
            this.dataGridView1.TabIndex = 135;
            // 
            // MeasureViewer2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Move_To_PCS_Fault);
            this.Controls.Add(this.btn_Move_To_PCS_Data);
            this.Controls.Add(this.btn_Move_To_BMS_Rack);
            this.Controls.Add(this.btn_Move_To_BMS_System);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MeasureViewer2";
            this.Size = new System.Drawing.Size(960, 434);
            this.Load += new System.EventHandler(this.Measure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Move_To_PCS_Fault;
        private System.Windows.Forms.Button btn_Move_To_PCS_Data;
        private System.Windows.Forms.Button btn_Move_To_BMS_Rack;
        private System.Windows.Forms.Button btn_Move_To_BMS_System;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
