using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21
{
    public class Deck31_NewHJ_Burn_WRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Eidolon of the Great Revel"),(4, "Goblin Guide"),(4, "Monastery Swiftspear"),(4, "Lava Spike"),(4, "Rift Bolt"),(4, "Skewer the Critics"),(4, "Boros Charm"),(4, "Lightning Bolt"),(4, "Lightning Helix"),(4, "Searing Blaze"),(1, "Skullcrack"),(2, "Arid Mesa"),(2, "Bloodstained Mire"),(3, "Inspiring Vantage"),(2, "Mountain"),(2, "Sacred Foundry"),(1, "Scalding Tarn"),(1, "Stomping Ground"),(4, "Sunbaked Canyon"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Skullcrack"),(1, "Deflecting Palm"),(4, "Destructive Revelry"),(2, "Exquisite Firecraft"),(2, "Path to Exile"),(2, "Rest in Peace"),(2, "Searing Blood") }; } }
    }
}