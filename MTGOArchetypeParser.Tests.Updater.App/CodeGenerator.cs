using MTGOArchetypeParser.DataSources.Model;
using MTGOArchetypeParser.Tests.Updater.Model;
using System;
using System.IO;
using System.Linq;

namespace MTGOArchetypeParser.Tests.Updater
{
    public static class CodeGenerator
    {
        public static string GenerateTest(TournamentKeys tournamentKeys, DeckKeys deckKeys)
        {
            var testContents = _testTemplate
                    .Replace("FILE_WITHOUT_EXTENSION", $"\"{Path.GetFileNameWithoutExtension(tournamentKeys.File)}\"")
                    .Replace("META_NAME", tournamentKeys.MetaName)
                    .Replace("META_ID", tournamentKeys.MetaID)
                    .Replace("EVENT_ID", tournamentKeys.EventID)
                    .Replace("DECK_ID", deckKeys.DeckID)
                    .Replace("DECK_INDEX", deckKeys.DeckIndex.ToString())
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
                    .Replace("EVENT_ID", tournamentKeys.EventID)
                    .Replace("TEST_DATA", testData.ToString());
        }

        #region Test Snippet

        static string _testTemplate = @"        [Test]
        public void DECK_ID()
        {
            Test(
                GetDeck(FILE_WITHOUT_EXTENSION,DECK_INDEX),
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
    public class EventTest_EVENT_ID : EventTest
    {
TEST_DATA
    }
}
";
    }
    #endregion
}
