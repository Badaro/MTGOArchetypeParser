using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_11
{
    public class Deck05_SonicSmasher_SnowControl_SnowBlade_WUG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Jace, the Mind Sculptor"),(3, "Teferi, Time Raveler"),(4, "Ice-Fang Coatl"),(1, "Snapcaster Mage"),(4, "Stoneforge Mystic"),(3, "Uro, Titan of Nature's Wrath"),(2, "Cryptic Command"),(4, "Force of Negation"),(2, "Mana Leak"),(4, "Path to Exile"),(4, "Arcum's Astrolabe"),(1, "Batterskull"),(1, "Sword of Feast and Famine"),(2, "Breeding Pool"),(3, "Field of Ruin"),(4, "Flooded Strand"),(2, "Hallowed Fountain"),(4, "Misty Rainforest"),(1, "Mystic Sanctuary"),(1, "Snow-Covered Forest"),(5, "Snow-Covered Island"),(1, "Snow-Covered Plains"),(1, "Temple Garden") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Aether Gust"),(2, "Ashiok, Dream Render"),(2, "Celestial Purge"),(2, "Ceremonious Rejection"),(2, "Mystical Dispute"),(1, "Supreme Verdict"),(1, "Timely Reinforcements"),(2, "Veil of Summer") }; } }
    }
}