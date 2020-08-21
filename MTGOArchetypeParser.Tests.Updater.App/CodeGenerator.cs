﻿using MTGOArchetypeParser.Data;
using MTGOArchetypeParser.Data.Model;
using MTGOArchetypeParser.Tests.Updater.Model;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.Updater
{
    public static class CodeGenerator
    {
        public static string GenerateSummary(MTGOTournament tournament)
        {
            StringBuilder summary = new StringBuilder();

            for (int i = 0; i < tournament.Decks.Length; i++)
            {
                var result = ArchetypeAnalyzer.Detect(tournament.Decks[i].Mainboard.Select(i => i.CardName).ToArray(), tournament.Decks[i].Sideboard.Select(i => i.CardName).ToArray(), MTGOArchetypeParser.Archetypes.Modern.Loader.GetArchetypes());

                int position = i + 1;
                string player = tournament.Decks[i].Player;
                string name;
                string colors = result.Color.ToString();
                string companion = result.Companion.HasValue ? result.Companion.ToString() : "None";
                if (result.Matches.Length == 0)
                {
                    name = "Unknown";
                }
                else
                {
                    if (result.Matches.Length == 1)
                    {
                        name = result.Matches[0].Archetype.GetType().Name;

                        if (result.Matches[0].Variant != null) name = $"{result.Matches[0].Variant.GetType().Name}";
                    }
                    else
                    {
                        name = String.Join(",", result.Matches.Select(m => m.Archetype.GetType().Name));
                    }
                }

                if (companion != "None")
                {
                    summary.AppendLine($"#{position.ToString("D2")} {player}: {name} ({colors}, {companion})");
                }
                else
                {
                    summary.AppendLine($"#{position.ToString("D2")} {player}: {name} ({colors})");
                }
            }

            return _summarySnippet.Replace("{SUMMARY}",summary.ToString());
        }

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

        public static string GenerateClasss(TournamentKeys tournamentKeys, string testData, string summary)
        {
            return _classTemplate
                    .Replace("SUMMARY", summary)
                    .Replace("META_ID", tournamentKeys.MetaID)
                    .Replace("EVENT_ID", tournamentKeys.EventID)
                    .Replace("TEST_DATA", testData.ToString());
        }

        #region Summary Snippet

        static string _summarySnippet = @"/*
{SUMMARY}*/";

        #endregion

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

SUMMARY

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