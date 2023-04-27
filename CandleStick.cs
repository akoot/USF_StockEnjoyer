using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks
{
    /// <summary>
    /// Candle Stick Class
    /// </summary>
    internal class CandleStick
    {
        public DateTime Date { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }

        /// <summary>
        /// Create a candlestick object with all of the info from the CSV file
        /// </summary>
        /// <param name="date"></param>
        /// <param name="open"></param>
        /// <param name="high"></param>
        /// <param name="low"></param>
        /// <param name="close"></param>
        /// <param name="volume"></param>
        public CandleStick(DateTime date, double open, double high, double low, double close, double volume)
        {
            this.Date = date;
            this.Open = open;
            this.High = high;
            this.Low = low;
            this.Close = close;
            this.Volume = volume;
        }

        /// <summary>
        /// This was used in testing
        /// </summary>
        /// <returns></returns>
        override public string ToString()
        {
            return $"Date: {Date}, Open/High/Low/Close/Volume: {Open}/{High}/{Low}/{Close}/{Volume}";
        }
    }
}
