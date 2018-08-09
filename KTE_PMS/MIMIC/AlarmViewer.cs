using KTE_PMS.CLASS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{
    public partial class AlarmViewer : Viewer
    {

        Color flashColor;
        
        const int max_row_size = 11;

        public AlarmViewer()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Flashing_Row();
            LoadCurrentFault();
            Cell_Color_Painting();
        }

        public void LoadCurrentFault()
        {
            Repository.Instance.TagManager.Alarm_Display(ref dataGridView1, 0);
            
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

        #region ALARM_TEST
        private void RiseAlarm(cTag[] tt)
        {
            foreach (cTag i in Repository.Instance.TagManager.tt)
            {

                i.HiHi = true;

                // ----------------------------------------------------------------------------------------
                // 현재 Alarm이 정상적으로 동작하지 않기때문에 i.TimeStamp라는 함수를 둬서 시간을 표시한다
                // ----------------------------------------------------------------------------------------
                i.TimeStamp = DateTime.Now;

                // 상태는 4가지 종류가 있음
                // Unack Alarm, Unack normal, Acked Alarm, Acked Normal
                // 해당 경우를 다 판단해서 생각
                // 일단 Unack Alarm
                // 기본은 Acked Normal. 다 사라진 상태.
                if (i.AlrOnValue == true)
                {

                    if (i.UnAck == true)
                    {
                        // Unacked Alarm
                        // 빨간색 Flickering
                        MakeAlarm(Convert.ToString(i.TimeStamp), "COMM", "PCS", i.Description + "Too High");
                    }
                    else if (i.UnAck == false)
                    {
                        // Acked Alarm
                        // 빨간색
                    }

                }
                else if (i.AlrOnValue == false)
                {
                    // Acked Normal
                    // 초록색
                }


                if (i.UnAck == true)
                {
                    if (i.HiHi == true)
                    {
                        MakeAlarm(Convert.ToString(i.TimeStamp), "COMM", "PCS", i.Description + "Too High");
                    }
                    if (i.Hi == true)
                    {
                        MakeAlarm(Convert.ToString(i.TimeStamp), "COMM", "PCS", i.Description + "High");
                    }
                    if (i.Lo == true)
                    {
                        MakeAlarm(Convert.ToString(i.TimeStamp), "COMM", "PCS", i.Description + "Low");
                    }
                    if (i.LoLo == true)
                    {
                        MakeAlarm(Convert.ToString(i.TimeStamp), "COMM", "PCS", i.Description + "Too low");
                    }
                }
            }
        }

        private void AlarmTest()
        {
            string[] row0 = new string[5];

            row0[0] = DateTime.Now.ToString();
            row0[1] = "COMM";
            row0[2] = "PCS";
            row0[3] = "PCS FAULT";

            // row0[4] 는 ACK, UNACK, UNACK_NORMAL로 구성됨
            Random rando = new Random((int)DateTime.Now.Ticks);

            int rand = rando.Next(1, 4);

            switch (rand)
            {
                case 1:
                    row0[4] = "ACK";
                    break;
                case 2:
                    row0[4] = "UNACK";
                    break;
                case 3:
                    row0[4] = "UNACK_NORMAL";
                    break;
            }

            dataGridView1.Rows.Add(row0);

            //DataGridViewTextBoxRow a = new dataGridView1.Rows.DataGridViewTextBoxRow();

            // Tag가 있어야한다.
            // Tag는 Alarm의 정보 Ack 정보를 가지고 있어야함
            // Tag와 받는곳을 같이

            // Tag 이름를 추가할 때 이름 Description 연동방법을 정의
            // Tag이름 + Protocol 정의


        }
        private void MakeAlarm(string date, string type, string device, string description)
        {
            string[] row0 = new string[5];

            row0[0] = date;
            row0[1] = type;
            row0[2] = device;
            row0[3] = description;

            dataGridView1.DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.Rows.Add(row0);

        }
        private void button1_Click(object sender, EventArgs e)
        {

            AlarmTest();
        }
        #endregion

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Cell_Color_Painting();

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

        private void NEXT_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.FirstDisplayedScrollingRowIndex + max_row_size >= dataGridView1.RowCount - 1)
                {
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                }
                else
                {
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.FirstDisplayedScrollingRowIndex + max_row_size;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
}

        private void PREV_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.FirstDisplayedScrollingRowIndex - max_row_size <= 0)
                {
                    dataGridView1.FirstDisplayedScrollingRowIndex = 0;
                }
                else
                {
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.FirstDisplayedScrollingRowIndex - max_row_size;           
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private void btnACK_Click(object sender, EventArgs e)
        {
            // 일다안~~~ Unacked 인놈을 다 Ack로 변경해야한다.

            Repository.Instance.TagManager.ALARM_ACK();

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void AlarmViewer_Load(object sender, EventArgs e)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));          
            dataGridView1.Columns[0].HeaderCell.Style = style;
            dataGridView1.Columns[1].HeaderCell.Style = style;
            dataGridView1.Columns[2].HeaderCell.Style = style;
            dataGridView1.Columns[3].HeaderCell.Style = style;
            dataGridView1.Columns[4].HeaderCell.Style = style;
            
        }

        #region 버튼_Image처리관련함수들
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

        private void PREV_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.왼화살표_on, button.Width, button.Height);
        }

        private void PREV_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void NEXT_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.오른화살표_on, button.Width, button.Height);
        }

        private void NEXT_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }

        private void btnACK_MouseDown(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = ImageResize.ResizeImage(Properties.Resources.ack_on, button.Width, button.Height);
        }

        private void btnACK_MouseUp(object sender, MouseEventArgs e)
        {
            // 클릭한 버튼에 해당되는 이미지만 On Image로 변경한다 //
            Button button = (Button)sender;
            button.Image = null;
        }
        #endregion
    }
}
