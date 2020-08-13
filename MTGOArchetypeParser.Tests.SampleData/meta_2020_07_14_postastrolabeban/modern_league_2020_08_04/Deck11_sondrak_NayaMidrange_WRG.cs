using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_04
{
    public class Deck11_sondrak_NayaMidrange_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Wrenn and Six"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(2, "Klothys, God of Destiny"),
            new SampleCard(2, "Magus of the Moon"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(3, "Chromatic Star"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(2, "Arid Mesa"),
            new SampleCard(2, "Forest"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(1, "Inspiring Vantage"),
            new SampleCard(1, "Mountain"),
            new SampleCard(1, "Plains"),
            new SampleCard(1, "Raging Ravine"),
            new SampleCard(2, "Sacred Foundry"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(1, "Sunbaked Canyon"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(3, "Windswept Heath"),
            new SampleCard(1, "Wooded Bastion"),
            new SampleCard(2, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Anger of the Gods"),
            new SampleCard(2, "Blood Moon"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(2, "Choke"),
            new SampleCard(1, "Cindervines"),
            new SampleCard(1, "Kor Firewalker"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(1, "Rest in Peace"),
            new SampleCard(1, "Shattering Spree"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}