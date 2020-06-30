using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck50_Rvng_Prowess_R : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Bedlam Reveler"),(4, "Kiln Fiend"),(4, "Monastery Swiftspear"),(4, "Soul-Scar Mage"),(4, "Crash Through"),(4, "Lava Spike"),(4, "Light Up the Stage"),(2, "Burst Lightning"),(4, "Lava Dart"),(4, "Lightning Bolt"),(4, "Manamorphose"),(3, "Fiery Islet"),(14, "Mountain"),(1, "Sunbaked Canyon") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Abrade"),(1, "Bonecrusher Giant"),(3, "Dragon's Claw"),(3, "Grafdigger's Cage"),(3, "Magus of the Moon"),(2, "Saheeli, Sublime Artificer") }; } }
    }
}