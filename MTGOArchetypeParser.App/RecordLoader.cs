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
        public static Record[] GetRecords(Tournament[] tournaments, ArchetypeFormat format, ArchetypeFormat referenceFormat, bool includeDecklists, bool includeMatchups, int maxDecksPerEvent, ConflictSolvingMode conflictMode)
        {
            List<Record> records = new List<Record>();

            foreach (var tournament in tournaments)
            {
                ArchetypeMeta meta = format.Metas.LastOrDefault(m => m.StartDate <= tournament.Decks.First().Date);
                if (meta == null) continue; // Tournament outside of the meta range, may happen due to them being posted late

                DateTime metaWeekReferenceDate = GetMetaWeekReferenceDate(meta.StartDate);

                string metaID = meta.Name;

                int weekID = ((int)Math.Floor((tournament.Decks.First().Date.Value - metaWeekReferenceDate).Days / 7.0)) + 1;

                List<Record> tournamentRecords = new List<Record>();
                for (int i = 0; i < tournament.Decks.Length; i++)
                {
                    RecordArchetype archetype = GetArchetype(tournament.Decks[i], format, conflictMode);

                    RecordArchetype referenceArchetype = null;
                    if (referenceFormat != null) referenceArchetype = GetArchetype(tournament.Decks[i], referenceFormat, conflictMode);

                    string points = "-";
                    if (tournament.Standings != null)
                    {
                        var standing = tournament.Standings.FirstOrDefault(s => s.Player == tournament.Decks[i].Player);
                        if (standing != null) points = standing.Points.ToString();
                    }

                    tournamentRecords.Add(new Record()
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
                        ReferenceArchetype = referenceArchetype,
                        Mainboard = includeDecklists ? tournament.Decks[i].Mainboard : null,
                        Sideboard = includeDecklists ? tournament.Decks[i].Sideboard : null,
                        Matchups = null
                    });
                }

                if (includeMatchups && tournament.Rounds != null)
                {
                    foreach (var round in tournament.Rounds)
                    {
                        foreach (var match in round.Matches)
                        {
                            Record player1 = tournamentRecords.FirstOrDefault(r => r.Player == match.Player1);
                            Record player2 = tournamentRecords.FirstOrDefault(r => r.Player == match.Player2);
                            string[] result = match.Result.Split("-");

                            if (player1 != null && player2 != null && result.Length == 3)
                            {
                                // Valid result
                                int player1Wins = int.Parse(result[0]);
                                int player2Wins = int.Parse(result[1]);
                                int draws = int.Parse(result[2]);

                                if (player1.Matchups == null) player1.Matchups = new RecordMatchup[0];
                                if (player2.Matchups == null) player2.Matchups = new RecordMatchup[0];

                                // TODO: This is kinda ugly and should be done with a list instead of converting between list and array
                                var player1Matchups = player1.Matchups.ToList();
                                var player2Matchups = player2.Matchups.ToList();

                                player1Matchups.Add(new RecordMatchup()
                                {
                                    Opponent = player2.Player,
                                    OpponentArchetype = player2.Archetype.Archetype,
                                    Wins = player1Wins,
                                    Losses = player2Wins,
                                    Draws = draws
                                });

                                player2Matchups.Add(new RecordMatchup()
                                {
                                    Opponent = player1.Player,
                                    OpponentArchetype = player1.Archetype.Archetype,
                                    Wins = player2Wins,
                                    Losses = player1Wins,
                                    Draws = draws
                                });

                                player1.Matchups = player1Matchups.ToArray();
                                player2.Matchups = player2Matchups.ToArray();
                            }
                        }
                    }
                }


                if (maxDecksPerEvent > 0) tournamentRecords = tournamentRecords.Take(maxDecksPerEvent).ToList();
                records.AddRange(tournamentRecords);
            }

            return records.OrderBy(r => r.Date).ToArray();
        }

        private static RecordArchetype GetArchetype(Deck deck, ArchetypeFormat format, ConflictSolvingMode conflictMode)
        {
            var detectionResult = ArchetypeAnalyzer.Detect(deck.Mainboard.Select(i => new Card() { Name = i.Card, Count = i.Count }).ToArray(), deck.Sideboard.Select(i => new Card() { Name = i.Card, Count = i.Count }).ToArray(), format, 0.1, conflictMode);

            string colorID = detectionResult.Color.ToString();
            string companionID = detectionResult.Companion == null ? "" : detectionResult.Companion.Value.ToString();
            string archetypeID = "Unknown";

            if (detectionResult.Matches.Length == 1) archetypeID = GetArchetype(detectionResult.Matches.First(), detectionResult.Color);
            if (detectionResult.Matches.Length > 1) archetypeID = $"Conflict({String.Join(",", detectionResult.Matches.Select(m => GetArchetype(m, detectionResult.Color)))})";

            return new RecordArchetype()
            {
                Archetype = archetypeID,
                Companion = companionID,
                Color = colorID,
            };
        }

        private static string GetArchetype(ArchetypeMatch match, ArchetypeColor color)
        {
            string result = match.Archetype.GetName(color);
            if (match.Variant != null)
            {
                result = match.Variant.GetName(color);
            }
            return result;
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
