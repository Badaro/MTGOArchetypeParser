﻿using MTGOArchetypeParser.Data;
using MTGOArchetypeParser.Model;
using MTGODecklistParser.Data;
using MTGODecklistParser.Model;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.DownloadAll.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Downloading tournament list");

                bool allMetas = args.Any(a => a.ToLower() == "allmetas");
                bool includeLeagues = args.Any(a => a.ToLower() == "includeleagues");

                DateTime startDate = allMetas ?
                    MTGOArchetypeParser.Metas.Modern.Loader.GetMetas().First().StartDate :
                    MTGOArchetypeParser.Metas.Modern.Loader.GetMetas().Last().StartDate;

                Func<Tournament, bool> excludeLeaguesFilter = t => t.Name.Contains("Modern") && !t.Name.Contains("League");
                Func<Tournament, bool> includeLeaguesFilter = t => t.Name.Contains("Modern");
                Func<Tournament, bool> filter = includeLeagues ? includeLeaguesFilter : excludeLeaguesFilter;

                Tournament[] tournaments = TournamentLoader.GetTournaments(startDate, DateTime.UtcNow).Where(t => filter(t)).ToArray();

                // Destination CSV output
                StringBuilder csvData = new StringBuilder();
                csvData.AppendLine($"EVENT,META,WEEK,DATE,PLAYER,URL,ARCHETYPE,VARIANT,COLOR,COMPANION");

                foreach (var tournament in tournaments)
                {
                    Console.WriteLine($"Downloading {tournament.Uri}");

                    ArchetypeMeta meta = Metas.Modern.Loader.GetMetas().Last(m => m.StartDate <= tournament.Date);
                    DateTime metaWeekReferenceDate = GetMetaWeekReferenceDate(meta.StartDate);

                    string metaID = meta.GetType().Name;
                    int weekID = ((int)Math.Floor((tournament.Date - metaWeekReferenceDate).Days / 7.0)) + 1;

                    var decks = MTGODecklistParser.Data.DeckLoader.GetDecks(tournament.Uri);

                    for (int i = 0; i < decks.Length; i++)
                    {
                        var detectionResult = ArchetypeAnalyzer.Detect(decks[i].Mainboard.Select(i => i.CardName).ToArray(), decks[i].Sideboard.Select(i => i.CardName).ToArray(), MTGOArchetypeParser.Archetypes.Modern.Loader.GetArchetypes());

                        string colorID = detectionResult.Color.ToString();
                        string companionID = detectionResult.Companion == null ? "" : detectionResult.Companion.Value.ToString();
                        string archetypeID = "Unknown";
                        string variantID = String.Empty;

                        if (detectionResult.Matches.Length == 1)
                        {
                            var detected = detectionResult.Matches.First();
                            archetypeID = detected.Archetype.GetType().Name;
                            if (detected.Variant != null)
                            {
                                variantID = detected.Variant.GetType().Name;
                            }
                        }

                        string consolidatedID = String.IsNullOrEmpty(variantID) ? archetypeID : variantID;

                        csvData.AppendLine($"{tournament.Name},{metaID},{weekID},{tournament.Date.ToString("yyyy-MM-dd")},{decks[i].Player},{decks[i].AnchorUri},{archetypeID},{consolidatedID},{colorID},{companionID}");
                    }

                    File.WriteAllText($"mtgo_data_{tournaments.Max(t => t.Date).ToString("yyyy_MM_dd")}.csv", csvData.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Note: I'm considering the meta weeks as starting on tuesday, since the weekend events (challenges) are posted monday
        static DateTime GetMetaWeekReferenceDate(DateTime metaStart)
        {
            switch (metaStart.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return metaStart.AddDays(-5);
                case DayOfWeek.Monday:
                    return metaStart.AddDays(-6);
                case DayOfWeek.Tuesday:
                    return metaStart;
                case DayOfWeek.Wednesday:
                    return metaStart.AddDays(-1);
                case DayOfWeek.Thursday:
                    return metaStart.AddDays(-2);
                case DayOfWeek.Friday:
                    return metaStart.AddDays(-3);
                case DayOfWeek.Saturday:
                    return metaStart.AddDays(-4);
                default:
                    throw new Exception("Invalid DayOfWeek for meta start date");
            }
        }
    }
}

