using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck52_Amatox_Soulherder_WUG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Teferi, Time Raveler"),(4, "Coiling Oracle"),(1, "Deputy of Detention"),(3, "Eternal Witness"),(4, "Ice-Fang Coatl"),(1, "Knight of Autumn"),(1, "Luminous Broodmoth"),(1, "Mulldrifter"),(4, "Noble Hierarch"),(2, "Soulherder"),(1, "Thassa, Deep-Dwelling"),(2, "Uro, Titan of Nature's Wrath"),(2, "Neoform"),(2, "Time Warp"),(4, "Ephemerate"),(3, "Force of Negation"),(3, "Path to Exile"),(1, "Breeding Pool"),(1, "Canopy Vista"),(1, "Flooded Strand"),(1, "Hallowed Fountain"),(4, "Misty Rainforest"),(1, "Prairie Stream"),(2, "Prismatic Vista"),(3, "Snow-Covered Forest"),(2, "Snow-Covered Island"),(1, "Snow-Covered Plains"),(1, "Temple Garden"),(3, "Windswept Heath") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Teferi, Time Raveler"),(1, "Aether Gust"),(1, "Celestial Purge"),(1, "Ceremonious Rejection"),(1, "Disdainful Stroke"),(1, "Force of Vigor"),(1, "Lavinia, Azorius Renegade"),(1, "Mystical Dispute"),(1, "Reflector Mage"),(1, "Thragtusk"),(1, "Timely Reinforcements"),(2, "Veil of Summer"),(1, "Winds of Abandon"),(1, "Worship") }; } }
    }
}