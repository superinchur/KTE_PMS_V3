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
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrendViewer));
            DevExpress.XtraCharts.TextAnnotation textAnnotation4 = new DevExpress.XtraCharts.TextAnnotation();
            DevExpress.XtraCharts.ChartAnchorPoint chartAnchorPoint4 = new DevExpress.XtraCharts.ChartAnchorPoint();
            DevExpress.XtraCharts.FreePosition freePosition4 = new DevExpress.XtraCharts.FreePosition();
            DevExpress.XtraCharts.XYDiagram xyDiagram4 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView4 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.TextAnnotation textAnnotation5 = new DevExpress.XtraCharts.TextAnnotation();
            DevExpress.XtraCharts.ChartAnchorPoint chartAnchorPoint5 = new DevExpress.XtraCharts.ChartAnchorPoint();
            DevExpress.XtraCharts.FreePosition freePosition5 = new DevExpress.XtraCharts.FreePosition();
            DevExpress.XtraCharts.XYDiagram xyDiagram5 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView5 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.TextAnnotation textAnnotation6 = new DevExpress.XtraCharts.TextAnnotation();
            DevExpress.XtraCharts.ChartAnchorPoint chartAnchorPoint6 = new DevExpress.XtraCharts.ChartAnchorPoint();
            DevExpress.XtraCharts.FreePosition freePosition6 = new DevExpress.XtraCharts.FreePosition();
            DevExpress.XtraCharts.XYDiagram xyDiagram6 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView6 = new DevExpress.XtraCharts.LineSeriesView();
            this.trend_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl3 = new DevExpress.XtraCharts.ChartControl();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trend_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView6)).BeginInit();
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
            columnExpression5.ColumnName = "DATETIME";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"134\" />";
            table2.Name = "trend_data";
            columnExpression5.Table = table2;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "VOLTAGE";
            columnExpression6.Table = table2;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "CURRENT";
            columnExpression7.Table = table2;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "POWER";
            columnExpression8.Table = table2;
            column8.Expression = columnExpression8;
            selectQuery2.Columns.Add(column5);
            selectQuery2.Columns.Add(column6);
            selectQuery2.Columns.Add(column7);
            selectQuery2.Columns.Add(column8);
            selectQuery2.Name = "trend_data";
            selectQuery2.Tables.Add(table2);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // chartControl1
            // 
            textAnnotation4.AnchorPoint = chartAnchorPoint4;
            textAnnotation4.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None;
            textAnnotation4.Name = "Annotation 1";
            textAnnotation4.ShapePosition = freePosition4;
            textAnnotation4.Text = "Power";
            this.chartControl1.AnnotationRepository.AddRange(new DevExpress.XtraCharts.Annotation[] {
            textAnnotation4});
            this.chartControl1.DataSource = this.trend_dataBindingSource;
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
            this.chartControl1.Diagram = xyDiagram4;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(15, 281);
            this.chartControl1.Name = "chartControl1";
            series4.ArgumentDataMember = "DATETIME";
            series4.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series4.DataSource = this.trend_dataBindingSource;
            series4.Name = "Series 1";
            series4.ValueDataMembersSerializable = "POWER";
            series4.View = lineSeriesView4;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4};
            this.chartControl1.Size = new System.Drawing.Size(797, 130);
            this.chartControl1.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(664, 416);
            this.maskedTextBox1.Mask = "0000년90월90일 90시90분";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(148, 21);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(15, 414);
            this.maskedTextBox2.Mask = "0000년90월90일 90시90분";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(148, 21);
            this.maskedTextBox2.TabIndex = 4;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(844, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "직접설정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.적용);
            // 
            // chartControl2
            // 
            textAnnotation5.AnchorPoint = chartAnchorPoint5;
            textAnnotation5.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None;
            textAnnotation5.Name = "Annotation 1";
            textAnnotation5.ShapePosition = freePosition5;
            textAnnotation5.Text = "Current";
            this.chartControl2.AnnotationRepository.AddRange(new DevExpress.XtraCharts.Annotation[] {
            textAnnotation5});
            this.chartControl2.DataSource = this.trend_dataBindingSource;
            xyDiagram5.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.None;
            xyDiagram5.AxisX.DateTimeScaleOptions.AutoGrid = false;
            xyDiagram5.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Second;
            xyDiagram5.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Second;
            xyDiagram5.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram5.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram5.EnableAxisXScrolling = true;
            xyDiagram5.EnableAxisXZooming = true;
            xyDiagram5.EnableAxisYScrolling = true;
            xyDiagram5.EnableAxisYZooming = true;
            this.chartControl2.Diagram = xyDiagram5;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl2.Location = new System.Drawing.Point(15, 145);
            this.chartControl2.Name = "chartControl2";
            series5.ArgumentDataMember = "DATETIME";
            series5.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series5.DataSource = this.trend_dataBindingSource;
            series5.Name = "Series 1";
            series5.ValueDataMembersSerializable = "CURRENT";
            series5.View = lineSeriesView5;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series5};
            this.chartControl2.Size = new System.Drawing.Size(797, 130);
            this.chartControl2.TabIndex = 6;
            // 
            // chartControl3
            // 
            textAnnotation6.AnchorPoint = chartAnchorPoint6;
            textAnnotation6.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None;
            textAnnotation6.Name = "Annotation 1";
            textAnnotation6.ShapePosition = freePosition6;
            textAnnotation6.Text = "Voltage";
            this.chartControl3.AnnotationRepository.AddRange(new DevExpress.XtraCharts.Annotation[] {
            textAnnotation6});
            this.chartControl3.DataSource = this.trend_dataBindingSource;
            xyDiagram6.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.None;
            xyDiagram6.AxisX.DateTimeScaleOptions.AutoGrid = false;
            xyDiagram6.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Second;
            xyDiagram6.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Second;
            xyDiagram6.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram6.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram6.EnableAxisXScrolling = true;
            xyDiagram6.EnableAxisXZooming = true;
            xyDiagram6.EnableAxisYScrolling = true;
            xyDiagram6.EnableAxisYZooming = true;
            this.chartControl3.Diagram = xyDiagram6;
            this.chartControl3.Legend.Name = "Default Legend";
            this.chartControl3.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl3.Location = new System.Drawing.Point(15, 9);
            this.chartControl3.Name = "chartControl3";
            series6.ArgumentDataMember = "DATETIME";
            series6.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series6.DataSource = this.trend_dataBindingSource;
            series6.Name = "Series 1";
            series6.ValueDataMembersSerializable = "VOLTAGE";
            series6.View = lineSeriesView6;
            this.chartControl3.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series6};
            this.chartControl3.Size = new System.Drawing.Size(797, 130);
            this.chartControl3.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(844, 165);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "1일단위";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(844, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "1시간단위";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(844, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "10분단위 시간 확정";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(818, 53);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(49, 16);
            this.checkBox5.TabIndex = 19;
            this.checkBox5.Text = "Auto";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(818, 75);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(113, 16);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Text = "AutoSideMargin";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(818, 31);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(132, 16);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "Scale : Continuous";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(818, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 16);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Scale : Automatic";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TrendViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chartControl3);
            this.Controls.Add(this.chartControl2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.chartControl1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TrendViewer";
            this.Size = new System.Drawing.Size(964, 454);
            ((System.ComponentModel.ISupportInitialize)(this.trend_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
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
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraCharts.ChartControl chartControl3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}