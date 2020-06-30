using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_20
{
    public class Deck05_Papelucho10_Infect_UG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (3, "Blighted Agent"),(4, "Glistener Elf"),(4, "Noble Hierarch"),(1, "Spellskite"),(2, "Distortion Strike"),(4, "Scale Up"),(1, "Become Immense"),(4, "Blossoming Defense"),(4, "Groundswell"),(4, "Might of Old Krosa"),(3, "Mutagenic Growth"),(2, "Spell Pierce"),(4, "Vines of Vastwood"),(2, "Breeding Pool"),(4, "Inkmoth Nexus"),(1, "Pendelhaven"),(3, "Snow-Covered Forest"),(3, "Waterlogged Grove"),(4, "Windswept Heath"),(3, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Spellskite"),(1, "Ceremonious Rejection"),(1, "Contentious Plan"),(2, "Force of Vigor"),(3, "Mystical Dispute"),(1, "Nature's Claim"),(1, "Return to Nature"),(1, "Sylvan Scrying"),(3, "Veil of Summer") }; } }
    }
}