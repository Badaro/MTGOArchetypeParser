using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_10
{
    public class Deck12_ZYURYO_SnowControl_WUBG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Jace, the Mind Sculptor"),(1, "Teferi, Hero of Dominaria"),(2, "Teferi, Time Raveler"),(4, "Ice-Fang Coatl"),(2, "Snapcaster Mage"),(3, "Uro, Titan of Nature's Wrath"),(1, "Dead of Winter"),(1, "Supreme Verdict"),(1, "Abrupt Decay"),(2, "Archmage's Charm"),(2, "Cryptic Command"),(1, "Dovin's Veto"),(3, "Force of Negation"),(1, "Kaya's Guile"),(2, "Mana Leak"),(4, "Path to Exile"),(4, "Arcum's Astrolabe"),(1, "Breeding Pool"),(4, "Field of Ruin"),(3, "Flooded Strand"),(1, "Hallowed Fountain"),(3, "Misty Rainforest"),(2, "Mystic Sanctuary"),(1, "Snow-Covered Forest"),(4, "Snow-Covered Island"),(2, "Snow-Covered Plains"),(1, "Snow-Covered Swamp"),(1, "Temple Garden"),(1, "Watery Grave") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Dead of Winter"),(1, "Dovin's Veto"),(1, "Kaya's Guile"),(3, "Ashiok, Dream Render"),(1, "Assassin's Trophy"),(2, "Celestial Purge"),(1, "Disdainful Stroke"),(2, "Timely Reinforcements"),(3, "Veil of Summer") }; } }
    }
}