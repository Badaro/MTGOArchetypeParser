using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_07
{
    public class Deck56_AbelMolto_Burn_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Eidolon of the Great Revel"),
            new SampleCard(4, "Goblin Guide"),
            new SampleCard(1, "Grim Lavamancer"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Wild Nacatl"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(3, "Rift Bolt"),
            new SampleCard(4, "Atarka's Command"),
            new SampleCard(4, "Boros Charm"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Searing Blaze"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Copperline Gorge"),
            new SampleCard(2, "Mountain"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(1, "Scalding Tarn"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Deflecting Palm"),
            new SampleCard(4, "Destructive Revelry"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Rest in Peace"),
            new SampleCard(3, "Searing Blood") 
        };
    }
}