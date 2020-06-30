using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21
{
    public class Deck23_katoriarch123_SnowControl_WUG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Jace, the Mind Sculptor"),(2, "Teferi, Hero of Dominaria"),(3, "Teferi, Time Raveler"),(4, "Ice-Fang Coatl"),(2, "Snapcaster Mage"),(3, "Uro, Titan of Nature's Wrath"),(1, "Oust"),(2, "Supreme Verdict"),(1, "Archmage's Charm"),(2, "Cryptic Command"),(3, "Force of Negation"),(2, "Mana Leak"),(4, "Path to Exile"),(1, "Spell Snare"),(4, "Arcum's Astrolabe"),(1, "Breeding Pool"),(4, "Field of Ruin"),(4, "Flooded Strand"),(1, "Hallowed Fountain"),(4, "Misty Rainforest"),(2, "Mystic Sanctuary"),(1, "Snow-Covered Forest"),(5, "Snow-Covered Island"),(1, "Snow-Covered Plains"),(1, "Temple Garden") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Aether Gust"),(1, "Ashiok, Dream Render"),(3, "Celestial Purge"),(2, "Disdainful Stroke"),(2, "Surgical Extraction"),(2, "Timely Reinforcements"),(3, "Veil of Summer") }; } }
    }
}