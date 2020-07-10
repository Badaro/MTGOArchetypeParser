using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class DimirControl : Archetype
    {
        public DimirControl()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Fatal Push" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Drown in the Loch" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Snapcaster Mage" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Force of Negation" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOfInMainboard, Cards = new string[] { "Cryptic Command", "Archmage's Charm" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Ice-Fang Coatl" } }
            };
        }
    }

}
