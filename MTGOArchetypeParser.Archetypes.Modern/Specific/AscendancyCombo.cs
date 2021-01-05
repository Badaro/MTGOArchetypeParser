using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class AscendancyCombo : ArchetypeSpecific
    {
        public AscendancyCombo()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Jeskai Ascendancy" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Fatestitcher" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new AscendancyBreach()
            };
        }
    }

    public class AscendancyBreach : ArchetypeVariant
    {
        public AscendancyBreach()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Underworld Breach" } },
            };
        }
    }
}
