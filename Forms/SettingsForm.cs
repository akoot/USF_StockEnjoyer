using System;
using System.Windows.Forms;

namespace StocksEnjoyer.Forms
{
    /// <summary>
    ///     The Settings class is a Windows form which contains all of the controls required to view a graph of a selected CSV
    ///     file.
    ///     Inside this class there are methods specific to the Settings form only, as any cross-form functionality should be
    ///     contained
    ///     inside the main StocksEnjoyer.cs class.
    /// </summary>
    public partial class SettingsForm : Form
    {
        /// <summary>
        ///     The "main" class instance.
        /// </summary>
        private readonly StocksEnjoyerMain _stocksEnjoyer = new StocksEnjoyerMain();

        /// <summary>
        ///     Windows Forms constructor.
        ///     Initializes components (default behavior)
        ///     Updates the combo box
        ///     Updates the "Load" button
        /// </summary>
        public SettingsForm()
        {
            // Initialize components (default action)
            InitializeComponent();

            // Update the CSV list combo box based on the files inside of the folder
            UpdateCsvListComboBox(null, null); // Updates the combo box
            comboBox_csvList_Changed(null, null); // Updates the "Load" button
        }

        /// <summary>
        ///     Checks whenever the filter checkbox is clicked.
        ///     Fires the UpdateCsvListComboBox function, and enables/disables the filter radio buttons depending on whether the
        ///     filter checkbox is enabled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_filter_CheckedChanged(object sender, EventArgs e)
        {
            // Enable the filter panel only if filtering is checked
            panel_filter.Enabled = checkBox_filter.Checked;

            // Update the combo box. It could possibly be new items so it's best to reload it
            UpdateCsvListComboBox(null, null);
        }

        /// <summary>
        ///     Handles the accessibility of the combo box, as well as populating it with the desired items, depending on the
        ///     filtering (or lack thereof).
        ///     This will check whether or not to enable the combo box depending if there are items being filtered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCsvListComboBox(object sender, EventArgs e)
        {
            comboBox_csvList.Items.Clear(); // Clear the combo box every update
            // comboBox_csvList.SelectedText = string.Empty; // Doesn't do anything oh well

            // Checks if the combo box list should be enabled (clickable)
            // If filtering is enabled but none of the radio buttons are checked, then the combo box should be disabled.
            if (panel_filter.Enabled && !(radioButton_daily.Checked || radioButton_daily.Checked ||
                                          radioButton_weekly.Checked || radioButton_monthly.Checked))
            {
                comboBox_csvList.Enabled = false;
                return;
            }

            comboBox_csvList.Enabled =
                true; // Enable the combo box from this point on because we already tested for any scenarios where it should be disabled.

            // If the user does not want to filter csv files, then just fill the combo box with all of the csv file names.
            // If the user wants to filter the csv files AND one of the radio buttons are selected, then only fill the combo box with the specified radio button time period.
            foreach (var csvFile in _stocksEnjoyer.CsvFileNames)
                if (!panel_filter.Enabled || (radioButton_daily.Checked && csvFile.Contains("Day")) ||
                    (radioButton_weekly.Checked && csvFile.Contains("Week")) ||
                    (radioButton_monthly.Checked && csvFile.Contains("Month")))
                    comboBox_csvList.Items.Add(csvFile);
        }

        /// <summary>
        ///     When the "Load" button is clicked, show the "chart" form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_load_Click(object sender, EventArgs e)
        {
            if (!IsSelectedCsvFileValid())
            {
                MessageBox.Show("Invalid CSV file specified!");
                return;
            }

            //stocksEnjoyer.form_chart.LoadChart(comboBox_csvList.Text);
            if (_stocksEnjoyer.FormChart.IsDisposed) _stocksEnjoyer.FormChart = new ChartForm(_stocksEnjoyer);
            _stocksEnjoyer.FormChart.Show();
            _stocksEnjoyer.FormChart.Focus();
        }

        /// <summary>
        ///     Checks if the CSV file name in the combo box actually exists and is in the CSV file names list in memory
        /// </summary>
        /// <returns></returns>
        private bool IsSelectedCsvFileValid()
        {
            return _stocksEnjoyer.CsvFileNames.Contains(comboBox_csvList.Text);
        }

        /// <summary>
        ///     Checks when the combo box has changed in value.
        ///     If the combo box is empty, disables the "Load" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_csvList_Changed(object sender, EventArgs e)
        {
            // Skip doing anything if the selected CSV file does not exist
            if (!IsSelectedCsvFileValid()) return;

            // Show the "Show Chart" button
            button_load.Enabled = true;

            // Load the chart
            _stocksEnjoyer.FormChart.LoadChart(comboBox_csvList.Text);
        }

        /// <summary>
        ///     Reloads the list of CSV files in the specified folder (Default: "Stock Data").
        ///     This is useful if you want to add more CSV files during runtime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_reload_Click(object sender, EventArgs e)
        {
            // Update the CSV files to memory (the list)
            _stocksEnjoyer.SetupCsvFiles();

            // Reload the combo box to show the new files
            UpdateCsvListComboBox(null, null);

            // Tell the user that the files were loaded successfully!
            MessageBox.Show(
                $"Loaded {_stocksEnjoyer.CsvFileNames.Count} CSV files from \"{StocksEnjoyerMain.FolderPath}\"");
        }
    }
}