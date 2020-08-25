using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class LivingEnd : ArchetypeSpecific
    {
        public LivingEnd()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Living End" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Street Wraith" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Ardent Plea", "Violent Outburst" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new BlueLivingEnd()
            };
        }
    }

    public class BlueLivingEnd : ArchetypeVariant
    {
        public BlueLivingEnd()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.ColorMustInclude, Color = ArchetypeColor.U },
            };
        }
    }
}
