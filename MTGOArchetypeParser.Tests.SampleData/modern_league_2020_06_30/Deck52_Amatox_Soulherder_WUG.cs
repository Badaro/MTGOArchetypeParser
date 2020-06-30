using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck52_Amatox_Soulherder_WUG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Teferi, Time Raveler"),
            new SampleCard(4, "Coiling Oracle"),
            new SampleCard(1, "Deputy of Detention"),
            new SampleCard(3, "Eternal Witness"),
            new SampleCard(4, "Ice-Fang Coatl"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(1, "Luminous Broodmoth"),
            new SampleCard(1, "Mulldrifter"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(2, "Soulherder"),
            new SampleCard(1, "Thassa, Deep-Dwelling"),
            new SampleCard(2, "Uro, Titan of Nature's Wrath"),
            new SampleCard(2, "Neoform"),
            new SampleCard(2, "Time Warp"),
            new SampleCard(4, "Ephemerate"),
            new SampleCard(3, "Force of Negation"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(1, "Breeding Pool"),
            new SampleCard(1, "Canopy Vista"),
            new SampleCard(1, "Flooded Strand"),
            new SampleCard(1, "Hallowed Fountain"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(1, "Prairie Stream"),
            new SampleCard(2, "Prismatic Vista"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(2, "Snow-Covered Island"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(3, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Teferi, Time Raveler"),
            new SampleCard(1, "Aether Gust"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(1, "Ceremonious Rejection"),
            new SampleCard(1, "Disdainful Stroke"),
            new SampleCard(1, "Force of Vigor"),
            new SampleCard(1, "Lavinia, Azorius Renegade"),
            new SampleCard(1, "Mystical Dispute"),
            new SampleCard(1, "Reflector Mage"),
            new SampleCard(1, "Thragtusk"),
            new SampleCard(1, "Timely Reinforcements"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(1, "Winds of Abandon"),
            new SampleCard(1, "Worship") 
        };
    }
}