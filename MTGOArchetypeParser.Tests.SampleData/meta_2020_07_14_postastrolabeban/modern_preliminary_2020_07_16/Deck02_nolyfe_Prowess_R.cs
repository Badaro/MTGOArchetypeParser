using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_07_16
{
    public class Deck02_nolyfe_Prowess_R : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Bedlam Reveler"),
            new SampleCard(2, "Kiln Fiend"),
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
            new SampleCard(13, "Mountain"),
            new SampleCard(4, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Abrade"),
            new SampleCard(1, "Bonecrusher Giant"),
            new SampleCard(1, "Dismember"),
            new SampleCard(3, "Dragon's Claw"),
            new SampleCard(1, "Kozilek's Return"),
            new SampleCard(2, "Shrine of Burning Rage"),
            new SampleCard(4, "Soul-Guide Lantern") 
        };
    }
}