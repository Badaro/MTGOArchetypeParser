using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_challenge_2020_06_21
{
    public class Deck16_Archgaze_Winota_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Angrath's Marauders"),
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(1, "Magus of the Moon"),
            new SampleCard(1, "Resolute Blademaster"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Strangleroot Geist"),
            new SampleCard(3, "Voice of Resurgence"),
            new SampleCard(4, "Winota, Joiner of Forces"),
            new SampleCard(4, "Eldritch Evolution"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Smuggler's Copter"),
            new SampleCard(1, "Arid Mesa"),
            new SampleCard(4, "Copperline Gorge"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(3, "Stomping Ground"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Avalanche Riders"),
            new SampleCard(1, "Choke"),
            new SampleCard(1, "Collector Ouphe"),
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(1, "Gaddock Teeg"),
            new SampleCard(1, "Klothys, God of Destiny"),
            new SampleCard(2, "Knight of Autumn"),
            new SampleCard(1, "Linvala, Keeper of Silence"),
            new SampleCard(1, "Obstinate Baloth"),
            new SampleCard(1, "Path to Exile"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(1, "Thrun, the Last Troll"),
            new SampleCard(1, "Veil of Summer") 
        };
    }
}