using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_18
{
    public class Deck10_Stompy45_Ponza_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Chandra, Torch of Defiance"),
            new SampleCard(1, "Wrenn and Six"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(1, "Birds of Paradise"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(3, "Glorybringer"),
            new SampleCard(3, "Klothys, God of Destiny"),
            new SampleCard(4, "Magus of the Moon"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(2, "Pillage"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(5, "Forest"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(2, "Mountain"),
            new SampleCard(2, "Prismatic Vista"),
            new SampleCard(3, "Stomping Ground"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(2, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Pillage"),
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Cindervines"),
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(3, "Grafdigger's Cage"),
            new SampleCard(2, "Kitchen Finks"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}