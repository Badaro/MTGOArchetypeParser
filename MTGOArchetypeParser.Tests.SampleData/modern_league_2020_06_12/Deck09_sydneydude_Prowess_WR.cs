using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck09_sydneydude_Prowess_WR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Blistercoil Weird"),
            new SampleCard(4, "Kiln Fiend"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Crash Through"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(4, "Gut Shot"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Mutagenic Growth"),
            new SampleCard(4, "Arid Mesa"),
            new SampleCard(3, "Inspiring Vantage"),
            new SampleCard(3, "Mountain"),
            new SampleCard(3, "Sacred Foundry"),
            new SampleCard(3, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Bedlam Reveler"),
            new SampleCard(4, "Kor Firewalker"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(3, "Wear // Tear") 
        };
    }
}