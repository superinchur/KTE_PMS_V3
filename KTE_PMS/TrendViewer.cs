﻿using DevExpress.Utils;
using DevExpress.XtraCharts;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Forms;

namespace KTE_PMS
{
    public partial class TrendViewer : MIMIC.Viewer
    {
        public TrendViewer()
        {
            InitializeComponent();

            

            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;
            XYDiagram diagram1 = (XYDiagram)chartControl2.Diagram;
            XYDiagram diagram2 = (XYDiagram)chartControl3.Diagram;

            diagram.AxisX.Label.TextPattern = "{A: yy/MM/dd hh:mm}";
            diagram1.AxisX.Label.TextPattern = "{A: yy/MM/dd hh:mm}";
            diagram2.AxisX.Label.TextPattern = "{A: yy/MM/dd hh:mm}";

            diagram.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Continuous;
            diagram1.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Continuous;
            diagram2.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Continuous;

            sqlDataSource1.Fill();

            timer1.Interval = 1000;      // 1초

            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sqlDataSource1.Fill();
            chartControl1.RefreshData();

            if (Properties.Settings.Default.DEBUG)
            {
                // AugoGenerating
                Random rand = new Random();
               
                Repository.Instance.dbConnector.Insert_Value_to_Database(rand.Next(800,1000) / 10, rand.Next(100,200)/10 ,rand.Next(300,400)/10);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Repository.Instance.dbConnector.Insert_Value_to_Database();

        }

        private void 적용(object sender, EventArgs e)
        {
            SetDiagramTimeRange((XYDiagram)chartControl1.Diagram, 0);
            SetDiagramTimeRange((XYDiagram)chartControl2.Diagram, 0);
            SetDiagramTimeRange((XYDiagram)chartControl3.Diagram, 0);
        }

        private void maskedTextBox2_MaskInputRejected(object sender, System.Windows.Forms.MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox2.MaskFull)
            {
                System.Windows.MessageBox.Show("모든 사항이 입력되었습니다. 추가입력이 불가합니다");
            }
            else if (e.Position == maskedTextBox2.Mask.Length)
            {
                System.Windows.MessageBox.Show("마스크 위치를 넘어섰습니다. 입력이 불가합니다");
            }
            else
            {
                System.Windows.MessageBox.Show("숫자만 입력해야 합니다. 입력이 불가합니다");
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, System.Windows.Forms.MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox1.MaskFull)
            {
                System.Windows.MessageBox.Show("모든 사항이 입력되었습니다. 추가입력이 불가합니다");
            }
            else if (e.Position == maskedTextBox1.Mask.Length)
            {
                System.Windows.MessageBox.Show("마스크 위치를 넘어섰습니다. 입력이 불가합니다");
            }
            else
            {
                System.Windows.MessageBox.Show("숫자만 입력해야 합니다. 입력이 불가합니다");
            }
        }

        private void SetDiagramTimeRange(XYDiagram diagram, int diff)
        {
            try
            { 
                if (diff != 0)
                {
                    DateTime dt1 = DateTime.Now.AddMinutes(diff);
                    DateTime dt2 = DateTime.Now.AddMinutes(-1 * diff);

                    maskedTextBox1.Text = dt1.Year.ToString("D4") + "년" + dt1.Month.ToString("D2") + "월" + dt1.Day.ToString("D2") + "일 " + dt1.Hour.ToString("D2") + "시" + dt1.Minute.ToString("D2") + "분";
                    maskedTextBox2.Text = dt2.Year.ToString("D4") + "년" + dt2.Month.ToString("D2") + "월" + dt2.Day.ToString("D2") + "일 " + dt2.Hour.ToString("D2") + "시" + dt2.Minute.ToString("D2") + "분";
                }


                DateTime t_Datetime_Maxvalue = DateTime.Parse(maskedTextBox1.Text.Trim());
                diagram.AxisX.VisualRange.MaxValue = t_Datetime_Maxvalue;
                diagram.AxisX.WholeRange.MaxValue = t_Datetime_Maxvalue;

                DateTime t_Datetime_Minvalue = DateTime.Parse(maskedTextBox2.Text.Trim());
                diagram.AxisX.VisualRange.MinValue = t_Datetime_Minvalue;
                diagram.AxisX.WholeRange.MinValue = t_Datetime_Minvalue;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox a = (CheckBox)sender;
            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;
            XYDiagram diagram1 = (XYDiagram)chartControl2.Diagram;
            XYDiagram diagram2 = (XYDiagram)chartControl3.Diagram;

            if (a.Checked)
            {
                diagram.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Automatic;
                diagram1.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Automatic;
                diagram2.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Automatic;
            }
            else
            {
                diagram.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Manual;
                diagram1.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Manual;
                diagram2.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Manual;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox a = (CheckBox)sender;
            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;
            XYDiagram diagram1 = (XYDiagram)chartControl2.Diagram;
            XYDiagram diagram2 = (XYDiagram)chartControl3.Diagram;

            if (a.Checked)
            {
                diagram.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Continuous;
                diagram1.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Continuous;
                diagram2.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Continuous;
            }
            else
            {
                diagram.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Manual;
                diagram1.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Manual;
                diagram2.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Manual;
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox a = (CheckBox)sender;
            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;
            XYDiagram diagram1 = (XYDiagram)chartControl2.Diagram;
            XYDiagram diagram2 = (XYDiagram)chartControl3.Diagram;

            if (a.Checked)
            {
                diagram.AxisX.WholeRange.AutoSideMargins = true;
                diagram.AxisX.VisualRange.AutoSideMargins = true;

                diagram1.AxisX.WholeRange.AutoSideMargins = true;
                diagram1.AxisX.VisualRange.AutoSideMargins = true;

                diagram2.AxisX.WholeRange.AutoSideMargins = true;
                diagram2.AxisX.VisualRange.AutoSideMargins = true;
            }
            else
            {
                diagram.AxisX.WholeRange.AutoSideMargins = false;
                diagram.AxisX.VisualRange.AutoSideMargins = false;

                diagram1.AxisX.WholeRange.AutoSideMargins = false;
                diagram1.AxisX.VisualRange.AutoSideMargins = false;

                diagram2.AxisX.WholeRange.AutoSideMargins = false;
                diagram2.AxisX.VisualRange.AutoSideMargins = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox a = (CheckBox)sender;
            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;
            XYDiagram diagram1 = (XYDiagram)chartControl2.Diagram;
            XYDiagram diagram2 = (XYDiagram)chartControl3.Diagram;

            if (a.Checked)
            {
                diagram.AxisX.WholeRange.Auto = true;
                diagram.AxisX.VisualRange.Auto = true;

                diagram1.AxisX.WholeRange.Auto = true;
                diagram1.AxisX.VisualRange.Auto = true;

                diagram2.AxisX.WholeRange.Auto = true;
                diagram2.AxisX.VisualRange.Auto = true;
            }
            else
            {
                diagram.AxisX.WholeRange.Auto = false;
                diagram.AxisX.VisualRange.Auto = false;

                diagram1.AxisX.WholeRange.Auto = false;
                diagram1.AxisX.VisualRange.Auto = false;

                diagram2.AxisX.WholeRange.Auto = false;
                diagram2.AxisX.VisualRange.Auto = false;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SetDiagramTimeRange((XYDiagram)chartControl1.Diagram, 10);
            SetDiagramTimeRange((XYDiagram)chartControl2.Diagram, 10);
            SetDiagramTimeRange((XYDiagram)chartControl3.Diagram, 10);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SetDiagramTimeRange((XYDiagram)chartControl1.Diagram, 60);
            SetDiagramTimeRange((XYDiagram)chartControl2.Diagram, 60);
            SetDiagramTimeRange((XYDiagram)chartControl3.Diagram, 60);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            SetDiagramTimeRange((XYDiagram)chartControl1.Diagram, 1440);
            SetDiagramTimeRange((XYDiagram)chartControl2.Diagram, 1440);
            SetDiagramTimeRange((XYDiagram)chartControl3.Diagram, 1440);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == System.Windows.Forms.MessageBox.Show("Are you sure to export trending data?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                Repository.Instance.dbConnector.Export_Data();
            }

        }

        private void TrendViewer_Load(object sender, EventArgs e)
        {

        }
    }
}

