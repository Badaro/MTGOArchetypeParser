using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_04_postcompanionchange.modern_league_2020_06_23
{
    public class Deck48_cjucjujp_HardenedScales_BG_Lurrus : ISampleDeck
    {
        public ISampleCard[] Mainboard => new ISampleCard[] 
        { 
            new SampleCard(4, "Arcbound Ravager"),
            new SampleCard(4, "Arcbound Worker"),
            new SampleCard(4, "Hangarback Walker"),
            new SampleCard(3, "Metallic Mimic"),
            new SampleCard(4, "Walking Ballista"),
            new SampleCard(4, "Ancient Stirrings"),
            new SampleCard(3, "Animation Module"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(4, "The Ozolith"),
            new SampleCard(1, "Throne of Geth"),
            new SampleCard(1, "Welding Jar"),
            new SampleCard(4, "Hardened Scales"),
            new SampleCard(1, "Blinkmoth Nexus"),
            new SampleCard(4, "Blooming Marsh"),
            new SampleCard(2, "Darksteel Citadel"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(2, "Llanowar Reborn"),
            new SampleCard(4, "Llanowar Wastes"),
            new SampleCard(1, "Phyrexia's Core"),
            new SampleCard(3, "Snow-Covered Forest"),
            new SampleCard(2, "Swamp") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(2, "Duress"),
            new SampleCard(4, "Fatal Push"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(1, "Nature's Claim"),
            new SampleCard(1, "Seal of Primordium"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}