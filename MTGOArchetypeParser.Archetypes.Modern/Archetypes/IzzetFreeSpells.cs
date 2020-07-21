using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class IzzetFreeSpells : Archetype
    {
        public IzzetFreeSpells()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Electrodominance" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "As Foretold" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Crashing Footfalls", "Restore Balance", "Living End" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new IzzetRestoreBalance(),
                new IzzetLivingEnd(),
            };
        }
    }

    public class IzzetRestoreBalance : ArchetypeVariant
    {
        public IzzetRestoreBalance()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Ancestral Vision" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Restore Balance" } }
            };
        }
    }

    public class IzzetLivingEnd : ArchetypeVariant
    {
        public IzzetLivingEnd()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Living End" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainboard, Cards = new string[] { "Striped Riverwinder","Street Wraith", "Desert Cerodon" , "Waker of Waves" } },
            };
        }
    }

}
