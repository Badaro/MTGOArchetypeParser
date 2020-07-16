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
            var archetype = new Archetype()
            {
                Conditions = new ArchetypeCondition[]
                {
                    new ArchetypeCondition() { Type= ArchetypeConditionType.InMainboard, Cards = new string[] { "Card 1" } }
                }
            };

            var result = ArchetypeAnalyzer.Detect(
                new string[] { "Card 1", "Card 2" },
                new string[] { },
                new Archetype[]
                {
                    archetype
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();
        }

        [Test]
        public void InSideboard()
        {
            var archetype = new Archetype()
            {
                Conditions = new ArchetypeCondition[]
                {
                    new ArchetypeCondition() { Type= ArchetypeConditionType.InSideboard, Cards = new string[] { "Card 1" } }
                }
            };

            var result = ArchetypeAnalyzer.Detect(
                new string[] { },
                new string[] { "Card 1", "Card 2" },
                new Archetype[]
                {
                    archetype
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();
        }

        [Test]
        public void InMainOrSideboard()
        {
            var archetype = new Archetype()
            {
                Conditions = new ArchetypeCondition[]
                {
                    new ArchetypeCondition() { Type= ArchetypeConditionType.InMainOrSideboard, Cards = new string[] { "Card 1" } }
                }
            };

            var result = ArchetypeAnalyzer.Detect(
            new string[] { "Card 1", "Card 2" },
            new string[] { },
            new Archetype[]
            {
                archetype
            });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();

            result = ArchetypeAnalyzer.Detect(
                new string[] { },
                new string[] { "Card 1", "Card 2" },
                new Archetype[]
                {
                    archetype
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();
        }

        [Test]
        public void OneOrMoreInMainboard()
        {
            var archetype = new Archetype()
            {
                Conditions = new ArchetypeCondition[]
                {
                    new ArchetypeCondition() { Type= ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Card 1", "Card 2" } }
                }
            };

            var result = ArchetypeAnalyzer.Detect(
                new string[] { "Card 1", "Card 3" },
                new string[] { },
                new Archetype[]
                {
                    archetype
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();

            result = ArchetypeAnalyzer.Detect(
                new string[] { "Card 2", "Card 3" },
                new string[] { },
                new Archetype[]
                {
                    archetype
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();

        }

        [Test]
        public void OneOrMoreInSideboard()
        {
            var archetype = new Archetype()
            {
                Conditions = new ArchetypeCondition[]
                {
                    new ArchetypeCondition() { Type= ArchetypeConditionType.OneOrMoreInSideboard, Cards = new string[] { "Card 1", "Card 2" } }
                }
            };

            var result = ArchetypeAnalyzer.Detect(
                new string[] { },
                new string[] { "Card 1", "Card 3" },
                new Archetype[]
                {
                    archetype
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();

            result = ArchetypeAnalyzer.Detect(
                new string[] { },
                new string[] { "Card 2", "Card 3" },
                new Archetype[]
                {
                    archetype
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();
        }

        [Test]
        public void OneOrMoreInMainOrSideboard()
        {
            var archetype = new Archetype()
            {
                Conditions = new ArchetypeCondition[]
                {
                    new ArchetypeCondition() { Type= ArchetypeConditionType.OneOrMoreInMainOrSideboard, Cards = new string[] { "Card 1", "Card 2" } }
                }
            };

            var result = ArchetypeAnalyzer.Detect(
            new string[] { "Card 1", "Card 3" },
            new string[] { },
            new Archetype[]
            {
                            archetype
            });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();

            result = ArchetypeAnalyzer.Detect(
                new string[] { "Card 2", "Card 3" },
                new string[] { },
                new Archetype[]
                {
                    archetype
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();

            result = ArchetypeAnalyzer.Detect(
                new string[] { },
                new string[] { "Card 1", "Card 3" },
                new Archetype[]
                {
                    archetype
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();

            result = ArchetypeAnalyzer.Detect(
                new string[] { },
                new string[] { "Card 2", "Card 3" },
                new Archetype[]
                {
                    archetype
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();
        }


        [Test]
        public void TwoOrMoreInMainboard()
        {
            var archetype = new Archetype()
            {
                Conditions = new ArchetypeCondition[]
                {
                    new ArchetypeCondition() { Type= ArchetypeConditionType.TwoOrMoreInMainboard, Cards = new string[] { "Card 1", "Card 2", "Card 3", "Card 4" } }
                }
            };

            var result = ArchetypeAnalyzer.Detect(
                new string[] { "Card 1", "Card 5" },
                new string[] { },
                new Archetype[]
                {
                    archetype
                });

            result.Matches.Should().HaveCount(0);

            result = ArchetypeAnalyzer.Detect(
                new string[] { "Card 1", "Card 3" },
                new string[] { },
                new Archetype[]
                {
                    archetype
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();

            result = ArchetypeAnalyzer.Detect(
                new string[] { "Card 2", "Card 3" },
                new string[] { },
                new Archetype[]
                {
                    archetype
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();

        }

        [Test]
        public void TwoOrMoreInSideboard()
        {
            var archetype = new Archetype()
            {
                Conditions = new ArchetypeCondition[]
                {
                    new ArchetypeCondition() { Type= ArchetypeConditionType.TwoOrMoreInSideboard, Cards = new string[] { "Card 1", "Card 2", "Card 4", "Card 3" } }
                }
            };

            var result = ArchetypeAnalyzer.Detect(
            new string[] { },
            new string[] { "Card 1", "Card 6" },
            new Archetype[]
            {
                archetype
            });

            result.Matches.Should().HaveCount(0);

            result = ArchetypeAnalyzer.Detect(
                new string[] { },
                new string[] { "Card 1", "Card 3" },
                new Archetype[]
                {
                    archetype
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();

            result = ArchetypeAnalyzer.Detect(
                new string[] { },
                new string[] { "Card 2", "Card 3" },
                new Archetype[]
                {
                    archetype
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();
        }

        [Test]
        public void TwoOrMoreInMainOrSideboard()
        {
            var archetype = new Archetype()
            {
                Conditions = new ArchetypeCondition[]
                {
                    new ArchetypeCondition() { Type= ArchetypeConditionType.TwoOrMoreInMainOrSideboard, Cards = new string[] { "Card 1", "Card 2", "Card 4", "Card 3" } }
                }
            };

            var result = ArchetypeAnalyzer.Detect(
            new string[] { "Card 1", "Card 6" },
            new string[] { },
            new Archetype[]
            {
                archetype
            });

            result.Matches.Should().HaveCount(0);

            result = ArchetypeAnalyzer.Detect(
            new string[] { "Card 1", "Card 3" },
            new string[] { },
            new Archetype[]
            {
                            archetype
            });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();

            result = ArchetypeAnalyzer.Detect(
                new string[] { "Card 2", "Card 3" },
                new string[] { },
                new Archetype[]
                {
                    archetype
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();

            result = ArchetypeAnalyzer.Detect(
                new string[] { },
                new string[] { "Card 1", "Card 3" },
                new Archetype[]
                {
                    archetype
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();

            result = ArchetypeAnalyzer.Detect(
                new string[] { },
                new string[] { "Card 2", "Card 3" },
                new Archetype[]
                {
                    archetype
                });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();

            result = ArchetypeAnalyzer.Detect(
            new string[] { "Card 1", "Card 8" },
            new string[] { "Card 2", "Card 6" },
            new Archetype[]
            {
                archetype
            });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();

            result = ArchetypeAnalyzer.Detect(
            new string[] { "Card 2", "Card 8" },
            new string[] { "Card 2", "Card 6" },
            new Archetype[]
            {
                archetype
            });

            result.Matches.Should().HaveCount(0);
        }

        [Test]
        public void DoesNotContain()
        {
            var archetype = new Archetype()
            {
                Conditions = new ArchetypeCondition[]
                {
                    new ArchetypeCondition() { Type= ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Card 1" } }
                }
            };

            var result = ArchetypeAnalyzer.Detect(
            new string[] { "Card 2", "Card 3" },
            new string[] { },
            new Archetype[]
            {
                 archetype
            });

            result.Matches.Should().HaveCount(1);
            result.Matches.First().Archetype.Should().Be(archetype);
            result.Matches.First().Variant.Should().BeNull();

            result = ArchetypeAnalyzer.Detect(
            new string[] { "Card 1", "Card 3" },
            new string[] { },
            new Archetype[]
            {
                 archetype
            });

            result.Matches.Should().HaveCount(0);

            result = ArchetypeAnalyzer.Detect(
            new string[] { },
            new string[] { "Card 1", "Card 3" },
            new Archetype[]
            {
                 archetype
            });

            result.Matches.Should().HaveCount(0);
        }
    }
}
