using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_08_17
{
    public class Deck15_nahuel10_Ponza_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Chandra, Torch of Defiance"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(1, "Birds of Paradise"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(4, "Elder Gargaroth"),
            new SampleCard(3, "Klothys, God of Destiny"),
            new SampleCard(1, "Scavenging Ooze"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(3, "Pillage"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Blood Moon"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(5, "Forest"),
            new SampleCard(2, "Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Anger of the Gods"),
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Choke"),
            new SampleCard(2, "Cindervines"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Obstinate Baloth"),
            new SampleCard(1, "Relic of Progenitus"),
            new SampleCard(1, "Thrun, the Last Troll"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}