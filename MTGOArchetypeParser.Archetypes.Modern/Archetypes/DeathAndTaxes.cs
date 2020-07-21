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
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Leonin Arbiter", "Thalia, Guardian of Thraben", "Chalice of the Void", } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Leonin Arbiter", "Eldrazi Displacer", "Restoration Angel", "Charming Prince" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainOrSideboard, Cards = new string[] { "Path to Exile", "Dismember" } },
            };
            Variants = new ArchetypeVariant[]
            {
                new EldraziTaxes(),
                new CatsAndTaxes(),
                new ThaliaStompy(),
                new ThaliaStoneblade()
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
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Leonin Arbiter" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Chalice of the Void" } },
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
    public class ThaliaStompy : ArchetypeVariant
    {
        public ThaliaStompy()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Thalia, Guardian of Thraben" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Chalice of the Void" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Simian Spirit Guide" } }
            };
        }
    }

    public class ThaliaStoneblade : ArchetypeVariant
    {
        public ThaliaStoneblade()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Thalia, Guardian of Thraben" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Stoneforge Mystic" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Leonin Arbiter" } }
            };
        }
    }
}
