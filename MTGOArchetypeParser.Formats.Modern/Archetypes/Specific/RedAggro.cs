using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class RedAggro : ArchetypeSpecific
    {
        public RedAggro()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainboard, Cards = new string[] { "Goblin Guide", "Eidolon of the Great Revel", "Monastery Swiftspear", "Soul-Scar Mage", "Abbot of Keral Keep", "Kiln Fiend", "Stormwing Entity", "Sprite Dragon" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Lightning Bolt" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Kird Ape" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Death's Shadow" } },
            };
            Variants = new ArchetypeVariant[]
            {
                new Burn(),
                new Prowess(),
                new OboshAggro()
            };
        }
    }

    public class Burn : ArchetypeVariant
    {
        public Burn()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Goblin Guide", "Eidolon of the Great Revel" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainboard, Cards = new string[] { "Rift Bolt", "Skewer the Critics", "Lightning Helix", "Boros Charm", "Skullcrack", "Searing Blaze", "Atarka's Command" } },
            };
        }
    }

    public class Prowess : ArchetypeVariant
    {
        public Prowess()
        {
            IncludeColorInName = true;
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Soul-Scar Mage", "Abbot of Keral Keep", "Kiln Fiend", "Stormwing Entity", "Nivmagus Elemental" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContainMainboard, Cards = new string[] { "Eidolon of the Great Revel" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Obosh, the Preypiercer" } },
            };
        }
    }

    public class OboshAggro : ArchetypeVariant
    {
        public OboshAggro()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Seasoned Pyromancer", "Bomat Courier" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InSideboard, Cards = new string[] { "Obosh, the Preypiercer" } },
            };
        }
    }

}
