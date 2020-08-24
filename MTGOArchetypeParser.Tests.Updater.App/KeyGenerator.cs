using MTGOArchetypeParser.Data.Model;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Tests.Updater.Model;
using System;
using System.IO;
using System.Linq;

namespace MTGOArchetypeParser.Tests.Updater
{
    public static class KeyGenerator
    {
        public static TournamentKeys GenerateTournamentKeys(ArchetypeMeta meta, Tournament tournament)
        {
            string metaName = meta.GetType().Name;
            string metaID = $"meta_{meta.StartDate.ToString("yyyy_MM_dd")}_{metaName.ToLower()}";

            // Destination for sample data
            string leagueID = Path.GetFileName(tournament.Information.Uri.ToString()).Replace("-", "_");

            return new TournamentKeys()
            {
                File = tournament.File,
                MetaName = metaName,
                MetaID = metaID,
                EventID = leagueID
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

            string deckID = $"Deck{(deckIndex + 1).ToString("D2")}";
            deckID += playerID.Length > 0 ? $"_{new string(playerID.Where(c => char.IsLetterOrDigit(c)).ToArray())}" : "_Unknown";
            deckID += archetypeID.Length > 0 ? $"_{archetypeID}" : "_Unknown";
            deckID += variantID.Length > 0 ? $"_{variantID}" : "";
            deckID += $"_{colorID}";
            deckID += companionID.Length > 0 ? $"_{companionID}" : "";

            return new DeckKeys()
            {
                DeckIndex = deckIndex,
                DeckID = deckID,
                ColorID = colorID,
                ArchetypeID = archetypeID,
                VariantID = variantID,
                CompanionID = companionID
            };
        }
    }
}
