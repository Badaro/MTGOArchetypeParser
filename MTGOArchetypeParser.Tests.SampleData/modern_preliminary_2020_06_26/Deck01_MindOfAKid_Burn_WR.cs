using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_26
{
    public class Deck01_MindOfAKid_Burn_WR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Eidolon of the Great Revel"),(4, "Goblin Guide"),(4, "Monastery Swiftspear"),(4, "Lava Spike"),(4, "Rift Bolt"),(4, "Skewer the Critics"),(4, "Boros Charm"),(4, "Lightning Bolt"),(4, "Lightning Helix"),(2, "Searing Blaze"),(2, "Skullcrack"),(2, "Arid Mesa"),(1, "Fiery Islet"),(4, "Inspiring Vantage"),(3, "Sacred Foundry"),(4, "Scalding Tarn"),(2, "Snow-Covered Mountain"),(4, "Sunbaked Canyon") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Searing Blaze"),(2, "Skullcrack"),(2, "Kor Firewalker"),(1, "Lurrus of the Dream-Den"),(3, "Path to Exile"),(2, "Rest in Peace"),(3, "Smash to Smithereens") }; } }
    }
}