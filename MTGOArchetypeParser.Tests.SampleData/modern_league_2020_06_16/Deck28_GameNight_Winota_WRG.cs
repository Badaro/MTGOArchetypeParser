using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck28_GameNight_Winota_WRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Angrath's Marauders"),(4, "Arbor Elf"),(2, "Avalanche Riders"),(4, "Birds of Paradise"),(4, "Goblin Rabblemaster"),(4, "Huntmaster of the Fells"),(4, "Magus of the Moon"),(2, "Pia Nalaar"),(4, "Seasoned Pyromancer"),(4, "Winota, Joiner of Forces"),(4, "Utopia Sprawl"),(5, "Forest"),(1, "Mountain"),(1, "Plains"),(1, "Sacred Foundry"),(3, "Stomping Ground"),(1, "Temple Garden"),(4, "Windswept Heath"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Anger of the Gods"),(2, "Choke"),(2, "Cindervines"),(3, "Collector Ouphe"),(4, "Kitchen Finks"),(2, "Relic of Progenitus") }; } }
    }
}