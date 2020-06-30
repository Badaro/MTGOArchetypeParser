using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_21
{
    public class Deck09_kbr3_HardenedScales_G : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Arcbound Ravager"),(4, "Arcbound Worker"),(4, "Hangarback Walker"),(4, "Scrapyard Recombiner"),(4, "Walking Ballista"),(2, "Animation Module"),(4, "The Ozolith"),(2, "Throne of Geth"),(4, "Welding Jar"),(4, "Hardened Scales"),(4, "Blinkmoth Nexus"),(2, "Cavern of Souls"),(6, "Forest"),(4, "Inkmoth Nexus"),(4, "Llanowar Reborn"),(2, "Pendelhaven"),(2, "Phyrexia's Core") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Animation Module"),(2, "Dismember"),(4, "Gemrazer"),(2, "Pithing Needle"),(3, "Relic of Progenitus"),(2, "Torpor Orb") }; } }
    }
}