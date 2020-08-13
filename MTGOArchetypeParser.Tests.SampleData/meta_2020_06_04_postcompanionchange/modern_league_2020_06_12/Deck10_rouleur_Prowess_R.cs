using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_12
{
    public class Deck10_rouleur_Prowess_R : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Bedlam Reveler"),
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(3, "Runaway Steam-Kin"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Crash Through"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(3, "Burst Lightning"),
            new SampleCard(3, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Fiery Islet"),
            new SampleCard(14, "Mountain") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(1, "Blood Moon"),
            new SampleCard(1, "Boil"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Dragon's Claw"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Kozilek's Return"),
            new SampleCard(1, "Shrine of Burning Rage"),
            new SampleCard(2, "Tormod's Crypt") 
        };
    }
}