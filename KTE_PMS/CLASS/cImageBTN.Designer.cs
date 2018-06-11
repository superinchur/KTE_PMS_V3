using System.ComponentModel;
using System.Windows.Forms;

namespace KTE_PMS.CLASS
{
    partial class cImageBTN
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
            this._tsMain = new System.Windows.Forms.ToolStrip();
            this._bButton = new System.Windows.Forms.ToolStripButton();
            this._tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tsMain
            // 
            this._tsMain.BackColor = System.Drawing.Color.Transparent;
            this._tsMain.CanOverflow = false;
            this._tsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tsMain.GripMargin = new System.Windows.Forms.Padding(0);
            this._tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._bButton});
            this._tsMain.Location = new System.Drawing.Point(0, 0);
            this._tsMain.Name = "_tsMain";
            this._tsMain.Size = new System.Drawing.Size(25, 25);
            this._tsMain.TabIndex = 0;
            // 
            // _bButton
            // 
            this._bButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._bButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._bButton.Name = "_bButton";
            this._bButton.Size = new System.Drawing.Size(23, 216);
            // 
            // cImageBTN
            // 
            this.Controls.Add(this._tsMain);
            this.Name = "cImageBTN";
            this.Size = new System.Drawing.Size(25, 25);
            this._tsMain.ResumeLayout(false);
            this._tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
    }
}
