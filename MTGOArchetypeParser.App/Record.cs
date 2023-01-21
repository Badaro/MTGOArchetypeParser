using MTGOArchetypeParser.Data.Model;
using System;

namespace MTGOArchetypeParser.App
{
    public class Record
    {
        public string TournamentFile { get; set; }
        public string Tournament { get; set; }
        public string Meta { get; set; }
        public int Week { get; set; }
        public DateTime Date { get; set; }
        public string Result { get; set; }
        public string Points { get; set; }
        public string Player { get; set; }
        public Uri AnchorUri { get; set; }
        public RecordArchetype Archetype { get; set; }
        public RecordArchetype ReferenceArchetype { get; set; }
        public DeckItem[] Mainboard { get; set; }
        public DeckItem[] Sideboard { get; set; }
        public RecordMatchup[] Matchups { get; set; }
    }
}
