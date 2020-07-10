using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class Skelementals : Archetype
    {
        public Skelementals()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Lightning Skelemental" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Unearth" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Liliana of the Veil" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Death's Shadow" } }
            };
        }
    }
}
