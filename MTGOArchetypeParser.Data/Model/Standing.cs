using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json;

namespace MTGOArchetypeParser.Data.Model
{
    public class Standing
    {
        [JsonProperty("Rank")]
        public int Rank { get; set; }
        [JsonProperty("Player")]
        public string Player { get; set; }
        [JsonProperty("Points")]
        public int Points { get; set; }

        public override string ToString()
        {
            return $"#{Rank} {Player} {Points} points";
        }
    }
}
