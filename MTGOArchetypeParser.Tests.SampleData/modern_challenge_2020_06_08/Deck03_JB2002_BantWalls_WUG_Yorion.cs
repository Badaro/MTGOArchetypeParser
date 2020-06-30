using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_08
{
    public class Deck03_JB2002_BantWalls_WUG_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Teferi, Time Raveler"),(1, "Arcades, the Strategist"),(4, "Ice-Fang Coatl"),(3, "Kitchen Finks"),(4, "Knight of Autumn"),(4, "Restoration Angel"),(2, "Vendilion Clique"),(2, "Venser, Shaper Savant"),(4, "Wall of Blossoms"),(4, "Wall of Omens"),(2, "Supreme Verdict"),(2, "Dovin's Veto"),(4, "Force of Negation"),(4, "Path to Exile"),(4, "Arcum's Astrolabe"),(2, "On Thin Ice"),(1, "Breeding Pool"),(3, "Cavern of Souls"),(4, "Celestial Colonnade"),(1, "Hallowed Fountain"),(4, "Misty Rainforest"),(1, "Prismatic Vista"),(4, "Snow-Covered Forest"),(4, "Snow-Covered Island"),(4, "Snow-Covered Plains"),(1, "Temple Garden"),(4, "Windswept Heath") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Supreme Verdict"),(2, "Aether Gust"),(4, "Ashiok, Dream Render"),(2, "Celestial Purge"),(2, "Disdainful Stroke"),(2, "Rest in Peace"),(1, "Yorion, Sky Nomad") }; } }
    }
}