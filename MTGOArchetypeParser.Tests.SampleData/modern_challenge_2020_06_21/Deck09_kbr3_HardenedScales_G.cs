using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21
{
    public class Deck09_kbr3_HardenedScales_G : ISampleDeck
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
            new SampleCard(4, "Blinkmoth Nexus"),
            new SampleCard(2, "Cavern of Souls"),
            new SampleCard(6, "Forest"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(4, "Llanowar Reborn"),
            new SampleCard(2, "Pendelhaven"),
            new SampleCard(2, "Phyrexia's Core") 
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