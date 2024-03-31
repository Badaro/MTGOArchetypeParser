using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.App
{
    public class ConsoleOutput : IOutput
    {
        public void WriteRecords(Record[] records, ExecutionSettings settings)
        {
            if (records.Length == 0)
            {
                if (settings.Action == ExecutionAction.Compare)
                {
                    Console.WriteLine("No changes detected");
                }
                else
                {
                    Console.WriteLine("No results to display");
                }
            }
            else
            {
                if (settings.Action == ExecutionAction.Compare)
                {
                    Console.WriteLine("Comparison results: ");
                    foreach (var record in records)
                    {
                        Console.WriteLine($"* {record.TournamentFile} -> {record.Player} changed from {record.ReferenceArchetype.Archetype} to {record.Archetype.Archetype}");
                    }
                }
                else
                {
                    Console.WriteLine("Detection results: ");
                    foreach (var record in records)
                    {
                        if(settings.ShowColors)
                        {
                            Console.WriteLine($"* {record.TournamentFile} -> {record.Result} {record.Player} ({record.Archetype.Archetype}) ({record.Archetype.Color})");
                        }
                        else
                        {
                            Console.WriteLine($"* {record.TournamentFile} -> {record.Result} {record.Player} ({record.Archetype.Archetype})");
                        }
                    }
                }
            }
        }
        public void WriteCards(Dictionary<string, int> cards, ExecutionSettings settings)
        {
            foreach (var card in cards.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"* {card.Key} ({card.Value} {((card.Value == 1) ? "copy" : "copies")})");
            }
        }

        public void WriteBreakdown(Dictionary<string, int> consolidatedTotals, ExecutionSettings settings)
        {
            Console.WriteLine("----- Meta Breakdown: -----");

            foreach (var total in consolidatedTotals.Where(t => t.Key != settings.OthersKey).OrderByDescending(t => t.Value))
            {
                if (settings.MetaBreakdownShowCount)
                {
                    Console.WriteLine($"* {total.Key} ({total.Value})");
                }
                else
                {
                    Console.WriteLine($"* {total.Key} ({Math.Round((100.0 * total.Value) / consolidatedTotals.Sum(c => c.Value), 1).ToString("F1", CultureInfo.InvariantCulture)}%)");
                }
            }
            if (consolidatedTotals[settings.OthersKey] > 0)
            {
                if (settings.MetaBreakdownShowCount)
                {
                    Console.WriteLine($"* {settings.OthersKey} ({consolidatedTotals[settings.OthersKey]})");
                }
                else
                {
                    Console.WriteLine($"* {settings.OthersKey} ({Math.Round((100.0 * consolidatedTotals[settings.OthersKey]) / consolidatedTotals.Sum(c => c.Value), 1).ToString("F1", CultureInfo.InvariantCulture)}%)");
                }
            }
            Console.WriteLine($"Total Decks: {consolidatedTotals.Sum(c => c.Value)}");
        }

        public void WriteWinrates(Dictionary<string, RecordMatchup> results, ExecutionSettings settings)
        {
            Console.WriteLine($"----- Winrate Breakdown: -----");

            foreach (var result in results.OrderByDescending(r => r.Value.Wins + r.Value.Losses + r.Value.Draws))
            {
                double winrate = ((double)100) * ((double)result.Value.Wins) / ((double)(result.Value.Wins + result.Value.Losses));
                Console.WriteLine($"* {result.Key}: {result.Value.Wins}-{result.Value.Losses}-{result.Value.Draws} ({winrate.ToString("F1", CultureInfo.InvariantCulture)}% WR)");
            }
        }

        public void WriteMatchups(Dictionary<string, RecordMatchup> results, ExecutionSettings settings)
        {
            Console.WriteLine($"----- Matchup Breakdown for {settings.MatchupsFor} ({results.Sum(r => r.Value.Wins + r.Value.Losses + r.Value.Draws)} matches): -----");

            foreach (var result in results.OrderByDescending(r => r.Value.Wins + r.Value.Losses + r.Value.Draws))
            {
                double winrate = ((double)100) * ((double)result.Value.Wins) / ((double)(result.Value.Wins + result.Value.Losses));
                Console.WriteLine($"* vs {result.Key}: {result.Value.Wins}-{result.Value.Losses}-{result.Value.Draws} ({winrate.ToString("F1", CultureInfo.InvariantCulture)}% WR))");
            }
        }
    }
}
