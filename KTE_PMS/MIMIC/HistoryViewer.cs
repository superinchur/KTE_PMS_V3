using System;
using System.Drawing;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{

    public partial class HistoryViewer : Viewer
    {
        const int max_row_size = 11;

        Color flashColor;
        private int diff;

        public HistoryViewer()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
        }


        private void btn_TO_ALARM_Click(object sender, EventArgs e)
        {
            Panel p = (Panel)Parent;
            p.Controls.Clear();
            p.Controls.Add(Repository.Instance.p_alarm);
        }

        private void btn_TO_HISTORY_Click(object sender, EventArgs e)
        {
            Panel p = (Panel)Parent;
            p.Controls.Clear();
            p.Controls.Add(Repository.Instance.p_history);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Cell_Color_Painting();
        }


        public void LoadCurrentFault()
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    dataSet1.Clear();
                }

                if (diff == 0)
                {
                    dataSet1 = Repository.Instance.dbConnector.Get_Product();
                }
                else
                {
                    DateTime arg1 = DateTime.Parse(tb_startTime.Text.Trim());
                    DateTime arg2 = DateTime.Parse(tb_endTime.Text.Trim());
                    dataSet1 = Repository.Instance.dbConnector.Get_Product(arg1.ToString(), arg2.ToString());
                }

                dataGridView1.DataSource = dataSet1.Tables[0];
                dataGridView1.Columns[0].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";
                dataGridView1.Columns[0].Width = 180;
                dataGridView1.Columns[0].ReadOnly = true;

                dataGridView1.Columns[1].Width = 85;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].Width = 80;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].Width = 270;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[4].Width = 180;
                dataGridView1.Columns[4].ReadOnly = true;

//                dataGridView1.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Cell_Color_Painting()
        {
            string type;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                type = dataGridView1.Rows[i].Cells[4].Value.ToString();

                switch (type)
                {
                    case "ACK":
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        break;
                    case "UNACK":
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = flashColor;
                        break;
                    case "UNACK NORMAL":
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                        break;
                }
            }
        }

        private void Flashing_Row()
        {
            if (flashColor == Color.Gray)
            {
                flashColor = Color.Red;
            }
            else
            {
                flashColor = Color.Gray;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadCurrentFault();
        }

        private void HistoryViewer_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            Set_TimeTextBox(diff);
            LoadCurrentFault();
        }

        private void Set_TimeTextBox(int diff)
        {
            DateTime dt1 = new DateTime();
            DateTime dt2 = new DateTime();

            if (diff == 1440)
            {
                dt1 = DateTime.Now.AddDays(-1);
                dt2 = DateTime.Now;

            }
            else if (diff == 43200)
            {
                dt1 = DateTime.Now.AddMonths(-1);
                dt2 = DateTime.Now;
            }
            else
            {
                dt1 = DateTime.Now.AddMinutes(-1 * diff);
                dt2 = DateTime.Now;
            }
            tb_startTime.Text = dt1.Year.ToString("D4") + "년" + dt1.Month.ToString("D2") + "월" + dt1.Day.ToString("D2") + "일 " + dt1.Hour.ToString("D2") + "시" + dt1.Minute.ToString("D2") + "분";
            tb_endTime.Text = dt2.Year.ToString("D4") + "년" + dt2.Month.ToString("D2") + "월" + dt2.Day.ToString("D2") + "일 " + dt2.Hour.ToString("D2") + "시" + dt2.Minute.ToString("D2") + "분";

        }

    private void tb_startTime_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MaskedTextBox tb = (MaskedTextBox)sender;

            if (tb.MaskFull)
            {
                System.Windows.MessageBox.Show("모든 사항이 입력되었습니다. 추가입력이 불가합니다");
            }
            else if (e.Position == tb.Mask.Length)
            {
                System.Windows.MessageBox.Show("마스크 위치를 넘어섰습니다. 입력이 불가합니다");
            }
            else
            {
                System.Windows.MessageBox.Show("숫자만 입력해야 합니다. 입력이 불가합니다");
            }
        }

        private void btn_Update_1Day_Click(object sender, EventArgs e)
        {
            diff = 1440;
            Set_TimeTextBox(diff);
            LoadCurrentFault();

        }

        private void btn_Update_1Month_Click(object sender, EventArgs e)
        {
            diff = 43200;
            Set_TimeTextBox(diff);
            LoadCurrentFault();
        }

        private void btn_Update_Manual_Click(object sender, EventArgs e)
        {
            diff = -1;
            LoadCurrentFault();
        }

        private void btn_Update_Total(object sender, EventArgs e)
        {
            diff = 0;
            LoadCurrentFault();
        }
    }
}
