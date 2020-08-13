using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_challenge_2020_08_12
{
    public class Deck28_HIziri88_Ponza_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Chandra, Torch of Defiance"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(1, "Bonecrusher Giant"),
            new SampleCard(4, "Glorybringer"),
            new SampleCard(3, "Klothys, God of Destiny"),
            new SampleCard(4, "Magus of the Moon"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(3, "Pillage"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(2, "Smuggler's Copter"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(6, "Forest"),
            new SampleCard(2, "Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Abrade"),
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(1, "Boil"),
            new SampleCard(2, "Choke"),
            new SampleCard(2, "Cindervines"),
            new SampleCard(3, "Grafdigger's Cage"),
            new SampleCard(2, "Kitchen Finks"),
            new SampleCard(2, "Obstinate Baloth") 
        };
    }
}