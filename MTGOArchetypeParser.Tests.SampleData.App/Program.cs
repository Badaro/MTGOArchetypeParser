using MTGOArchetypeParser.Data;
using MTGOArchetypeParser.DataSources;
using MTGOArchetypeParser.DataSources.Model;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Tests.SampleData.App.Model;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.SampleData.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if(args.Length==0)
                {
                    Console.WriteLine("Usage MTGOArchetypeParser.Tests.SampleData.App.exe CACHE_FOLDER");
                    return;
                }
                string cacheFolder = args[0];

                bool allowUpdate = false;
                if (args.Length > 1 && args[1].ToString() == "allowupdate") allowUpdate = true;

                string solutionFolder = new DirectoryInfo(@"..\..\..\..\").FullName;
                string deckFolder = Path.Combine(solutionFolder, "MTGOArchetypeParser.Tests.SampleData");
                string testFolder = Path.Combine(solutionFolder, "MTGOArchetypeParser.Tests");
                ArchetypeMeta[] metas = Metas.Modern.Loader.GetMetas();

                CacheItem[] tournaments = DataLoader.GetTournaments(cacheFolder, metas.First().StartDate.AddDays(1), n => n.Contains("Modern"));

                foreach (CacheItem tournament in tournaments)
                {
                    Console.WriteLine($"Generating Sample Data for {tournament.Tournament.Uri}");

                    ArchetypeMeta tournamentMeta = metas.Last(m => m.StartDate <= tournament.Decks.First().Date);
                    TournamentKeys tournamentKeys = KeyGenerator.GenerateTournamentKeys(tournamentMeta, tournament);

                    // Destination for sample data
                    string tournamentDecksFolder = Path.Combine(deckFolder, tournamentKeys.MetaID, tournamentKeys.LeagueID);
                    string tournamentTestFile = Path.Combine(testFolder, tournamentKeys.MetaID, $"EventTest_{tournamentKeys.LeagueID}.cs");

                    if (Directory.Exists(tournamentDecksFolder) || File.Exists(tournamentTestFile))
                    {
                        if (!allowUpdate)
                        {
                            Console.WriteLine("Tournament already exists and allowupdate was not specified, skipping");
                            continue;
                        }
                        else
                        {
                            if (Directory.Exists(tournamentDecksFolder)) Directory.Delete(tournamentDecksFolder, true);
                            if (File.Exists(tournamentTestFile)) File.Delete(tournamentTestFile);
                        }
                    }

                    StringBuilder tournamentTestData = new StringBuilder();

                    for (int i = 0; i < tournament.Decks.Length; i++)
                    {
                        var detectionResult = ArchetypeAnalyzer.Detect(tournament.Decks[i].Mainboard.Select(i => i.CardName).ToArray(), tournament.Decks[i].Sideboard.Select(i => i.CardName).ToArray(), Archetypes.Modern.Loader.GetArchetypes());
                        DeckKeys deckKeys = KeyGenerator.GenerateDeckKeys(i + 1, tournament.Decks[i], detectionResult);

                        string tournamentDeckFile = Path.Combine(tournamentDecksFolder, $"{deckKeys.DeckID}.cs");
                        string tournamentDeckFileContents = CodeGenerator.GenerateDeck(tournamentKeys, deckKeys, tournament.Decks[i]);
                        FileWriter.Write(tournamentDeckFile, tournamentDeckFileContents);

                        string tournamentDeckTestContents = CodeGenerator.GenerateTest(tournamentKeys, deckKeys);
                        tournamentTestData.Append(tournamentDeckTestContents);
                    }

                    // Generating test class
                    string testFileContents = CodeGenerator.GenerateClasss(tournamentKeys, tournamentTestData.ToString());
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
