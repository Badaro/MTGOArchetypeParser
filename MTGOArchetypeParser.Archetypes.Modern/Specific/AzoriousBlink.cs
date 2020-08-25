using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class AzoriousBlink : ArchetypeSpecific
    {
        public AzoriousBlink()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Spreading Seas" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Wall of Omens" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Yorion, Sky Nomad" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Restoration Angel" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.DoesNotContain, Cards = new string[] { "Jolrael, Mwonvuli Recluse" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new JeskaiBlink()
            };
        }
    }

    public class JeskaiBlink : ArchetypeVariant
    {
        public JeskaiBlink()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Lightning Bolt" } },
            };
        }
    }
}