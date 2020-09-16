using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class GTron : ArchetypeSpecific
    {
        public GTron()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Urza's Tower" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Urza's Mine" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Urza's Power Plant" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Forest", "Snow-Covered Forest" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Expedition Map" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Ancient Stirrings" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Sylvan Scrying" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new KGCTron(),
                new GolosTron(),
                new GreenEldraziTron(),
                new OrreryTron()
            };
        }
    }

    public class GreenEldraziTron : ArchetypeVariant
    {
        public GreenEldraziTron()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Eldrazi Temple" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Thought-Knot Seer" } }
            };
        }
    }

    public class KGCTron : ArchetypeVariant
    {
        public KGCTron()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Karn, the Great Creator" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Golos, Tireless Pilgrim" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Filigree Sages" } }
            };
        }
    }

    public class GolosTron : ArchetypeVariant
    {
        public GolosTron()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Cascading Cataracts" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Golos, Tireless Pilgrim" } }
            };
        }
    }

    public class OrreryTron : ArchetypeVariant
    {
        public OrreryTron()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Chromatic Orrery" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Filigree Sages" } }
            };
        }
    }
}
