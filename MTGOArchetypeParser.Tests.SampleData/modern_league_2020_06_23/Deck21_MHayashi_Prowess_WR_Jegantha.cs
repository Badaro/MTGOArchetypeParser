using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck21_MHayashi_Prowess_WR_Jegantha : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Abbot of Keral Keep"),(4, "Bomat Courier"),(4, "Monastery Swiftspear"),(4, "Soul-Scar Mage"),(4, "Firebolt"),(4, "Light Up the Stage"),(4, "Burst Lightning"),(4, "Lava Dart"),(4, "Lightning Bolt"),(4, "Seal of Fire"),(4, "Arid Mesa"),(4, "Bloodstained Mire"),(6, "Mountain"),(2, "Sacred Foundry"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Blood Moon"),(1, "Jegantha, the Wellspring"),(4, "Path to Exile"),(4, "Relic of Progenitus"),(4, "Wear // Tear") }; } }
    }
}