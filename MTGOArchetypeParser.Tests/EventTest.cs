﻿using FluentAssertions;
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
        string cacheFolder = new DirectoryInfo(@"..\..\..\..\MTGODecklistCache\Tournaments").FullName;
        static Dictionary<string, Tournament> tournamentCache = new Dictionary<string, Tournament>();

        protected Deck GetDeck(string tournamentName, int deckIndex)
        {
            if (!tournamentCache.ContainsKey(tournamentName))
            {
                tournamentCache.Add(tournamentName, TournamentLoader.GetTournamentByName(cacheFolder, tournamentName));
            }
            return tournamentCache[tournamentName].Decks[deckIndex];
        }

        protected void Test(Deck deck, ArchetypeMeta meta, ArchetypeColor expectedColor, Type expectedArchetype, Type expectedVariant = null, ArchetypeCompanion? expectedCompanion = null)
        {
            var result = ArchetypeAnalyzer.Detect(deck.Mainboard.Select(i => new Card() { Name = i.Card, Count = i.Count }).ToArray(), deck.Sideboard.Select(i => new Card() { Name = i.Card, Count = i.Count }).ToArray(), MTGOArchetypeParser.Archetypes.Modern.Loader.GetArchetypes());

            result.Matches.Should().HaveCount(1);

            result.Color.Should().Be(expectedColor);

            if (expectedArchetype != null) result.Matches.First().Archetype.Should().BeOfType(expectedArchetype);
            else throw new Exception($"Archetype not specified, detection returned {result.Matches.First().Archetype.GetType().Name}");

            if (expectedVariant != null) result.Matches.First().Variant.Should().BeOfType(expectedVariant);
            else result.Matches.First().Variant.Should().BeNull();

            if (expectedCompanion != null) result.Companion.Should().Be(expectedCompanion.Value);
            else result.Companion.Should().BeNull();
        }
    }
}
