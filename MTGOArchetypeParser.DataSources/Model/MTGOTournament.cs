using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.DataSources.Model
{
    public class MTGOTournament
    {
        public string File { get; set; }
        public MTGOTournamentInfo Tournament { get; set; }
        public MTGODeck[] Decks { get; set; }

        public override string ToString()
        {
            return this.Tournament.Name;
        }
    }
}
