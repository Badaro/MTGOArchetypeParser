using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class SaheeliCombo : ArchetypeSpecific
    {
        public SaheeliCombo()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Saheeli Rai" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Felidar Guardian" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Pillar of the Paruns" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Kaya's Guile" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new SaheeliToLight(),
                new SnowSaheeli(),
                new OmnathSaheeli()
            };
        }
    }

    public class SaheeliToLight : ArchetypeVariant
    {
        public SaheeliToLight()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Oath of Nissa" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Bring to Light" } }
            };
        }
    }

    public class SnowSaheeli : ArchetypeVariant
    {
        public SnowSaheeli()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Ice-Fang Coatl" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Omnath, Locus of Creation" } }
            };
        }
    }

    public class OmnathSaheeli : ArchetypeVariant
    {
        public OmnathSaheeli()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Omnath, Locus of Creation" } }
            };
        }
    }
}
