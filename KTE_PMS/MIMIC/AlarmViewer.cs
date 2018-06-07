﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace KTE_PMS.MIMIC
{
    public partial class AlarmViewer : Viewer
    {

        //System.Threading.Timer threadingtimer = null; // 1초 타이머를 위한 함수(Main Timer)

        //bool newRowNeeded;
        //private int numberOfRows;
        const int initialSize = 0;
        Color flashColor;

        const int max_row_size = 11;

        public AlarmViewer()
        {
            InitializeComponent();
            //numberOfRows = initialSize;

            //dataGridView2.ForceInitialize();

            //GridColumn unbColumn = dataGridView2.
            //dataGridview1_
            //dataGridView1.Columns[0].Size

            //dataGridView1.AutoSizeColumnsMode  = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void Alarm_Load(object sender, EventArgs e)
        {

            threadingtimer = new System.Threading.Timer(ThreadingTimerCallback, null, 1000, 1000);

        }

        public new void ThreadingTimerCallback(object state)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    // 1초 Timer에 의해서 수행되는 코드

                    // 1초마다 Flashing을 하자

                }));
            }
            catch (ThreadAbortException ex)
            {
                MessageBox.Show("Abort", ex.Message);
                throw ex;
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
            string[] row0 = new string[4];

            row0[0] = date;
            row0[1] = type;
            row0[2] = device;
            row0[3] = description;

            dataGridView1.DefaultCellStyle.BackColor = Color.LightGray;
            //dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Green;
            //dataGridView1.Get
            dataGridView1.Rows.Add(row0);
            //newRowNeeded = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {

            AlarmTest();
        }

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
                    case "UNACK_NORMAL":
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                        break;
                }
            }
        }

        private void NEXT_Click(object sender, EventArgs e)
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

        private void PREV_Click(object sender, EventArgs e)
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
    }
}