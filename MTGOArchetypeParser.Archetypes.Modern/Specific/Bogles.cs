using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Bogles : ArchetypeSpecific
    {
        public Bogles()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Kor Spiritdancer", "Gladecover Scout", "Silhana Ledgewalker" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Slippery Bogle" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Daybreak Coronet" } }
            };
        }
    }
}
