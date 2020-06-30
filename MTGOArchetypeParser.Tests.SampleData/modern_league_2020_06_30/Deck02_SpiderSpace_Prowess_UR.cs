using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck02_SpiderSpace_Prowess_UR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Bedlam Reveler"),(4, "Monastery Swiftspear"),(4, "Soul-Scar Mage"),(2, "Sprite Dragon"),(4, "Stormwing Entity"),(3, "Crash Through"),(4, "Light Up the Stage"),(2, "Of One Mind"),(4, "Gut Shot"),(4, "Lava Dart"),(4, "Lightning Bolt"),(4, "Manamorphose"),(2, "Mutagenic Growth"),(2, "Fiery Islet"),(4, "Scalding Tarn"),(4, "Snow-Covered Mountain"),(4, "Spirebluff Canal"),(2, "Steam Vents"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Abrade"),(3, "Aether Gust"),(2, "Assault Strobe"),(1, "Blood Moon"),(2, "Dragon's Claw"),(3, "Mystical Dispute"),(2, "Surgical Extraction") }; } }
    }
}