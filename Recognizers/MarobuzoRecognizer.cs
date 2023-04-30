using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace StocksEnjoyer.Recognizers
{
    internal class MarobuzoRecognizer : PatternRecognizer
    {
        public override void Draw(Chart chart)
        {
            chart.Legends[0].CustomItems.Add(Color.Fuchsia, "Marobuzo");
            var candles = chart.DataSource as List<CandleStick>;
            for (var i = 0; i < candles.Count; i++)
            {
                var current = candles[i];

                // check if the current candle is a marubozu
                var isMarubozu = Math.Abs(current.Open - current.High) < 0.01 * current.High &&
                                 Math.Abs(current.Close - current.Low) < 0.01 * current.High;

                // if the current candle is a marubozu, add its index to the result list
                if (isMarubozu) chart.Series[0].Points[i + 1].Color = Color.Fuchsia;
            }
        }
    }
}