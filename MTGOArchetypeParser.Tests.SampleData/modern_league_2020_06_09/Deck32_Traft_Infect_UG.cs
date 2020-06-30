using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_09
{
    public class Deck32_Traft_Infect_UG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Birds of Paradise"),(4, "Blighted Agent"),(4, "Glistener Elf"),(4, "Noble Hierarch"),(1, "Spellskite"),(2, "Distortion Strike"),(4, "Scale Up"),(1, "Become Immense"),(3, "Blossoming Defense"),(4, "Might of Old Krosa"),(4, "Mutagenic Growth"),(1, "Peek"),(2, "Spell Pierce"),(3, "Vines of Vastwood"),(2, "Rancor"),(2, "Breeding Pool"),(2, "Forest"),(4, "Inkmoth Nexus"),(1, "Misty Rainforest"),(2, "Pendelhaven"),(2, "Verdant Catacombs"),(3, "Waterlogged Grove"),(2, "Windswept Heath"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Ceremonious Rejection"),(2, "Dismember"),(2, "Force of Vigor"),(2, "Mystical Dispute"),(4, "Tarmogoyf"),(3, "Veil of Summer") }; } }
    }
}