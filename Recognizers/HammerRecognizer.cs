using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace StocksEnjoyer.Recognizers
{
    internal class HammerRecognizer : PatternRecognizer
    {
        /// <summary>
        ///     Note that this function assumes that a hammer candle is defined as a candlestick with a small body located at the
        ///     upper end of the candle, with a lower shadow at least twice the size of the body, and little to no upper shadow.
        ///     You can adjust the threshold for what constitutes a small body by changing the value 1/3 in the isHammer
        ///     calculation. Also, this function assumes that the input list of candles is sorted by date in ascending order.
        /// </summary>
        /// <param name="chart"></param>
        public override void Draw(Chart chart)
        {
            chart.Legends[0].CustomItems.Add(Color.LightGreen, "Hammer");
            if (!(chart.DataSource is List<CandleStick> candles)) return;
            for (var i = 0; i < candles.Count; i++)
            {
                var current = candles[i];

                // check if the current candle is a hammer
                var isHammer = current.Open > current.Close &&
                               current.Open - current.Close < (current.High - current.Low) / 3 &&
                               current.Close == current.Low &&
                               current.Open - current.Low < current.High - current.Open;

                // if the current candle is a hammer, add its index to the result list
                if (isHammer) chart.Series[0].Points[i + 1].Color = Color.LightGreen;
            }
        }
    }
}