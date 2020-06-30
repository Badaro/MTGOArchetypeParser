using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_showcase_challenge_2020_06_07
{
    public class Deck04_McWinSauce_SnowControl_SnowBlade_WUG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Jace, the Mind Sculptor"),(1, "Teferi, Hero of Dominaria"),(2, "Teferi, Time Raveler"),(4, "Ice-Fang Coatl"),(4, "Stoneforge Mystic"),(3, "Uro, Titan of Nature's Wrath"),(1, "Supreme Verdict"),(2, "Archmage's Charm"),(2, "Cryptic Command"),(3, "Force of Negation"),(2, "Mana Leak"),(4, "Path to Exile"),(4, "Arcum's Astrolabe"),(1, "Batterskull"),(1, "Sword of Feast and Famine"),(2, "Breeding Pool"),(2, "Field of Ruin"),(4, "Flooded Strand"),(2, "Hallowed Fountain"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(1, "Polluted Delta"),(1, "Snow-Covered Forest"),(4, "Snow-Covered Island"),(1, "Snow-Covered Plains"),(1, "Temple Garden") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Supreme Verdict"),(3, "Aether Gust"),(1, "Ashiok, Dream Render"),(2, "Celestial Purge"),(1, "Ceremonious Rejection"),(1, "Disdainful Stroke"),(2, "Dovin's Veto"),(2, "Timely Reinforcements"),(2, "Veil of Summer") }; } }
    }
}