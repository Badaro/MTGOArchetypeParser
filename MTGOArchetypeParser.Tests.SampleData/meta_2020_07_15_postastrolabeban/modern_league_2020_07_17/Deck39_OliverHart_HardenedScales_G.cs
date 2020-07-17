using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_17
{
    public class Deck39_OliverHart_HardenedScales_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arcbound Ravager"),
            new SampleCard(4, "Arcbound Worker"),
            new SampleCard(4, "Hangarback Walker"),
            new SampleCard(4, "Scrapyard Recombiner"),
            new SampleCard(4, "Walking Ballista"),
            new SampleCard(3, "Animation Module"),
            new SampleCard(4, "The Ozolith"),
            new SampleCard(2, "Throne of Geth"),
            new SampleCard(3, "Welding Jar"),
            new SampleCard(4, "Hardened Scales"),
            new SampleCard(3, "Blinkmoth Nexus"),
            new SampleCard(3, "Cavern of Souls"),
            new SampleCard(6, "Forest"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(4, "Llanowar Reborn"),
            new SampleCard(2, "Pendelhaven"),
            new SampleCard(2, "Phyrexia's Core") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Animation Module"),
            new SampleCard(2, "Dismember"),
            new SampleCard(2, "Gemrazer"),
            new SampleCard(4, "Relic of Progenitus"),
            new SampleCard(3, "Torpor Orb"),
            new SampleCard(3, "Veil of Summer") 
        };
    }
}