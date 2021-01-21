using FluentAssertions;
using MTGOArchetypeParser.Data;
using MTGOArchetypeParser.Data.Model;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class EventTest
    {
        string[] cacheFolders = new string[]
        {
            new DirectoryInfo(@"..\..\..\..\MTGODecklistCache\Tournaments").FullName,
            new DirectoryInfo(@"..\..\..\..\ManaTradersDecklistCache\Tournaments").FullName,
        };
        static Dictionary<string, Tournament> tournamentCache = new Dictionary<string, Tournament>();
        static ArchetypeFormat _modern = MTGOArchetypeParser.Formats.Modern.Loader.GetFormat();

        protected Deck GetDeck(string tournamentName, int deckIndex)
        {
            if (!tournamentCache.ContainsKey(tournamentName))
            {
                foreach (string cacheFolder in cacheFolders)
                {
                    try
                    {
                        tournamentCache.Add(tournamentName, TournamentLoader.GetTournamentByName(cacheFolder, tournamentName));
                    }
                    catch
                    {
                    }
                }
            }
            if (!tournamentCache.ContainsKey(tournamentName)) throw new Exception($"Could not locate tournament {tournamentName}");
            return tournamentCache[tournamentName].Decks[deckIndex];
        }

        protected void Test(Deck deck, string meta, ArchetypeColor expectedColor, string expectedArchetype, string expectedVariant = null, ArchetypeCompanion? expectedCompanion = null)
        {
            var result = ArchetypeAnalyzer.Detect(deck.Mainboard.Select(i => new Card() { Name = i.Card, Count = i.Count }).ToArray(), deck.Sideboard.Select(i => new Card() { Name = i.Card, Count = i.Count }).ToArray(), _modern);

            result.Matches.Should().HaveCount(1);

            result.Color.Should().Be(expectedColor);

            if (expectedArchetype != null) result.Matches.First().Archetype.GetType().Name.Should().Be(expectedArchetype);
            else throw new Exception($"Archetype not specified, detection returned {result.Matches.First().Archetype.GetType().Name}");

            if (expectedVariant != null) result.Matches.First().Variant.GetType().Name.Should().Be(expectedVariant);
            else result.Matches.First().Variant.Should().BeNull();

            if (expectedCompanion != null) result.Companion.Should().Be(expectedCompanion.Value);
            else result.Companion.Should().BeNull();
        }
    }
}
