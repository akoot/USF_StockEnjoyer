using StocksEnjoyer.Recognizers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// if i wasn't limited to .net windows forms this would actually look good
// i refuse to programatically set the "paint" of a button and whatnot or whatever
// but at least this will run on a computer from 2002!!!!
namespace StocksEnjoyer
{
    public class StocksEnjoyerMain
    {

        public string folderPath = "Stock Data"; // replace with your folder path

        public List<CandleStick> CandleStickList;
        public List<string> CsvFileNames = new List<string>();

        public Dictionary<string, PatternRecognizer> PatternRecognizers = new Dictionary<string, PatternRecognizer>();

        public string SelectedCSVFile = "";

        /// <summary>
        /// The "chart" form instance
        /// </summary>
        public ChartForm form_chart;
        public StocksEnjoyerMain() {
            LoadCandlesticks();
            SetupRecognizers();
            form_chart = new ChartForm(this);
        }

        public void SetupRecognizers()
        {
            PatternRecognizers["Doji"] = new DojiRecognizer();
            PatternRecognizers["Dragonfly"] = new DragonflyDojiRecognizer();
            PatternRecognizers["Evening Star"] = new EveningStartRecognizer();
            PatternRecognizers["Gravestone"] = new GravestoneDojiRecognizer();
            PatternRecognizers["Hammer"] = new HammerRecognizer();
            PatternRecognizers["Inverted Hammer"] = new InvertedHammerRecognizer();
            PatternRecognizers["Marobuzo"] = new MarobuzoRecognizer();
            PatternRecognizers["Spinning Top"] = new SpinningTopRecognizer();
            PatternRecognizers["Harami"] = new HaramiRecognizer();
        }

        /// <summary>
        /// Loads all of the candlesticks into memory.
        /// This looks inside of the "Stock Data" folder located where the program's executable is.
        /// This function can be called any time during runtime to reload the list of CSV files.
        /// </summary>
        public void LoadCandlesticks()
        {
            // Create a new list for both candlesticks and csv file names.
            CandleStickList = new List<CandleStick>();
            CsvFileNames = new List<string>();

            var csvFiles = Directory.GetFiles(folderPath, "*.csv");
            foreach (string csvFile in csvFiles)
            {
                CsvFileNames.Add(Path.GetFileName(csvFile));
                foreach (CandleStick candleStick in LoadCSV(Path.GetFileName(csvFile)))
                {
                    CandleStickList.Add(candleStick); // what a cringe way to do this in C#
                }
            }
            Console.WriteLine($"Loaded {csvFiles.Length} .csv files in {folderPath}.");
        }

        public List<CandleStick> LoadCSV(string csvFile)
        {
            var candleSticks = new List<CandleStick>();
            string[] lines = File.ReadAllLines($@"{folderPath}\{csvFile}");
            for (int i = 1; i < lines.Length; i++)
            {
                string[] csv = lines[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                candleSticks.Add(new CandleStick(DateTime.Parse(csv[0].Trim('"')),
                    double.Parse(csv[1]),
                    double.Parse(csv[2]),
                    double.Parse(csv[3]),
                    double.Parse(csv[4]),
                    double.Parse(csv.Length == 7 ? csv[5] : csv[4]))); // not necessary but maybe...
            }
            return candleSticks;
        }
    }
}
