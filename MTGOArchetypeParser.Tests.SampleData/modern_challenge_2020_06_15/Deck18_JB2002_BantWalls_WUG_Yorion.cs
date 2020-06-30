using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15
{
    public class Deck18_JB2002_BantWalls_WUG_Yorion : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Ashiok, Dream Render"),(2, "Jace, the Mind Sculptor"),(3, "Teferi, Time Raveler"),(4, "Ice-Fang Coatl"),(4, "Knight of Autumn"),(4, "Restoration Angel"),(3, "Vendilion Clique"),(4, "Wall of Blossoms"),(4, "Wall of Omens"),(1, "Yorion, Sky Nomad"),(2, "Supreme Verdict"),(2, "Dovin's Veto"),(4, "Force of Negation"),(4, "Path to Exile"),(4, "Arcum's Astrolabe"),(3, "Detention Sphere"),(1, "Breeding Pool"),(4, "Cavern of Souls"),(4, "Celestial Colonnade"),(1, "Hallowed Fountain"),(4, "Misty Rainforest"),(4, "Snow-Covered Forest"),(4, "Snow-Covered Island"),(4, "Snow-Covered Plains"),(1, "Temple Garden"),(4, "Windswept Heath") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Yorion, Sky Nomad"),(3, "Ashiok, Dream Render"),(2, "Supreme Verdict"),(2, "Aether Gust"),(3, "Celestial Purge"),(2, "Disdainful Stroke"),(2, "Rest in Peace") }; } }
    }
}