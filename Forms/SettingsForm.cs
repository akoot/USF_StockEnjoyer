using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StocksEnjoyer
{
    /// <summary>
    /// The Settings class is a Windows form which contains all of the controls required to view a graph of a selected CSV file.
    /// Inside this class there are methods specific to the Settings form only, as any cross-form functionality should be contained
    /// inside the main StocksEnjoyer.cs class.
    /// </summary>
    public partial class SettingsForm : Form
    {
        /// <summary>
        /// The "main" class instance.
        /// </summary>
        readonly StocksEnjoyer stocksEnjoyer = new StocksEnjoyer();

        /// <summary>
        /// Windows Forms constructor.
        /// Initializes components (default behavior)
        /// Updates the combo box
        /// Updates the "Load" button
        /// </summary>
        public SettingsForm()
        {
            InitializeComponent();
            UpdateCsvListComboBox(null, null); // Updates the combo box
            comboBox_csvList_Changed(null, null); // Updates the "Load" button
        }

        /// <summary>
        /// Checks whenever the filter checkbox is clicked.
        /// Fires the UpdateCsvListComboBox function, and enables/disables the filter radio buttons depending on whether the filter checkbox is enabled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_filter_CheckedChanged(object sender, EventArgs e)
        {
            panel_filter.Enabled = checkBox_filter.Checked;
            UpdateCsvListComboBox(null, null);
        }

        /// <summary>
        /// Handles the accessibility of the combo box, as well as populating it with the desired items, depending on the filtering (or lack thereof).
        /// This will check whether or not to enable the combo box depending if there are items being filtered.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCsvListComboBox(object sender, EventArgs e)
        {
            comboBox_csvList.Items.Clear(); // Clear the combo box every update
            // comboBox_csvList.SelectedText = string.Empty; // Doesn't do anything oh well

            // Checks if the combo box list should be enabled (clickable)
            // If filtering is enabled but none of the radio buttons are checked, then the combo box should be disabled.
            if (panel_filter.Enabled && !(radioButton_daily.Checked || radioButton_daily.Checked || radioButton_weekly.Checked || radioButton_monthly.Checked))
            {
                comboBox_csvList.Enabled = false;
                return;
            }

            comboBox_csvList.Enabled = true; // Enable the combo box from this point on because we already tested for any scenarios where it should be disabled.

            // If the user does not want to filter csv files, then just fill the combo box with all of the csv file names.
            // If the user wants to filter the csv files AND one of the radio buttons are selected, then only fill the combo box with the specified radio button time period.
            foreach (var csvFile in stocksEnjoyer.CsvFileNames)
            {
                if (!panel_filter.Enabled || (radioButton_daily.Checked && csvFile.Contains("Day")) || (radioButton_weekly.Checked && csvFile.Contains("Week")) || (radioButton_monthly.Checked && csvFile.Contains("Month")))
                {
                    comboBox_csvList.Items.Add(csvFile);
                }
            }
        }

        /// <summary>
        /// When the "Load" button is clicked, show the "chart" form.
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
            // TODO: DataBind
            stocksEnjoyer.form_chart.Show();
        }

        private bool IsSelectedCsvFileValid()
        {
            return stocksEnjoyer.CsvFileNames.Contains(comboBox_csvList.Text);
        }

        /// <summary>
        /// Checks when the combo box has changed in value.
        /// If the combo box is empty, disables the "Load" button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_csvList_Changed(object sender, EventArgs e)
        {
            button_load.Enabled = IsSelectedCsvFileValid();
        }

        /// <summary>
        /// Reloads the list of CSV files in the specified folder (Default: "Stock Data").
        /// This is useful if you want to add more CSV files during runtime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_reload_Click(object sender, EventArgs e)
        {
            stocksEnjoyer.LoadCandlesticks();
            UpdateCsvListComboBox(null, null);
            MessageBox.Show($"Loaded {stocksEnjoyer.CsvFileNames.Count} CSV files from \"{stocksEnjoyer.folderPath}\"");
        }
    }
}
