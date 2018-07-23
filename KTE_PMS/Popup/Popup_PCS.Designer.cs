namespace KTE_PMS.Popup
{
    partial class Popup_PCS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup_PCS));
            this.label13 = new System.Windows.Forms.Label();
            this.btn_IDLE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(226, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 18);
            this.label13.TabIndex = 97;
            this.label13.Text = "Idle";
            // 
            // btn_IDLE
            // 
            this.btn_IDLE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_IDLE.BackgroundImage")));
            this.btn_IDLE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_IDLE.Location = new System.Drawing.Point(218, 138);
            this.btn_IDLE.Name = "btn_IDLE";
            this.btn_IDLE.Size = new System.Drawing.Size(51, 51);
            this.btn_IDLE.TabIndex = 98;
            this.btn_IDLE.TabStop = false;
            this.btn_IDLE.UseVisualStyleBackColor = true;
            // 
            // Popup_PCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_IDLE);
            this.Controls.Add(this.label13);
            this.Name = "Popup_PCS";
            this.Text = "Popup_PCS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_IDLE;
        private System.Windows.Forms.Label label13;
    }
}