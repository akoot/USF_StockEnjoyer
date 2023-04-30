using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StocksEnjoyer
{
    internal class DojiRecognizer : PatternRecognizer
    {
        public override void Draw(Chart chart)
        {
            chart.Legends[0].CustomItems.Add(Color.Red, "Doji");
            var candleSticks = chart.DataSource as List<CandleStick>;
            for (int i = 0; i < candleSticks.Count - 1; i++)
            {
                CandleStick current = candleSticks[i];
                CandleStick next = candleSticks[i + 1];

                // check if the current candle is a doji
                bool isDoji = Math.Abs(current.Open - current.Close) < 0.01 * current.High;

                // check if the next candle is not a doji and its open is within the range of the current doji
                bool isFollowingCandle = !(Math.Abs(next.Open - next.Close) < 0.01 * next.High && next.Open >= current.Low && next.Open <= current.High);

                // if both conditions are true, add the index of the next candle to the result list
                if (isDoji && isFollowingCandle)
                {
                    chart.Series[0].Points[i + 1].Color = Color.Red;
                }
            }
        }
    }
}
