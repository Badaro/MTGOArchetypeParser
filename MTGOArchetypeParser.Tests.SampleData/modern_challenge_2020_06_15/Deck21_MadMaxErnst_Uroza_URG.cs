using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15
{
    public class Deck21_MadMaxErnst_Uroza_URG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Emry, Lurker of the Loch"),(4, "Gilded Goose"),(3, "Uro, Titan of Nature's Wrath"),(4, "Urza, Lord High Artificer"),(3, "Cryptic Command"),(1, "Deprive"),(4, "Galvanic Blast"),(3, "Metallic Rebuke"),(4, "Arcum's Astrolabe"),(3, "Engineered Explosives"),(4, "Mishra's Bauble"),(2, "Soul-Guide Lantern"),(2, "Breeding Pool"),(4, "Flooded Strand"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(2, "Polluted Delta"),(1, "Snow-Covered Forest"),(5, "Snow-Covered Island"),(1, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Aether Gust"),(1, "Ashiok, Dream Render"),(1, "Ceremonious Rejection"),(2, "Damping Sphere"),(1, "Disdainful Stroke"),(2, "Dispel"),(1, "Tireless Tracker"),(2, "Veil of Summer"),(2, "Wrenn and Six") }; } }
    }
}