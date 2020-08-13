using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_preliminary_2020_06_20
{
    public class Deck09_FrancusAurelius_NayaMidrange_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Ajani Steadfast"),
            new SampleCard(2, "Chandra, Torch of Defiance"),
            new SampleCard(2, "Wrenn and Six"),
            new SampleCard(2, "Birds of Paradise"),
            new SampleCard(4, "Knight of the Reliquary"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(2, "Seasoned Pyromancer"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(4, "Tarmogoyf"),
            new SampleCard(1, "Tireless Tracker"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(4, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Embercleave"),
            new SampleCard(1, "Sword of Feast and Famine"),
            new SampleCard(1, "Blast Zone"),
            new SampleCard(1, "Field of Ruin"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(1, "Kessig Wolf Run"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(1, "Sunbaked Canyon"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(1, "Tranquil Thicket"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Blood Moon"),
            new SampleCard(2, "Boil"),
            new SampleCard(1, "Cindervines"),
            new SampleCard(2, "Collector Ouphe"),
            new SampleCard(2, "Force of Vigor"),
            new SampleCard(1, "Goblin Cratermaker"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Lightning Helix"),
            new SampleCard(1, "Scavenging Ooze") 
        };
    }
}