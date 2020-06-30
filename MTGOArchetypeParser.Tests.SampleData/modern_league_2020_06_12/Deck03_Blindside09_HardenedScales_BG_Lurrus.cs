using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_12
{
    public class Deck03_Blindside09_HardenedScales_BG_Lurrus : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Arcbound Ravager"),(4, "Arcbound Worker"),(4, "Hangarback Walker"),(3, "Metallic Mimic"),(4, "Walking Ballista"),(4, "Ancient Stirrings"),(3, "Animation Module"),(3, "Mishra's Bauble"),(3, "The Ozolith"),(1, "Throne of Geth"),(1, "Welding Jar"),(4, "Hardened Scales"),(4, "Blooming Marsh"),(2, "Darksteel Citadel"),(3, "Forest"),(4, "Inkmoth Nexus"),(2, "Llanowar Reborn"),(2, "Llanowar Wastes"),(2, "Nurturing Peatland"),(1, "Phyrexia's Core"),(1, "Swamp"),(1, "Urborg, Tomb of Yawgmoth") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Damping Sphere"),(3, "Fatal Push"),(1, "Lurrus of the Dream Den"),(1, "Nature's Claim"),(1, "Nihil Spellbomb"),(1, "Seal of Primordium"),(2, "Thoughtseize"),(1, "Tormod's Crypt"),(1, "Torpor Orb"),(2, "Veil of Summer") }; } }
    }
}