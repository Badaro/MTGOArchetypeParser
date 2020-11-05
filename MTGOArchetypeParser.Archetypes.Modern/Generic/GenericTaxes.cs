﻿using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class GenericTaxes : ArchetypeGeneric
    {
        public GenericTaxes()
        {
            IncludeColorInName = true;
            CommonCards = new string[]
            {
                "Giver of Runes",
                "Brimaz, King of Oreskos",
                "Thalia, Guardian of Thraben",
                "Aether Vial",
                "Leonin Arbiter",
                "Charming Prince",
                "Flickerwisp",
                "Eldrazi Displacer",
                "Thought-Knot Seer",
                "Serra Avenger"
            };
        }
    }
}
