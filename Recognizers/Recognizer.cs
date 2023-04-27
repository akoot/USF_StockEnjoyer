using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StocksEnjoyer
{
    internal abstract class Recognizer
    {
        public abstract int[] Recognize(List<CandleStick> candleSticks);
    }
}
