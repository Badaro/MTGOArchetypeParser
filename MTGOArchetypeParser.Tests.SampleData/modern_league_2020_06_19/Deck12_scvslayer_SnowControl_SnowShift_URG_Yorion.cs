using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_19
{
    public class Deck12_scvslayer_SnowControl_SnowShift_URG_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Wrenn and Six"),(2, "Arboreal Grazer"),(4, "Ice-Fang Coatl"),(4, "Uro, Titan of Nature's Wrath"),(4, "Scapeshift"),(4, "Search for Tomorrow"),(4, "Cryptic Command"),(4, "Growth Spiral"),(4, "Lightning Bolt"),(4, "Remand"),(4, "Arcum's Astrolabe"),(4, "Abundant Growth"),(1, "Breeding Pool"),(4, "Ketria Triome"),(4, "Misty Rainforest"),(3, "Mystic Sanctuary"),(2, "Prismatic Vista"),(4, "Scalding Tarn"),(2, "Snow-Covered Forest"),(5, "Snow-Covered Island"),(1, "Snow-Covered Mountain"),(4, "Steam Vents"),(2, "Stomping Ground"),(2, "Valakut, the Molten Pinnacle"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Aether Gust"),(3, "Anger of the Gods"),(2, "Mystical Dispute"),(3, "Veil of Summer"),(3, "Weather the Storm"),(1, "Yorion, Sky Nomad") }; } }
    }
}