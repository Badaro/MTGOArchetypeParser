using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class DeathAndTaxes : Archetype
    {
        public DeathAndTaxes()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Aether Vial" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Leonin Arbiter" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Thalia, Guardian of Thraben" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Path to Exile" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new EldraziTaxes()
            };
        }
    }

    public class EldraziTaxes : ArchetypeVariant
    {
        public EldraziTaxes()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Eldrazi Temple" } },
            };
        }
    }
}
