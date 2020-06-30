using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck24_DemianDesposito10_Prowess_R : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Abbot of Keral Keep"),(1, "Bonecrusher Giant"),(4, "Goblin Guide"),(1, "Grim Lavamancer"),(4, "Monastery Swiftspear"),(4, "Soul-Scar Mage"),(4, "Forked Bolt"),(4, "Lava Spike"),(4, "Light Up the Stage"),(4, "Lava Dart"),(4, "Lightning Bolt"),(4, "Mishra's Bauble"),(3, "Arid Mesa"),(2, "Bloodstained Mire"),(4, "Fiery Islet"),(4, "Mountain"),(4, "Sunbaked Canyon"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Blood Moon"),(2, "Dragon's Claw"),(4, "Leyline of the Void"),(3, "Reality Hemorrhage"),(4, "Smash to Smithereens") }; } }
    }
}