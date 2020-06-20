using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Ponza : Archetype
    {
        public Ponza()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Arbor Elf" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Utopia Sprawl" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Lightning Bolt" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Klothys, God of Destiny" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOfInMainOrSideboard, Cards = new string[] { "Magus of the Moon", "Blood Moon" } }
            };
        }
    }
}
