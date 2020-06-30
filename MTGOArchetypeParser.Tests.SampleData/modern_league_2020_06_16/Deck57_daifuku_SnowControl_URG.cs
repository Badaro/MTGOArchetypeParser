using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck57_daifuku_SnowControl_URG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Jace, the Mind Sculptor"),(4, "Wrenn and Six"),(4, "Bloodbraid Elf"),(4, "Ice-Fang Coatl"),(4, "Tarmogoyf"),(3, "Uro, Titan of Nature's Wrath"),(4, "Archmage's Charm"),(4, "Cryptic Command"),(4, "Lightning Bolt"),(4, "Arcum's Astrolabe"),(1, "Breeding Pool"),(2, "Flooded Strand"),(1, "Lonely Sandbar"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(4, "Scalding Tarn"),(2, "Snow-Covered Forest"),(5, "Snow-Covered Island"),(1, "Snow-Covered Mountain"),(1, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Aether Gust"),(2, "Anger of the Gods"),(2, "Ashiok, Dream Render"),(3, "Blood Moon"),(3, "Veil of Summer"),(2, "Weather the Storm") }; } }
    }
}