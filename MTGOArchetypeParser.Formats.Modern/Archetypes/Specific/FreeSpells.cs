using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class FreeSpells : ArchetypeSpecific
    {
        public FreeSpells()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Electrodominance" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "As Foretold" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.OneOrMoreInMainboard, Cards = new string[] { "Crashing Footfalls", "Restore Balance", "Living End" } }
            };
            Variants = new ArchetypeVariant[]
            {
                new ElectroBalance(),
                new ElectroEnd(),
            };
        }
    }

    public class ElectroBalance : ArchetypeVariant
    {
        public ElectroBalance()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Ancestral Vision" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Restore Balance" } }
            };
        }
    }

    public class ElectroEnd : ArchetypeVariant
    {
        public ElectroEnd()
        {
            Conditions = new ArchetypeCondition[]
            {
                new ArchetypeCondition() { Type = ArchetypeConditionType.InMainboard, Cards = new string[] { "Living End" } },
                new ArchetypeCondition() { Type = ArchetypeConditionType.TwoOrMoreInMainboard, Cards = new string[] { "Striped Riverwinder","Street Wraith", "Desert Cerodon" , "Waker of Waves" } },
            };
        }
    }

}
