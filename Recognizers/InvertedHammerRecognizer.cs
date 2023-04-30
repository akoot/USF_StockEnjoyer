using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace StocksEnjoyer.Recognizers
{
    internal class InvertedHammerRecognizer : PatternRecognizer
    {
        public override void Draw(Chart chart)
        {
            chart.Legends[0].CustomItems.Add(Color.Sienna, "Inverted Hammer");
            var candles = chart.DataSource as List<CandleStick>;
            for (int i = 0; i < candles.Count; i++)
            {
                CandleStick current = candles[i];

                // check if the current candle is an inverted hammer
                bool isInvertedHammer = current.Close > current.Open && current.Close - current.Open < (current.High - current.Low) / 3 && current.Open == current.Low && (current.Close - current.Low) < (current.High - current.Close);

                // if the current candle is an inverted hammer, add its index to the result list
                if (isInvertedHammer)
                {
                    chart.Series[0].Points[i + 1].Color = Color.Sienna;
                }
            }
        }
    }
}
