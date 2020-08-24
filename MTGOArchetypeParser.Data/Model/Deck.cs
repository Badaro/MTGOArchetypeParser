using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using System.IO;

namespace MTGOArchetypeParser.Data.Model
{
    public class Deck
    {
        [JsonProperty("Date")]
        public DateTime? Date { get; set; }
        [JsonProperty("Player")]
        public string Player { get; set; }
        [JsonProperty("AnchorUri")]
        public Uri AnchorUri { get; set; }
        [JsonProperty("Mainboard")]
        public DeckItem[] Mainboard { get; set; }
        [JsonProperty("Sideboard")]
        public DeckItem[] Sideboard { get; set; }

        public bool Contains(params string[] cards)
        {
            return cards.All(c => Mainboard.Any(i => i.Card == c) || Sideboard.Any(i => i.Card == c));
        }

        public override string ToString()
        {
            var total = Mainboard.Select(c => c.Count).Sum() + Sideboard.Select(c => c.Count).Sum();
            return $"{Path.GetFileNameWithoutExtension(AnchorUri.LocalPath)} {Player}";
        }
    }
}
