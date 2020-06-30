using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14
{
    public class Deck31_SunofNothing_Uroza_URG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Wrenn and Six"),(4, "Emry, Lurker of the Loch"),(4, "Gilded Goose"),(3, "Uro, Titan of Nature's Wrath"),(4, "Urza, Lord High Artificer"),(3, "Cryptic Command"),(3, "Galvanic Blast"),(3, "Metallic Rebuke"),(1, "Aether Spellbomb"),(4, "Arcum's Astrolabe"),(3, "Engineered Explosives"),(4, "Mishra's Bauble"),(2, "Breeding Pool"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(4, "Polluted Delta"),(2, "Scalding Tarn"),(1, "Snow-Covered Forest"),(5, "Snow-Covered Island"),(1, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Aether Gust"),(3, "Ceremonious Rejection"),(1, "Lightning Bolt"),(2, "Mystical Dispute"),(2, "Tireless Tracker"),(2, "Tormod's Crypt"),(2, "Veil of Summer") }; } }
    }
}