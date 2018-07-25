namespace KTE_PMS.MIMIC
{
    partial class AlarmViewer
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DATETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEVICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PREV = new System.Windows.Forms.Button();
            this.NEXT = new System.Windows.Forms.Button();
            this.btnACK = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_TO_HISTORY = new System.Windows.Forms.Button();
            this.btn_TO_ALARM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("굴림", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DATETIME,
            this.CLASS,
            this.DEVICE,
            this.DESCRIPTION,
            this.IO});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(55, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(851, 361);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // DATETIME
            // 
            this.DATETIME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DATETIME.DefaultCellStyle = dataGridViewCellStyle13;
            this.DATETIME.HeaderText = "TIME";
            this.DATETIME.MinimumWidth = 100;
            this.DATETIME.Name = "DATETIME";
            this.DATETIME.ReadOnly = true;
            this.DATETIME.Width = 180;
            // 
            // CLASS
            // 
            this.CLASS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CLASS.DefaultCellStyle = dataGridViewCellStyle14;
            this.CLASS.HeaderText = "CLASS";
            this.CLASS.MinimumWidth = 50;
            this.CLASS.Name = "CLASS";
            this.CLASS.ReadOnly = true;
            // 
            // DEVICE
            // 
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DEVICE.DefaultCellStyle = dataGridViewCellStyle15;
            this.DEVICE.HeaderText = "DEVICE";
            this.DEVICE.MinimumWidth = 80;
            this.DEVICE.Name = "DEVICE";
            this.DEVICE.ReadOnly = true;
            this.DEVICE.Width = 80;
            // 
            // DESCRIPTION
            // 
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DESCRIPTION.DefaultCellStyle = dataGridViewCellStyle16;
            this.DESCRIPTION.HeaderText = "DESCRIPTION";
            this.DESCRIPTION.MinimumWidth = 200;
            this.DESCRIPTION.Name = "DESCRIPTION";
            this.DESCRIPTION.ReadOnly = true;
            this.DESCRIPTION.Width = 270;
            // 
            // IO
            // 
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IO.DefaultCellStyle = dataGridViewCellStyle17;
            this.IO.HeaderText = "IO";
            this.IO.MinimumWidth = 100;
            this.IO.Name = "IO";
            this.IO.ReadOnly = true;
            this.IO.Width = 170;
            // 
            // PREV
            // 
            this.PREV.BackgroundImage = global::KTE_PMS.Properties.Resources.왼화살표_off;
            this.PREV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PREV.FlatAppearance.BorderSize = 0;
            this.PREV.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.PREV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PREV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PREV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PREV.Location = new System.Drawing.Point(299, 14);
            this.PREV.Name = "PREV";
            this.PREV.Size = new System.Drawing.Size(23, 23);
            this.PREV.TabIndex = 3;
            this.PREV.TabStop = false;
            this.PREV.UseVisualStyleBackColor = true;
            this.PREV.Click += new System.EventHandler(this.PREV_Click);
            this.PREV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PREV_MouseDown);
            this.PREV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PREV_MouseUp);
            // 
            // NEXT
            // 
            this.NEXT.BackgroundImage = global::KTE_PMS.Properties.Resources.오른화살표_off;
            this.NEXT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NEXT.FlatAppearance.BorderSize = 0;
            this.NEXT.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.NEXT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NEXT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NEXT.Location = new System.Drawing.Point(327, 14);
            this.NEXT.Name = "NEXT";
            this.NEXT.Size = new System.Drawing.Size(23, 23);
            this.NEXT.TabIndex = 4;
            this.NEXT.TabStop = false;
            this.NEXT.UseVisualStyleBackColor = true;
            this.NEXT.Click += new System.EventHandler(this.NEXT_Click);
            this.NEXT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NEXT_MouseDown);
            this.NEXT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NEXT_MouseUp);
            // 
            // btnACK
            // 
            this.btnACK.BackgroundImage = global::KTE_PMS.Properties.Resources.ack_off;
            this.btnACK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnACK.FlatAppearance.BorderSize = 0;
            this.btnACK.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnACK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnACK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnACK.Location = new System.Drawing.Point(850, 14);
            this.btnACK.Name = "btnACK";
            this.btnACK.Size = new System.Drawing.Size(47, 23);
            this.btnACK.TabIndex = 5;
            this.btnACK.TabStop = false;
            this.btnACK.UseVisualStyleBackColor = true;
            this.btnACK.Click += new System.EventHandler(this.btnACK_Click);
            this.btnACK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnACK_MouseDown);
            this.btnACK.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnACK_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_TO_HISTORY
            // 
            this.btn_TO_HISTORY.BackgroundImage = global::KTE_PMS.Properties.Resources.history_off_1;
            this.btn_TO_HISTORY.FlatAppearance.BorderSize = 0;
            this.btn_TO_HISTORY.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_TO_HISTORY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_TO_HISTORY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_TO_HISTORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TO_HISTORY.Location = new System.Drawing.Point(181, 14);
            this.btn_TO_HISTORY.Name = "btn_TO_HISTORY";
            this.btn_TO_HISTORY.Size = new System.Drawing.Size(93, 23);
            this.btn_TO_HISTORY.TabIndex = 6;
            this.btn_TO_HISTORY.TabStop = false;
            this.btn_TO_HISTORY.UseVisualStyleBackColor = true;
            this.btn_TO_HISTORY.Click += new System.EventHandler(this.btn_TO_HISTORY_Click);
            this.btn_TO_HISTORY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_TO_HISTORY_MouseDown);
            this.btn_TO_HISTORY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_TO_HISTORY_MouseUp);
            // 
            // btn_TO_ALARM
            // 
            this.btn_TO_ALARM.BackgroundImage = global::KTE_PMS.Properties.Resources.alarm_off_1;
            this.btn_TO_ALARM.FlatAppearance.BorderSize = 0;
            this.btn_TO_ALARM.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_TO_ALARM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_TO_ALARM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_TO_ALARM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TO_ALARM.Location = new System.Drawing.Point(64, 14);
            this.btn_TO_ALARM.Name = "btn_TO_ALARM";
            this.btn_TO_ALARM.Size = new System.Drawing.Size(93, 23);
            this.btn_TO_ALARM.TabIndex = 7;
            this.btn_TO_ALARM.TabStop = false;
            this.btn_TO_ALARM.UseVisualStyleBackColor = true;
            this.btn_TO_ALARM.Click += new System.EventHandler(this.btn_TO_ALARM_Click);
            this.btn_TO_ALARM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_TO_ALARM_MouseDown);
            this.btn_TO_ALARM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_TO_ALARM_MouseUp);
            // 
            // AlarmViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_TO_ALARM);
            this.Controls.Add(this.btn_TO_HISTORY);
            this.Controls.Add(this.btnACK);
            this.Controls.Add(this.NEXT);
            this.Controls.Add(this.PREV);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AlarmViewer";
            this.Load += new System.EventHandler(this.AlarmViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PREV;
        private System.Windows.Forms.Button NEXT;
        private System.Windows.Forms.Button btnACK;
        private System.Windows.Forms.Button btn_TO_HISTORY;
        private System.Windows.Forms.Button btn_TO_ALARM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATETIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEVICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn IO;
        public System.Windows.Forms.Timer timer1;
    }
}
