using System;
using System.Drawing;
using System.Windows.Forms;

namespace KTE_PMS.MIMIC
{

    public partial class HistoryViewer : Viewer
    {
        const int max_row_size = 11;

        Color flashColor;

        public HistoryViewer()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();

            



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
            //Flashing_Row();
            //LoadCurrentFault();
            //Cell_Color_Painting();
        }


        public void LoadCurrentFault()
        {
            if (dataGridView1.Rows.Count > 0)
            {

                dataSet1.Clear();
            }


            dataSet1 = Repository.Instance.dbConnector.Get_Product();
            dataGridView1.DataSource = dataSet1.Tables[0];
            dataGridView1.AutoResizeColumns();
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

        private void Setting()
        {
            // 
            // dataGridView1
            // 
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new Font("굴림", 24F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("굴림", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ImeMode = ImeMode.NoControl;
            this.dataGridView1.Location = new Point(65, 68);
            this.dataGridView1.Margin = new Padding(0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("굴림", 24F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle10.Font = new Font("굴림", 20.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle10.Padding = new Padding(2);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("굴림", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new Size(835, 116);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadCurrentFault();
        }
    }
}
