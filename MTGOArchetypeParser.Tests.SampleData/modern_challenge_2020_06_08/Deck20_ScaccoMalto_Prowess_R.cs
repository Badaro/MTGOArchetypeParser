using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_08
{
    public class Deck20_ScaccoMalto_Prowess_R : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Bedlam Reveler"),
            new SampleCard(2, "Kiln Fiend"),
            new SampleCard(4, "Monastery Swiftspear"),
            new SampleCard(2, "Runaway Steam-Kin"),
            new SampleCard(4, "Soul-Scar Mage"),
            new SampleCard(4, "Crash Through"),
            new SampleCard(4, "Lava Spike"),
            new SampleCard(4, "Light Up the Stage"),
            new SampleCard(2, "Burst Lightning"),
            new SampleCard(4, "Lava Dart"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Manamorphose"),
            new SampleCard(4, "Fiery Islet"),
            new SampleCard(14, "Mountain") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Abrade"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(1, "Kozilek's Return"),
            new SampleCard(1, "Saheeli, Sublime Artificer"),
            new SampleCard(2, "Shrine of Burning Rage"),
            new SampleCard(2, "Sorcerous Spyglass"),
            new SampleCard(3, "Tormod's Crypt") 
        };
    }
}