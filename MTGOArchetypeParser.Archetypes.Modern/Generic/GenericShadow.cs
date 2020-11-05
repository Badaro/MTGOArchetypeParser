using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class GenericShadow : ArchetypeGeneric
    {
        public GenericShadow()
        {
            IncludeColorInName = true;
            CommonCards = new string[]
            {
                "Death's Shadow",
                "Tarmogoyf",
                "Gurmag Angler",
                "Thoughtseize",
                "Temur Battle Rage",
                "Street Wraith",
                "Dismember",
                "Mutagenic Growth",
                "Traverse the Ulvenwald",
                "Stubborn Denial"
            };
            RequiredCards = new string[]
            {
                "Death's Shadow"
            };
        }
    }
}
