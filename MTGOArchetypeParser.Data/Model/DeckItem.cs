using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Data.Model
{
    public class DeckItem
    {
        [JsonProperty("Count")]
        public int Count { get; set; }
        [JsonProperty("CardName")]
        public string Card { get; set; }

        public override string ToString()
        {
            return $"{Count} {Card}";
        }
    }
}
