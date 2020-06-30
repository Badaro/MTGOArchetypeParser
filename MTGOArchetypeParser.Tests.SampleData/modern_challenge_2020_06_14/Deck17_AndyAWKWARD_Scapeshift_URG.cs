using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14
{
    public class Deck17_AndyAWKWARD_Scapeshift_URG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Wrenn and Six"),(4, "Uro, Titan of Nature's Wrath"),(3, "Scapeshift"),(2, "Sweltering Suns"),(3, "Cryptic Command"),(2, "Force of Negation"),(4, "Growth Spiral"),(2, "Izzet Charm"),(4, "Lightning Bolt"),(4, "Remand"),(4, "Arcum's Astrolabe"),(1, "Breeding Pool"),(3, "Ketria Triome"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(1, "Scalding Tarn"),(2, "Snow-Covered Forest"),(3, "Snow-Covered Island"),(1, "Snow-Covered Mountain"),(4, "Steam Vents"),(3, "Stomping Ground"),(2, "Valakut, the Molten Pinnacle") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Aether Gust"),(2, "Alpine Moon"),(2, "Flame Slash"),(1, "Force of Vigor"),(2, "Mystical Dispute"),(3, "Obstinate Baloth"),(3, "Veil of Summer") }; } }
    }
}