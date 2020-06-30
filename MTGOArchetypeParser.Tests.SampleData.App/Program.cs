using MTGOArchetypeParser.Data;
using MTGODecklistParser.Data;
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

                Console.WriteLine("Downloading tournament list");
                string[] eventUrls = TournamentLoader.GetTournaments(new DateTime(2020, 06, 05, 00, 00, 00, DateTimeKind.Utc), DateTime.UtcNow).Where(t => t.Name.Contains("Modern")).Select(e => e.Uri.ToString()).ToArray();

                foreach (string eventUrl in eventUrls)
                {
                    Console.WriteLine($"Downloading {eventUrl}");

                    // Destination for sample data
                    string leagueID = Path.GetFileName(eventUrl).Replace("-", "_");
                    string sampleDataOutputFolder = Path.Combine(new DirectoryInfo(@"..\..\..\..\").FullName, "MTGOArchetypeParser.Tests.SampleData", leagueID);
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
                    var decks = MTGODecklistParser.Data.DeckLoader.GetDecks(new Uri(eventUrl));

                    // Destination for test class
                    string testOutputFile = Path.Combine(new DirectoryInfo(@"..\..\..\..\").FullName, "MTGOArchetypeParser.Tests", $"EventTest_{leagueID}.cs");
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
                            .Replace("LEAGUE_ID", leagueID)
                            .Replace("DECK_ID", deckID)
                            .Replace("MAINBOARD_CARDS", String.Join(",", decks[i].Mainboard.Select(c => $"({c.Count}, \"{c.CardName}\")")))
                            .Replace("SIDEBOARD_CARDS", String.Join(",", decks[i].Sideboard.Select(c => $"({c.Count}, \"{c.CardName}\")")));

                        File.WriteAllText(sampleDataFile, sampleDataContents);

                        string testContents = _testTemplate
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

namespace MTGOArchetypeParser.Tests.SampleData.LEAGUE_ID
{
    public class DECK_ID : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { MAINBOARD_CARDS }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { SIDEBOARD_CARDS }; } }
    }
}";

        static string _testTemplate = @"        [Test]
        public void DECK_ID()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.LEAGUE_ID.DECK_ID(),
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

namespace MTGOArchetypeParser.Tests
{
    public class EventTest_LEAGUE_ID : EventTest
    {
TEST_DATA
    }
}
";
    }
}
