using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck18_Praxifi_Winota_WRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Angrath's Marauders"),(4, "Birds of Paradise"),(2, "Goblin Rabblemaster"),(4, "Llanowar Elves"),(4, "Seasoned Pyromancer"),(4, "Strangleroot Geist"),(3, "Voice of Resurgence"),(4, "Winota, Joiner of Forces"),(4, "Eldritch Evolution"),(3, "Lightning Bolt"),(2, "Smuggler's Copter"),(1, "Cavern of Souls"),(4, "Copperline Gorge"),(1, "Horizon Canopy"),(1, "Razorverge Thicket"),(1, "Sacred Foundry"),(1, "Snow-Covered Forest"),(1, "Snow-Covered Mountain"),(2, "Stomping Ground"),(2, "Temple Garden"),(4, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Avalanche Riders"),(2, "Choke"),(1, "Gaddock Teeg"),(1, "Knight of Autumn"),(2, "Path to Exile"),(3, "Rest in Peace"),(3, "Timely Reinforcements") }; } }
    }
}