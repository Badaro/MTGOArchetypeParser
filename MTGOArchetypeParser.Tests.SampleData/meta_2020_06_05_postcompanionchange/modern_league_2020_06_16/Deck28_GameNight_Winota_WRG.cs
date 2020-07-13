using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_16
{
    public class Deck28_GameNight_Winota_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Angrath's Marauders"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(2, "Avalanche Riders"),
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(4, "Goblin Rabblemaster"),
            new SampleCard(4, "Huntmaster of the Fells"),
            new SampleCard(4, "Magus of the Moon"),
            new SampleCard(2, "Pia Nalaar"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Winota, Joiner of Forces"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(5, "Forest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(3, "Stomping Ground"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Choke"),
            new SampleCard(2, "Cindervines"),
            new SampleCard(3, "Collector Ouphe"),
            new SampleCard(4, "Kitchen Finks"),
            new SampleCard(2, "Relic of Progenitus") 
        };
    }
}