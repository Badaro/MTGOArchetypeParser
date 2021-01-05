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
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Summoner's Pact", "Hour of Promise", "Elvish Reclaimer", "Sakura-Tribe Elder" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Force of Negation" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Gyruda, Doom of Depths" } },
            };
            Variants = new ArchetypeVariant[]
            {
                new AmuletTitan(),
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
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Eladamri's Call", "Flagstones of Trokair" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Amulet of Vigor" } },
            };
        }
    }
}
