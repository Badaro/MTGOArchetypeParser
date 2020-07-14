using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_14
{
    public class Deck51_KoDiamonds_Ponza_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Chandra, Torch of Defiance"),
            new SampleCard(2, "Wrenn and Six"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(3, "Bonecrusher Giant"),
            new SampleCard(3, "Glorybringer"),
            new SampleCard(3, "Klothys, God of Destiny"),
            new SampleCard(2, "Magus of the Moon"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(5, "Forest"),
            new SampleCard(1, "Kessig Wolf Run"),
            new SampleCard(1, "Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(4, "Verdant Catacombs"),
            new SampleCard(2, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Blood Moon"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(1, "Boil"),
            new SampleCard(2, "Cindervines"),
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(1, "Obstinate Baloth"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(1, "Trinisphere"),
            new SampleCard(1, "Veil of Summer") 
        };
    }
}