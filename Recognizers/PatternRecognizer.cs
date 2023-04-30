using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace StocksEnjoyer
{
    public abstract class PatternRecognizer
    {
        public abstract void Draw(Chart chart);
    }
}
