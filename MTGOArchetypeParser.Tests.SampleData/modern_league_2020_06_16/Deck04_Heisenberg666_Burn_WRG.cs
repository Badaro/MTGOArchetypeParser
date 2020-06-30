using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck04_Heisenberg666_Burn_WRG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Eidolon of the Great Revel"),(4, "Goblin Guide"),(4, "Monastery Swiftspear"),(4, "Vexing Devil"),(4, "Lava Spike"),(4, "Atarka's Command"),(4, "Boros Charm"),(4, "Lightning Bolt"),(4, "Lightning Helix"),(4, "Searing Blaze"),(3, "Bloodstained Mire"),(3, "Copperline Gorge"),(3, "Inspiring Vantage"),(2, "Mountain"),(2, "Sacred Foundry"),(2, "Stomping Ground"),(2, "Sunbaked Canyon"),(3, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Alpine Moon"),(4, "Destructive Revelry"),(4, "Leyline of Combustion"),(3, "Path to Exile"),(1, "Ravenous Trap"),(2, "Relic of Progenitus") }; } }
    }
}