using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_06_30
{
    public class Deck21_DemianDesposito10_Prowess_WR_Jegantha : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Abbot of Keral Keep"),
            new SampleCard(4, "Bomat Courier"),
            new SampleCard(1, "Bonecrusher Giant"),
            new SampleCard(1, "Grim Lavamancer"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Forked Bolt"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(4, "Arid Mesa"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(6, "Mountain"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Blood Moon"),
            new SampleCard(1, "Jegantha, the Wellspring"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(4, "Wear // Tear") 
        };
    }
}