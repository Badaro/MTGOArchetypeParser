using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_preliminary_2020_06_18
{
    public class Deck09_MadCowChicken_EldraziBlade_WG_Jegantha : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Birds of Paradise"),
            new SampleCard(4, "Matter Reshaper"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(4, "Reality Smasher"),
            new SampleCard(3, "Stoneforge Mystic"),
            new SampleCard(4, "Thought-Knot Seer"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(3, "Engineered Explosives"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(3, "Talisman of Unity"),
            new SampleCard(4, "Cavern of Souls"),
            new SampleCard(4, "Eldrazi Temple"),
            new SampleCard(3, "Forest"),
            new SampleCard(3, "Horizon Canopy"),
            new SampleCard(1, "Plains"),
            new SampleCard(4, "Prismatic Vista"),
            new SampleCard(2, "Scavenger Grounds"),
            new SampleCard(1, "Wastes") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Choke"),
            new SampleCard(1, "Jegantha, the Wellspring"),
            new SampleCard(4, "Ravenous Trap"),
            new SampleCard(1, "Surgical Extraction"),
            new SampleCard(4, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}