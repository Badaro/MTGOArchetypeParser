using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck58_abijhavs_Prowess_R : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Bedlam Reveler"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(3, "Runaway Steam-Kin"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Crash Through"),
            new SampleCard(2, "Firebolt"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(2, "Burst Lightning"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(2, "Fiery Islet"),
            new SampleCard(14, "Mountain"),
            new SampleCard(2, "Sunbaked Canyon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Abrade"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(2, "Dragon's Claw"),
            new SampleCard(3, "Grafdigger's Cage"),
            new SampleCard(2, "Kozilek's Return"),
            new SampleCard(2, "Shrine of Burning Rage") 
        };
    }
}