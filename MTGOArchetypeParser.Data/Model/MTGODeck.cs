using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MTGOArchetypeParser.Data.Model
{
    public class MTGODeck
    {
        public DateTime Date { get; set; }
        public string Player { get; set; }
        public Uri AnchorUri { get; set; }
        public MTGODeckItem[] Mainboard { get; set; }
        public MTGODeckItem[] Sideboard { get; set; }

        public bool Contains(params string[] cards)
        {
            return cards.All(c => Mainboard.Any(i => i.CardName == c) || Sideboard.Any(i => i.CardName == c));
        }

        public override string ToString()
        {
            var total = Mainboard.Select(c => c.Count).Sum() + Sideboard.Select(c => c.Count).Sum();
            return $"{total} cards";
        }
    }
}
