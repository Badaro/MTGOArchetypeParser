using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class BantMidrange : Archetype
    {
        public BantMidrange()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Karn, the Great Creator" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Teferi, Time Raveler" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Stoneforge Mystic" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Batterskull" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Kinnan, Bonder Prodigy" } }
            };
        }
    }
}
