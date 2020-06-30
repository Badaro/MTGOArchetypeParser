using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_23
{
    public class Deck32_thepensword_Prowess_R : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Bedlam Reveler"),
            new SampleCard(3, "Kiln Fiend"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Crash Through"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(2, "Burst Lightning"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(2, "Mutagenic Growth"),
            new SampleCard(4, "Fiery Islet"),
            new SampleCard(14, "Mountain") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Abrade"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(4, "Dragon's Claw"),
            new SampleCard(1, "Flame Slash"),
            new SampleCard(1, "Pyroclasm"),
            new SampleCard(3, "Soul-Guide Lantern") 
        };
    }
}