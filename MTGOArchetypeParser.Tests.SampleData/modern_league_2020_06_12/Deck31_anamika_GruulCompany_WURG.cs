using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck31_anamika_GruulCompany_WURG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Ahn-Crop Crasher"),(3, "Birds of Paradise"),(1, "Bonecrusher Giant"),(1, "Gallia of the Endless Dance"),(3, "Goblin Chieftain"),(4, "Goblin Rabblemaster"),(3, "Hexdrinker"),(4, "Legion Warboss"),(4, "Noble Hierarch"),(3, "Scavenging Ooze"),(1, "Seasoned Pyromancer"),(1, "Abrade"),(4, "Collected Company"),(3, "Lightning Bolt"),(1, "Bloodstained Mire"),(1, "Breeding Pool"),(3, "Forest"),(2, "Kessig Wolf Run"),(1, "Mountain"),(1, "Sacred Foundry"),(3, "Stomping Ground"),(2, "Verdant Catacombs"),(4, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Blood Moon"),(2, "Damping Sphere"),(1, "Engineered Explosives"),(1, "Izzet Staticaster"),(2, "Magus of the Moon"),(2, "Mana Leak"),(3, "Path to Exile"),(2, "Rest in Peace") }; } }
    }
}