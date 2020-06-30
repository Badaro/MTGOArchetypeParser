using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_26
{
    public class Deck09_esatheking_Prowess_WR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Bedlam Reveler"),
            new SampleCard(1, "Electrostatic Field"),
            new SampleCard(4, "Kiln Fiend"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Crash Through"),
            new SampleCard(1, "Finale of Promise"),
            new SampleCard(2, "Firebolt"),
            new SampleCard(2, "Forked Bolt"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(1, "Burst Lightning"),
            new SampleCard(3, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(2, "Mutagenic Growth"),
            new SampleCard(1, "Mishra's Bauble"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(4, "Mountain"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(2, "Sunbaked Canyon"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Bedlam Reveler"),
            new SampleCard(1, "Dragon's Claw"),
            new SampleCard(2, "Kor Firewalker"),
            new SampleCard(1, "Lightning Helix"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(2, "Tormod's Crypt"),
            new SampleCard(4, "Wear // Tear") 
        };
    }
}