namespace KTE_PMS.Popup
{
    partial class Popup_Battery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup_Battery));
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Grid_OFF = new System.Windows.Forms.Button();
            this.btn_Grid_ON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(172, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 18);
            this.label12.TabIndex = 93;
            this.label12.Text = "Grid OFF";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(74, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 92;
            this.label11.Text = "Grid ON";
            // 
            // btn_Grid_OFF
            // 
            this.btn_Grid_OFF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Grid_OFF.BackgroundImage")));
            this.btn_Grid_OFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Grid_OFF.Location = new System.Drawing.Point(175, 83);
            this.btn_Grid_OFF.Name = "btn_Grid_OFF";
            this.btn_Grid_OFF.Size = new System.Drawing.Size(51, 51);
            this.btn_Grid_OFF.TabIndex = 91;
            this.btn_Grid_OFF.TabStop = false;
            this.btn_Grid_OFF.UseVisualStyleBackColor = true;
            // 
            // btn_Grid_ON
            // 
            this.btn_Grid_ON.BackgroundImage = global::KTE_PMS.Properties.Resources.RUN_003_1;
            this.btn_Grid_ON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Grid_ON.Location = new System.Drawing.Point(75, 83);
            this.btn_Grid_ON.Name = "btn_Grid_ON";
            this.btn_Grid_ON.Size = new System.Drawing.Size(51, 51);
            this.btn_Grid_ON.TabIndex = 90;
            this.btn_Grid_ON.TabStop = false;
            this.btn_Grid_ON.UseVisualStyleBackColor = true;
            // 
            // Popup_Battery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_Grid_OFF);
            this.Controls.Add(this.btn_Grid_ON);
            this.Name = "Popup_Battery";
            this.Text = "Popup_Battery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Grid_OFF;
        private System.Windows.Forms.Button btn_Grid_ON;
    }
}