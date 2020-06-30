using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_11
{
    public class Deck02_LordBeerus_Burn_WR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Eidolon of the Great Revel"),(4, "Goblin Guide"),(4, "Monastery Swiftspear"),(4, "Lava Spike"),(4, "Rift Bolt"),(4, "Skewer the Critics"),(4, "Boros Charm"),(4, "Lightning Bolt"),(3, "Lightning Helix"),(4, "Searing Blaze"),(1, "Skullcrack"),(4, "Arid Mesa"),(1, "Fiery Islet"),(4, "Inspiring Vantage"),(2, "Sacred Foundry"),(2, "Scalding Tarn"),(3, "Snow-Covered Mountain"),(4, "Sunbaked Canyon") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Skullcrack"),(1, "Kor Firewalker"),(3, "Path to Exile"),(3, "Rest in Peace"),(1, "Searing Blood"),(4, "Smash to Smithereens") }; } }
    }
}