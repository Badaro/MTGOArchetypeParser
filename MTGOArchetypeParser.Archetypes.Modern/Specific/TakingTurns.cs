using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class TakingTurns : ArchetypeSpecific
    {
        public TakingTurns()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Time Warp", "Temporal Mastery", "Savor the Moment", "Exhaustion", "Walk the Aeons",  } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Cryptic Command" , "Remand"} },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Coiling Oracle", "Remand"} },
            };
            Variants = new ArchetypeVariant[]
            {
                new FiresTurns()
            };
        }
    }

    public class FiresTurns : ArchetypeVariant
    {
        public FiresTurns()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Fires of Invention" } }
            };
        }
    }
}
