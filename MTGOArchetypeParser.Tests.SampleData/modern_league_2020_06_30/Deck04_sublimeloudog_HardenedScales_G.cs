using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck04_sublimeloudog_HardenedScales_G : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Arcbound Ravager"),(4, "Arcbound Worker"),(4, "Hangarback Walker"),(3, "Metallic Mimic"),(3, "Scrapyard Recombiner"),(1, "Steel Overseer"),(4, "Walking Ballista"),(3, "Animation Module"),(3, "The Ozolith"),(2, "Throne of Geth"),(3, "Welding Jar"),(4, "Hardened Scales"),(1, "Blinkmoth Nexus"),(4, "Darksteel Citadel"),(7, "Forest"),(4, "Inkmoth Nexus"),(3, "Llanowar Reborn"),(2, "Nurturing Peatland"),(1, "Pendelhaven") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (3, "Damping Sphere"),(3, "Dismember"),(3, "Grafdigger's Cage"),(3, "Nature's Claim"),(2, "Spellskite"),(1, "Veil of Summer") }; } }
    }
}