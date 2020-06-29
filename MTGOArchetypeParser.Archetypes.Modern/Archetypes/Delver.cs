using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Delver : Archetype
    {
        public Delver()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Delver of Secrets" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Lightning Bolt" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOfInMainboard, Cards = new string[] { "Remand", "Mana Leak" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new GrixisDelver()
            };
        }
    }

    public class GrixisDelver : ArchetypeVariant
    {
        public GrixisDelver()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOfInMainboard, Cards = new string[] { "Thoughtseize", "Inquisition of Kozilek" } }
            };
        }
    }

}
