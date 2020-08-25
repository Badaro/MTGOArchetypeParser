using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class BantBlink : ArchetypeSpecific
    {
        public BantBlink()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainOrSideboard, Cards = new string[] { "Yorion, Sky Nomad", "Soulherder", "Ephemerate", "Restoration Angel", "Flickerwisp" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainOrSideboard, Cards = new string[] { "Knight of Autumn", "Ice-Fang Coatl", "Coiling Oracle", "Wall of Omens", "Wall of Blossoms", "Eternal Witness", "Watcher for Tomorrow", "Fblthp, the Lost" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Emeria, the Sky Ruin" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Leonin Arbiter" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Metallic Rebuke" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Kiki-Jiki, Mirror Breaker" } }
            };
        }
    }
}
