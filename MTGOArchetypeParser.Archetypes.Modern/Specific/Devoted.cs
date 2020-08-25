using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Devoted : ArchetypeSpecific
    {
        public Devoted()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Devoted Druid" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Vizier of Remedies" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Walking Ballista" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new HeliodDevoted(),
                new KinnanDevoted()
            };
        }
    }

    public class HeliodDevoted : ArchetypeVariant
    {
        public HeliodDevoted()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Heliod, Sun-Crowned" } }
            };
        }
    }

    public class KinnanDevoted : ArchetypeVariant
    {
        public KinnanDevoted()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Kinnan, Bonder Prodigy" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Freed from the Real" } }
            };
        }
    }
}
