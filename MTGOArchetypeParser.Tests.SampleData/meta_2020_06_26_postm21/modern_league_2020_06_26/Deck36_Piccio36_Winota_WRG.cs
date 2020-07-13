using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_06_26
{
    public class Deck36_Piccio36_Winota_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Angrath's Marauders"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(1, "Magus of the Moon"),
            new SampleCard(1, "Pia and Kiran Nalaar"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Strangleroot Geist"),
            new SampleCard(3, "Voice of Resurgence"),
            new SampleCard(4, "Winota, Joiner of Forces"),
            new SampleCard(4, "Eldritch Evolution"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Smuggler's Copter"),
            new SampleCard(4, "Copperline Gorge"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(3, "Stomping Ground"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Avalanche Riders"),
            new SampleCard(2, "Caustic Caterpillar"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Ethersworn Canonist"),
            new SampleCard(1, "Gaddock Teeg"),
            new SampleCard(2, "Knight of Autumn"),
            new SampleCard(1, "Linvala, Keeper of Silence"),
            new SampleCard(1, "Obstinate Baloth"),
            new SampleCard(1, "Path to Exile"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Thrun, the Last Troll") 
        };
    }
}