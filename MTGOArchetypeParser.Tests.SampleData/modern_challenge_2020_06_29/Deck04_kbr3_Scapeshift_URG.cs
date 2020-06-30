using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck04_kbr3_Scapeshift_URG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Uro, Titan of Nature's Wrath"),(4, "Scapeshift"),(2, "Cryptic Command"),(2, "Force of Negation"),(4, "Growth Spiral"),(2, "Izzet Charm"),(4, "Lightning Bolt"),(4, "Opt"),(3, "Remand"),(2, "Thought Scour"),(2, "Breeding Pool"),(4, "Ketria Triome"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(4, "Scalding Tarn"),(1, "Snow-Covered Forest"),(2, "Snow-Covered Island"),(4, "Steam Vents"),(4, "Stomping Ground"),(2, "Valakut, the Molten Pinnacle") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (4, "Aether Gust"),(3, "Anger of the Gods"),(2, "Flame Slash"),(2, "Force of Vigor"),(2, "Mystical Dispute"),(2, "Veil of Summer") }; } }
    }
}