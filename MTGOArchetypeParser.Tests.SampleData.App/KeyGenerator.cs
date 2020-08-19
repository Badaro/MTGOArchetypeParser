using MTGOArchetypeParser.DataSources.Model;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Tests.SampleData.App.Model;
using System;
using System.IO;
using System.Linq;

namespace MTGOArchetypeParser.Tests.SampleData.App
{
    public static class KeyGenerator
    {
        public static TournamentKeys GenerateTournamentKeys(ArchetypeMeta meta, CacheItem tournament)
        {
            string metaName = meta.GetType().Name;
            string metaID = $"meta_{meta.StartDate.ToString("yyyy_MM_dd")}_{metaName.ToLower()}";

            // Destination for sample data
            string leagueID = Path.GetFileName(tournament.Tournament.Uri.ToString()).Replace("-", "_");

            return new TournamentKeys()
            {
                MetaName = metaName,
                MetaID = metaID,
                LeagueID = leagueID
            };
        }

        public static DeckKeys GenerateDeckKeys(int deckIndex, Deck deck, ArchetypeResult detectionResult)
        {
            string playerID = deck.Player == null ? "" : deck.Player;
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

            string deckID = $"Deck{(deckIndex).ToString("D2")}";
            deckID += playerID.Length > 0 ? $"_{new string(playerID.Where(c => char.IsLetterOrDigit(c)).ToArray())}" : "_Unknown";
            deckID += archetypeID.Length > 0 ? $"_{archetypeID}" : "_Unknown";
            deckID += variantID.Length > 0 ? $"_{variantID}" : "";
            deckID += $"_{colorID}";
            deckID += companionID.Length > 0 ? $"_{companionID}" : "";

            return new DeckKeys()
            {
                DeckID = deckID,
                ColorID = colorID,
                ArchetypeID = archetypeID,
                VariantID = variantID,
                CompanionID = companionID
            };
        }
    }
}
