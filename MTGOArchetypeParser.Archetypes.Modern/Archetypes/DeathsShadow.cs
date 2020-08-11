using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class DeathsShadow : Archetype
    {
        public DeathsShadow()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Death's Shadow" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Thoughtseize" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Street Wraith", "Dismember", "Mutagenic Growth" } },
            };
            Variants = new ArchetypeVariant[]
            {
                new GrixisShadow(),
                new MarduShadow(),
                new EsperShadow(),
                new OrzhovShadow(),
                new TraverseShadow(),
                new SuicideShadow()
            };
        }
    }

    public class GrixisShadow : ArchetypeVariant
    {
        public GrixisShadow()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainOrSideboard, Cards = new string[] { "Stubborn Denial", "Thought Scour" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainOrSideboard, Cards = new string[] { "Kolaghan's Command", "Lightning Bolt" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Traverse the Ulvenwald" } }
            };
        }
    }

    public class MarduShadow : ArchetypeVariant
    {
        public MarduShadow()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainOrSideboard, Cards = new string[] { "Ranger-Captain of Eos", "Tidehollow Sculler", "Path to Exile" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainOrSideboard, Cards = new string[] { "Kolaghan's Command", "Lightning Bolt" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Traverse the Ulvenwald" } }
            };
        }
    }

    public class OrzhovShadow : ArchetypeVariant
    {
        public OrzhovShadow()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainOrSideboard, Cards = new string[] { "Ranger-Captain of Eos", "Tidehollow Sculler", "Path to Exile" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Kolaghan's Command" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Temur Battle Rage" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Lightning Bolt" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Thought Scour" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Traverse the Ulvenwald" } }
            };
        }
    }

    public class EsperShadow : ArchetypeVariant
    {
        public EsperShadow()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainOrSideboard, Cards = new string[] { "Stubborn Denial", "Thought Scour" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainOrSideboard, Cards = new string[] { "Ranger-Captain of Eos", "Tidehollow Sculler", "Path to Exile" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Traverse the Ulvenwald" } }
            };
        }
    }

    public class TraverseShadow : ArchetypeVariant
    {
        public TraverseShadow()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Tarmogoyf" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Traverse the Ulvenwald" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Mutagenic Growth" } }
            };
        }
    }

    public class SuicideShadow : ArchetypeVariant
    {
        public SuicideShadow()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Tarmogoyf" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Mutagenic Growth" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Monastery Swiftspear" } }
            };
        }
    }
}
