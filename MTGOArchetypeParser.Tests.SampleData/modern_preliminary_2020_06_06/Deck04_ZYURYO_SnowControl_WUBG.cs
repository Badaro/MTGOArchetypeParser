using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_06
{
    public class Deck04_ZYURYO_SnowControl_WUBG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Jace, the Mind Sculptor"),(1, "Teferi, Hero of Dominaria"),(2, "Teferi, Time Raveler"),(4, "Ice-Fang Coatl"),(2, "Snapcaster Mage"),(3, "Uro, Titan of Nature's Wrath"),(2, "Supreme Verdict"),(1, "Archmage's Charm"),(2, "Assassin's Trophy"),(2, "Cryptic Command"),(3, "Force of Negation"),(2, "Kaya's Guile"),(2, "Mana Leak"),(4, "Path to Exile"),(4, "Arcum's Astrolabe"),(1, "Breeding Pool"),(4, "Field of Ruin"),(3, "Flooded Strand"),(1, "Hallowed Fountain"),(3, "Misty Rainforest"),(1, "Mystic Sanctuary"),(1, "Prismatic Vista"),(1, "Snow-Covered Forest"),(4, "Snow-Covered Island"),(2, "Snow-Covered Plains"),(1, "Snow-Covered Swamp"),(1, "Temple Garden"),(1, "Zagoth Triome") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Ashiok, Dream Render"),(2, "Celestial Purge"),(1, "Dead of Winter"),(1, "Disdainful Stroke"),(1, "Dovin's Veto"),(1, "Engineered Explosives"),(2, "Surgical Extraction"),(2, "Timely Reinforcements"),(2, "Veil of Summer") }; } }
    }
}