using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_11
{
    public class Deck08_Charlesjacenorman_Burn_WR_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Eidolon of the Great Revel"),(4, "Goblin Guide"),(1, "Grim Lavamancer"),(4, "Monastery Swiftspear"),(4, "Lava Spike"),(3, "Rift Bolt"),(3, "Skewer the Critics"),(4, "Boros Charm"),(4, "Lightning Bolt"),(4, "Lightning Helix"),(3, "Searing Blaze"),(2, "Skullcrack"),(1, "Bloodstained Mire"),(2, "Fiery Islet"),(4, "Inspiring Vantage"),(3, "Mountain"),(2, "Sacred Foundry"),(4, "Sunbaked Canyon"),(4, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Deafening Silence"),(4, "Dragon's Claw"),(1, "Lurrus of the Dream Den"),(3, "Path to Exile"),(1, "Relic of Progenitus"),(1, "Soul-Guide Lantern"),(2, "Wear // Tear") }; } }
    }
}