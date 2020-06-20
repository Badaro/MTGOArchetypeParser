using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Rock : Archetype
    {
        public Rock()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Tarmogoyf" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainOrSideboard, Cards = new string[] { "Fatal Push" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOfInMainboard, Cards = new string[] { "Thoughtseize", "Inquisition of Kozilek" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOfInMainOrSideboard, Cards = new string[] { "Abrupt Decay", "Assassin's Trophy", "Maelstrom Pulse" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Death's Shadow" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Arcum's Astrolabe" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new Jund(),
                new Sultai()
            };
        }
    }

    public class Jund : ArchetypeVariant
    {
        public Jund()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Kolaghan's Command" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Lightning Bolt" } }
            };
        }
    }

    public class Sultai : ArchetypeVariant
    {
        public Sultai()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Snapcaster Mage" } }
            };
        }
    }
}
