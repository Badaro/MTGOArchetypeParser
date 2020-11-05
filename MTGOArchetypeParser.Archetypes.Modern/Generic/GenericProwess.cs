using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class GenericProwess : ArchetypeGeneric
    {
        public GenericProwess()
        {
            IncludeColorInName = true;
            CommonCards = new string[]
            {
                "Monastery Swiftspear",
                "Soul-Scar Mage",
                "Abbot of Keral Keep",
                "Stormwing Entity",
                "Manamorphose",
                "Mishra's Bauble",
                "Lurrus of the Dream-Den",
                "Bedlam Reveler",
                "Gut Shot",
                "Light Up the Stage"
            };
        }
    }
}
