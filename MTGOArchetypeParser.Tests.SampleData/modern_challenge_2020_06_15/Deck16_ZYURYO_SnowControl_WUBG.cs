using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15
{
    public class Deck16_ZYURYO_SnowControl_WUBG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Jace, the Mind Sculptor"),(1, "Kaya, Orzhov Usurper"),(1, "Teferi, Hero of Dominaria"),(2, "Teferi, Time Raveler"),(4, "Ice-Fang Coatl"),(2, "Snapcaster Mage"),(3, "Uro, Titan of Nature's Wrath"),(2, "Dead of Winter"),(2, "Archmage's Charm"),(2, "Cryptic Command"),(2, "Fatal Push"),(3, "Force of Negation"),(1, "Kaya's Guile"),(2, "Mana Leak"),(3, "Path to Exile"),(4, "Arcum's Astrolabe"),(1, "Breeding Pool"),(4, "Field of Ruin"),(2, "Flooded Strand"),(1, "Hallowed Fountain"),(3, "Misty Rainforest"),(1, "Mystic Sanctuary"),(3, "Polluted Delta"),(1, "Snow-Covered Forest"),(4, "Snow-Covered Island"),(1, "Snow-Covered Plains"),(1, "Snow-Covered Swamp"),(1, "Temple Garden"),(1, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Kaya's Guile"),(3, "Ashiok, Dream Render"),(2, "Assassin's Trophy"),(2, "Celestial Purge"),(1, "Disdainful Stroke"),(1, "Dovin's Veto"),(1, "Notion Thief"),(1, "Timely Reinforcements"),(2, "Veil of Summer") }; } }
    }
}