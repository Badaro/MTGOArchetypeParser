using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Tokens : ArchetypeSpecific
    {
        public Tokens()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainboard, Cards = new string[] { "Spectral Procession", "Bitterblossom", "Raise the Alarm", "Lingering Souls" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Sorin, Solemn Visitor", "Intangible Virtue" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Fallen Shinobi" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Smallpox" } },
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
