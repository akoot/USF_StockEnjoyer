using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace StocksEnjoyer
{
    internal class DojiRecognizer : PatternRecognizer
    {
        /// <summary>
        ///     Note that this function assumes that a doji is defined as a candlestick with a body that is less than 1% of the
        ///     candle's high. You can adjust this threshold by changing the value 0.01 in the isDoji calculation. Also, this
        ///     function assumes that the input list of candles is sorted by date in ascending order.
        /// </summary>
        /// <param name="chart"></param>
        public override void Draw(Chart chart)
        {
            chart.Legends[0].CustomItems.Add(Color.Red, "Doji");
            var candles = chart.DataSource as List<CandleStick>;
            for (var i = 0; i < candles.Count - 1; i++)
            {
                var current = candles[i];
                var next = candles[i + 1];

                // check if the current candle is a doji
                var isDoji = Math.Abs(current.Open - current.Close) < 0.01 * current.High;

                // check if the next candle is not a doji and its open is within the range of the current doji
                var isFollowingCandle = !(Math.Abs(next.Open - next.Close) < 0.01 * next.High &&
                                          next.Open >= current.Low && next.Open <= current.High);

                // if both conditions are true, add the index of the next candle to the result list
                if (isDoji && isFollowingCandle) chart.Series[0].Points[i + 1].Color = Color.Red;
            }
        }
    }
}