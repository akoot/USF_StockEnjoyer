using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stocks
{
    internal class Stocks
    {
        public List<CandleStick> CandleStickList = new List<CandleStick>();
        public List<string> CsvFileNames = new List<string>();
        public Stocks() {
            loadCandlesticks();
            new HammerRecognizer().Recognize(CandleStickList);
        }

        /// <summary>
        /// 
        /// </summary>
        void loadCandlesticks()
        {
            string folderPath = "Stock Data"; // replace with your folder path
            var csvFiles = Directory.GetFiles(folderPath, "*.csv");
            foreach (string csvFile in csvFiles)
            {
                CsvFileNames.Add(Path.GetFileName(csvFile));
                string[] lines = File.ReadAllLines(csvFile);
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] csv = lines[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    CandleStickList.Add(new CandleStick(DateTime.Parse(csv[0].Trim('"')),
                        double.Parse(csv[1]),
                        double.Parse(csv[2]),
                        double.Parse(csv[3]),
                        double.Parse(csv[4]),
                        double.Parse(csv.Length == 7 ? csv[5] : csv[4]))); // not necessary but maybe...
                }
            }
            Console.WriteLine($"Loaded {csvFiles.Length} .csv files in {folderPath}.");
        }
    }
}
