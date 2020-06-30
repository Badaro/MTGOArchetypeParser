using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14
{
    public class Deck27_SebastianStueckl_Ponza_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Chandra, Torch of Defiance"),
            new SampleCard(1, "Domri, Anarch of Bolas"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(2, "Glorybringer"),
            new SampleCard(2, "Hexdrinker"),
            new SampleCard(3, "Klothys, God of Destiny"),
            new SampleCard(4, "Magus of the Moon"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(2, "Misty Rainforest"),
            new SampleCard(6, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(2, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Choke"),
            new SampleCard(2, "Cindervines"),
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(1, "Obstinate Baloth"),
            new SampleCard(2, "Pillage"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}