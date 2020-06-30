using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_30
{
    public class Deck15_FEARnLOATHing_Prowess_UR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Monastery Swiftspear"),(4, "Soul-Scar Mage"),(4, "Stormwing Entity"),(4, "Lava Spike"),(4, "Light Up the Stage"),(4, "Rift Bolt"),(4, "Gut Shot"),(4, "Lava Dart"),(4, "Lightning Bolt"),(4, "Manamorphose"),(4, "Fiery Islet"),(1, "Island"),(3, "Mountain"),(4, "Scalding Tarn"),(4, "Spirebluff Canal"),(4, "Steam Vents") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Abrade"),(2, "Aether Gust"),(1, "Dragon's Claw"),(3, "Grafdigger's Cage"),(1, "Shrine of Burning Rage"),(3, "Skullcrack"),(2, "Surgical Extraction") }; } }
    }
}