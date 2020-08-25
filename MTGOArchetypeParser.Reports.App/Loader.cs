using MTGOArchetypeParser.Data;
using MTGOArchetypeParser.Data.Model;
using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Reports.App
{
    public static class Loader
    {
        public static DataRecord[] GetRecords(string cacheFolder, DateTime startDate, bool includeLeagues)
        {
            Func<string, bool> excludeLeaguesFilter = n => n.Contains("Modern") && !n.Contains("League");
            Func<string, bool> includeLeaguesFilter = n => n.Contains("Modern");
            Func<string, bool> filter = includeLeagues ? includeLeaguesFilter : excludeLeaguesFilter;

            Tournament[] tournaments = TournamentLoader.GetTournamentsByDate(cacheFolder, startDate, filter).ToArray();

            List<DataRecord> records = new List<DataRecord>();

            foreach (var tournament in tournaments)
            {
                ArchetypeMeta meta = Metas.Modern.Loader.GetMetas().Last(m => m.StartDate <= tournament.Decks.First().Date);
                DateTime metaWeekReferenceDate = GetMetaWeekReferenceDate(meta.StartDate);

                string metaID = meta.GetType().Name;

                int weekID = ((int)Math.Floor((tournament.Decks.First().Date.Value - metaWeekReferenceDate).Days / 7.0)) + 1;

                for (int i = 0; i < tournament.Decks.Length; i++)
                {
                    var detectionResult = ArchetypeAnalyzer.Detect(tournament.Decks[i].Mainboard.Select(i => new Card() { Name = i.Card, Count = i.Count }).ToArray(), tournament.Decks[i].Sideboard.Select(i => new Card() { Name = i.Card, Count = i.Count }).ToArray(), MTGOArchetypeParser.Archetypes.Modern.Loader.GetArchetypes());

                    string colorID = detectionResult.Color.ToString();
                    string companionID = detectionResult.Companion == null ? "" : detectionResult.Companion.Value.ToString();
                    string archetypeID = "Unknown";
                    string variantID = String.Empty;

                    if (detectionResult.Matches.Length == 1)
                    {
                        var detected = detectionResult.Matches.First();

                        archetypeID = detected.Archetype.GetType().Name;
                        if (detected.Archetype is ArchetypeGeneric)
                        {
                            string colorName = GetColorName(detectionResult.Color);
                            archetypeID = archetypeID.Replace("Generic", colorName);
                        }
                        else
                        {
                            if (detected.Variant != null)
                            {
                                variantID = detected.Variant.GetType().Name;
                            }
                        }
                    }

                    string consolidatedID = String.IsNullOrEmpty(variantID) ? archetypeID : variantID;

                    records.Add(new DataRecord()
                    {
                        Tournament = tournament.Information.Name,
                        Meta = metaID,
                        Week = weekID,
                        Date = tournament.Decks.First().Date.Value,
                        Player = tournament.Decks[i].Player,
                        AnchorUri = tournament.Decks[i].AnchorUri,
                        Archetype = archetypeID,
                        Variant = consolidatedID,
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

        static string GetColorName(ArchetypeColor color)
        {
            switch (color)
            {
                case ArchetypeColor.W:
                    return $"MonoWhite";
                case ArchetypeColor.U:
                    return $"MonoBlue";
                case ArchetypeColor.B:
                    return $"MonoBlack";
                case ArchetypeColor.R:
                    return $"MonoRed";
                case ArchetypeColor.G:
                    return $"MonoGreen";
                case ArchetypeColor.WU:   // Azorius
                    return $"Azorius";
                case ArchetypeColor.WB:   // Orzhov
                    return $"Orzhov";
                case ArchetypeColor.WR:   // Boros
                    return $"Boros";
                case ArchetypeColor.WG:   // Selesnya
                    return $"Selenya";
                case ArchetypeColor.UB:   // Dimir
                    return $"Dimir";
                case ArchetypeColor.UR:   // Izzet
                    return $"Izzet";
                case ArchetypeColor.UG:   // Simic
                    return $"Simic";
                case ArchetypeColor.BR:   // Rakdos
                    return $"Rakdos";
                case ArchetypeColor.BG:   // Golgari
                    return $"Golgari";
                case ArchetypeColor.RG:   // Gruul
                    return $"Gruul";
                case ArchetypeColor.WUB:  // Esper
                    return $"Esper";
                case ArchetypeColor.WUR:  // Jeskai
                    return $"Jeskai";
                case ArchetypeColor.WUG:  // Bant
                    return $"Bant";
                case ArchetypeColor.WBR:  // Mardu
                    return $"Mardu";
                case ArchetypeColor.WBG:  // Abzan
                    return $"Abzan";
                case ArchetypeColor.WRG:  // Naya
                    return $"Naya";
                case ArchetypeColor.UBR:  // Grixis
                    return $"Grixis";
                case ArchetypeColor.UBG:  // Sultai
                    return $"Sultai";
                case ArchetypeColor.URG:  // Temur
                    return $"Temur";
                case ArchetypeColor.BRG:  // Jund
                    return $"Jund";
                case ArchetypeColor.WUBR: // Not-G
                    return $"4ColorNonGreen";
                case ArchetypeColor.WUBG: // Not-R
                    return $"4ColorNonRed";
                case ArchetypeColor.WURG: // Not-B
                    return $"4ColorNonBlack";
                case ArchetypeColor.UBRG: // Not-W
                    return $"4ColorNonWhite";
                case ArchetypeColor.WUBRG:
                    return $"5Color";
                default:
                    return "";
            }
        }
    }
}
