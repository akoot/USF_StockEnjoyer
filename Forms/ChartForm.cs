﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StocksEnjoyer
{
    public partial class ChartForm : Form
    {
        private StocksEnjoyerMain stocksEnjoyer;
        private string SelectedCSVFile;
        private List<String> selectedPatterns;

        public ChartForm(StocksEnjoyerMain stocksEnjoyer)
        {
            this.stocksEnjoyer = stocksEnjoyer;
            InitializeComponent();
            SetupPatternRecognizers();
            selectedPatterns = new List<String>();
        }

        private void SetupPatternRecognizers()
        {
            Console.WriteLine($"Loaded {stocksEnjoyer.PatternRecognizers.Count} pattern recognizers.");
            foreach (string recognizer in stocksEnjoyer.PatternRecognizers.Keys)
            {
                var checkbox = new CheckBox();
                checkbox.Text = recognizer;
                checkbox.Font = new Font("Microsoft Sans", 11);
                // checkbox.FlatStyle = FlatStyle.System;
                panel_patterns.Controls.Add(checkbox);
                checkbox.CheckedChanged += new EventHandler(PatternCheckedEvent);
            }
        }

        /// <summary>
        /// Fired when any of the pattern checkboxes are checked or unchecked.
        /// This will update the chart to display these patterns.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatternCheckedEvent(object sender, EventArgs e)
        {
            var checkbox = (CheckBox) sender;
            var enabled = checkbox.Checked;

            if (enabled) selectedPatterns.Add(checkbox.Text);
            else selectedPatterns.Remove(checkbox.Text);

            if (enabled)
            {
                stocksEnjoyer.PatternRecognizers[checkbox.Text].Draw(chart_stock);
                //Console.WriteLine($"{checkbox.Text} pattern indices: {string.Join(", ",patterns)}");
            }
            //Console.WriteLine($"{checkbox.Text}: {enabled}");
        }

        /// <summary>
        /// Fired when the user changes the dateTimePicker value.
        /// This will update the chart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateChartData();
        }

        private void UpdateChartData()
        {
            chart_stock.DataSource = GetCandleSticks(dateTimePicker_start.Value, dateTimePicker_end.Value);
            chart_stock.DataBind();
        }

        private List<CandleStick> GetCandleSticks(DateTime from, DateTime to)
        {
            var candleSticks = new List<CandleStick>();
            foreach (CandleStick candleStick in stocksEnjoyer.LoadCSV(SelectedCSVFile))
            {
                if (candleStick.Date >= from && candleStick.Date <= to) candleSticks.Add(candleStick);
            }
            return candleSticks;
        }

        internal void LoadChart(string selectedCSVFile)
        {
            chart_stock.Titles[0].Text = selectedCSVFile;
            chart_stock.Series[0].Name = selectedCSVFile;
            SelectedCSVFile = selectedCSVFile;
            UpdateChartData();
        }
    }
}
