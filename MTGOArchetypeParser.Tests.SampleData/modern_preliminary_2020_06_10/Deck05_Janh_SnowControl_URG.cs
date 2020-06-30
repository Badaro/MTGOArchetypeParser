using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_10
{
    public class Deck05_Janh_SnowControl_URG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Jace, the Mind Sculptor"),(3, "Wrenn and Six"),(4, "Ice-Fang Coatl"),(2, "Snapcaster Mage"),(3, "Uro, Titan of Nature's Wrath"),(2, "Archmage's Charm"),(2, "Cryptic Command"),(1, "Deprive"),(3, "Force of Negation"),(2, "Lightning Bolt"),(2, "Mana Leak"),(3, "Skred"),(1, "Spell Snare"),(4, "Arcum's Astrolabe"),(2, "Breeding Pool"),(3, "Field of Ruin"),(1, "Lonely Sandbar"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(4, "Scalding Tarn"),(1, "Snow-Covered Forest"),(5, "Snow-Covered Island"),(1, "Snow-Covered Mountain"),(1, "Steam Vents"),(1, "Stomping Ground") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Abrade"),(3, "Aether Gust"),(2, "Anger of the Gods"),(2, "Ashiok, Dream Render"),(2, "Blood Moon"),(1, "Disdainful Stroke"),(2, "Mystical Dispute"),(2, "Veil of Summer") }; } }
    }
}