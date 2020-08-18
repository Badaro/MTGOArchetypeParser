using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_18
{
    public class Deck50_Xenowan_HardenedScales_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arcbound Ravager"),
            new SampleCard(4, "Arcbound Worker"),
            new SampleCard(4, "Hangarback Walker"),
            new SampleCard(3, "Metallic Mimic"),
            new SampleCard(2, "Scrapyard Recombiner"),
            new SampleCard(4, "Walking Ballista"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(3, "Animation Module"),
            new SampleCard(4, "The Ozolith"),
            new SampleCard(2, "Throne of Geth"),
            new SampleCard(4, "Hardened Scales"),
            new SampleCard(3, "Darksteel Citadel"),
            new SampleCard(8, "Forest"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(3, "Llanowar Reborn"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(1, "Phyrexia's Core") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(3, "Dismember"),
            new SampleCard(3, "Gemrazer"),
            new SampleCard(2, "Grafdigger's Cage"),
            new SampleCard(2, "Relic of Progenitus"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}