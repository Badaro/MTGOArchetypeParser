using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_17
{
    public class Deck16_bkorbsquare07_Prowess_WR : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(4, "Kiln Fiend"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Crash Through"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Mutagenic Growth"),
            new SampleCard(4, "Temur Battle Rage"),
            new SampleCard(3, "Bloodstained Mire"),
            new SampleCard(4, "Inspiring Vantage"),
            new SampleCard(4, "Mountain"),
            new SampleCard(4, "Sacred Foundry"),
            new SampleCard(3, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Bedlam Reveler"),
            new SampleCard(3, "Flame Slash"),
            new SampleCard(4, "Kor Firewalker"),
            new SampleCard(1, "Molten Rain"),
            new SampleCard(4, "Path to Exile") 
        };
    }
}