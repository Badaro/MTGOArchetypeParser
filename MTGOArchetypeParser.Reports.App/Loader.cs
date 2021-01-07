using MTGOArchetypeParser.Data;
using MTGOArchetypeParser.Data.Model;
using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MTGOArchetypeParser.Reports.App
{
    public static class Loader
    {
        static Dictionary<string, ArchetypeColor> _lands = MTGOArchetypeParser.Cards.Modern.Loader.GetLands();
        static Dictionary<string, ArchetypeColor> _nonlands = MTGOArchetypeParser.Cards.Modern.Loader.GetNonLands();
        static Archetype[] _archetypes = MTGOArchetypeParser.Archetypes.Modern.Loader.GetArchetypes();

        public static DataRecord[] GetRecords(string cacheFolder, DateTime startDate)
        {
            Tournament[] tournaments = TournamentLoader.GetTournamentsByDate(cacheFolder, startDate, n => n.Contains("Modern") && !n.Contains("League")).ToArray();

            List<DataRecord> records = new List<DataRecord>();

            foreach (var tournament in tournaments)
            {
                ArchetypeMeta meta = Metas.Modern.Loader.GetMetas().Last(m => m.StartDate <= tournament.Decks.First().Date);
                DateTime metaWeekReferenceDate = GetMetaWeekReferenceDate(meta.StartDate);

                string metaID = meta.GetType().Name;

                int weekID = ((int)Math.Floor((tournament.Decks.First().Date.Value - metaWeekReferenceDate).Days / 7.0)) + 1;

                for (int i = 0; i < tournament.Decks.Length; i++)
                {
                    var detectionResult = ArchetypeAnalyzer.Detect(tournament.Decks[i].Mainboard.Select(i => new Card() { Name = i.Card, Count = i.Count }).ToArray(), tournament.Decks[i].Sideboard.Select(i => new Card() { Name = i.Card, Count = i.Count }).ToArray(), _archetypes, _lands, _nonlands);

                    string colorID = detectionResult.Color.ToString();
                    string companionID = detectionResult.Companion == null ? "" : detectionResult.Companion.Value.ToString();
                    string archetypeID = "Unknown";
                    string variantID = String.Empty;

                    if (detectionResult.Matches.Length == 1)
                    {
                        var detected = detectionResult.Matches.First();

                        archetypeID = detected.Archetype.GetName(detectionResult.Color);
                        if (detected.Variant != null)
                        {
                            archetypeID = detected.Variant.GetName(detectionResult.Color);
                        }
                    }

                    string points = "-";
                    if (tournament.Standings != null)
                    {
                        var standing = tournament.Standings.FirstOrDefault(s => s.Player == tournament.Decks[i].Player);
                        if (standing != null) points = standing.Points.ToString();
                    }

                    records.Add(new DataRecord()
                    {
                        Tournament = tournament.Information.Name,
                        Meta = metaID,
                        Week = weekID,
                        Date = tournament.Decks.First().Date.Value,
                        Result = tournament.Decks[i].Result,
                        Points = points,
                        Player = tournament.Decks[i].Player,
                        AnchorUri = tournament.Decks[i].AnchorUri,
                        Archetype = archetypeID,
                        Color = colorID,
                        Companion = companionID,
                        Deck = tournament.Decks[i]
                    });
                }
            }

            return records.OrderBy(r => r.Date).ToArray();
        }

        // Note: I'm considering the meta weeks as starting on monday
        static DateTime GetMetaWeekReferenceDate(DateTime metaStart)
        {
            switch (metaStart.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return metaStart.AddDays(-6);
                case DayOfWeek.Monday:
                    return metaStart;
                case DayOfWeek.Tuesday:
                    return metaStart.AddDays(-1);
                case DayOfWeek.Wednesday:
                    return metaStart.AddDays(-2);
                case DayOfWeek.Thursday:
                    return metaStart.AddDays(-3);
                case DayOfWeek.Friday:
                    return metaStart.AddDays(-4);
                case DayOfWeek.Saturday:
                    return metaStart.AddDays(-5);
                default:
                    throw new Exception("Invalid DayOfWeek for meta start date");
            }
        }
    }
}
