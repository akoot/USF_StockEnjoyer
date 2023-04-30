using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace StocksEnjoyer.Recognizers
{
    internal class MorningStarRecognizer : PatternRecognizer
    {
        public override void Draw(Chart chart)
        {
            chart.Legends[0].CustomItems.Add(Color.DarkCyan, "Morning Star");
            var candles = chart.DataSource as List<CandleStick>;
            for (int i = 2; i < candles.Count; i++)
            {
                CandleStick current = candles[i];
                CandleStick previous = candles[i - 1];
                CandleStick first = candles[i - 2];

                // check if the current candle is a morning star
                bool isMorningStar = current.Close > previous.Close && current.Close > current.Open &&
                    current.Open < previous.Close && current.Low > previous.Low && current.Low > first.Low &&
                    previous.Close > previous.Open && previous.Close > first.Close && previous.Open < first.Close;

                // if the current candle is a morning star, add its index to the result list
                if (isMorningStar)
                {
                    chart.Series[0].Points[i + 1].Color = Color.DarkCyan;
                }
            }
        }
    }
}
