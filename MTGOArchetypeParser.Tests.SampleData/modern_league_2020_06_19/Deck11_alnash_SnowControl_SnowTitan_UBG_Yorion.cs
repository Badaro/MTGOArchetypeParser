using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_19
{
    public class Deck11_alnash_SnowControl_SnowTitan_UBG_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Jace, the Mind Sculptor"),(2, "Tamiyo, Collector of Tales"),(2, "Brazen Borrower"),(4, "Ice-Fang Coatl"),(2, "Primeval Titan"),(2, "Snapcaster Mage"),(2, "Thragtusk"),(4, "Uro, Titan of Nature's Wrath"),(1, "Venser, Shaper Savant"),(4, "Search for Tomorrow"),(1, "Archmage's Charm"),(3, "Cryptic Command"),(2, "Dismember"),(3, "Force of Negation"),(2, "Mana Leak"),(3, "Remand"),(2, "Spell Snare"),(4, "Arcum's Astrolabe"),(1, "Blast Zone"),(4, "Breeding Pool"),(1, "Castle Vantress"),(3, "Field of Ruin"),(2, "Field of the Dead"),(1, "Flooded Grove"),(2, "Hinterland Harbor"),(4, "Misty Rainforest"),(3, "Mystic Sanctuary"),(3, "Polluted Delta"),(2, "Snow-Covered Forest"),(7, "Snow-Covered Island"),(2, "Zagoth Triome") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Aether Gust"),(2, "Disdainful Stroke"),(1, "Engineered Explosives"),(2, "Nature's Claim"),(2, "Surgical Extraction"),(2, "Tireless Tracker"),(2, "Veil of Summer"),(1, "Yorion, Sky Nomad") }; } }
    }
}