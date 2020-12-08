using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Zoo : ArchetypeSpecific
    {
        public Zoo()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Goblin Guide" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Atarka's Command" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainboard, Cards = new string[] { "Goblin Bushwhacker", "Reckless Bushwhacker", "Burning-Tree Emissary", "Wild Nacatl" , "Pelt Collector" } },
            };
            Variants = new ArchetypeVariant[]
            {
                new BushwhackerZoo()
            };
        }
    }

    public class BushwhackerZoo : ArchetypeVariant
    {
        public BushwhackerZoo()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainboard, Cards = new string[] { "Goblin Bushwhacker", "Reckless Bushwhacker", "Burning-Tree Emissary" } },
            };
        }
    }
}
