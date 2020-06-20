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

        protected void Test(ISampleDeck deck, ArchetypeColor? expectedColor = null, Type expectedArchetype = null, Type expectedVariant = null, ArchetypeCompanion? expectedCompanion = null)
        {
            var result = ArchetypeAnalyzer.Detect(deck.Mainboard, deck.Sideboard, MTGOArchetypeParser.Archetypes.Modern.Loader.GetArchetypes());

            if (expectedColor != null) result.Color.Should().Be(expectedColor);
            else result.Color.Should().Be(ArchetypeColor.C);

            if (expectedArchetype != null)
            {
                result.Matches.Should().HaveCount(1);
                result.Matches.First().Archetype.Should().BeOfType(expectedArchetype);

                if (expectedVariant != null) result.Matches.First().Variant.Should().BeOfType(expectedVariant);
                else result.Matches.First().Variant.Should().BeNull();
            }
            else
            {
                result.Matches.Should().HaveCount(0);
            }

            if (expectedCompanion != null) result.Companion.Should().Be(expectedCompanion.Value);
            else result.Companion.Should().BeNull();
        }
    }
}
