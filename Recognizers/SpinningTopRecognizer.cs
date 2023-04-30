using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace StocksEnjoyer.Recognizers
{
    internal class SpinningTopRecognizer : PatternRecognizer
    {
        public override void Draw(Chart chart)
        {
            chart.Legends[0].CustomItems.Add(Color.Crimson, "Spinning Top");
            var candles = chart.DataSource as List<CandleStick>;
            for (var i = 0; i < candles.Count; i++)
            {
                var current = candles[i];

                // check if the current candle is a spinning top
                var isSpinningTop = current.High - current.Low < (current.Close - current.Open) * 2 &&
                                    current.Close != current.Open;

                // if the current candle is a spinning top, add its index to the result list
                if (isSpinningTop) chart.Series[0].Points[i].Color = Color.Crimson;
            }
        }
    }
}