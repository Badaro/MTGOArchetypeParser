using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck08_haubidtran_Uroza_UBG_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Emry, Lurker of the Loch"),(4, "Gilded Goose"),(4, "Ice-Fang Coatl"),(3, "Uro, Titan of Nature's Wrath"),(4, "Urza, Lord High Artificer"),(2, "Abrupt Decay"),(4, "Cryptic Command"),(4, "Fatal Push"),(2, "Metallic Rebuke"),(4, "Arcum's Astrolabe"),(4, "Engineered Explosives"),(4, "Mishra's Bauble"),(2, "Nihil Spellbomb"),(4, "Abundant Growth"),(2, "Breeding Pool"),(1, "Flooded Strand"),(4, "Misty Rainforest"),(3, "Mystic Sanctuary"),(1, "Overgrown Tomb"),(4, "Polluted Delta"),(3, "Prismatic Vista"),(1, "Scalding Tarn"),(2, "Snow-Covered Forest"),(5, "Snow-Covered Island"),(1, "Snow-Covered Swamp"),(1, "Watery Grave"),(1, "Zagoth Triome"),(2, "Lurrus of the Dream-Den") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (4, "Aether Gust"),(3, "Damping Sphere"),(2, "Dead of Winter"),(2, "Disdainful Stroke"),(3, "Veil of Summer"),(1, "Yorion, Sky Nomad") }; } }
    }
}