using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Model
{
    public class ArchetypeCondition
    {
        public ArchetypeConditionType Type { get; set; }
        public string[] Cards { get; set; }
    }
}

