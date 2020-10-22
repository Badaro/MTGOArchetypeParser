using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class BorosLandDestruction : ArchetypeSpecific
    {
        public BorosLandDestruction()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Boom // Bust" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Pillage"} },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Cleansing Wildfire", "Molten Rain", "Stone Rain" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Chandra, Torch of Defiance", "Karn, the Great Creator", "Nahiri, the Harbinger", "Goblin Dark-Dwellers" } }
            };
        }
    }
}
