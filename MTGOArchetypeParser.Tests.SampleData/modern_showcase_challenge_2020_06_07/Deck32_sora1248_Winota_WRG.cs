using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_showcase_challenge_2020_06_07
{
    public class Deck32_sora1248_Winota_WRG : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Angrath's Marauders"),
            new SampleCard(3, "Arbor Elf"),
            new SampleCard(4, "Birds of Paradise"),
            new SampleCard(1, "Eternal Witness"),
            new SampleCard(1, "Magus of the Moon"),
            new SampleCard(4, "Seasoned Pyromancer"),
            new SampleCard(4, "Strangleroot Geist"),
            new SampleCard(3, "Voice of Resurgence"),
            new SampleCard(4, "Winota, Joiner of Forces"),
            new SampleCard(4, "Eldritch Evolution"),
            new SampleCard(3, "Lightning Bolt"),
            new SampleCard(2, "Smuggler's Copter"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(4, "Copperline Gorge"),
            new SampleCard(1, "Razorverge Thicket"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Mountain"),
            new SampleCard(3, "Stomping Ground"),
            new SampleCard(3, "Temple Garden"),
            new SampleCard(4, "Windswept Heath"),
            new SampleCard(4, "Wooded Foothills") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Lightning Bolt"),
            new SampleCard(2, "Avalanche Riders"),
            new SampleCard(1, "Choke"),
            new SampleCard(1, "Gaddock Teeg"),
            new SampleCard(1, "Huntmaster of the Fells"),
            new SampleCard(2, "Knight of Autumn"),
            new SampleCard(1, "Linvala, Keeper of Silence"),
            new SampleCard(3, "Rest in Peace"),
            new SampleCard(3, "Timely Reinforcements") 
        };
    }
}