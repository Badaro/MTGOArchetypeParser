using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_10
{
    public class Deck15_Phyziks42_Ponza_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arbor Elf"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(2, "Elder Gargaroth"),
            new SampleCard(3, "Klothys, God of Destiny"),
            new SampleCard(4, "Magus of the Moon"),
            new SampleCard(1, "Questing Beast"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(3, "Seasoned Pyromancer"),
            new SampleCard(3, "Stoneforge Mystic"),
            new SampleCard(2, "Terror of the Peaks"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of War and Peace"),
            new SampleCard(4, "Utopia Sprawl"),
            new SampleCard(3, "Arid Mesa"),
            new SampleCard(4, "Forest"),
            new SampleCard(2, "Mountain"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(2, "Snow-Covered Plains"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Choke"),
            new SampleCard(2, "Leyline of Sanctity"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Sweltering Suns"),
            new SampleCard(2, "Veil of Summer"),
            new SampleCard(2, "Weather the Storm") 
        };
    }
}