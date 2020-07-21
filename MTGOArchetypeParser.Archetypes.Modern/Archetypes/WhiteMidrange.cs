using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class WhiteMidrange : Archetype
    {
        public WhiteMidrange()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Thalia, Guardian of Thraben" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Aether Vial" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Stoneforge Mystic" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Leonin Arbiter" } }
            };
        }
    }
}
