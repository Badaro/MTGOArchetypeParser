using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_showcase_challenge_2020_06_07
{
    public class Deck13_SpiderSpace_HardenedScales_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arcbound Ravager"),
            new SampleCard(4, "Arcbound Worker"),
            new SampleCard(4, "Hangarback Walker"),
            new SampleCard(3, "Metallic Mimic"),
            new SampleCard(2, "Scrapyard Recombiner"),
            new SampleCard(1, "Steel Overseer"),
            new SampleCard(4, "Walking Ballista"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(3, "Animation Module"),
            new SampleCard(3, "The Ozolith"),
            new SampleCard(1, "Throne of Geth"),
            new SampleCard(2, "Welding Jar"),
            new SampleCard(4, "Hardened Scales"),
            new SampleCard(4, "Darksteel Citadel"),
            new SampleCard(7, "Forest"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(2, "Llanowar Reborn"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(1, "Phyrexia's Core") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(3, "Dismember"),
            new SampleCard(3, "Grafdigger's Cage"),
            new SampleCard(2, "Karn, Scion of Urza"),
            new SampleCard(2, "Nature's Claim"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}