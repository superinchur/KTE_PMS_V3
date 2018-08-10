using KTE_PMS.CLASS;
using KTE_PMS.Popup;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{

    public partial class HistoryViewer : Viewer
    {
        const int max_row_size = 11;

        Color flashColor;
        public int diff;

        public HistoryViewer()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();

            tb_startTimePicker.Format = DateTimePickerFormat.Custom;
            tb_startTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            tb_endTimePicker.Format = DateTimePickerFormat.Custom;
            tb_endTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";



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
                    string arg1 = tb_startTimePicker.Text;
                    string arg2 = tb_endTimePicker.Text;
                    dataSet1 = Repository.Instance.dbConnector.Get_Product(arg1, arg2);
                }

                dataGridView1.DataSource = dataSet1.Tables[0];
                dataGridView1.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
                dataGridView1.Columns[0].Width = 360;
                dataGridView1.Columns[0].ReadOnly = true;

                dataGridView1.Columns[1].Width = 170;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].Width = 160;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].Width = 540;
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[4].Width = 360;
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

            btn_Update_1Day_Click(null, null);

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font("나눔바른고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            //style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.Columns[0].HeaderCell.Style = style;
            dataGridView1.Columns[1].HeaderCell.Style = style;
            dataGridView1.Columns[2].HeaderCell.Style = style;
            dataGridView1.Columns[3].HeaderCell.Style = style;
            dataGridView1.Columns[4].HeaderCell.Style = style;
        }

        private void Set_TimeTextBox(int diff)
        {
            DateTime dt1 = new DateTime();
            DateTime dt2 = new DateTime();

            if (diff == 1440)
            {
                //dt1 = DateTime.Now.AddDays(-1);
                dt1 = DateTime.Now;
                dt2 = DateTime.Now;


                tb_startTimePicker.Text = dt1.Year.ToString("D4") + "-" + dt1.Month.ToString("D2") + "-" + dt1.Day.ToString("D2") + " 00:00:00";
                tb_endTimePicker.Text = dt2.Year.ToString("D4") + "-" + dt2.Month.ToString("D2") + "-" + dt2.Day.ToString("D2") + " 23:59:59";
            }
            else if (diff == 43200)
            {
                //dt1 = DateTime.Now.AddMonths(-1);
                dt1 = DateTime.Now;
                dt2 = DateTime.Now;


                tb_startTimePicker.Text = dt1.Year.ToString("D4") + "-" + dt1.Month.ToString("D2") + "-" + "01" + " 00:00:00";
                tb_endTimePicker.Text = dt2.Year.ToString("D4") + "-" + dt2.Month.ToString("D2") + "-" + dt2.Day.ToString("D2") + " 23:59:59";
            }
            else
            {
                dt1 = DateTime.Now.AddMinutes(-1 * diff);
                dt2 = DateTime.Now;

                tb_startTimePicker.Text = dt1.Year.ToString("D4") + "-" + dt1.Month.ToString("D2") + "-" + dt1.Day.ToString("D2") + " 00:00:00";
                tb_endTimePicker.Text = dt2.Year.ToString("D4") + "-" + dt2.Month.ToString("D2") + "-" + dt2.Day.ToString("D2") + " 23:59:59";
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

        #region Button_Image_처리관련함수들
        private void btn_TO_ALARM_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.alarm_on1, button.Width, button.Height);
        }

        private void btn_TO_ALARM_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void btn_TO_HISTORY_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.history_on, button.Width, button.Height);
        }

        private void btn_TO_HISTORY_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void btn_Update_1Day_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources._1day_on, button.Width, button.Height);
        }

        private void btn_Update_1Day_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void btn_Update_1Month_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources._1month_off , button.Width, button.Height);
        }

        private void btn_Update_1Month_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.all_on , button.Width, button.Height);
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void btn_Update_Manual_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.setup_on , button.Width, button.Height);
        }

        private void btn_Update_Manual_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.update_on , button.Width, button.Height);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }
        #endregion

        private void tb_startTime_Click(object sender, EventArgs e)
        {
            DateTimePicker picker = new DateTimePicker();

            picker.Format = DateTimePickerFormat.Custom;
            picker.CustomFormat = "yyyy월mm년dd일 HH:mm:ss";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Popup_History_Search a = new Popup_History_Search();

                a.Show();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.검색_on, button.Width, button.Height);
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }
    }
}
