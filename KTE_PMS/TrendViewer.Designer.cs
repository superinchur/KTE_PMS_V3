namespace KTE_PMS
{
    partial class TrendViewer
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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrendViewer));
            DevExpress.XtraCharts.TextAnnotation textAnnotation1 = new DevExpress.XtraCharts.TextAnnotation();
            DevExpress.XtraCharts.ChartAnchorPoint chartAnchorPoint1 = new DevExpress.XtraCharts.ChartAnchorPoint();
            DevExpress.XtraCharts.FreePosition freePosition1 = new DevExpress.XtraCharts.FreePosition();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.TextAnnotation textAnnotation2 = new DevExpress.XtraCharts.TextAnnotation();
            DevExpress.XtraCharts.ChartAnchorPoint chartAnchorPoint2 = new DevExpress.XtraCharts.ChartAnchorPoint();
            DevExpress.XtraCharts.FreePosition freePosition2 = new DevExpress.XtraCharts.FreePosition();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.TextAnnotation textAnnotation3 = new DevExpress.XtraCharts.TextAnnotation();
            DevExpress.XtraCharts.ChartAnchorPoint chartAnchorPoint3 = new DevExpress.XtraCharts.ChartAnchorPoint();
            DevExpress.XtraCharts.FreePosition freePosition3 = new DevExpress.XtraCharts.FreePosition();
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.TextAnnotation textAnnotation4 = new DevExpress.XtraCharts.TextAnnotation();
            DevExpress.XtraCharts.ChartAnchorPoint chartAnchorPoint4 = new DevExpress.XtraCharts.ChartAnchorPoint();
            DevExpress.XtraCharts.FreePosition freePosition4 = new DevExpress.XtraCharts.FreePosition();
            DevExpress.XtraCharts.XYDiagram xyDiagram4 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView4 = new DevExpress.XtraCharts.LineSeriesView();
            this.trend_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Battery = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Grid = new System.Windows.Forms.Button();
            this.chartControl4 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl3 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.trend_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).BeginInit();
            this.SuspendLayout();
            // 
            // trend_dataBindingSource
            // 
            this.trend_dataBindingSource.DataMember = "trend_data";
            this.trend_dataBindingSource.DataSource = this.sqlDataSource1;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_mysql_Connection_v1.0";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "DATETIME";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"134\" />";
            table1.Name = "trend_data";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "VOLTAGE";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "CURRENT";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "POWER";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Name = "trend_data";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // chartControl1
            // 
            textAnnotation1.AnchorPoint = chartAnchorPoint1;
            textAnnotation1.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None;
            textAnnotation1.Name = "Annotation 1";
            freePosition1.InnerIndents.Left = 43;
            freePosition1.InnerIndents.Top = 15;
            textAnnotation1.ShapePosition = freePosition1;
            textAnnotation1.Text = "전력";
            this.chartControl1.AnnotationRepository.AddRange(new DevExpress.XtraCharts.Annotation[] {
            textAnnotation1});
            this.chartControl1.DataSource = this.trend_dataBindingSource;
            xyDiagram1.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.None;
            xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = false;
            xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Second;
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Second;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.EnableAxisXScrolling = true;
            xyDiagram1.EnableAxisXZooming = true;
            xyDiagram1.EnableAxisYScrolling = true;
            xyDiagram1.EnableAxisYZooming = true;
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(43, 61);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "DATETIME";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series1.DataSource = this.trend_dataBindingSource;
            series1.Name = "Series 1";
            series1.ValueDataMembersSerializable = "POWER";
            series1.View = lineSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(741, 115);
            this.chartControl1.TabIndex = 2;
            this.chartControl1.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(358, 10);
            this.maskedTextBox1.Mask = "0000년90월90일 90시90분";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(177, 21);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(153, 10);
            this.maskedTextBox2.Mask = "0000년90월90일 90시90분";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(177, 21);
            this.maskedTextBox2.TabIndex = 4;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "직접설정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.적용);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(633, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "1일";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(567, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "1시간";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(501, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "10분";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Export_Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(120, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "전력";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(174, 37);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.Text = "전력누계";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(250, 36);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(48, 16);
            this.checkBox3.TabIndex = 27;
            this.checkBox3.Text = "전압";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(304, 36);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(48, 16);
            this.checkBox4.TabIndex = 28;
            this.checkBox4.Text = "전류";
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(54, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 14);
            this.label1.TabIndex = 29;
            this.label1.Text = "조회기간";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(54, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 30;
            this.label2.Text = "조회항목";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(111, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 14);
            this.label3.TabIndex = 31;
            this.label3.Text = "From";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(332, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 14);
            this.label4.TabIndex = 32;
            this.label4.Text = "To";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Battery
            // 
            this.btn_Battery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_Battery.BackgroundImage = global::KTE_PMS.Properties.Resources.배터리_off;
            this.btn_Battery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Battery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Battery.Location = new System.Drawing.Point(843, 83);
            this.btn_Battery.Name = "btn_Battery";
            this.btn_Battery.Size = new System.Drawing.Size(82, 92);
            this.btn_Battery.TabIndex = 81;
            this.btn_Battery.UseVisualStyleBackColor = false;
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_Load.BackgroundImage = global::KTE_PMS.Properties.Resources.LOAD_off;
            this.btn_Load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Load.Location = new System.Drawing.Point(843, 309);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(82, 92);
            this.btn_Load.TabIndex = 82;
            this.btn_Load.UseVisualStyleBackColor = false;
            // 
            // btn_Grid
            // 
            this.btn_Grid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_Grid.BackgroundImage = global::KTE_PMS.Properties.Resources.Grid_off;
            this.btn_Grid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Grid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Grid.Location = new System.Drawing.Point(843, 196);
            this.btn_Grid.Name = "btn_Grid";
            this.btn_Grid.Size = new System.Drawing.Size(82, 92);
            this.btn_Grid.TabIndex = 83;
            this.btn_Grid.UseVisualStyleBackColor = false;
            // 
            // chartControl4
            // 
            textAnnotation2.AnchorPoint = chartAnchorPoint2;
            textAnnotation2.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None;
            textAnnotation2.Name = "Annotation 1";
            freePosition2.InnerIndents.Left = 43;
            freePosition2.InnerIndents.Top = 13;
            textAnnotation2.ShapePosition = freePosition2;
            textAnnotation2.Text = "전류";
            this.chartControl4.AnnotationRepository.AddRange(new DevExpress.XtraCharts.Annotation[] {
            textAnnotation2});
            this.chartControl4.DataSource = this.trend_dataBindingSource;
            xyDiagram2.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.None;
            xyDiagram2.AxisX.DateTimeScaleOptions.AutoGrid = false;
            xyDiagram2.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Second;
            xyDiagram2.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Second;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram2.EnableAxisXScrolling = true;
            xyDiagram2.EnableAxisXZooming = true;
            xyDiagram2.EnableAxisYScrolling = true;
            xyDiagram2.EnableAxisYZooming = true;
            this.chartControl4.Diagram = xyDiagram2;
            this.chartControl4.Legend.Name = "Default Legend";
            this.chartControl4.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl4.Location = new System.Drawing.Point(43, 302);
            this.chartControl4.Name = "chartControl4";
            series2.ArgumentDataMember = "DATETIME";
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series2.DataSource = this.trend_dataBindingSource;
            series2.Name = "Series 1";
            series2.ValueDataMembersSerializable = "VOLTAGE";
            series2.View = lineSeriesView2;
            this.chartControl4.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl4.Size = new System.Drawing.Size(744, 115);
            this.chartControl4.TabIndex = 24;
            this.chartControl4.Click += new System.EventHandler(this.chartControl4_Click);
            // 
            // chartControl2
            // 
            textAnnotation3.AnchorPoint = chartAnchorPoint3;
            textAnnotation3.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None;
            textAnnotation3.Name = "Annotation 1";
            freePosition3.InnerIndents.Left = 39;
            freePosition3.InnerIndents.Top = 14;
            textAnnotation3.ShapePosition = freePosition3;
            textAnnotation3.Text = "전력누계";
            this.chartControl2.AnnotationRepository.AddRange(new DevExpress.XtraCharts.Annotation[] {
            textAnnotation3});
            this.chartControl2.DataSource = this.trend_dataBindingSource;
            xyDiagram3.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.None;
            xyDiagram3.AxisX.DateTimeScaleOptions.AutoGrid = false;
            xyDiagram3.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Second;
            xyDiagram3.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Second;
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisX.VisualRange.Auto = false;
            xyDiagram3.AxisX.VisualRange.MaxValueSerializable = "07/23/2018 10:54:33.000";
            xyDiagram3.AxisX.VisualRange.MinValueSerializable = "07/23/2018 10:54:24.000";
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.VisualRange.Auto = false;
            xyDiagram3.AxisY.VisualRange.MaxValueSerializable = "5.742";
            xyDiagram3.AxisY.VisualRange.MinValueSerializable = "4.5936";
            xyDiagram3.EnableAxisXScrolling = true;
            xyDiagram3.EnableAxisXZooming = true;
            xyDiagram3.EnableAxisYScrolling = true;
            xyDiagram3.EnableAxisYZooming = true;
            this.chartControl2.Diagram = xyDiagram3;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl2.Location = new System.Drawing.Point(829, 13);
            this.chartControl2.Name = "chartControl2";
            series3.ArgumentDataMember = "DATETIME";
            series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series3.DataSource = this.trend_dataBindingSource;
            series3.Name = "Series 1";
            series3.ValueDataMembersSerializable = "CURRENT";
            series3.View = lineSeriesView3;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.chartControl2.Size = new System.Drawing.Size(77, 53);
            this.chartControl2.TabIndex = 6;
            this.chartControl2.Click += new System.EventHandler(this.chartControl2_Click);
            // 
            // chartControl3
            // 
            textAnnotation4.AnchorPoint = chartAnchorPoint4;
            textAnnotation4.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None;
            textAnnotation4.Name = "Annotation 1";
            freePosition4.InnerIndents.Left = 43;
            freePosition4.InnerIndents.Top = 13;
            textAnnotation4.ShapePosition = freePosition4;
            textAnnotation4.Text = "전압";
            this.chartControl3.AnnotationRepository.AddRange(new DevExpress.XtraCharts.Annotation[] {
            textAnnotation4});
            this.chartControl3.DataSource = this.trend_dataBindingSource;
            xyDiagram4.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.None;
            xyDiagram4.AxisX.DateTimeScaleOptions.AutoGrid = false;
            xyDiagram4.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Second;
            xyDiagram4.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Second;
            xyDiagram4.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram4.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram4.EnableAxisXScrolling = true;
            xyDiagram4.EnableAxisXZooming = true;
            xyDiagram4.EnableAxisYScrolling = true;
            xyDiagram4.EnableAxisYZooming = true;
            this.chartControl3.Diagram = xyDiagram4;
            this.chartControl3.Legend.Name = "Default Legend";
            this.chartControl3.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl3.Location = new System.Drawing.Point(42, 182);
            this.chartControl3.Name = "chartControl3";
            series4.ArgumentDataMember = "DATETIME";
            series4.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series4.DataSource = this.trend_dataBindingSource;
            series4.Name = "Series 1";
            series4.ValueDataMembersSerializable = "VOLTAGE";
            series4.View = lineSeriesView4;
            this.chartControl3.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4};
            this.chartControl3.Size = new System.Drawing.Size(744, 115);
            this.chartControl3.TabIndex = 7;
            this.chartControl3.Click += new System.EventHandler(this.chartControl3_Click);
            // 
            // TrendViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_Grid);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_Battery);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chartControl4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chartControl3);
            this.Controls.Add(this.chartControl2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.chartControl1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TrendViewer";
            this.Load += new System.EventHandler(this.TrendViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trend_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource trend_dataBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Battery;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Grid;
        private DevExpress.XtraCharts.ChartControl chartControl4;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraCharts.ChartControl chartControl3;
    }
}