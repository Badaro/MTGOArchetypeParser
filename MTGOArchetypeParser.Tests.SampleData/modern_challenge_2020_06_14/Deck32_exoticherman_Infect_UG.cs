using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_14
{
    public class Deck32_exoticherman_Infect_UG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (1, "Birds of Paradise"),(4, "Blighted Agent"),(4, "Glistener Elf"),(4, "Noble Hierarch"),(1, "Spellskite"),(2, "Distortion Strike"),(4, "Scale Up"),(1, "Become Immense"),(2, "Blossoming Defense"),(1, "Dismember"),(2, "Groundswell"),(4, "Might of Old Krosa"),(4, "Mutagenic Growth"),(2, "Spell Pierce"),(4, "Vines of Vastwood"),(2, "Breeding Pool"),(1, "Dryad Arbor"),(2, "Forest"),(4, "Inkmoth Nexus"),(1, "Misty Rainforest"),(2, "Pendelhaven"),(2, "Verdant Catacombs"),(3, "Waterlogged Grove"),(2, "Windswept Heath"),(1, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Spellskite"),(2, "Dismember"),(1, "Ceremonious Rejection"),(3, "Mystical Dispute"),(4, "Tarmogoyf"),(2, "Veil of Summer"),(2, "Wilt") }; } }
    }
}