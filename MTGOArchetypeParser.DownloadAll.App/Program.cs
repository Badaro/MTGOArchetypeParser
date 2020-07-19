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

                bool allMetas = args.Any(a => a.ToLower() == "allmetas");
                bool includeLeagues = args.Any(a => a.ToLower() == "includeleagues");

                DateTime startDate = allMetas ?
                    MTGOArchetypeParser.Metas.Modern.Loader.GetMetas().First().StartDate :
                    MTGOArchetypeParser.Metas.Modern.Loader.GetMetas().Last().StartDate;

                Func<Tournament, bool> excludeLeaguesFilter = t => t.Name.Contains("Modern") && !t.Name.Contains("League");
                Func<Tournament, bool> includeLeaguesFilter = t => t.Name.Contains("Modern");
                Func<Tournament, bool> filter = includeLeagues ? includeLeaguesFilter : excludeLeaguesFilter;

                Tournament[] tournaments = TournamentLoader.GetTournaments(startDate, DateTime.UtcNow).Where(t => filter(t)).ToArray();

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

