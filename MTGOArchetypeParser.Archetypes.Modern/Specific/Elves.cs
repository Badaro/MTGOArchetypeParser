using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Elves : ArchetypeSpecific
    {
        public Elves()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Llanowar Elves" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainboard, Cards = new string[] { "Elvish Archdruid", "Heritage Druid", "Nettle Sentinel", "Elvish Clancaller" } },
            };
            Variants = new ArchetypeVariant[]
            {
                new GolgariElves(),
                new DevotedElves(),
                new ComboElves()
            };
        }
    }

    public class GolgariElves : ArchetypeVariant
    {
        public GolgariElves()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.ColorIsExactly, Color = ArchetypeColor.BG },
            };
        }
    }

    public class DevotedElves : ArchetypeVariant
    {
        public DevotedElves()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Devoted Druid" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Vizier of Remedies" } },
            };
        }
    }

    public class ComboElves : ArchetypeVariant
    {
        public ComboElves()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Beast Whisperer" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Craterhoof Behemoth" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Devoted Druid" } },
            };
        }
    }
}
