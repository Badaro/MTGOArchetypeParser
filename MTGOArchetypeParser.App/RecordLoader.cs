using MTGOArchetypeParser.Data;
using MTGOArchetypeParser.Data.Model;
using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MTGOArchetypeParser.App
{
    public static class RecordLoader
    {
        public static Record[] GetRecords(Tournament[] tournaments, ArchetypeFormat format, ArchetypeFormat referenceFormat)
        {
            List<Record> records = new List<Record>();

            foreach (var tournament in tournaments)
            {
                ArchetypeMeta meta = format.Metas.Last(m => m.StartDate <= tournament.Decks.First().Date);
                DateTime metaWeekReferenceDate = GetMetaWeekReferenceDate(meta.StartDate);

                string metaID = meta.Name;

                int weekID = ((int)Math.Floor((tournament.Decks.First().Date.Value - metaWeekReferenceDate).Days / 7.0)) + 1;

                for (int i = 0; i < tournament.Decks.Length; i++)
                {
                    RecordArchetype archetype = GetArchetype(tournament.Decks[i], format);

                    RecordArchetype referenceArchetype = null;
                    if (referenceFormat != null) referenceArchetype = GetArchetype(tournament.Decks[i], referenceFormat);

                    string points = "-";
                    if (tournament.Standings != null)
                    {
                        var standing = tournament.Standings.FirstOrDefault(s => s.Player == tournament.Decks[i].Player);
                        if (standing != null) points = standing.Points.ToString();
                    }

                    records.Add(new Record()
                    {
                        TournamentFile = Path.GetFileNameWithoutExtension(tournament.File),
                        Tournament = tournament.Information.Name,
                        Meta = metaID,
                        Week = weekID,
                        Date = tournament.Decks.First().Date.Value,
                        Result = tournament.Decks[i].Result,
                        Points = points,
                        Player = tournament.Decks[i].Player,
                        AnchorUri = tournament.Decks[i].AnchorUri,
                        Archetype = archetype,
                        ReferenceArchetype = referenceArchetype
                    });
                }
            }

            return records.OrderBy(r => r.Date).ToArray();
        }

        private static RecordArchetype GetArchetype(Deck deck, ArchetypeFormat format)
        {
            var detectionResult = ArchetypeAnalyzer.Detect(deck.Mainboard.Select(i => new Card() { Name = i.Card, Count = i.Count }).ToArray(), deck.Sideboard.Select(i => new Card() { Name = i.Card, Count = i.Count }).ToArray(), format);

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

            return new RecordArchetype()
            {
                Archetype = archetypeID,
                Companion = companionID,
                Color = colorID,
            };
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
