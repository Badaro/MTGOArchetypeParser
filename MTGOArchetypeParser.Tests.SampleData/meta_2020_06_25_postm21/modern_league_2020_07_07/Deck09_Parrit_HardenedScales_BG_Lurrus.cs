using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_league_2020_07_07
{
    public class Deck09_Parrit_HardenedScales_BG_Lurrus : ISampleDeck
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
            new SampleCard(3, "Mishra's Bauble"),
            new SampleCard(3, "The Ozolith"),
            new SampleCard(1, "Throne of Geth"),
            new SampleCard(1, "Welding Jar"),
            new SampleCard(4, "Hardened Scales"),
            new SampleCard(4, "Blooming Marsh"),
            new SampleCard(2, "Darksteel Citadel"),
            new SampleCard(3, "Forest"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(2, "Llanowar Reborn"),
            new SampleCard(2, "Llanowar Wastes"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(1, "Phyrexia's Core"),
            new SampleCard(1, "Snow-Covered Swamp"),
            new SampleCard(1, "Urborg, Tomb of Yawgmoth") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Lurrus of the Dream-Den"),
            new SampleCard(2, "Nature's Claim"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(1, "Tormod's Crypt"),
            new SampleCard(1, "Torpor Orb"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}