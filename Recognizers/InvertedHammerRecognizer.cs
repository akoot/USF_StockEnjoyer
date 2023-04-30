using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace StocksEnjoyer.Recognizers
{
    internal class InvertedHammerRecognizer : PatternRecognizer
    {
        /// <summary>
        ///     Note that this function assumes that an inverted hammer candle is defined as a candlestick with a small body
        ///     located at the lower end of the candle, with an upper shadow at least twice the size of the body, and little to no
        ///     lower shadow. You can adjust the threshold for what constitutes a small body by changing the value 1/3 in the
        ///     isInvertedHammer calculation. Also, this function assumes that the input list of candles is sorted by date in
        ///     ascending order.
        /// </summary>
        /// <param name="chart"></param>
        public override void Draw(Chart chart)
        {
            chart.Legends[0].CustomItems.Add(Color.Sienna, "Inverted Hammer");
            var candles = chart.DataSource as List<CandleStick>;
            for (var i = 0; i < candles.Count; i++)
            {
                var current = candles[i];

                // check if the current candle is an inverted hammer
                var isInvertedHammer = current.Close > current.Open &&
                                       current.Close - current.Open < (current.High - current.Low) / 3 &&
                                       current.Open == current.Low &&
                                       current.Close - current.Low < current.High - current.Close;

                // if the current candle is an inverted hammer, add its index to the result list
                if (isInvertedHammer) chart.Series[0].Points[i + 1].Color = Color.Sienna;
            }
        }
    }
}