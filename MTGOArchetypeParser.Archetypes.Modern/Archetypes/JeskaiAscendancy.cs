using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class JeskaiAscendancy : Archetype
    {
        public JeskaiAscendancy()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Jeskai Ascendancy" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Underworld Breach" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Fatestitcher" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new JeskaiBreach()
            };
        }
    }

    public class JeskaiBreach : ArchetypeVariant
    {
        public JeskaiBreach()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Underworld Breach" } },
            };
        }
    }
}
