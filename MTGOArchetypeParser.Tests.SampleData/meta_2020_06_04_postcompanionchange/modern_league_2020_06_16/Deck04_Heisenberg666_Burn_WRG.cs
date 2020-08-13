using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_16
{
    public class Deck04_Heisenberg666_Burn_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Eidolon of the Great Revel"),
            new SampleCard(4, "Goblin Guide"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Vexing Devil"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Atarka's Command"),
            new SampleCard(4, "Boros Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Lightning Helix"),
            new SampleCard(4, "Searing Blaze"),
            new SampleCard(3, "Bloodstained Mire"),
            new SampleCard(3, "Copperline Gorge"),
            new SampleCard(3, "Inspiring Vantage"),
            new SampleCard(2, "Mountain"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(2, "Sunbaked Canyon"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Alpine Moon"),
            new SampleCard(4, "Destructive Revelry"),
            new SampleCard(4, "Leyline of Combustion"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(1, "Ravenous Trap"),
            new SampleCard(2, "Relic of Progenitus") 
        };
    }
}