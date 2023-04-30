﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace StocksEnjoyer
{
    internal class GravestoneDojiRecognizer : PatternRecognizer
    {
        public override void Draw(Chart chart)
        {
            chart.Legends[0].CustomItems.Add(Color.AliceBlue, "Gravestone");
            var candles = chart.DataSource as List<CandleStick>;
            for (var i = 0; i < candles.Count - 1; i++)
            {
                var current = candles[i];
                var next = candles[i + 1];

                // check if the current candle is a gravestone doji
                var isGravestone = current.Open == current.High && current.Close == current.Low &&
                                   Math.Abs(current.Open - current.Close) < 0.01 * current.High;

                // check if the next candle is not a doji and its open is within the range of the current gravestone doji
                var isFollowingCandle = !(Math.Abs(next.Open - next.Close) < 0.01 * next.High &&
                                          next.Open >= current.Low && next.Open <= current.High);

                // if both conditions are true, add the index of the next candle to the result list
                if (isGravestone && isFollowingCandle) chart.Series[0].Points[i + 1].Color = Color.AliceBlue;
            }
        }
    }
}