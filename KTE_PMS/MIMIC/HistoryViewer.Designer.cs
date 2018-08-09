namespace KTE_PMS.MIMIC
{
    partial class HistoryViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataTable2 = new System.Data.DataTable();
            this.dataTable3 = new System.Data.DataTable();
            this.dataTable4 = new System.Data.DataTable();
            this.dataTable5 = new System.Data.DataTable();
            this.tb_startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tb_endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Update_1Month = new System.Windows.Forms.Button();
            this.btn_Update_1Day = new System.Windows.Forms.Button();
            this.btn_Update_Manual = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_TO_ALARM = new System.Windows.Forms.Button();
            this.btn_TO_HISTORY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(110, 93);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1696, 664);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.dataTable2,
            this.dataTable3,
            this.dataTable4,
            this.dataTable5});
            // 
            // dataTable1
            // 
            this.dataTable1.TableName = "DATETIME";
            // 
            // dataTable2
            // 
            this.dataTable2.MinimumCapacity = 100;
            this.dataTable2.TableName = "CLASS";
            // 
            // dataTable3
            // 
            this.dataTable3.MinimumCapacity = 200;
            this.dataTable3.TableName = "DEVICE";
            // 
            // dataTable4
            // 
            this.dataTable4.MinimumCapacity = 300;
            this.dataTable4.TableName = "DESCRIPTION";
            // 
            // dataTable5
            // 
            this.dataTable5.MinimumCapacity = 400;
            this.dataTable5.TableName = "IO";
            // 
            // tb_startTimePicker
            // 
            this.tb_startTimePicker.CalendarFont = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_startTimePicker.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tb_startTimePicker.Location = new System.Drawing.Point(675, 54);
            this.tb_startTimePicker.Name = "tb_startTimePicker";
            this.tb_startTimePicker.Size = new System.Drawing.Size(297, 35);
            this.tb_startTimePicker.TabIndex = 29;
            this.tb_startTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tb_endTimePicker
            // 
            this.tb_endTimePicker.CalendarFont = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_endTimePicker.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_endTimePicker.Location = new System.Drawing.Point(1019, 54);
            this.tb_endTimePicker.MaxDate = new System.DateTime(2048, 12, 31, 0, 0, 0, 0);
            this.tb_endTimePicker.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.tb_endTimePicker.Name = "tb_endTimePicker";
            this.tb_endTimePicker.Size = new System.Drawing.Size(297, 35);
            this.tb_endTimePicker.TabIndex = 30;
            this.tb_endTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label15.Font = new System.Drawing.Font("나눔바른고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(979, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 28);
            this.label15.TabIndex = 115;
            this.label15.Text = "~";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::KTE_PMS.Properties.Resources.검색_off;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1490, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 46);
            this.button2.TabIndex = 31;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::KTE_PMS.Properties.Resources.all_off;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1011, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 44);
            this.button3.TabIndex = 28;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_Update_Total);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3_MouseUp);
            // 
            // btn_Update_1Month
            // 
            this.btn_Update_1Month.BackgroundImage = global::KTE_PMS.Properties.Resources._1month_off;
            this.btn_Update_1Month.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Update_1Month.FlatAppearance.BorderSize = 0;
            this.btn_Update_1Month.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Update_1Month.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Update_1Month.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Update_1Month.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update_1Month.Location = new System.Drawing.Point(845, 7);
            this.btn_Update_1Month.Name = "btn_Update_1Month";
            this.btn_Update_1Month.Size = new System.Drawing.Size(140, 44);
            this.btn_Update_1Month.TabIndex = 27;
            this.btn_Update_1Month.UseVisualStyleBackColor = true;
            this.btn_Update_1Month.Click += new System.EventHandler(this.btn_Update_1Month_Click);
            this.btn_Update_1Month.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Update_1Month_MouseDown);
            this.btn_Update_1Month.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Update_1Month_MouseUp);
            // 
            // btn_Update_1Day
            // 
            this.btn_Update_1Day.BackgroundImage = global::KTE_PMS.Properties.Resources._1day_off;
            this.btn_Update_1Day.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Update_1Day.FlatAppearance.BorderSize = 0;
            this.btn_Update_1Day.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Update_1Day.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Update_1Day.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Update_1Day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update_1Day.Location = new System.Drawing.Point(675, 7);
            this.btn_Update_1Day.Name = "btn_Update_1Day";
            this.btn_Update_1Day.Size = new System.Drawing.Size(140, 44);
            this.btn_Update_1Day.TabIndex = 26;
            this.btn_Update_1Day.UseVisualStyleBackColor = true;
            this.btn_Update_1Day.Click += new System.EventHandler(this.btn_Update_1Day_Click);
            this.btn_Update_1Day.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Update_1Day_MouseDown);
            this.btn_Update_1Day.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Update_1Day_MouseUp);
            // 
            // btn_Update_Manual
            // 
            this.btn_Update_Manual.BackgroundImage = global::KTE_PMS.Properties.Resources.setup_off;
            this.btn_Update_Manual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Update_Manual.FlatAppearance.BorderSize = 0;
            this.btn_Update_Manual.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Update_Manual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Update_Manual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Update_Manual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update_Manual.Location = new System.Drawing.Point(1176, 7);
            this.btn_Update_Manual.Name = "btn_Update_Manual";
            this.btn_Update_Manual.Size = new System.Drawing.Size(140, 44);
            this.btn_Update_Manual.TabIndex = 23;
            this.btn_Update_Manual.UseVisualStyleBackColor = true;
            this.btn_Update_Manual.Click += new System.EventHandler(this.btn_Update_Manual_Click);
            this.btn_Update_Manual.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Update_Manual_MouseDown);
            this.btn_Update_Manual.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Update_Manual_MouseUp);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::KTE_PMS.Properties.Resources.update_off;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1646, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 11;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // btn_TO_ALARM
            // 
            this.btn_TO_ALARM.BackgroundImage = global::KTE_PMS.Properties.Resources.alarm_off1;
            this.btn_TO_ALARM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TO_ALARM.FlatAppearance.BorderSize = 0;
            this.btn_TO_ALARM.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_TO_ALARM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_TO_ALARM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_TO_ALARM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TO_ALARM.Location = new System.Drawing.Point(110, 22);
            this.btn_TO_ALARM.Name = "btn_TO_ALARM";
            this.btn_TO_ALARM.Size = new System.Drawing.Size(186, 46);
            this.btn_TO_ALARM.TabIndex = 9;
            this.btn_TO_ALARM.TabStop = false;
            this.btn_TO_ALARM.UseVisualStyleBackColor = true;
            this.btn_TO_ALARM.Click += new System.EventHandler(this.btn_TO_ALARM_Click);
            this.btn_TO_ALARM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_TO_ALARM_MouseDown);
            this.btn_TO_ALARM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_TO_ALARM_MouseUp);
            // 
            // btn_TO_HISTORY
            // 
            this.btn_TO_HISTORY.BackgroundImage = global::KTE_PMS.Properties.Resources.history_off;
            this.btn_TO_HISTORY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TO_HISTORY.FlatAppearance.BorderSize = 0;
            this.btn_TO_HISTORY.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_TO_HISTORY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_TO_HISTORY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_TO_HISTORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TO_HISTORY.Location = new System.Drawing.Point(302, 22);
            this.btn_TO_HISTORY.Name = "btn_TO_HISTORY";
            this.btn_TO_HISTORY.Size = new System.Drawing.Size(186, 46);
            this.btn_TO_HISTORY.TabIndex = 8;
            this.btn_TO_HISTORY.TabStop = false;
            this.btn_TO_HISTORY.UseVisualStyleBackColor = true;
            this.btn_TO_HISTORY.Click += new System.EventHandler(this.btn_TO_HISTORY_Click);
            this.btn_TO_HISTORY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_TO_HISTORY_MouseDown);
            this.btn_TO_HISTORY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_TO_HISTORY_MouseUp);
            // 
            // HistoryViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_endTimePicker);
            this.Controls.Add(this.tb_startTimePicker);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Update_1Month);
            this.Controls.Add(this.btn_Update_1Day);
            this.Controls.Add(this.btn_Update_Manual);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_TO_ALARM);
            this.Controls.Add(this.btn_TO_HISTORY);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HistoryViewer";
            this.Size = new System.Drawing.Size(1920, 796);
            this.Load += new System.EventHandler(this.HistoryViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_TO_ALARM;
        private System.Windows.Forms.Button btn_TO_HISTORY;
        private System.Windows.Forms.Timer timer1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataTable dataTable2;
        private System.Data.DataTable dataTable3;
        private System.Data.DataTable dataTable4;
        private System.Data.DataTable dataTable5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Update_1Day;
        private System.Windows.Forms.Button btn_Update_Manual;
        private System.Windows.Forms.Button btn_Update_1Month;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        public System.Data.DataSet dataSet1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DateTimePicker tb_startTimePicker;
        public System.Windows.Forms.DateTimePicker tb_endTimePicker;
    }
}