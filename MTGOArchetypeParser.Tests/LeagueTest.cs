using FluentAssertions;
using MTGOArchetypeParser.Data;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Tests.SampleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class LeagueTest
    {

        protected void Test(ISampleDeck deck, Type expectedArchetype, Type expectedVariant = null, ArchetypeCompanion? expectedCompanion = null)
        {
            var result = ArchetypeAnalyzer.Detect(deck.Mainboard, deck.Sideboard, MTGOArchetypeParser.Archetypes.Modern.Loader.GetArchetypes());

            result.Should().HaveCount(1);

            if (expectedArchetype != null) result.First().Archetype.Should().BeOfType(expectedArchetype);
            else result.First().Archetype.Should().BeNull();

            if (expectedVariant != null) result.First().Variant.Should().BeOfType(expectedVariant);
            else result.First().Variant.Should().BeNull();

            if (expectedCompanion != null) result.First().Companion.Should().Be(expectedCompanion.Value);
            else result.First().Companion.Should().BeNull();
        }
    }
}
