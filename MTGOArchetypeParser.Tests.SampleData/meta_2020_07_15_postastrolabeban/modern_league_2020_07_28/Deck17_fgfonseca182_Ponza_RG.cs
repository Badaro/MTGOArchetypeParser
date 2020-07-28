using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck17_fgfonseca182_Ponza_RG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Chandra, Torch of Defiance"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(1, "Birds of Paradise"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(3, "Bonecrusher Giant"),
            new SampleCard(3, "Glorybringer"),
            new SampleCard(3, "Klothys, God of Destiny"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Pillage"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Blood Moon"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(6, "Forest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(4, "Stomping Ground"),
            new SampleCard(1, "Verdant Catacombs"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Anger of the Gods"),
            new SampleCard(2, "Boil"),
            new SampleCard(2, "Cindervines"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(1, "Obstinate Baloth"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(1, "Thrun, the Last Troll"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}