using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StocksEnjoyer
{
    public partial class ChartForm : Form
    {
        private StocksEnjoyer stocksEnjoyer;

        public ChartForm(StocksEnjoyer stocksEnjoyer)
        {
            this.stocksEnjoyer = stocksEnjoyer;
            InitializeComponent();
            SetupPatternRecognizers();
        }

        private void SetupPatternRecognizers()
        {
            Console.WriteLine($"Loaded {stocksEnjoyer.Recognizers.Count} pattern recognizers.");
            foreach (string recognizer in stocksEnjoyer.Recognizers.Keys)
            {
                var checkbox = new CheckBox();
                checkbox.Text = recognizer;
                // checkbox.FlatStyle = FlatStyle.System;
                panel_patterns.Controls.Add(checkbox);
            }
        }

        private void PatternCheckedEvent(object sender, EventArgs e)
        {
            var checkbox = (CheckBox) sender;
            var enabled = checkbox.Checked;
            Console.WriteLine($"{checkbox.Text}: {enabled}");
        }

        /// <summary>
        /// Fired when the user changes the dateTimePicker value.
        /// This will update the chart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker_start_ValueChanged(object sender, EventArgs e)
        {
            //TODO: Update chart
        }

        /// <summary>
        /// Fired when the user changes the dateTimePicker value.
        /// This will update the chart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker_end_ValueChanged(object sender, EventArgs e)
        {
            //TODO: Update chart
        }
    }
}
