using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_28
{
    public class Deck21_MHayashi_RedDeckWins_R_Obosh : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Blistercoil Weird"),
            new SampleCard(4, "Bomat Courier"),
            new SampleCard(4, "Bonecrusher Giant"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Firebolt"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(4, "Burst Lightning"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Fiery Islet"),
            new SampleCard(18, "Mountain"),
            new SampleCard(1, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Blood Moon"),
            new SampleCard(2, "Kozilek's Return"),
            new SampleCard(1, "Obosh, the Preypiercer"),
            new SampleCard(4, "Relic of Progenitus"),
            new SampleCard(4, "Shattering Spree") 
        };
    }
}