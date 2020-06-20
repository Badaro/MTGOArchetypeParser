using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class DeathsShadow : Archetype
    {
        public DeathsShadow()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Death's Shadow" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Thoughtseize" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new GrixisShadow(),
                new TraverseShadow()
            };
        }
    }

    public class GrixisShadow : ArchetypeVariant
    {
        public GrixisShadow()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Stubborn Denial" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Snapcaster Mage" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Traverse the Ulvenwald" } }
            };
        }
    }

    public class TraverseShadow : ArchetypeVariant
    {
        public TraverseShadow()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Tarmogoyf" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Traverse the Ulvenwald" } }
            };
        }
    }
}
