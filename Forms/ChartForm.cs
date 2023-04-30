using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StocksEnjoyer
{
    /// <summary>
    /// Form that displays the selected CSV file.
    /// Gives the user access to multiple pattern recognizers that can be toggled.
    /// Each pattern recognizer will color the candlesticks a certain color if they meet the criteria.
    /// </summary>
    public partial class ChartForm : Form
    {
        private string SelectedCSVFile;
        private readonly List<string> selectedPatterns;
        private readonly StocksEnjoyerMain stocksEnjoyer;

        public ChartForm(StocksEnjoyerMain stocksEnjoyer)
        {
            this.stocksEnjoyer = stocksEnjoyer;
            InitializeComponent();
            SetupPatternRecognizers();
            selectedPatterns = new List<string>();
        }

        private void SetupPatternRecognizers()
        {
            Console.WriteLine($"Loaded {stocksEnjoyer.PatternRecognizers.Count} pattern recognizers.");
            foreach (var recognizer in stocksEnjoyer.PatternRecognizers.Keys)
            {
                var checkbox = new CheckBox();
                checkbox.Text = recognizer;
                checkbox.Font = new Font("Microsoft Sans", 11);
                // checkbox.FlatStyle = FlatStyle.System;
                panel_patterns.Controls.Add(checkbox);
                checkbox.CheckedChanged += PatternCheckedEvent;
            }
        }

        /// <summary>
        ///     Fired when any of the pattern checkboxes are checked or unchecked.
        ///     This will update the chart to display these patterns.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatternCheckedEvent(object sender, EventArgs e)
        {
            var checkbox = (CheckBox)sender;
            var enabled = checkbox.Checked;

            if (enabled) selectedPatterns.Add(checkbox.Text);
            else selectedPatterns.Remove(checkbox.Text);

            UpdateChartData();
        }

        /// <summary>
        ///     Fired when the user changes the dateTimePicker value.
        ///     This will update the chart.
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
            chart_stock.Legends[0].CustomItems.Clear();
            foreach (var selectedPattern in selectedPatterns)
                stocksEnjoyer.PatternRecognizers[selectedPattern].Draw(chart_stock);
        }

        private List<CandleStick> GetCandleSticks(DateTime from, DateTime to)
        {
            var candleSticks = new List<CandleStick>();
            foreach (var candleStick in StocksEnjoyerMain.LoadCsv(SelectedCSVFile))
                if (candleStick.Date >= from && candleStick.Date <= to)
                    candleSticks.Add(candleStick);
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