using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_25
{
    public class Deck14_Papelucho10_Infect_UG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Blighted Agent"),(4, "Glistener Elf"),(4, "Noble Hierarch"),(1, "Spellskite"),(3, "Distortion Strike"),(4, "Scale Up"),(4, "Blossoming Defense"),(3, "Groundswell"),(4, "Might of Old Krosa"),(4, "Mutagenic Growth"),(2, "Spell Pierce"),(4, "Vines of Vastwood"),(2, "Breeding Pool"),(3, "Inkmoth Nexus"),(1, "Pendelhaven"),(3, "Snow-Covered Forest"),(1, "Verdant Catacombs"),(3, "Waterlogged Grove"),(4, "Windswept Heath"),(2, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (2, "Spellskite"),(1, "Dismember"),(2, "Force of Vigor"),(3, "Mystical Dispute"),(1, "Nature's Claim"),(1, "Piracy Charm"),(1, "Return to Nature"),(1, "Slip Through Space"),(3, "Veil of Summer") }; } }
    }
}