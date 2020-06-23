using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Data
{
    // Should have most relevant lands as far as color-detection goes
    // Does not include fetches and canopies since they are used too often off-color

    internal class ArchetypeLands
    {
        public static readonly Dictionary<string, ArchetypeColor> Lands = new Dictionary<string, ArchetypeColor>()
        {
            // Basic
            { "Plains", ArchetypeColor.W },
            { "Island", ArchetypeColor.U },
            { "Swamp", ArchetypeColor.B },
            { "Mountain", ArchetypeColor.R },
            { "Forest", ArchetypeColor.G },

            // Snow Basic
            { "Snow-Covered Plains", ArchetypeColor.W },
            { "Snow-Covered Island", ArchetypeColor.U },
            { "Snow-Covered Swamp", ArchetypeColor.B },
            { "Snow-Covered Mountain", ArchetypeColor.R },
            { "Snow-Covered Forest", ArchetypeColor.G },

            // Shock
            { "Hallowed Fountain", ArchetypeColor.WU },
            { "Godless Shrine", ArchetypeColor.WB },
            { "Sacred Foundry", ArchetypeColor.WR },
            { "Temple Garden", ArchetypeColor.WG },
            { "Watery Grave", ArchetypeColor.UB },
            { "Steam Vents", ArchetypeColor.UR },
            { "Breeding Pool", ArchetypeColor.UG },
            { "Blood Crypt", ArchetypeColor.BR },
            { "Overgrown Tomb", ArchetypeColor.BG },
            { "Stomping Ground", ArchetypeColor.RG },

            // Fast
            { "Seachrome Coast", ArchetypeColor.WU },
            { "Concealed Courtyard", ArchetypeColor.WB },
            { "Inspiring Vantage", ArchetypeColor.WR },
            { "Razorverge Thicket", ArchetypeColor.WG },
            { "Darkslick Shores", ArchetypeColor.UB },
            { "Spirebluff Canal", ArchetypeColor.UR },
            { "Botanical Sanctum", ArchetypeColor.UG },
            { "Blackcleave Cliffs", ArchetypeColor.BR },
            { "Blooming Marsh", ArchetypeColor.BG },
            { "Copperline Gorge", ArchetypeColor.RG },

            // Man
            { "Celestial Colonnade", ArchetypeColor.WU },
            { "Shambling Vent", ArchetypeColor.WB },
            { "Needle Spires", ArchetypeColor.WR },
            { "Stirring Wildwood", ArchetypeColor.WG },
            { "Creeping Tar Pit", ArchetypeColor.UB },
            { "Wandering Fumarole", ArchetypeColor.UR },
            { "Lumbering Falls", ArchetypeColor.UG },
            { "Lavaclaw Reaches", ArchetypeColor.BR },
            { "Hissing Quagmire", ArchetypeColor.BG },
            { "Raging Ravine", ArchetypeColor.RG },

            // Battle Lands
            { "Prairie Stream", ArchetypeColor.WU },
            { "Canopy Vista", ArchetypeColor.WG },
            { "Sunken Hollow", ArchetypeColor.UB },
            { "Smoldering Marsh", ArchetypeColor.BR },
            { "Cinder Glade", ArchetypeColor.RG },

            // Shadow Labds
            { "Port Town", ArchetypeColor.WU },
            { "Fortified Village", ArchetypeColor.WG },
            { "Choked Estuary ", ArchetypeColor.UB },
            { "Foreboding Ruins", ArchetypeColor.BR },
            { "Game Trail", ArchetypeColor.RG },

            // Future Sight
            { "Dakmor Salvage", ArchetypeColor.B },
            { "Tolaria West", ArchetypeColor.U },
            { "Llanowar Reborn", ArchetypeColor.G },
            { "Dryad Arbor", ArchetypeColor.G },
            { "Nimbus Maze", ArchetypeColor.WU },
            { "River of Tears", ArchetypeColor.UB },
            { "Grove of the Burnwillows", ArchetypeColor.RG },

            // Tribal
            { "Wanderwine Hub ", ArchetypeColor.WU },
            { "Ancient Amphitheater ", ArchetypeColor.WR },
            { "Secluded Glen", ArchetypeColor.UB },
            { "Auntie's Hovel", ArchetypeColor.BR },
            { "Gilt-Leaf Palace", ArchetypeColor.BG },
            { "Murmuring Bosk", ArchetypeColor.WBG },

            // Filter
            { "Mystic Gate", ArchetypeColor.WU },
            { "Fetid Heath", ArchetypeColor.WB },
            { "Rugged Prairie", ArchetypeColor.WR },
            { "Wooded Bastion", ArchetypeColor.WG },
            { "Sunken Ruins", ArchetypeColor.UB },
            { "Cascade Bluffs", ArchetypeColor.UR },
            { "Flooded Grove", ArchetypeColor.UG },
            { "Graven Cairns ", ArchetypeColor.BR },
            { "Twilight Mire", ArchetypeColor.BG },
            { "Fire-lit Thicket", ArchetypeColor.RG },

            // Temples
            { "Temple of Enlightenment", ArchetypeColor.WU },
            { "Temple of Silence", ArchetypeColor.WB },
            { "Temple of Triumph", ArchetypeColor.WR },
            { "Temple of Plenty", ArchetypeColor.WG },
            { "Temple of Deceit", ArchetypeColor.UB },
            { "Temple of Epiphany", ArchetypeColor.UR },
            { "Temple of Mystery", ArchetypeColor.UG },
            { "Temple of Malice", ArchetypeColor.BR },
            { "Temple of Malady", ArchetypeColor.BG },
            { "Temple of Abandon", ArchetypeColor.RG },

            // Bounce
            { "Azorius Chancery", ArchetypeColor.WU },
            { "Orzhov Basilica", ArchetypeColor.WB },
            { "Boros Garrison", ArchetypeColor.WR },
            { "Selesnya Sanctuary", ArchetypeColor.WG },
            { "Dimir Aqueduct", ArchetypeColor.UB },
            { "Izzet Boilerworks", ArchetypeColor.UR },
            { "Simic Growth Chamber", ArchetypeColor.UG },
            { "Rakdos Carnarium", ArchetypeColor.BR },
            { "Golgari Rot Farm", ArchetypeColor.BG },
            { "Gruul Turf ", ArchetypeColor.RG },

            // Check
            { "Glacial Fortress", ArchetypeColor.WU },
            { "Isolated Chapel", ArchetypeColor.WB },
            { "Clifftop Retreat", ArchetypeColor.WR },
            { "Sunpetal Grove", ArchetypeColor.WG },
            { "Drowned Catacomb", ArchetypeColor.UB },
            { "Sulfur Falls", ArchetypeColor.UR },
            { "Hinterland Harbor", ArchetypeColor.UG },
            { "Dragonskull Summit", ArchetypeColor.BR },
            { "Woodland Cemetery", ArchetypeColor.BG },
            { "Rootbound Crag", ArchetypeColor.RG },

            // Pain
            { "Adarkar Wastes", ArchetypeColor.WU },
            { "Caves of Koilos", ArchetypeColor.WB },
            { "Battlefield Forge", ArchetypeColor.WR },
            { "Brushland", ArchetypeColor.WG },
            { "Underground River", ArchetypeColor.UB },
            { "Shivan Reef", ArchetypeColor.UR },
            { "Yavimaya Coast", ArchetypeColor.UG },
            { "Sulfurous Springs", ArchetypeColor.BR },
            { "Llanowar Wastes", ArchetypeColor.BG },
            { "Karplusan Forest", ArchetypeColor.RG },

            // Desert Pain
            { "Windbrisk Heights", ArchetypeColor.W },
            { "Shelldock Isle", ArchetypeColor.U },
            { "Howltooth Hollow", ArchetypeColor.B },
            { "Spinerock Knoll", ArchetypeColor.R },
            { "Mosswort Bridge", ArchetypeColor.G },

            // Hideaway
            { "Shefet Dunes", ArchetypeColor.W },
            { "Ipnu Rivulet", ArchetypeColor.U },
            { "Ifnir Deadlands", ArchetypeColor.B },
            { "Ramunap Ruins", ArchetypeColor.R },
            { "Hashep Oasis", ArchetypeColor.G },

            // Zendikar should-be-legendary 
            { "Emeria, the Sky Ruin", ArchetypeColor.W },
            { "Magosi, the Waterveil", ArchetypeColor.U },
            { "Crypt of Agadeem", ArchetypeColor.B },
            { "Valakut, the Molten Pinnacle", ArchetypeColor.R },
            { "Oran-Rief, the Vastwood", ArchetypeColor.G },

            // Eldraine Fetchable
            { "Idyllic Grange", ArchetypeColor.W },
            { "Mystic Sanctuary", ArchetypeColor.U },
            { "Witch's Cottage", ArchetypeColor.B },
            { "Dwarven Mine", ArchetypeColor.R },
            { "Gingerbread Cabin", ArchetypeColor.G },

            // Eldraine Castle
            { "Castle Ardenvale", ArchetypeColor.W },
            { "Castle Vantress", ArchetypeColor.U },
            { "Castle Locthwain", ArchetypeColor.B },
            { "Castle Embereth", ArchetypeColor.R },
            { "Castle Garenbrig", ArchetypeColor.G },

            // Cycling 
            { "Secluded Steppe", ArchetypeColor.W },
            { "Lonely Sandbar", ArchetypeColor.U },
            { "Barren Moor", ArchetypeColor.B },
            { "Forgotten Cave", ArchetypeColor.R },
            { "Tranquil Thicket", ArchetypeColor.G },

            // Cycling Dual
            { "Irrigated Farmland", ArchetypeColor.WU },
            { "Fetid Pools ", ArchetypeColor.UB },
            { "Scattered Groves", ArchetypeColor.WG },
            { "Canyon Slough", ArchetypeColor.BR },
            { "Sheltered Thicket", ArchetypeColor.RG },

            // Triome
            { "Indatha Triome ", ArchetypeColor.WBG },
            { "Raugrin Triome ", ArchetypeColor.WUR },
            { "Zagoth Triome", ArchetypeColor.UBG },
            { "Savai Triome ", ArchetypeColor.WBR },
            { "Ketria Triome", ArchetypeColor.URG },

            // CKamigawa
            { "Eiganjo Castle", ArchetypeColor.W },
            { "Minamo, School at Water's Edge", ArchetypeColor.U },
            { "Shizo, Death's Storehouse", ArchetypeColor.B },
            { "Shinka, the Bloodsoaked Keep", ArchetypeColor.R },
            { "Okina, Temple to the Grandfathers", ArchetypeColor.G },

            // Time Spiral
            { "Flagstones of Trokair", ArchetypeColor.W },
            { "Academy Ruins", ArchetypeColor.U },
            { "Urborg, Tomb of Yawgmoth", ArchetypeColor.B },
            { "Kher Keep", ArchetypeColor.R },
            { "Pendelhaven", ArchetypeColor.G },

            // Misc
            { "Oboro, Palace in the Clouds", ArchetypeColor.U },

            // 5C
            { "Ancient Ziggurat", ArchetypeColor.WUBRG }, // Usually represents a 5C deck, but not guaranteed
            { "Sliver Hive", ArchetypeColor.WUBRG }, // Usually represents a 5C deck, but not guaranteed
        };
    }
}
