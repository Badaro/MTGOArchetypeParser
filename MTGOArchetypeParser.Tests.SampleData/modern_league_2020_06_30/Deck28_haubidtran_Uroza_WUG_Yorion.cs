using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck28_haubidtran_Uroza_WUG_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Teferi, Time Raveler"),(4, "Emry, Lurker of the Loch"),(4, "Gilded Goose"),(4, "Ice-Fang Coatl"),(4, "Thraben Inspector"),(3, "Uro, Titan of Nature's Wrath"),(4, "Urza, Lord High Artificer"),(4, "Cryptic Command"),(3, "Ephemerate"),(4, "Metallic Rebuke"),(3, "Path to Exile"),(4, "Arcum's Astrolabe"),(4, "Mishra's Bauble"),(4, "Springleaf Drum"),(2, "Breeding Pool"),(4, "Flooded Strand"),(2, "Hallowed Fountain"),(4, "Misty Rainforest"),(3, "Mystic Sanctuary"),(4, "Polluted Delta"),(1, "Scalding Tarn"),(1, "Snow-Covered Forest"),(6, "Snow-Covered Island"),(1, "Snow-Covered Plains") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Teferi, Time Raveler"),(3, "Aether Gust"),(1, "Ashiok, Dream Render"),(2, "Celestial Purge"),(2, "Ceremonious Rejection"),(3, "Damping Sphere"),(1, "Soul-Guide Lantern"),(1, "Tormod's Crypt"),(1, "Yorion, Sky Nomad") }; } }
    }
}