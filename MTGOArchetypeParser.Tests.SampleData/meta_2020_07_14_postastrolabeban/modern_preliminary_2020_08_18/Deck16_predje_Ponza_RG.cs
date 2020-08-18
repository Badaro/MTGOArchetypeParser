using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_preliminary_2020_08_18
{
    public class Deck16_predje_Ponza_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Chandra, Torch of Defiance"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(3, "Glorybringer"),
            new SampleCard(3, "Klothys, God of Destiny"),
            new SampleCard(3, "Magus of the Moon"),
            new SampleCard(1, "Questing Beast"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(3, "Seasoned Pyromancer"),
            new SampleCard(2, "Tireless Tracker"),
            new SampleCard(3, "Pillage"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Blood Moon"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(6, "Forest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Prismatic Vista"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(1, "Boil"),
            new SampleCard(1, "Choke"),
            new SampleCard(2, "Cindervines"),
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(1, "Elder Gargaroth"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Obstinate Baloth"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(1, "Weather the Storm") 
        };
    }
}