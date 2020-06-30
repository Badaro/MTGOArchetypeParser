using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck07_Jakesbaked_Scapeshift_URG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Nimble Obstructionist"),(2, "Uro, Titan of Nature's Wrath"),(4, "Scapeshift"),(4, "Search for Tomorrow"),(4, "Cryptic Command"),(4, "Growth Spiral"),(1, "Izzet Charm"),(4, "Lightning Bolt"),(2, "Peer Through Depths"),(4, "Remand"),(1, "Wilt"),(2, "Breeding Pool"),(2, "Forest"),(3, "Island"),(4, "Ketria Triome"),(4, "Misty Rainforest"),(1, "Mountain"),(2, "Mystic Sanctuary"),(2, "Scalding Tarn"),(4, "Steam Vents"),(3, "Stomping Ground"),(2, "Valakut, the Molten Pinnacle") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Uro, Titan of Nature's Wrath"),(2, "Anger of the Gods"),(3, "Damping Sphere"),(1, "Delay"),(1, "Engineered Explosives"),(2, "Force of Negation"),(3, "Veil of Summer"),(2, "Weather the Storm") }; } }
    }
}