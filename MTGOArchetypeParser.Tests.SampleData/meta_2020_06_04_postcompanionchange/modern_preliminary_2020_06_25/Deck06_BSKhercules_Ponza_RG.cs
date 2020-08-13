using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_25
{
    public class Deck06_BSKhercules_Ponza_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Chandra, Torch of Defiance"),
            new SampleCard(2, "Wrenn and Six"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(2, "Bonecrusher Giant"),
            new SampleCard(4, "Glorybringer"),
            new SampleCard(3, "Klothys, God of Destiny"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(3, "Pillage"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Blood Moon"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(6, "Forest"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(2, "Verdant Catacombs"),
            new SampleCard(2, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Anger of the Gods"),
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Cindervines"),
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(3, "Kitchen Finks"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}