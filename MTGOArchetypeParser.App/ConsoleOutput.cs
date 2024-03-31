using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public void WriteBreakdown(Dictionary<string, int> archetypes, ExecutionSettings settings)
        {
            throw new NotImplementedException();
        }

        public void WriteWinrates(Dictionary<string, RecordMatchup> archetypes, ExecutionSettings settings)
        {
            throw new NotImplementedException();
        }

        public void WriteMatchups(Dictionary<string, RecordMatchup> archetypes, ExecutionSettings settings)
        {
            throw new NotImplementedException();
        }
    }
}
