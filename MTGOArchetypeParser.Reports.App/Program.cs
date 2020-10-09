using MTGOArchetypeParser.Data.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Reports.App
{
    class Program
    {
        static string _outputFolder = "reports";
        static double _minPercentage = 0.02;

        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    Console.WriteLine("Usage MTGOArchetypeParser.Reports.App.exe CACHE_FOLDER");
                    return;
                }
                string cacheFolder = args[0];

                if (Directory.Exists(_outputFolder)) Directory.Delete(_outputFolder, true);
                Directory.CreateDirectory(_outputFolder);

                bool allMetas = args.Any(a => a.ToLower() == "allmetas");
                bool includeLeagues = args.Any(a => a.ToLower() == "includeleagues");

                DateTime startDate = allMetas ?
                    MTGOArchetypeParser.Metas.Modern.Loader.GetMetas().First().StartDate :
                    MTGOArchetypeParser.Metas.Modern.Loader.GetMetas().Last(m => m.StartDate < DateTime.UtcNow).StartDate;

                DataRecord[] records = Loader.GetRecords(cacheFolder, startDate.AddDays(1), includeLeagues);

                string date = $"{records.Max(t => t.Date).ToString("yyyy_MM_dd")}";
                GenerateDump(records, $"mtgo_data_{date}");
                GenerateTrend(records, $"mtgo_trend_{date}");

                foreach (string meta in records.Select(r => r.Meta).Distinct())
                {
                    GenerateMeta(records.Where(r => r.Meta == meta), r => r.Archetype, $"mtgo_meta_archetype_{meta.ToLower()}_full_{date}", _minPercentage);
                    GenerateMeta(records.Where(r => r.Meta == meta), r => r.Archetype, $"mtgo_meta_all_archetype_{meta.ToLower()}_full_{date}", 0);
                    GenerateColors(records.Where(r => r.Meta == meta), $"mtgo_meta_colors_{meta.ToLower()}_full_{date}");
                    GenerateCards(records.Where(r => r.Meta == meta), $"mtgo_meta_cards_{meta.ToLower()}_full_{date}");

                    foreach (int week in records.Where(r => r.Meta == meta).Select(r => r.Week).Distinct())
                    {
                        GenerateMeta(records.Where(r => r.Meta == meta && r.Week == week), r => r.Archetype, $"mtgo_meta_archetype_{meta.ToLower()}_week{week.ToString("D2")}_{date}", _minPercentage);
                        GenerateMeta(records.Where(r => r.Meta == meta && r.Week == week), r => r.Archetype, $"mtgo_meta_all_archetype_{meta.ToLower()}_week{week.ToString("D2")}_{date}", 0);
                        GenerateColors(records.Where(r => r.Meta == meta && r.Week == week), $"mtgo_meta_colors_{meta.ToLower()}_week{week.ToString("D2")}_{date}");
                        GenerateCards(records.Where(r => r.Meta == meta && r.Week == week), $"mtgo_meta_cards_{meta.ToLower()}_week{week.ToString("D2")}_{date}");
                    }
                }

                Dictionary<int, int> totals = new Dictionary<int, int>();
                Dictionary<int, int> reds = new Dictionary<int, int>();
                foreach (var record in records)
                {
                    if (!totals.ContainsKey(record.Week)) totals.Add(record.Week, 0);
                    if (!reds.ContainsKey(record.Week)) reds.Add(record.Week, 0);

                    if (record.Deck.Mainboard.Any(c => c.Card == "Monastery Swiftspear"))
                    {
                        reds[record.Week]++;
                    }
                    totals[record.Week]++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static void GenerateDump(IEnumerable<DataRecord> records, string reportName)
        {
            StringBuilder csvData = new StringBuilder();
            csvData.AppendLine($"EVENT,META,WEEK,DATE,PLAYER,URL,ARCHETYPE,COLOR,COMPANION");

            foreach (var record in records)
            {
                csvData.AppendLine($"{record.Tournament},{record.Meta},{record.Week},{record.Date.ToString("yyyy-MM-dd")},{record.Player},{record.AnchorUri},{record.Archetype},{record.Color},{record.Companion}");
            }

            File.WriteAllText($"{_outputFolder}\\{reportName}.csv", csvData.ToString());
        }

        private static void GenerateTrend(IEnumerable<DataRecord> records, string reportName)
        {
            int maxWeeks = records.Max(r => r.Week);

            int[] totalPerWeek = new int[maxWeeks];
            Dictionary<string, int[]> consolidatedResults = new Dictionary<string, int[]>();
            foreach (var record in records)
            {
                totalPerWeek[record.Week - 1]++;
                if (!consolidatedResults.ContainsKey(record.Archetype)) consolidatedResults.Add(record.Archetype, new int[maxWeeks]);
                consolidatedResults[record.Archetype][record.Week - 1]++;
            }

            string header = "ARCHETYPE";
            for (int i = 0; i < maxWeeks; i++) header += $",WEEK {i + 1}";
            for (int i = 1; i < maxWeeks; i++) header += $",TREND WEEK {i + 1}";

            StringBuilder csvData = new StringBuilder();
            csvData.AppendLine(header);

            foreach (var archetype in consolidatedResults)
            {
                string line = $"{archetype.Key}";

                for (int i = 0; i < maxWeeks; i++)
                {
                    if (archetype.Value[i] > 0)
                    {
                        double percentage = 100d * ((double)archetype.Value[i]) / ((double)totalPerWeek[i]);
                        line += $",{percentage.ToString("F1", CultureInfo.InvariantCulture)}%";
                    }
                    else
                    {
                        line += ",";
                    }
                }

                for (int i = 1; i < maxWeeks; i++)
                {
                    double percentageLast = 100d * ((double)archetype.Value[i - 1]) / ((double)totalPerWeek[i - 1]);
                    double percentageCurrent = 100d * ((double)archetype.Value[i]) / ((double)totalPerWeek[i]);
                    double diff = (percentageCurrent - percentageLast);

                    if (diff > 5) line += $",↑↑";
                    else if (diff > 2) line += $",↑";
                    else if (diff < -5) line += $",↓↓";
                    else if (diff < -2) line += $",↓";
                    else line += $",-";
                }

                csvData.AppendLine(line);
            }

            File.WriteAllText($"{_outputFolder}\\{reportName}.csv", csvData.ToString());
        }

        private static void GenerateMeta(IEnumerable<DataRecord> records, Func<DataRecord, string> selector, string reportName, double minPercentage)
        {
            string othersKey = "Others";

            Dictionary<string, int> totals = new Dictionary<string, int>();
            foreach (var record in records)
            {
                string key = selector(record);
                if (!totals.ContainsKey(key)) totals.Add(key, 0);
                totals[key]++;
            }

            // Consolidates "other" data
            double minCount = (minPercentage * records.Count());
            Dictionary<string, int> consolidatedTotals = new Dictionary<string, int>();
            consolidatedTotals.Add(othersKey, 0);
            foreach (var total in totals)
            {
                if (total.Value > minCount) consolidatedTotals.Add(total.Key, total.Value);
                else consolidatedTotals[othersKey] += total.Value;
            }

            StringBuilder csvData = new StringBuilder();
            csvData.AppendLine($"DECK,COUNT,PERCENT");

            foreach (var total in consolidatedTotals.Where(t => t.Key != othersKey).OrderByDescending(t => t.Value))
            {
                csvData.AppendLine($"{total.Key},{total.Value},{Math.Round((100.0 * total.Value) / consolidatedTotals.Sum(c => c.Value), 1).ToString("F1", CultureInfo.InvariantCulture)}%");
            }
            if (consolidatedTotals[othersKey] > 0)
            {
                csvData.AppendLine($"{othersKey},{consolidatedTotals[othersKey]},{Math.Round((100.0 * consolidatedTotals[othersKey]) / totals.Sum(c => c.Value), 1).ToString("F1", CultureInfo.InvariantCulture)}%");
            }
            csvData.AppendLine($"Total,{consolidatedTotals.Sum(c => c.Value)},100%");

            File.WriteAllText($"{_outputFolder}\\{reportName}.csv", csvData.ToString());
        }

        private static void GenerateColors(IEnumerable<DataRecord> records, string reportName)
        {
            Dictionary<string, int> totals = new Dictionary<string, int>();
            totals.Add("W", 0);
            totals.Add("U", 0);
            totals.Add("B", 0);
            totals.Add("R", 0);
            totals.Add("G", 0);

            foreach (var record in records)
            {
                foreach (var color in totals.Keys.ToArray())
                {
                    if (record.Color.ToString().Contains(color)) totals[color]++;
                }
            }

            StringBuilder csvData = new StringBuilder();
            csvData.AppendLine($"COLOR,COUNT,PERCENT");

            foreach (var total in totals)
            {
                csvData.AppendLine($"{total.Key},{total.Value},{Math.Round((100.0 * total.Value) / records.Count(), 1).ToString("F1", CultureInfo.InvariantCulture)}%");
            }

            File.WriteAllText($"{_outputFolder}\\{reportName}.csv", csvData.ToString());
        }

        private static void GenerateCards(IEnumerable<DataRecord> records, string reportName)
        {
            Dictionary<string, int> count = new Dictionary<string, int>();
            Dictionary<string, int> decks = new Dictionary<string, int>();
            Dictionary<string, int> mainboardCount = new Dictionary<string, int>();
            Dictionary<string, int> sideboardCount = new Dictionary<string, int>();
            Dictionary<string, int> mainboardDecks = new Dictionary<string, int>();
            Dictionary<string, int> sideboardDecks = new Dictionary<string, int>();

            foreach (var record in records)
            {
                foreach (var card in record.Deck.Mainboard.Concat(record.Deck.Sideboard))
                {
                    if (!mainboardCount.ContainsKey(card.Card))
                    {
                        count.Add(card.Card, 0);
                        decks.Add(card.Card, 0);
                        mainboardCount.Add(card.Card, 0);
                        sideboardCount.Add(card.Card, 0);
                        mainboardDecks.Add(card.Card, 0);
                        sideboardDecks.Add(card.Card, 0);
                    }
                }
            }

            foreach (var record in records)
            {
                foreach (var card in record.Deck.Mainboard)
                {
                    count[card.Card] += card.Count;
                    mainboardCount[card.Card] += card.Count;
                    mainboardDecks[card.Card] += 1;
                }
                foreach (DeckItem card in record.Deck.Sideboard)
                {
                    count[card.Card] += card.Count;
                    sideboardCount[card.Card] += card.Count;
                    sideboardDecks[card.Card] += 1;
                }
                foreach (var card in record.Deck.Mainboard.Concat(record.Deck.Sideboard).Select(c => c.Card).Distinct())
                {
                    decks[card] += 1;
                }
            }

            StringBuilder csvData = new StringBuilder();
            csvData.AppendLine($"NAME,COUNT,DECKS,MAINBOARD_COUNT,MAINBOARD_DECKS,SIDEBOARD_COUNT,SIDEBOARD_DECKS");

            foreach (var card in decks.Keys.OrderByDescending(k => count[k]))
            {
                csvData.AppendLine($"{card.Replace(",", "")},{count[card]},{decks[card]},{mainboardCount[card]},{mainboardDecks[card]},{sideboardCount[card]},{sideboardDecks[card]}");
            }

            File.WriteAllText($"{_outputFolder}\\{reportName}.csv", csvData.ToString());
        }
    }
}

