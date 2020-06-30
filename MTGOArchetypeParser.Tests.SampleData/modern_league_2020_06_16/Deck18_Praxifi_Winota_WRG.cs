using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_16
{
    public class Deck18_Praxifi_Winota_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Angrath's Marauders"),
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(2, "Goblin Rabblemaster"),
            new SampleCard(4, "Llanowar Elves"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Strangleroot Geist"),
            new SampleCard(3, "Voice of Resurgence"),
            new SampleCard(4, "Winota, Joiner of Forces"),
            new SampleCard(4, "Eldritch Evolution"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(2, "Smuggler's Copter"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(4, "Copperline Gorge"),
            new SampleCard(1, "Horizon Canopy"),
            new SampleCard(1, "Razorverge Thicket"),
            new SampleCard(1, "Sacred Foundry"),
            new SampleCard(1, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(2, "Stomping Ground"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Avalanche Riders"),
            new SampleCard(2, "Choke"),
            new SampleCard(1, "Gaddock Teeg"),
            new SampleCard(1, "Knight of Autumn"),
            new SampleCard(2, "Path to Exile"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(3, "Timely Reinforcements") 
        };
    }
}