using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Model
{
    public class ArchetypeResult
    {
        public ArchetypeMatch[] Matches { get; set; }
        public ArchetypeColor Color { get; set; }
        public ArchetypeCompanion? Companion { get; set; }
    }
}
