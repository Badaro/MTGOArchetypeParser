using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class GenericMidrange : ArchetypeGeneric
    {
        public GenericMidrange()
        {
            IncludeColorInName = true;
            CommonCards = new string[]
            {
                "Bloodbraid Elf",
                "Scavenging Ooze",
                "Noble Hierarch",
                "Birds of Paradise",
                "Arbor Elf",
                "Thoughtseize",
                "Inquisition of Kozilek",
                "Kroxa, Titan of Death's Hunger",
                "Seasoned Pyromancer",
                "Tarmogoyf",
                "Wrenn and Six",
                "Dark Confidant",
                "Liliana of the Veil",
                "Stoneforge Mystic",
                "Brazen Borrower",
                "Spell Queller",
                "Karn, the Great Creator",
                "Geist of Saint Traft"
            };
        }
    }
}
