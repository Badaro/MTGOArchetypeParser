using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class PrimevalTitan : ArchetypeSpecific
    {
        public PrimevalTitan()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Primeval Titan" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Summoner's Pact", "Hour of Promise", "Elvish Reclaimer", "Sakura-Tribe Elder", "Heartless Summoning" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Force of Negation" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Battle of Wits" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Gyruda, Doom of Depths" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Inferno Titan" } },
            };
            Variants = new ArchetypeVariant[]
            {
                new AmuletTitan(),
                new KGCAmuletTitan(),
                new TitanShift(),
                new ReclaimerTitan()
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
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Simic Growth Chamber", "Selesnya Sanctuary" } },
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
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Simic Growth Chamber", "Selesnya Sanctuary" } },
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

    public class ReclaimerTitan : ArchetypeVariant
    {
        public ReclaimerTitan()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Elvish Reclaimer" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Amulet of Vigor" } },
            };
        }
    }
}
