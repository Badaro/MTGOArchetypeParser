using MTGOArchetypeParser.Data.Model;
using System;

namespace MTGOArchetypeParser.Reports.App
{
    public class DataRecord
    {
        public string Tournament { get; set; }
        public string Meta { get; set; }
        public int Week { get; set; }
        public DateTime Date { get; set; }
        public string Result { get; set; }
        public string Player { get; set; }
        public Uri AnchorUri { get; set; }
        public string Archetype { get; set; }
        public string Color { get; set; }
        public string Companion { get; set; }
        public Deck Deck { get; set; }
    }
}
