using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MTGOArchetypeParser.Data.Model
{
    public class TournamentInfo
    {
        [JsonProperty("Date")]
        public DateTime Date { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Uri")]
        public Uri Uri { get; set; }
        public override string ToString()
        {
            return Path.GetFileNameWithoutExtension(Uri.LocalPath);
        }
    }
}
