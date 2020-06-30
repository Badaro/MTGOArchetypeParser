using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck19_2radMTG_SnowControl_SnowReclamation_URG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Wrenn and Six"),(4, "Ice-Fang Coatl"),(3, "Uro, Titan of Nature's Wrath"),(3, "Cryptic Command"),(3, "Expansion // Explosion"),(2, "Fact or Fiction"),(3, "Force of Negation"),(4, "Growth Spiral"),(2, "Lightning Bolt"),(1, "Remand"),(4, "Arcum's Astrolabe"),(4, "Wilderness Reclamation"),(2, "Breeding Pool"),(2, "Flooded Strand"),(1, "Ketria Triome"),(4, "Misty Rainforest"),(4, "Mystic Sanctuary"),(4, "Scalding Tarn"),(1, "Snow-Covered Forest"),(6, "Snow-Covered Island"),(2, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Aether Gust"),(2, "Anger of the Gods"),(2, "Ashiok, Dream Render"),(2, "Blood Moon"),(2, "Mystical Dispute"),(2, "Veil of Summer"),(3, "Weather the Storm") }; } }
    }
}