using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_21
{
    public class Deck61_MartinezDP_NayaMidrange_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Wrenn and Six"),
            new SampleCard(4, "Bloodbraid Elf"),
            new SampleCard(4, "Noble Hierarch"),
            new SampleCard(3, "Renegade Rallier"),
            new SampleCard(2, "Scavenging Ooze"),
            new SampleCard(4, "Stoneforge Mystic"),
            new SampleCard(3, "Tireless Tracker"),
            new SampleCard(4, "Lightning Bolt"),
            new SampleCard(3, "Lightning Helix"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(1, "Batterskull"),
            new SampleCard(1, "Sword of Fire and Ice"),
            new SampleCard(1, "Sword of Light and Shadow"),
            new SampleCard(1, "Copperline Gorge"),
            new SampleCard(3, "Forest"),
            new SampleCard(1, "Ghost Quarter"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(1, "Inspiring Vantage"),
            new SampleCard(1, "Mountain"),
            new SampleCard(2, "Plains"),
            new SampleCard(1, "Razorverge Thicket"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(1, "Stomping Ground"),
            new SampleCard(1, "Sunbaked Canyon"),
            new SampleCard(1, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Blood Moon"),
            new SampleCard(1, "Celestial Purge"),
            new SampleCard(1, "Chandra, Torch of Defiance"),
            new SampleCard(2, "Fiery Justice"),
            new SampleCard(1, "Huntmaster of the Fells"),
            new SampleCard(2, "Knight of Autumn"),
            new SampleCard(1, "Magus of the Moon"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}