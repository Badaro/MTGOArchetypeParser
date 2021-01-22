using MTGOArchetypeParser.Data.Model;
using System;
using System.Diagnostics.CodeAnalysis;

namespace MTGOArchetypeParser.App
{
    public class RecordArchetype : IEquatable<RecordArchetype>
    {
        public string Archetype { get; set; }
        public string Color { get; set; }
        public string Companion { get; set; }
        public bool Equals([AllowNull] RecordArchetype other)
        {
            return
                this.Archetype == other.Archetype &&
                this.Color == other.Color &&
                this.Companion == other.Companion;
        }
    }

}
