using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Merfolk : ArchetypeSpecific
    {
        public Merfolk()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Lord of Atlantis" ,"Master of the Pearl Trident", "Merrow Reejerey" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Merfolk Trickster", "Silvergill Adept" } }
            };
        }
    }
}
