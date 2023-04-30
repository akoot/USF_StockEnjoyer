namespace StocksEnjoyer
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            this.chart_stock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.candleStickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer_main = new System.Windows.Forms.SplitContainer();
            this.splitContainer_settings = new System.Windows.Forms.SplitContainer();
            this.panel_timePeriod = new System.Windows.Forms.Panel();
            this.label_timePeriod = new System.Windows.Forms.Label();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.label_endDate = new System.Windows.Forms.Label();
            this.label_startDate = new System.Windows.Forms.Label();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.label_patterns = new System.Windows.Forms.Label();
            this.panel_patterns = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chart_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candleStickBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).BeginInit();
            this.splitContainer_main.Panel1.SuspendLayout();
            this.splitContainer_main.Panel2.SuspendLayout();
            this.splitContainer_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_settings)).BeginInit();
            this.splitContainer_settings.Panel1.SuspendLayout();
            this.splitContainer_settings.Panel2.SuspendLayout();
            this.splitContainer_settings.SuspendLayout();
            this.panel_timePeriod.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_stock
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_stock.ChartAreas.Add(chartArea1);
            this.chart_stock.DataSource = this.candleStickBindingSource;
            this.chart_stock.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_stock.Legends.Add(legend1);
            this.chart_stock.Location = new System.Drawing.Point(0, 0);
            this.chart_stock.Name = "chart_stock";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "Date";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueMembers = "Low, High, Close, Open";
            series1.YValuesPerPoint = 4;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart_stock.Series.Add(series1);
            this.chart_stock.Size = new System.Drawing.Size(858, 548);
            this.chart_stock.TabIndex = 0;
            this.chart_stock.Text = "Stonks";
            title1.Name = "Title1";
            this.chart_stock.Titles.Add(title1);
            // 
            // candleStickBindingSource
            // 
            this.candleStickBindingSource.DataSource = typeof(StocksEnjoyer.CandleStick);
            // 
            // splitContainer_main
            // 
            this.splitContainer_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_main.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_main.Name = "splitContainer_main";
            // 
            // splitContainer_main.Panel1
            // 
            this.splitContainer_main.Panel1.Controls.Add(this.chart_stock);
            // 
            // splitContainer_main.Panel2
            // 
            this.splitContainer_main.Panel2.Controls.Add(this.splitContainer_settings);
            this.splitContainer_main.Size = new System.Drawing.Size(1065, 548);
            this.splitContainer_main.SplitterDistance = 858;
            this.splitContainer_main.TabIndex = 1;
            // 
            // splitContainer_settings
            // 
            this.splitContainer_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_settings.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_settings.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_settings.Name = "splitContainer_settings";
            this.splitContainer_settings.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_settings.Panel1
            // 
            this.splitContainer_settings.Panel1.Controls.Add(this.panel_timePeriod);
            // 
            // splitContainer_settings.Panel2
            // 
            this.splitContainer_settings.Panel2.Controls.Add(this.label_patterns);
            this.splitContainer_settings.Panel2.Controls.Add(this.panel_patterns);
            this.splitContainer_settings.Size = new System.Drawing.Size(203, 548);
            this.splitContainer_settings.SplitterDistance = 174;
            this.splitContainer_settings.TabIndex = 11;
            // 
            // panel_timePeriod
            // 
            this.panel_timePeriod.Controls.Add(this.label_timePeriod);
            this.panel_timePeriod.Controls.Add(this.dateTimePicker_start);
            this.panel_timePeriod.Controls.Add(this.label_endDate);
            this.panel_timePeriod.Controls.Add(this.label_startDate);
            this.panel_timePeriod.Controls.Add(this.dateTimePicker_end);
            this.panel_timePeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_timePeriod.Location = new System.Drawing.Point(0, 0);
            this.panel_timePeriod.Name = "panel_timePeriod";
            this.panel_timePeriod.Padding = new System.Windows.Forms.Padding(10);
            this.panel_timePeriod.Size = new System.Drawing.Size(203, 174);
            this.panel_timePeriod.TabIndex = 9;
            // 
            // label_timePeriod
            // 
            this.label_timePeriod.AutoSize = true;
            this.label_timePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timePeriod.Location = new System.Drawing.Point(13, 10);
            this.label_timePeriod.Name = "label_timePeriod";
            this.label_timePeriod.Size = new System.Drawing.Size(118, 22);
            this.label_timePeriod.TabIndex = 1;
            this.label_timePeriod.Text = "Time Period";
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_start.Location = new System.Drawing.Point(17, 74);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.ShowUpDown = true;
            this.dateTimePicker_start.Size = new System.Drawing.Size(175, 26);
            this.dateTimePicker_start.TabIndex = 4;
            this.dateTimePicker_start.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label_endDate
            // 
            this.label_endDate.AutoSize = true;
            this.label_endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_endDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_endDate.Location = new System.Drawing.Point(13, 104);
            this.label_endDate.Name = "label_endDate";
            this.label_endDate.Size = new System.Drawing.Size(79, 20);
            this.label_endDate.TabIndex = 7;
            this.label_endDate.Text = "End Date";
            // 
            // label_startDate
            // 
            this.label_startDate.AutoSize = true;
            this.label_startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_startDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_startDate.Location = new System.Drawing.Point(13, 49);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(86, 20);
            this.label_startDate.TabIndex = 5;
            this.label_startDate.Text = "Start Date";
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_end.Location = new System.Drawing.Point(17, 129);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.ShowUpDown = true;
            this.dateTimePicker_end.Size = new System.Drawing.Size(176, 26);
            this.dateTimePicker_end.TabIndex = 6;
            this.dateTimePicker_end.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label_patterns
            // 
            this.label_patterns.AutoSize = true;
            this.label_patterns.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_patterns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_patterns.Location = new System.Drawing.Point(0, 0);
            this.label_patterns.Name = "label_patterns";
            this.label_patterns.Padding = new System.Windows.Forms.Padding(10);
            this.label_patterns.Size = new System.Drawing.Size(105, 42);
            this.label_patterns.TabIndex = 8;
            this.label_patterns.Text = "Patterns";
            // 
            // panel_patterns
            // 
            this.panel_patterns.AutoScroll = true;
            this.panel_patterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_patterns.Location = new System.Drawing.Point(0, 0);
            this.panel_patterns.Name = "panel_patterns";
            this.panel_patterns.Padding = new System.Windows.Forms.Padding(10, 40, 10, 10);
            this.panel_patterns.Size = new System.Drawing.Size(203, 370);
            this.panel_patterns.TabIndex = 0;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 548);
            this.Controls.Add(this.splitContainer_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChartForm";
            this.Text = "StocksEnjoyer 3.0 - Chart";
            ((System.ComponentModel.ISupportInitialize)(this.chart_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candleStickBindingSource)).EndInit();
            this.splitContainer_main.Panel1.ResumeLayout(false);
            this.splitContainer_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_main)).EndInit();
            this.splitContainer_main.ResumeLayout(false);
            this.splitContainer_settings.Panel1.ResumeLayout(false);
            this.splitContainer_settings.Panel2.ResumeLayout(false);
            this.splitContainer_settings.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_settings)).EndInit();
            this.splitContainer_settings.ResumeLayout(false);
            this.panel_timePeriod.ResumeLayout(false);
            this.panel_timePeriod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_stock;
        private System.Windows.Forms.SplitContainer splitContainer_main;
        private System.Windows.Forms.Label label_timePeriod;
        private System.Windows.Forms.Label label_endDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.Label label_startDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.SplitContainer splitContainer_settings;
        private System.Windows.Forms.FlowLayoutPanel panel_patterns;
        private System.Windows.Forms.Label label_patterns;
        private System.Windows.Forms.Panel panel_timePeriod;
        private System.Windows.Forms.BindingSource candleStickBindingSource;
    }
}