using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StocksEnjoyer.Forms
{
    /// <summary>
    ///     Form that displays the selected CSV file.
    ///     Gives the user access to multiple pattern recognizers that can be toggled.
    ///     Each pattern recognizer will color the candlesticks a certain color if they meet the criteria.
    /// </summary>
    public partial class ChartForm : Form
    {
        // The list of patterns that the chart should be rendering
        private readonly List<string> _selectedPatterns;

        // The main instance (passed through the constructor)
        private readonly StocksEnjoyerMain _stocksEnjoyer;

        // The current CSV file
        private string _selectedCsvFile;

        /// <summary>
        ///     The constructor to the chart form.
        ///     It takes in the main class as its parameter
        /// </summary>
        /// <param name="stocksEnjoyer"></param>
        public ChartForm(StocksEnjoyerMain stocksEnjoyer)
        {
            // Set the main class instance
            _stocksEnjoyer = stocksEnjoyer;

            // Initialize the component (default)
            InitializeComponent();

            // Setup the pattern recognizers
            SetupPatternRecognizers();

            // Create a new list for the selected patterns
            _selectedPatterns = new List<string>();
        }

        /// <summary>
        ///     Populates the flow pane that will contain checkboxes used to toggle the different
        ///     types of patterns. Each of the checkboxes has a specific style I wanted to fit with the
        ///     rest of the program, rather than the defaults. The text for each checkbox is the name of the
        ///     pattern.
        /// </summary>
        private void SetupPatternRecognizers()
        {
            Console.WriteLine($"Loaded {_stocksEnjoyer.PatternRecognizers.Count} pattern recognizers.");
            foreach (var recognizer in _stocksEnjoyer.PatternRecognizers.Keys)
            {
                // Create a new CheckBox object
                var checkbox = new CheckBox();

                // Set the text for the CheckBox
                checkbox.Text = recognizer;

                // Set the font to whatever is default in Designer
                checkbox.Font = new Font("Microsoft Sans", 11);

                // Add the checkbox to the flow pane panel in the design
                panel_patterns.Controls.Add(checkbox);

                // Add an event listener to the checkbox when the user clicks on it
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
            // Get the checkbox object from the sender, which should be of CheckBox type
            var checkbox = (CheckBox)sender;

            // If the checkbox is checked, add it to the list of selected patterns
            if (checkbox.Checked) _selectedPatterns.Add(checkbox.Text);

            // Otherwise, remove it from the list
            else _selectedPatterns.Remove(checkbox.Text);

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

        /// <summary>
        ///     This will populate the chart with candlesticks based on the time period selected.
        ///     This will also color the candlesticks based on which patterns are selected.
        /// </summary>
        private void UpdateChartData()
        {
            // Set the data points in the chart
            chart_stock.DataSource = GetCandleSticks(dateTimePicker_start.Value, dateTimePicker_end.Value);

            // Update the chart (refreshes the display)
            chart_stock.DataBind();

            // Clears the legend. The legend will be populated again by the PatternRecognizer if it is checked
            chart_stock.Legends[0].CustomItems.Clear();

            // For each of the selected pattern recognizers, draw or color the candlesticks that match the pattern
            foreach (var selectedPattern in _selectedPatterns)
                _stocksEnjoyer.PatternRecognizers[selectedPattern].Draw(chart_stock);
        }

        /// <summary>
        ///     Returns a list of candlesticks that contain dates that are ONLY in the specified time period.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        private List<CandleStick> GetCandleSticks(DateTime from, DateTime to)
        {
            // A nice and fine LINQ expression provided to you by JetBrains Rider!
            return StocksEnjoyerMain.LoadCsv(_selectedCsvFile)
                .Where(candleStick => candleStick.Date >= from && candleStick.Date <= to).ToList();
        }

        /// <summary>
        ///     Loads the chart based on what CSV file is selected.
        ///     This just sets the title and series name as well as updates the chart.
        /// </summary>
        /// <param name="selectedCsvFile"></param>
        internal void LoadChart(string selectedCsvFile)
        {
            // Set the title to the CSV file name
            chart_stock.Titles[0].Text = selectedCsvFile;

            // Set the series name to the CSV file name
            chart_stock.Series[0].Name = selectedCsvFile;

            // Set the selected CSV file name
            _selectedCsvFile = selectedCsvFile;

            // Refresh the chart
            UpdateChartData();
        }
    }
}