﻿using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace StocksEnjoyer.Recognizers
{
    internal class SpinningTopRecognizer : PatternRecognizer
    {
        /// <summary>
        ///     Note that this function assumes that a spinning top candle is defined as a candlestick with a small body
        ///     relative to the candle's total range, with a long upper and lower shadow, and the opening and closing prices
        ///     near the middle of the candle's range. You can adjust the threshold for what constitutes a small body by
        ///     changing the value 2 in the (current.High - current.Low) (less than) (current.Close - current.Open) * 2
        ///     calculation.
        ///     Also, this function assumes that the input list of candles is sorted by date in ascending order.
        /// </summary>
        /// <param name="chart"></param>
        public override void Draw(Chart chart)
        {
            chart.Legends[0].CustomItems.Add(Color.Crimson, "Spinning Top");
            if (!(chart.DataSource is List<CandleStick> candles)) return;
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