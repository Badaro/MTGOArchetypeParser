using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_15
{
    public class Deck31_ilsecco14_Ponza_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Wrenn and Six"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(4, "Glorybringer"),
            new SampleCard(2, "Klothys, God of Destiny"),
            new SampleCard(2, "Magus of the Moon"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(3, "Pillage"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Blood Moon"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(6, "Forest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Anger of the Gods"),
            new SampleCard(2, "Choke"),
            new SampleCard(2, "Cindervines"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Kitchen Finks"),
            new SampleCard(2, "Obstinate Baloth"),
            new SampleCard(2, "Relic of Progenitus") 
        };
    }
}