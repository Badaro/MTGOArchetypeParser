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
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Leonin Arbiter" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOfInMainOrSideboard, Cards = new string[] { "Thalia, Guardian of Thraben", "Spirit of the Labyrinth" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Path to Exile" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new EldraziTaxes(),
                new CatsAndTaxes()
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

    public class CatsAndTaxes : ArchetypeVariant
    {
        public CatsAndTaxes()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Brimaz, King of Oreskos" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Pride Sovereign" } },
            };
        }
    }
}
