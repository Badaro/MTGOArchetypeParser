using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class EightWhack : Archetype
    {
        public EightWhack()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Goblin Guide" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Goblin Bushwhacker", "Reckless Bushwhacker" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new AtarkaWhack()
            };
        }
    }

    public class AtarkaWhack : ArchetypeVariant
    {
        public AtarkaWhack()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Atarka's Command" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Burning-Tree Emissary" } }
            };
        }
    }
}
