using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace StocksEnjoyer.Recognizers
{
    internal class HaramiRecognizer : PatternRecognizer
    {
        public override void Draw(Chart chart)
        {
            chart.Legends[0].CustomItems.Add(Color.Beige, "Harami");
            var candles = chart.DataSource as List<CandleStick>;
            for (int i = 1; i < candles.Count; i++)
            {
                CandleStick current = candles[i];
                CandleStick previous = candles[i - 1];

                // check if the current candle is a harami
                bool isHarami = current.Close < previous.Open && current.Open > previous.Close && current.High < previous.Open && current.Low > previous.Close;

                // if the current candle is a harami, add its index to the result list
                if (isHarami)
                {
                    chart.Series[0].Points[i + 1].Color = Color.Beige;
                }
            }
        }
    }
}
