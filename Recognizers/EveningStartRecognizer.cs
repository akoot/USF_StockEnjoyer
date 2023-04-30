using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace StocksEnjoyer.Recognizers
{
    internal class EveningStartRecognizer : PatternRecognizer
    {
        public override void Draw(Chart chart)
        {
            chart.Legends[0].CustomItems.Add(Color.Orchid, "Evening Star");
            var candles = chart.DataSource as List<CandleStick>;
            for (var i = 2; i < candles.Count; i++)
            {
                var current = candles[i];
                var previous = candles[i - 1];
                var first = candles[i - 2];

                // check if the current candle is an evening star
                var isEveningStar = current.Close < previous.Close && current.Close < current.Open &&
                                    current.Open > previous.Close && current.High < previous.High &&
                                    current.High < first.High &&
                                    previous.Close < previous.Open && previous.Close < first.Close &&
                                    previous.Open > first.Close;

                // if the current candle is an evening star, add its index to the result list
                if (isEveningStar) chart.Series[0].Points[i + 1].Color = Color.Orchid;
            }
        }
    }
}