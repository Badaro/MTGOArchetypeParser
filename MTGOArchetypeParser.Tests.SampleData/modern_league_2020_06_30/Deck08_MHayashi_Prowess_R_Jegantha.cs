using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck08_MHayashi_Prowess_R_Jegantha : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Abbot of Keral Keep"),(4, "Bonecrusher Giant"),(4, "Grim Lavamancer"),(4, "Monastery Swiftspear"),(4, "Soul-Scar Mage"),(4, "Firebolt"),(4, "Light Up the Stage"),(4, "Burst Lightning"),(4, "Lava Dart"),(4, "Lightning Bolt"),(4, "Bloodstained Mire"),(12, "Mountain"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (4, "Abrade"),(1, "Jegantha, the Wellspring"),(4, "Magus of the Moon"),(2, "Ratchet Bomb"),(4, "Relic of Progenitus") }; } }
    }
}