namespace KTE_PMS.MIMIC
{
    partial class PCSViewer
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
            this.SuspendLayout();
            // 
            // PCSViewer
            // 
            this.ClientSize = new System.Drawing.Size(648, 456);
            this.Name = "PCSViewer";
            this.ResumeLayout(false);

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