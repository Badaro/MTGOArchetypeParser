using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class NivToLight : ArchetypeSpecific
    {
        public NivToLight()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Niv-Mizzet Reborn" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Bring to Light" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainOrSideboard, Cards = new string[] { "Lightning Helix" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Assassin's Trophy", "Abrupt Decay" } }
            };
        }
    }
}
