using MTGOArchetypeParser.Data;
using System;
using System.Linq;

namespace MTGOArchetypeParser.App
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: MTGOArchetypeParser.App.exe EVENT_URL");
            }
            else
            {
                try
                {
                    var decks = MTGODecklistParser.Data.DeckLoader.GetDecks(new Uri(args[0]));

                    for (int i = 0; i < decks.Length; i++)
                    {
                        var result = ArchetypeAnalyzer.Detect(decks[i].Mainboard.Select(i => i.CardName).ToArray(), decks[i].Sideboard.Select(i => i.CardName).ToArray(), MTGOArchetypeParser.Archetypes.Modern.Loader.GetArchetypes());

                        int position = i + 1;
                        string player = decks[i].Player;
                        string name;
                        string colors = result.Color.ToString();
                        string companion = result.Companion.HasValue ? result.Companion.ToString() : "None";
                        if (result.Matches.Length == 0)
                        {
                            name = "Unknown";
                        }
                        else
                        {
                            if (result.Matches.Length == 1)
                            {
                                name = result.Matches[0].Archetype.GetType().Name;

                                if (result.Matches[0].Variant != null) name = $"{result.Matches[0].Variant.GetType().Name}";
                            }
                            else
                            {
                                name = String.Join(",", result.Matches.Select(m => m.Archetype.GetType().Name));
                            }
                        }

                        if (companion != "None")
                        {
                            Console.WriteLine($"#{position.ToString("D2")} {player}: {name} ({colors}, {companion})");
                        }
                        else
                        {
                            Console.WriteLine($"#{position.ToString("D2")} {player}: {name} ({colors})");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
