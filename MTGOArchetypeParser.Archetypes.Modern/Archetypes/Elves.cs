using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Elves : Archetype
    {
        public Elves()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Llanowar Elves" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Elvish Archdruid" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Elvish Clancaller" } },
            };
            Variants = new ArchetypeVariant[]
            {
                new GolgariElves(),
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
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Shaman of the Pack" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Ezuri, Renegade Leader" } }
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
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Craterhoof Behemoth" } }            };
        }
    }
}
