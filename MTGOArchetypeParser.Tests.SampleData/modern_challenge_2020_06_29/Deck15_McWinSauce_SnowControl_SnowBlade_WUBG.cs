using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck15_McWinSauce_SnowControl_SnowBlade_WUBG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Jace, the Mind Sculptor"),(1, "Teferi, Hero of Dominaria"),(1, "Teferi, Master of Time"),(2, "Teferi, Time Raveler"),(4, "Ice-Fang Coatl"),(4, "Stoneforge Mystic"),(2, "Uro, Titan of Nature's Wrath"),(2, "Supreme Verdict"),(2, "Archmage's Charm"),(2, "Cryptic Command"),(3, "Force of Negation"),(2, "Mana Leak"),(4, "Path to Exile"),(4, "Arcum's Astrolabe"),(1, "Batterskull"),(1, "Sword of Feast and Famine"),(2, "Breeding Pool"),(2, "Field of Ruin"),(4, "Flooded Strand"),(2, "Hallowed Fountain"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(1, "Snow-Covered Forest"),(4, "Snow-Covered Island"),(1, "Snow-Covered Plains"),(1, "Temple Garden"),(1, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Aether Gust"),(1, "Ashiok, Dream Render"),(2, "Celestial Purge"),(1, "Ceremonious Rejection"),(1, "Containment Priest"),(1, "Disdainful Stroke"),(1, "Dovin's Veto"),(2, "Plague Engineer"),(2, "Timely Reinforcements"),(2, "Veil of Summer") }; } }
    }
}