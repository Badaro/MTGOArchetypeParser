using FluentAssertions;
using MTGOArchetypeParser.Data;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Tests.SampleData;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class EventTest
    {

        protected void Test(ISampleDeck deck, ArchetypeMeta meta, ArchetypeColor expectedColor, Type expectedArchetype, Type expectedVariant = null, ArchetypeCompanion? expectedCompanion = null)
        {
            var result = ArchetypeAnalyzer.Detect(deck.Mainboard.Select(c => c.Name).ToArray(), deck.Sideboard.Select(c => c.Name).ToArray(), MTGOArchetypeParser.Archetypes.Modern.Loader.GetArchetypes());

            result.Matches.Should().HaveCount(1);

            result.Color.Should().Be(expectedColor);
            result.Matches.First().Archetype.Should().BeOfType(expectedArchetype);

            if (expectedVariant != null) result.Matches.First().Variant.Should().BeOfType(expectedVariant);
            else result.Matches.First().Variant.Should().BeNull();

            if (expectedCompanion != null) result.Companion.Should().Be(expectedCompanion.Value);
            else result.Companion.Should().BeNull();
        }
    }
}
