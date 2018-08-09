using KTE_PMS.MIMIC;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KTE_PMS.Popup
{
    public partial class Popup_History_Search : Form
    {

        DataTable Filter_Tag_Data_Table;

        public Popup_History_Search()
        {
            InitializeComponent();
        }

        
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            HistoryViewer a = Repository.Instance.p_history;
            
            try
            {
                if (a.dataGridView1.Rows.Count > 0)
                {
                    a.dataSet1.Clear();
                }

                if (a.diff == 0)
                {
                    a.dataSet1 = Repository.Instance.dbConnector.Get_Product();
                }
                else
                {
                    string arg1 = a.tb_startTimePicker.Text;
                    string arg2 = a.tb_endTimePicker.Text;
                    a.dataSet1 = Repository.Instance.dbConnector.Get_Product(arg1, arg2);
                }


                Filter_Tag_Data_Table = a.dataSet1.Tables[0];
                string expression = tb_System_Filter.Text.Trim();

                
                if (expression != "")
                {
                    Filter_Tag_Data_Table = Filter_Tag_Data_Table.AsEnumerable()
                                            .Where(row => row.Field<String>("DEVICE").Contains(expression))
                                              .CopyToDataTable();
                }
                

                string expression1 = tb_Description_Filter.Text.Trim();

                if (expression1 != "") 
                {
                    Filter_Tag_Data_Table = Filter_Tag_Data_Table.AsEnumerable()
                                            .Where(row => row.Field<String>("DESCRIPTION").Contains(expression1))
                                              .CopyToDataTable();
                }
                
                string expression2 = tb_IO_Filter.Text.Trim();

                if (expression2 != "")
                {
                    Filter_Tag_Data_Table = Filter_Tag_Data_Table.AsEnumerable()
                                            .Where(row => row.Field<String>("IO").Contains(expression2))
                                              .CopyToDataTable();
                }
                

                if (expression == String.Empty && expression1 == String.Empty && expression2 == String.Empty)
                {
                    a.dataGridView1.DataSource = a.dataSet1.Tables[0];
                }
                else
                {
                    a.dataGridView1.DataSource = Filter_Tag_Data_Table;
                }

                a.dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
}

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }
    }
}
