using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_league_2020_07_10
{
    public class Deck13_Parrit_HardenedScales_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arcbound Ravager"),
            new SampleCard(4, "Arcbound Worker"),
            new SampleCard(4, "Hangarback Walker"),
            new SampleCard(4, "Scrapyard Recombiner"),
            new SampleCard(4, "Walking Ballista"),
            new SampleCard(2, "Animation Module"),
            new SampleCard(4, "The Ozolith"),
            new SampleCard(2, "Throne of Geth"),
            new SampleCard(4, "Welding Jar"),
            new SampleCard(4, "Hardened Scales"),
            new SampleCard(1, "Blinkmoth Nexus"),
            new SampleCard(4, "Darksteel Citadel"),
            new SampleCard(5, "Forest"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(4, "Llanowar Reborn"),
            new SampleCard(1, "Pendelhaven"),
            new SampleCard(2, "Phyrexia's Core"),
            new SampleCard(3, "Snow-Covered Forest") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Animation Module"),
            new SampleCard(2, "Dismember"),
            new SampleCard(4, "Gemrazer"),
            new SampleCard(2, "Pithing Needle"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(2, "Torpor Orb") 
        };
    }
}