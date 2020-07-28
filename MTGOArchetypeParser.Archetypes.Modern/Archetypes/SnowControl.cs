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
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainOrSideboard, Cards = new string[] { "Ice-Fang Coatl", "Uro, Titan of Nature's Wrath", "Dead of Winter", "On Thin Ice", "Blood Moon" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Cryptic Command", "Jace, the Mind Sculptor", "Teferi, Hero of Dominaria" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Soulherder" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Saheeli Rai" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Metallic Rebuke" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new SultaiSnow(),
                new TemurSnow(),
                new SnowBlade(),
                new SnowReclamation(),
                new SnowTurns(),
                new SnowShift(),
                new SnowTitan(),
                new SnowBreach()
            };
        }
    }

    public class SultaiSnow : ArchetypeVariant
    {
        public SultaiSnow()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainOrSideboard, Cards = new string[] { "Fatal Push" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainOrSideboard, Cards = new string[] { "Abrupt Decay", "Assassin's Trophy", "Maelstrom Pulse" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainOrSideboard, Cards = new string[] { "Thoughtseize", "Inquisition of Kozilek", "Collective Brutality", "Cling to Dust", "Dead of Winter" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Path to Exile" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Teferi, Time Raveler" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Dovin's Veto" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Wilderness Reclamation" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Scapeshift" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Time Warp" } }
            };
        }
    }

    public class TemurSnow : ArchetypeVariant
    {
        public TemurSnow()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Lightning Bolt" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Wrenn and Six", "Seasoned Pyromancer", "Blood Moon" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Path to Exile" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Wilderness Reclamation" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Scapeshift" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Time Warp" } },
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

    public class SnowBreach : ArchetypeVariant
    {
        public SnowBreach()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Emrakul, the Aeons Torn" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Through the Breach" } }
            };
        }
    }
}
