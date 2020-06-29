using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class SnowControl : Archetype
    {
        public SnowControl()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Arcum's Astrolabe" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Ice-Fang Coatl" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Uro, Titan of Nature's Wrath" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOfInMainboard, Cards = new string[] { "Cryptic Command", "Jace, the Mind Sculptor" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Soulherder" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Metallic Rebuke" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new SultaiSnow(),
                new SnowBlade(),
                new SnowReclamation(),
                new SnowTurns(),
                new SnowShift(),
                new SnowTitan()
            };
        }
    }

    public class SultaiSnow : ArchetypeVariant
    {
        public SultaiSnow()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Fatal Push" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOfInMainboard, Cards = new string[] { "Abrupt Decay", "Assassin's Trophy", "Maelstrom Pulse" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOfInMainboard, Cards = new string[] { "Thoughtseize", "Inquisition of Kozilek", "Cling to Dust" } }
            };
        }
    }

    public class SnowShift : ArchetypeVariant
    {
        public SnowShift()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Scapeshift" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Valakut, the Molten Pinnacle" } }
            };
        }
    }

    public class SnowTurns : ArchetypeVariant
    {
        public SnowTurns()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Time Warp" } },
            };
        }
    }

    public class SnowReclamation : ArchetypeVariant
    {
        public SnowReclamation()
        {
            Conditions = new ArchetypeCondition[]
            {
                    new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Wilderness Reclamation" } }
            };
        }
    }

    public class SnowBlade : ArchetypeVariant
    {
        public SnowBlade()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Stoneforge Mystic" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Batterskull" } }
            };
        }
    }

    public class SnowTitan : ArchetypeVariant
    {
        public SnowTitan()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Primeval Titan" } }
            };
        }
    }
}
