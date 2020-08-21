using MTGOArchetypeParser.Data;
using MTGOArchetypeParser.Data.Model;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Tests.Updater.Model;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.Updater
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 2)
                {
                    Console.WriteLine("Usage MTGOArchetypeParser.Tests.Updater CACHE_FOLDER TEST_FOLDER");
                    return;
                }
                string cacheFolder = args[0];
                string testFolder = args[1];

                bool allowUpdate = false;
                if (args.Any(a => a == "allowupdate")) allowUpdate = true;

                ArchetypeMeta[] metas = Metas.Modern.Loader.GetMetas();

                MTGOTournament[] tournaments = TournamentLoader.GetTournamentsByDate(cacheFolder, metas.First().StartDate.AddDays(1), n => n.Contains("Modern"));

                foreach (MTGOTournament tournament in tournaments)
                {
                    Console.WriteLine($"Generating Sample Data for {tournament.Tournament.Uri}");

                    ArchetypeMeta tournamentMeta = metas.Last(m => m.StartDate <= tournament.Decks.First().Date);
                    TournamentKeys tournamentKeys = KeyGenerator.GenerateTournamentKeys(tournamentMeta, tournament);

                    // Destination for sample data
                    string tournamentTestFile = Path.Combine(testFolder, tournamentKeys.MetaID, $"EventTest_{tournamentKeys.EventID}.cs");

                    if (File.Exists(tournamentTestFile))
                    {
                        if (!allowUpdate)
                        {
                            Console.WriteLine("Tournament already exists and allowupdate was not specified, skipping");
                            continue;
                        }
                        else
                        {
                            if (File.Exists(tournamentTestFile)) File.Delete(tournamentTestFile);
                        }
                    }

                    StringBuilder tournamentTestData = new StringBuilder();

                    for (int i = 0; i < tournament.Decks.Length; i++)
                    {
                        var detectionResult = ArchetypeAnalyzer.Detect(tournament.Decks[i].Mainboard.Select(i => i.CardName).ToArray(), tournament.Decks[i].Sideboard.Select(i => i.CardName).ToArray(), Archetypes.Modern.Loader.GetArchetypes());
                        DeckKeys deckKeys = KeyGenerator.GenerateDeckKeys(i, tournament.Decks[i], detectionResult);

                        string tournamentDeckTestContents = CodeGenerator.GenerateTest(tournamentKeys, deckKeys);
                        tournamentTestData.Append(tournamentDeckTestContents);
                    }

                    // Generating test class
                    string testFileContents = CodeGenerator.GenerateClasss(tournamentKeys, tournamentTestData.ToString(), CodeGenerator.GenerateSummary(tournament));
                    FileWriter.Write(tournamentTestFile, testFileContents);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
