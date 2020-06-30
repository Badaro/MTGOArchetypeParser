using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class IzzetControl : Archetype
    {
        public IzzetControl()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Lightning Bolt" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Remand" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Snapcaster Mage" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOfInMainboard, Cards = new string[] { "Thing in the Ice", "Through the Breach" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOfInMainboard, Cards = new string[] { "Cryptic Command", "Archmage's Charm" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOfInMainboard, Cards = new string[] { "Serum Visions", "Opt" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Ice-Fang Coatl" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new IzzetBreach()
            };
        }
    }

    public class IzzetBreach : ArchetypeVariant
    {
        public IzzetBreach()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Emrakul, the Aeons Torn" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Through the Breach" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Ice-Fang Coatl" } }
            };
        }
    }
}
