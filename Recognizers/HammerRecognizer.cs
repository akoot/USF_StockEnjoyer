using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StocksEnjoyer
{
    internal class HammerRecognizer : PatternRecognizer
    {
        public override void Draw(Chart chart)
        {
            chart.Legends[0].CustomItems.Add(Color.LightGreen, "Hammer");
            var candles = chart.DataSource as List<CandleStick>;
            for (int i = 0; i < candles.Count; i++)
            {
                CandleStick current = candles[i];

                // check if the current candle is a hammer
                bool isHammer = current.Open > current.Close && current.Open - current.Close < (current.High - current.Low) / 3 && current.Close == current.Low && (current.Open - current.Low) < (current.High - current.Open);

                // if the current candle is a hammer, add its index to the result list
                if (isHammer)
                {
                    chart.Series[0].Points[i + 1].Color = Color.LightGreen;
                }
            }
        }
    }
}
