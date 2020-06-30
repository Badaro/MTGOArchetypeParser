using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck23_roterErzengel_Infect_WUG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Teferi, Time Raveler"),(4, "Blighted Agent"),(4, "Glistener Elf"),(4, "Noble Hierarch"),(1, "Spellskite"),(2, "Distortion Strike"),(4, "Scale Up"),(1, "Become Immense"),(3, "Blossoming Defense"),(1, "Dismember"),(4, "Groundswell"),(4, "Might of Old Krosa"),(2, "Mutagenic Growth"),(2, "Spell Pierce"),(3, "Vines of Vastwood"),(2, "Breeding Pool"),(2, "Forest"),(1, "Horizon Canopy"),(4, "Inkmoth Nexus"),(1, "Misty Rainforest"),(2, "Pendelhaven"),(1, "Temple Garden"),(2, "Waterlogged Grove"),(3, "Windswept Heath"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Ceremonious Rejection"),(1, "Grafdigger's Cage"),(2, "Mystical Dispute"),(3, "Nature's Claim"),(2, "Path to Exile"),(1, "Pulse of Murasa"),(2, "Relic of Progenitus"),(3, "Veil of Summer") }; } }
    }
}