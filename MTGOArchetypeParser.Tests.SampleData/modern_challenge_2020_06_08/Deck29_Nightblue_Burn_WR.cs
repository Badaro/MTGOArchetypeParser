using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_08
{
    public class Deck29_Nightblue_Burn_WR : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Eidolon of the Great Revel"),(4, "Goblin Guide"),(1, "Grim Lavamancer"),(4, "Monastery Swiftspear"),(4, "Lava Spike"),(4, "Rift Bolt"),(1, "Skewer the Critics"),(4, "Boros Charm"),(4, "Lightning Bolt"),(4, "Lightning Helix"),(3, "Searing Blaze"),(3, "Skullcrack"),(2, "Bloodstained Mire"),(2, "Fiery Islet"),(4, "Inspiring Vantage"),(3, "Mountain"),(2, "Sacred Foundry"),(4, "Sunbaked Canyon"),(3, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Deafening Silence"),(1, "Deflecting Palm"),(2, "Grafdigger's Cage"),(3, "Kor Firewalker"),(3, "Path to Exile"),(2, "Searing Blood"),(2, "Wear // Tear") }; } }
    }
}