using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Ponza : ArchetypeSpecific
    {
        public Ponza()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Arbor Elf" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Utopia Sprawl" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Klothys, God of Destiny" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Lightning Bolt", "Bonecrusher Giant", "Abrade" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainOrSideboard, Cards = new string[] { "Magus of the Moon", "Blood Moon" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new LiquimetalPonza()
            };
        }
    }

    public class LiquimetalPonza : ArchetypeVariant
    {
        public LiquimetalPonza()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Liquimetal Coating" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Karn, the Great Creator" } }
            };
        }
    }
}
