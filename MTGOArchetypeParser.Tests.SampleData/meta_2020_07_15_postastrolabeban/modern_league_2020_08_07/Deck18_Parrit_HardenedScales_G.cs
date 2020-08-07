using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_08_07
{
    public class Deck18_Parrit_HardenedScales_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arcbound Ravager"),
            new SampleCard(4, "Arcbound Worker"),
            new SampleCard(4, "Hangarback Walker"),
            new SampleCard(2, "Metallic Mimic"),
            new SampleCard(2, "Scrapyard Recombiner"),
            new SampleCard(1, "Steel Overseer"),
            new SampleCard(4, "Walking Ballista"),
            new SampleCard(2, "Ancient Stirrings"),
            new SampleCard(3, "Animation Module"),
            new SampleCard(4, "The Ozolith"),
            new SampleCard(2, "Throne of Geth"),
            new SampleCard(4, "Hardened Scales"),
            new SampleCard(1, "Cavern of Souls"),
            new SampleCard(2, "Darksteel Citadel"),
            new SampleCard(5, "Forest"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(4, "Llanowar Reborn"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(2, "Phyrexia's Core"),
            new SampleCard(3, "Snow-Covered Forest") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Damping Sphere"),
            new SampleCard(3, "Dismember"),
            new SampleCard(3, "Gemrazer"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(1, "Torpor Orb"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}