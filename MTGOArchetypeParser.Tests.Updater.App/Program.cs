using MTGOArchetypeParser.Data;
using MTGOArchetypeParser.Data.Model;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Tests.Updater.Model;
using System;
using System.Collections.Generic;
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
                if (args.Length < 3)
                {
                    Console.WriteLine("Usage MTGOArchetypeParser.Tests.Updater TEST_FOLDER FORMAT_DATA_FOLDER CACHE_FOLDER_1 [CACHE_FOLDER_2] [CACHE_FOLDER_3]");
                    return;
                }
                string testFolder = args[0];
                string formatDataFolder = args[1];
                string[] cacheFolders = args.Skip(2).ToArray();

                ArchetypeFormat modernFormat = Formats.FromJson.Loader.GetFormat(formatDataFolder, "Modern");

                ArchetypeMeta[] metas = modernFormat.Metas;

                Tournament[] tournaments = cacheFolders.SelectMany(c => TournamentLoader.GetTournamentsByDate(c, metas.First().StartDate.AddDays(1), n => n.Contains("Modern") && !n.Contains("League"))).ToArray();

                foreach (Tournament tournament in tournaments)
                {
                    Console.WriteLine($"Generating Sample Data for {tournament.Information.Uri}");

                    ArchetypeMeta tournamentMeta = metas.Last(m => m.StartDate <= tournament.Decks.First().Date);
                    TournamentKeys tournamentKeys = KeyGenerator.GenerateTournamentKeys(tournamentMeta, tournament);

                    // Destination for sample data
                    string tournamentTestFile = Path.Combine(testFolder, tournamentKeys.MetaID, $"EventTest_{tournamentKeys.EventID}.cs");

                    if (File.Exists(tournamentTestFile))
                    {
                        Console.WriteLine("Tournament already exists, skipping");
                        continue;
                    }

                    StringBuilder tournamentTestData = new StringBuilder();

                    for (int i = 0; i < tournament.Decks.Length; i++)
                    {
                        var detectionResult = ArchetypeAnalyzer.Detect(tournament.Decks[i].Mainboard.Select(i => new Card() { Name = i.Card, Count = i.Count }).ToArray(), tournament.Decks[i].Sideboard.Select(i => new Card() { Name = i.Card, Count = i.Count }).ToArray(), modernFormat);
                        DeckKeys deckKeys = KeyGenerator.GenerateDeckKeys(i, tournament.Decks[i], detectionResult);

                        string tournamentDeckTestContents = CodeGenerator.GenerateTest(tournamentKeys, deckKeys);
                        tournamentTestData.Append(tournamentDeckTestContents);
                    }

                    // Generating test class
                    string testFileContents = CodeGenerator.GenerateClasss(tournamentKeys, tournamentTestData.ToString(), CodeGenerator.GenerateSummary(tournament, modernFormat));
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
