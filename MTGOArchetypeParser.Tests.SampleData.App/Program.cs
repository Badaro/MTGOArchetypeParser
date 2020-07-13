using MTGOArchetypeParser.Data;
using MTGOArchetypeParser.Model;
using MTGODecklistParser.Data;
using MTGODecklistParser.Model;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MTGOArchetypeParser.Tests.SampleData.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool allowUpdate = false;
                if (args.Length > 0 && args[0].ToString() == "allowupdate") allowUpdate = true;

                ArchetypeMeta[] metas = Metas.Modern.Loader.GetMetas();
                Console.WriteLine("Downloading tournament list");
                Tournament[] tournaments = TournamentLoader.GetTournaments(metas.First().StartDate, DateTime.UtcNow).Where(t => t.Name.Contains("Modern")).ToArray();

                foreach (Tournament tournament in tournaments)
                {
                    ArchetypeMeta tournamentMeta = metas.Last(m => m.StartDate <= tournament.Date);
                    string metaName = tournamentMeta.GetType().Name;
                    string metaID = $"meta_{tournamentMeta.StartDate.ToString("yyyy_MM_dd")}_{metaName.ToLower()}";

                    Console.WriteLine($"Downloading {tournament.Uri.ToString()}");

                    // Destination for sample data
                    string leagueID = Path.GetFileName(tournament.Uri.ToString()).Replace("-", "_");
                    string sampleDataOutputFolder = Path.Combine(new DirectoryInfo(@"..\..\..\..\").FullName, "MTGOArchetypeParser.Tests.SampleData", metaID.ToLower(), leagueID);
                    if (Directory.Exists(sampleDataOutputFolder))
                    {
                        if (!allowUpdate)
                        {
                            Console.WriteLine("Tournament already exists and allowupdate was not specified, skipping");
                            continue;
                        }
                        else
                        {
                            Directory.Delete(sampleDataOutputFolder, true);
                        }
                    }
                    Directory.CreateDirectory(sampleDataOutputFolder);

                    // Decklist download
                    var decks = MTGODecklistParser.Data.DeckLoader.GetDecks(tournament.Uri);

                    // Destination for test class
                    string testOutputFolder = Path.Combine(new DirectoryInfo(@"..\..\..\..\").FullName, "MTGOArchetypeParser.Tests", metaID.ToLower());
                    if (!Directory.Exists(testOutputFolder)) Directory.CreateDirectory(testOutputFolder);

                    string testOutputFile = Path.Combine(testOutputFolder, $"EventTest_{leagueID}.cs");
                    if (File.Exists(testOutputFile)) File.Delete(testOutputFile);

                    StringBuilder testData = new StringBuilder();

                    for (int i = 0; i < decks.Length; i++)
                    {
                        var detectionResult = ArchetypeAnalyzer.Detect(decks[i].Mainboard.Select(i => i.CardName).ToArray(), decks[i].Sideboard.Select(i => i.CardName).ToArray(), MTGOArchetypeParser.Archetypes.Modern.Loader.GetArchetypes());

                        string playerID = decks[i].Player == null ? "" : decks[i].Player;
                        string colorID = detectionResult.Color.ToString();
                        string companionID = detectionResult.Companion == null ? "" : detectionResult.Companion.Value.ToString();
                        string archetypeID = String.Empty;
                        string variantID = String.Empty;

                        if (detectionResult.Matches.Length == 1)
                        {
                            var detected = detectionResult.Matches.First();
                            archetypeID = detected.Archetype.GetType().Name;
                            if (detected.Variant != null)
                            {
                                variantID = detected.Variant.GetType().Name;
                            }
                        }

                        string deckID = $"Deck{(i + 1).ToString("D2")}";
                        deckID += playerID.Length > 0 ? $"_{new string(playerID.Where(c => char.IsLetterOrDigit(c)).ToArray())}" : "_Unknown";
                        deckID += archetypeID.Length > 0 ? $"_{archetypeID}" : "_Unknown";
                        deckID += variantID.Length > 0 ? $"_{variantID}" : "";
                        deckID += $"_{colorID}";
                        deckID += companionID.Length > 0 ? $"_{companionID}" : "";

                        string sampleDataFile = Path.Combine(sampleDataOutputFolder, $"{deckID}.cs");

                        string sampleDataContents = _sampleDataTemplate
                            .Replace("META_NAME", metaName)
                            .Replace("META_ID", metaID)
                            .Replace("LEAGUE_ID", leagueID)
                            .Replace("DECK_ID", deckID)
                            .Replace("MAINBOARD_CARDS", String.Join($",{Environment.NewLine}{new string(' ', 12)}", decks[i].Mainboard.Select(c => $"new SampleCard({c.Count}, \"{c.CardName}\")")))
                            .Replace("SIDEBOARD_CARDS", String.Join($",{Environment.NewLine}{new string(' ', 12)}", decks[i].Sideboard.Select(c => $"new SampleCard({c.Count}, \"{c.CardName}\")")));

                        File.WriteAllText(sampleDataFile, sampleDataContents);

                        string testContents = _testTemplate
                            .Replace("META_NAME", metaName)
                            .Replace("META_ID", metaID)
                            .Replace("LEAGUE_ID", leagueID)
                            .Replace("DECK_ID", deckID)
                            .Replace("COLOR_ID", colorID)
                            .Replace("COMPANION_ID", companionID.Length > 0 ? $"ArchetypeCompanion.{companionID}" : "null")
                            .Replace("ARCHETYPE_ID", archetypeID.Length > 0 ? $"typeof(MTGOArchetypeParser.Archetypes.Modern.{archetypeID})" : "null")
                            .Replace("VARIANT_ID", variantID.Length > 0 ? $"typeof(MTGOArchetypeParser.Archetypes.Modern.{variantID})" : "null");

                        testData.Append(testContents);
                        testData.Append(Environment.NewLine);
                        testData.Append(Environment.NewLine);
                    }

                    // Generating test class
                    string testFileContents = _testClassTemplate
                            .Replace("META_NAME", metaName)
                            .Replace("META_ID", metaID)
                            .Replace("LEAGUE_ID", leagueID)
                            .Replace("TEST_DATA", testData.ToString());

                    File.WriteAllText(testOutputFile, testFileContents);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static string _sampleDataTemplate = @"using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.META_ID.LEAGUE_ID
{
    public class DECK_ID : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            MAINBOARD_CARDS 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            SIDEBOARD_CARDS 
        };
    }
}";

        static string _testTemplate = @"        [Test]
        public void DECK_ID()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.META_ID.LEAGUE_ID.DECK_ID(),
                new MTGOArchetypeParser.Metas.Modern.META_NAME(),
                ArchetypeColor.COLOR_ID,
                ARCHETYPE_ID,
                VARIANT_ID,
                COMPANION_ID
            );
        }";

        static string _testClassTemplate = @"using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.META_ID
{
    public class EventTest_LEAGUE_ID : EventTest
    {
TEST_DATA
    }
}
";
    }
}
