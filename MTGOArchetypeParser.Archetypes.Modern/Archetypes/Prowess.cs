using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Prowess : Archetype
    {
        public Prowess()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainboard, Cards = new string[] { "Monastery Swiftspear", "Soul-Scar Mage", "Stormwing Entity", "Delver of Secrets" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainboard, Cards = new string[] { "Manamorphose", "Mishra's Bauble", "Lava Dart", "Gut Shot" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Lightning Bolt" } },
            };
            Variants = new ArchetypeVariant[]
            {
                new RakdosProwess(),
                new IzzetProwess(),
                new JeskaiProwess(),
            };
        }
    }

    public class RakdosProwess : ArchetypeVariant
    {
        public RakdosProwess()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainOrSideboard, Cards = new string[] { "Thoughtseize" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Cling to Dust" } }
            };
        }
    }

    public class IzzetProwess : ArchetypeVariant
    {
        public IzzetProwess()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Sprite Dragon" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Stormwing Entity" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Lightning Helix" } }
            };
        }
    }

    public class JeskaiProwess : ArchetypeVariant
    {
        public JeskaiProwess()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Sprite Dragon" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Stormwing Entity" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Lightning Helix" } }
            };
        }
    }
}
