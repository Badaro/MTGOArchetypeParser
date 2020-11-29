using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class OboshAggro : ArchetypeSpecific
    {
        public OboshAggro()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Monastery Swiftspear" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Soul-Scar Mage" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Seasoned Pyromancer", "Bomat Courier" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InSideboard, Cards = new string[] { "Obosh, the Preypiercer" } },
            };
        }
    }
}
