using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Delver : ArchetypeSpecific
    {
        public Delver()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Delver of Secrets" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Lightning Bolt", "Psionic Blast", "Fatal Push" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainboard, Cards = new string[] { "Vapor Snag", "Remand", "Mana Leak", "Force of Negation", "Archmage's Charm", "Stubborn Denial" } }
            };
        }
    }
}
