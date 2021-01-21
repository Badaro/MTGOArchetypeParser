using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class GenericBlink : ArchetypeGeneric
    {
        public GenericBlink()
        {
            IncludeColorInName = true;
            CommonCards = new string[]
            {
                "Yorion, Sky Nomad",
                "Soulherder",
                "Ephemerate",
                "Knight of Autumn",
                "Ice-Fang Coatl",
                "Coiling Oracle",
                "Wall of Omens",
                "Wall of Blossoms",
                "Eternal Witness",
                "Watcher for Tomorrow",
                "Fblthp, the Lost",
                "Spreading Seas",
                "Deputy of Detention",
                "Restoration Angel",
                "Vedalken Plotter",
                "Charming Prince"
            };
        }
    }
}
