using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_31
{
    public class Deck29_Jenara19_NayaMidrange_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(3, "Bloodbraid Elf"),
            new SampleCard(2, "Klothys, God of Destiny"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(2, "Seasoned Pyromancer"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(2, "Lightning Bolt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(3, "Mishra's Bauble"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(2, "Seal of Fire"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(1, "Forest"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(3, "Inspiring Vantage"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Plains"),
            new SampleCard(1, "Raging Ravine"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Sunbaked Canyon"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(2, "Wooded Foothills"),
            new SampleCard(3, "Lurrus of the Dream-Den") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Abrade"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(3, "Boil"),
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(2, "Magus of the Moon"),
            new SampleCard(1, "Timely Reinforcements"),
            new SampleCard(2, "Tormod's Crypt") 
        };
    }
}