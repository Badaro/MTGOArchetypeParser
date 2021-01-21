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
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainboard, Cards = new string[] { "Time Warp", "Temporal Mastery", "Savor the Moment", "Exhaustion", "Walk the Aeons",  } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Cryptic Command" , "Remand", "Howling Mine" } },
            };
        }
    }
}
