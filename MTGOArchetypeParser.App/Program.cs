﻿using MTGOArchetypeParser.Data;
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

                Console.WriteLine("* Loading meta information");
                DateTime startDate = format.Metas.First().StartDate.AddDays(1);
                string metaFilter = String.Empty;
                if (settings.StartDate == null && !String.IsNullOrEmpty(settings.Meta))
                {
                    if (settings.Meta.ToLowerInvariant() == "current") metaFilter = format.Metas.Where(m => m.StartDate.AddDays(1) < DateTime.UtcNow).Last().Name;
                    else metaFilter = settings.Meta;

                    var meta = format.Metas.FirstOrDefault(m => m.Name.Contains(metaFilter, StringComparison.InvariantCultureIgnoreCase));
                    if (meta != null) startDate = meta.StartDate.AddDays(1);
                }

                if (settings.StartDate != null) startDate = settings.StartDate.Value;

                Console.WriteLine("* Loading tournaments");
                Tournament[] tournaments = settings.TournamentFolder.SelectMany(c => TournamentLoader.GetTournamentsByDate(c, startDate, t =>
                {
                    if (settings.Filter != null)
                    {
                        foreach (string filter in settings.Filter)
                        {
                            if (!t.Contains(filter, StringComparison.InvariantCultureIgnoreCase)) return false;
                        }
                    }
                    if (settings.Exclude != null)
                    {
                        foreach (string exclude in settings.Exclude)
                        {
                            if (t.Contains(exclude, StringComparison.InvariantCultureIgnoreCase)) return false;
                        }
                    }
                    return true;
                }, t =>
                {
                    if (settings.FolderFilter != null)
                    {
                        foreach (string folderFilter in settings.FolderFilter)
                        {
                            if (!t.Contains(folderFilter, StringComparison.InvariantCultureIgnoreCase)) return false;
                        }
                    }
                    return true;
                })).ToArray();

                Record[] records = RecordLoader.GetRecords(tournaments, format, referenceFormat, settings.IncludeDecklists, settings.IncludeMatchups, settings.MaxDecksPerEvent, settings.ConflictSolvingMode);

                if (!String.IsNullOrEmpty(metaFilter))
                {
                    records = records.Where(r => r.Meta.Contains(metaFilter, StringComparison.InvariantCultureIgnoreCase)).ToArray();

                    if (!String.IsNullOrEmpty(settings.MetaWeek))
                    {
                        int metaWeekFilter;
                        if (settings.MetaWeek.ToLowerInvariant() == "current") metaWeekFilter = records.Max(r => r.Week);
                        else metaWeekFilter = Int32.Parse(settings.MetaWeek);

                        records = records.Where(r => r.Week == metaWeekFilter).ToArray();
                    }
                }

                if (!String.IsNullOrEmpty(settings.Archetype))
                {
                    records = records.Where(r => r.Archetype.Archetype.Contains(settings.Archetype, StringComparison.InvariantCultureIgnoreCase)).ToArray();
                }

                if (!String.IsNullOrEmpty(settings.Player))
                {
                    records = records.Where(r => r.Player.Equals(settings.Player, StringComparison.InvariantCultureIgnoreCase)).ToArray();
                }

                if (!String.IsNullOrEmpty(settings.Color))
                {
                    records = records.Where(r => r.Archetype.Color.Equals(settings.Color, StringComparison.InvariantCultureIgnoreCase)).ToArray();
                }

                if (settings.Card != null && settings.IncludeDecklists)
                {
                    foreach (string card in settings.Card)
                    {
                        records = records.Where(r =>
                            r.Mainboard.Any(c => c.Card.Equals(card, StringComparison.InvariantCultureIgnoreCase)) ||
                            r.Sideboard.Any(c => c.Card.Equals(card, StringComparison.InvariantCultureIgnoreCase))
                        ).ToArray();
                    }
                }

                if (settings.ExcludeCard != null && settings.IncludeDecklists)
                {
                    foreach (string card in settings.ExcludeCard)
                    {
                        records = records.Where(r =>
                            !r.Mainboard.Any(c => c.Card.Equals(card, StringComparison.InvariantCultureIgnoreCase)) &&
                            !r.Sideboard.Any(c => c.Card.Equals(card, StringComparison.InvariantCultureIgnoreCase))
                        ).ToArray();
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

                    IOutput output;

                    switch (settings.Output)
                    {
                        case ExecutionOutput.Csv:
                            PrintRecords(records, settings, new IOutput[] { new CsvOutput(), new ConsoleOutput() });
                            break;
                        case ExecutionOutput.Json:
                            PrintRecords(records, settings, new IOutput[] { new JsonOutput(), new ConsoleOutput() });
                            break;
                        case ExecutionOutput.Reddit:
                            PrintRecords(records, settings, new IOutput[] { new RedditOutput(), new ConsoleOutput() });
                            break;
                        case ExecutionOutput.Console:
                        default:
                            PrintRecords(records, settings, new IOutput[] { new ConsoleOutput() });
                            break;
                    }

                    if (settings.MetaBreakdown) PrintBreakdown(records, settings, new IOutput[] { new ConsoleOutput() });
                    if (settings.WinrateBreakdown) PrintWinrates(records, settings, new IOutput[] { new ConsoleOutput() });
                    if (settings.CardBreakdown) PrintCards(records, settings, new IOutput[] { new ConsoleOutput() });
                    if (settings.MatchupsFor != null) PrintMatchups(records, settings, new IOutput[] { new ConsoleOutput() });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                if (ex is ValidationException) Console.WriteLine(_usage);
            }
        }

        static void PrintRecords(Record[] records, ExecutionSettings settings, IEnumerable<IOutput> outputs)
        {
            foreach (var output in outputs) output.WriteRecords(records, settings);
        }

        static void PrintBreakdown(Record[] records, ExecutionSettings settings, IEnumerable<IOutput> outputs)
        {
            double minPercentage = settings.MinOthersPercent / 100;

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
            consolidatedTotals.Add(settings.OthersKey, 0);
            foreach (var total in totals)
            {
                if (total.Value > minCount) consolidatedTotals.Add(total.Key, total.Value);
                else consolidatedTotals[settings.OthersKey] += total.Value;
            }

            foreach (var output in outputs) output.WriteBreakdown(consolidatedTotals, settings);
        }

        static void PrintWinrates(Record[] records, ExecutionSettings settings, IEnumerable<IOutput> outputs)
        {
            Dictionary<string, RecordMatchup> results = new Dictionary<string, RecordMatchup>();

            foreach (var record in records)
            {
                if (!results.ContainsKey(record.Archetype.Archetype)) results.Add(record.Archetype.Archetype, new RecordMatchup());

                if (record.Wins != "-") results[record.Archetype.Archetype].Wins += int.Parse(record.Wins);
                if (record.Losses != "-") results[record.Archetype.Archetype].Losses += int.Parse(record.Losses);
                if (record.Draws != "-") results[record.Archetype.Archetype].Draws += int.Parse(record.Draws);
            }

            foreach (var output in outputs) output.WriteWinrates(results, settings);
        }

        static void PrintCards(Record[] records, ExecutionSettings settings, IEnumerable<IOutput> outputs)
        {
            Console.WriteLine("----- Card Breakdown: -----");

            Dictionary<string, int> cards = new Dictionary<string, int>();
            foreach (var record in records)
            {
                foreach (var card in record.Mainboard)
                {
                    if (!cards.ContainsKey(card.Card)) cards.Add(card.Card, 0);
                    cards[card.Card] += card.Count;
                }
                foreach (var card in record.Sideboard)
                {
                    if (!cards.ContainsKey(card.Card)) cards.Add(card.Card, 0);
                    cards[card.Card] += card.Count;
                }
            }

            foreach (var output in outputs) output.WriteCards(cards, settings);
        }

        static void PrintMatchups(Record[] records, ExecutionSettings settings, IEnumerable<IOutput> outputs)
        {
            Dictionary<string, RecordMatchup> results = new Dictionary<string, RecordMatchup>();

            var archetypeRecords = records.Where(r => r.Archetype.Archetype == settings.MatchupsFor).ToList();
            foreach (var record in archetypeRecords)
            {
                if (record.Matchups != null)
                {
                    foreach (var matchup in record.Matchups)
                    {
                        if (matchup.OpponentArchetype == settings.MatchupsFor) continue; // Skip mirrors

                        if (!results.ContainsKey(matchup.OpponentArchetype)) results.Add(matchup.OpponentArchetype, new RecordMatchup());

                        if (matchup.Wins > matchup.Losses)
                        {
                            results[matchup.OpponentArchetype].Wins++;
                        }
                        else
                        {
                            if (matchup.Wins < matchup.Losses)
                            {
                                results[matchup.OpponentArchetype].Losses++;
                            }
                            else
                            {
                                results[matchup.OpponentArchetype].Draws++;
                            }
                        }
                    }
                }
            }

            foreach (var output in outputs) output.WriteMatchups(results, settings);
        }

        static string _usage = @"Usage: MTGOArchetypeParser.App [OUTPUT] [ACTION] [SETTINGS]

Sample:
MTGOArchetypeParser.App csv detect filter=challenge
MTGOArchetypeParser.App console compare filter=modern-preliminary-2021-01-21 referenceformat=Modern-Old

Outputs:
* console: Prints the results in-line
* csv: Generates a csv file with the results
* json: Generates a jsonfile with the results

Actions:
* detect: Detects archetypes
* compare: Compares the results between two format data sets

Settings (can also be specified using settings.json):
* format: Format data to be used for detection
* referenceformat: Format data to be used for comparison
* meta: Only generate data for events that belong to this meta
* metaweek: Only generate data for events that belong to this meta week
* startdate: Only generate data for events on or after this date, must be in format yyyy-MM-dd
* filter: Only generate data for events that match this string, can be specified more than once
* folderfilter: Only generate data for events in folders that match this string, can be specified more than once
* exclude: Only generate data for events that do NOT match this string, can be specified more than once
* archetype: Only generate data for decks whose archetypes match this string
* player: Only generate data for decks whose player is exactly this string
* color: Only generate data for decks whose color is exactly this string
* card: Only generate data for decks that contains this card, can be specified more than once, requires includedecklists=true
* excludecard: Only generate data for decks that do not contain this card, can be specified more than once, requires includedecklists=true
* metabreakdown: If set to true will include a meta breakdown summary at the end of the console output
* metabreakdownshowcount: If set to true will show the number of decks instead of the percent of decks in the meta breakdown
* cardbreakdown: If set to true will include a card breakdown summary at the end of the console output
* matchupsfor: If an archetype is specified in this parameter it will an matchup breakdown summary at the end of the console output
* includedecklists: If set to true will include the decklists in the output, only supported when using json
* includematchups: If set to true will include the matchups in the output, only supported when using json
* maxdecksperevent: Limits the number of decks per event
* minotherspercent: Sets the minimum percent to include an archetype in 'Others'
* tournamentfolder: Specifies the location of folders with the tournament data, can be specified more than once
* formatdatafolder: Specifies the location of the folders with the format data
* outputfile: Specifies the name of the file to be saved when using csv ou json output
* showcolors: If set to true will include colors for each deck in the console output
* conflictsolvingmode: If set to prefersimpler will automatically solve conflicts by picking the simpler deck";
    }
}
