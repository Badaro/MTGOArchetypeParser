using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck21_DemianDesposito10_Prowess_WR_Jegantha : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Abbot of Keral Keep"),(4, "Bomat Courier"),(1, "Bonecrusher Giant"),(1, "Grim Lavamancer"),(4, "Monastery Swiftspear"),(4, "Soul-Scar Mage"),(4, "Forked Bolt"),(4, "Lava Spike"),(4, "Light Up the Stage"),(4, "Lava Dart"),(4, "Lightning Bolt"),(4, "Mishra's Bauble"),(4, "Arid Mesa"),(4, "Bloodstained Mire"),(6, "Mountain"),(2, "Sacred Foundry"),(3, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Blood Moon"),(1, "Jegantha, the Wellspring"),(4, "Path to Exile"),(3, "Rest in Peace"),(4, "Wear // Tear") }; } }
    }
}