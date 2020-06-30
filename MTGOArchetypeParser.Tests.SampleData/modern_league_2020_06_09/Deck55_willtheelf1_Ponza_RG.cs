using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck55_willtheelf1_Ponza_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Chandra, Torch of Defiance"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(4, "Glorybringer"),
            new SampleCard(3, "Klothys, God of Destiny"),
            new SampleCard(4, "Magus of the Moon"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(3, "Pillage"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(5, "Forest"),
            new SampleCard(2, "Mountain"),
            new SampleCard(1, "Prismatic Vista"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Choke"),
            new SampleCard(2, "Cindervines"),
            new SampleCard(1, "Courser of Kruphix"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Life Goes On"),
            new SampleCard(2, "Obstinate Baloth"),
            new SampleCard(2, "Relic of Progenitus") 
        };
    }
}