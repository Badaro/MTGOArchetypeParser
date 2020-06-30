using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_19
{
    public class Deck03_qbturtle15_Ponza_RG_Obosh : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(2, "Birds of Paradise"),
            new SampleCard(4, "Bonecrusher Giant"),
            new SampleCard(4, "Glorybringer"),
            new SampleCard(4, "Kitchen Finks"),
            new SampleCard(3, "Klothys, God of Destiny"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Pillage"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Blood Moon"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(5, "Forest"),
            new SampleCard(1, "Misty Rainforest"),
            new SampleCard(2, "Mountain"),
            new SampleCard(2, "Prismatic Vista"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(1, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Flame Slash"),
            new SampleCard(3, "Grafdigger's Cage"),
            new SampleCard(1, "Life Goes On"),
            new SampleCard(2, "Molten Rain"),
            new SampleCard(2, "Natural State"),
            new SampleCard(1, "Obosh, the Preypiercer"),
            new SampleCard(2, "Thragtusk"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}