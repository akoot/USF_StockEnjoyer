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

namespace Stocks
{
    /// <summary>
    /// Main class that holds all of the information and functions between forms and such.
    /// </summary>
    public partial class Settings : Form
    {
        readonly Stocks stocks = new Stocks();
        private readonly Display display = new Display();

        public Settings()
        {
            InitializeComponent();
            UpdateCsvListComboBox(null, null);
            comboBox_csvList_Changted(null, null);
        }

        private void checkBox_filter_CheckedChanged(object sender, EventArgs e)
        {
            panel_filter.Enabled = checkBox_filter.Checked;
            UpdateCsvListComboBox(null, null);
        }

        private void UpdateCsvListComboBox(object sender, EventArgs e)
        {
            comboBox_csvList.Items.Clear();
            comboBox_csvList.SelectedText = string.Empty;
            // comboBox_csvList_Changted(null, null);
            if (panel_filter.Enabled && !(radioButton_daily.Checked || radioButton_daily.Checked || radioButton_weekly.Checked || radioButton_monthly.Checked))
            {
                comboBox_csvList.Enabled = false;
                return;
            }
            
            comboBox_csvList.Enabled = true;
            foreach (var csvFile in stocks.CsvFileNames)
            {
                if (!panel_filter.Enabled || (radioButton_daily.Checked && csvFile.Contains("Day")) || (radioButton_weekly.Checked && csvFile.Contains("Week")) || (radioButton_monthly.Checked && csvFile.Contains("Month")))
                {
                    comboBox_csvList.Items.Add(csvFile);
                }
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            display.Show();
        }

        private void comboBox_csvList_Changted(object sender, EventArgs e)
        {
            button_load.Enabled = comboBox_csvList.SelectedItem != null;
        }
    }
}
