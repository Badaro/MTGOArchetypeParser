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
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Mystical Teachings", "Expansion // Explosion" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Wilderness Reclamation" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Nexus of Fate" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Snapcaster Mage", "Wrenn and Six" } }
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
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Expansion // Explosion" } },
            };
        }
    }
}
