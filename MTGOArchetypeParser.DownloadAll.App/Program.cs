using MTGOArchetypeParser.Data;
using MTGODecklistParser.Data;
using MTGODecklistParser.Model;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.DownloadAll.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Downloading tournament list");
                Tournament[] tournaments = TournamentLoader.GetTournaments(new DateTime(2020, 06, 05, 00, 00, 00, DateTimeKind.Utc), DateTime.UtcNow).Where(t => t.Name.Contains("Modern")).ToArray();

                // Destination CSV output
                StringBuilder csvData = new StringBuilder();
                csvData.AppendLine($"EVENT,META,DATE,PLAYER,URL,ARCHETYPE,VARIANT,COLOR,COMPANION");

                foreach (var tournament in tournaments)
                {
                    Console.WriteLine($"Downloading {tournament.Uri}");

                    string metaID = Metas.Modern.Loader.GetMetas().Last(m => m.StartDate <= tournament.Date).GetType().Name;

                    var decks = MTGODecklistParser.Data.DeckLoader.GetDecks(tournament.Uri);

                    for (int i = 0; i < decks.Length; i++)
                    {
                        var detectionResult = ArchetypeAnalyzer.Detect(decks[i].Mainboard.Select(i => i.CardName).ToArray(), decks[i].Sideboard.Select(i => i.CardName).ToArray(), MTGOArchetypeParser.Archetypes.Modern.Loader.GetArchetypes());

                        string colorID = detectionResult.Color.ToString();
                        string companionID = detectionResult.Companion == null ? "" : detectionResult.Companion.Value.ToString();
                        string archetypeID = "Unknown";
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

                        string consolidatedID = String.IsNullOrEmpty(variantID) ? archetypeID : variantID;

                        csvData.AppendLine($"{tournament.Name},{metaID},{tournament.Date.ToString("yyyy-MM-dd")},{decks[i].Player},{decks[i].AnchorUri},{archetypeID},{consolidatedID},{colorID},{companionID}");
                    }

                    File.WriteAllText($"mtgo_data_{tournaments.Max(t => t.Date).ToString("yyyy_MM_dd")}.csv", csvData.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

