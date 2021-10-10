using FluentAssertions;
using MTGOArchetypeParser.Data;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class ConditionTests
    {
        static ArchetypeFormat _modern = MTGOArchetypeParser.Formats.FromJson.Loader.GetFormat(new DirectoryInfo(@"..\..\..\..\MTGOFormatData\Formats").FullName, "Modern");

        [Test]
        public void InMainboard()
        {
            DetectionShouldSucceed(
                condition: ArchetypeConditionType.InMainboard,
                cards: new string[] { "Card 1" },
                mainboard: new string[] { "Card 1", "Card 2" },
                sideboard: new string[] { }
            );
        }

        [Test]
        public void InSideboard()
        {
            DetectionShouldSucceed(
                condition: ArchetypeConditionType.InSideboard,
                cards: new string[] { "Card 1" },
                mainboard: new string[] { },
                sideboard: new string[] { "Card 1", "Card 2" }
            );
        }

        [Test]
        public void InMainOrSideboard()
        {
            DetectionShouldSucceed(
                ArchetypeConditionType.InMainOrSideboard,
                cards: new string[] { "Card 1" },
                mainboard: new string[] { "Card 1", "Card 2" },
                sideboard: new string[] { }
            );

            DetectionShouldSucceed(
                condition: ArchetypeConditionType.InMainOrSideboard,
                cards: new string[] { "Card 1" },
                mainboard: new string[] { },
                sideboard: new string[] { "Card 1", "Card 2" }
            );
        }

        [Test]
        public void OneOrMoreInMainboard()
        {
            DetectionShouldSucceed(
                condition: ArchetypeConditionType.OneOrMoreInMainboard,
                cards: new string[] { "Card 1", "Card 2" },
                mainboard: new string[] { "Card 1", "Card 3" },
                sideboard: new string[] { }
            );

            DetectionShouldSucceed(
                condition: ArchetypeConditionType.OneOrMoreInMainboard,
                cards: new string[] { "Card 1", "Card 2" },
                mainboard: new string[] { "Card 2", "Card 3" },
                sideboard: new string[] { }
            );
        }

        [Test]
        public void OneOrMoreInSideboard()
        {
            DetectionShouldSucceed(
                condition: ArchetypeConditionType.OneOrMoreInSideboard,
                cards: new string[] { "Card 1", "Card 2" },
                mainboard: new string[] { },
                sideboard: new string[] { "Card 1", "Card 3" }
            );

            DetectionShouldSucceed(
                condition: ArchetypeConditionType.OneOrMoreInSideboard,
                cards: new string[] { "Card 1", "Card 2" },
                mainboard: new string[] { },
                sideboard: new string[] { "Card 2", "Card 3" }
            );
        }

        [Test]
        public void OneOrMoreInMainOrSideboard()
        {
            DetectionShouldSucceed(
                condition: ArchetypeConditionType.OneOrMoreInMainOrSideboard,
                cards: new string[] { "Card 1", "Card 2" },
                mainboard: new string[] { "Card 1", "Card 3" },
                sideboard: new string[] { }
            );

            DetectionShouldSucceed(
                condition: ArchetypeConditionType.OneOrMoreInMainOrSideboard,
                cards: new string[] { "Card 1", "Card 2" },
                mainboard: new string[] { },
                sideboard: new string[] { "Card 2", "Card 3" }
            );
        }

        [Test]
        public void TwoOrMoreInMainboard()
        {
            DetectionShouldFail(
                condition: ArchetypeConditionType.TwoOrMoreInMainboard,
                cards: new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
                mainboard: new string[] { "Card 1", "Card 5" },
                sideboard: new string[] { }
            );

            DetectionShouldSucceed(
                condition: ArchetypeConditionType.TwoOrMoreInMainboard,
                cards: new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
                mainboard: new string[] { "Card 1", "Card 3" },
                sideboard: new string[] { }
            );

            DetectionShouldSucceed(
                condition: ArchetypeConditionType.TwoOrMoreInMainboard,
                cards: new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
                mainboard: new string[] { "Card 2", "Card 3" },
                sideboard: new string[] { }
            );
        }

        [Test]
        public void TwoOrMoreInSideboard()
        {
            DetectionShouldFail(
                condition: ArchetypeConditionType.TwoOrMoreInSideboard,
                cards: new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
                mainboard: new string[] { },
                sideboard: new string[] { "Card 1", "Card 5" });

            DetectionShouldSucceed(
                condition: ArchetypeConditionType.TwoOrMoreInSideboard,
                cards: new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
                mainboard: new string[] { },
                sideboard: new string[] { "Card 1", "Card 3" }
            );

            DetectionShouldSucceed(
                condition: ArchetypeConditionType.TwoOrMoreInSideboard,
                cards: new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
                mainboard: new string[] { },
                sideboard: new string[] { "Card 2", "Card 3" }
            );
        }

        [Test]
        public void TwoOrMoreInMainOrSideboard()
        {
            DetectionShouldFail(
                condition: ArchetypeConditionType.TwoOrMoreInMainOrSideboard,
                cards: new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
                mainboard: new string[] { "Card 1" },
                sideboard: new string[] { "Card 5" });

            DetectionShouldSucceed(
                condition: ArchetypeConditionType.TwoOrMoreInMainOrSideboard,
                cards: new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
                mainboard: new string[] { "Card 1", "Card 3" },
                sideboard: new string[] { }
            );

            DetectionShouldSucceed(
                condition: ArchetypeConditionType.TwoOrMoreInMainOrSideboard,
                cards: new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
                mainboard: new string[] { },
                sideboard: new string[] { "Card 2", "Card 3" }
            );

            DetectionShouldSucceed(
                condition: ArchetypeConditionType.TwoOrMoreInMainOrSideboard,
                cards: new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
                mainboard: new string[] { "Card 1", },
                sideboard: new string[] { "Card 4" }
            );
        }

        [Test]
        public void DoesNotContain()
        {
            DetectionShouldSucceed(
                condition: ArchetypeConditionType.DoesNotContain,
                cards: new string[] { "Card 1" },
                mainboard: new string[] { "Card 2", "Card 3" },
                sideboard: new string[] { }
            );

            DetectionShouldFail(
                condition: ArchetypeConditionType.DoesNotContain,
                cards: new string[] { "Card 1" },
                mainboard: new string[] { "Card 1", "Card 3" },
                sideboard: new string[] { }
            );

            DetectionShouldFail(
                condition: ArchetypeConditionType.DoesNotContain,
                cards: new string[] { "Card 1" },
                mainboard: new string[] { },
                sideboard: new string[] { "Card 1", "Card 3" }
            );
        }

        [Test]
        public void DoesNotContainMainboard()
        {
            DetectionShouldSucceed(
                condition: ArchetypeConditionType.DoesNotContainMainboard,
                cards: new string[] { "Card 1" },
                mainboard: new string[] { "Card 2", "Card 3" },
                sideboard: new string[] { }
            );

            DetectionShouldFail(
                condition: ArchetypeConditionType.DoesNotContainMainboard,
                cards: new string[] { "Card 1" },
                mainboard: new string[] { "Card 1", "Card 3" },
                sideboard: new string[] { }
            );

            DetectionShouldSucceed(
                condition: ArchetypeConditionType.DoesNotContainMainboard,
                cards: new string[] { "Card 1" },
                mainboard: new string[] { },
                sideboard: new string[] { "Card 1", "Card 3" }
            );
        }

        [Test]
        public void DoesNotContainSideboard()
        {
            DetectionShouldSucceed(
                condition: ArchetypeConditionType.DoesNotContainSideboard,
                cards: new string[] { "Card 1" },
                mainboard: new string[] { "Card 2", "Card 3" },
                sideboard: new string[] { }
            );

            DetectionShouldSucceed(
                condition: ArchetypeConditionType.DoesNotContainSideboard,
                cards: new string[] { "Card 1" },
                mainboard: new string[] { "Card 1", "Card 3" },
                sideboard: new string[] { }
            );

            DetectionShouldFail(
                condition: ArchetypeConditionType.DoesNotContainSideboard,
                cards: new string[] { "Card 1" },
                mainboard: new string[] { },
                sideboard: new string[] { "Card 1", "Card 3" }
            );
        }

        private void DetectionShouldSucceed(ArchetypeConditionType condition, string[] cards, string[] mainboard, string[] sideboard)
        {
            var archetype = new ArchetypeSpecific()
            {
                Conditions = new ArchetypeCondition[]
                {
                    new ArchetypeCondition() { Type= condition, Cards = cards }
                }
            };

            var result = ArchetypeAnalyzer.Detect(
                mainboard.Select(c => new Card() { Count = 4, Name = c }).ToArray(),
                sideboard.Select(c => new Card() { Count = 4, Name = c }).ToArray(),
                new ArchetypeFormat
                {
                    Archetypes = new Archetype[]
                    {
                         archetype
                    },
                    Lands = _modern.Lands,
                    NonLands = _modern.NonLands
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();
        }

        private void DetectionShouldFail(ArchetypeConditionType condition, string[] cards, string[] mainboard, string[] sideboard)
        {
            var archetype = new ArchetypeSpecific()
            {
                Conditions = new ArchetypeCondition[]
                {
                    new ArchetypeCondition() { Type= condition, Cards = cards }
                }
            };

            var result = ArchetypeAnalyzer.Detect(
                mainboard.Select(c => new Card() { Count = 4, Name = c }).ToArray(),
                sideboard.Select(c => new Card() { Count = 4, Name = c }).ToArray(),
                new ArchetypeFormat
                {
                    Archetypes = new Archetype[]
                    {
                         archetype
                    },
                    Lands = _modern.Lands,
                    NonLands = _modern.NonLands
                });

            result.Matches.Should().HaveCount(0);
        }
    }
}
