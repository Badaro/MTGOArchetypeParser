using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck33_BabaBaws94_Prowess_WR_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Abbot of Keral Keep"),
            new SampleCard(1, "Bedlam Reveler"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Crash Through"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(2, "Burst Lightning"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(3, "Seal of Fire"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(4, "Mountain"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(4, "Sunbaked Canyon"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Dragon's Claw"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(2, "Tormod's Crypt"),
            new SampleCard(4, "Wear // Tear") 
        };
    }
}