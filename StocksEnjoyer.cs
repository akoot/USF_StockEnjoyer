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
    public class StocksEnjoyer
    {

        public string folderPath = "Stock Data"; // replace with your folder path

        public List<CandleStick> CandleStickList;
        public List<string> CsvFileNames = new List<string>();

        public Dictionary<string, Recognizer> Recognizers = new Dictionary<string, Recognizer>();

        /// <summary>
        /// The "chart" form instance
        /// </summary>
        public ChartForm form_chart;
        public StocksEnjoyer() {
            LoadCandlesticks();
            SetupRecognizers();
            form_chart = new ChartForm(this);
        }

        public void SetupRecognizers()
        {
            Recognizers["Doji"] = new DojiRecognizer();
            Recognizers["Dragonfly"] = new DragonflyDojiRecognizer();
            Recognizers["Evening Star"] = new EveningStartRecognizer();
            Recognizers["Gravestone"] = new GravestoneDojiRecognizer();
            Recognizers["Hammer"] = new HammerRecognizer();
            Recognizers["Inverted Hammer"] = new InvertedHammerRecognizer();
            Recognizers["Marobuzo"] = new MarobuzoRecognizer();
            Recognizers["Spinning Top"] = new SpinningTopRecognizer();
            Recognizers["Harami"] = new HaramiRecognizer();
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
