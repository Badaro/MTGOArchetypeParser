using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_07_19
{
    public class Deck27_Vonducky_Prowess_WR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Bedlam Reveler"),
            new SampleCard(4, "Kiln Fiend"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Crash Through"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(1, "Boros Charm"),
            new SampleCard(1, "Burst Lightning"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Mutagenic Growth"),
            new SampleCard(2, "Temur Battle Rage"),
            new SampleCard(1, "Bloodstained Mire"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(4, "Mountain"),
            new SampleCard(4, "Sacred Foundry"),
            new SampleCard(3, "Sunbaked Canyon"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Bedlam Reveler"),
            new SampleCard(3, "Abrade"),
            new SampleCard(4, "Kor Firewalker"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(3, "Tormod's Crypt") 
        };
    }
}