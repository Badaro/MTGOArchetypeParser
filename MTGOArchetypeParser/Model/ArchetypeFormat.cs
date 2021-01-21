using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Model
{
    public class ArchetypeFormat
    {
        public Archetype[] Archetypes { get; set; }
        public ArchetypeMeta[] Metas { get; set; }
        public Dictionary<string, ArchetypeColor> Lands { get; set; }
        public Dictionary<string, ArchetypeColor> NonLands { get; set; }
    }
}
