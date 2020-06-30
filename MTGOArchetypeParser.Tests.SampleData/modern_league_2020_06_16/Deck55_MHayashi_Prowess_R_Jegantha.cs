using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck55_MHayashi_Prowess_R_Jegantha : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Abbot of Keral Keep"),(4, "Bomat Courier"),(4, "Bonecrusher Giant"),(4, "Monastery Swiftspear"),(4, "Soul-Scar Mage"),(4, "Light Up the Stage"),(4, "Burst Lightning"),(4, "Lava Dart"),(4, "Lightning Bolt"),(4, "Seal of Fire"),(16, "Mountain"),(4, "Ramunap Ruins") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (4, "Abrade"),(2, "Blood Moon"),(1, "Jegantha, the Wellspring"),(4, "Ratchet Bomb"),(4, "Relic of Progenitus") }; } }
    }
}