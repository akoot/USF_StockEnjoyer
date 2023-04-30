using System.Windows.Forms.DataVisualization.Charting;

namespace StocksEnjoyer.Recognizers
{
    /// <summary>
    ///     A Pattern Recognizer class is meant to be used as an abstract class which implements the function
    ///     "Draw". I chose "Draw" instead of recognize because it would be easier and more straightforward
    ///     to draw the actual patterns directly rather than first getting the indices.
    /// </summary>
    public abstract class PatternRecognizer
    {
        /// <summary>
        ///     This function takes in the Chart object and makes changes to the relevant data points.
        ///     For now, they will color each point depending on what pattern it is.
        ///     It will also create a new legend item showing what color it is.
        /// </summary>
        /// <param name="chart"></param>
        public abstract void Draw(Chart chart);
    }
}