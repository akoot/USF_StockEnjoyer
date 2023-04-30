using System.Windows.Forms.DataVisualization.Charting;

namespace StocksEnjoyer
{
    public abstract class PatternRecognizer
    {
        public abstract void Draw(Chart chart);
    }
}