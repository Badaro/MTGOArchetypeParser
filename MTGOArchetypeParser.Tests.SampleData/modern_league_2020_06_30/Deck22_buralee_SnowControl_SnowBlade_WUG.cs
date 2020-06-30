using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck22_buralee_SnowControl_SnowBlade_WUG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Jace, the Mind Sculptor"),(2, "Teferi, Time Raveler"),(2, "Birds of Paradise"),(1, "Deputy of Detention"),(3, "Geist of Saint Traft"),(4, "Ice-Fang Coatl"),(4, "Noble Hierarch"),(4, "Spell Queller"),(4, "Stoneforge Mystic"),(2, "Uro, Titan of Nature's Wrath"),(2, "Force of Negation"),(4, "Path to Exile"),(2, "Arcum's Astrolabe"),(1, "Batterskull"),(1, "Sword of Feast and Famine"),(1, "Breeding Pool"),(2, "Field of Ruin"),(2, "Flooded Strand"),(1, "Hallowed Fountain"),(4, "Misty Rainforest"),(2, "Snow-Covered Forest"),(2, "Snow-Covered Island"),(2, "Snow-Covered Plains"),(1, "Temple Garden"),(1, "Waterlogged Grove"),(4, "Windswept Heath") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Ashiok, Dream Render"),(1, "Celestial Purge"),(2, "Damping Sphere"),(2, "Gaddock Teeg"),(1, "Knight of Autumn"),(3, "Mystical Dispute"),(1, "Timely Reinforcements"),(1, "Tireless Tracker"),(2, "Veil of Summer") }; } }
    }
}