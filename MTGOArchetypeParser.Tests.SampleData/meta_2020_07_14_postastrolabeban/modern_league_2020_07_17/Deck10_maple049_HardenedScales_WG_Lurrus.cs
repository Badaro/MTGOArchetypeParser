using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_07_17
{
    public class Deck10_maple049_HardenedScales_WG_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arcbound Ravager"),
            new SampleCard(4, "Arcbound Worker"),
            new SampleCard(4, "Hangarback Walker"),
            new SampleCard(4, "Walking Ballista"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(3, "Path to Exile"),
            new SampleCard(3, "Animation Module"),
            new SampleCard(2, "Springleaf Drum"),
            new SampleCard(4, "The Ozolith"),
            new SampleCard(1, "Throne of Geth"),
            new SampleCard(4, "Hardened Scales"),
            new SampleCard(1, "Blinkmoth Nexus"),
            new SampleCard(4, "Brushland"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(2, "Llanowar Reborn"),
            new SampleCard(2, "Phyrexia's Core"),
            new SampleCard(3, "Razorverge Thicket"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(1, "Snow-Covered Plains"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(2, "Windswept Heath") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Path to Exile"),
            new SampleCard(2, "Burrenton Forge-Tender"),
            new SampleCard(2, "Ethersworn Canonist"),
            new SampleCard(3, "Gemrazer"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(1, "Nature's Claim"),
            new SampleCard(2, "Tormod's Crypt"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}