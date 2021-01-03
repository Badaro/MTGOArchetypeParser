using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class KinnanLegends : ArchetypeSpecific
    {
        public KinnanLegends()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainboard, Cards = new string[] {  "Karn, the Great Creator", "Emry, Lurker of the Loch" , "Urza, Lord High Artificer", "Uro, Titan of Nature's Wrath", "Omnath, Locus of Creation" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Mox Amber" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Kinnan, Bonder Prodigy" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Grinding Station" } },
            };
        }
    }
}
