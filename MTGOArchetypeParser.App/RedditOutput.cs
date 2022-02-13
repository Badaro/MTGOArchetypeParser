using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.App
{
    public class RedditOutput : IOutput
    {
        public void Write(Record[] records, ExecutionSettings settings)
        {
            if (settings.Action != ExecutionAction.Detect) throw new Exception("Reddit output only supports detect mode");

            if (records.Length == 0)
            {
                Console.WriteLine("No changes detected");
            }
            else
            {
                string lastEvent = String.Empty;
                Console.WriteLine("Detection results: ");
                foreach (var record in records)
                {
                    if (record.TournamentFile != lastEvent)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"**{record.TournamentFile}**");
                        Console.WriteLine();
                        lastEvent = record.TournamentFile;
                    }

                    string companionDisplay = String.IsNullOrEmpty(record.Archetype.Companion) ? "" : $" ({record.Archetype.Companion})";
                    Console.WriteLine($"* [{record.Archetype.Archetype}{companionDisplay}]({record.AnchorUri.ToString()}): **{record.Player.Replace("_","\\_")}**");
                }
            }
        }
    }
}
