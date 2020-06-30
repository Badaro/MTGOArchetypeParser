using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck14_Voltzwagon_Ponza_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Chandra, Torch of Defiance"),
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(4, "Glorybringer"),
            new SampleCard(3, "Klothys, God of Destiny"),
            new SampleCard(4, "Magus of the Moon"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(5, "Forest"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(1, "Tranquil Thicket"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(3, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Boil"),
            new SampleCard(1, "Chandra's Defeat"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Obstinate Baloth"),
            new SampleCard(3, "Pillage"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(2, "Tireless Tracker") 
        };
    }
}