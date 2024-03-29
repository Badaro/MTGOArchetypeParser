﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MTGOArchetypeParser.Data.Model
{
    public class Tournament
    {
        public string File { get; set; }
        [JsonProperty("Tournament")]
        public TournamentInfo Information { get; set; }
        [JsonProperty("Decks")]
        public Deck[] Decks { get; set; }
        [JsonProperty("Standings")]
        public Standing[] Standings { get; set; }
        [JsonProperty("Rounds")]
        public Round[] Rounds{ get; set; }
        public string JsonFile { get; set; }

        public override string ToString()
        {
            return Path.GetFileNameWithoutExtension(this.JsonFile);
        }
    }
}
