﻿using FluentAssertions;
using MTGOArchetypeParser.Data;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class ConditionTests
    {
        [Test]
        public void InMainboard()
        {
            DetectionSuccess(ArchetypeConditionType.InMainboard,
                new string[] { "Card 1" },
                new string[] { "Card 1", "Card 2" },
                new string[] { });
        }

        [Test]
        public void InSideboard()
        {
            DetectionSuccess(ArchetypeConditionType.InSideboard,
                new string[] { "Card 1" },
                new string[] { },
                new string[] { "Card 1", "Card 2" });
        }

        [Test]
        public void InMainOrSideboard()
        {
            DetectionSuccess(ArchetypeConditionType.InMainOrSideboard,
                new string[] { "Card 1" },
                new string[] { "Card 1", "Card 2" },
                new string[] { });

            DetectionSuccess(ArchetypeConditionType.InMainOrSideboard,
                new string[] { "Card 1" },
                new string[] { },
                new string[] { "Card 1", "Card 2" });
        }

        [Test]
        public void OneOrMoreInMainboard()
        {
            DetectionSuccess(ArchetypeConditionType.OneOrMoreInMainboard,
                new string[] { "Card 1", "Card 2" },
                new string[] { "Card 1", "Card 3" },
                new string[] { });

            DetectionSuccess(ArchetypeConditionType.OneOrMoreInMainboard,
                new string[] { "Card 1", "Card 2" },
                new string[] { "Card 2", "Card 3" },
                new string[] { });
        }

        [Test]
        public void TwoOrMoreInMainboard()
        {
            DetectionFailure(ArchetypeConditionType.TwoOrMoreInMainboard,
               new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
               new string[] { "Card 1", "Card 5" },
               new string[] { });

            DetectionSuccess(ArchetypeConditionType.TwoOrMoreInMainboard,
               new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
               new string[] { "Card 1", "Card 3" },
               new string[] { });

            DetectionSuccess(ArchetypeConditionType.TwoOrMoreInMainboard,
               new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
               new string[] { "Card 2", "Card 3" },
               new string[] { });
        }

        [Test]
        public void DoesNotContain()
        {
            DetectionSuccess(ArchetypeConditionType.DoesNotContain,
               new string[] { "Card 1" },
               new string[] { "Card 2", "Card 3" },
               new string[] { });

            DetectionFailure(ArchetypeConditionType.DoesNotContain,
               new string[] { "Card 1" },
               new string[] { "Card 1", "Card 3" },
               new string[] { });

            DetectionFailure(ArchetypeConditionType.DoesNotContain,
               new string[] { "Card 1" },
               new string[] { },
               new string[] { "Card 1", "Card 3" });
        }

        [Test]
        public void DoesNotContainMainboard()
        {
            DetectionSuccess(ArchetypeConditionType.DoesNotContainMainboard,
               new string[] { "Card 1" },
               new string[] { "Card 2", "Card 3" },
               new string[] { });

            DetectionFailure(ArchetypeConditionType.DoesNotContainMainboard,
               new string[] { "Card 1" },
               new string[] { "Card 1", "Card 3" },
               new string[] { });

            DetectionSuccess(ArchetypeConditionType.DoesNotContainMainboard,
               new string[] { "Card 1" },
               new string[] { },
               new string[] { "Card 1", "Card 3" });
        }

        [Test]
        public void DoesNotContainSideboard()
        {
            DetectionSuccess(ArchetypeConditionType.DoesNotContainSideboard,
               new string[] { "Card 1" },
               new string[] { "Card 2", "Card 3" },
               new string[] { });

            DetectionSuccess(ArchetypeConditionType.DoesNotContainSideboard,
               new string[] { "Card 1" },
               new string[] { "Card 1", "Card 3" },
               new string[] { });

            DetectionFailure(ArchetypeConditionType.DoesNotContainSideboard,
               new string[] { "Card 1" },
               new string[] { },
               new string[] { "Card 1", "Card 3" });
        }

        [Test]
        public void ColorIsExactly()
        {
            DetectionFailure(ArchetypeConditionType.ColorIsExactly,
               ArchetypeColor.WU,
               new string[] { "Plains" },
               new string[] { });

            DetectionSuccess(ArchetypeConditionType.ColorIsExactly,
               ArchetypeColor.WU,
               new string[] { "Plains", "Island" },
               new string[] { });

            DetectionFailure(ArchetypeConditionType.ColorIsExactly,
               ArchetypeColor.WU,
               new string[] { "Swamp" },
               new string[] { });
        }

        private void DetectionSuccess(ArchetypeConditionType condition, string[] archetypeCards, string[] testMainboard, string[] testSideboard)
        {
            DetectionSuccess(condition, archetypeCards, default(ArchetypeColor), testMainboard, testSideboard);
        }

        private void DetectionSuccess(ArchetypeConditionType condition, ArchetypeColor archetypeColor, string[] testMainboard, string[] testSideboard)
        {
            DetectionSuccess(condition, new string[0], archetypeColor, testMainboard, testSideboard);
        }

        private void DetectionSuccess(ArchetypeConditionType condition, string[] archetypeCards, ArchetypeColor archetypeColor, string[] testMainboard, string[] testSideboard)
        {
            var archetype = new ArchetypeSpecific()
            {
                Conditions = new ArchetypeCondition[]
                {
                    new ArchetypeCondition() { Type= condition, Cards = archetypeCards, Color = archetypeColor }
                }
            };

            var result = ArchetypeAnalyzer.Detect(
                testMainboard.Select(c => new Card() { Count = 1, Name = c }).ToArray(),
                testSideboard.Select(c => new Card() { Count = 1, Name = c }).ToArray(),
                new ArchetypeSpecific[]
                {
                     archetype
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();
        }

        private void DetectionFailure(ArchetypeConditionType condition, string[] archetypeCards, string[] testMainboard, string[] testSideboard)
        {
            DetectionFailure(condition, archetypeCards, default(ArchetypeColor), testMainboard, testSideboard);
        }

        private void DetectionFailure(ArchetypeConditionType condition, ArchetypeColor archetypeColor, string[] testMainboard, string[] testSideboard)
        {
            DetectionFailure(condition, new string[0], archetypeColor, testMainboard, testSideboard);
        }

        private void DetectionFailure(ArchetypeConditionType condition, string[] archetypeCards, ArchetypeColor archetypeColor, string[] testMainboard, string[] testSideboard)
        {
            var archetype = new ArchetypeSpecific()
            {
                Conditions = new ArchetypeCondition[]
                {
                    new ArchetypeCondition() { Type= condition, Cards = archetypeCards, Color = archetypeColor }
                }
            };

            var result = ArchetypeAnalyzer.Detect(
                testMainboard.Select(c => new Card() { Count = 1, Name = c }).ToArray(),
                testSideboard.Select(c => new Card() { Count = 1, Name = c }).ToArray(),
                new ArchetypeSpecific[]
                {
                     archetype
                });

            result.Matches.Should().HaveCount(0);
        }
    }
}
