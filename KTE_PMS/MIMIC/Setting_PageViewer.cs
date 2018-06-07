using System;
using System.Linq;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{
    public partial class Setting_PageViewer : Viewer
    {
        public Setting_PageViewer()
        {
            InitializeComponent();
        }

        private void AccessToOperatingSystem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure to finish the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                // exit program    
                Application.Exit();
            }
            else
            {
                // nothing happened
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Repository.Instance.bmsviewer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Repository.Instance.modbus_rtuviewer.Show();

        }
    }
}
