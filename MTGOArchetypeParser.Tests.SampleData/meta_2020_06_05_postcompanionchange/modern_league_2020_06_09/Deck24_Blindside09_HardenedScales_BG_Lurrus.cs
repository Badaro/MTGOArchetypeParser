using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.meta_2020_06_05_postcompanionchange.modern_league_2020_06_09
{
    public class Deck24_Blindside09_HardenedScales_BG_Lurrus : ISampleDeck
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
            new SampleCard(3, "Darksteel Citadel"),
            new SampleCard(3, "Forest"),
            new SampleCard(4, "Inkmoth Nexus"),
            new SampleCard(2, "Llanowar Reborn"),
            new SampleCard(1, "Llanowar Wastes"),
            new SampleCard(2, "Nurturing Peatland"),
            new SampleCard(1, "Phyrexia's Core"),
            new SampleCard(1, "Swamp"),
            new SampleCard(1, "Urborg, Tomb of Yawgmoth") 
        };
        public ISampleCard[] Sideboard => new ISampleCard[] 
        { 
            new SampleCard(2, "Damping Sphere"),
            new SampleCard(3, "Fatal Push"),
            new SampleCard(1, "Lurrus of the Dream Den"),
            new SampleCard(1, "Nihil Spellbomb"),
            new SampleCard(2, "Seal of Primordium"),
            new SampleCard(2, "Thoughtseize"),
            new SampleCard(2, "Tormod's Crypt"),
            new SampleCard(2, "Veil of Summer") 
        };
    }
}