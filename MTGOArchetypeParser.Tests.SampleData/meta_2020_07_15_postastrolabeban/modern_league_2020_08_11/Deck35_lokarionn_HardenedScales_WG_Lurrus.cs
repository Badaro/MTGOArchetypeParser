using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_11
{
    public class Deck35_lokarionn_HardenedScales_WG_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arcbound Ravager"),
            new SampleCard(4, "Arcbound Worker"),
            new SampleCard(4, "Hangarback Walker"),
            new SampleCard(4, "Metallic Mimic"),
            new SampleCard(2, "Steel Overseer"),
            new SampleCard(4, "Walking Ballista"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(2, "Animation Module"),
            new SampleCard(2, "The Ozolith"),
            new SampleCard(2, "Throne of Geth"),
            new SampleCard(2, "Welding Jar"),
            new SampleCard(4, "Hardened Scales"),
            new SampleCard(4, "Brushland"),
            new SampleCard(2, "Forest"),
            new SampleCard(2, "Horizon Canopy"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(1, "Phyrexia's Core"),
            new SampleCard(4, "Razorverge Thicket"),
            new SampleCard(2, "Snow-Covered Forest"),
            new SampleCard(2, "Temple Garden"),
            new SampleCard(1, "Tomb of the Spirit Dragon") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(4, "Kor Firewalker"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(3, "Nature's Claim"),
            new SampleCard(2, "Path to Exile") 
        };
    }
}