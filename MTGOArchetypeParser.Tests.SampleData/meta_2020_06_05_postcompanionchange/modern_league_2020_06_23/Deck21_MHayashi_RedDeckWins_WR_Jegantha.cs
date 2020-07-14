using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_23
{
    public class Deck21_MHayashi_RedDeckWins_WR_Jegantha : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Abbot of Keral Keep"),
            new SampleCard(4, "Bomat Courier"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Firebolt"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(4, "Burst Lightning"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Seal of Fire"),
            new SampleCard(4, "Arid Mesa"),
            new SampleCard(4, "Bloodstained Mire"),
            new SampleCard(6, "Mountain"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Blood Moon"),
            new SampleCard(1, "Jegantha, the Wellspring"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(4, "Relic of Progenitus"),
            new SampleCard(4, "Wear // Tear") 
        };
    }
}