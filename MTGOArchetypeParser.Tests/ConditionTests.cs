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
        public void OneOrMoreInSideboard()
        {
            DetectionSuccess(ArchetypeConditionType.OneOrMoreInSideboard,
                new string[] { "Card 1", "Card 2" },
                new string[] { },
                new string[] { "Card 1", "Card 3" });

            DetectionSuccess(ArchetypeConditionType.OneOrMoreInSideboard,
                new string[] { "Card 1", "Card 2" },
                new string[] { },
                new string[] { "Card 2", "Card 3" });
        }

        [Test]
        public void OneOrMoreInMainOrSideboard()
        {
            DetectionSuccess(ArchetypeConditionType.OneOrMoreInMainOrSideboard,
               new string[] { "Card 1", "Card 2" },
               new string[] { "Card 1", "Card 3" },
               new string[] { });

            DetectionSuccess(ArchetypeConditionType.OneOrMoreInMainOrSideboard,
                new string[] { "Card 1", "Card 2" },
                new string[] { "Card 2", "Card 3" },
                new string[] { });

            DetectionSuccess(ArchetypeConditionType.OneOrMoreInMainOrSideboard,
                new string[] { "Card 1", "Card 2" },
                new string[] { },
                new string[] { "Card 1", "Card 3" });

            DetectionSuccess(ArchetypeConditionType.OneOrMoreInMainOrSideboard,
                new string[] { "Card 1", "Card 2" },
                new string[] { },
                new string[] { "Card 2", "Card 3" });
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
        public void TwoOrMoreInSideboard()
        {
            DetectionFailure(ArchetypeConditionType.TwoOrMoreInSideboard,
               new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
               new string[] { },
               new string[] { "Card 1", "Card 5" });

            DetectionSuccess(ArchetypeConditionType.TwoOrMoreInSideboard,
               new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
               new string[] { },
               new string[] { "Card 1", "Card 3" });

            DetectionSuccess(ArchetypeConditionType.TwoOrMoreInSideboard,
               new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
               new string[] { },
               new string[] { "Card 2", "Card 3" });
        }

        [Test]
        public void TwoOrMoreInMainOrSideboard()
        {
            DetectionFailure(ArchetypeConditionType.TwoOrMoreInMainOrSideboard,
               new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
               new string[] { "Card 1", "Card 5" },
               new string[] { });

            DetectionSuccess(ArchetypeConditionType.TwoOrMoreInMainOrSideboard,
               new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
               new string[] { "Card 1", "Card 3" },
               new string[] { });

            DetectionSuccess(ArchetypeConditionType.TwoOrMoreInMainOrSideboard,
               new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
               new string[] { "Card 2", "Card 3" },
               new string[] { });

            DetectionFailure(ArchetypeConditionType.TwoOrMoreInMainOrSideboard,
               new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
               new string[] { },
               new string[] { "Card 1", "Card 5" });

            DetectionSuccess(ArchetypeConditionType.TwoOrMoreInMainOrSideboard,
               new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
               new string[] { },
               new string[] { "Card 1", "Card 3" });

            DetectionSuccess(ArchetypeConditionType.TwoOrMoreInMainOrSideboard,
               new string[] { "Card 1", "Card 2", "Card 3", "Card 4" },
               new string[] { },
               new string[] { "Card 2", "Card 3" });
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
        public void DoesNotContainAll()
        {
            DetectionSuccess(ArchetypeConditionType.DoesNotContainAll,
               new string[] { "Card 1", "Card 2" },
               new string[] { "Card 1" },
               new string[] { });

            DetectionSuccess(ArchetypeConditionType.DoesNotContainAll,
               new string[] { "Card 1", "Card 2" },
               new string[] { "Card 2" },
               new string[] { });

            DetectionFailure(ArchetypeConditionType.DoesNotContainAll,
               new string[] { "Card 1", "Card 2" },
               new string[] { "Card 1", "Card 2" },
               new string[] { });

            DetectionFailure(ArchetypeConditionType.DoesNotContainAll,
               new string[] { "Card 1", "Card 2" },
               new string[] { },
               new string[] { "Card 1", "Card 2" });

            DetectionFailure(ArchetypeConditionType.DoesNotContainAll,
               new string[] { "Card 1", "Card 2" },
               new string[] { "Card 1" },
               new string[] { "Card 2" });
        }

        private void DetectionSuccess(ArchetypeConditionType condition, string[] archetypeCards, string[] testMainboard, string[] testSideboard)
        {
            var archetype = new Archetype()
            {
                Conditions = new ArchetypeCondition[]
                {
                    new ArchetypeCondition() { Type= condition, Cards = archetypeCards }
                }
            };

            var result = ArchetypeAnalyzer.Detect(
                testMainboard,
                testSideboard,
                new Archetype[]
                {
                     archetype
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();
        }

        private void DetectionFailure(ArchetypeConditionType condition, string[] archetypeCards, string[] testMainboard, string[] testSideboard)
        {
            var archetype = new Archetype()
            {
                Conditions = new ArchetypeCondition[]
                {
                    new ArchetypeCondition() { Type= condition, Cards = archetypeCards }
                }
            };

            var result = ArchetypeAnalyzer.Detect(
                testMainboard,
                testSideboard,
                new Archetype[]
                {
                     archetype
                });

            result.Matches.Should().HaveCount(0);
        }
    }
}
