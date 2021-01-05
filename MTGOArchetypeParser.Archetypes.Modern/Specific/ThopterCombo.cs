﻿using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class ThopterCombo : ArchetypeSpecific
    {
        public ThopterCombo()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Mishra's Bauble", "Witching Well" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Sword of the Meek" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Thopter Foundry" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Uro, Titan of Nature's Wrath" } },
            };
            Variants = new ArchetypeVariant[]
            {
                new ThopterUrza(),
                new Lantern()
            };
        }
    }

    public class ThopterUrza : ArchetypeVariant
    {
        public ThopterUrza()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Urza, Lord High Artificer" } },
            };
        }
    }

    public class Lantern : ArchetypeVariant
    {
        public Lantern()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Lantern of Insight" } },
            };
        }
    }
}