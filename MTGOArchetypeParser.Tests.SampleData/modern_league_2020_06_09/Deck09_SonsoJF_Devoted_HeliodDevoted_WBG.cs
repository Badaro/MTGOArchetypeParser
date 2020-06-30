using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck09_SonsoJF_Devoted_HeliodDevoted_WBG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (2, "Birds of Paradise"),(4, "Devoted Druid"),(1, "Giver of Runes"),(4, "Heliod, Sun-Crowned"),(4, "Kitchen Finks"),(4, "Noble Hierarch"),(3, "Ranger-Captain of Eos"),(4, "Spike Feeder"),(1, "Viscera Seer"),(3, "Vizier of Remedies"),(2, "Walking Ballista"),(2, "Finale of Devastation"),(4, "Collected Company"),(2, "Forest"),(1, "Godless Shrine"),(3, "Horizon Canopy"),(1, "Marsh Flats"),(2, "Overgrown Tomb"),(2, "Plains"),(2, "Razorverge Thicket"),(2, "Temple Garden"),(3, "Verdant Catacombs"),(4, "Windswept Heath") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Choke"),(2, "Damping Sphere"),(1, "Knight of Autumn"),(3, "Kor Firewalker"),(3, "Path to Exile"),(2, "Thoughtseize"),(2, "Veil of Summer") }; } }
    }
}