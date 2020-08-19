using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.DataSources.Model
{
    public class CacheItem
    {
        public Tournament Tournament { get; set; }
        public Deck[] Decks { get; set; }

        public override string ToString()
        {
            return this.Tournament.Name;
        }
    }
}
