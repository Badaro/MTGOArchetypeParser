using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_27
{
    public class Deck06_Wolfie98_SnowControl_URG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Jace, the Mind Sculptor"),(3, "Wrenn and Six"),(4, "Ice-Fang Coatl"),(3, "Snapcaster Mage"),(3, "Uro, Titan of Nature's Wrath"),(2, "Archmage's Charm"),(3, "Cryptic Command"),(1, "Deprive"),(2, "Force of Negation"),(4, "Lightning Bolt"),(3, "Mana Leak"),(1, "Skred"),(4, "Arcum's Astrolabe"),(2, "Breeding Pool"),(1, "Field of Ruin"),(2, "Lonely Sandbar"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(3, "Scalding Tarn"),(1, "Snow-Covered Forest"),(6, "Snow-Covered Island"),(1, "Snow-Covered Mountain"),(2, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Aether Gust"),(2, "Anger of the Gods"),(2, "Blood Moon"),(2, "Disdainful Stroke"),(1, "Engineered Explosives"),(2, "Mystical Dispute"),(2, "Veil of Summer"),(2, "Weather the Storm") }; } }
    }
}