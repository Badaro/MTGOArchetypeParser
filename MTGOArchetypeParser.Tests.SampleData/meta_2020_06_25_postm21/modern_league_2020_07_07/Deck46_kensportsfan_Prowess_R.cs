using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07
{
    public class Deck46_kensportsfan_Prowess_R : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Bedlam Reveler"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Crash Through"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(2, "Wild Slash"),
            new SampleCard(4, "Mishra's Bauble"),
            new SampleCard(2, "Fiery Islet"),
            new SampleCard(14, "Mountain"),
            new SampleCard(2, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Abrade"),
            new SampleCard(3, "Bonecrusher Giant"),
            new SampleCard(4, "Dragon's Claw"),
            new SampleCard(1, "Shenanigans"),
            new SampleCard(4, "Surgical Extraction") 
        };
    }
}