using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StocksEnjoyer
{
    internal class HammerRecognizer : PatternRecognizer
    {
        public override int[] Recognize(List<CandleStick> candleSticks)
        {
            MessageBox.Show("This hammer is now RECOGNIZED");
            return new int[0];
        }
    }
}
