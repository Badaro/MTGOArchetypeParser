using MTGOArchetypeParser.DataSources.Model;
using MTGOArchetypeParser.Tests.SampleData.App.Model;
using System;
using System.Linq;

namespace MTGOArchetypeParser.Tests.SampleData.App
{
    public static class CodeGenerator
    {

        public static string GenerateDeck(TournamentKeys tournamentKeys, DeckKeys deckKeys, Deck deck)
        {
            return _deckTemplate
                    .Replace("META_ID", tournamentKeys.MetaID)
                    .Replace("LEAGUE_ID", tournamentKeys.LeagueID)
                    .Replace("DECK_ID", deckKeys.DeckID)
                    .Replace("MAINBOARD_CARDS", String.Join($",{Environment.NewLine}{new string(' ', 12)}", deck.Mainboard.Select(c => $"new SampleCard({c.Count}, \"{c.CardName}\")")))
                    .Replace("SIDEBOARD_CARDS", String.Join($",{Environment.NewLine}{new string(' ', 12)}", deck.Sideboard.Select(c => $"new SampleCard({c.Count}, \"{c.CardName}\")")));
        }

        public static string GenerateTest(TournamentKeys tournamentKeys, DeckKeys deckKeys)
        {
            var testContents = _testTemplate
                    .Replace("META_NAME", tournamentKeys.MetaName)
                    .Replace("META_ID", tournamentKeys.MetaID)
                    .Replace("LEAGUE_ID", tournamentKeys.LeagueID)
                    .Replace("DECK_ID", deckKeys.DeckID)
                    .Replace("COLOR_ID", deckKeys.ColorID)
                    .Replace("COMPANION_ID", deckKeys.CompanionID.Length > 0 ? $"ArchetypeCompanion.{deckKeys.CompanionID}" : "null")
                    .Replace("ARCHETYPE_ID", deckKeys.ArchetypeID.Length > 0 ? $"typeof({deckKeys.ArchetypeID})" : "null")
                    .Replace("VARIANT_ID", deckKeys.VariantID.Length > 0 ? $"typeof({deckKeys.VariantID})" : "null");

            return testContents + Environment.NewLine + Environment.NewLine;
        }

        public static string GenerateClasss(TournamentKeys tournamentKeys, string testData)
        {
            return _classTemplate
                    .Replace("META_ID", tournamentKeys.MetaID)
                    .Replace("LEAGUE_ID", tournamentKeys.LeagueID)
                    .Replace("TEST_DATA", testData.ToString());
        }

        #region Deck Snippet

        static string _deckTemplate = @"using MTGOArchetypeParser.Tests.SampleData;

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

        #endregion

        #region Test Snippet

        static string _testTemplate = @"        [Test]
        public void DECK_ID()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.META_ID.LEAGUE_ID.DECK_ID(),
                new META_NAME(),
                ArchetypeColor.COLOR_ID,
                ARCHETYPE_ID,
                VARIANT_ID,
                COMPANION_ID
            );
        }";

        #endregion

        #region Class Snippet

        static string _classTemplate = @"using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
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
    #endregion
}
