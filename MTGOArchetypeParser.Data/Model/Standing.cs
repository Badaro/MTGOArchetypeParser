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
        [JsonProperty("Wins")]
        public int Wins { get; set; }
        [JsonProperty("Losses")]
        public int Losses { get; set; }
        [JsonProperty("Draws")]
        public int Draws { get; set; }

        public override string ToString()
        {
            return $"#{Rank} {Player} {Points} points {Wins}-{Losses}-{Draws}";
        }
    }
}
