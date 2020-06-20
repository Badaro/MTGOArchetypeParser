using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class GTron : Archetype
    {
        public GTron()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Urza's Tower" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Urza's Mine" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Urza's Power Plant" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Karn Liberated" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOfInMainboard, Cards = new string[] { "Forest", "Snow-Covered Forest" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Expedition Map" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Ancient Stirrings" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Sylvan Scrying" } },
            };
            Variants = new ArchetypeVariant[]
            {
                new KGCTron()
            };
        }
    }

    public class KGCTron : ArchetypeVariant
    {
        public KGCTron()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Karn, the Great Creator" } }
            };
        }
    }
}
