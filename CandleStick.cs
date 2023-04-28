using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksEnjoyer
{
    /// <summary>
    /// Candle stick class. This class contains the Date, High, Low, Open, Close and Volume values of a typical candlestick.
    /// These values are meant to be read from a CSV file provided by Yahoo Finance.
    /// Although Yahoo Finance has a slightly different format, you can still use their CSV files if you read them correctly.
    /// 
    /// As shown below, the CandleStick class has six properties, each corresponding to one of the values needed to represent a stock candlestick: date, open price, high price, low price, close price, and volume. These properties are all public and have both getter and setter methods.
    /// The constructor for the CandleStick class takes in six parameters: date, open, high, low, close, and volume.These values are used to initialize the corresponding properties of the class.
    /// </summary>
    public class CandleStick
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
        /// <param name="date">The date of the candlestick. This will determine where on the chart it will be on the X axis.</param>
        /// <param name="open">The open value of the stock at the specified date.</param>
        /// <param name="high">The high value of the stock at the specified date.</param>
        /// <param name="low">The low value of the stock at the specified date.</param>
        /// <param name="close">The close value of the stock at the specified date.</param>
        /// <param name="volume">The volume of the stock at the specified date.</param>
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
        /// This will return a string representation of a CandleStick object, showing all of its variables.
        /// </summary>
        /// <returns>A string representation of a CandleStick object.</returns>
        override public string ToString()
        {
            return $"Date: {Date}, Open/High/Low/Close/Volume: {Open}/{High}/{Low}/{Close}/{Volume}";
        }
    }
}
