using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_showcase_challenge_2020_06_07
{
    public class Deck13_SpiderSpace_HardenedScales_G : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Arcbound Ravager"),(4, "Arcbound Worker"),(4, "Hangarback Walker"),(3, "Metallic Mimic"),(2, "Scrapyard Recombiner"),(1, "Steel Overseer"),(4, "Walking Ballista"),(4, "Ancient Stirrings"),(3, "Animation Module"),(3, "The Ozolith"),(1, "Throne of Geth"),(2, "Welding Jar"),(4, "Hardened Scales"),(4, "Darksteel Citadel"),(7, "Forest"),(4, "Inkmoth Nexus"),(2, "Llanowar Reborn"),(2, "Nurturing Peatland"),(1, "Pendelhaven"),(1, "Phyrexia's Core") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Damping Sphere"),(3, "Dismember"),(3, "Grafdigger's Cage"),(2, "Karn, Scion of Urza"),(2, "Nature's Claim"),(2, "Veil of Summer") }; } }
    }
}