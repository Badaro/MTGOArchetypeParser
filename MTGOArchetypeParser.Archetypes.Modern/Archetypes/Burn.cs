using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Burn : Archetype
    {
        public Burn()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainboard, Cards = new string[] { "Goblin Guide", "Monastery Swiftspear", "Vexing Devil", "Eidolon of the Great Revel" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Lightning Bolt" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Lava Spike" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainboard, Cards = new string[] { "Rift Bolt", "Skewer the Critics", "Lightning Helix", "Boros Charm", "Skullcrack" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new IncineratorBurn()
            };
        }
    }

    public class IncineratorBurn : ArchetypeVariant
    {
        public IncineratorBurn()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Chandra's Incinerator" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Seal of Fire" } }
            };
        }
    }
}
