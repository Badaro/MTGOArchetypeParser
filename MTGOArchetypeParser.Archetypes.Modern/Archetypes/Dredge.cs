using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Dredge : Archetype
    {
        public Dredge()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Stinkweed Imp" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Life from the Loam" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOfInMainboard, Cards = new string[] { "Bloodghast", "Silversmote Ghoul" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Prized Amalgam" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Narcomoeba" } }
            };
        }
    }
}
