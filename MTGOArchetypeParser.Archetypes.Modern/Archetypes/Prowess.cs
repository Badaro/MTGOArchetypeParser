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
                new GruulProwess(),
                new JundProwess()
            };
        }
    }

    public class RakdosProwess : ArchetypeVariant
    {
        public RakdosProwess()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.ColorMustInclude, Color = ArchetypeColor.BR },
                new ArchetypeCondition() { Type = ArchetypeConditionType.ColorDoesNotInclude, Color = ArchetypeColor.G },
            };
        }
    }

    public class IzzetProwess : ArchetypeVariant
    {
        public IzzetProwess()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.ColorIsExactly, Color = ArchetypeColor.UR },
            };
        }
    }

    public class JeskaiProwess : ArchetypeVariant
    {
        public JeskaiProwess()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.ColorIsExactly, Color = ArchetypeColor.WUR },
            };
        }
    }

    public class GruulProwess : ArchetypeVariant
    {
        public GruulProwess()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.ColorIsExactly, Color = ArchetypeColor.RG },
            };
        }
    }

    public class JundProwess : ArchetypeVariant
    {
        public JundProwess()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.ColorIsExactly, Color = ArchetypeColor.BRG },
            };
        }
    }

}
