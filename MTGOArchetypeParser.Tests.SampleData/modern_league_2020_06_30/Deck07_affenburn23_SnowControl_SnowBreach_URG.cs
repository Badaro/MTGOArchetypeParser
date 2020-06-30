using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck07_affenburn23_SnowControl_SnowBreach_URG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Emrakul, the Aeons Torn"),(4, "Ice-Fang Coatl"),(1, "Snapcaster Mage"),(2, "Uro, Titan of Nature's Wrath"),(2, "Archmage's Charm"),(2, "Cryptic Command"),(1, "Fact or Fiction"),(2, "Force of Negation"),(2, "Izzet Charm"),(4, "Lightning Bolt"),(4, "Remand"),(4, "Through the Breach"),(4, "Arcum's Astrolabe"),(2, "Breeding Pool"),(1, "Desolate Lighthouse"),(2, "Flooded Strand"),(2, "Misty Rainforest"),(2, "Mystic Sanctuary"),(4, "Scalding Tarn"),(1, "Snow-Covered Forest"),(7, "Snow-Covered Island"),(1, "Snow-Covered Mountain"),(2, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Abrade"),(2, "Aether Gust"),(3, "Anger of the Gods"),(3, "Ashiok, Dream Render"),(2, "Blood Moon"),(2, "Veil of Summer"),(2, "Weather the Storm") }; } }
    }
}