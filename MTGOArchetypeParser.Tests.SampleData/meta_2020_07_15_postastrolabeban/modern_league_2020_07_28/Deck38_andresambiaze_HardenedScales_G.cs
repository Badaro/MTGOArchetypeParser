using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_07_15_postastrolabeban.modern_league_2020_07_28
{
    public class Deck38_andresambiaze_HardenedScales_G : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arcbound Ravager"),
            new SampleCard(4, "Arcbound Worker"),
            new SampleCard(4, "Hangarback Walker"),
            new SampleCard(3, "Scrapyard Recombiner"),
            new SampleCard(4, "Walking Ballista"),
            new SampleCard(4, "Animation Module"),
            new SampleCard(4, "The Ozolith"),
            new SampleCard(2, "Throne of Geth"),
            new SampleCard(3, "Welding Jar"),
            new SampleCard(4, "Hardened Scales"),
            new SampleCard(3, "Blinkmoth Nexus"),
            new SampleCard(3, "Cavern of Souls"),
            new SampleCard(7, "Forest"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(4, "Llanowar Reborn"),
            new SampleCard(2, "Pendelhaven"),
            new SampleCard(1, "Phyrexia's Core") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(3, "Damping Sphere"),
            new SampleCard(2, "Dismember"),
            new SampleCard(3, "Gemrazer"),
            new SampleCard(3, "Relic of Progenitus"),
            new SampleCard(2, "Torpor Orb"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}