using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Goblins : Archetype
    {
        public Goblins()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Goblin Matron" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Sling-Gang Lieutenant" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOfInMainboard, Cards = new string[] { "Auntie's Hovel", "Cavern of Souls" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new SnoopGoblins()
            };
        }
    }

    public class SnoopGoblins : ArchetypeVariant
    {
        public SnoopGoblins()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Boggart Harbinger" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Kiki-Jiki, Mirror Breaker" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Conspicuous Snoop" } }
            };
        }
    }
}