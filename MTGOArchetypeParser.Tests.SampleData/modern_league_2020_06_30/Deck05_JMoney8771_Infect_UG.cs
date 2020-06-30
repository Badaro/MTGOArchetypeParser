using MTGOArchetypeParser.Tests.SampleData;

namespace MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_30
{
    public class Deck05_JMoney8771_Infect_UG : ISampleDeck
    {
        public (int Count, string Name)[] Mainboard { get { return new (int Count, string Name)[] { (4, "Blighted Agent"),(4, "Glistener Elf"),(4, "Noble Hierarch"),(2, "Spellskite"),(2, "Distortion Strike"),(4, "Scale Up"),(1, "Become Immense"),(4, "Blossoming Defense"),(2, "Dismember"),(3, "Groundswell"),(4, "Might of Old Krosa"),(2, "Spell Pierce"),(4, "Vines of Vastwood"),(2, "Breeding Pool"),(1, "Dryad Arbor"),(2, "Forest"),(4, "Inkmoth Nexus"),(2, "Pendelhaven"),(4, "Waterlogged Grove"),(4, "Windswept Heath"),(1, "Wooded Foothills") }; } }
        public (int Count, string Name)[] Sideboard { get { return new (int Count, string Name)[] { (1, "Spellskite"),(1, "Dismember"),(3, "Force of Vigor"),(2, "Grafdigger's Cage"),(2, "Miscast"),(2, "Mystical Dispute"),(4, "Veil of Summer") }; } }
    }
}