using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck09_esatheking_Prowess_WR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Bedlam Reveler"),(1, "Electrostatic Field"),(4, "Kiln Fiend"),(4, "Monastery Swiftspear"),(4, "Soul-Scar Mage"),(4, "Crash Through"),(1, "Finale of Promise"),(2, "Firebolt"),(2, "Forked Bolt"),(4, "Light Up the Stage"),(1, "Burst Lightning"),(3, "Lava Dart"),(4, "Lightning Bolt"),(4, "Manamorphose"),(2, "Mutagenic Growth"),(1, "Mishra's Bauble"),(2, "Arid Mesa"),(4, "Inspiring Vantage"),(4, "Mountain"),(2, "Sacred Foundry"),(2, "Sunbaked Canyon"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Bedlam Reveler"),(1, "Dragon's Claw"),(2, "Kor Firewalker"),(1, "Lightning Helix"),(4, "Path to Exile"),(2, "Tormod's Crypt"),(4, "Wear // Tear") }; } }
    }
}