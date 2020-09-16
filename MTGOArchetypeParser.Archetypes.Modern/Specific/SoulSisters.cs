using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class SoulSisters : ArchetypeSpecific
    {
        public SoulSisters()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Soul Warden" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Soul's Attendant" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Martyr of Sands" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new HeliodSisters()
            };
        }
    }

    public class HeliodSisters : ArchetypeVariant
    {
        public HeliodSisters()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Heliod, Sun-Crowned" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Walking Ballista" } }
            };
        }
    }
}
