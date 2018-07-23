using KTE_PMS.Observer;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{
    public partial class MeasureViewerV2 : Viewer, IUpdate
    {
        //DataTable Filter_Tag_Data_Table = new DataTable();
        DataTable Filter_Tag_Data_Table;
        public MeasureViewerV2()
        {
            InitializeComponent();


        }

        delegate void CrossThreadSafetySetText(Control ctl, String text);

        private void CSafeSetText(Control ctl, String text)
        {

            /*
             * InvokeRequired 속성 (Control.InvokeRequired, MSDN)
             *   짧게 말해서, 이 컨트롤이 만들어진 스레드와 현재의 스레드가 달라서
             *   컨트롤에서 스레드를 만들어야 하는지를 나타내는 속성입니다.  
             * 
             * InvokeRequired 속성의 값이 참이면, 컨트롤에서 스레드를 만들어 텍스트를 변경하고,
             * 그렇지 않은 경우에는 그냥 변경해도 아무 오류가 없기 때문에 텍스트를 변경합니다.
             */
            if (ctl.InvokeRequired)
                ctl.Invoke(new CrossThreadSafetySetText(CSafeSetText), ctl, text);
            else
                ctl.Text = text;
        }

        public void ObserverUpdate()
        {

        }




        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void MeasureViewerV2_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Repository.Instance.Tag_Data_Table;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //                string expression = "Description Like 'Rack1'";
                string expression = tb_Filter.Text.Trim();

                Filter_Tag_Data_Table = Repository.Instance.Tag_Data_Table.AsEnumerable()
                                            .Where(row => row.Field<String>("Description").Contains(expression))
                                              .CopyToDataTable();
                if (expression == String.Empty)
                {
                    gridControl1.DataSource = Repository.Instance.Tag_Data_Table;
                }
                else
                {
                    gridControl1.DataSource = Filter_Tag_Data_Table;
                }



                gridControl1.RefreshDataSource();
                gridControl1.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
