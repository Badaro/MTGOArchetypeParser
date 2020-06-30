using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_18
{
    public class Deck11_LSN_Burn_WR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Eidolon of the Great Revel"),(4, "Goblin Guide"),(4, "Monastery Swiftspear"),(4, "Lava Spike"),(4, "Rift Bolt"),(3, "Skewer the Critics"),(4, "Boros Charm"),(4, "Lightning Bolt"),(2, "Lightning Helix"),(4, "Searing Blaze"),(3, "Skullcrack"),(2, "Bloodstained Mire"),(1, "Fiery Islet"),(4, "Inspiring Vantage"),(3, "Mountain"),(2, "Sacred Foundry"),(2, "Scalding Tarn"),(4, "Sunbaked Canyon"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Skullcrack"),(1, "Grafdigger's Cage"),(3, "Kor Firewalker"),(3, "Path to Exile"),(2, "Rest in Peace"),(1, "Searing Blood"),(4, "Smash to Smithereens") }; } }
    }
}