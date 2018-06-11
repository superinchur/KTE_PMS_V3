using System;
using System.Windows.Forms;

namespace KTE_PMS.CLASS
{
    public partial class cImageBTN : UserControl
    {

        public string ToolTipText
        {
            get { return _bButton.ToolTipText; }
            set { _bButton.ToolTipText = value; }
        }

        public bool CheckOnClick
        {
            get { return _bButton.CheckOnClick; }
            set { _bButton.CheckOnClick = value; }
        }

        public bool DoubleClickEnabled
        {
            get { return _bButton.DoubleClickEnabled; }
            set { _bButton.DoubleClickEnabled = value; }
        }

        public System.Drawing.Image Image
        {
            get { return _bButton.Image; }
            set { _bButton.Image = value; }
        }

        public new event EventHandler Click;
        public new event EventHandler DoubleClick;

        private ToolStrip _tsMain;
        private ToolStripButton _bButton;


        public cImageBTN()
        {
            InitializeComponent();
        }

        void bButton_Click(object sender, EventArgs e)
        {
            if (Click != null)
            {
                Click(this, e);
            }
        }

        void bButton_DoubleClick(object sender, EventArgs e)
        {
            if (DoubleClick != null)
            {
                DoubleClick(this, e);
            }
        }

        public class ImageButtonToolStripSystemRenderer : ToolStripSystemRenderer
        {
            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
            {
                //base.OnRenderToolStripBorder(e);
            }
        }
    }
}
