using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_05
{
    public class Deck07_Cherryxman_Uroza_WUG_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Emry, Lurker of the Loch"),(4, "Gilded Goose"),(4, "Ice-Fang Coatl"),(4, "Thraben Inspector"),(2, "Trinket Mage"),(4, "Uro, Titan of Nature's Wrath"),(4, "Urza, Lord High Artificer"),(4, "Cryptic Command"),(4, "Metallic Rebuke"),(4, "Path to Exile"),(4, "Aether Vial"),(4, "Arcum's Astrolabe"),(1, "Engineered Explosives"),(4, "Mishra's Bauble"),(2, "Breeding Pool"),(4, "Flooded Strand"),(2, "Hallowed Fountain"),(4, "Misty Rainforest"),(3, "Mystic Sanctuary"),(4, "Prismatic Vista"),(1, "Scalding Tarn"),(2, "Snow-Covered Forest"),(5, "Snow-Covered Island"),(1, "Snow-Covered Plains"),(1, "Temple Garden") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (4, "Aether Gust"),(2, "Damping Sphere"),(3, "Disdainful Stroke"),(3, "Dispel"),(1, "Soul-Guide Lantern"),(1, "Tormod's Crypt"),(1, "Yorion, Sky Nomad") }; } }
    }
}