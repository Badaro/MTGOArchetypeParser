using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_30
{
    public class Deck01_pbarrrgh_SnowControl_URG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Wrenn and Six"),(2, "Brazen Borrower"),(4, "Ice-Fang Coatl"),(4, "Uro, Titan of Nature's Wrath"),(2, "Archmage's Charm"),(4, "Cryptic Command"),(3, "Force of Negation"),(4, "Lightning Bolt"),(1, "Magmatic Sinkhole"),(4, "Thought Scour"),(4, "Arcum's Astrolabe"),(2, "Breeding Pool"),(1, "Field of Ruin"),(1, "Ketria Triome"),(4, "Misty Rainforest"),(3, "Mystic Sanctuary"),(2, "Polluted Delta"),(4, "Scalding Tarn"),(1, "Snow-Covered Forest"),(6, "Snow-Covered Island"),(1, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (4, "Aether Gust"),(2, "Ashiok, Dream Render"),(3, "Ceremonious Rejection"),(2, "Dismember"),(1, "Pyroclasm"),(2, "Veil of Summer"),(1, "Weather the Storm") }; } }
    }
}