using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck36_MrRaeb_Uroza_UBG_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Emry, Lurker of the Loch"),(4, "Gilded Goose"),(4, "Ice-Fang Coatl"),(4, "Uro, Titan of Nature's Wrath"),(4, "Urza, Lord High Artificer"),(2, "Abrupt Decay"),(4, "Cryptic Command"),(4, "Fatal Push"),(2, "Metallic Rebuke"),(4, "Arcum's Astrolabe"),(3, "Engineered Explosives"),(4, "Mishra's Bauble"),(4, "Nihil Spellbomb"),(4, "Abundant Growth"),(2, "Breeding Pool"),(4, "Misty Rainforest"),(3, "Mystic Sanctuary"),(1, "Overgrown Tomb"),(4, "Polluted Delta"),(4, "Prismatic Vista"),(1, "Scalding Tarn"),(2, "Snow-Covered Forest"),(5, "Snow-Covered Island"),(1, "Snow-Covered Swamp"),(1, "Watery Grave"),(1, "Zagoth Triome") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Abrupt Decay"),(2, "Metallic Rebuke"),(4, "Aether Gust"),(2, "Damping Sphere"),(2, "Dead of Winter"),(3, "Veil of Summer"),(1, "Yorion, Sky Nomad") }; } }
    }
}