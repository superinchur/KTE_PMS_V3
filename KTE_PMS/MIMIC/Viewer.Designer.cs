﻿namespace KTE_PMS.MIMIC
{
    partial class Viewer
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
            this.components = new System.ComponentModel.Container();
            this.Viewer_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Viewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Name = "Viewer";
            this.Size = new System.Drawing.Size(960, 434);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Timer Viewer_Timer;
    }
}