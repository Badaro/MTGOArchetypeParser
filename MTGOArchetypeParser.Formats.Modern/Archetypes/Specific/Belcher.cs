using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Belcher : ArchetypeSpecific
    {
        public Belcher()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Goblin Charbelcher" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainboard, Cards = new string[] { "Simian Spirit Guide", "Irencrag Feat", "Chancellor of the Tangle", "Desperate Ritual", "Pyretic Ritual" } },
            };
        }
    }
}
