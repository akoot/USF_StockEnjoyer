using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace StocksEnjoyer.Recognizers
{
    internal class MarobuzoRecognizer : PatternRecognizer
    {
        /// <summary>
        ///     Note that this function assumes that a Marubozu candle is defined as a candlestick with a very small or
        ///     non-existent upper and lower shadow, and with an open very close to the high and a close very close to the low. You
        ///     can adjust the threshold for what constitutes a small shadow by changing the value 0.01 in the isMarubozu
        ///     calculation. Also, this function assumes that the input list of candles is sorted by date in ascending order.
        /// </summary>
        /// <param name="chart"></param>
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