using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Model
{
    public class Archetype
    {
        public ArchetypeCondition[] Conditions { get; set; }
        public ArchetypeVariant[] Variants { get; set; }
    }
}
