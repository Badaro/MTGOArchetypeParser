using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck38_NeverDidntHaveIt_Prowess_WR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Blistercoil Weird"),(4, "Kiln Fiend"),(4, "Monastery Swiftspear"),(4, "Soul-Scar Mage"),(4, "Crash Through"),(4, "Light Up the Stage"),(4, "Gut Shot"),(4, "Lava Dart"),(4, "Lightning Bolt"),(4, "Manamorphose"),(4, "Mutagenic Growth"),(2, "Temur Battle Rage"),(3, "Bloodstained Mire"),(2, "Inspiring Vantage"),(3, "Mountain"),(3, "Sacred Foundry"),(3, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Alpine Moon"),(4, "Bedlam Reveler"),(4, "Kor Firewalker"),(4, "Path to Exile"),(2, "Reality Hemorrhage") }; } }
    }
}