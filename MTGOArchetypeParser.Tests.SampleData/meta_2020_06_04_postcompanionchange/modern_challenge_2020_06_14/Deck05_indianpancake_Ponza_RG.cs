using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_challenge_2020_06_14
{
    public class Deck05_indianpancake_Ponza_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Chandra, Torch of Defiance"),
            new SampleCard(2, "Wrenn and Six"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(4, "Glorybringer"),
            new SampleCard(3, "Klothys, God of Destiny"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(3, "Pillage"),
            new SampleCard(1, "Burst Lightning"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Blood Moon"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(4, "Misty Rainforest"),
            new SampleCard(6, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(1, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(1, "Boil"),
            new SampleCard(2, "Choke"),
            new SampleCard(1, "Cindervines"),
            new SampleCard(1, "Collector Ouphe"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(2, "Kitchen Finks"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(1, "Tireless Tracker"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}