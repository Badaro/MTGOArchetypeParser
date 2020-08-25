using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Model
{
    public abstract class Archetype
    {
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    public class ArchetypeSpecific : Archetype
    {
        public ArchetypeCondition[] Conditions { get; set; }
        public ArchetypeVariant[] Variants { get; set; }
    }

    public class ArchetypeVariant : ArchetypeSpecific
    {
    }

    public class ArchetypeGeneric : Archetype
    {
        public string[] CommonCards { get; set; }
    }

}
