using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_challenge_2020_06_29
{
    public class Deck06_OYU_Infect_UG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Blighted Agent"),(4, "Glistener Elf"),(4, "Noble Hierarch"),(1, "Spellskite"),(2, "Distortion Strike"),(3, "Scale Up"),(1, "Sylvan Scrying"),(1, "Become Immense"),(3, "Blossoming Defense"),(3, "Groundswell"),(4, "Might of Old Krosa"),(4, "Mutagenic Growth"),(1, "Spell Pierce"),(4, "Vines of Vastwood"),(2, "Breeding Pool"),(1, "Dryad Arbor"),(2, "Forest"),(4, "Inkmoth Nexus"),(1, "Misty Rainforest"),(2, "Pendelhaven"),(2, "Verdant Catacombs"),(3, "Waterlogged Grove"),(2, "Windswept Heath"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Spellskite"),(1, "Spell Pierce"),(1, "Aether Gust"),(2, "Dismember"),(1, "Nature's Claim"),(1, "Pithing Needle"),(4, "Tarmogoyf"),(2, "Veil of Summer"),(2, "Wilt") }; } }
    }
}