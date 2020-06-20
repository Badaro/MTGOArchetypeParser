using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Model
{
    public class ArchetypeResult
    {
        public Archetype Archetype { get; set; }
        public Archetype Variant { get; set; }
        public ArchetypeCompanion? Companion { get; set; }
    }
}
