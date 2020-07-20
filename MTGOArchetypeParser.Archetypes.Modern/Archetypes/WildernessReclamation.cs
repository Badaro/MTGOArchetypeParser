using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class WildernessReclamation : Archetype
    {
        public WildernessReclamation()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Mystical Teachings", "Expansion // Explosion", "Fact or Fiction" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Wilderness Reclamation" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Nexus of Fate" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContainAll, Cards = new string[] { "Ice-Fang Coatl", "Uro, Titan of Nature's Wrath" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new ReclamationTeachings(),
                new TemurReclamation()
            };
        }
    }

    public class ReclamationTeachings : ArchetypeVariant
    {
        public ReclamationTeachings()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Mystical Teachings" } },
            };
        }
    }

    public class TemurReclamation : ArchetypeVariant
    {
        public TemurReclamation()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Lightning Bolt" } },
            };
        }
    }
}
