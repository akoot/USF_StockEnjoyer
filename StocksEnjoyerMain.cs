using System;
using System.Collections.Generic;
using System.IO;
using StocksEnjoyer.Recognizers;

// if i wasn't limited to .net windows forms this would actually look good
// i refuse to programatically set the "paint" of a button and whatnot or whatever
// but at least this will run on a computer from 2002!!!!
namespace StocksEnjoyer
{
    /// <summary>
    ///     This is the main class that will contain most of the data that needs to be shared between classes and forms.
    /// </summary>
    public class StocksEnjoyerMain
    {
        // This is the default directory where all the CSV files are held.
        // Due to budget cuts and time constraints our team was not able to
        // implement a function to change this directory during runtime.
        public const string FolderPath = "Stock Data"; // replace with your folder path

        // This dictionary holds all of the pattern recognizers to be later used during runtime.
        // The name of the pattern is the key, and the actual object is the value.
        // If I want to get the Doji pattern recognizer, I run PatternRecognizers["Doji"];
        public readonly Dictionary<string, PatternRecognizer> PatternRecognizers =
            new Dictionary<string, PatternRecognizer>();

        // This is used to populate the combo box displaying the CSV files.
        public List<string> CsvFileNames = new List<string>();

        /// <summary>
        ///     The "chart" form instance
        /// </summary>
        public ChartForm FormChart;

        /// <summary>
        /// The main constructor for the main class.
        /// This will load all of the candlesticks into memory
        /// </summary>
        public StocksEnjoyerMain()
        {
            SetupCsvFiles();
            SetupRecognizers();
            FormChart = new ChartForm(this);
        }

        /// <summary>
        ///     This function sets up all of the recognizer abstract classes.
        /// </summary>
        private void SetupRecognizers()
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
        ///     Loads all of the candlesticks into memory.
        ///     This looks inside of the "Stock Data" folder located where the program's executable is.
        ///     This function can be called any time during runtime to reload the list of CSV files.
        /// </summary>
        public void SetupCsvFiles()
        {
            // Create a new list for csv file names.
            CsvFileNames = new List<string>();
            
            // Get the list of CSV files inside the FolderPath
            var csvFiles = Directory.GetFiles(FolderPath, "*.csv");
            
            // Save only the names and not the full path into the variable.
            foreach (var csvFile in csvFiles) CsvFileNames.Add(Path.GetFileName(csvFile));
            
            // Log this to help
            Console.WriteLine($"Loaded {csvFiles.Length} .csv files in {FolderPath}.");
        }

        /// <summary>
        /// Loads the CSV file provided and creates a CandleStick object for every line in that file.
        /// </summary>
        /// <param name="csvFile"></param>
        /// <returns></returns>
        public static List<CandleStick> LoadCsv(string csvFile)
        {
            // Create an empty list to fill with candlesticks
            var candleSticks = new List<CandleStick>();
            
            // Get the lines from each file
            var lines = File.ReadAllLines($@"{FolderPath}\{csvFile}");
            
            // For each line, create a CandleStick object using the data separated by a comma.
            for (var i = 1; i < lines.Length; i++)
            {
                // Split each line with a comma and remove empty entries.
                var csv = lines[i].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                
                // Add a new CandleStick object to the list of candlesticks defined above
                candleSticks.Add(new CandleStick(DateTime.Parse(csv[0].Trim('"')),
                    double.Parse(csv[1]),
                    double.Parse(csv[2]),
                    double.Parse(csv[3]),
                    double.Parse(csv[4]),
                    // This would account for the old csv file format that was not downloaded from Yahoo
                    // but rather it was provided.
                    double.Parse(csv.Length == 7 ? csv[5] : csv[4]))); // not necessary but maybe...
            }
            
            // Return the list of candlesticks.
            return candleSticks;
        }
    }
}