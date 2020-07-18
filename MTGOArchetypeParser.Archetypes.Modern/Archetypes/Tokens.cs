using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Tokens : Archetype
    {
        public Tokens()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainboard, Cards = new string[] { "Spectral Procession", "Bitterblossom", "Raise the Alarm", "Lingering Souls" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new OrzhovTokens()
            };
        }
    }

    public class OrzhovTokens : ArchetypeVariant
    {
        public OrzhovTokens()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Lingering Souls" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Sorin, Solemn Visitor" } }
            };
        }
    }
}
