using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck47_MagicRainbows_Burn_R : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Chandra's Incinerator"),(3, "Eidolon of the Great Revel"),(2, "Grim Lavamancer"),(4, "Monastery Swiftspear"),(4, "Vexing Devil"),(4, "Lava Spike"),(4, "Rift Bolt"),(4, "Skewer the Critics"),(4, "Lightning Bolt"),(3, "Shard Volley"),(4, "Seal of Fire"),(20, "Mountain") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Dragon's Claw"),(3, "Searing Blood"),(2, "Shrine of Burning Rage"),(2, "Skullcrack"),(4, "Smash to Smithereens"),(3, "Soul-Guide Lantern") }; } }
    }
}