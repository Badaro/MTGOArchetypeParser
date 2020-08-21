using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Data.Model
{
    public class MTGODeckItem
    {
        public int Count { get; set; }
        public string CardName { get; set; }

        public override string ToString()
        {
            return $"{Count} {CardName}";
        }
    }
}
