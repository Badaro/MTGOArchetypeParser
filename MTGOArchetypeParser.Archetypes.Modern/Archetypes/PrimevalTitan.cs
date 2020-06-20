using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class PrimevalTitan : Archetype
    {
        public PrimevalTitan()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Primeval Titan" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Summoner's Pact" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new AmuletTitan(),
                new KGCAmuletTitan(),
                new TitanShift()
            };
        }
    }

    public class AmuletTitan : ArchetypeVariant
    {
        public AmuletTitan()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Amulet of Vigor" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Simic Growth Chamber" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Karn, the Great Creator" } }
            };
        }
    }

    public class KGCAmuletTitan : ArchetypeVariant
    {
        public KGCAmuletTitan()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Amulet of Vigor" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Simic Growth Chamber" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Karn, the Great Creator" } }
            };
        }
    }

    public class TitanShift : ArchetypeVariant
    {
        public TitanShift()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Scapeshift" } }
            };
        }
    }
}
