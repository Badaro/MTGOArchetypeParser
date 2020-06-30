using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15
{
    public class Deck28_Batutinha_SnowControl_WUG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Ashiok, Dream Render"),(3, "Jace, the Mind Sculptor"),(1, "Teferi, Hero of Dominaria"),(3, "Teferi, Time Raveler"),(4, "Ice-Fang Coatl"),(3, "Uro, Titan of Nature's Wrath"),(2, "Supreme Verdict"),(1, "Timely Reinforcements"),(2, "Archmage's Charm"),(2, "Cryptic Command"),(3, "Force of Negation"),(2, "Mana Leak"),(4, "Path to Exile"),(4, "Arcum's Astrolabe"),(1, "Breeding Pool"),(4, "Field of Ruin"),(4, "Flooded Strand"),(1, "Hallowed Fountain"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(1, "Snow-Covered Forest"),(5, "Snow-Covered Island"),(2, "Snow-Covered Plains"),(1, "Temple Garden") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Ashiok, Dream Render"),(2, "Timely Reinforcements"),(2, "Aether Gust"),(1, "Carnage Tyrant"),(2, "Celestial Purge"),(1, "Disdainful Stroke"),(1, "Monastery Mentor"),(1, "Surgical Extraction"),(3, "Veil of Summer") }; } }
    }
}