using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class BantBlink : Archetype
    {
        public BantBlink()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Yorion, Sky Nomad", "Soulherder", "Ephemerate", "Venser, Shaper Savant" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Knight of Autumn", "Coiling Oracle", "Wall of Omens" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Emeria, the Sky Ruin" } }
            };
        }
    }
}
