using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck24_Ghost_Burn_WRG : ISampleDeck
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
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(4, "Copperline Gorge"),
            new SampleCard(2, "Mountain"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(2, "Scalding Tarn"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Destructive Revelry"),
            new SampleCard(4, "Leyline of Combustion"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Rest in Peace") 
        };
    }
}