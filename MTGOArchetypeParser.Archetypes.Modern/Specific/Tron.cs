using MTGOArchetypeParser.Model;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Tron : ArchetypeSpecific
    {
        public Tron()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Urza's Tower" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Urza's Mine" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Urza's Power Plant" } },
            };
            Variants = new ArchetypeVariant[]
            {
                new GreenTron(),
                new BlueTron(),
                new EldraziTron(),
                new DiceFactoryTron()
            };
        }
    }

    public class GreenTron : ArchetypeVariant
    {
        public GreenTron()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Forest", "Snow-Covered Forest" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Expedition Map" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Ancient Stirrings" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Sylvan Scrying" } }
            };
        }
    }

    public class EldraziTron : ArchetypeVariant
    {
        public EldraziTron()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Eldrazi Temple" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Thought-Knot Seer" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Reality Smasher", "Oblivion Sower" } }
            };
        }
    }

    public class BlueTron : ArchetypeVariant
    {
        public BlueTron()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Academy Ruins" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Condescend" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Remand" } }
            };
        }
    }

    public class DiceFactoryTron : ArchetypeVariant
    {
        public DiceFactoryTron()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Urza's Tower" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Urza's Mine" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Urza's Power Plant" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Expedition Map" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Coretapper" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Astral Cornucopia" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Everflowing Chalice" } }
            };
        }
    }

}
