using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_18
{
    public class Deck09_MadCowChicken_EldraziBlade_WG_Jegantha : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Birds of Paradise"),(4, "Matter Reshaper"),(4, "Noble Hierarch"),(4, "Reality Smasher"),(3, "Stoneforge Mystic"),(4, "Thought-Knot Seer"),(4, "Ancient Stirrings"),(4, "Path to Exile"),(1, "Batterskull"),(3, "Engineered Explosives"),(1, "Sword of Feast and Famine"),(1, "Sword of Fire and Ice"),(3, "Talisman of Unity"),(4, "Cavern of Souls"),(4, "Eldrazi Temple"),(3, "Forest"),(3, "Horizon Canopy"),(1, "Plains"),(4, "Prismatic Vista"),(2, "Scavenger Grounds"),(1, "Wastes") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Choke"),(1, "Jegantha, the Wellspring"),(4, "Ravenous Trap"),(1, "Surgical Extraction"),(4, "Veil of Summer"),(2, "Weather the Storm") }; } }
    }
}