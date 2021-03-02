using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.App
{
    public class ConsoleOutput : IOutput
    {
        public void Write(Record[] records, ExecutionAction action, string outputFile)
        {
            if (records.Length == 0)
            {
                if (action == ExecutionAction.Compare)
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
                if (action == ExecutionAction.Compare)
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
                        Console.WriteLine($"* {record.TournamentFile} -> {record.Player} -> {record.Archetype.Archetype}");
                    }
                }
            }
        }
    }
}
