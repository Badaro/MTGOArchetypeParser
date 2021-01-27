using MTGOArchetypeParser.Data;
using MTGOArchetypeParser.Data.Model;
using MTGOArchetypeParser.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace MTGOArchetypeParser.App
{
    class Program
    {
        static string _settingsFile = "settings.json";

        static void Main(string[] args)
        {
            try
            {
                var settings = ExecutionSettings.FromJsonFile(_settingsFile);
                settings.ApplyOverrides(args);
                settings.Validate();
                settings.Print();

                Console.WriteLine("Starting detection engine:");
                Console.WriteLine("* Loading format data");
                ArchetypeFormat format = Formats.FromJson.Loader.GetFormat(settings.FormatDataFolder, settings.Format);

                ArchetypeFormat referenceFormat = null;
                if (!String.IsNullOrEmpty(settings.ReferenceFormat))
                {
                    referenceFormat = Formats.FromJson.Loader.GetFormat(settings.FormatDataFolder, settings.ReferenceFormat);
                }

                Console.WriteLine("* Loading tournaments");
                Tournament[] tournaments = settings.TournamentFolder.SelectMany(c => TournamentLoader.GetTournamentsByDate(c, format.Metas.First().StartDate.AddDays(1))).ToArray();

                foreach (string filter in settings.Filter)
                {
                    tournaments = tournaments.Where(t => t.Information.Name.Contains(filter, StringComparison.InvariantCultureIgnoreCase) || t.Information.Uri.ToString().Contains(filter, StringComparison.InvariantCultureIgnoreCase)).ToArray();
                }
                foreach (string exclude in settings.Exclude)
                {
                    tournaments = tournaments.Where(t => !t.Information.Name.Contains(exclude, StringComparison.InvariantCultureIgnoreCase) && !t.Information.Uri.ToString().Contains(exclude, StringComparison.InvariantCultureIgnoreCase)).ToArray();
                }

                Record[] records = RecordLoader.GetRecords(tournaments, format, referenceFormat);

                if (!String.IsNullOrEmpty(settings.Meta))
                {
                    string metaFilter = settings.Meta;
                    if (metaFilter.ToLowerInvariant() == "current") metaFilter = format.Metas.Where(m => m.StartDate.AddDays(1) < DateTime.UtcNow).Last().Name;
                    records = records.Where(r => r.Meta.Contains(metaFilter, StringComparison.InvariantCultureIgnoreCase)).ToArray();

                    if (!String.IsNullOrEmpty(settings.MetaWeek))
                    {
                        int metaWeekFilter;
                        if (settings.MetaWeek.ToLowerInvariant() == "current") metaWeekFilter = records.Max(r => r.Week);
                        else metaWeekFilter = Int32.Parse(settings.MetaWeek);

                        records = records.Where(r => r.Week == metaWeekFilter).ToArray();
                    }
                }

                if (records.Length == 0)
                {
                    Console.WriteLine("No records found with the current filters");
                }
                else
                {
                    if (settings.Action == ExecutionAction.Compare)
                    {
                        records = records.Where(r => !r.Archetype.Equals(r.ReferenceArchetype)).ToArray();
                    }

                    if (settings.Output == ExecutionOutput.Console)
                    {
                        new ConsoleOutput().Write(records, settings.Action);
                    }
                    else
                    {
                        Console.WriteLine("Saving data to CSV file");
                        new CsvOutput().Write(records, settings.Action);
                    }
                }

                if (settings.MetaBreakdown) PrintBreakdown(records);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                if (ex is ValidationException) Console.WriteLine(_usage);
            }
        }

        static void PrintBreakdown(Record[] records)
        {
            double minPercentage = 0.02;
            string othersKey = "Others";

            Dictionary<string, int> totals = new Dictionary<string, int>();
            foreach (var record in records)
            {
                string key = record.Archetype.Archetype;
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

            Console.WriteLine("Meta Breakdown:");

            foreach (var total in consolidatedTotals.Where(t => t.Key != othersKey).OrderByDescending(t => t.Value))
            {
                Console.WriteLine($"* {total.Key} ({Math.Round((100.0 * total.Value) / consolidatedTotals.Sum(c => c.Value), 1).ToString("F1", CultureInfo.InvariantCulture)}%) ");
            }
            if (consolidatedTotals[othersKey] > 0)
            {
                Console.WriteLine($"* {othersKey} ({Math.Round((100.0 * consolidatedTotals[othersKey]) / consolidatedTotals.Sum(c => c.Value), 1).ToString("F1", CultureInfo.InvariantCulture)}%) ");
            }
            Console.WriteLine($"Total Decks: {consolidatedTotals.Sum(c => c.Value)}");
        }

        static string _usage = @"Usage: MTGOArchetypeParser.App [OUTPUT] [ACTION] [SETTINGS]

Sample:
MTGOArchetypeParser.App csv detect filter=challenge
MTGOArchetypeParser.App console compare filter=modern-preliminary-2021-01-21 referenceformat=Modern-Old

Outputs:
* console: Prints the results in-line
* csv: Generates a csv file with the results

Actions:
* detect: Detects archetypes
* compare: Compares the results between two format data sets

Settings (can also be specified using settings.json):
* format: Format data to be used for detection
* referenceformat: Format data to be used for comparison
* meta: Only generate data for events that belong to this meta
* metaweek: Only generate data for events that belong to this meta week
* filter: Only generate data for events that match this string, can be specified more than once
* exclude: Only generate data for events that do NOT match this string, can be specified more than once
* metabreakdown: If set to true will include a meta breakdown summary at the end of the console output
* tournamentfolder: Specifies the location of folders with the tournament data, can be specified more than once
* formatdatafolder: Specifies the location of the folders with the format data";
    }
}
