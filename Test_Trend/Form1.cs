﻿using DevExpress.XtraCharts;
using KTE_PMS;
using System;
using System.Linq;
using System.Windows.Forms;


namespace Test_Trend
{
    public partial class Form1 : Form
    {
        Series[] series = new Series[2];
        DateTime[] cdatetTime;
        Double[] cVoltage;


        public DBConnector dbConnector;


        public Form1()
        {
            InitializeComponent();


            dbConnector = new DBConnector();

            series[0] = new Series("time1", ViewType.Line);

            cdatetTime = new DateTime[10];
            cVoltage = new double[10];
            /*
            chartControl1.Series.Add(series[0]);


            series[0].ArgumentDataMember = "DATETIME";
            series[0].ArgumentScaleType = ScaleType.DateTime;
            series[0].ValueDataMembers.AddRange(new string[] { "VOLTAGE" });
            series[0].ValueScaleType = ScaleType.Numerical;
            */
            //chartControl1.Series[0].ValueDataMembers[0].

            // Set some properties to get a nice-looking chart.

            ((XYDiagram)chartControl1.Diagram).AxisY.Visibility = DevExpress.Utils.DefaultBoolean.False;
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            SetDiagramTimeRange((XYDiagram)chartControl1.Diagram, 1440);

            timer1.Interval = 400;      // 0.4초

            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource

            sqlDataSource1.Fill();
        }

        private void SetDiagramTimeRange(XYDiagram diagram, int diff)
        {

            //DateTime dt1 = DateTime.Now.AddHours(1);
            //DateTime dt2 = DateTime.Now.AddHours(-1);
            if (diff != 0)
            {
                DateTime dt1 = DateTime.Now.AddMinutes(diff);
                DateTime dt2 = DateTime.Now.AddMinutes(-1 * diff);
                /*
                //DateTime dt = Convert.ToDateTime(diagram.AxisX.VisualRange.MaxValue);          
                maskedTextBox1.Text = dt1.Year.ToString("D4") + "년" + dt1.Month.ToString("D2") + "월" + dt1.Day.ToString("D2") + "일 " + dt1.Hour.ToString("D2") + "시" + dt1.Minute.ToString("D2") + "분";
                //dt = Convert.ToDateTime(diagram.AxisX.VisualRange.MinValue);
                maskedTextBox2.Text = dt2.Year.ToString("D4") + "년" + dt2.Month.ToString("D2") + "월" + dt2.Day.ToString("D2") + "일 " + dt2.Hour.ToString("D2") + "시" + dt2.Minute.ToString("D2") + "분";
                */
                maskedTextBox1.Text = dt1.Year.ToString("D4") + "년" + dt1.Month.ToString("D2") + "월" + dt1.Day.ToString("D2") + "일 " + dt1.Hour.ToString("D2") + "시" + dt1.Minute.ToString("D2") + "분";
                maskedTextBox2.Text = dt2.Year.ToString("D4") + "년" + dt2.Month.ToString("D2") + "월" + dt2.Day.ToString("D2") + "일 " + dt2.Hour.ToString("D2") + "시" + dt2.Minute.ToString("D2") + "분";
            }

            /*
            diagram.AxisX.WholeRange.Auto = false;
            diagram.AxisX.VisualRange.Auto = false;
            
            diagram.AxisX.VisualRange.AutoSideMargins = false;
            diagram.AxisX.WholeRange.AutoSideMargins = false;
            */

            DateTime t_Datetime_Maxvalue = DateTime.Parse(maskedTextBox1.Text.Trim());
            diagram.AxisX.VisualRange.MaxValue = t_Datetime_Maxvalue;
            diagram.AxisX.WholeRange.MaxValue = t_Datetime_Maxvalue;

            DateTime t_Datetime_Minvalue = DateTime.Parse(maskedTextBox2.Text.Trim());
            diagram.AxisX.VisualRange.MinValue = t_Datetime_Minvalue;
            diagram.AxisX.WholeRange.MinValue = t_Datetime_Minvalue;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dbConnector.Insert_Voltage();
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            dbConnector.GetProduct();
            sqlDataSource1.Fill();
            //chartControl1.RefreshData();

        }

        private void 적용(object sender, EventArgs e)
        {
            try
            {
                SetDiagramTimeRange((XYDiagram)chartControl1.Diagram, 0);
            }
            catch (Exception)
            {

            }
        }

        private void maskedTextBox2_MaskInputRejected(object sender, System.Windows.Forms.MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox2.MaskFull)
            {
                MessageBox.Show("모든 사항이 입력되었습니다. 추가입력이 불가합니다");
            }
            else if (e.Position == maskedTextBox2.Mask.Length)
            {
                MessageBox.Show("마스크 위치를 넘어섰습니다. 입력이 불가합니다");
            }
            else
            {
                MessageBox.Show("숫자만 입력해야 합니다. 입력이 불가합니다");
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, System.Windows.Forms.MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox1.MaskFull)
            {
                MessageBox.Show("모든 사항이 입력되었습니다. 추가입력이 불가합니다");
            }
            else if (e.Position == maskedTextBox1.Mask.Length)
            {
                MessageBox.Show("마스크 위치를 넘어섰습니다. 입력이 불가합니다");
            }
            else
            {
                MessageBox.Show("숫자만 입력해야 합니다. 입력이 불가합니다");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox a = (CheckBox)sender;
            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;

            if (a.Checked)
            {
                diagram.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Automatic;
            }
            else
            {
                diagram.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Manual;
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox a = (CheckBox)sender;
            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;

            if (a.Checked)
            {
                diagram.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Continuous ;
            }
            else
            {
                diagram.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Manual;
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox a = (CheckBox)sender;
            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;

            if (a.Checked)
            {
                diagram.AxisX.WholeRange.AutoSideMargins = true;
                diagram.AxisX.VisualRange.AutoSideMargins = true;
            }
            else
            {
                diagram.AxisX.WholeRange.AutoSideMargins = false;
                diagram.AxisX.VisualRange.AutoSideMargins = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox a = (CheckBox)sender;
            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;

            if (a.Checked)
            {
                diagram.AxisX.WholeRange.Auto = true;
                diagram.AxisX.VisualRange.Auto = true;
            }
            else
            {
                diagram.AxisX.WholeRange.Auto = false;
                diagram.AxisX.VisualRange.Auto = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetDiagramTimeRange((XYDiagram)chartControl1.Diagram, 10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetDiagramTimeRange((XYDiagram)chartControl1.Diagram, 60);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetDiagramTimeRange((XYDiagram)chartControl1.Diagram, 1440);
        }
    }
}
