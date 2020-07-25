using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class AzoriusControl : Archetype
    {
        public AzoriusControl()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Cryptic Command" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Path to Exile" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Jace, the Mind Sculptor" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainOrSideboard, Cards = new string[] { "Celestial Colonnade", "Teferi, Hero of Dominaria", "Entreat the Angels", "Shark Typhoon", "Timely Reinforcements" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Ice-Fang Coatl" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Lightning Bolt" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new Miracles()
            };
        }
    }

    public class Miracles : ArchetypeVariant
    {
        public Miracles()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Terminus" } },
            };
        }
    }
}
