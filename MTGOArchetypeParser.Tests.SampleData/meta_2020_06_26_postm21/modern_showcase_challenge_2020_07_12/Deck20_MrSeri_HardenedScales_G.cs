using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_showcase_challenge_2020_07_12
{
    public class Deck20_MrSeri_HardenedScales_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arcbound Ravager"),
            new SampleCard(4, "Arcbound Worker"),
            new SampleCard(2, "Crystalline Giant"),
            new SampleCard(4, "Hangarback Walker"),
            new SampleCard(2, "Metallic Mimic"),
            new SampleCard(1, "Steel Overseer"),
            new SampleCard(4, "Walking Ballista"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(3, "Animation Module"),
            new SampleCard(4, "The Ozolith"),
            new SampleCard(2, "Throne of Geth"),
            new SampleCard(4, "Hardened Scales"),
            new SampleCard(4, "Darksteel Citadel"),
            new SampleCard(8, "Forest"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(2, "Llanowar Reborn"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(1, "Phyrexia's Core") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(3, "Dismember"),
            new SampleCard(1, "Grafdigger's Cage"),
            new SampleCard(1, "Karn, Scion of Urza"),
            new SampleCard(3, "Nature's Claim"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(2, "Torpor Orb"),
            new SampleCard(1, "Veil of Summer") 
        };
    }
}