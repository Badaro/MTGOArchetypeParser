using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Delver : ArchetypeSpecific
    {
        public Delver()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Delver of Secrets" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Lightning Bolt" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainboard, Cards = new string[] { "Vapor Snag", "Remand", "Mana Leak", "Force of Negation", "Archmage's Charm", "Stubborn Denial" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new GrixisDelver(),
                new TemurDelver(),
                new JeskaiDelver()
            };
        }
    }

    public class GrixisDelver : ArchetypeVariant
    {
        public GrixisDelver()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.ColorIsExactly, Color = ArchetypeColor.UBR },
            };
        }
    }

    public class TemurDelver : ArchetypeVariant
    {
        public TemurDelver()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.ColorIsExactly, Color = ArchetypeColor.URG },
            };
        }
    }

    public class JeskaiDelver : ArchetypeVariant
    {
        public JeskaiDelver()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.ColorIsExactly, Color = ArchetypeColor.WUR },
            };
        }
    }
}
