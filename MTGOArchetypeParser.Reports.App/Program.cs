﻿using MTGOArchetypeParser.Data.Model;
using MTGOArchetypeParser.Model;
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
                if (args.Length < 2)
                {
                    Console.WriteLine("Usage MTGOArchetypeParser.Reports.App.exe FORMAT_DATA_FOLDER CACHE_FOLDER_1 [CACHE_FOLDER_2] [CACHE_FOLDER_3]");
                    return;
                }

                string formatDataFolders = args[0];
                string[] cacheFolders = args.Skip(1).ToArray();

                ArchetypeFormat modernFormat = MTGOArchetypeParser.Formats.FromJson.Loader.GetFormat(formatDataFolders, "Modern");

                if (Directory.Exists(_outputFolder)) Directory.Delete(_outputFolder, true);
                Directory.CreateDirectory(_outputFolder);

                DateTime startDate = modernFormat.Metas.First().StartDate;

                DataRecord[] records = cacheFolders.SelectMany(c => Loader.GetRecords(c, modernFormat, startDate.AddDays(1))).OrderBy(c => c.Date).ToArray();

                string date = $"{records.Max(t => t.Date).ToString("yyyy_MM_dd")}";
                GenerateDump(records, $"mtgo_data_{date}");

                foreach (string meta in records.Select(r => r.Meta).Distinct())
                {
                    GenerateMeta(records.Where(r => r.Meta == meta), r => r.Archetype, $"mtgo_meta_archetype_{meta.ToLower()}_full_{date}", _minPercentage);
                    foreach (int week in records.Where(r => r.Meta == meta).Select(r => r.Week).Distinct())
                    {
                        GenerateMeta(records.Where(r => r.Meta == meta && r.Week == week), r => r.Archetype, $"mtgo_meta_archetype_{meta.ToLower()}_week{week.ToString("D2")}_{date}", _minPercentage);
                    }
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
            csvData.AppendLine($"EVENT,META,WEEK,DATE,RESULT,POINTS,PLAYER,URL,ARCHETYPE,COLOR,COMPANION");

            foreach (var record in records)
            {
                csvData.AppendLine($"{record.Tournament},{record.Meta},{record.Week},{record.Date.ToString("yyyy-MM-dd")},{record.Result},{record.Points},{record.Player},{record.AnchorUri},{record.Archetype},{record.Color},{record.Companion}");
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
    }
}

